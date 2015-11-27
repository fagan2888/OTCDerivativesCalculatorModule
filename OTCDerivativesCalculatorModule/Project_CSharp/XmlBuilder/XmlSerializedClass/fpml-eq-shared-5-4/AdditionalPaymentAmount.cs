using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionalPaymentAmount : ISerialized
    {
        public AdditionalPaymentAmount(XmlNode xmlNode)
        {
            XmlNode paymentAmountNode = xmlNode.SelectSingleNode("paymentAmount");
            
            if (paymentAmountNode != null)
            {
                if (paymentAmountNode.Attributes["href"] != null || paymentAmountNode.Attributes["id"] != null) 
                {
                    if (paymentAmountNode.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(paymentAmountNode);
                        IDManager.SetID(paymentAmountIDRef_, ob);
                    }
                    else if (paymentAmountNode.Attributes["href"] != null)
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentAmount_ = new NonNegativeMoney(paymentAmountNode);
                    }
                }
                else
                {
                    paymentAmount_ = new NonNegativeMoney(paymentAmountNode);
                }
            }
            
        
            XmlNode formulaNode = xmlNode.SelectSingleNode("formula");
            
            if (formulaNode != null)
            {
                if (formulaNode.Attributes["href"] != null || formulaNode.Attributes["id"] != null) 
                {
                    if (formulaNode.Attributes["id"] != null) 
                    {
                        formulaIDRef_ = formulaNode.Attributes["id"].Value;
                        Formula ob = new Formula(formulaNode);
                        IDManager.SetID(formulaIDRef_, ob);
                    }
                    else if (formulaNode.Attributes["href"] != null)
                    {
                        formulaIDRef_ = formulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formula_ = new Formula(formulaNode);
                    }
                }
                else
                {
                    formula_ = new Formula(formulaNode);
                }
            }
            
        
        }
        
    
        #region PaymentAmount_
        private NonNegativeMoney paymentAmount_;
        public NonNegativeMoney PaymentAmount_
        {
            get
            {
                if (this.paymentAmount_ != null)
                {
                    return this.paymentAmount_; 
                }
                else if (this.paymentAmountIDRef_ != null)
                {
                    paymentAmount_ = IDManager.getID(paymentAmountIDRef_) as NonNegativeMoney;
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
        #region Formula_
        private Formula formula_;
        public Formula Formula_
        {
            get
            {
                if (this.formula_ != null)
                {
                    return this.formula_; 
                }
                else if (this.formulaIDRef_ != null)
                {
                    formula_ = IDManager.getID(formulaIDRef_) as Formula;
                    return this.formula_; 
                }
                else
                {
                      return this.formula_; 
                }
            }
            set
            {
                if (this.formula_ != value)
                {
                    this.formula_ = value;
                }
            }
        }
        #endregion
        
        public string formulaIDRef_ { get; set; }
        
    
        
    
    }
    
}

