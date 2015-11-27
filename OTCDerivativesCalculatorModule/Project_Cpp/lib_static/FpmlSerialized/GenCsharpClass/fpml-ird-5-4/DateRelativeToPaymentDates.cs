using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateRelativeToPaymentDates
    {
        public DateRelativeToPaymentDates(XmlNode xmlNode)
        {
            XmlNodeList paymentDatesReferenceNodeList = xmlNode.SelectNodes("paymentDatesReference");
            
            foreach (XmlNode item in paymentDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesReferenceIDRef = item.Attributes["id"].Name;
                        List<PaymentDatesReference> ob = new List<PaymentDatesReference>();
                        ob.Add(new PaymentDatesReference(item));
                        IDManager.SetID(paymentDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    paymentDatesReference.Add(new PaymentDatesReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentDatesReference
        private List<PaymentDatesReference> paymentDatesReference;
        public List<PaymentDatesReference> PaymentDatesReference
        {
            get
            {
                if (this.paymentDatesReference != null)
                {
                    return this.paymentDatesReference; 
                }
                else if (this.paymentDatesReferenceIDRef != null)
                {
                    paymentDatesReference = IDManager.getID(paymentDatesReferenceIDRef) as List<PaymentDatesReference>;
                    return this.paymentDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDatesReference != value)
                {
                    this.paymentDatesReference = value;
                }
            }
        }
        #endregion
        
        public string PaymentDatesReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

