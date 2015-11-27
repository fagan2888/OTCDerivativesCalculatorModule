using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeAmendmentContent
    {
        public TradeAmendmentContent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            if (tradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(tradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trade = new Trade(item);
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
        
    
        #region Trade
        private Trade trade;
        public Trade Trade
        {
            get
            {
                if (this.trade != null)
                {
                    return this.trade; 
                }
                else if (this.tradeIDRef != null)
                {
                    trade = IDManager.getID(tradeIDRef) as Trade;
                    return this.trade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trade != value)
                {
                    this.trade = value;
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
        
    
        
    
    }
    
}

