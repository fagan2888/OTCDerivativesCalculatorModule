using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using QLNet;

namespace RiskMonitor
{
    public class CustomFunction
    {
        public static Date StrToDate(string dateStr)
        {
            Date result = new Date();

            string[] patternList = { "yyyy-MM-dd" , "yyyyMMdd"};
            DateTime parsedDate;
            //DateTime.TryParseExact(dateStr, pattern, null, DateTimeStyles.None, out parsedDate);

            foreach (var pattern in patternList)
            {
                if (DateTime.TryParseExact(dateStr, pattern, null,
                                          DateTimeStyles.None, out parsedDate))
                {
                    result =  new Date(parsedDate);
                    break;
                }
                //Console.WriteLine("Converted '{0}' to {1:d}.", dateValue, parsedDate);
                //Console.WriteLine("Unable to convert '{0}' to a date and time.", dateValue);

                
            }

            return result;
        }

        
    }
}
