using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommoditySettlementPeriodsPriceSchedule : ISerialized
    {
        public CommoditySettlementPeriodsPriceSchedule(XmlNode xmlNode)
        {
            XmlNodeList settlementPeriodsPriceStepNodeList = xmlNode.SelectNodes("settlementPeriodsPriceStep");
            
            if (settlementPeriodsPriceStepNodeList != null)
            {
                this.settlementPeriodsPriceStep_ = new List<FixedPrice>();
                foreach (XmlNode item in settlementPeriodsPriceStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsPriceStepIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsPriceStep_.Add(new FixedPrice(item));
                            IDManager.SetID(settlementPeriodsPriceStepIDRef_, settlementPeriodsPriceStep_[settlementPeriodsPriceStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsPriceStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsPriceStep_.Add(new FixedPrice(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsPriceStep_.Add(new FixedPrice(item));
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
        
    
        #region SettlementPeriodsPriceStep_
        private List<FixedPrice> settlementPeriodsPriceStep_;
        public List<FixedPrice> SettlementPeriodsPriceStep_
        {
            get
            {
                if (this.settlementPeriodsPriceStep_ != null)
                {
                    return this.settlementPeriodsPriceStep_; 
                }
                else if (this.settlementPeriodsPriceStepIDRef_ != null)
                {
                    return this.settlementPeriodsPriceStep_; 
                }
                else
                {
                      return this.settlementPeriodsPriceStep_; 
                }
            }
            set
            {
                if (this.settlementPeriodsPriceStep_ != value)
                {
                    this.settlementPeriodsPriceStep_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsPriceStepIDRef_ { get; set; }
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

