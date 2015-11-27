using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustedPaymentDates : ISerialized
    {
        public AdjustedPaymentDates(XmlNode xmlNode)
        {
            XmlNode adjustedPaymentDateNode = xmlNode.SelectSingleNode("adjustedPaymentDate");
            
            if (adjustedPaymentDateNode != null)
            {
                if (adjustedPaymentDateNode.Attributes["href"] != null || adjustedPaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustedPaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedPaymentDateNode);
                        IDManager.SetID(adjustedPaymentDateIDRef_, ob);
                    }
                    else if (adjustedPaymentDateNode.Attributes["href"] != null)
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                    }
                }
                else
                {
                    adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                }
            }
            
        
            XmlNode paymentAmountNode = xmlNode.SelectSingleNode("paymentAmount");
            
            if (paymentAmountNode != null)
            {
                if (paymentAmountNode.Attributes["href"] != null || paymentAmountNode.Attributes["id"] != null) 
                {
                    if (paymentAmountNode.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["id"].Value;
                        Money ob = new Money(paymentAmountNode);
                        IDManager.SetID(paymentAmountIDRef_, ob);
                    }
                    else if (paymentAmountNode.Attributes["href"] != null)
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentAmount_ = new Money(paymentAmountNode);
                    }
                }
                else
                {
                    paymentAmount_ = new Money(paymentAmountNode);
                }
            }
            
        
        }
        
    
        #region AdjustedPaymentDate_
        private XsdTypeDate adjustedPaymentDate_;
        public XsdTypeDate AdjustedPaymentDate_
        {
            get
            {
                if (this.adjustedPaymentDate_ != null)
                {
                    return this.adjustedPaymentDate_; 
                }
                else if (this.adjustedPaymentDateIDRef_ != null)
                {
                    adjustedPaymentDate_ = IDManager.getID(adjustedPaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustedPaymentDate_; 
                }
                else
                {
                      return this.adjustedPaymentDate_; 
                }
            }
            set
            {
                if (this.adjustedPaymentDate_ != value)
                {
                    this.adjustedPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedPaymentDateIDRef_ { get; set; }
        #region PaymentAmount_
        private Money paymentAmount_;
        public Money PaymentAmount_
        {
            get
            {
                if (this.paymentAmount_ != null)
                {
                    return this.paymentAmount_; 
                }
                else if (this.paymentAmountIDRef_ != null)
                {
                    paymentAmount_ = IDManager.getID(paymentAmountIDRef_) as Money;
                    return this.paymentAmount_; 
                }
                else
                {
                      return this.paymentAmount_; 
                }
            }
            set
            {
                if (this.paymentAmount_ != value)
                {
                    this.paymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string paymentAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

