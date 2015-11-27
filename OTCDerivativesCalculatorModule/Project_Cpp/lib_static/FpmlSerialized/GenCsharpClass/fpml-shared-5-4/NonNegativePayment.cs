using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NonNegativePayment
    {
        public NonNegativePayment(XmlNode xmlNode)
        : base(xmlNode)
        {
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
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(paymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentAmount
        private NonNegativeMoney paymentAmount;
        public NonNegativeMoney PaymentAmount
        {
            get
            {
                if (this.paymentAmount != null)
                {
                    return this.paymentAmount; 
                }
                else if (this.paymentAmountIDRef != null)
                {
                    paymentAmount = IDManager.getID(paymentAmountIDRef) as NonNegativeMoney;
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
        
        public string NonNegativeMoneyIDRef { get; set; }
        
    
        
    
    }
    
}

