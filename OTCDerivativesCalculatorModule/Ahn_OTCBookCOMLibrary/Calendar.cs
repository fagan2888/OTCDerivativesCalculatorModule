using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Calendar
    {
        private DBCalendar dbCalendar_;
        private string calendarName_;

        public Calendar()
        {
            this.dbCalendar_ = new DBCalendar();
            this.calendarName_ = "EmptyCalendar";
        }

        public string get_name()
        {
            return this.calendarName_;
        }

        public string loadCalendar(string calName)
        {
            this.calendarName_ = calName;

            try
            {
                this.dbCalendar_.loadHolidaysFromDB(calName);
            }
            catch (Exception)
            {
                return "calendar load fail";
            }


            return "calendar load complete";
        }

        public string loadCalendars(string[] calNames)
        {
            try
            {
                for (int i = 0; i < calNames.Length; i++)
                {
                    this.calendarName_ = calNames[i] + ",";
                }

                return "calendars(" + calNames.Length + ") load complete";
            }
            catch (Exception)
            {

                return "calendars(" + calNames.Length + ") load fail";
            }

        }

        public bool isHoliday(DateTime d)
        {
            return !(this.dbCalendar_.isBusinessDay(d));
        }

        public int[] holidayList()
        {
            if (this.dbCalendar_.holidayList().Count == 0)
            {
                int[] s = new int[] { 0 };
                return s;
            }
            else 
            {
                return this.dbCalendar_.holidayList().ToArray();
            }
            
        }

        public string holidayList2()
        {
            if (this.dbCalendar_.holidayList().Count == 0)
            {
                return "empty";
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (var item in this.dbCalendar_.holidayList())
                {
                    sb.Append(item + "|");
                }

                return sb.ToString();
            }

        }

        public string removeHoliday(DateTime d)
        {
            try
            {
                if (this.calendarName_ == "EmptyCalendar")
                {
                    return "this is emptyCalendar";
                }
                else
                {
                    this.dbCalendar_.removeHoliday(d);

                    return "remove complete : " + d.ToString("yyyyMMdd");
                }
            }
            catch (Exception e)
            {
                return "remove fail : " + d.ToString("yyyyMMdd") + " " + e.Message;

                throw;
            }
            
        }

        public string addHoliday(DateTime d,string description)
        {
            try
            {
                if (this.calendarName_ == "EmptyCalendar")
                {
                    return "this is emptyCalendar";
                }
                else
                {
                    this.dbCalendar_.addHoliday(d, description);

                    return "add complete : " + d.ToString("yyyyMMdd");
                }

            }
            catch (Exception e)
            {
                return "add fail : " + d.ToString("yyyyMMdd") + " " + e.Message;

                throw;
            }

        }

        public int advance(DateTime d, string periodStr, string businessDayConv = "ModifyFollowing")
        {
            return this.dbCalendar_.advance(d, periodStr, businessDayConv);
        }

        //public string addHolidayObjer(object date, string description)
        //{

        //    DateTime d = ExcelObjectMarshal.objectDateMarshal(date);

        //    DateTime? d_null = date as DateTime?;
        //    DateTime d = d_null.Value;

        //    try
        //    {
        //        if (this.calendarName_ != "EmptyCalendar")
        //        {
        //            this.dbCalendar_.addHoliday(d, description);

        //            return "this is emptyCalendar";
        //        }
        //        else
        //        {
        //            return "remove complete : " + d.ToString("yyyyMMdd");
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        return "add fail : " + d.ToString("yyyyMMdd") + " " + e.Message;

        //        throw;
        //    }

        //}

    }
}
