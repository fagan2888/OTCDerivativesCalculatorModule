using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SensitivityDefinition
    {
        public SensitivityDefinition(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList valuationScenarioReferenceNodeList = xmlNode.SelectNodes("valuationScenarioReference");
            if (valuationScenarioReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationScenarioReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationScenarioReferenceIDRef = item.Attributes["id"].Name;
                        ValuationScenarioReference ob = ValuationScenarioReference();
                        IDManager.SetID(valuationScenarioReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationScenarioReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationScenarioReference = new ValuationScenarioReference(item);
                    }
                }
            }
            
        
            XmlNodeList partialDerivativeNodeList = xmlNode.SelectNodes("partialDerivative");
            
            foreach (XmlNode item in partialDerivativeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partialDerivativeIDRef = item.Attributes["id"].Name;
                        List<PricingParameterDerivative> ob = new List<PricingParameterDerivative>();
                        ob.Add(new PricingParameterDerivative(item));
                        IDManager.SetID(partialDerivativeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partialDerivativeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partialDerivative.Add(new PricingParameterDerivative(item));
                    }
                }
            }
            
        
            XmlNodeList formulaNodeList = xmlNode.SelectNodes("formula");
            if (formulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaIDRef = item.Attributes["id"].Name;
                        DerivativeFormula ob = DerivativeFormula();
                        IDManager.SetID(formulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formula = new DerivativeFormula(item);
                    }
                }
            }
            
        
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        TimeDimension ob = TimeDimension();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new TimeDimension(item);
                    }
                }
            }
            
        
            XmlNodeList coordinateNodeList = xmlNode.SelectNodes("coordinate");
            if (coordinateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coordinateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coordinateIDRef = item.Attributes["id"].Name;
                        PricingDataPointCoordinate ob = PricingDataPointCoordinate();
                        IDManager.SetID(coordinateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coordinateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coordinate = new PricingDataPointCoordinate(item);
                    }
                }
            }
            
        
            XmlNodeList coordinateReferenceNodeList = xmlNode.SelectNodes("coordinateReference");
            if (coordinateReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coordinateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coordinateReferenceIDRef = item.Attributes["id"].Name;
                        PricingDataPointCoordinateReference ob = PricingDataPointCoordinateReference();
                        IDManager.SetID(coordinateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coordinateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coordinateReference = new PricingDataPointCoordinateReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeString name;
        public XsdTypeString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ValuationScenarioReference
        private ValuationScenarioReference valuationScenarioReference;
        public ValuationScenarioReference ValuationScenarioReference
        {
            get
            {
                if (this.valuationScenarioReference != null)
                {
                    return this.valuationScenarioReference; 
                }
                else if (this.valuationScenarioReferenceIDRef != null)
                {
                    valuationScenarioReference = IDManager.getID(valuationScenarioReferenceIDRef) as ValuationScenarioReference;
                    return this.valuationScenarioReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationScenarioReference != value)
                {
                    this.valuationScenarioReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationScenarioReferenceIDRef { get; set; }
        #region PartialDerivative
        private List<PricingParameterDerivative> partialDerivative;
        public List<PricingParameterDerivative> PartialDerivative
        {
            get
            {
                if (this.partialDerivative != null)
                {
                    return this.partialDerivative; 
                }
                else if (this.partialDerivativeIDRef != null)
                {
                    partialDerivative = IDManager.getID(partialDerivativeIDRef) as List<PricingParameterDerivative>;
                    return this.partialDerivative; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partialDerivative != value)
                {
                    this.partialDerivative = value;
                }
            }
        }
        #endregion
        
        public string PricingParameterDerivativeIDRef { get; set; }
        #region Formula
        private DerivativeFormula formula;
        public DerivativeFormula Formula
        {
            get
            {
                if (this.formula != null)
                {
                    return this.formula; 
                }
                else if (this.formulaIDRef != null)
                {
                    formula = IDManager.getID(formulaIDRef) as DerivativeFormula;
                    return this.formula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                }
            }
        }
        #endregion
        
        public string DerivativeFormulaIDRef { get; set; }
        #region Term
        private TimeDimension term;
        public TimeDimension Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as TimeDimension;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string TimeDimensionIDRef { get; set; }
        #region Coordinate
        private PricingDataPointCoordinate coordinate;
        public PricingDataPointCoordinate Coordinate
        {
            get
            {
                if (this.coordinate != null)
                {
                    return this.coordinate; 
                }
                else if (this.coordinateIDRef != null)
                {
                    coordinate = IDManager.getID(coordinateIDRef) as PricingDataPointCoordinate;
                    return this.coordinate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coordinate != value)
                {
                    this.coordinate = value;
                }
            }
        }
        #endregion
        
        public string PricingDataPointCoordinateIDRef { get; set; }
        #region CoordinateReference
        private PricingDataPointCoordinateReference coordinateReference;
        public PricingDataPointCoordinateReference CoordinateReference
        {
            get
            {
                if (this.coordinateReference != null)
                {
                    return this.coordinateReference; 
                }
                else if (this.coordinateReferenceIDRef != null)
                {
                    coordinateReference = IDManager.getID(coordinateReferenceIDRef) as PricingDataPointCoordinateReference;
                    return this.coordinateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coordinateReference != value)
                {
                    this.coordinateReference = value;
                }
            }
        }
        #endregion
        
        public string PricingDataPointCoordinateReferenceIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

