using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{


    internal class Duration
    {


        #region Attributes
        private int hours;

        private int minutes;

        private int seconds;
        #endregion

        #region Properties

        public int Hours
        {
            get { return hours; }
            set { hours = value>=0? value:0; }
        }

        public int Minutes
        {
            get { return minutes; }

            set
            {
                minutes = (value >= 0 && value < 60) ? value : 0;
            }
        }

        public int Seconds
        {
            get { return seconds; }

            set
            {
                seconds = (value >= 0 && value < 60) ? value : 0;
            }
        }
        #endregion

        #region Constructor

        public Duration(double h, double m, double s) {
            Hours = h;
            Minutes = m;
            Seconds = s;

        }

        public Duration(int totalSec )
        {

            SetFromTotalSeconds(totalSec);

        }

        private void SetFromTotalSeconds(int totalSeconds)
        {
            if (totalSeconds < 0)
                totalSeconds = 0;

            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Methods

        public override string ToString()
        {

            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";

        }

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion

        #region OperatorOverLoading



        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator +( Duration d2, int num)
        {
            return new Duration(num + d2.TotalSeconds());
        }

        public static Duration operator +(int num,Duration d2)
        {
            return new Duration(num + d2.TotalSeconds());
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator true(Duration d) => d.TotalSeconds() > 0;

        public static bool operator false(Duration d) => d.TotalSeconds() <= 0;

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public static explicit operator Duration(DateTime dt)
        {
            return new Duration(dt.Hour, dt.Minute, dt.Second);
        }



        #endregion
    }
}
