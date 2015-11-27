using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Notional : ISerialized
    {
        public Notional(XmlNode xmlNode)
        {
            XmlNode notionalStepScheduleNode = xmlNode.SelectSingleNode("notionalStepSchedule");
            
            if (notionalStepScheduleNode != null)
            {
                if (notionalStepScheduleNode.Attributes["href"] != null || notionalStepScheduleNode.Attributes["id"] != null) 
                {
                    if (notionalStepScheduleNode.Attributes["id"] != null) 
                    {
                        notionalStepScheduleIDRef_ = notionalStepScheduleNode.Attributes["id"].Value;
                        NonNegativeAmountSchedule ob = new NonNegativeAmountSchedule(notionalStepScheduleNode);
                        IDManager.SetID(notionalStepScheduleIDRef_, ob);
                    }
                    else if (notionalStepScheduleNode.Attributes["href"] != null)
                    {
                        notionalStepScheduleIDRef_ = notionalStepScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalStepSchedule_ = new NonNegativeAmountSchedule(notionalStepScheduleNode);
                    }
                }
                else
                {
                    notionalStepSchedule_ = new NonNegativeAmountSchedule(notionalStepScheduleNode);
                }
            }
            
        
            XmlNode notionalStepParametersNode = xmlNode.SelectSingleNode("notionalStepParameters");
            
            if (notionalStepParametersNode != null)
            {
                if (notionalStepParametersNode.Attributes["href"] != null || notionalStepParametersNode.Attributes["id"] != null) 
                {
                    if (notionalStepParametersNode.Attributes["id"] != null) 
                    {
                        notionalStepParametersIDRef_ = notionalStepParametersNode.Attributes["id"].Value;
                        NotionalStepRule ob = new NotionalStepRule(notionalStepParametersNode);
                        IDManager.SetID(notionalStepParametersIDRef_, ob);
                    }
                    else if (notionalStepParametersNode.Attributes["href"] != null)
                    {
                        notionalStepParametersIDRef_ = notionalStepParametersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalStepParameters_ = new NotionalStepRule(notionalStepParametersNode);
                    }
                }
                else
                {
                    notionalStepParameters_ = new NotionalStepRule(notionalStepParametersNode);
                }
            }
            
        
        }
        
    
        #region NotionalStepSchedule_
        private NonNegativeAmountSchedule notionalStepSchedule_;
        public NonNegativeAmountSchedule NotionalStepSchedule_
        {
            get
            {
                if (this.notionalStepSchedule_ != null)
                {
                    return this.notionalStepSchedule_; 
                }
                else if (this.notionalStepScheduleIDRef_ != null)
                {
                    notionalStepSchedule_ = IDManager.getID(notionalStepScheduleIDRef_) as NonNegativeAmountSchedule;
                    return this.notionalStepSchedule_; 
                }
                else
                {
                      return this.notionalStepSchedule_; 
                }
            }
            set
            {
                if (this.notionalStepSchedule_ != value)
                {
                    this.notionalStepSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string notionalStepScheduleIDRef_ { get; set; }
        #region NotionalStepParameters_
        private NotionalStepRule notionalStepParameters_;
        public NotionalStepRule NotionalStepParameters_
        {
            get
            {
                if (this.notionalStepParameters_ != null)
                {
                    return this.notionalStepParameters_; 
                }
                else if (this.notionalStepParametersIDRef_ != null)
                {
                    notionalStepParameters_ = IDManager.getID(notionalStepParametersIDRef_) as NotionalStepRule;
                    return this.notionalStepParameters_; 
                }
                else
                {
                      return this.notionalStepParameters_; 
                }
            }
            set
            {
                if (this.notionalStepParameters_ != value)
                {
                    this.notionalStepParameters_ = value;
                }
            }
        }
        #endregion
        
        public string notionalStepParametersIDRef_ { get; set; }
        
    
        
    
    }
    
}

