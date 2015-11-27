using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class ProtectionTerms : ISerialized
    {
        public ProtectionTerms() { }
        public ProtectionTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationAmountNode = xmlNode.SelectSingleNode("calculationAmount");
            
            if (calculationAmountNode != null)
            {
                if (calculationAmountNode.Attributes["href"] != null || calculationAmountNode.Attributes["id"] != null) 
                {
                    if (calculationAmountNode.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["id"].Value;
                        CalculationAmount ob = new CalculationAmount(calculationAmountNode);
                        IDManager.SetID(calculationAmountIDRef_, ob);
                    }
                    else if (calculationAmountNode.Attributes["href"] != null)
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAmount_ = new CalculationAmount(calculationAmountNode);
                    }
                }
                else
                {
                    calculationAmount_ = new CalculationAmount(calculationAmountNode);
                }
            }
            
        
            XmlNode creditEventsNode = xmlNode.SelectSingleNode("creditEvents");
            
            if (creditEventsNode != null)
            {
                if (creditEventsNode.Attributes["href"] != null || creditEventsNode.Attributes["id"] != null) 
                {
                    if (creditEventsNode.Attributes["id"] != null) 
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["id"].Value;
                        CreditEvents ob = new CreditEvents(creditEventsNode);
                        IDManager.SetID(creditEventsIDRef_, ob);
                    }
                    else if (creditEventsNode.Attributes["href"] != null)
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvents_ = new CreditEvents(creditEventsNode);
                    }
                }
                else
                {
                    creditEvents_ = new CreditEvents(creditEventsNode);
                }
            }
            
        
            XmlNode accrualCouponNode = xmlNode.SelectSingleNode("accrualCoupon");
            
            if (accrualCouponNode != null)
            {
                if (accrualCouponNode.Attributes["href"] != null || accrualCouponNode.Attributes["id"] != null) 
                {
                    if (accrualCouponNode.Attributes["id"] != null) 
                    {
                        accrualCouponIDRef_ = accrualCouponNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(accrualCouponNode);
                        IDManager.SetID(accrualCouponIDRef_, ob);
                    }
                    else if (accrualCouponNode.Attributes["href"] != null)
                    {
                        accrualCouponIDRef_ = accrualCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accrualCoupon_ = new XsdTypeBoolean(accrualCouponNode);
                    }
                }
                else
                {
                    accrualCoupon_ = new XsdTypeBoolean(accrualCouponNode);
                }
            }
            
        
        }
        
    
        #region CalculationAmount_
        private CalculationAmount calculationAmount_;
        public CalculationAmount CalculationAmount_
        {
            get
            {
                if (this.calculationAmount_ != null)
                {
                    return this.calculationAmount_; 
                }
                else if (this.calculationAmountIDRef_ != null)
                {
                    calculationAmount_ = IDManager.getID(calculationAmountIDRef_) as CalculationAmount;
                    return this.calculationAmount_; 
                }
                else
                {
                      return this.calculationAmount_; 
                }
            }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAmountIDRef_ { get; set; }
        #region CreditEvents_
        private CreditEvents creditEvents_;
        public CreditEvents CreditEvents_
        {
            get
            {
                if (this.creditEvents_ != null)
                {
                    return this.creditEvents_; 
                }
                else if (this.creditEventsIDRef_ != null)
                {
                    creditEvents_ = IDManager.getID(creditEventsIDRef_) as CreditEvents;
                    return this.creditEvents_; 
                }
                else
                {
                      return this.creditEvents_; 
                }
            }
            set
            {
                if (this.creditEvents_ != value)
                {
                    this.creditEvents_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventsIDRef_ { get; set; }
        #region AccrualCoupon_
        private XsdTypeBoolean accrualCoupon_;
        public XsdTypeBoolean AccrualCoupon_
        {
            get
            {
                if (this.accrualCoupon_ != null)
                {
                    return this.accrualCoupon_; 
                }
                else if (this.accrualCouponIDRef_ != null)
                {
                    accrualCoupon_ = IDManager.getID(accrualCouponIDRef_) as XsdTypeBoolean;
                    return this.accrualCoupon_; 
                }
                else
                {
                      return this.accrualCoupon_; 
                }
            }
            set
            {
                if (this.accrualCoupon_ != value)
                {
                    this.accrualCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string accrualCouponIDRef_ { get; set; }
        
    
        
    
    }
    
}

