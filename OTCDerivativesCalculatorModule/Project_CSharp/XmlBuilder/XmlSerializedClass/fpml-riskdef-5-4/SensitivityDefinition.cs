using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SensitivityDefinition : ISerialized
    {
        public SensitivityDefinition(XmlNode xmlNode)
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
            
        
            XmlNodeList partialDerivativeNodeList = xmlNode.SelectNodes("partialDerivative");
            
            if (partialDerivativeNodeList != null)
            {
                this.partialDerivative_ = new List<PricingParameterDerivative>();
                foreach (XmlNode item in partialDerivativeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partialDerivativeIDRef_ = item.Attributes["id"].Value;
                            partialDerivative_.Add(new PricingParameterDerivative(item));
                            IDManager.SetID(partialDerivativeIDRef_, partialDerivative_[partialDerivative_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partialDerivativeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partialDerivative_.Add(new PricingParameterDerivative(item));
                        }
                    }
                    else
                    {
                        partialDerivative_.Add(new PricingParameterDerivative(item));
                    }
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
                        DerivativeFormula ob = new DerivativeFormula(formulaNode);
                        IDManager.SetID(formulaIDRef_, ob);
                    }
                    else if (formulaNode.Attributes["href"] != null)
                    {
                        formulaIDRef_ = formulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formula_ = new DerivativeFormula(formulaNode);
                    }
                }
                else
                {
                    formula_ = new DerivativeFormula(formulaNode);
                }
            }
            
        
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        TimeDimension ob = new TimeDimension(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new TimeDimension(termNode);
                    }
                }
                else
                {
                    term_ = new TimeDimension(termNode);
                }
            }
            
        
            XmlNode coordinateNode = xmlNode.SelectSingleNode("coordinate");
            
            if (coordinateNode != null)
            {
                if (coordinateNode.Attributes["href"] != null || coordinateNode.Attributes["id"] != null) 
                {
                    if (coordinateNode.Attributes["id"] != null) 
                    {
                        coordinateIDRef_ = coordinateNode.Attributes["id"].Value;
                        PricingDataPointCoordinate ob = new PricingDataPointCoordinate(coordinateNode);
                        IDManager.SetID(coordinateIDRef_, ob);
                    }
                    else if (coordinateNode.Attributes["href"] != null)
                    {
                        coordinateIDRef_ = coordinateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coordinate_ = new PricingDataPointCoordinate(coordinateNode);
                    }
                }
                else
                {
                    coordinate_ = new PricingDataPointCoordinate(coordinateNode);
                }
            }
            
        
            XmlNode coordinateReferenceNode = xmlNode.SelectSingleNode("coordinateReference");
            
            if (coordinateReferenceNode != null)
            {
                if (coordinateReferenceNode.Attributes["href"] != null || coordinateReferenceNode.Attributes["id"] != null) 
                {
                    if (coordinateReferenceNode.Attributes["id"] != null) 
                    {
                        coordinateReferenceIDRef_ = coordinateReferenceNode.Attributes["id"].Value;
                        PricingDataPointCoordinateReference ob = new PricingDataPointCoordinateReference(coordinateReferenceNode);
                        IDManager.SetID(coordinateReferenceIDRef_, ob);
                    }
                    else if (coordinateReferenceNode.Attributes["href"] != null)
                    {
                        coordinateReferenceIDRef_ = coordinateReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coordinateReference_ = new PricingDataPointCoordinateReference(coordinateReferenceNode);
                    }
                }
                else
                {
                    coordinateReference_ = new PricingDataPointCoordinateReference(coordinateReferenceNode);
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
        #region PartialDerivative_
        private List<PricingParameterDerivative> partialDerivative_;
        public List<PricingParameterDerivative> PartialDerivative_
        {
            get
            {
                if (this.partialDerivative_ != null)
                {
                    return this.partialDerivative_; 
                }
                else if (this.partialDerivativeIDRef_ != null)
                {
                    return this.partialDerivative_; 
                }
                else
                {
                      return this.partialDerivative_; 
                }
            }
            set
            {
                if (this.partialDerivative_ != value)
                {
                    this.partialDerivative_ = value;
                }
            }
        }
        #endregion
        
        public string partialDerivativeIDRef_ { get; set; }
        #region Formula_
        private DerivativeFormula formula_;
        public DerivativeFormula Formula_
        {
            get
            {
                if (this.formula_ != null)
                {
                    return this.formula_; 
                }
                else if (this.formulaIDRef_ != null)
                {
                    formula_ = IDManager.getID(formulaIDRef_) as DerivativeFormula;
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
        #region Term_
        private TimeDimension term_;
        public TimeDimension Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as TimeDimension;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
        #region Coordinate_
        private PricingDataPointCoordinate coordinate_;
        public PricingDataPointCoordinate Coordinate_
        {
            get
            {
                if (this.coordinate_ != null)
                {
                    return this.coordinate_; 
                }
                else if (this.coordinateIDRef_ != null)
                {
                    coordinate_ = IDManager.getID(coordinateIDRef_) as PricingDataPointCoordinate;
                    return this.coordinate_; 
                }
                else
                {
                      return this.coordinate_; 
                }
            }
            set
            {
                if (this.coordinate_ != value)
                {
                    this.coordinate_ = value;
                }
            }
        }
        #endregion
        
        public string coordinateIDRef_ { get; set; }
        #region CoordinateReference_
        private PricingDataPointCoordinateReference coordinateReference_;
        public PricingDataPointCoordinateReference CoordinateReference_
        {
            get
            {
                if (this.coordinateReference_ != null)
                {
                    return this.coordinateReference_; 
                }
                else if (this.coordinateReferenceIDRef_ != null)
                {
                    coordinateReference_ = IDManager.getID(coordinateReferenceIDRef_) as PricingDataPointCoordinateReference;
                    return this.coordinateReference_; 
                }
                else
                {
                      return this.coordinateReference_; 
                }
            }
            set
            {
                if (this.coordinateReference_ != value)
                {
                    this.coordinateReference_ = value;
                }
            }
        }
        #endregion
        
        public string coordinateReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

