using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TriggerEvent : ISerialized
    {
        public TriggerEvent(XmlNode xmlNode)
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
            
        
            XmlNode triggerDatesNode = xmlNode.SelectSingleNode("triggerDates");
            
            if (triggerDatesNode != null)
            {
                if (triggerDatesNode.Attributes["href"] != null || triggerDatesNode.Attributes["id"] != null) 
                {
                    if (triggerDatesNode.Attributes["id"] != null) 
                    {
                        triggerDatesIDRef_ = triggerDatesNode.Attributes["id"].Value;
                        DateList ob = new DateList(triggerDatesNode);
                        IDManager.SetID(triggerDatesIDRef_, ob);
                    }
                    else if (triggerDatesNode.Attributes["href"] != null)
                    {
                        triggerDatesIDRef_ = triggerDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerDates_ = new DateList(triggerDatesNode);
                    }
                }
                else
                {
                    triggerDates_ = new DateList(triggerDatesNode);
                }
            }
            
        
            XmlNode triggerNode = xmlNode.SelectSingleNode("trigger");
            
            if (triggerNode != null)
            {
                if (triggerNode.Attributes["href"] != null || triggerNode.Attributes["id"] != null) 
                {
                    if (triggerNode.Attributes["id"] != null) 
                    {
                        triggerIDRef_ = triggerNode.Attributes["id"].Value;
                        Trigger ob = new Trigger(triggerNode);
                        IDManager.SetID(triggerIDRef_, ob);
                    }
                    else if (triggerNode.Attributes["href"] != null)
                    {
                        triggerIDRef_ = triggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trigger_ = new Trigger(triggerNode);
                    }
                }
                else
                {
                    trigger_ = new Trigger(triggerNode);
                }
            }
            
        
            XmlNode featurePaymentNode = xmlNode.SelectSingleNode("featurePayment");
            
            if (featurePaymentNode != null)
            {
                if (featurePaymentNode.Attributes["href"] != null || featurePaymentNode.Attributes["id"] != null) 
                {
                    if (featurePaymentNode.Attributes["id"] != null) 
                    {
                        featurePaymentIDRef_ = featurePaymentNode.Attributes["id"].Value;
                        FeaturePayment ob = new FeaturePayment(featurePaymentNode);
                        IDManager.SetID(featurePaymentIDRef_, ob);
                    }
                    else if (featurePaymentNode.Attributes["href"] != null)
                    {
                        featurePaymentIDRef_ = featurePaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        featurePayment_ = new FeaturePayment(featurePaymentNode);
                    }
                }
                else
                {
                    featurePayment_ = new FeaturePayment(featurePaymentNode);
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
        #region TriggerDates_
        private DateList triggerDates_;
        public DateList TriggerDates_
        {
            get
            {
                if (this.triggerDates_ != null)
                {
                    return this.triggerDates_; 
                }
                else if (this.triggerDatesIDRef_ != null)
                {
                    triggerDates_ = IDManager.getID(triggerDatesIDRef_) as DateList;
                    return this.triggerDates_; 
                }
                else
                {
                      return this.triggerDates_; 
                }
            }
            set
            {
                if (this.triggerDates_ != value)
                {
                    this.triggerDates_ = value;
                }
            }
        }
        #endregion
        
        public string triggerDatesIDRef_ { get; set; }
        #region Trigger_
        private Trigger trigger_;
        public Trigger Trigger_
        {
            get
            {
                if (this.trigger_ != null)
                {
                    return this.trigger_; 
                }
                else if (this.triggerIDRef_ != null)
                {
                    trigger_ = IDManager.getID(triggerIDRef_) as Trigger;
                    return this.trigger_; 
                }
                else
                {
                      return this.trigger_; 
                }
            }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                }
            }
        }
        #endregion
        
        public string triggerIDRef_ { get; set; }
        #region FeaturePayment_
        private FeaturePayment featurePayment_;
        public FeaturePayment FeaturePayment_
        {
            get
            {
                if (this.featurePayment_ != null)
                {
                    return this.featurePayment_; 
                }
                else if (this.featurePaymentIDRef_ != null)
                {
                    featurePayment_ = IDManager.getID(featurePaymentIDRef_) as FeaturePayment;
                    return this.featurePayment_; 
                }
                else
                {
                      return this.featurePayment_; 
                }
            }
            set
            {
                if (this.featurePayment_ != value)
                {
                    this.featurePayment_ = value;
                }
            }
        }
        #endregion
        
        public string featurePaymentIDRef_ { get; set; }
        
    
        
    
    }
    
}

