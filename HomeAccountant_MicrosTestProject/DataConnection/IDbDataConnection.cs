using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;

namespace HomeAccountant_MicrosTestProject.DataConnection
{
    public interface IDbDataConnection : IDisposable
    {
        bool CreateUserProfile(string userProfileName, string[] defaultExpenceCategories, string[] defaultIncomeCategories);
        bool DeleteUserProfile(string userProfileName);
        IEnumerable<AccountRecord> GetAccountRecords(string userProfileName, DateTime start, DateTime end);
        IEnumerable<RecordCategory> GetExpenceCategories(string userProfileName);
        IEnumerable<RecordCategory> GetIncomeCategories(string userProfileName);
        IEnumerable<UserProfile> GetUserProfiles();
        int InsertAccountRecord(string userProfileName, AccountRecord record);
        int InsertBulkRecords(string userProfileName, IEnumerable<AccountRecord> records);
        int InsertExpenceCategory(string userProfileName, RecordCategory category);
        int InsertIncomeCategory(string userProfileName, RecordCategory category);
        bool RemoveAccountRecord(string userProfileName, AccountRecord record);
        bool RemoveCategory(string userProfileName, RecordCategory category);
        bool UpdateAccountRecord(string userProfileName, AccountRecord record);
    }
}