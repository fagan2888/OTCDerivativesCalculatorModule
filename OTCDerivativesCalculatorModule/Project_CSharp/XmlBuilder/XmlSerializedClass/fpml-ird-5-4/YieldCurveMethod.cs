using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class YieldCurveMethod : ISerialized
    {
        public YieldCurveMethod(XmlNode xmlNode)
        {
            XmlNode settlementRateSourceNode = xmlNode.SelectSingleNode("settlementRateSource");
            
            if (settlementRateSourceNode != null)
            {
                if (settlementRateSourceNode.Attributes["href"] != null || settlementRateSourceNode.Attributes["id"] != null) 
                {
                    if (settlementRateSourceNode.Attributes["id"] != null) 
                    {
                        settlementRateSourceIDRef_ = settlementRateSourceNode.Attributes["id"].Value;
                        SettlementRateSource ob = new SettlementRateSource(settlementRateSourceNode);
                        IDManager.SetID(settlementRateSourceIDRef_, ob);
                    }
                    else if (settlementRateSourceNode.Attributes["href"] != null)
                    {
                        settlementRateSourceIDRef_ = settlementRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementRateSource_ = new SettlementRateSource(settlementRateSourceNode);
                    }
                }
                else
                {
                    settlementRateSource_ = new SettlementRateSource(settlementRateSourceNode);
                }
            }
            
        
            XmlNode quotationRateTypeNode = xmlNode.SelectSingleNode("quotationRateType");
            
            if (quotationRateTypeNode != null)
            {
                if (quotationRateTypeNode.Attributes["href"] != null || quotationRateTypeNode.Attributes["id"] != null) 
                {
                    if (quotationRateTypeNode.Attributes["id"] != null) 
                    {
                        quotationRateTypeIDRef_ = quotationRateTypeNode.Attributes["id"].Value;
                        QuotationRateTypeEnum ob = new QuotationRateTypeEnum(quotationRateTypeNode);
                        IDManager.SetID(quotationRateTypeIDRef_, ob);
                    }
                    else if (quotationRateTypeNode.Attributes["href"] != null)
                    {
                        quotationRateTypeIDRef_ = quotationRateTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotationRateType_ = new QuotationRateTypeEnum(quotationRateTypeNode);
                    }
                }
                else
                {
                    quotationRateType_ = new QuotationRateTypeEnum(quotationRateTypeNode);
                }
            }
            
        
        }
        
    
        #region SettlementRateSource_
        private SettlementRateSource settlementRateSource_;
        public SettlementRateSource SettlementRateSource_
        {
            get
            {
                if (this.settlementRateSource_ != null)
                {
                    return this.settlementRateSource_; 
                }
                else if (this.settlementRateSourceIDRef_ != null)
                {
                    settlementRateSource_ = IDManager.getID(settlementRateSourceIDRef_) as SettlementRateSource;
                    return this.settlementRateSource_; 
                }
                else
                {
                      return this.settlementRateSource_; 
                }
            }
            set
            {
                if (this.settlementRateSource_ != value)
                {
                    this.settlementRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string settlementRateSourceIDRef_ { get; set; }
        #region QuotationRateType_
        private QuotationRateTypeEnum quotationRateType_;
        public QuotationRateTypeEnum QuotationRateType_
        {
            get
            {
                if (this.quotationRateType_ != null)
                {
                    return this.quotationRateType_; 
                }
                else if (this.quotationRateTypeIDRef_ != null)
                {
                    quotationRateType_ = IDManager.getID(quotationRateTypeIDRef_) as QuotationRateTypeEnum;
                    return this.quotationRateType_; 
                }
                else
                {
                      return this.quotationRateType_; 
                }
            }
            set
            {
                if (this.quotationRateType_ != value)
                {
                    this.quotationRateType_ = value;
                }
            }
        }
        #endregion
        
        public string quotationRateTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

