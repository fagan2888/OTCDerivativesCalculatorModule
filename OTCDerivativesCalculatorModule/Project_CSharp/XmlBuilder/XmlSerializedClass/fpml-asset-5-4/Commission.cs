using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Commission : ISerialized
    {
        public Commission(XmlNode xmlNode)
        {
            XmlNode commissionDenominationNode = xmlNode.SelectSingleNode("commissionDenomination");
            
            if (commissionDenominationNode != null)
            {
                if (commissionDenominationNode.Attributes["href"] != null || commissionDenominationNode.Attributes["id"] != null) 
                {
                    if (commissionDenominationNode.Attributes["id"] != null) 
                    {
                        commissionDenominationIDRef_ = commissionDenominationNode.Attributes["id"].Value;
                        CommissionDenominationEnum ob = new CommissionDenominationEnum(commissionDenominationNode);
                        IDManager.SetID(commissionDenominationIDRef_, ob);
                    }
                    else if (commissionDenominationNode.Attributes["href"] != null)
                    {
                        commissionDenominationIDRef_ = commissionDenominationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commissionDenomination_ = new CommissionDenominationEnum(commissionDenominationNode);
                    }
                }
                else
                {
                    commissionDenomination_ = new CommissionDenominationEnum(commissionDenominationNode);
                }
            }
            
        
            XmlNode commissionAmountNode = xmlNode.SelectSingleNode("commissionAmount");
            
            if (commissionAmountNode != null)
            {
                if (commissionAmountNode.Attributes["href"] != null || commissionAmountNode.Attributes["id"] != null) 
                {
                    if (commissionAmountNode.Attributes["id"] != null) 
                    {
                        commissionAmountIDRef_ = commissionAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(commissionAmountNode);
                        IDManager.SetID(commissionAmountIDRef_, ob);
                    }
                    else if (commissionAmountNode.Attributes["href"] != null)
                    {
                        commissionAmountIDRef_ = commissionAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commissionAmount_ = new XsdTypeDecimal(commissionAmountNode);
                    }
                }
                else
                {
                    commissionAmount_ = new XsdTypeDecimal(commissionAmountNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode commissionPerTradeNode = xmlNode.SelectSingleNode("commissionPerTrade");
            
            if (commissionPerTradeNode != null)
            {
                if (commissionPerTradeNode.Attributes["href"] != null || commissionPerTradeNode.Attributes["id"] != null) 
                {
                    if (commissionPerTradeNode.Attributes["id"] != null) 
                    {
                        commissionPerTradeIDRef_ = commissionPerTradeNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(commissionPerTradeNode);
                        IDManager.SetID(commissionPerTradeIDRef_, ob);
                    }
                    else if (commissionPerTradeNode.Attributes["href"] != null)
                    {
                        commissionPerTradeIDRef_ = commissionPerTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commissionPerTrade_ = new XsdTypeDecimal(commissionPerTradeNode);
                    }
                }
                else
                {
                    commissionPerTrade_ = new XsdTypeDecimal(commissionPerTradeNode);
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            if (fxRateNodeList != null)
            {
                this.fxRate_ = new List<FxRate>();
                foreach (XmlNode item in fxRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fxRateIDRef_ = item.Attributes["id"].Value;
                            fxRate_.Add(new FxRate(item));
                            IDManager.SetID(fxRateIDRef_, fxRate_[fxRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fxRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fxRate_.Add(new FxRate(item));
                        }
                    }
                    else
                    {
                        fxRate_.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region CommissionDenomination_
        private CommissionDenominationEnum commissionDenomination_;
        public CommissionDenominationEnum CommissionDenomination_
        {
            get
            {
                if (this.commissionDenomination_ != null)
                {
                    return this.commissionDenomination_; 
                }
                else if (this.commissionDenominationIDRef_ != null)
                {
                    commissionDenomination_ = IDManager.getID(commissionDenominationIDRef_) as CommissionDenominationEnum;
                    return this.commissionDenomination_; 
                }
                else
                {
                      return this.commissionDenomination_; 
                }
            }
            set
            {
                if (this.commissionDenomination_ != value)
                {
                    this.commissionDenomination_ = value;
                }
            }
        }
        #endregion
        
        public string commissionDenominationIDRef_ { get; set; }
        #region CommissionAmount_
        private XsdTypeDecimal commissionAmount_;
        public XsdTypeDecimal CommissionAmount_
        {
            get
            {
                if (this.commissionAmount_ != null)
                {
                    return this.commissionAmount_; 
                }
                else if (this.commissionAmountIDRef_ != null)
                {
                    commissionAmount_ = IDManager.getID(commissionAmountIDRef_) as XsdTypeDecimal;
                    return this.commissionAmount_; 
                }
                else
                {
                      return this.commissionAmount_; 
                }
            }
            set
            {
                if (this.commissionAmount_ != value)
                {
                    this.commissionAmount_ = value;
                }
            }
        }
        #endregion
        
        public string commissionAmountIDRef_ { get; set; }
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region CommissionPerTrade_
        private XsdTypeDecimal commissionPerTrade_;
        public XsdTypeDecimal CommissionPerTrade_
        {
            get
            {
                if (this.commissionPerTrade_ != null)
                {
                    return this.commissionPerTrade_; 
                }
                else if (this.commissionPerTradeIDRef_ != null)
                {
                    commissionPerTrade_ = IDManager.getID(commissionPerTradeIDRef_) as XsdTypeDecimal;
                    return this.commissionPerTrade_; 
                }
                else
                {
                      return this.commissionPerTrade_; 
                }
            }
            set
            {
                if (this.commissionPerTrade_ != value)
                {
                    this.commissionPerTrade_ = value;
                }
            }
        }
        #endregion
        
        public string commissionPerTradeIDRef_ { get; set; }
        #region FxRate_
        private List<FxRate> fxRate_;
        public List<FxRate> FxRate_
        {
            get
            {
                if (this.fxRate_ != null)
                {
                    return this.fxRate_; 
                }
                else if (this.fxRateIDRef_ != null)
                {
                    return this.fxRate_; 
                }
                else
                {
                      return this.fxRate_; 
                }
            }
            set
            {
                if (this.fxRate_ != value)
                {
                    this.fxRate_ = value;
                }
            }
        }
        #endregion
        
        public string fxRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

