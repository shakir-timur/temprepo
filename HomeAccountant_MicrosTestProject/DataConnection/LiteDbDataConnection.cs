using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.IO;

namespace HomeAccountant_MicrosTestProject.DataConnection
{
    class LiteDbDataConnection : IDbDataConnection
    {
        const string profileDbName = "profiles.db";
        const string profilesTable = "profiles";
        const string expenceCategories = "expence";
        const string incomeCategories = "income";
        const string recordsTable = "records";
        const string profileDirName = "Profiles";

        LiteDatabase profileDb;
        LiteDatabase recordsDb;

        ILiteCollection<UserProfile> Profiles => profileDb?.GetCollection<UserProfile>(profilesTable);

        public LiteDbDataConnection(string userProfileName = null)
        {
            profileDb = new LiteDatabase(Path.Combine(".", profileDbName));

            Directory.CreateDirectory(Path.Combine(".", profileDirName));

            if (userProfileName != null)
            {
                var profile = Profiles.FindOne(p => p.UserName == userProfileName);
                var uid = profile.UserUID;

                recordsDb = new LiteDatabase(Path.Combine(".", profileDirName, uid));
            }
        }


        public IEnumerable<UserProfile> GetUserProfiles()
        {
            return Profiles.FindAll();
        }

        public bool CreateUserProfile(string userProfileName, string[] defaultExpenceCategories, string[] defaultIncomeCategories)
        {
            var profile = new UserProfile()
            {
                UserName = userProfileName,
                UserUID = Guid.NewGuid().ToString()
            };

            Profiles.Insert(profile);

            recordsDb = new LiteDatabase(Path.Combine(".", profileDirName, profile.UserUID));

            recordsDb.GetCollection<RecordCategory>(expenceCategories).InsertBulk(defaultExpenceCategories.Select(cat => new RecordCategory() { Name = cat }));
            recordsDb.GetCollection<RecordCategory>(incomeCategories).InsertBulk(defaultIncomeCategories.Select(cat => new RecordCategory() { Name = cat }));

            return true;
        }

        public bool DeleteUserProfile(string userProfileName)
        {
            var profile = Profiles.FindOne(p => p.UserName == userProfileName);

            recordsDb?.Dispose();

            File.Delete(Path.Combine(".", profileDirName, profile.UserUID));

            return Profiles.Delete(profile.Id);
        }

        public IEnumerable<AccountRecord> GetAccountRecords(string userProfileName, DateTime start, DateTime end)
        {
            var records = recordsDb.GetCollection<AccountRecord>(recordsTable);

            return records.Query().Where(r => r.RecordDate >= start && r.RecordDate < end).ToEnumerable();
        }

        public int InsertAccountRecord(string userProfileName, AccountRecord record)
        {
            return recordsDb.GetCollection<AccountRecord>(recordsTable).Insert(record);
        }

        public int InsertBulkRecords(string userProfileName, IEnumerable<AccountRecord> records)
        {
            return recordsDb.GetCollection<AccountRecord>(recordsTable).InsertBulk(records);
        }

        public bool UpdateAccountRecord(string userProfileName, AccountRecord record)
        {
            return recordsDb.GetCollection<AccountRecord>(recordsTable).Update(record);
        }

        public bool RemoveAccountRecord(string userProfileName, AccountRecord record)
        {
            return recordsDb.GetCollection<AccountRecord>(recordsTable).Delete(record.Id);
        }

        public void Dispose()
        {
            profileDb?.Dispose();
            recordsDb?.Dispose();
        }

        public IEnumerable<RecordCategory> GetIncomeCategories(string userProfileName)
        {
            var categories = recordsDb.GetCollection<RecordCategory>(incomeCategories);
            return categories.FindAll();
        }

        public IEnumerable<RecordCategory> GetExpenceCategories(string userProfileName)
        {
            var categories = recordsDb.GetCollection<RecordCategory>(expenceCategories);
            return categories.FindAll();
        }

        public int InsertIncomeCategory(string userProfileName, RecordCategory category)
        {
            return recordsDb.GetCollection<RecordCategory>(incomeCategories).Insert(category);
        }

        public int InsertExpenceCategory(string userProfileName, RecordCategory category)
        {
            return recordsDb.GetCollection<RecordCategory>(expenceCategories).Insert(category);
        }

        public bool RemoveCategory(string userProfileName, RecordCategory category)
        {
            if (recordsDb.GetCollection<RecordCategory>(expenceCategories).Exists(c => c.Id == category.Id && c.Name == category.Name))
            {
                return recordsDb.GetCollection<RecordCategory>(expenceCategories).Delete(category.Id);
            }
            if (recordsDb.GetCollection<RecordCategory>(incomeCategories).Exists(c => c.Id == category.Id && c.Name == category.Name))
            {
                return recordsDb.GetCollection<RecordCategory>(incomeCategories).Delete(category.Id);
            }

            return false;
        }

    }
}
