using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class StringConverter
    {
        public static string xmlDateStrTodbDateStrTime(string xmlDateStr)
        {
            string conv = "";

            conv = xmlDateStr.Replace("/", "");
            conv = xmlDateStr.Replace("-", "");

            return conv;
        }

        public static DateTime xmlDateToDateTime(string d)
        {
            DateTime date = DateTime.ParseExact(d, StringFormat.XmlDateFormat_, null);

            return date;
        }

        public static string xmlDateTimeToDateString(DateTime dateTime)
        {
            string dateStr = dateTime.ToString(StringFormat.XmlDateFormat_);

            return dateStr;
        }

        public static DateTime dbDateToDateTime(string d)
        {
            DateTime date = DateTime.ParseExact(d, StringFormat.DbDateFormat_, null);

            return date;
        }

        public static string dbDateTimeToDateString(DateTime dateTime)
        {
            string dateStr = dateTime.ToString(StringFormat.DbDateFormat_);

            return dateStr;
        }

    }
}
