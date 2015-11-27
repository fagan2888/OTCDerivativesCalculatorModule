using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementPeriods : ISerialized
    {
        public SettlementPeriods(XmlNode xmlNode)
        {
            XmlNode durationNode = xmlNode.SelectSingleNode("duration");
            
            if (durationNode != null)
            {
                if (durationNode.Attributes["href"] != null || durationNode.Attributes["id"] != null) 
                {
                    if (durationNode.Attributes["id"] != null) 
                    {
                        durationIDRef_ = durationNode.Attributes["id"].Value;
                        SettlementPeriodDurationEnum ob = new SettlementPeriodDurationEnum(durationNode);
                        IDManager.SetID(durationIDRef_, ob);
                    }
                    else if (durationNode.Attributes["href"] != null)
                    {
                        durationIDRef_ = durationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        duration_ = new SettlementPeriodDurationEnum(durationNode);
                    }
                }
                else
                {
                    duration_ = new SettlementPeriodDurationEnum(durationNode);
                }
            }
            
        
            XmlNodeList applicableDayNodeList = xmlNode.SelectNodes("applicableDay");
            
            if (applicableDayNodeList != null)
            {
                this.applicableDay_ = new List<DayOfWeekEnum>();
                foreach (XmlNode item in applicableDayNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            applicableDayIDRef_ = item.Attributes["id"].Value;
                            applicableDay_.Add(new DayOfWeekEnum(item));
                            IDManager.SetID(applicableDayIDRef_, applicableDay_[applicableDay_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            applicableDayIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        applicableDay_.Add(new DayOfWeekEnum(item));
                        }
                    }
                    else
                    {
                        applicableDay_.Add(new DayOfWeekEnum(item));
                    }
                }
            }
            
        
            XmlNode startTimeNode = xmlNode.SelectSingleNode("startTime");
            
            if (startTimeNode != null)
            {
                if (startTimeNode.Attributes["href"] != null || startTimeNode.Attributes["id"] != null) 
                {
                    if (startTimeNode.Attributes["id"] != null) 
                    {
                        startTimeIDRef_ = startTimeNode.Attributes["id"].Value;
                        OffsetPrevailingTime ob = new OffsetPrevailingTime(startTimeNode);
                        IDManager.SetID(startTimeIDRef_, ob);
                    }
                    else if (startTimeNode.Attributes["href"] != null)
                    {
                        startTimeIDRef_ = startTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        startTime_ = new OffsetPrevailingTime(startTimeNode);
                    }
                }
                else
                {
                    startTime_ = new OffsetPrevailingTime(startTimeNode);
                }
            }
            
        
            XmlNode endTimeNode = xmlNode.SelectSingleNode("endTime");
            
            if (endTimeNode != null)
            {
                if (endTimeNode.Attributes["href"] != null || endTimeNode.Attributes["id"] != null) 
                {
                    if (endTimeNode.Attributes["id"] != null) 
                    {
                        endTimeIDRef_ = endTimeNode.Attributes["id"].Value;
                        OffsetPrevailingTime ob = new OffsetPrevailingTime(endTimeNode);
                        IDManager.SetID(endTimeIDRef_, ob);
                    }
                    else if (endTimeNode.Attributes["href"] != null)
                    {
                        endTimeIDRef_ = endTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endTime_ = new OffsetPrevailingTime(endTimeNode);
                    }
                }
                else
                {
                    endTime_ = new OffsetPrevailingTime(endTimeNode);
                }
            }
            
        
            XmlNode excludeHolidaysNode = xmlNode.SelectSingleNode("excludeHolidays");
            
            if (excludeHolidaysNode != null)
            {
                if (excludeHolidaysNode.Attributes["href"] != null || excludeHolidaysNode.Attributes["id"] != null) 
                {
                    if (excludeHolidaysNode.Attributes["id"] != null) 
                    {
                        excludeHolidaysIDRef_ = excludeHolidaysNode.Attributes["id"].Value;
                        CommodityBusinessCalendar ob = new CommodityBusinessCalendar(excludeHolidaysNode);
                        IDManager.SetID(excludeHolidaysIDRef_, ob);
                    }
                    else if (excludeHolidaysNode.Attributes["href"] != null)
                    {
                        excludeHolidaysIDRef_ = excludeHolidaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excludeHolidays_ = new CommodityBusinessCalendar(excludeHolidaysNode);
                    }
                }
                else
                {
                    excludeHolidays_ = new CommodityBusinessCalendar(excludeHolidaysNode);
                }
            }
            
        
            XmlNode includeHolidaysNode = xmlNode.SelectSingleNode("includeHolidays");
            
            if (includeHolidaysNode != null)
            {
                if (includeHolidaysNode.Attributes["href"] != null || includeHolidaysNode.Attributes["id"] != null) 
                {
                    if (includeHolidaysNode.Attributes["id"] != null) 
                    {
                        includeHolidaysIDRef_ = includeHolidaysNode.Attributes["id"].Value;
                        CommodityBusinessCalendar ob = new CommodityBusinessCalendar(includeHolidaysNode);
                        IDManager.SetID(includeHolidaysIDRef_, ob);
                    }
                    else if (includeHolidaysNode.Attributes["href"] != null)
                    {
                        includeHolidaysIDRef_ = includeHolidaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        includeHolidays_ = new CommodityBusinessCalendar(includeHolidaysNode);
                    }
                }
                else
                {
                    includeHolidays_ = new CommodityBusinessCalendar(includeHolidaysNode);
                }
            }
            
        
        }
        
    
        #region Duration_
        private SettlementPeriodDurationEnum duration_;
        public SettlementPeriodDurationEnum Duration_
        {
            get
            {
                if (this.duration_ != null)
                {
                    return this.duration_; 
                }
                else if (this.durationIDRef_ != null)
                {
                    duration_ = IDManager.getID(durationIDRef_) as SettlementPeriodDurationEnum;
                    return this.duration_; 
                }
                else
                {
                      return this.duration_; 
                }
            }
            set
            {
                if (this.duration_ != value)
                {
                    this.duration_ = value;
                }
            }
        }
        #endregion
        
        public string durationIDRef_ { get; set; }
        #region ApplicableDay_
        private List<DayOfWeekEnum> applicableDay_;
        public List<DayOfWeekEnum> ApplicableDay_
        {
            get
            {
                if (this.applicableDay_ != null)
                {
                    return this.applicableDay_; 
                }
                else if (this.applicableDayIDRef_ != null)
                {
                    return this.applicableDay_; 
                }
                else
                {
                      return this.applicableDay_; 
                }
            }
            set
            {
                if (this.applicableDay_ != value)
                {
                    this.applicableDay_ = value;
                }
            }
        }
        #endregion
        
        public string applicableDayIDRef_ { get; set; }
        #region StartTime_
        private OffsetPrevailingTime startTime_;
        public OffsetPrevailingTime StartTime_
        {
            get
            {
                if (this.startTime_ != null)
                {
                    return this.startTime_; 
                }
                else if (this.startTimeIDRef_ != null)
                {
                    startTime_ = IDManager.getID(startTimeIDRef_) as OffsetPrevailingTime;
                    return this.startTime_; 
                }
                else
                {
                      return this.startTime_; 
                }
            }
            set
            {
                if (this.startTime_ != value)
                {
                    this.startTime_ = value;
                }
            }
        }
        #endregion
        
        public string startTimeIDRef_ { get; set; }
        #region EndTime_
        private OffsetPrevailingTime endTime_;
        public OffsetPrevailingTime EndTime_
        {
            get
            {
                if (this.endTime_ != null)
                {
                    return this.endTime_; 
                }
                else if (this.endTimeIDRef_ != null)
                {
                    endTime_ = IDManager.getID(endTimeIDRef_) as OffsetPrevailingTime;
                    return this.endTime_; 
                }
                else
                {
                      return this.endTime_; 
                }
            }
            set
            {
                if (this.endTime_ != value)
                {
                    this.endTime_ = value;
                }
            }
        }
        #endregion
        
        public string endTimeIDRef_ { get; set; }
        #region ExcludeHolidays_
        private CommodityBusinessCalendar excludeHolidays_;
        public CommodityBusinessCalendar ExcludeHolidays_
        {
            get
            {
                if (this.excludeHolidays_ != null)
                {
                    return this.excludeHolidays_; 
                }
                else if (this.excludeHolidaysIDRef_ != null)
                {
                    excludeHolidays_ = IDManager.getID(excludeHolidaysIDRef_) as CommodityBusinessCalendar;
                    return this.excludeHolidays_; 
                }
                else
                {
                      return this.excludeHolidays_; 
                }
            }
            set
            {
                if (this.excludeHolidays_ != value)
                {
                    this.excludeHolidays_ = value;
                }
            }
        }
        #endregion
        
        public string excludeHolidaysIDRef_ { get; set; }
        #region IncludeHolidays_
        private CommodityBusinessCalendar includeHolidays_;
        public CommodityBusinessCalendar IncludeHolidays_
        {
            get
            {
                if (this.includeHolidays_ != null)
                {
                    return this.includeHolidays_; 
                }
                else if (this.includeHolidaysIDRef_ != null)
                {
                    includeHolidays_ = IDManager.getID(includeHolidaysIDRef_) as CommodityBusinessCalendar;
                    return this.includeHolidays_; 
                }
                else
                {
                      return this.includeHolidays_; 
                }
            }
            set
            {
                if (this.includeHolidays_ != value)
                {
                    this.includeHolidays_ = value;
                }
            }
        }
        #endregion
        
        public string includeHolidaysIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

