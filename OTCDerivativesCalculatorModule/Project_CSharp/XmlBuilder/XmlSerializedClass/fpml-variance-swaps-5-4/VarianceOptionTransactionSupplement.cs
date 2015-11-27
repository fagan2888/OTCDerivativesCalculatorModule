using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VarianceOptionTransactionSupplement : OptionBase
    {
        public VarianceOptionTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode equityPremiumNode = xmlNode.SelectSingleNode("equityPremium");
            
            if (equityPremiumNode != null)
            {
                if (equityPremiumNode.Attributes["href"] != null || equityPremiumNode.Attributes["id"] != null) 
                {
                    if (equityPremiumNode.Attributes["id"] != null) 
                    {
                        equityPremiumIDRef_ = equityPremiumNode.Attributes["id"].Value;
                        EquityPremium ob = new EquityPremium(equityPremiumNode);
                        IDManager.SetID(equityPremiumIDRef_, ob);
                    }
                    else if (equityPremiumNode.Attributes["href"] != null)
                    {
                        equityPremiumIDRef_ = equityPremiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityPremium_ = new EquityPremium(equityPremiumNode);
                    }
                }
                else
                {
                    equityPremium_ = new EquityPremium(equityPremiumNode);
                }
            }
            
        
            XmlNode equityExerciseNode = xmlNode.SelectSingleNode("equityExercise");
            
            if (equityExerciseNode != null)
            {
                if (equityExerciseNode.Attributes["href"] != null || equityExerciseNode.Attributes["id"] != null) 
                {
                    if (equityExerciseNode.Attributes["id"] != null) 
                    {
                        equityExerciseIDRef_ = equityExerciseNode.Attributes["id"].Value;
                        EquityExerciseValuationSettlement ob = new EquityExerciseValuationSettlement(equityExerciseNode);
                        IDManager.SetID(equityExerciseIDRef_, ob);
                    }
                    else if (equityExerciseNode.Attributes["href"] != null)
                    {
                        equityExerciseIDRef_ = equityExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityExercise_ = new EquityExerciseValuationSettlement(equityExerciseNode);
                    }
                }
                else
                {
                    equityExercise_ = new EquityExerciseValuationSettlement(equityExerciseNode);
                }
            }
            
        
            XmlNode exchangeLookAlikeNode = xmlNode.SelectSingleNode("exchangeLookAlike");
            
            if (exchangeLookAlikeNode != null)
            {
                if (exchangeLookAlikeNode.Attributes["href"] != null || exchangeLookAlikeNode.Attributes["id"] != null) 
                {
                    if (exchangeLookAlikeNode.Attributes["id"] != null) 
                    {
                        exchangeLookAlikeIDRef_ = exchangeLookAlikeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(exchangeLookAlikeNode);
                        IDManager.SetID(exchangeLookAlikeIDRef_, ob);
                    }
                    else if (exchangeLookAlikeNode.Attributes["href"] != null)
                    {
                        exchangeLookAlikeIDRef_ = exchangeLookAlikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeLookAlike_ = new XsdTypeBoolean(exchangeLookAlikeNode);
                    }
                }
                else
                {
                    exchangeLookAlike_ = new XsdTypeBoolean(exchangeLookAlikeNode);
                }
            }
            
        
            XmlNode methodOfAdjustmentNode = xmlNode.SelectSingleNode("methodOfAdjustment");
            
            if (methodOfAdjustmentNode != null)
            {
                if (methodOfAdjustmentNode.Attributes["href"] != null || methodOfAdjustmentNode.Attributes["id"] != null) 
                {
                    if (methodOfAdjustmentNode.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["id"].Value;
                        MethodOfAdjustmentEnum ob = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                        IDManager.SetID(methodOfAdjustmentIDRef_, ob);
                    }
                    else if (methodOfAdjustmentNode.Attributes["href"] != null)
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                    }
                }
                else
                {
                    methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                }
            }
            
        
            XmlNode optionEntitlementNode = xmlNode.SelectSingleNode("optionEntitlement");
            
            if (optionEntitlementNode != null)
            {
                if (optionEntitlementNode.Attributes["href"] != null || optionEntitlementNode.Attributes["id"] != null) 
                {
                    if (optionEntitlementNode.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(optionEntitlementNode);
                        IDManager.SetID(optionEntitlementIDRef_, ob);
                    }
                    else if (optionEntitlementNode.Attributes["href"] != null)
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                    }
                }
                else
                {
                    optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                }
            }
            
        
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new PositiveDecimal(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new PositiveDecimal(multiplierNode);
                }
            }
            
        
            XmlNode varianceSwapTransactionSupplementNode = xmlNode.SelectSingleNode("varianceSwapTransactionSupplement");
            
            if (varianceSwapTransactionSupplementNode != null)
            {
                if (varianceSwapTransactionSupplementNode.Attributes["href"] != null || varianceSwapTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (varianceSwapTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode.Attributes["id"].Value;
                        VarianceSwapTransactionSupplement ob = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                        IDManager.SetID(varianceSwapTransactionSupplementIDRef_, ob);
                    }
                    else if (varianceSwapTransactionSupplementNode.Attributes["href"] != null)
                    {
                        varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceSwapTransactionSupplement_ = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                    }
                }
                else
                {
                    varianceSwapTransactionSupplement_ = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                }
            }
            
        
        }
        
    
        #region EquityPremium_
        private EquityPremium equityPremium_;
        public EquityPremium EquityPremium_
        {
            get
            {
                if (this.equityPremium_ != null)
                {
                    return this.equityPremium_; 
                }
                else if (this.equityPremiumIDRef_ != null)
                {
                    equityPremium_ = IDManager.getID(equityPremiumIDRef_) as EquityPremium;
                    return this.equityPremium_; 
                }
                else
                {
                      return this.equityPremium_; 
                }
            }
            set
            {
                if (this.equityPremium_ != value)
                {
                    this.equityPremium_ = value;
                }
            }
        }
        #endregion
        
        public string equityPremiumIDRef_ { get; set; }
        #region EquityExercise_
        private EquityExerciseValuationSettlement equityExercise_;
        public EquityExerciseValuationSettlement EquityExercise_
        {
            get
            {
                if (this.equityExercise_ != null)
                {
                    return this.equityExercise_; 
                }
                else if (this.equityExerciseIDRef_ != null)
                {
                    equityExercise_ = IDManager.getID(equityExerciseIDRef_) as EquityExerciseValuationSettlement;
                    return this.equityExercise_; 
                }
                else
                {
                      return this.equityExercise_; 
                }
            }
            set
            {
                if (this.equityExercise_ != value)
                {
                    this.equityExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityExerciseIDRef_ { get; set; }
        #region ExchangeLookAlike_
        private XsdTypeBoolean exchangeLookAlike_;
        public XsdTypeBoolean ExchangeLookAlike_
        {
            get
            {
                if (this.exchangeLookAlike_ != null)
                {
                    return this.exchangeLookAlike_; 
                }
                else if (this.exchangeLookAlikeIDRef_ != null)
                {
                    exchangeLookAlike_ = IDManager.getID(exchangeLookAlikeIDRef_) as XsdTypeBoolean;
                    return this.exchangeLookAlike_; 
                }
                else
                {
                      return this.exchangeLookAlike_; 
                }
            }
            set
            {
                if (this.exchangeLookAlike_ != value)
                {
                    this.exchangeLookAlike_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeLookAlikeIDRef_ { get; set; }
        #region MethodOfAdjustment_
        private MethodOfAdjustmentEnum methodOfAdjustment_;
        public MethodOfAdjustmentEnum MethodOfAdjustment_
        {
            get
            {
                if (this.methodOfAdjustment_ != null)
                {
                    return this.methodOfAdjustment_; 
                }
                else if (this.methodOfAdjustmentIDRef_ != null)
                {
                    methodOfAdjustment_ = IDManager.getID(methodOfAdjustmentIDRef_) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment_; 
                }
                else
                {
                      return this.methodOfAdjustment_; 
                }
            }
            set
            {
                if (this.methodOfAdjustment_ != value)
                {
                    this.methodOfAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string methodOfAdjustmentIDRef_ { get; set; }
        #region OptionEntitlement_
        private PositiveDecimal optionEntitlement_;
        public PositiveDecimal OptionEntitlement_
        {
            get
            {
                if (this.optionEntitlement_ != null)
                {
                    return this.optionEntitlement_; 
                }
                else if (this.optionEntitlementIDRef_ != null)
                {
                    optionEntitlement_ = IDManager.getID(optionEntitlementIDRef_) as PositiveDecimal;
                    return this.optionEntitlement_; 
                }
                else
                {
                      return this.optionEntitlement_; 
                }
            }
            set
            {
                if (this.optionEntitlement_ != value)
                {
                    this.optionEntitlement_ = value;
                }
            }
        }
        #endregion
        
        public string optionEntitlementIDRef_ { get; set; }
        #region Multiplier_
        private PositiveDecimal multiplier_;
        public PositiveDecimal Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as PositiveDecimal;
                    return this.multiplier_; 
                }
                else
                {
                      return this.multiplier_; 
                }
            }
            set
            {
                if (this.multiplier_ != value)
                {
                    this.multiplier_ = value;
                }
            }
        }
        #endregion
        
        public string multiplierIDRef_ { get; set; }
        #region VarianceSwapTransactionSupplement_
        private VarianceSwapTransactionSupplement varianceSwapTransactionSupplement_;
        public VarianceSwapTransactionSupplement VarianceSwapTransactionSupplement_
        {
            get
            {
                if (this.varianceSwapTransactionSupplement_ != null)
                {
                    return this.varianceSwapTransactionSupplement_; 
                }
                else if (this.varianceSwapTransactionSupplementIDRef_ != null)
                {
                    varianceSwapTransactionSupplement_ = IDManager.getID(varianceSwapTransactionSupplementIDRef_) as VarianceSwapTransactionSupplement;
                    return this.varianceSwapTransactionSupplement_; 
                }
                else
                {
                      return this.varianceSwapTransactionSupplement_; 
                }
            }
            set
            {
                if (this.varianceSwapTransactionSupplement_ != value)
                {
                    this.varianceSwapTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string varianceSwapTransactionSupplementIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

