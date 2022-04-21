using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    public static class Exchanger
    {
        //USD
        public static double ExchangeUSDtoGBP(double One, double Two)
        {
            return One * Two;
        }

        public static double ExchangeUSDtoCAN(double One, double Two)
        {
            return One + Two;
        }

        public static double ExchangeUSDtoEUR(double One, double Two)
        {
            return One * Two;
        }

        //GBP
        public static double ExchangeGBPtoUSD(double One, double Two)
        {
            return One * Two;
        }

        public static double ExchangeGBPtoCAN(double One, double Two)
        {
            return One * Two;
        }

        public static double ExchangeGBPtoEUR(double One, double Two)
        {
            return One * Two;
        }

        //CAN
        public static double ExchangeCANtoUSD(double One, double Two)
        {
            return One * Two;
        }
        public static double ExchangeCANtoGBP(double One, double Two)
        {
            return One * Two;
        }
        public static double ExchangeCANtoEUR(double One, double Two)
        {
            return One * Two;
        }

        //Euro
        public static double ExchangeEURtoUSD(double One, double Two)
        {
            return One * Two;
        }
        public static double ExchangeEURtoGBP(double One, double Two)
        {
            return One * Two;
        }
        public static double ExchangeEURtoCAN(double One, double Two)
        {
            return One * Two;
        }
    }
}
