using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant_MicrosTestProject.DataConnection
{
    public interface IDataConnection : IDisposable
    {
        IEnumerable<UserProfile> GetUserProfiles();

        bool CreateUserProfile(string userProfileName, string[] defaultCategories);

        bool DeleteUserProfile(string userProfileName);

        IEnumerable<ExpenceRecord> GetExpenceRecords(string userProfileName, DateTime start, DateTime end);

        int InsertExpenseRecord(string userProfileName, ExpenceRecord record);

        bool UpdateExpenceRecord(string userProfileName, ExpenceRecord record);

        bool RemoveExpenceRecord(string userProfileName, ExpenceRecord record);

        IEnumerable<PurchaseCategory> GetCategories(string userProfileName);

        int InsertCategory(string userProfileName, PurchaseCategory category);

        bool RemoveCategory(string userProfileName, PurchaseCategory category);
    }
}
