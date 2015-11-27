using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustedPaymentDates
    {
        public AdjustedPaymentDates(XmlNode xmlNode)
        {
            XmlNodeList adjustedPaymentDateNodeList = xmlNode.SelectNodes("adjustedPaymentDate");
            if (adjustedPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList paymentAmountNodeList = xmlNode.SelectNodes("paymentAmount");
            if (paymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(paymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region AdjustedPaymentDate
        private XsdTypeDate adjustedPaymentDate;
        public XsdTypeDate AdjustedPaymentDate
        {
            get
            {
                if (this.adjustedPaymentDate != null)
                {
                    return this.adjustedPaymentDate; 
                }
                else if (this.adjustedPaymentDateIDRef != null)
                {
                    adjustedPaymentDate = IDManager.getID(adjustedPaymentDateIDRef) as XsdTypeDate;
                    return this.adjustedPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedPaymentDate != value)
                {
                    this.adjustedPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region PaymentAmount
        private Money paymentAmount;
        public Money PaymentAmount
        {
            get
            {
                if (this.paymentAmount != null)
                {
                    return this.paymentAmount; 
                }
                else if (this.paymentAmountIDRef != null)
                {
                    paymentAmount = IDManager.getID(paymentAmountIDRef) as Money;
                    return this.paymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentAmount != value)
                {
                    this.paymentAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

