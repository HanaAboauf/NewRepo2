using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    internal class HireDate
    {
        #region Attributes
        private int day;

        private int month;

        private int year;
        #endregion

        #region Properties

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    day = 1;
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    month = 1;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900)
                {
                    year = value;
                }
                else
                {
                    year = 2000;
                }
            }
        }

        #endregion

        #region Constructors
        public HireDate()
        {
            day=default;
            month = default;
            year = default;

        }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        } 
        #endregion
    }
}
