using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task02
{
    internal class HireDate
    {
        /*
         * ( day, month and Years)
         */

        #region Attributes

        private int day;

        private int month;

        private int year;
        #endregion

        #region Properties

        public int Day
        {
            get { return day; }
            set { day = value >= 1 && value <= 31 ? value : 1; }
        }

        public int Month
        {
            get { return month; }

            set { month = value>=1 && value<=12 ? value:1; }
        }

        public int Year
        {
            get { return year; }

            set { year = value>=1990? value:1990; }
        }


        #endregion

        #region Constructor

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Method

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
        #endregion
    }
}
