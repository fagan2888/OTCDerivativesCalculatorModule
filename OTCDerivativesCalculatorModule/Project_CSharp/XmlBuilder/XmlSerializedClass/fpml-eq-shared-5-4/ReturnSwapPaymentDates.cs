using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapPaymentDates : ISerialized
    {
        public ReturnSwapPaymentDates(XmlNode xmlNode)
        {
            XmlNode paymentDatesInterimNode = xmlNode.SelectSingleNode("paymentDatesInterim");
            
            if (paymentDatesInterimNode != null)
            {
                if (paymentDatesInterimNode.Attributes["href"] != null || paymentDatesInterimNode.Attributes["id"] != null) 
                {
                    if (paymentDatesInterimNode.Attributes["id"] != null) 
                    {
                        paymentDatesInterimIDRef_ = paymentDatesInterimNode.Attributes["id"].Value;
                        AdjustableOrRelativeDates ob = new AdjustableOrRelativeDates(paymentDatesInterimNode);
                        IDManager.SetID(paymentDatesInterimIDRef_, ob);
                    }
                    else if (paymentDatesInterimNode.Attributes["href"] != null)
                    {
                        paymentDatesInterimIDRef_ = paymentDatesInterimNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDatesInterim_ = new AdjustableOrRelativeDates(paymentDatesInterimNode);
                    }
                }
                else
                {
                    paymentDatesInterim_ = new AdjustableOrRelativeDates(paymentDatesInterimNode);
                }
            }
            
        
            XmlNode paymentDateFinalNode = xmlNode.SelectSingleNode("paymentDateFinal");
            
            if (paymentDateFinalNode != null)
            {
                if (paymentDateFinalNode.Attributes["href"] != null || paymentDateFinalNode.Attributes["id"] != null) 
                {
                    if (paymentDateFinalNode.Attributes["id"] != null) 
                    {
                        paymentDateFinalIDRef_ = paymentDateFinalNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(paymentDateFinalNode);
                        IDManager.SetID(paymentDateFinalIDRef_, ob);
                    }
                    else if (paymentDateFinalNode.Attributes["href"] != null)
                    {
                        paymentDateFinalIDRef_ = paymentDateFinalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDateFinal_ = new AdjustableOrRelativeDate(paymentDateFinalNode);
                    }
                }
                else
                {
                    paymentDateFinal_ = new AdjustableOrRelativeDate(paymentDateFinalNode);
                }
            }
            
        
        }
        
    
        #region PaymentDatesInterim_
        private AdjustableOrRelativeDates paymentDatesInterim_;
        public AdjustableOrRelativeDates PaymentDatesInterim_
        {
            get
            {
                if (this.paymentDatesInterim_ != null)
                {
                    return this.paymentDatesInterim_; 
                }
                else if (this.paymentDatesInterimIDRef_ != null)
                {
                    paymentDatesInterim_ = IDManager.getID(paymentDatesInterimIDRef_) as AdjustableOrRelativeDates;
                    return this.paymentDatesInterim_; 
                }
                else
                {
                      return this.paymentDatesInterim_; 
                }
            }
            set
            {
                if (this.paymentDatesInterim_ != value)
                {
                    this.paymentDatesInterim_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesInterimIDRef_ { get; set; }
        #region PaymentDateFinal_
        private AdjustableOrRelativeDate paymentDateFinal_;
        public AdjustableOrRelativeDate PaymentDateFinal_
        {
            get
            {
                if (this.paymentDateFinal_ != null)
                {
                    return this.paymentDateFinal_; 
                }
                else if (this.paymentDateFinalIDRef_ != null)
                {
                    paymentDateFinal_ = IDManager.getID(paymentDateFinalIDRef_) as AdjustableOrRelativeDate;
                    return this.paymentDateFinal_; 
                }
                else
                {
                      return this.paymentDateFinal_; 
                }
            }
            set
            {
                if (this.paymentDateFinal_ != value)
                {
                    this.paymentDateFinal_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateFinalIDRef_ { get; set; }
        
    
        
    
    }
    
}

