using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class ExchangeMonitor
    {
        private string _currencyType;
        private double _value;



        public ExchangeMonitor(string CurrencyType, double Value)
        {
            _currencyType = CurrencyType;
            _value = Value;


        }

        public ExchangeMonitor(double Value)
        {
            _value = Value;

        }

        public double moneyValue()
        {
            return _value;
        }

    }
}
