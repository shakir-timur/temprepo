using HomeAccountant_MicrosTestProject.DataConnection;
using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountant_MicrosTestProject
{
    static class RandomDataGenerator
    {
        static Random random = new Random();
        public static void Generate(string profile, IDbDataConnection data)
        {
            var ecats = data.GetExpenceCategories(profile).ToList();
            var icats = data.GetIncomeCategories(profile).ToList();

            var rlist = new List<AccountRecord>(10000);
            for (int i = 0; i < 10_000; i++)
            {
                string comment = adverbs[random.Next(adverbs.Length)] + " " + nouns[random.Next(nouns.Length)];
                DateTime date = DateTime.Now.Date - TimeSpan.FromDays(random.Next(1000));
                double price = random.NextDouble() * 1000_000;
                price = Math.Round(price, 2);
                AccountRecordType type = (AccountRecordType)random.Next(2);
                RecordCategory cat;
                if (type == AccountRecordType.Expence)
                    cat = ecats[random.Next(ecats.Count)];
                else
                    cat = icats[random.Next(icats.Count)];

                AccountRecord r = new AccountRecord()
                {
                    RecordType = type,
                    Category = cat,
                    Comment = comment,
                    Amount = (decimal)price,
                    RecordDate = date
                };
                rlist.Add(r);
            }

            if (data is LiteDbDataConnection c)
            {
                c.InsertBulkRecords(profile, rlist);
            }
            else
            {
                foreach (var r in rlist)
                {
                    data.InsertAccountRecord(profile, r);
                }
            }
        }
        static string[] nouns = new string[] { "Роллтон", "Сапог", "Банан", "Носок", "Сыр", "Зонт", "Цветок", "Спирт", "Напиток", "Хлеб", "Батон" };
        static string[] adverbs = new string[] { "Дорогой", "Дешевый", "Свежий", "Непонятный", "Китайский", "Местный" };
    }
}
