using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SinglePayment : PaymentBase
    {
        public SinglePayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode adjustablePaymentDateNode = xmlNode.SelectSingleNode("adjustablePaymentDate");
            
            if (adjustablePaymentDateNode != null)
            {
                if (adjustablePaymentDateNode.Attributes["href"] != null || adjustablePaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustablePaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustablePaymentDateIDRef_ = adjustablePaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustablePaymentDateNode);
                        IDManager.SetID(adjustablePaymentDateIDRef_, ob);
                    }
                    else if (adjustablePaymentDateNode.Attributes["href"] != null)
                    {
                        adjustablePaymentDateIDRef_ = adjustablePaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustablePaymentDate_ = new XsdTypeDate(adjustablePaymentDateNode);
                    }
                }
                else
                {
                    adjustablePaymentDate_ = new XsdTypeDate(adjustablePaymentDateNode);
                }
            }
            
        
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
            
        
            XmlNode fixedAmountNode = xmlNode.SelectSingleNode("fixedAmount");
            
            if (fixedAmountNode != null)
            {
                if (fixedAmountNode.Attributes["href"] != null || fixedAmountNode.Attributes["id"] != null) 
                {
                    if (fixedAmountNode.Attributes["id"] != null) 
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["id"].Value;
                        Money ob = new Money(fixedAmountNode);
                        IDManager.SetID(fixedAmountIDRef_, ob);
                    }
                    else if (fixedAmountNode.Attributes["href"] != null)
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedAmount_ = new Money(fixedAmountNode);
                    }
                }
                else
                {
                    fixedAmount_ = new Money(fixedAmountNode);
                }
            }
            
        
        }
        
    
        #region AdjustablePaymentDate_
        private XsdTypeDate adjustablePaymentDate_;
        public XsdTypeDate AdjustablePaymentDate_
        {
            get
            {
                if (this.adjustablePaymentDate_ != null)
                {
                    return this.adjustablePaymentDate_; 
                }
                else if (this.adjustablePaymentDateIDRef_ != null)
                {
                    adjustablePaymentDate_ = IDManager.getID(adjustablePaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustablePaymentDate_; 
                }
                else
                {
                      return this.adjustablePaymentDate_; 
                }
            }
            set
            {
                if (this.adjustablePaymentDate_ != value)
                {
                    this.adjustablePaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustablePaymentDateIDRef_ { get; set; }
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
        #region FixedAmount_
        private Money fixedAmount_;
        public Money FixedAmount_
        {
            get
            {
                if (this.fixedAmount_ != null)
                {
                    return this.fixedAmount_; 
                }
                else if (this.fixedAmountIDRef_ != null)
                {
                    fixedAmount_ = IDManager.getID(fixedAmountIDRef_) as Money;
                    return this.fixedAmount_; 
                }
                else
                {
                      return this.fixedAmount_; 
                }
            }
            set
            {
                if (this.fixedAmount_ != value)
                {
                    this.fixedAmount_ = value;
                }
            }
        }
        #endregion
        
        public string fixedAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

