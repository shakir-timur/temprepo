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
    class LiteDbDataConnection : IDataConnection
    {
        const string profileDbName = "profiles.db";
        const string profilesTable = "profiles";
        const string categoryTable = "categories";
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

        public bool CreateUserProfile(string userProfileName, string[] defaultCategories)
        {
            var profile = new UserProfile()
            {
                UserName = userProfileName,
                UserUID = Guid.NewGuid().ToString()
            };

            Profiles.Insert(profile);

            recordsDb = new LiteDatabase(Path.Combine(".", profileDirName, profile.UserUID));

            recordsDb.GetCollection<PurchaseCategory>(categoryTable).InsertBulk(defaultCategories.Select(cat => new PurchaseCategory() { Name = cat }));

            return true;
        }

        public bool DeleteUserProfile(string userProfileName)
        {
            var profile = Profiles.FindOne(p => p.UserName == userProfileName);

            recordsDb?.Dispose();

            File.Delete(Path.Combine(".", profileDirName, profile.UserUID));

            return Profiles.Delete(profile.Id);
        }

        public IEnumerable<ExpenceRecord> GetExpenceRecords(string userProfileName, DateTime start, DateTime end)
        {
            var records = recordsDb.GetCollection<ExpenceRecord>(recordsTable);

            return records.Query().Where(r => r.PurchaseDate >= start && r.PurchaseDate < end).ToEnumerable();
        }

        public int InsertExpenseRecord(string userProfileName, ExpenceRecord record)
        {
            return recordsDb.GetCollection<ExpenceRecord>(recordsTable).Insert(record);
        }

        public bool UpdateExpenceRecord(string userProfileName, ExpenceRecord record)
        {
            return recordsDb.GetCollection<ExpenceRecord>(recordsTable).Update(record);
        }

        public bool RemoveExpenceRecord(string userProfileName, ExpenceRecord record)
        {
            return recordsDb.GetCollection<ExpenceRecord>(recordsTable).Delete(record.Id);
        }

        public void Dispose()
        {
            profileDb?.Dispose();
            recordsDb?.Dispose();
        }

        public IEnumerable<PurchaseCategory> GetCategories(string userProfileName)
        {
            var categories = recordsDb.GetCollection<PurchaseCategory>(categoryTable);
            return categories.FindAll();
        }

        public int InsertCategory(string userProfileName, PurchaseCategory category)
        {
            return recordsDb.GetCollection<PurchaseCategory>(categoryTable).Insert(category);
        }

        public bool RenameCategory(string userProfileName, PurchaseCategory category, string newCategoryName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCategory(string userProfileName, PurchaseCategory category)
        {
            return recordsDb.GetCollection<PurchaseCategory>(categoryTable).Delete(category.Id);
        }

        
    }
}
