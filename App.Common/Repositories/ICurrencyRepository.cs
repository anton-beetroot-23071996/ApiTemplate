﻿using System;
using System.Collections.Generic;

namespace App.Repositories
{
    public interface ICurrencyRepository
    {
        IEnumerable<string> GetCurrencyCodes();
        IEnumerable<KeyValuePair<string, decimal>> GetExchangeRates(DateTime date);
    }
}
