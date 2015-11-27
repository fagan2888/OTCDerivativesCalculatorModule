using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AveragingPeriod
    {
        public AveragingPeriod(XmlNode xmlNode)
        {
            XmlNodeList scheduleNodeList = xmlNode.SelectNodes("schedule");
            
            foreach (XmlNode item in scheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scheduleIDRef = item.Attributes["id"].Name;
                        List<AveragingSchedule> ob = new List<AveragingSchedule>();
                        ob.Add(new AveragingSchedule(item));
                        IDManager.SetID(scheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    schedule.Add(new AveragingSchedule(item));
                    }
                }
            }
            
        
            XmlNodeList averagingDateTimesNodeList = xmlNode.SelectNodes("averagingDateTimes");
            if (averagingDateTimesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingDateTimesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingDateTimesIDRef = item.Attributes["id"].Name;
                        DateTimeList ob = DateTimeList();
                        IDManager.SetID(averagingDateTimesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingDateTimesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingDateTimes = new DateTimeList(item);
                    }
                }
            }
            
        
            XmlNodeList averagingObservationsNodeList = xmlNode.SelectNodes("averagingObservations");
            if (averagingObservationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingObservationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingObservationsIDRef = item.Attributes["id"].Name;
                        AveragingObservationList ob = AveragingObservationList();
                        IDManager.SetID(averagingObservationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingObservationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingObservations = new AveragingObservationList(item);
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionNodeList = xmlNode.SelectNodes("marketDisruption");
            if (marketDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef = item.Attributes["id"].Name;
                        MarketDisruption ob = MarketDisruption();
                        IDManager.SetID(marketDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketDisruption = new MarketDisruption(item);
                    }
                }
            }
            
        
        }
        
    
        #region Schedule
        private List<AveragingSchedule> schedule;
        public List<AveragingSchedule> Schedule
        {
            get
            {
                if (this.schedule != null)
                {
                    return this.schedule; 
                }
                else if (this.scheduleIDRef != null)
                {
                    schedule = IDManager.getID(scheduleIDRef) as List<AveragingSchedule>;
                    return this.schedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.schedule != value)
                {
                    this.schedule = value;
                }
            }
        }
        #endregion
        
        public string AveragingScheduleIDRef { get; set; }
        #region AveragingDateTimes
        private DateTimeList averagingDateTimes;
        public DateTimeList AveragingDateTimes
        {
            get
            {
                if (this.averagingDateTimes != null)
                {
                    return this.averagingDateTimes; 
                }
                else if (this.averagingDateTimesIDRef != null)
                {
                    averagingDateTimes = IDManager.getID(averagingDateTimesIDRef) as DateTimeList;
                    return this.averagingDateTimes; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingDateTimes != value)
                {
                    this.averagingDateTimes = value;
                }
            }
        }
        #endregion
        
        public string DateTimeListIDRef { get; set; }
        #region AveragingObservations
        private AveragingObservationList averagingObservations;
        public AveragingObservationList AveragingObservations
        {
            get
            {
                if (this.averagingObservations != null)
                {
                    return this.averagingObservations; 
                }
                else if (this.averagingObservationsIDRef != null)
                {
                    averagingObservations = IDManager.getID(averagingObservationsIDRef) as AveragingObservationList;
                    return this.averagingObservations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingObservations != value)
                {
                    this.averagingObservations = value;
                }
            }
        }
        #endregion
        
        public string AveragingObservationListIDRef { get; set; }
        #region MarketDisruption
        private MarketDisruption marketDisruption;
        public MarketDisruption MarketDisruption
        {
            get
            {
                if (this.marketDisruption != null)
                {
                    return this.marketDisruption; 
                }
                else if (this.marketDisruptionIDRef != null)
                {
                    marketDisruption = IDManager.getID(marketDisruptionIDRef) as MarketDisruption;
                    return this.marketDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruption != value)
                {
                    this.marketDisruption = value;
                }
            }
        }
        #endregion
        
        public string MarketDisruptionIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

