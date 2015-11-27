using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Fx_exchangeLeg : ISerialized
    {
        public Fx_exchangeLeg() { }
        public Fx_exchangeLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode targetNotionalNode = xmlNode.SelectSingleNode("targetNotional");
            
            if (targetNotionalNode != null)
            {
                if (targetNotionalNode.Attributes["href"] != null || targetNotionalNode.Attributes["id"] != null) 
                {
                    if (targetNotionalNode.Attributes["id"] != null) 
                    {
                        targetNotionalIDRef_ = targetNotionalNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(targetNotionalNode);
                        IDManager.SetID(targetNotionalIDRef_, ob);
                    }
                    else if (targetNotionalNode.Attributes["href"] != null)
                    {
                        targetNotionalIDRef_ = targetNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        targetNotional_ = new XsdTypeToken(targetNotionalNode);
                    }
                }
                else
                {
                    targetNotional_ = new XsdTypeToken(targetNotionalNode);
                }
            }
            
        
            XmlNode targetCurrencyNode = xmlNode.SelectSingleNode("targetCurrency");
            
            if (targetCurrencyNode != null)
            {
                if (targetCurrencyNode.Attributes["href"] != null || targetCurrencyNode.Attributes["id"] != null) 
                {
                    if (targetCurrencyNode.Attributes["id"] != null) 
                    {
                        targetCurrencyIDRef_ = targetCurrencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(targetCurrencyNode);
                        IDManager.SetID(targetCurrencyIDRef_, ob);
                    }
                    else if (targetCurrencyNode.Attributes["href"] != null)
                    {
                        targetCurrencyIDRef_ = targetCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        targetCurrency_ = new XsdTypeToken(targetCurrencyNode);
                    }
                }
                else
                {
                    targetCurrency_ = new XsdTypeToken(targetCurrencyNode);
                }
            }
            
        
            XmlNode baseNotionalNode = xmlNode.SelectSingleNode("baseNotional");
            
            if (baseNotionalNode != null)
            {
                if (baseNotionalNode.Attributes["href"] != null || baseNotionalNode.Attributes["id"] != null) 
                {
                    if (baseNotionalNode.Attributes["id"] != null) 
                    {
                        baseNotionalIDRef_ = baseNotionalNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(baseNotionalNode);
                        IDManager.SetID(baseNotionalIDRef_, ob);
                    }
                    else if (baseNotionalNode.Attributes["href"] != null)
                    {
                        baseNotionalIDRef_ = baseNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseNotional_ = new XsdTypeToken(baseNotionalNode);
                    }
                }
                else
                {
                    baseNotional_ = new XsdTypeToken(baseNotionalNode);
                }
            }
            
        
            XmlNode baseCurrencyNode = xmlNode.SelectSingleNode("baseCurrency");
            
            if (baseCurrencyNode != null)
            {
                if (baseCurrencyNode.Attributes["href"] != null || baseCurrencyNode.Attributes["id"] != null) 
                {
                    if (baseCurrencyNode.Attributes["id"] != null) 
                    {
                        baseCurrencyIDRef_ = baseCurrencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(baseCurrencyNode);
                        IDManager.SetID(baseCurrencyIDRef_, ob);
                    }
                    else if (baseCurrencyNode.Attributes["href"] != null)
                    {
                        baseCurrencyIDRef_ = baseCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseCurrency_ = new XsdTypeToken(baseCurrencyNode);
                    }
                }
                else
                {
                    baseCurrency_ = new XsdTypeToken(baseCurrencyNode);
                }
            }
            
        
            XmlNode exchangeTypeNode = xmlNode.SelectSingleNode("exchangeType");
            
            if (exchangeTypeNode != null)
            {
                if (exchangeTypeNode.Attributes["href"] != null || exchangeTypeNode.Attributes["id"] != null) 
                {
                    if (exchangeTypeNode.Attributes["id"] != null) 
                    {
                        exchangeTypeIDRef_ = exchangeTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(exchangeTypeNode);
                        IDManager.SetID(exchangeTypeIDRef_, ob);
                    }
                    else if (exchangeTypeNode.Attributes["href"] != null)
                    {
                        exchangeTypeIDRef_ = exchangeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeType_ = new XsdTypeToken(exchangeTypeNode);
                    }
                }
                else
                {
                    exchangeType_ = new XsdTypeToken(exchangeTypeNode);
                }
            }
            
        
            XmlNode exchangeRateNode = xmlNode.SelectSingleNode("exchangeRate");
            
            if (exchangeRateNode != null)
            {
                if (exchangeRateNode.Attributes["href"] != null || exchangeRateNode.Attributes["id"] != null) 
                {
                    if (exchangeRateNode.Attributes["id"] != null) 
                    {
                        exchangeRateIDRef_ = exchangeRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(exchangeRateNode);
                        IDManager.SetID(exchangeRateIDRef_, ob);
                    }
                    else if (exchangeRateNode.Attributes["href"] != null)
                    {
                        exchangeRateIDRef_ = exchangeRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeRate_ = new XsdTypeToken(exchangeRateNode);
                    }
                }
                else
                {
                    exchangeRate_ = new XsdTypeToken(exchangeRateNode);
                }
            }
            
        
            XmlNode calculationDateNode = xmlNode.SelectSingleNode("calculationDate");
            
            if (calculationDateNode != null)
            {
                if (calculationDateNode.Attributes["href"] != null || calculationDateNode.Attributes["id"] != null) 
                {
                    if (calculationDateNode.Attributes["id"] != null) 
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationDateNode);
                        IDManager.SetID(calculationDateIDRef_, ob);
                    }
                    else if (calculationDateNode.Attributes["href"] != null)
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDate_ = new XsdTypeToken(calculationDateNode);
                    }
                }
                else
                {
                    calculationDate_ = new XsdTypeToken(calculationDateNode);
                }
            }
            
        
            XmlNode paymentDaysNode = xmlNode.SelectSingleNode("paymentDays");
            
            if (paymentDaysNode != null)
            {
                if (paymentDaysNode.Attributes["href"] != null || paymentDaysNode.Attributes["id"] != null) 
                {
                    if (paymentDaysNode.Attributes["id"] != null) 
                    {
                        paymentDaysIDRef_ = paymentDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(paymentDaysNode);
                        IDManager.SetID(paymentDaysIDRef_, ob);
                    }
                    else if (paymentDaysNode.Attributes["href"] != null)
                    {
                        paymentDaysIDRef_ = paymentDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDays_ = new XsdTypeToken(paymentDaysNode);
                    }
                }
                else
                {
                    paymentDays_ = new XsdTypeToken(paymentDaysNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new XsdTypeToken(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new XsdTypeToken(paymentDateNode);
                }
            }
            
        
            XmlNode forwardFlagNode = xmlNode.SelectSingleNode("forwardFlag");
            
            if (forwardFlagNode != null)
            {
                if (forwardFlagNode.Attributes["href"] != null || forwardFlagNode.Attributes["id"] != null) 
                {
                    if (forwardFlagNode.Attributes["id"] != null) 
                    {
                        forwardFlagIDRef_ = forwardFlagNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(forwardFlagNode);
                        IDManager.SetID(forwardFlagIDRef_, ob);
                    }
                    else if (forwardFlagNode.Attributes["href"] != null)
                    {
                        forwardFlagIDRef_ = forwardFlagNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardFlag_ = new XsdTypeToken(forwardFlagNode);
                    }
                }
                else
                {
                    forwardFlag_ = new XsdTypeToken(forwardFlagNode);
                }
            }
            
        
            XmlNode forwardPointNode = xmlNode.SelectSingleNode("forwardPoint");
            
            if (forwardPointNode != null)
            {
                if (forwardPointNode.Attributes["href"] != null || forwardPointNode.Attributes["id"] != null) 
                {
                    if (forwardPointNode.Attributes["id"] != null) 
                    {
                        forwardPointIDRef_ = forwardPointNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(forwardPointNode);
                        IDManager.SetID(forwardPointIDRef_, ob);
                    }
                    else if (forwardPointNode.Attributes["href"] != null)
                    {
                        forwardPointIDRef_ = forwardPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardPoint_ = new XsdTypeToken(forwardPointNode);
                    }
                }
                else
                {
                    forwardPoint_ = new XsdTypeToken(forwardPointNode);
                }
            }
            
        
        }
        
    
        #region TargetNotional_
        private XsdTypeToken targetNotional_;
        public XsdTypeToken TargetNotional_
        {
            get
            {
                if (this.targetNotional_ != null)
                {
                    return this.targetNotional_; 
                }
                else if (this.targetNotionalIDRef_ != null)
                {
                    targetNotional_ = IDManager.getID(targetNotionalIDRef_) as XsdTypeToken;
                    return this.targetNotional_; 
                }
                else
                {
                    throw new Exception( "targetNotional_Node no exist!");
                }
            }
            set
            {
                if (this.targetNotional_ != value)
                {
                    this.targetNotional_ = value;
                }
            }
        }
        #endregion
        
        public string targetNotionalIDRef_ { get; set; }
        #region TargetCurrency_
        private XsdTypeToken targetCurrency_;
        public XsdTypeToken TargetCurrency_
        {
            get
            {
                if (this.targetCurrency_ != null)
                {
                    return this.targetCurrency_; 
                }
                else if (this.targetCurrencyIDRef_ != null)
                {
                    targetCurrency_ = IDManager.getID(targetCurrencyIDRef_) as XsdTypeToken;
                    return this.targetCurrency_; 
                }
                else
                {
                    throw new Exception( "targetCurrency_Node no exist!");
                }
            }
            set
            {
                if (this.targetCurrency_ != value)
                {
                    this.targetCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string targetCurrencyIDRef_ { get; set; }
        #region BaseNotional_
        private XsdTypeToken baseNotional_;
        public XsdTypeToken BaseNotional_
        {
            get
            {
                if (this.baseNotional_ != null)
                {
                    return this.baseNotional_; 
                }
                else if (this.baseNotionalIDRef_ != null)
                {
                    baseNotional_ = IDManager.getID(baseNotionalIDRef_) as XsdTypeToken;
                    return this.baseNotional_; 
                }
                else
                {
                    throw new Exception( "baseNotional_Node no exist!");
                }
            }
            set
            {
                if (this.baseNotional_ != value)
                {
                    this.baseNotional_ = value;
                }
            }
        }
        #endregion
        
        public string baseNotionalIDRef_ { get; set; }
        #region BaseCurrency_
        private XsdTypeToken baseCurrency_;
        public XsdTypeToken BaseCurrency_
        {
            get
            {
                if (this.baseCurrency_ != null)
                {
                    return this.baseCurrency_; 
                }
                else if (this.baseCurrencyIDRef_ != null)
                {
                    baseCurrency_ = IDManager.getID(baseCurrencyIDRef_) as XsdTypeToken;
                    return this.baseCurrency_; 
                }
                else
                {
                    throw new Exception( "baseCurrency_Node no exist!");
                }
            }
            set
            {
                if (this.baseCurrency_ != value)
                {
                    this.baseCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string baseCurrencyIDRef_ { get; set; }
        #region ExchangeType_
        private XsdTypeToken exchangeType_;
        public XsdTypeToken ExchangeType_
        {
            get
            {
                if (this.exchangeType_ != null)
                {
                    return this.exchangeType_; 
                }
                else if (this.exchangeTypeIDRef_ != null)
                {
                    exchangeType_ = IDManager.getID(exchangeTypeIDRef_) as XsdTypeToken;
                    return this.exchangeType_; 
                }
                else
                {
                    throw new Exception( "exchangeType_Node no exist!");
                }
            }
            set
            {
                if (this.exchangeType_ != value)
                {
                    this.exchangeType_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeTypeIDRef_ { get; set; }
        #region ExchangeRate_
        private XsdTypeToken exchangeRate_;
        public XsdTypeToken ExchangeRate_
        {
            get
            {
                if (this.exchangeRate_ != null)
                {
                    return this.exchangeRate_; 
                }
                else if (this.exchangeRateIDRef_ != null)
                {
                    exchangeRate_ = IDManager.getID(exchangeRateIDRef_) as XsdTypeToken;
                    return this.exchangeRate_; 
                }
                else
                {
                    throw new Exception( "exchangeRate_Node no exist!");
                }
            }
            set
            {
                if (this.exchangeRate_ != value)
                {
                    this.exchangeRate_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeRateIDRef_ { get; set; }
        #region CalculationDate_
        private XsdTypeToken calculationDate_;
        public XsdTypeToken CalculationDate_
        {
            get
            {
                if (this.calculationDate_ != null)
                {
                    return this.calculationDate_; 
                }
                else if (this.calculationDateIDRef_ != null)
                {
                    calculationDate_ = IDManager.getID(calculationDateIDRef_) as XsdTypeToken;
                    return this.calculationDate_; 
                }
                else
                {
                    throw new Exception( "calculationDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDateIDRef_ { get; set; }
        #region PaymentDays_
        private XsdTypeToken paymentDays_;
        public XsdTypeToken PaymentDays_
        {
            get
            {
                if (this.paymentDays_ != null)
                {
                    return this.paymentDays_; 
                }
                else if (this.paymentDaysIDRef_ != null)
                {
                    paymentDays_ = IDManager.getID(paymentDaysIDRef_) as XsdTypeToken;
                    return this.paymentDays_; 
                }
                else
                {
                    throw new Exception( "paymentDays_Node no exist!");
                }
            }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDaysIDRef_ { get; set; }
        #region PaymentDate_
        private XsdTypeToken paymentDate_;
        public XsdTypeToken PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as XsdTypeToken;
                    return this.paymentDate_; 
                }
                else
                {
                    throw new Exception( "paymentDate_Node no exist!");
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
        #region ForwardFlag_
        private XsdTypeToken forwardFlag_;
        public XsdTypeToken ForwardFlag_
        {
            get
            {
                if (this.forwardFlag_ != null)
                {
                    return this.forwardFlag_; 
                }
                else if (this.forwardFlagIDRef_ != null)
                {
                    forwardFlag_ = IDManager.getID(forwardFlagIDRef_) as XsdTypeToken;
                    return this.forwardFlag_; 
                }
                else
                {
                    throw new Exception( "forwardFlag_Node no exist!");
                }
            }
            set
            {
                if (this.forwardFlag_ != value)
                {
                    this.forwardFlag_ = value;
                }
            }
        }
        #endregion
        
        public string forwardFlagIDRef_ { get; set; }
        #region ForwardPoint_
        private XsdTypeToken forwardPoint_;
        public XsdTypeToken ForwardPoint_
        {
            get
            {
                if (this.forwardPoint_ != null)
                {
                    return this.forwardPoint_; 
                }
                else if (this.forwardPointIDRef_ != null)
                {
                    forwardPoint_ = IDManager.getID(forwardPointIDRef_) as XsdTypeToken;
                    return this.forwardPoint_; 
                }
                else
                {
                    throw new Exception( "forwardPoint_Node no exist!");
                }
            }
            set
            {
                if (this.forwardPoint_ != value)
                {
                    this.forwardPoint_ = value;
                }
            }
        }
        #endregion
        
        public string forwardPointIDRef_ { get; set; }
        
    
        
    
    }
    
}

