using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Demo_01
{
    internal static class IntExtension
    {
        public static int Reverse(this int Number)
        {
            int ReversedNumber = 0, Reminder;
            while (Number != 0)
            {
                Reminder = Number % 10;
                ReversedNumber = ReversedNumber * 10 + Reminder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }

        public static long Reverse(this long Number)
        {
            long ReversedNumber = 0, Reminder;
            while (Number != 0)
            {
                Reminder = Number % 10;
                ReversedNumber = ReversedNumber * 10 + Reminder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }
    }
}
