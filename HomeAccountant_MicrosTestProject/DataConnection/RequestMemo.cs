using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant_MicrosTestProject.DataConnection
{
    class RequestMemo
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public bool ShowAll { get; set; }
        public bool GroupBy { get; set; }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            RequestMemo memo = obj as RequestMemo;

            return Start == memo.Start && Stop == memo.Stop && ShowAll == memo.ShowAll && GroupBy == memo.GroupBy;
        }
        public override int GetHashCode()
        {
            return Start.GetHashCode() + Stop.GetHashCode() + GroupBy.GetHashCode() + ShowAll.GetHashCode();
        }
    }
}
