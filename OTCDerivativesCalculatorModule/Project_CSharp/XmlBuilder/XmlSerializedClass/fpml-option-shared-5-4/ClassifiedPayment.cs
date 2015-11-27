using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ClassifiedPayment : NonNegativePayment
    {
        public ClassifiedPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList paymentTypeNodeList = xmlNode.SelectNodes("paymentType");
            
            if (paymentTypeNodeList != null)
            {
                this.paymentType_ = new List<PaymentType>();
                foreach (XmlNode item in paymentTypeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentTypeIDRef_ = item.Attributes["id"].Value;
                            paymentType_.Add(new PaymentType(item));
                            IDManager.SetID(paymentTypeIDRef_, paymentType_[paymentType_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentTypeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        paymentType_.Add(new PaymentType(item));
                        }
                    }
                    else
                    {
                        paymentType_.Add(new PaymentType(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentType_
        private List<PaymentType> paymentType_;
        public List<PaymentType> PaymentType_
        {
            get
            {
                if (this.paymentType_ != null)
                {
                    return this.paymentType_; 
                }
                else if (this.paymentTypeIDRef_ != null)
                {
                    return this.paymentType_; 
                }
                else
                {
                      return this.paymentType_; 
                }
            }
            set
            {
                if (this.paymentType_ != value)
                {
                    this.paymentType_ = value;
                }
            }
        }
        #endregion
        
        public string paymentTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

