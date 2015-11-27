using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxSingleLeg : Product
    {
        public FxSingleLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode exchangedCurrency1Node = xmlNode.SelectSingleNode("exchangedCurrency1");
            
            if (exchangedCurrency1Node != null)
            {
                if (exchangedCurrency1Node.Attributes["href"] != null || exchangedCurrency1Node.Attributes["id"] != null) 
                {
                    if (exchangedCurrency1Node.Attributes["id"] != null) 
                    {
                        exchangedCurrency1IDRef_ = exchangedCurrency1Node.Attributes["id"].Value;
                        Payment ob = new Payment(exchangedCurrency1Node);
                        IDManager.SetID(exchangedCurrency1IDRef_, ob);
                    }
                    else if (exchangedCurrency1Node.Attributes["href"] != null)
                    {
                        exchangedCurrency1IDRef_ = exchangedCurrency1Node.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangedCurrency1_ = new Payment(exchangedCurrency1Node);
                    }
                }
                else
                {
                    exchangedCurrency1_ = new Payment(exchangedCurrency1Node);
                }
            }
            
        
            XmlNode exchangedCurrency2Node = xmlNode.SelectSingleNode("exchangedCurrency2");
            
            if (exchangedCurrency2Node != null)
            {
                if (exchangedCurrency2Node.Attributes["href"] != null || exchangedCurrency2Node.Attributes["id"] != null) 
                {
                    if (exchangedCurrency2Node.Attributes["id"] != null) 
                    {
                        exchangedCurrency2IDRef_ = exchangedCurrency2Node.Attributes["id"].Value;
                        Payment ob = new Payment(exchangedCurrency2Node);
                        IDManager.SetID(exchangedCurrency2IDRef_, ob);
                    }
                    else if (exchangedCurrency2Node.Attributes["href"] != null)
                    {
                        exchangedCurrency2IDRef_ = exchangedCurrency2Node.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangedCurrency2_ = new Payment(exchangedCurrency2Node);
                    }
                }
                else
                {
                    exchangedCurrency2_ = new Payment(exchangedCurrency2Node);
                }
            }
            
        
            XmlNode dealtCurrencyNode = xmlNode.SelectSingleNode("dealtCurrency");
            
            if (dealtCurrencyNode != null)
            {
                if (dealtCurrencyNode.Attributes["href"] != null || dealtCurrencyNode.Attributes["id"] != null) 
                {
                    if (dealtCurrencyNode.Attributes["id"] != null) 
                    {
                        dealtCurrencyIDRef_ = dealtCurrencyNode.Attributes["id"].Value;
                        DealtCurrencyEnum ob = new DealtCurrencyEnum(dealtCurrencyNode);
                        IDManager.SetID(dealtCurrencyIDRef_, ob);
                    }
                    else if (dealtCurrencyNode.Attributes["href"] != null)
                    {
                        dealtCurrencyIDRef_ = dealtCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dealtCurrency_ = new DealtCurrencyEnum(dealtCurrencyNode);
                    }
                }
                else
                {
                    dealtCurrency_ = new DealtCurrencyEnum(dealtCurrencyNode);
                }
            }
            
        
            XmlNode tenorNameNode = xmlNode.SelectSingleNode("tenorName");
            
            if (tenorNameNode != null)
            {
                if (tenorNameNode.Attributes["href"] != null || tenorNameNode.Attributes["id"] != null) 
                {
                    if (tenorNameNode.Attributes["id"] != null) 
                    {
                        tenorNameIDRef_ = tenorNameNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(tenorNameNode);
                        IDManager.SetID(tenorNameIDRef_, ob);
                    }
                    else if (tenorNameNode.Attributes["href"] != null)
                    {
                        tenorNameIDRef_ = tenorNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenorName_ = new XsdTypeBoolean(tenorNameNode);
                    }
                }
                else
                {
                    tenorName_ = new XsdTypeBoolean(tenorNameNode);
                }
            }
            
        
            XmlNode tenorPeriodNode = xmlNode.SelectSingleNode("tenorPeriod");
            
            if (tenorPeriodNode != null)
            {
                if (tenorPeriodNode.Attributes["href"] != null || tenorPeriodNode.Attributes["id"] != null) 
                {
                    if (tenorPeriodNode.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["id"].Value;
                        Period ob = new Period(tenorPeriodNode);
                        IDManager.SetID(tenorPeriodIDRef_, ob);
                    }
                    else if (tenorPeriodNode.Attributes["href"] != null)
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenorPeriod_ = new Period(tenorPeriodNode);
                    }
                }
                else
                {
                    tenorPeriod_ = new Period(tenorPeriodNode);
                }
            }
            
        
            XmlNode valueDateNode = xmlNode.SelectSingleNode("valueDate");
            
            if (valueDateNode != null)
            {
                if (valueDateNode.Attributes["href"] != null || valueDateNode.Attributes["id"] != null) 
                {
                    if (valueDateNode.Attributes["id"] != null) 
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(valueDateNode);
                        IDManager.SetID(valueDateIDRef_, ob);
                    }
                    else if (valueDateNode.Attributes["href"] != null)
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valueDate_ = new XsdTypeDate(valueDateNode);
                    }
                }
                else
                {
                    valueDate_ = new XsdTypeDate(valueDateNode);
                }
            }
            
        
            XmlNode currency1ValueDateNode = xmlNode.SelectSingleNode("currency1ValueDate");
            
            if (currency1ValueDateNode != null)
            {
                if (currency1ValueDateNode.Attributes["href"] != null || currency1ValueDateNode.Attributes["id"] != null) 
                {
                    if (currency1ValueDateNode.Attributes["id"] != null) 
                    {
                        currency1ValueDateIDRef_ = currency1ValueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(currency1ValueDateNode);
                        IDManager.SetID(currency1ValueDateIDRef_, ob);
                    }
                    else if (currency1ValueDateNode.Attributes["href"] != null)
                    {
                        currency1ValueDateIDRef_ = currency1ValueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency1ValueDate_ = new XsdTypeDate(currency1ValueDateNode);
                    }
                }
                else
                {
                    currency1ValueDate_ = new XsdTypeDate(currency1ValueDateNode);
                }
            }
            
        
            XmlNode currency2ValueDateNode = xmlNode.SelectSingleNode("currency2ValueDate");
            
            if (currency2ValueDateNode != null)
            {
                if (currency2ValueDateNode.Attributes["href"] != null || currency2ValueDateNode.Attributes["id"] != null) 
                {
                    if (currency2ValueDateNode.Attributes["id"] != null) 
                    {
                        currency2ValueDateIDRef_ = currency2ValueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(currency2ValueDateNode);
                        IDManager.SetID(currency2ValueDateIDRef_, ob);
                    }
                    else if (currency2ValueDateNode.Attributes["href"] != null)
                    {
                        currency2ValueDateIDRef_ = currency2ValueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency2ValueDate_ = new XsdTypeDate(currency2ValueDateNode);
                    }
                }
                else
                {
                    currency2ValueDate_ = new XsdTypeDate(currency2ValueDateNode);
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
                        ExchangeRate ob = new ExchangeRate(exchangeRateNode);
                        IDManager.SetID(exchangeRateIDRef_, ob);
                    }
                    else if (exchangeRateNode.Attributes["href"] != null)
                    {
                        exchangeRateIDRef_ = exchangeRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeRate_ = new ExchangeRate(exchangeRateNode);
                    }
                }
                else
                {
                    exchangeRate_ = new ExchangeRate(exchangeRateNode);
                }
            }
            
        
            XmlNode nonDeliverableSettlementNode = xmlNode.SelectSingleNode("nonDeliverableSettlement");
            
            if (nonDeliverableSettlementNode != null)
            {
                if (nonDeliverableSettlementNode.Attributes["href"] != null || nonDeliverableSettlementNode.Attributes["id"] != null) 
                {
                    if (nonDeliverableSettlementNode.Attributes["id"] != null) 
                    {
                        nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode.Attributes["id"].Value;
                        FxCashSettlement ob = new FxCashSettlement(nonDeliverableSettlementNode);
                        IDManager.SetID(nonDeliverableSettlementIDRef_, ob);
                    }
                    else if (nonDeliverableSettlementNode.Attributes["href"] != null)
                    {
                        nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonDeliverableSettlement_ = new FxCashSettlement(nonDeliverableSettlementNode);
                    }
                }
                else
                {
                    nonDeliverableSettlement_ = new FxCashSettlement(nonDeliverableSettlementNode);
                }
            }
            
        
        }
        
    
        #region ExchangedCurrency1_
        private Payment exchangedCurrency1_;
        public Payment ExchangedCurrency1_
        {
            get
            {
                if (this.exchangedCurrency1_ != null)
                {
                    return this.exchangedCurrency1_; 
                }
                else if (this.exchangedCurrency1IDRef_ != null)
                {
                    exchangedCurrency1_ = IDManager.getID(exchangedCurrency1IDRef_) as Payment;
                    return this.exchangedCurrency1_; 
                }
                else
                {
                      return this.exchangedCurrency1_; 
                }
            }
            set
            {
                if (this.exchangedCurrency1_ != value)
                {
                    this.exchangedCurrency1_ = value;
                }
            }
        }
        #endregion
        
        public string exchangedCurrency1IDRef_ { get; set; }
        #region ExchangedCurrency2_
        private Payment exchangedCurrency2_;
        public Payment ExchangedCurrency2_
        {
            get
            {
                if (this.exchangedCurrency2_ != null)
                {
                    return this.exchangedCurrency2_; 
                }
                else if (this.exchangedCurrency2IDRef_ != null)
                {
                    exchangedCurrency2_ = IDManager.getID(exchangedCurrency2IDRef_) as Payment;
                    return this.exchangedCurrency2_; 
                }
                else
                {
                      return this.exchangedCurrency2_; 
                }
            }
            set
            {
                if (this.exchangedCurrency2_ != value)
                {
                    this.exchangedCurrency2_ = value;
                }
            }
        }
        #endregion
        
        public string exchangedCurrency2IDRef_ { get; set; }
        #region DealtCurrency_
        private DealtCurrencyEnum dealtCurrency_;
        public DealtCurrencyEnum DealtCurrency_
        {
            get
            {
                if (this.dealtCurrency_ != null)
                {
                    return this.dealtCurrency_; 
                }
                else if (this.dealtCurrencyIDRef_ != null)
                {
                    dealtCurrency_ = IDManager.getID(dealtCurrencyIDRef_) as DealtCurrencyEnum;
                    return this.dealtCurrency_; 
                }
                else
                {
                      return this.dealtCurrency_; 
                }
            }
            set
            {
                if (this.dealtCurrency_ != value)
                {
                    this.dealtCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string dealtCurrencyIDRef_ { get; set; }
        #region TenorName_
        private XsdTypeBoolean tenorName_;
        public XsdTypeBoolean TenorName_
        {
            get
            {
                if (this.tenorName_ != null)
                {
                    return this.tenorName_; 
                }
                else if (this.tenorNameIDRef_ != null)
                {
                    tenorName_ = IDManager.getID(tenorNameIDRef_) as XsdTypeBoolean;
                    return this.tenorName_; 
                }
                else
                {
                      return this.tenorName_; 
                }
            }
            set
            {
                if (this.tenorName_ != value)
                {
                    this.tenorName_ = value;
                }
            }
        }
        #endregion
        
        public string tenorNameIDRef_ { get; set; }
        #region TenorPeriod_
        private Period tenorPeriod_;
        public Period TenorPeriod_
        {
            get
            {
                if (this.tenorPeriod_ != null)
                {
                    return this.tenorPeriod_; 
                }
                else if (this.tenorPeriodIDRef_ != null)
                {
                    tenorPeriod_ = IDManager.getID(tenorPeriodIDRef_) as Period;
                    return this.tenorPeriod_; 
                }
                else
                {
                      return this.tenorPeriod_; 
                }
            }
            set
            {
                if (this.tenorPeriod_ != value)
                {
                    this.tenorPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string tenorPeriodIDRef_ { get; set; }
        #region ValueDate_
        private XsdTypeDate valueDate_;
        public XsdTypeDate ValueDate_
        {
            get
            {
                if (this.valueDate_ != null)
                {
                    return this.valueDate_; 
                }
                else if (this.valueDateIDRef_ != null)
                {
                    valueDate_ = IDManager.getID(valueDateIDRef_) as XsdTypeDate;
                    return this.valueDate_; 
                }
                else
                {
                      return this.valueDate_; 
                }
            }
            set
            {
                if (this.valueDate_ != value)
                {
                    this.valueDate_ = value;
                }
            }
        }
        #endregion
        
        public string valueDateIDRef_ { get; set; }
        #region Currency1ValueDate_
        private XsdTypeDate currency1ValueDate_;
        public XsdTypeDate Currency1ValueDate_
        {
            get
            {
                if (this.currency1ValueDate_ != null)
                {
                    return this.currency1ValueDate_; 
                }
                else if (this.currency1ValueDateIDRef_ != null)
                {
                    currency1ValueDate_ = IDManager.getID(currency1ValueDateIDRef_) as XsdTypeDate;
                    return this.currency1ValueDate_; 
                }
                else
                {
                      return this.currency1ValueDate_; 
                }
            }
            set
            {
                if (this.currency1ValueDate_ != value)
                {
                    this.currency1ValueDate_ = value;
                }
            }
        }
        #endregion
        
        public string currency1ValueDateIDRef_ { get; set; }
        #region Currency2ValueDate_
        private XsdTypeDate currency2ValueDate_;
        public XsdTypeDate Currency2ValueDate_
        {
            get
            {
                if (this.currency2ValueDate_ != null)
                {
                    return this.currency2ValueDate_; 
                }
                else if (this.currency2ValueDateIDRef_ != null)
                {
                    currency2ValueDate_ = IDManager.getID(currency2ValueDateIDRef_) as XsdTypeDate;
                    return this.currency2ValueDate_; 
                }
                else
                {
                      return this.currency2ValueDate_; 
                }
            }
            set
            {
                if (this.currency2ValueDate_ != value)
                {
                    this.currency2ValueDate_ = value;
                }
            }
        }
        #endregion
        
        public string currency2ValueDateIDRef_ { get; set; }
        #region ExchangeRate_
        private ExchangeRate exchangeRate_;
        public ExchangeRate ExchangeRate_
        {
            get
            {
                if (this.exchangeRate_ != null)
                {
                    return this.exchangeRate_; 
                }
                else if (this.exchangeRateIDRef_ != null)
                {
                    exchangeRate_ = IDManager.getID(exchangeRateIDRef_) as ExchangeRate;
                    return this.exchangeRate_; 
                }
                else
                {
                      return this.exchangeRate_; 
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
        #region NonDeliverableSettlement_
        private FxCashSettlement nonDeliverableSettlement_;
        public FxCashSettlement NonDeliverableSettlement_
        {
            get
            {
                if (this.nonDeliverableSettlement_ != null)
                {
                    return this.nonDeliverableSettlement_; 
                }
                else if (this.nonDeliverableSettlementIDRef_ != null)
                {
                    nonDeliverableSettlement_ = IDManager.getID(nonDeliverableSettlementIDRef_) as FxCashSettlement;
                    return this.nonDeliverableSettlement_; 
                }
                else
                {
                      return this.nonDeliverableSettlement_; 
                }
            }
            set
            {
                if (this.nonDeliverableSettlement_ != value)
                {
                    this.nonDeliverableSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string nonDeliverableSettlementIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

