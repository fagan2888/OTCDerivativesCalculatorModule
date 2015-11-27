using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DerivativeCalculationProcedure : ISerialized
    {
        public DerivativeCalculationProcedure(XmlNode xmlNode)
        {
            XmlNode methodNode = xmlNode.SelectSingleNode("method");
            
            if (methodNode != null)
            {
                if (methodNode.Attributes["href"] != null || methodNode.Attributes["id"] != null) 
                {
                    if (methodNode.Attributes["id"] != null) 
                    {
                        methodIDRef_ = methodNode.Attributes["id"].Value;
                        DerivativeCalculationMethod ob = new DerivativeCalculationMethod(methodNode);
                        IDManager.SetID(methodIDRef_, ob);
                    }
                    else if (methodNode.Attributes["href"] != null)
                    {
                        methodIDRef_ = methodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        method_ = new DerivativeCalculationMethod(methodNode);
                    }
                }
                else
                {
                    method_ = new DerivativeCalculationMethod(methodNode);
                }
            }
            
        
            XmlNode perturbationAmountNode = xmlNode.SelectSingleNode("perturbationAmount");
            
            if (perturbationAmountNode != null)
            {
                if (perturbationAmountNode.Attributes["href"] != null || perturbationAmountNode.Attributes["id"] != null) 
                {
                    if (perturbationAmountNode.Attributes["id"] != null) 
                    {
                        perturbationAmountIDRef_ = perturbationAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(perturbationAmountNode);
                        IDManager.SetID(perturbationAmountIDRef_, ob);
                    }
                    else if (perturbationAmountNode.Attributes["href"] != null)
                    {
                        perturbationAmountIDRef_ = perturbationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        perturbationAmount_ = new XsdTypeDecimal(perturbationAmountNode);
                    }
                }
                else
                {
                    perturbationAmount_ = new XsdTypeDecimal(perturbationAmountNode);
                }
            }
            
        
            XmlNode averagedNode = xmlNode.SelectSingleNode("averaged");
            
            if (averagedNode != null)
            {
                if (averagedNode.Attributes["href"] != null || averagedNode.Attributes["id"] != null) 
                {
                    if (averagedNode.Attributes["id"] != null) 
                    {
                        averagedIDRef_ = averagedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(averagedNode);
                        IDManager.SetID(averagedIDRef_, ob);
                    }
                    else if (averagedNode.Attributes["href"] != null)
                    {
                        averagedIDRef_ = averagedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averaged_ = new XsdTypeBoolean(averagedNode);
                    }
                }
                else
                {
                    averaged_ = new XsdTypeBoolean(averagedNode);
                }
            }
            
        
            XmlNode perturbationTypeNode = xmlNode.SelectSingleNode("perturbationType");
            
            if (perturbationTypeNode != null)
            {
                if (perturbationTypeNode.Attributes["href"] != null || perturbationTypeNode.Attributes["id"] != null) 
                {
                    if (perturbationTypeNode.Attributes["id"] != null) 
                    {
                        perturbationTypeIDRef_ = perturbationTypeNode.Attributes["id"].Value;
                        PerturbationType ob = new PerturbationType(perturbationTypeNode);
                        IDManager.SetID(perturbationTypeIDRef_, ob);
                    }
                    else if (perturbationTypeNode.Attributes["href"] != null)
                    {
                        perturbationTypeIDRef_ = perturbationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        perturbationType_ = new PerturbationType(perturbationTypeNode);
                    }
                }
                else
                {
                    perturbationType_ = new PerturbationType(perturbationTypeNode);
                }
            }
            
        
            XmlNode derivativeFormulaNode = xmlNode.SelectSingleNode("derivativeFormula");
            
            if (derivativeFormulaNode != null)
            {
                if (derivativeFormulaNode.Attributes["href"] != null || derivativeFormulaNode.Attributes["id"] != null) 
                {
                    if (derivativeFormulaNode.Attributes["id"] != null) 
                    {
                        derivativeFormulaIDRef_ = derivativeFormulaNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(derivativeFormulaNode);
                        IDManager.SetID(derivativeFormulaIDRef_, ob);
                    }
                    else if (derivativeFormulaNode.Attributes["href"] != null)
                    {
                        derivativeFormulaIDRef_ = derivativeFormulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        derivativeFormula_ = new XsdTypeString(derivativeFormulaNode);
                    }
                }
                else
                {
                    derivativeFormula_ = new XsdTypeString(derivativeFormulaNode);
                }
            }
            
        
            XmlNode replacementMarketInputNode = xmlNode.SelectSingleNode("replacementMarketInput");
            
            if (replacementMarketInputNode != null)
            {
                if (replacementMarketInputNode.Attributes["href"] != null || replacementMarketInputNode.Attributes["id"] != null) 
                {
                    if (replacementMarketInputNode.Attributes["id"] != null) 
                    {
                        replacementMarketInputIDRef_ = replacementMarketInputNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(replacementMarketInputNode);
                        IDManager.SetID(replacementMarketInputIDRef_, ob);
                    }
                    else if (replacementMarketInputNode.Attributes["href"] != null)
                    {
                        replacementMarketInputIDRef_ = replacementMarketInputNode.Attributes["href"].Value;
                    }
                    else
                    {
                        replacementMarketInput_ = new PricingStructureReference(replacementMarketInputNode);
                    }
                }
                else
                {
                    replacementMarketInput_ = new PricingStructureReference(replacementMarketInputNode);
                }
            }
            
        
        }
        
    
        #region Method_
        private DerivativeCalculationMethod method_;
        public DerivativeCalculationMethod Method_
        {
            get
            {
                if (this.method_ != null)
                {
                    return this.method_; 
                }
                else if (this.methodIDRef_ != null)
                {
                    method_ = IDManager.getID(methodIDRef_) as DerivativeCalculationMethod;
                    return this.method_; 
                }
                else
                {
                      return this.method_; 
                }
            }
            set
            {
                if (this.method_ != value)
                {
                    this.method_ = value;
                }
            }
        }
        #endregion
        
        public string methodIDRef_ { get; set; }
        #region PerturbationAmount_
        private XsdTypeDecimal perturbationAmount_;
        public XsdTypeDecimal PerturbationAmount_
        {
            get
            {
                if (this.perturbationAmount_ != null)
                {
                    return this.perturbationAmount_; 
                }
                else if (this.perturbationAmountIDRef_ != null)
                {
                    perturbationAmount_ = IDManager.getID(perturbationAmountIDRef_) as XsdTypeDecimal;
                    return this.perturbationAmount_; 
                }
                else
                {
                      return this.perturbationAmount_; 
                }
            }
            set
            {
                if (this.perturbationAmount_ != value)
                {
                    this.perturbationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string perturbationAmountIDRef_ { get; set; }
        #region Averaged_
        private XsdTypeBoolean averaged_;
        public XsdTypeBoolean Averaged_
        {
            get
            {
                if (this.averaged_ != null)
                {
                    return this.averaged_; 
                }
                else if (this.averagedIDRef_ != null)
                {
                    averaged_ = IDManager.getID(averagedIDRef_) as XsdTypeBoolean;
                    return this.averaged_; 
                }
                else
                {
                      return this.averaged_; 
                }
            }
            set
            {
                if (this.averaged_ != value)
                {
                    this.averaged_ = value;
                }
            }
        }
        #endregion
        
        public string averagedIDRef_ { get; set; }
        #region PerturbationType_
        private PerturbationType perturbationType_;
        public PerturbationType PerturbationType_
        {
            get
            {
                if (this.perturbationType_ != null)
                {
                    return this.perturbationType_; 
                }
                else if (this.perturbationTypeIDRef_ != null)
                {
                    perturbationType_ = IDManager.getID(perturbationTypeIDRef_) as PerturbationType;
                    return this.perturbationType_; 
                }
                else
                {
                      return this.perturbationType_; 
                }
            }
            set
            {
                if (this.perturbationType_ != value)
                {
                    this.perturbationType_ = value;
                }
            }
        }
        #endregion
        
        public string perturbationTypeIDRef_ { get; set; }
        #region DerivativeFormula_
        private XsdTypeString derivativeFormula_;
        public XsdTypeString DerivativeFormula_
        {
            get
            {
                if (this.derivativeFormula_ != null)
                {
                    return this.derivativeFormula_; 
                }
                else if (this.derivativeFormulaIDRef_ != null)
                {
                    derivativeFormula_ = IDManager.getID(derivativeFormulaIDRef_) as XsdTypeString;
                    return this.derivativeFormula_; 
                }
                else
                {
                      return this.derivativeFormula_; 
                }
            }
            set
            {
                if (this.derivativeFormula_ != value)
                {
                    this.derivativeFormula_ = value;
                }
            }
        }
        #endregion
        
        public string derivativeFormulaIDRef_ { get; set; }
        #region ReplacementMarketInput_
        private PricingStructureReference replacementMarketInput_;
        public PricingStructureReference ReplacementMarketInput_
        {
            get
            {
                if (this.replacementMarketInput_ != null)
                {
                    return this.replacementMarketInput_; 
                }
                else if (this.replacementMarketInputIDRef_ != null)
                {
                    replacementMarketInput_ = IDManager.getID(replacementMarketInputIDRef_) as PricingStructureReference;
                    return this.replacementMarketInput_; 
                }
                else
                {
                      return this.replacementMarketInput_; 
                }
            }
            set
            {
                if (this.replacementMarketInput_ != value)
                {
                    this.replacementMarketInput_ = value;
                }
            }
        }
        #endregion
        
        public string replacementMarketInputIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

