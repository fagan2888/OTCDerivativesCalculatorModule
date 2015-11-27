using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PaymentDetail : PaymentBase
    {
        public PaymentDetail(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new AdjustableOrRelativeDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new AdjustableOrRelativeDate(paymentDateNode);
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
            
        
            XmlNode paymentRuleNode = xmlNode.SelectSingleNode("paymentRule");
            
            if (paymentRuleNode != null)
            {
                if (paymentRuleNode.Attributes["href"] != null || paymentRuleNode.Attributes["id"] != null) 
                {
                    if (paymentRuleNode.Attributes["id"] != null) 
                    {
                        paymentRuleIDRef_ = paymentRuleNode.Attributes["id"].Value;
                        PaymentRule ob = new PaymentRule(paymentRuleNode);
                        IDManager.SetID(paymentRuleIDRef_, ob);
                    }
                    else if (paymentRuleNode.Attributes["href"] != null)
                    {
                        paymentRuleIDRef_ = paymentRuleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentRule_ = new PaymentRule(paymentRuleNode);
                    }
                }
                else
                {
                    paymentRule_ = new PaymentRule(paymentRuleNode);
                }
            }
            
        
        }
        
    
        #region PaymentDate_
        private AdjustableOrRelativeDate paymentDate_;
        public AdjustableOrRelativeDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as AdjustableOrRelativeDate;
                    return this.paymentDate_; 
                }
                else
                {
                      return this.paymentDate_; 
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
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
        #region PaymentRule_
        private PaymentRule paymentRule_;
        public PaymentRule PaymentRule_
        {
            get
            {
                if (this.paymentRule_ != null)
                {
                    return this.paymentRule_; 
                }
                else if (this.paymentRuleIDRef_ != null)
                {
                    paymentRule_ = IDManager.getID(paymentRuleIDRef_) as PaymentRule;
                    return this.paymentRule_; 
                }
                else
                {
                      return this.paymentRule_; 
                }
            }
            set
            {
                if (this.paymentRule_ != value)
                {
                    this.paymentRule_ = value;
                }
            }
        }
        #endregion
        
        public string paymentRuleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

