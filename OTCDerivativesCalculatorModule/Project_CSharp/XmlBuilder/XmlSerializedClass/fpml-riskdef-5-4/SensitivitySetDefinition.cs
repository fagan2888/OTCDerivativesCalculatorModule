using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SensitivitySetDefinition : ISerialized
    {
        public SensitivitySetDefinition(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeString(nameNode);
                }
            }
            
        
            XmlNode sensitivityCharacteristicsNode = xmlNode.SelectSingleNode("sensitivityCharacteristics");
            
            if (sensitivityCharacteristicsNode != null)
            {
                if (sensitivityCharacteristicsNode.Attributes["href"] != null || sensitivityCharacteristicsNode.Attributes["id"] != null) 
                {
                    if (sensitivityCharacteristicsNode.Attributes["id"] != null) 
                    {
                        sensitivityCharacteristicsIDRef_ = sensitivityCharacteristicsNode.Attributes["id"].Value;
                        QuotationCharacteristics ob = new QuotationCharacteristics(sensitivityCharacteristicsNode);
                        IDManager.SetID(sensitivityCharacteristicsIDRef_, ob);
                    }
                    else if (sensitivityCharacteristicsNode.Attributes["href"] != null)
                    {
                        sensitivityCharacteristicsIDRef_ = sensitivityCharacteristicsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sensitivityCharacteristics_ = new QuotationCharacteristics(sensitivityCharacteristicsNode);
                    }
                }
                else
                {
                    sensitivityCharacteristics_ = new QuotationCharacteristics(sensitivityCharacteristicsNode);
                }
            }
            
        
            XmlNode valuationScenarioReferenceNode = xmlNode.SelectSingleNode("valuationScenarioReference");
            
            if (valuationScenarioReferenceNode != null)
            {
                if (valuationScenarioReferenceNode.Attributes["href"] != null || valuationScenarioReferenceNode.Attributes["id"] != null) 
                {
                    if (valuationScenarioReferenceNode.Attributes["id"] != null) 
                    {
                        valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode.Attributes["id"].Value;
                        ValuationScenarioReference ob = new ValuationScenarioReference(valuationScenarioReferenceNode);
                        IDManager.SetID(valuationScenarioReferenceIDRef_, ob);
                    }
                    else if (valuationScenarioReferenceNode.Attributes["href"] != null)
                    {
                        valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationScenarioReference_ = new ValuationScenarioReference(valuationScenarioReferenceNode);
                    }
                }
                else
                {
                    valuationScenarioReference_ = new ValuationScenarioReference(valuationScenarioReferenceNode);
                }
            }
            
        
            XmlNode pricingInputTypeNode = xmlNode.SelectSingleNode("pricingInputType");
            
            if (pricingInputTypeNode != null)
            {
                if (pricingInputTypeNode.Attributes["href"] != null || pricingInputTypeNode.Attributes["id"] != null) 
                {
                    if (pricingInputTypeNode.Attributes["id"] != null) 
                    {
                        pricingInputTypeIDRef_ = pricingInputTypeNode.Attributes["id"].Value;
                        PricingInputType ob = new PricingInputType(pricingInputTypeNode);
                        IDManager.SetID(pricingInputTypeIDRef_, ob);
                    }
                    else if (pricingInputTypeNode.Attributes["href"] != null)
                    {
                        pricingInputTypeIDRef_ = pricingInputTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingInputType_ = new PricingInputType(pricingInputTypeNode);
                    }
                }
                else
                {
                    pricingInputType_ = new PricingInputType(pricingInputTypeNode);
                }
            }
            
        
            XmlNode pricingInputReferenceNode = xmlNode.SelectSingleNode("pricingInputReference");
            
            if (pricingInputReferenceNode != null)
            {
                if (pricingInputReferenceNode.Attributes["href"] != null || pricingInputReferenceNode.Attributes["id"] != null) 
                {
                    if (pricingInputReferenceNode.Attributes["id"] != null) 
                    {
                        pricingInputReferenceIDRef_ = pricingInputReferenceNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(pricingInputReferenceNode);
                        IDManager.SetID(pricingInputReferenceIDRef_, ob);
                    }
                    else if (pricingInputReferenceNode.Attributes["href"] != null)
                    {
                        pricingInputReferenceIDRef_ = pricingInputReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingInputReference_ = new PricingStructureReference(pricingInputReferenceNode);
                    }
                }
                else
                {
                    pricingInputReference_ = new PricingStructureReference(pricingInputReferenceNode);
                }
            }
            
        
            XmlNode scaleNode = xmlNode.SelectSingleNode("scale");
            
            if (scaleNode != null)
            {
                if (scaleNode.Attributes["href"] != null || scaleNode.Attributes["id"] != null) 
                {
                    if (scaleNode.Attributes["id"] != null) 
                    {
                        scaleIDRef_ = scaleNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(scaleNode);
                        IDManager.SetID(scaleIDRef_, ob);
                    }
                    else if (scaleNode.Attributes["href"] != null)
                    {
                        scaleIDRef_ = scaleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        scale_ = new XsdTypeDecimal(scaleNode);
                    }
                }
                else
                {
                    scale_ = new XsdTypeDecimal(scaleNode);
                }
            }
            
        
            XmlNodeList sensitivityDefinitionNodeList = xmlNode.SelectNodes("sensitivityDefinition");
            
            if (sensitivityDefinitionNodeList != null)
            {
                this.sensitivityDefinition_ = new List<SensitivityDefinition>();
                foreach (XmlNode item in sensitivityDefinitionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            sensitivityDefinitionIDRef_ = item.Attributes["id"].Value;
                            sensitivityDefinition_.Add(new SensitivityDefinition(item));
                            IDManager.SetID(sensitivityDefinitionIDRef_, sensitivityDefinition_[sensitivityDefinition_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            sensitivityDefinitionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        sensitivityDefinition_.Add(new SensitivityDefinition(item));
                        }
                    }
                    else
                    {
                        sensitivityDefinition_.Add(new SensitivityDefinition(item));
                    }
                }
            }
            
        
            XmlNode calculationProcedureNode = xmlNode.SelectSingleNode("calculationProcedure");
            
            if (calculationProcedureNode != null)
            {
                if (calculationProcedureNode.Attributes["href"] != null || calculationProcedureNode.Attributes["id"] != null) 
                {
                    if (calculationProcedureNode.Attributes["id"] != null) 
                    {
                        calculationProcedureIDRef_ = calculationProcedureNode.Attributes["id"].Value;
                        DerivativeCalculationProcedure ob = new DerivativeCalculationProcedure(calculationProcedureNode);
                        IDManager.SetID(calculationProcedureIDRef_, ob);
                    }
                    else if (calculationProcedureNode.Attributes["href"] != null)
                    {
                        calculationProcedureIDRef_ = calculationProcedureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationProcedure_ = new DerivativeCalculationProcedure(calculationProcedureNode);
                    }
                }
                else
                {
                    calculationProcedure_ = new DerivativeCalculationProcedure(calculationProcedureNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeString name_;
        public XsdTypeString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region SensitivityCharacteristics_
        private QuotationCharacteristics sensitivityCharacteristics_;
        public QuotationCharacteristics SensitivityCharacteristics_
        {
            get
            {
                if (this.sensitivityCharacteristics_ != null)
                {
                    return this.sensitivityCharacteristics_; 
                }
                else if (this.sensitivityCharacteristicsIDRef_ != null)
                {
                    sensitivityCharacteristics_ = IDManager.getID(sensitivityCharacteristicsIDRef_) as QuotationCharacteristics;
                    return this.sensitivityCharacteristics_; 
                }
                else
                {
                      return this.sensitivityCharacteristics_; 
                }
            }
            set
            {
                if (this.sensitivityCharacteristics_ != value)
                {
                    this.sensitivityCharacteristics_ = value;
                }
            }
        }
        #endregion
        
        public string sensitivityCharacteristicsIDRef_ { get; set; }
        #region ValuationScenarioReference_
        private ValuationScenarioReference valuationScenarioReference_;
        public ValuationScenarioReference ValuationScenarioReference_
        {
            get
            {
                if (this.valuationScenarioReference_ != null)
                {
                    return this.valuationScenarioReference_; 
                }
                else if (this.valuationScenarioReferenceIDRef_ != null)
                {
                    valuationScenarioReference_ = IDManager.getID(valuationScenarioReferenceIDRef_) as ValuationScenarioReference;
                    return this.valuationScenarioReference_; 
                }
                else
                {
                      return this.valuationScenarioReference_; 
                }
            }
            set
            {
                if (this.valuationScenarioReference_ != value)
                {
                    this.valuationScenarioReference_ = value;
                }
            }
        }
        #endregion
        
        public string valuationScenarioReferenceIDRef_ { get; set; }
        #region PricingInputType_
        private PricingInputType pricingInputType_;
        public PricingInputType PricingInputType_
        {
            get
            {
                if (this.pricingInputType_ != null)
                {
                    return this.pricingInputType_; 
                }
                else if (this.pricingInputTypeIDRef_ != null)
                {
                    pricingInputType_ = IDManager.getID(pricingInputTypeIDRef_) as PricingInputType;
                    return this.pricingInputType_; 
                }
                else
                {
                      return this.pricingInputType_; 
                }
            }
            set
            {
                if (this.pricingInputType_ != value)
                {
                    this.pricingInputType_ = value;
                }
            }
        }
        #endregion
        
        public string pricingInputTypeIDRef_ { get; set; }
        #region PricingInputReference_
        private PricingStructureReference pricingInputReference_;
        public PricingStructureReference PricingInputReference_
        {
            get
            {
                if (this.pricingInputReference_ != null)
                {
                    return this.pricingInputReference_; 
                }
                else if (this.pricingInputReferenceIDRef_ != null)
                {
                    pricingInputReference_ = IDManager.getID(pricingInputReferenceIDRef_) as PricingStructureReference;
                    return this.pricingInputReference_; 
                }
                else
                {
                      return this.pricingInputReference_; 
                }
            }
            set
            {
                if (this.pricingInputReference_ != value)
                {
                    this.pricingInputReference_ = value;
                }
            }
        }
        #endregion
        
        public string pricingInputReferenceIDRef_ { get; set; }
        #region Scale_
        private XsdTypeDecimal scale_;
        public XsdTypeDecimal Scale_
        {
            get
            {
                if (this.scale_ != null)
                {
                    return this.scale_; 
                }
                else if (this.scaleIDRef_ != null)
                {
                    scale_ = IDManager.getID(scaleIDRef_) as XsdTypeDecimal;
                    return this.scale_; 
                }
                else
                {
                      return this.scale_; 
                }
            }
            set
            {
                if (this.scale_ != value)
                {
                    this.scale_ = value;
                }
            }
        }
        #endregion
        
        public string scaleIDRef_ { get; set; }
        #region SensitivityDefinition_
        private List<SensitivityDefinition> sensitivityDefinition_;
        public List<SensitivityDefinition> SensitivityDefinition_
        {
            get
            {
                if (this.sensitivityDefinition_ != null)
                {
                    return this.sensitivityDefinition_; 
                }
                else if (this.sensitivityDefinitionIDRef_ != null)
                {
                    return this.sensitivityDefinition_; 
                }
                else
                {
                      return this.sensitivityDefinition_; 
                }
            }
            set
            {
                if (this.sensitivityDefinition_ != value)
                {
                    this.sensitivityDefinition_ = value;
                }
            }
        }
        #endregion
        
        public string sensitivityDefinitionIDRef_ { get; set; }
        #region CalculationProcedure_
        private DerivativeCalculationProcedure calculationProcedure_;
        public DerivativeCalculationProcedure CalculationProcedure_
        {
            get
            {
                if (this.calculationProcedure_ != null)
                {
                    return this.calculationProcedure_; 
                }
                else if (this.calculationProcedureIDRef_ != null)
                {
                    calculationProcedure_ = IDManager.getID(calculationProcedureIDRef_) as DerivativeCalculationProcedure;
                    return this.calculationProcedure_; 
                }
                else
                {
                      return this.calculationProcedure_; 
                }
            }
            set
            {
                if (this.calculationProcedure_ != value)
                {
                    this.calculationProcedure_ = value;
                }
            }
        }
        #endregion
        
        public string calculationProcedureIDRef_ { get; set; }
        
    
        
    
    }
    
}

