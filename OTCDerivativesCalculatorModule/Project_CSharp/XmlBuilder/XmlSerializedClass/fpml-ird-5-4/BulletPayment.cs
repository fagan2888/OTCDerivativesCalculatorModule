using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BulletPayment : Product
    {
        public BulletPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentNode = xmlNode.SelectSingleNode("payment");
            
            if (paymentNode != null)
            {
                if (paymentNode.Attributes["href"] != null || paymentNode.Attributes["id"] != null) 
                {
                    if (paymentNode.Attributes["id"] != null) 
                    {
                        paymentIDRef_ = paymentNode.Attributes["id"].Value;
                        Payment ob = new Payment(paymentNode);
                        IDManager.SetID(paymentIDRef_, ob);
                    }
                    else if (paymentNode.Attributes["href"] != null)
                    {
                        paymentIDRef_ = paymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payment_ = new Payment(paymentNode);
                    }
                }
                else
                {
                    payment_ = new Payment(paymentNode);
                }
            }
            
        
        }
        
    
        #region Payment_
        private Payment payment_;
        public Payment Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    payment_ = IDManager.getID(paymentIDRef_) as Payment;
                    return this.payment_; 
                }
                else
                {
                      return this.payment_; 
                }
            }
            set
            {
                if (this.payment_ != value)
                {
                    this.payment_ = value;
                }
            }
        }
        #endregion
        
        public string paymentIDRef_ { get; set; }
        
    
        
    
    }
    
}

