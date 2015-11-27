using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ClassifiedPayment
    {
        public ClassifiedPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList paymentTypeNodeList = xmlNode.SelectNodes("paymentType");
            
            foreach (XmlNode item in paymentTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentTypeIDRef = item.Attributes["id"].Name;
                        List<PaymentType> ob = new List<PaymentType>();
                        ob.Add(new PaymentType(item));
                        IDManager.SetID(paymentTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    paymentType.Add(new PaymentType(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentType
        private List<PaymentType> paymentType;
        public List<PaymentType> PaymentType
        {
            get
            {
                if (this.paymentType != null)
                {
                    return this.paymentType; 
                }
                else if (this.paymentTypeIDRef != null)
                {
                    paymentType = IDManager.getID(paymentTypeIDRef) as List<PaymentType>;
                    return this.paymentType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentType != value)
                {
                    this.paymentType = value;
                }
            }
        }
        #endregion
        
        public string PaymentTypeIDRef { get; set; }
        
    
        
    
    }
    
}

