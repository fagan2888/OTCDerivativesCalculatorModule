using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxSwapLeg
    {
        public FxSwapLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList tradeIdentifierReferenceNodeList = xmlNode.SelectNodes("tradeIdentifierReference");
            if (tradeIdentifierReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeIdentifierReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierReferenceIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifierReference ob = PartyTradeIdentifierReference();
                        IDManager.SetID(tradeIdentifierReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeIdentifierReference = new PartyTradeIdentifierReference(item);
                    }
                }
            }
            
        
            XmlNodeList exchangedCurrency1NodeList = xmlNode.SelectNodes("exchangedCurrency1");
            if (exchangedCurrency1NodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangedCurrency1NodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangedCurrency1IDRef = item.Attributes["id"].Name;
                        Payment ob = Payment();
                        IDManager.SetID(exchangedCurrency1IDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangedCurrency1IDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangedCurrency1 = new Payment(item);
                    }
                }
            }
            
        
            XmlNodeList exchangedCurrency2NodeList = xmlNode.SelectNodes("exchangedCurrency2");
            if (exchangedCurrency2NodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangedCurrency2NodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangedCurrency2IDRef = item.Attributes["id"].Name;
                        Payment ob = Payment();
                        IDManager.SetID(exchangedCurrency2IDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangedCurrency2IDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangedCurrency2 = new Payment(item);
                    }
                }
            }
            
        
            XmlNodeList dealtCurrencyNodeList = xmlNode.SelectNodes("dealtCurrency");
            if (dealtCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dealtCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dealtCurrencyIDRef = item.Attributes["id"].Name;
                        DealtCurrencyEnum ob = DealtCurrencyEnum();
                        IDManager.SetID(dealtCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dealtCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dealtCurrency = new DealtCurrencyEnum(item);
                    }
                }
            }
            
        
            XmlNodeList tenorNameNodeList = xmlNode.SelectNodes("tenorName");
            if (tenorNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorNameIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(tenorNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenorName = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList tenorPeriodNodeList = xmlNode.SelectNodes("tenorPeriod");
            if (tenorPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(tenorPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenorPeriod = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList valueDateNodeList = xmlNode.SelectNodes("valueDate");
            if (valueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(valueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList currency1ValueDateNodeList = xmlNode.SelectNodes("currency1ValueDate");
            if (currency1ValueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currency1ValueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currency1ValueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(currency1ValueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currency1ValueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency1ValueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList currency2ValueDateNodeList = xmlNode.SelectNodes("currency2ValueDate");
            if (currency2ValueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currency2ValueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currency2ValueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(currency2ValueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currency2ValueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency2ValueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeRateNodeList = xmlNode.SelectNodes("exchangeRate");
            if (exchangeRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeRateIDRef = item.Attributes["id"].Name;
                        ExchangeRate ob = ExchangeRate();
                        IDManager.SetID(exchangeRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeRate = new ExchangeRate(item);
                    }
                }
            }
            
        
            XmlNodeList nonDeliverableSettlementNodeList = xmlNode.SelectNodes("nonDeliverableSettlement");
            if (nonDeliverableSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonDeliverableSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonDeliverableSettlementIDRef = item.Attributes["id"].Name;
                        FxCashSettlement ob = FxCashSettlement();
                        IDManager.SetID(nonDeliverableSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonDeliverableSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonDeliverableSettlement = new FxCashSettlement(item);
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifierReference
        private PartyTradeIdentifierReference tradeIdentifierReference;
        public PartyTradeIdentifierReference TradeIdentifierReference
        {
            get
            {
                if (this.tradeIdentifierReference != null)
                {
                    return this.tradeIdentifierReference; 
                }
                else if (this.tradeIdentifierReferenceIDRef != null)
                {
                    tradeIdentifierReference = IDManager.getID(tradeIdentifierReferenceIDRef) as PartyTradeIdentifierReference;
                    return this.tradeIdentifierReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifierReference != value)
                {
                    this.tradeIdentifierReference = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierReferenceIDRef { get; set; }
        #region ExchangedCurrency1
        private Payment exchangedCurrency1;
        public Payment ExchangedCurrency1
        {
            get
            {
                if (this.exchangedCurrency1 != null)
                {
                    return this.exchangedCurrency1; 
                }
                else if (this.exchangedCurrency1IDRef != null)
                {
                    exchangedCurrency1 = IDManager.getID(exchangedCurrency1IDRef) as Payment;
                    return this.exchangedCurrency1; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangedCurrency1 != value)
                {
                    this.exchangedCurrency1 = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        #region ExchangedCurrency2
        private Payment exchangedCurrency2;
        public Payment ExchangedCurrency2
        {
            get
            {
                if (this.exchangedCurrency2 != null)
                {
                    return this.exchangedCurrency2; 
                }
                else if (this.exchangedCurrency2IDRef != null)
                {
                    exchangedCurrency2 = IDManager.getID(exchangedCurrency2IDRef) as Payment;
                    return this.exchangedCurrency2; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangedCurrency2 != value)
                {
                    this.exchangedCurrency2 = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        #region DealtCurrency
        private DealtCurrencyEnum dealtCurrency;
        public DealtCurrencyEnum DealtCurrency
        {
            get
            {
                if (this.dealtCurrency != null)
                {
                    return this.dealtCurrency; 
                }
                else if (this.dealtCurrencyIDRef != null)
                {
                    dealtCurrency = IDManager.getID(dealtCurrencyIDRef) as DealtCurrencyEnum;
                    return this.dealtCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dealtCurrency != value)
                {
                    this.dealtCurrency = value;
                }
            }
        }
        #endregion
        
        public string DealtCurrencyEnumIDRef { get; set; }
        #region TenorName
        private XsdTypeBoolean tenorName;
        public XsdTypeBoolean TenorName
        {
            get
            {
                if (this.tenorName != null)
                {
                    return this.tenorName; 
                }
                else if (this.tenorNameIDRef != null)
                {
                    tenorName = IDManager.getID(tenorNameIDRef) as XsdTypeBoolean;
                    return this.tenorName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenorName != value)
                {
                    this.tenorName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region TenorPeriod
        private Period tenorPeriod;
        public Period TenorPeriod
        {
            get
            {
                if (this.tenorPeriod != null)
                {
                    return this.tenorPeriod; 
                }
                else if (this.tenorPeriodIDRef != null)
                {
                    tenorPeriod = IDManager.getID(tenorPeriodIDRef) as Period;
                    return this.tenorPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenorPeriod != value)
                {
                    this.tenorPeriod = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region ValueDate
        private XsdTypeDate valueDate;
        public XsdTypeDate ValueDate
        {
            get
            {
                if (this.valueDate != null)
                {
                    return this.valueDate; 
                }
                else if (this.valueDateIDRef != null)
                {
                    valueDate = IDManager.getID(valueDateIDRef) as XsdTypeDate;
                    return this.valueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valueDate != value)
                {
                    this.valueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Currency1ValueDate
        private XsdTypeDate currency1ValueDate;
        public XsdTypeDate Currency1ValueDate
        {
            get
            {
                if (this.currency1ValueDate != null)
                {
                    return this.currency1ValueDate; 
                }
                else if (this.currency1ValueDateIDRef != null)
                {
                    currency1ValueDate = IDManager.getID(currency1ValueDateIDRef) as XsdTypeDate;
                    return this.currency1ValueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency1ValueDate != value)
                {
                    this.currency1ValueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Currency2ValueDate
        private XsdTypeDate currency2ValueDate;
        public XsdTypeDate Currency2ValueDate
        {
            get
            {
                if (this.currency2ValueDate != null)
                {
                    return this.currency2ValueDate; 
                }
                else if (this.currency2ValueDateIDRef != null)
                {
                    currency2ValueDate = IDManager.getID(currency2ValueDateIDRef) as XsdTypeDate;
                    return this.currency2ValueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency2ValueDate != value)
                {
                    this.currency2ValueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ExchangeRate
        private ExchangeRate exchangeRate;
        public ExchangeRate ExchangeRate
        {
            get
            {
                if (this.exchangeRate != null)
                {
                    return this.exchangeRate; 
                }
                else if (this.exchangeRateIDRef != null)
                {
                    exchangeRate = IDManager.getID(exchangeRateIDRef) as ExchangeRate;
                    return this.exchangeRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeRate != value)
                {
                    this.exchangeRate = value;
                }
            }
        }
        #endregion
        
        public string ExchangeRateIDRef { get; set; }
        #region NonDeliverableSettlement
        private FxCashSettlement nonDeliverableSettlement;
        public FxCashSettlement NonDeliverableSettlement
        {
            get
            {
                if (this.nonDeliverableSettlement != null)
                {
                    return this.nonDeliverableSettlement; 
                }
                else if (this.nonDeliverableSettlementIDRef != null)
                {
                    nonDeliverableSettlement = IDManager.getID(nonDeliverableSettlementIDRef) as FxCashSettlement;
                    return this.nonDeliverableSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonDeliverableSettlement != value)
                {
                    this.nonDeliverableSettlement = value;
                }
            }
        }
        #endregion
        
        public string FxCashSettlementIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

