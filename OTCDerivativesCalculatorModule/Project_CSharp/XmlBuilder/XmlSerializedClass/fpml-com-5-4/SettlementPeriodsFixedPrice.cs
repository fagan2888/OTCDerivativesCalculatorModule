using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementPeriodsFixedPrice : FixedPrice
    {
        public SettlementPeriodsFixedPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
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

