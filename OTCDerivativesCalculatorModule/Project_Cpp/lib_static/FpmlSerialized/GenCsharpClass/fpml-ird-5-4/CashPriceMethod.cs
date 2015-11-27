using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CashPriceMethod
    {
        public CashPriceMethod(XmlNode xmlNode)
        {
            XmlNodeList cashSettlementReferenceBanksNodeList = xmlNode.SelectNodes("cashSettlementReferenceBanks");
            if (cashSettlementReferenceBanksNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementReferenceBanksNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementReferenceBanksIDRef = item.Attributes["id"].Name;
                        CashSettlementReferenceBanks ob = CashSettlementReferenceBanks();
                        IDManager.SetID(cashSettlementReferenceBanksIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementReferenceBanksIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementReferenceBanks = new CashSettlementReferenceBanks(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementCurrencyNodeList = xmlNode.SelectNodes("cashSettlementCurrency");
            if (cashSettlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(cashSettlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementCurrency = new Currency(item);
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
        
    
        #region CashSettlementReferenceBanks
        private CashSettlementReferenceBanks cashSettlementReferenceBanks;
        public CashSettlementReferenceBanks CashSettlementReferenceBanks
        {
            get
            {
                if (this.cashSettlementReferenceBanks != null)
                {
                    return this.cashSettlementReferenceBanks; 
                }
                else if (this.cashSettlementReferenceBanksIDRef != null)
                {
                    cashSettlementReferenceBanks = IDManager.getID(cashSettlementReferenceBanksIDRef) as CashSettlementReferenceBanks;
                    return this.cashSettlementReferenceBanks; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementReferenceBanks != value)
                {
                    this.cashSettlementReferenceBanks = value;
                }
            }
        }
        #endregion
        
        public string CashSettlementReferenceBanksIDRef { get; set; }
        #region CashSettlementCurrency
        private Currency cashSettlementCurrency;
        public Currency CashSettlementCurrency
        {
            get
            {
                if (this.cashSettlementCurrency != null)
                {
                    return this.cashSettlementCurrency; 
                }
                else if (this.cashSettlementCurrencyIDRef != null)
                {
                    cashSettlementCurrency = IDManager.getID(cashSettlementCurrencyIDRef) as Currency;
                    return this.cashSettlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementCurrency != value)
                {
                    this.cashSettlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
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

