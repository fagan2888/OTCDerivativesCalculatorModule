using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendPaymentDate : ISerialized
    {
        public DividendPaymentDate(XmlNode xmlNode)
        {
            XmlNode dividendDateReferenceNode = xmlNode.SelectSingleNode("dividendDateReference");
            
            if (dividendDateReferenceNode != null)
            {
                if (dividendDateReferenceNode.Attributes["href"] != null || dividendDateReferenceNode.Attributes["id"] != null) 
                {
                    if (dividendDateReferenceNode.Attributes["id"] != null) 
                    {
                        dividendDateReferenceIDRef_ = dividendDateReferenceNode.Attributes["id"].Value;
                        DividendDateReferenceEnum ob = new DividendDateReferenceEnum(dividendDateReferenceNode);
                        IDManager.SetID(dividendDateReferenceIDRef_, ob);
                    }
                    else if (dividendDateReferenceNode.Attributes["href"] != null)
                    {
                        dividendDateReferenceIDRef_ = dividendDateReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendDateReference_ = new DividendDateReferenceEnum(dividendDateReferenceNode);
                    }
                }
                else
                {
                    dividendDateReference_ = new DividendDateReferenceEnum(dividendDateReferenceNode);
                }
            }
            
        
            XmlNode paymentDateOffsetNode = xmlNode.SelectSingleNode("paymentDateOffset");
            
            if (paymentDateOffsetNode != null)
            {
                if (paymentDateOffsetNode.Attributes["href"] != null || paymentDateOffsetNode.Attributes["id"] != null) 
                {
                    if (paymentDateOffsetNode.Attributes["id"] != null) 
                    {
                        paymentDateOffsetIDRef_ = paymentDateOffsetNode.Attributes["id"].Value;
                        Offset ob = new Offset(paymentDateOffsetNode);
                        IDManager.SetID(paymentDateOffsetIDRef_, ob);
                    }
                    else if (paymentDateOffsetNode.Attributes["href"] != null)
                    {
                        paymentDateOffsetIDRef_ = paymentDateOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDateOffset_ = new Offset(paymentDateOffsetNode);
                    }
                }
                else
                {
                    paymentDateOffset_ = new Offset(paymentDateOffsetNode);
                }
            }
            
        
            XmlNode adjustableDateNode = xmlNode.SelectSingleNode("adjustableDate");
            
            if (adjustableDateNode != null)
            {
                if (adjustableDateNode.Attributes["href"] != null || adjustableDateNode.Attributes["id"] != null) 
                {
                    if (adjustableDateNode.Attributes["id"] != null) 
                    {
                        adjustableDateIDRef_ = adjustableDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(adjustableDateNode);
                        IDManager.SetID(adjustableDateIDRef_, ob);
                    }
                    else if (adjustableDateNode.Attributes["href"] != null)
                    {
                        adjustableDateIDRef_ = adjustableDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustableDate_ = new AdjustableDate(adjustableDateNode);
                    }
                }
                else
                {
                    adjustableDate_ = new AdjustableDate(adjustableDateNode);
                }
            }
            
        
        }
        
    
        #region DividendDateReference_
        private DividendDateReferenceEnum dividendDateReference_;
        public DividendDateReferenceEnum DividendDateReference_
        {
            get
            {
                if (this.dividendDateReference_ != null)
                {
                    return this.dividendDateReference_; 
                }
                else if (this.dividendDateReferenceIDRef_ != null)
                {
                    dividendDateReference_ = IDManager.getID(dividendDateReferenceIDRef_) as DividendDateReferenceEnum;
                    return this.dividendDateReference_; 
                }
                else
                {
                      return this.dividendDateReference_; 
                }
            }
            set
            {
                if (this.dividendDateReference_ != value)
                {
                    this.dividendDateReference_ = value;
                }
            }
        }
        #endregion
        
        public string dividendDateReferenceIDRef_ { get; set; }
        #region PaymentDateOffset_
        private Offset paymentDateOffset_;
        public Offset PaymentDateOffset_
        {
            get
            {
                if (this.paymentDateOffset_ != null)
                {
                    return this.paymentDateOffset_; 
                }
                else if (this.paymentDateOffsetIDRef_ != null)
                {
                    paymentDateOffset_ = IDManager.getID(paymentDateOffsetIDRef_) as Offset;
                    return this.paymentDateOffset_; 
                }
                else
                {
                      return this.paymentDateOffset_; 
                }
            }
            set
            {
                if (this.paymentDateOffset_ != value)
                {
                    this.paymentDateOffset_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateOffsetIDRef_ { get; set; }
        #region AdjustableDate_
        private AdjustableDate adjustableDate_;
        public AdjustableDate AdjustableDate_
        {
            get
            {
                if (this.adjustableDate_ != null)
                {
                    return this.adjustableDate_; 
                }
                else if (this.adjustableDateIDRef_ != null)
                {
                    adjustableDate_ = IDManager.getID(adjustableDateIDRef_) as AdjustableDate;
                    return this.adjustableDate_; 
                }
                else
                {
                      return this.adjustableDate_; 
                }
            }
            set
            {
                if (this.adjustableDate_ != value)
                {
                    this.adjustableDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustableDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

