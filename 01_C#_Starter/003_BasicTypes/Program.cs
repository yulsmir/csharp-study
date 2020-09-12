using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ЦЕЛЫЕ ТИПЫ
            byte a = 0;
            Byte b = 255;

            sbyte c = -128;
            SByte d = +127;

            ushort e = 0;
            UInt16 f = 65535;

            short g = -32768;
            Int16 h = +32767;

            uint i = 0u;
            UInt32 j = 4294967295U;

            int k = -2147483648;
            Int32 l = +2147483647;

            ulong m = 0ul;
            UInt64 n = 18446744073709551615UL;

            long o = -9223372036854775808L;
            Int64 p = +9223372036854775807L;

            #endregion

            #region ВЕЩЕСТВЕННЫЕ ТИПЫ
            float q = -0.123456789f;
            Single r = +1.123456789F;

            double s = -0.123456789d;
            Double t = +1.123456789D;
            #endregion

            #region ДЕСЯТИЧНЫЙ ТИП
            decimal u = -0.12345m;
            Decimal v = +1.1234567M;
            #endregion

            #region ЛОГИЧЕСКИЙ ТИП
            bool w = true;
            Boolean x = false;
            #endregion

            #region СИМВОЛЬНЫЙ ТИП
            char y = 'a';
            Char z = 'b';
            #endregion

            #region СТРОКОВОЙ ТИП
            string firstString = "hello";
            String secondString = "HELLO";
            #endregion

            Console.ReadKey();
        }
    }
}