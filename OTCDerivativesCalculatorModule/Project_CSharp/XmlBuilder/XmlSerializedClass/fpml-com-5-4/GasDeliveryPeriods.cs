using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GasDeliveryPeriods : CommodityDeliveryPeriods
    {
        public GasDeliveryPeriods(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode supplyStartTimeNode = xmlNode.SelectSingleNode("supplyStartTime");
            
            if (supplyStartTimeNode != null)
            {
                if (supplyStartTimeNode.Attributes["href"] != null || supplyStartTimeNode.Attributes["id"] != null) 
                {
                    if (supplyStartTimeNode.Attributes["id"] != null) 
                    {
                        supplyStartTimeIDRef_ = supplyStartTimeNode.Attributes["id"].Value;
                        PrevailingTime ob = new PrevailingTime(supplyStartTimeNode);
                        IDManager.SetID(supplyStartTimeIDRef_, ob);
                    }
                    else if (supplyStartTimeNode.Attributes["href"] != null)
                    {
                        supplyStartTimeIDRef_ = supplyStartTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        supplyStartTime_ = new PrevailingTime(supplyStartTimeNode);
                    }
                }
                else
                {
                    supplyStartTime_ = new PrevailingTime(supplyStartTimeNode);
                }
            }
            
        
            XmlNode supplyEndTimeNode = xmlNode.SelectSingleNode("supplyEndTime");
            
            if (supplyEndTimeNode != null)
            {
                if (supplyEndTimeNode.Attributes["href"] != null || supplyEndTimeNode.Attributes["id"] != null) 
                {
                    if (supplyEndTimeNode.Attributes["id"] != null) 
                    {
                        supplyEndTimeIDRef_ = supplyEndTimeNode.Attributes["id"].Value;
                        PrevailingTime ob = new PrevailingTime(supplyEndTimeNode);
                        IDManager.SetID(supplyEndTimeIDRef_, ob);
                    }
                    else if (supplyEndTimeNode.Attributes["href"] != null)
                    {
                        supplyEndTimeIDRef_ = supplyEndTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        supplyEndTime_ = new PrevailingTime(supplyEndTimeNode);
                    }
                }
                else
                {
                    supplyEndTime_ = new PrevailingTime(supplyEndTimeNode);
                }
            }
            
        
        }
        
    
        #region SupplyStartTime_
        private PrevailingTime supplyStartTime_;
        public PrevailingTime SupplyStartTime_
        {
            get
            {
                if (this.supplyStartTime_ != null)
                {
                    return this.supplyStartTime_; 
                }
                else if (this.supplyStartTimeIDRef_ != null)
                {
                    supplyStartTime_ = IDManager.getID(supplyStartTimeIDRef_) as PrevailingTime;
                    return this.supplyStartTime_; 
                }
                else
                {
                      return this.supplyStartTime_; 
                }
            }
            set
            {
                if (this.supplyStartTime_ != value)
                {
                    this.supplyStartTime_ = value;
                }
            }
        }
        #endregion
        
        public string supplyStartTimeIDRef_ { get; set; }
        #region SupplyEndTime_
        private PrevailingTime supplyEndTime_;
        public PrevailingTime SupplyEndTime_
        {
            get
            {
                if (this.supplyEndTime_ != null)
                {
                    return this.supplyEndTime_; 
                }
                else if (this.supplyEndTimeIDRef_ != null)
                {
                    supplyEndTime_ = IDManager.getID(supplyEndTimeIDRef_) as PrevailingTime;
                    return this.supplyEndTime_; 
                }
                else
                {
                      return this.supplyEndTime_; 
                }
            }
            set
            {
                if (this.supplyEndTime_ != value)
                {
                    this.supplyEndTime_ = value;
                }
            }
        }
        #endregion
        
        public string supplyEndTimeIDRef_ { get; set; }
        
    
        
    
    }
    
}

