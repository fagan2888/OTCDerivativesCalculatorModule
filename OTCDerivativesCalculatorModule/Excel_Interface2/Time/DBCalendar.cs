using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class DBCalendar : QLNet.Calendar
    {
        private Dictionary<int, DateTime> holidays_;
        private bool holidaysLoadedFlag_ = false;

        #region CalendarName_
        private string calendarName_;
        public string CalendarName_
        {
            get { return this.calendarName_; }
            private set
            {
                if (this.calendarName_ != value)
                {
                    this.calendarName_ = value;
                }
            }
        }
        #endregion

        public DBCalendar()
        {
            this.calendar_ = this;
            holidays_ = new Dictionary<int, DateTime>();

        }

        public void loadHolidaysFromDB(string calendarName)
        {
            this.holidays_.Clear();
            this.calendarName_ = calendarName;

            HOLIDAY_INFO_Table_DAOManager daoM = new HOLIDAY_INFO_Table_DAOManager();

            daoM.HOLIDAY_COUNTRY_NAME_ = calendarName;

            daoM.selectContryName(DataBaseConnectManager.ConnectionFactory("myDB"));

            int daoCount = daoM.DAOList_.Count;
            
            for (int i = 0; i < daoCount ; i++)
            {
                DateTime d_time = StringConverter.dbDateToDateTime(daoM.DAOList_[i].HOLIDAY_DATE_);

                this.holidays_.Add(this.serialNumber(d_time), d_time);
            }

            this.holidaysLoadedFlag_ = true;

        }

        private void dataReload()
        {
            this.loadHolidaysFromDB(this.calendarName_);
        }

        //public void addHoildayToDB(DateTime date)
        //{
        //    HOLIDAY_INFO_Table_DAO dao = new HOLIDAY_INFO_Table_DAO();

        //    if (holidaysLoadedFlag_)
        //    {
        //        if (this.holidays_.ContainsKey(this.serialNumber(date)))
        //        {

        //        }
        //        else
        //        {
        //            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
        //        }
        //    }
        //    else
        //    {
        //        OutputLogViewModel.addResult("holiday does not loaded yet.");
        //    }

        //}

        public int serialNumber(DateTime date) { return (date - new DateTime(1899, 12, 31).Date).Days + 1; }

        public DateTime serialNumberDateTime(int serialNum) 
        {
            QLNet.Date d = new QLNet.Date(serialNum);

            return d;
        }

        public override string name() { return this.calendarName_; }

        public override bool isWeekend(DayOfWeek w)
        {
            return w == DayOfWeek.Saturday || w == DayOfWeek.Sunday;
        }

        public bool isBusinessDay(DateTime date)
        {
            DayOfWeek w = date.DayOfWeek;
            //int d = date.Day, dd = date.DayOfYear;
            //Month m = (Month)date.Month;
            //int y = date.Year;

            int serialNum = this.serialNumber(date);

            if (isWeekend(w))
            {
                if (this.holidays_.ContainsKey(serialNum))
                {
                    return true;
                }

                return true;
            }

            return false;

        }

        public override bool isBusinessDay(Date d)
        {
            return this.isBusinessDay(new DateTime(d.Year, d.Month, d.Day));
        }

        public List<int> holidayList()
        {
            List<int> list = this.holidays_.Keys.ToList<int>();

            return list;

            //List<string> list = new List<string>();

            //foreach (var item in this.holidays_)
            //{
            //     list.holidays_
            //}
            
        }

        public void removeHoliday(DateTime d)
        {
            try
            {
                HOLIDAY_INFO_Table_DAO dao = new HOLIDAY_INFO_Table_DAO();

                dao.HOLIDAY_DATE_ = StringConverter.dbDateTimeToDateString(d);
                dao.HOLIDAY_COUNTRY_NAME_ = this.calendarName_;

                dao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.dataReload();
            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("remove fail : " + d.ToString("yyyyMMdd") + " " + e.Message);
                throw;
            }
            


        }

        public void addHoliday(DateTime d, string description)
        {
            try
            {
                HOLIDAY_INFO_Table_DAO dao = new HOLIDAY_INFO_Table_DAO();

                dao.HOLIDAY_COUNTRY_NAME_ = this.calendarName_;
                dao.HOLIDAY_CURRENCY_CODE_ = this.calendarName_;
                dao.HOLIDAY_DATE_ = StringConverter.dbDateTimeToDateString(d);
                dao.HOLIDAY_NAME_ = description;
                dao.HOLIDAY_TYPE_ = "";
                dao.USING_START_DATE_ = "19000101";
                dao.USING_END_DATE_ = "21001231";

                dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.dataReload();

            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("add fail : " + d.ToString("yyyyMMdd") + " " + e.Message);
                throw;
            }
            
        }

        public int advance(DateTime d, string periodStr, string businessDayConv)
        {
            try
            {
                Period period = new Period(periodStr);
                
                Date result = this.advance(d, period, BusinessDayConvention.ModifiedFollowing);

                return result.serialNumber();

            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("fail " + e.Message);

                return (new Date().serialNumber());
            }
            
        }
    }
}
