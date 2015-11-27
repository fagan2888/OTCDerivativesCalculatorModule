using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeChangeBase
    {
        public TradeChangeBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    tradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList originalTradeNodeList = xmlNode.SelectNodes("originalTrade");
            if (originalTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originalTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originalTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(originalTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originalTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originalTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList agreementDateNodeList = xmlNode.SelectNodes("agreementDate");
            if (agreementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in agreementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        agreementDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(agreementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        agreementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        agreementDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList executionDateTimeNodeList = xmlNode.SelectNodes("executionDateTime");
            if (executionDateTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in executionDateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        executionDateTimeIDRef = item.Attributes["id"].Name;
                        ExecutionDateTime ob = ExecutionDateTime();
                        IDManager.SetID(executionDateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        executionDateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        executionDateTime = new ExecutionDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            
            foreach (XmlNode item in paymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentIDRef = item.Attributes["id"].Name;
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    payment.Add(new Payment(item));
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier
        private List<PartyTradeIdentifier> tradeIdentifier;
        public List<PartyTradeIdentifier> TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.tradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifier != value)
                {
                    this.tradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region OriginalTrade
        private Trade originalTrade;
        public Trade OriginalTrade
        {
            get
            {
                if (this.originalTrade != null)
                {
                    return this.originalTrade; 
                }
                else if (this.originalTradeIDRef != null)
                {
                    originalTrade = IDManager.getID(originalTradeIDRef) as Trade;
                    return this.originalTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originalTrade != value)
                {
                    this.originalTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region AgreementDate
        private XsdTypeDate agreementDate;
        public XsdTypeDate AgreementDate
        {
            get
            {
                if (this.agreementDate != null)
                {
                    return this.agreementDate; 
                }
                else if (this.agreementDateIDRef != null)
                {
                    agreementDate = IDManager.getID(agreementDateIDRef) as XsdTypeDate;
                    return this.agreementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.agreementDate != value)
                {
                    this.agreementDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ExecutionDateTime
        private ExecutionDateTime executionDateTime;
        public ExecutionDateTime ExecutionDateTime
        {
            get
            {
                if (this.executionDateTime != null)
                {
                    return this.executionDateTime; 
                }
                else if (this.executionDateTimeIDRef != null)
                {
                    executionDateTime = IDManager.getID(executionDateTimeIDRef) as ExecutionDateTime;
                    return this.executionDateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.executionDateTime != value)
                {
                    this.executionDateTime = value;
                }
            }
        }
        #endregion
        
        public string ExecutionDateTimeIDRef { get; set; }
        #region EffectiveDate
        private XsdTypeDate effectiveDate;
        public XsdTypeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as XsdTypeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Payment
        private List<Payment> payment;
        public List<Payment> Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as List<Payment>;
                    return this.payment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payment != value)
                {
                    this.payment = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

