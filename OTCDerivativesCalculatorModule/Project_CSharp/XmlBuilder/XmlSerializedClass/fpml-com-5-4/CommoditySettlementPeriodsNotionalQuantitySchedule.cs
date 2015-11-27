using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommoditySettlementPeriodsNotionalQuantitySchedule : ISerialized
    {
        public CommoditySettlementPeriodsNotionalQuantitySchedule(XmlNode xmlNode)
        {
            XmlNodeList settlementPeriodsNotionalQuantityStepNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantityStep");
            
            if (settlementPeriodsNotionalQuantityStepNodeList != null)
            {
                this.settlementPeriodsNotionalQuantityStep_ = new List<CommodityNotionalQuantity>();
                foreach (XmlNode item in settlementPeriodsNotionalQuantityStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsNotionalQuantityStepIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsNotionalQuantityStep_.Add(new CommodityNotionalQuantity(item));
                            IDManager.SetID(settlementPeriodsNotionalQuantityStepIDRef_, settlementPeriodsNotionalQuantityStep_[settlementPeriodsNotionalQuantityStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsNotionalQuantityStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsNotionalQuantityStep_.Add(new CommodityNotionalQuantity(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsNotionalQuantityStep_.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsReferenceNodeList = xmlNode.SelectNodes("settlementPeriodsReference");
            
            if (settlementPeriodsReferenceNodeList != null)
            {
                this.settlementPeriodsReference_ = new List<SettlementPeriodsReference>();
                foreach (XmlNode item in settlementPeriodsReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsReferenceIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                            IDManager.SetID(settlementPeriodsReferenceIDRef_, settlementPeriodsReference_[settlementPeriodsReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementPeriodsNotionalQuantityStep_
        private List<CommodityNotionalQuantity> settlementPeriodsNotionalQuantityStep_;
        public List<CommodityNotionalQuantity> SettlementPeriodsNotionalQuantityStep_
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantityStep_ != null)
                {
                    return this.settlementPeriodsNotionalQuantityStep_; 
                }
                else if (this.settlementPeriodsNotionalQuantityStepIDRef_ != null)
                {
                    return this.settlementPeriodsNotionalQuantityStep_; 
                }
                else
                {
                      return this.settlementPeriodsNotionalQuantityStep_; 
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantityStep_ != value)
                {
                    this.settlementPeriodsNotionalQuantityStep_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsNotionalQuantityStepIDRef_ { get; set; }
        #region SettlementPeriodsReference_
        private List<SettlementPeriodsReference> settlementPeriodsReference_;
        public List<SettlementPeriodsReference> SettlementPeriodsReference_
        {
            get
            {
                if (this.settlementPeriodsReference_ != null)
                {
                    return this.settlementPeriodsReference_; 
                }
                else if (this.settlementPeriodsReferenceIDRef_ != null)
                {
                    return this.settlementPeriodsReference_; 
                }
                else
                {
                      return this.settlementPeriodsReference_; 
                }
            }
            set
            {
                if (this.settlementPeriodsReference_ != value)
                {
                    this.settlementPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

