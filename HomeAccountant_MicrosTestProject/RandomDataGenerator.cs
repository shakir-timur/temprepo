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
        public static void Generate(string profile, IDataConnection data)
        {
            var cats = data.GetCategories(profile).ToList();

            for (int i = 0; i < 10000; i++)
            {
                string comment = adverbs[random.Next(adverbs.Length)] + " " + nouns[random.Next(nouns.Length)];
                DateTime date = DateTime.Now.Date - TimeSpan.FromDays(random.Next(1000));
                double price = random.NextDouble() * 1000_000;
                price = Math.Round(price, 2);
                PurchaseCategory cat = cats[random.Next(cats.Count)];

                ExpenceRecord r = new ExpenceRecord() { Category = cat, Comment = comment, Price = (decimal)price, PurchaseDate = date };
                data.InsertExpenseRecord(profile, r);
            }
        }

        static string[] nouns = new string[] { "Роллтон", "Сапог", "Банан", "Носок", "Сыр", "Зонт", "Цветок", "Спирт", "Напиток", "Хлеб", "Батон" };
        static string[] adverbs = new string[] { "Дорогой", "Дешевый", "Свежий", "Непонятный", "Китайский", "Местный" };
    }
}
