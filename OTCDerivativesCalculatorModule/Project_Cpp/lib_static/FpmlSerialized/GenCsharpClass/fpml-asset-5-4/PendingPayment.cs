using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PendingPayment
    {
        public PendingPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList paymentDateNodeList = xmlNode.SelectNodes("paymentDate");
            if (paymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList amountNodeList = xmlNode.SelectNodes("amount");
            if (amountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList accruedInterestNodeList = xmlNode.SelectNodes("accruedInterest");
            if (accruedInterestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accruedInterestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accruedInterestIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(accruedInterestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accruedInterestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accruedInterest = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentDate
        private XsdTypeDate paymentDate;
        public XsdTypeDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as XsdTypeDate;
                    return this.paymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDate != value)
                {
                    this.paymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Amount
        private Money amount;
        public Money Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as Money;
                    return this.amount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region AccruedInterest
        private Money accruedInterest;
        public Money AccruedInterest
        {
            get
            {
                if (this.accruedInterest != null)
                {
                    return this.accruedInterest; 
                }
                else if (this.accruedInterestIDRef != null)
                {
                    accruedInterest = IDManager.getID(accruedInterestIDRef) as Money;
                    return this.accruedInterest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accruedInterest != value)
                {
                    this.accruedInterest = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

