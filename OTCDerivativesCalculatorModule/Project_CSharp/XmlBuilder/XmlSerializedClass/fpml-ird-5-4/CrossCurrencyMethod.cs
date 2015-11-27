using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CrossCurrencyMethod : ISerialized
    {
        public CrossCurrencyMethod(XmlNode xmlNode)
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
            
        
            XmlNodeList cashSettlementCurrencyNodeList = xmlNode.SelectNodes("cashSettlementCurrency");
            
            if (cashSettlementCurrencyNodeList != null)
            {
                this.cashSettlementCurrency_ = new List<Currency>();
                foreach (XmlNode item in cashSettlementCurrencyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            cashSettlementCurrencyIDRef_ = item.Attributes["id"].Value;
                            cashSettlementCurrency_.Add(new Currency(item));
                            IDManager.SetID(cashSettlementCurrencyIDRef_, cashSettlementCurrency_[cashSettlementCurrency_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            cashSettlementCurrencyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        cashSettlementCurrency_.Add(new Currency(item));
                        }
                    }
                    else
                    {
                        cashSettlementCurrency_.Add(new Currency(item));
                    }
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
        private List<Currency> cashSettlementCurrency_;
        public List<Currency> CashSettlementCurrency_
        {
            get
            {
                if (this.cashSettlementCurrency_ != null)
                {
                    return this.cashSettlementCurrency_; 
                }
                else if (this.cashSettlementCurrencyIDRef_ != null)
                {
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

