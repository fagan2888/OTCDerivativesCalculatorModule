using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class YieldCurveMethod
    {
        public YieldCurveMethod(XmlNode xmlNode)
        {
            XmlNodeList settlementRateSourceNodeList = xmlNode.SelectNodes("settlementRateSource");
            if (settlementRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementRateSourceIDRef = item.Attributes["id"].Name;
                        SettlementRateSource ob = SettlementRateSource();
                        IDManager.SetID(settlementRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementRateSource = new SettlementRateSource(item);
                    }
                }
            }
            
        
            XmlNodeList quotationRateTypeNodeList = xmlNode.SelectNodes("quotationRateType");
            if (quotationRateTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotationRateTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationRateTypeIDRef = item.Attributes["id"].Name;
                        QuotationRateTypeEnum ob = QuotationRateTypeEnum();
                        IDManager.SetID(quotationRateTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationRateTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotationRateType = new QuotationRateTypeEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementRateSource
        private SettlementRateSource settlementRateSource;
        public SettlementRateSource SettlementRateSource
        {
            get
            {
                if (this.settlementRateSource != null)
                {
                    return this.settlementRateSource; 
                }
                else if (this.settlementRateSourceIDRef != null)
                {
                    settlementRateSource = IDManager.getID(settlementRateSourceIDRef) as SettlementRateSource;
                    return this.settlementRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementRateSource != value)
                {
                    this.settlementRateSource = value;
                }
            }
        }
        #endregion
        
        public string SettlementRateSourceIDRef { get; set; }
        #region QuotationRateType
        private QuotationRateTypeEnum quotationRateType;
        public QuotationRateTypeEnum QuotationRateType
        {
            get
            {
                if (this.quotationRateType != null)
                {
                    return this.quotationRateType; 
                }
                else if (this.quotationRateTypeIDRef != null)
                {
                    quotationRateType = IDManager.getID(quotationRateTypeIDRef) as QuotationRateTypeEnum;
                    return this.quotationRateType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationRateType != value)
                {
                    this.quotationRateType = value;
                }
            }
        }
        #endregion
        
        public string QuotationRateTypeEnumIDRef { get; set; }
        
    
        
    
    }
    
}

