using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TriggerEvent
    {
        public TriggerEvent(XmlNode xmlNode)
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
            
        
            XmlNodeList triggerDatesNodeList = xmlNode.SelectNodes("triggerDates");
            if (triggerDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerDatesIDRef = item.Attributes["id"].Name;
                        DateList ob = DateList();
                        IDManager.SetID(triggerDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerDates = new DateList(item);
                    }
                }
            }
            
        
            XmlNodeList triggerNodeList = xmlNode.SelectNodes("trigger");
            if (triggerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerIDRef = item.Attributes["id"].Name;
                        Trigger ob = Trigger();
                        IDManager.SetID(triggerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trigger = new Trigger(item);
                    }
                }
            }
            
        
            XmlNodeList featurePaymentNodeList = xmlNode.SelectNodes("featurePayment");
            if (featurePaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in featurePaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        featurePaymentIDRef = item.Attributes["id"].Name;
                        FeaturePayment ob = FeaturePayment();
                        IDManager.SetID(featurePaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        featurePaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        featurePayment = new FeaturePayment(item);
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
        #region TriggerDates
        private DateList triggerDates;
        public DateList TriggerDates
        {
            get
            {
                if (this.triggerDates != null)
                {
                    return this.triggerDates; 
                }
                else if (this.triggerDatesIDRef != null)
                {
                    triggerDates = IDManager.getID(triggerDatesIDRef) as DateList;
                    return this.triggerDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerDates != value)
                {
                    this.triggerDates = value;
                }
            }
        }
        #endregion
        
        public string DateListIDRef { get; set; }
        #region Trigger
        private Trigger trigger;
        public Trigger Trigger
        {
            get
            {
                if (this.trigger != null)
                {
                    return this.trigger; 
                }
                else if (this.triggerIDRef != null)
                {
                    trigger = IDManager.getID(triggerIDRef) as Trigger;
                    return this.trigger; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trigger != value)
                {
                    this.trigger = value;
                }
            }
        }
        #endregion
        
        public string TriggerIDRef { get; set; }
        #region FeaturePayment
        private FeaturePayment featurePayment;
        public FeaturePayment FeaturePayment
        {
            get
            {
                if (this.featurePayment != null)
                {
                    return this.featurePayment; 
                }
                else if (this.featurePaymentIDRef != null)
                {
                    featurePayment = IDManager.getID(featurePaymentIDRef) as FeaturePayment;
                    return this.featurePayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.featurePayment != value)
                {
                    this.featurePayment = value;
                }
            }
        }
        #endregion
        
        public string FeaturePaymentIDRef { get; set; }
        
    
        
    
    }
    
}

