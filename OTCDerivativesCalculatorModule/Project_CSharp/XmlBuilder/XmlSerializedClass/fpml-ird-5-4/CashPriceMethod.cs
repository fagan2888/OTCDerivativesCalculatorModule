using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashPriceMethod : ISerialized
    {
        public CashPriceMethod(XmlNode xmlNode)
        {
            XmlNode cashSettlementReferenceBanksNode = xmlNode.SelectSingleNode("cashSettlementReferenceBanks");
            
            if (cashSettlementReferenceBanksNode != null)
            {
                if (cashSettlementReferenceBanksNode.Attributes["href"] != null || cashSettlementReferenceBanksNode.Attributes["id"] != null) 
                {
                    if (cashSettlementReferenceBanksNode.Attributes["id"] != null) 
                    {
                        cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode.Attributes["id"].Value;
                        CashSettlementReferenceBanks ob = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                        IDManager.SetID(cashSettlementReferenceBanksIDRef_, ob);
                    }
                    else if (cashSettlementReferenceBanksNode.Attributes["href"] != null)
                    {
                        cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementReferenceBanks_ = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                    }
                }
                else
                {
                    cashSettlementReferenceBanks_ = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                }
            }
            
        
            XmlNode cashSettlementCurrencyNode = xmlNode.SelectSingleNode("cashSettlementCurrency");
            
            if (cashSettlementCurrencyNode != null)
            {
                if (cashSettlementCurrencyNode.Attributes["href"] != null || cashSettlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (cashSettlementCurrencyNode.Attributes["id"] != null) 
                    {
                        cashSettlementCurrencyIDRef_ = cashSettlementCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(cashSettlementCurrencyNode);
                        IDManager.SetID(cashSettlementCurrencyIDRef_, ob);
                    }
                    else if (cashSettlementCurrencyNode.Attributes["href"] != null)
                    {
                        cashSettlementCurrencyIDRef_ = cashSettlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementCurrency_ = new Currency(cashSettlementCurrencyNode);
                    }
                }
                else
                {
                    cashSettlementCurrency_ = new Currency(cashSettlementCurrencyNode);
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
        
    
        #region CashSettlementReferenceBanks_
        private CashSettlementReferenceBanks cashSettlementReferenceBanks_;
        public CashSettlementReferenceBanks CashSettlementReferenceBanks_
        {
            get
            {
                if (this.cashSettlementReferenceBanks_ != null)
                {
                    return this.cashSettlementReferenceBanks_; 
                }
                else if (this.cashSettlementReferenceBanksIDRef_ != null)
                {
                    cashSettlementReferenceBanks_ = IDManager.getID(cashSettlementReferenceBanksIDRef_) as CashSettlementReferenceBanks;
                    return this.cashSettlementReferenceBanks_; 
                }
                else
                {
                      return this.cashSettlementReferenceBanks_; 
                }
            }
            set
            {
                if (this.cashSettlementReferenceBanks_ != value)
                {
                    this.cashSettlementReferenceBanks_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementReferenceBanksIDRef_ { get; set; }
        #region CashSettlementCurrency_
        private Currency cashSettlementCurrency_;
        public Currency CashSettlementCurrency_
        {
            get
            {
                if (this.cashSettlementCurrency_ != null)
                {
                    return this.cashSettlementCurrency_; 
                }
                else if (this.cashSettlementCurrencyIDRef_ != null)
                {
                    cashSettlementCurrency_ = IDManager.getID(cashSettlementCurrencyIDRef_) as Currency;
                    return this.cashSettlementCurrency_; 
                }
                else
                {
                      return this.cashSettlementCurrency_; 
                }
            }
            set
            {
                if (this.cashSettlementCurrency_ != value)
                {
                    this.cashSettlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementCurrencyIDRef_ { get; set; }
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

