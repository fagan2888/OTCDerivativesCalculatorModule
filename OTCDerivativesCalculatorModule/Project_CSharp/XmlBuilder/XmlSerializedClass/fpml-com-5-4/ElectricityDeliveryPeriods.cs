using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryPeriods : CommodityDeliveryPeriods
    {
        public ElectricityDeliveryPeriods(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            if (settlementPeriodsNodeList != null)
            {
                this.settlementPeriods_ = new List<SettlementPeriods>();
                foreach (XmlNode item in settlementPeriodsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsIDRef_ = item.Attributes["id"].Value;
                            settlementPeriods_.Add(new SettlementPeriods(item));
                            IDManager.SetID(settlementPeriodsIDRef_, settlementPeriods_[settlementPeriods_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                        }
                    }
                    else
                    {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementPeriods_
        private List<SettlementPeriods> settlementPeriods_;
        public List<SettlementPeriods> SettlementPeriods_
        {
            get
            {
                if (this.settlementPeriods_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else if (this.settlementPeriodsIDRef_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else
                {
                      return this.settlementPeriods_; 
                }
            }
            set
            {
                if (this.settlementPeriods_ != value)
                {
                    this.settlementPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsIDRef_ { get; set; }
        
    
        
    
    }
    
}

