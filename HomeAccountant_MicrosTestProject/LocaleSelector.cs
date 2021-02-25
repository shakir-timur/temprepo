using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccountant_MicrosTestProject
{
    internal static class LocaleSelector
    {
        static Dictionary<string, CultureInfo> locales;

        static LocaleSelector()
        {
            string ruRU = "ru-RU";

            var ruLocale = new CultureInfo(ruRU);
            var enLocale = CultureInfo.InvariantCulture;

            locales = new Dictionary<string, CultureInfo>()
            {
                ["En"] = enLocale,
                [ruRU] = ruLocale
            };
        }

        public static string CurrentResourceCultureName => string.IsNullOrEmpty(Locale.ResourceCultureName) ? 
            "En" : Locale.ResourceCultureName;
        public static IEnumerable<string> Locales => locales.Keys.ToList();

        public static void SetLocale(string localeName)
        {
            if (locales.ContainsKey(localeName))
            {
                Locale.Culture = locales[localeName];
            }
            else
            {
#if DEBUG
                throw new ArgumentException("Locale not found");
#else
                MessageBox.Show("Error while setting the locale");
#endif
            }
        }

        internal static void SetComboboxDataSource(ComboBox languageComboBox, EventHandler langComboBoxSelectedIndexChanged)
        {
            if (languageComboBox.DataSource is null)
            {
                languageComboBox.DataSource = LocaleSelector.Locales;
                languageComboBox.SelectedIndexChanged += langComboBoxSelectedIndexChanged;
            }

            int index = languageComboBox.Items.IndexOf(LocaleSelector.CurrentResourceCultureName);

            if (index >= 0)
            {
                languageComboBox.SelectedIndex = index;
            }
            else
            {
                throw new InvalidOperationException("Error while setting current culture index");
            }
        }
    }
}
