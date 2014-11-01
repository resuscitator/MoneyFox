﻿using PropertyChanged;

namespace MoneyManager.DataAccess.Model
{
    [ImplementPropertyChanged]
    public class Country
    {
        public string Abbreviation { get; set; }

        public string Alpha3 { get; set; }

        public string CurrencyID { get; set; }

        public string CurrencyName { get; set; }

        public string ID { get; set; }

        public string Name { get; set; }
    }
}