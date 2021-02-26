using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant_MicrosTestProject.DataModel
{
    public class AccountRecord
    {
        public int Id { get; set; }
        public AccountRecordType RecordType { get; set; }
        public RecordCategory Category { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public DateTime RecordDate { get; set; }
    }

    public enum AccountRecordType
    { 
        Expence,
        Income
    }

}
