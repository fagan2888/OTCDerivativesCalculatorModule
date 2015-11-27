using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AveragingPeriod : ISerialized
    {
        public AveragingPeriod(XmlNode xmlNode)
        {
            XmlNodeList scheduleNodeList = xmlNode.SelectNodes("schedule");
            
            if (scheduleNodeList != null)
            {
                this.schedule_ = new List<AveragingSchedule>();
                foreach (XmlNode item in scheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            scheduleIDRef_ = item.Attributes["id"].Value;
                            schedule_.Add(new AveragingSchedule(item));
                            IDManager.SetID(scheduleIDRef_, schedule_[schedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            scheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        schedule_.Add(new AveragingSchedule(item));
                        }
                    }
                    else
                    {
                        schedule_.Add(new AveragingSchedule(item));
                    }
                }
            }
            
        
            XmlNode averagingDateTimesNode = xmlNode.SelectSingleNode("averagingDateTimes");
            
            if (averagingDateTimesNode != null)
            {
                if (averagingDateTimesNode.Attributes["href"] != null || averagingDateTimesNode.Attributes["id"] != null) 
                {
                    if (averagingDateTimesNode.Attributes["id"] != null) 
                    {
                        averagingDateTimesIDRef_ = averagingDateTimesNode.Attributes["id"].Value;
                        DateTimeList ob = new DateTimeList(averagingDateTimesNode);
                        IDManager.SetID(averagingDateTimesIDRef_, ob);
                    }
                    else if (averagingDateTimesNode.Attributes["href"] != null)
                    {
                        averagingDateTimesIDRef_ = averagingDateTimesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingDateTimes_ = new DateTimeList(averagingDateTimesNode);
                    }
                }
                else
                {
                    averagingDateTimes_ = new DateTimeList(averagingDateTimesNode);
                }
            }
            
        
            XmlNode averagingObservationsNode = xmlNode.SelectSingleNode("averagingObservations");
            
            if (averagingObservationsNode != null)
            {
                if (averagingObservationsNode.Attributes["href"] != null || averagingObservationsNode.Attributes["id"] != null) 
                {
                    if (averagingObservationsNode.Attributes["id"] != null) 
                    {
                        averagingObservationsIDRef_ = averagingObservationsNode.Attributes["id"].Value;
                        AveragingObservationList ob = new AveragingObservationList(averagingObservationsNode);
                        IDManager.SetID(averagingObservationsIDRef_, ob);
                    }
                    else if (averagingObservationsNode.Attributes["href"] != null)
                    {
                        averagingObservationsIDRef_ = averagingObservationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingObservations_ = new AveragingObservationList(averagingObservationsNode);
                    }
                }
                else
                {
                    averagingObservations_ = new AveragingObservationList(averagingObservationsNode);
                }
            }
            
        
            XmlNode marketDisruptionNode = xmlNode.SelectSingleNode("marketDisruption");
            
            if (marketDisruptionNode != null)
            {
                if (marketDisruptionNode.Attributes["href"] != null || marketDisruptionNode.Attributes["id"] != null) 
                {
                    if (marketDisruptionNode.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["id"].Value;
                        MarketDisruption ob = new MarketDisruption(marketDisruptionNode);
                        IDManager.SetID(marketDisruptionIDRef_, ob);
                    }
                    else if (marketDisruptionNode.Attributes["href"] != null)
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketDisruption_ = new MarketDisruption(marketDisruptionNode);
                    }
                }
                else
                {
                    marketDisruption_ = new MarketDisruption(marketDisruptionNode);
                }
            }
            
        
        }
        
    
        #region Schedule_
        private List<AveragingSchedule> schedule_;
        public List<AveragingSchedule> Schedule_
        {
            get
            {
                if (this.schedule_ != null)
                {
                    return this.schedule_; 
                }
                else if (this.scheduleIDRef_ != null)
                {
                    return this.schedule_; 
                }
                else
                {
                      return this.schedule_; 
                }
            }
            set
            {
                if (this.schedule_ != value)
                {
                    this.schedule_ = value;
                }
            }
        }
        #endregion
        
        public string scheduleIDRef_ { get; set; }
        #region AveragingDateTimes_
        private DateTimeList averagingDateTimes_;
        public DateTimeList AveragingDateTimes_
        {
            get
            {
                if (this.averagingDateTimes_ != null)
                {
                    return this.averagingDateTimes_; 
                }
                else if (this.averagingDateTimesIDRef_ != null)
                {
                    averagingDateTimes_ = IDManager.getID(averagingDateTimesIDRef_) as DateTimeList;
                    return this.averagingDateTimes_; 
                }
                else
                {
                      return this.averagingDateTimes_; 
                }
            }
            set
            {
                if (this.averagingDateTimes_ != value)
                {
                    this.averagingDateTimes_ = value;
                }
            }
        }
        #endregion
        
        public string averagingDateTimesIDRef_ { get; set; }
        #region AveragingObservations_
        private AveragingObservationList averagingObservations_;
        public AveragingObservationList AveragingObservations_
        {
            get
            {
                if (this.averagingObservations_ != null)
                {
                    return this.averagingObservations_; 
                }
                else if (this.averagingObservationsIDRef_ != null)
                {
                    averagingObservations_ = IDManager.getID(averagingObservationsIDRef_) as AveragingObservationList;
                    return this.averagingObservations_; 
                }
                else
                {
                      return this.averagingObservations_; 
                }
            }
            set
            {
                if (this.averagingObservations_ != value)
                {
                    this.averagingObservations_ = value;
                }
            }
        }
        #endregion
        
        public string averagingObservationsIDRef_ { get; set; }
        #region MarketDisruption_
        private MarketDisruption marketDisruption_;
        public MarketDisruption MarketDisruption_
        {
            get
            {
                if (this.marketDisruption_ != null)
                {
                    return this.marketDisruption_; 
                }
                else if (this.marketDisruptionIDRef_ != null)
                {
                    marketDisruption_ = IDManager.getID(marketDisruptionIDRef_) as MarketDisruption;
                    return this.marketDisruption_; 
                }
                else
                {
                      return this.marketDisruption_; 
                }
            }
            set
            {
                if (this.marketDisruption_ != value)
                {
                    this.marketDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

