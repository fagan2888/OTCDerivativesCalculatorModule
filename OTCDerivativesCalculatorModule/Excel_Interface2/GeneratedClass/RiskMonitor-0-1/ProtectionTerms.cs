using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProtectionTerms : ISerialized
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
            
        
            XmlNode obligationsNode = xmlNode.SelectSingleNode("obligations");
            
            if (obligationsNode != null)
            {
                if (obligationsNode.Attributes["href"] != null || obligationsNode.Attributes["id"] != null) 
                {
                    if (obligationsNode.Attributes["id"] != null) 
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["id"].Value;
                        Obligations ob = new Obligations(obligationsNode);
                        IDManager.SetID(obligationsIDRef_, ob);
                    }
                    else if (obligationsNode.Attributes["href"] != null)
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligations_ = new Obligations(obligationsNode);
                    }
                }
                else
                {
                    obligations_ = new Obligations(obligationsNode);
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
                    throw new Exception( "calculationAmount_Node no exist!");
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
                    throw new Exception( "creditEvents_Node no exist!");
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
        #region Obligations_
        private Obligations obligations_;
        public Obligations Obligations_
        {
            get
            {
                if (this.obligations_ != null)
                {
                    return this.obligations_; 
                }
                else if (this.obligationsIDRef_ != null)
                {
                    obligations_ = IDManager.getID(obligationsIDRef_) as Obligations;
                    return this.obligations_; 
                }
                else
                {
                    throw new Exception( "obligations_Node no exist!");
                }
            }
            set
            {
                if (this.obligations_ != value)
                {
                    this.obligations_ = value;
                }
            }
        }
        #endregion
        
        public string obligationsIDRef_ { get; set; }
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
                    throw new Exception( "accrualCoupon_Node no exist!");
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

