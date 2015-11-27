using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementPeriods
    {
        public SettlementPeriods(XmlNode xmlNode)
        {
            XmlNodeList durationNodeList = xmlNode.SelectNodes("duration");
            if (durationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in durationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        durationIDRef = item.Attributes["id"].Name;
                        SettlementPeriodDurationEnum ob = SettlementPeriodDurationEnum();
                        IDManager.SetID(durationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        durationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        duration = new SettlementPeriodDurationEnum(item);
                    }
                }
            }
            
        
            XmlNodeList applicableDayNodeList = xmlNode.SelectNodes("applicableDay");
            
            foreach (XmlNode item in applicableDayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableDayIDRef = item.Attributes["id"].Name;
                        List<DayOfWeekEnum> ob = new List<DayOfWeekEnum>();
                        ob.Add(new DayOfWeekEnum(item));
                        IDManager.SetID(applicableDayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableDayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    applicableDay.Add(new DayOfWeekEnum(item));
                    }
                }
            }
            
        
            XmlNodeList startTimeNodeList = xmlNode.SelectNodes("startTime");
            if (startTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startTimeIDRef = item.Attributes["id"].Name;
                        OffsetPrevailingTime ob = OffsetPrevailingTime();
                        IDManager.SetID(startTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startTime = new OffsetPrevailingTime(item);
                    }
                }
            }
            
        
            XmlNodeList endTimeNodeList = xmlNode.SelectNodes("endTime");
            if (endTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endTimeIDRef = item.Attributes["id"].Name;
                        OffsetPrevailingTime ob = OffsetPrevailingTime();
                        IDManager.SetID(endTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endTime = new OffsetPrevailingTime(item);
                    }
                }
            }
            
        
            XmlNodeList excludeHolidaysNodeList = xmlNode.SelectNodes("excludeHolidays");
            if (excludeHolidaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in excludeHolidaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        excludeHolidaysIDRef = item.Attributes["id"].Name;
                        CommodityBusinessCalendar ob = CommodityBusinessCalendar();
                        IDManager.SetID(excludeHolidaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        excludeHolidaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        excludeHolidays = new CommodityBusinessCalendar(item);
                    }
                }
            }
            
        
            XmlNodeList includeHolidaysNodeList = xmlNode.SelectNodes("includeHolidays");
            if (includeHolidaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in includeHolidaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        includeHolidaysIDRef = item.Attributes["id"].Name;
                        CommodityBusinessCalendar ob = CommodityBusinessCalendar();
                        IDManager.SetID(includeHolidaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        includeHolidaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        includeHolidays = new CommodityBusinessCalendar(item);
                    }
                }
            }
            
        
        }
        
    
        #region Duration
        private SettlementPeriodDurationEnum duration;
        public SettlementPeriodDurationEnum Duration
        {
            get
            {
                if (this.duration != null)
                {
                    return this.duration; 
                }
                else if (this.durationIDRef != null)
                {
                    duration = IDManager.getID(durationIDRef) as SettlementPeriodDurationEnum;
                    return this.duration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.duration != value)
                {
                    this.duration = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodDurationEnumIDRef { get; set; }
        #region ApplicableDay
        private List<DayOfWeekEnum> applicableDay;
        public List<DayOfWeekEnum> ApplicableDay
        {
            get
            {
                if (this.applicableDay != null)
                {
                    return this.applicableDay; 
                }
                else if (this.applicableDayIDRef != null)
                {
                    applicableDay = IDManager.getID(applicableDayIDRef) as List<DayOfWeekEnum>;
                    return this.applicableDay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicableDay != value)
                {
                    this.applicableDay = value;
                }
            }
        }
        #endregion
        
        public string DayOfWeekEnumIDRef { get; set; }
        #region StartTime
        private OffsetPrevailingTime startTime;
        public OffsetPrevailingTime StartTime
        {
            get
            {
                if (this.startTime != null)
                {
                    return this.startTime; 
                }
                else if (this.startTimeIDRef != null)
                {
                    startTime = IDManager.getID(startTimeIDRef) as OffsetPrevailingTime;
                    return this.startTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startTime != value)
                {
                    this.startTime = value;
                }
            }
        }
        #endregion
        
        public string OffsetPrevailingTimeIDRef { get; set; }
        #region EndTime
        private OffsetPrevailingTime endTime;
        public OffsetPrevailingTime EndTime
        {
            get
            {
                if (this.endTime != null)
                {
                    return this.endTime; 
                }
                else if (this.endTimeIDRef != null)
                {
                    endTime = IDManager.getID(endTimeIDRef) as OffsetPrevailingTime;
                    return this.endTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endTime != value)
                {
                    this.endTime = value;
                }
            }
        }
        #endregion
        
        public string OffsetPrevailingTimeIDRef { get; set; }
        #region ExcludeHolidays
        private CommodityBusinessCalendar excludeHolidays;
        public CommodityBusinessCalendar ExcludeHolidays
        {
            get
            {
                if (this.excludeHolidays != null)
                {
                    return this.excludeHolidays; 
                }
                else if (this.excludeHolidaysIDRef != null)
                {
                    excludeHolidays = IDManager.getID(excludeHolidaysIDRef) as CommodityBusinessCalendar;
                    return this.excludeHolidays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.excludeHolidays != value)
                {
                    this.excludeHolidays = value;
                }
            }
        }
        #endregion
        
        public string CommodityBusinessCalendarIDRef { get; set; }
        #region IncludeHolidays
        private CommodityBusinessCalendar includeHolidays;
        public CommodityBusinessCalendar IncludeHolidays
        {
            get
            {
                if (this.includeHolidays != null)
                {
                    return this.includeHolidays; 
                }
                else if (this.includeHolidaysIDRef != null)
                {
                    includeHolidays = IDManager.getID(includeHolidaysIDRef) as CommodityBusinessCalendar;
                    return this.includeHolidays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.includeHolidays != value)
                {
                    this.includeHolidays = value;
                }
            }
        }
        #endregion
        
        public string CommodityBusinessCalendarIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

