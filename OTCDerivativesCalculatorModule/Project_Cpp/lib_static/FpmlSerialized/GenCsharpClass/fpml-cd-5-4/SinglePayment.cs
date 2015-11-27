using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SinglePayment
    {
        public SinglePayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList adjustablePaymentDateNodeList = xmlNode.SelectNodes("adjustablePaymentDate");
            if (adjustablePaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustablePaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustablePaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustablePaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustablePaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustablePaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList fixedAmountNodeList = xmlNode.SelectNodes("fixedAmount");
            if (fixedAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(fixedAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region AdjustablePaymentDate
        private XsdTypeDate adjustablePaymentDate;
        public XsdTypeDate AdjustablePaymentDate
        {
            get
            {
                if (this.adjustablePaymentDate != null)
                {
                    return this.adjustablePaymentDate; 
                }
                else if (this.adjustablePaymentDateIDRef != null)
                {
                    adjustablePaymentDate = IDManager.getID(adjustablePaymentDateIDRef) as XsdTypeDate;
                    return this.adjustablePaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustablePaymentDate != value)
                {
                    this.adjustablePaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
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
        #region FixedAmount
        private Money fixedAmount;
        public Money FixedAmount
        {
            get
            {
                if (this.fixedAmount != null)
                {
                    return this.fixedAmount; 
                }
                else if (this.fixedAmountIDRef != null)
                {
                    fixedAmount = IDManager.getID(fixedAmountIDRef) as Money;
                    return this.fixedAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedAmount != value)
                {
                    this.fixedAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

