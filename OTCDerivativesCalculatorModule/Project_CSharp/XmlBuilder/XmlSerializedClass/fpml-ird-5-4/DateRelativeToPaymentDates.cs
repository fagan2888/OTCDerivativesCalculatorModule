using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateRelativeToPaymentDates : ISerialized
    {
        public DateRelativeToPaymentDates(XmlNode xmlNode)
        {
            XmlNodeList paymentDatesReferenceNodeList = xmlNode.SelectNodes("paymentDatesReference");
            
            if (paymentDatesReferenceNodeList != null)
            {
                this.paymentDatesReference_ = new List<PaymentDatesReference>();
                foreach (XmlNode item in paymentDatesReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentDatesReferenceIDRef_ = item.Attributes["id"].Value;
                            paymentDatesReference_.Add(new PaymentDatesReference(item));
                            IDManager.SetID(paymentDatesReferenceIDRef_, paymentDatesReference_[paymentDatesReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentDatesReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        paymentDatesReference_.Add(new PaymentDatesReference(item));
                        }
                    }
                    else
                    {
                        paymentDatesReference_.Add(new PaymentDatesReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentDatesReference_
        private List<PaymentDatesReference> paymentDatesReference_;
        public List<PaymentDatesReference> PaymentDatesReference_
        {
            get
            {
                if (this.paymentDatesReference_ != null)
                {
                    return this.paymentDatesReference_; 
                }
                else if (this.paymentDatesReferenceIDRef_ != null)
                {
                    return this.paymentDatesReference_; 
                }
                else
                {
                      return this.paymentDatesReference_; 
                }
            }
            set
            {
                if (this.paymentDatesReference_ != value)
                {
                    this.paymentDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

