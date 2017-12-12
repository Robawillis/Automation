using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Support
{
    class Utilities
    {
        public string Gettimestamp()
        {
            //timestamp creat a variable for year, month, day, hour, min, secconds , milliseconds
             string year = DateTime.Now.Year.ToString();
             string month = DateTime.Now.Month.ToString();
             string day = DateTime.Now.Day.ToString();
             string hour = DateTime.Now.Hour.ToString();
             string min = DateTime.Now.Minute.ToString();
             string seconds = DateTime.Now.Second.ToString();
             string miliseconds = DateTime.Now.Millisecond.ToString();

            //string timestamp = year + month + day + hour + min + seconds + miliseconds;
            //alterative method J.R
            string timestamp = DateTime.Now.ToString();
            return timestamp;
        }

    }
}
