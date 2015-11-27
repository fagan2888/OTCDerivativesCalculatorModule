using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PaymentDetail
    {
        public PaymentDetail(XmlNode xmlNode)
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
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new AdjustableOrRelativeDate(item);
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
            
        
            XmlNodeList paymentRuleNodeList = xmlNode.SelectNodes("paymentRule");
            if (paymentRuleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentRuleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentRuleIDRef = item.Attributes["id"].Name;
                        PaymentRule ob = PaymentRule();
                        IDManager.SetID(paymentRuleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentRuleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentRule = new PaymentRule(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentDate
        private AdjustableOrRelativeDate paymentDate;
        public AdjustableOrRelativeDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as AdjustableOrRelativeDate;
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
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
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
        #region PaymentRule
        private PaymentRule paymentRule;
        public PaymentRule PaymentRule
        {
            get
            {
                if (this.paymentRule != null)
                {
                    return this.paymentRule; 
                }
                else if (this.paymentRuleIDRef != null)
                {
                    paymentRule = IDManager.getID(paymentRuleIDRef) as PaymentRule;
                    return this.paymentRule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentRule != value)
                {
                    this.paymentRule = value;
                }
            }
        }
        #endregion
        
        public string PaymentRuleIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

