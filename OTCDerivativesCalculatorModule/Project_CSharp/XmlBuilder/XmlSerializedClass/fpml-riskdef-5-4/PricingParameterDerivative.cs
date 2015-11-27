using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingParameterDerivative : ISerialized
    {
        public PricingParameterDerivative(XmlNode xmlNode)
        {
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeString(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeString(descriptionNode);
                }
            }
            
        
            XmlNode parameterReferenceNode = xmlNode.SelectSingleNode("parameterReference");
            
            if (parameterReferenceNode != null)
            {
                if (parameterReferenceNode.Attributes["href"] != null || parameterReferenceNode.Attributes["id"] != null) 
                {
                    if (parameterReferenceNode.Attributes["id"] != null) 
                    {
                        parameterReferenceIDRef_ = parameterReferenceNode.Attributes["id"].Value;
                        AssetOrTermPointOrPricingStructureReference ob = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                        IDManager.SetID(parameterReferenceIDRef_, ob);
                    }
                    else if (parameterReferenceNode.Attributes["href"] != null)
                    {
                        parameterReferenceIDRef_ = parameterReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parameterReference_ = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                    }
                }
                else
                {
                    parameterReference_ = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                }
            }
            
        
            XmlNodeList inputDateReferenceNodeList = xmlNode.SelectNodes("inputDateReference");
            
            if (inputDateReferenceNodeList != null)
            {
                this.inputDateReference_ = new List<ValuationReference>();
                foreach (XmlNode item in inputDateReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            inputDateReferenceIDRef_ = item.Attributes["id"].Value;
                            inputDateReference_.Add(new ValuationReference(item));
                            IDManager.SetID(inputDateReferenceIDRef_, inputDateReference_[inputDateReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            inputDateReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        inputDateReference_.Add(new ValuationReference(item));
                        }
                    }
                    else
                    {
                        inputDateReference_.Add(new ValuationReference(item));
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
        
    
        #region Description_
        private XsdTypeString description_;
        public XsdTypeString Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeString;
                    return this.description_; 
                }
                else
                {
                      return this.description_; 
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        #region ParameterReference_
        private AssetOrTermPointOrPricingStructureReference parameterReference_;
        public AssetOrTermPointOrPricingStructureReference ParameterReference_
        {
            get
            {
                if (this.parameterReference_ != null)
                {
                    return this.parameterReference_; 
                }
                else if (this.parameterReferenceIDRef_ != null)
                {
                    parameterReference_ = IDManager.getID(parameterReferenceIDRef_) as AssetOrTermPointOrPricingStructureReference;
                    return this.parameterReference_; 
                }
                else
                {
                      return this.parameterReference_; 
                }
            }
            set
            {
                if (this.parameterReference_ != value)
                {
                    this.parameterReference_ = value;
                }
            }
        }
        #endregion
        
        public string parameterReferenceIDRef_ { get; set; }
        #region InputDateReference_
        private List<ValuationReference> inputDateReference_;
        public List<ValuationReference> InputDateReference_
        {
            get
            {
                if (this.inputDateReference_ != null)
                {
                    return this.inputDateReference_; 
                }
                else if (this.inputDateReferenceIDRef_ != null)
                {
                    return this.inputDateReference_; 
                }
                else
                {
                      return this.inputDateReference_; 
                }
            }
            set
            {
                if (this.inputDateReference_ != value)
                {
                    this.inputDateReference_ = value;
                }
            }
        }
        #endregion
        
        public string inputDateReferenceIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

