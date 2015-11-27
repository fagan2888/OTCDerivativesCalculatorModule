using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SensitivitySetDefinition
    {
        public SensitivitySetDefinition(XmlNode xmlNode)
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
            
        
            XmlNodeList sensitivityCharacteristicsNodeList = xmlNode.SelectNodes("sensitivityCharacteristics");
            if (sensitivityCharacteristicsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sensitivityCharacteristicsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sensitivityCharacteristicsIDRef = item.Attributes["id"].Name;
                        QuotationCharacteristics ob = QuotationCharacteristics();
                        IDManager.SetID(sensitivityCharacteristicsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sensitivityCharacteristicsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sensitivityCharacteristics = new QuotationCharacteristics(item);
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
            
        
            XmlNodeList pricingInputTypeNodeList = xmlNode.SelectNodes("pricingInputType");
            if (pricingInputTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingInputTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingInputTypeIDRef = item.Attributes["id"].Name;
                        PricingInputType ob = PricingInputType();
                        IDManager.SetID(pricingInputTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingInputTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingInputType = new PricingInputType(item);
                    }
                }
            }
            
        
            XmlNodeList pricingInputReferenceNodeList = xmlNode.SelectNodes("pricingInputReference");
            if (pricingInputReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingInputReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingInputReferenceIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(pricingInputReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingInputReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingInputReference = new PricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList scaleNodeList = xmlNode.SelectNodes("scale");
            if (scaleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in scaleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scaleIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(scaleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scaleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        scale = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList sensitivityDefinitionNodeList = xmlNode.SelectNodes("sensitivityDefinition");
            
            foreach (XmlNode item in sensitivityDefinitionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sensitivityDefinitionIDRef = item.Attributes["id"].Name;
                        List<SensitivityDefinition> ob = new List<SensitivityDefinition>();
                        ob.Add(new SensitivityDefinition(item));
                        IDManager.SetID(sensitivityDefinitionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sensitivityDefinitionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    sensitivityDefinition.Add(new SensitivityDefinition(item));
                    }
                }
            }
            
        
            XmlNodeList calculationProcedureNodeList = xmlNode.SelectNodes("calculationProcedure");
            if (calculationProcedureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationProcedureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationProcedureIDRef = item.Attributes["id"].Name;
                        DerivativeCalculationProcedure ob = DerivativeCalculationProcedure();
                        IDManager.SetID(calculationProcedureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationProcedureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationProcedure = new DerivativeCalculationProcedure(item);
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
        #region SensitivityCharacteristics
        private QuotationCharacteristics sensitivityCharacteristics;
        public QuotationCharacteristics SensitivityCharacteristics
        {
            get
            {
                if (this.sensitivityCharacteristics != null)
                {
                    return this.sensitivityCharacteristics; 
                }
                else if (this.sensitivityCharacteristicsIDRef != null)
                {
                    sensitivityCharacteristics = IDManager.getID(sensitivityCharacteristicsIDRef) as QuotationCharacteristics;
                    return this.sensitivityCharacteristics; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sensitivityCharacteristics != value)
                {
                    this.sensitivityCharacteristics = value;
                }
            }
        }
        #endregion
        
        public string QuotationCharacteristicsIDRef { get; set; }
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
        #region PricingInputType
        private PricingInputType pricingInputType;
        public PricingInputType PricingInputType
        {
            get
            {
                if (this.pricingInputType != null)
                {
                    return this.pricingInputType; 
                }
                else if (this.pricingInputTypeIDRef != null)
                {
                    pricingInputType = IDManager.getID(pricingInputTypeIDRef) as PricingInputType;
                    return this.pricingInputType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingInputType != value)
                {
                    this.pricingInputType = value;
                }
            }
        }
        #endregion
        
        public string PricingInputTypeIDRef { get; set; }
        #region PricingInputReference
        private PricingStructureReference pricingInputReference;
        public PricingStructureReference PricingInputReference
        {
            get
            {
                if (this.pricingInputReference != null)
                {
                    return this.pricingInputReference; 
                }
                else if (this.pricingInputReferenceIDRef != null)
                {
                    pricingInputReference = IDManager.getID(pricingInputReferenceIDRef) as PricingStructureReference;
                    return this.pricingInputReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingInputReference != value)
                {
                    this.pricingInputReference = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        #region Scale
        private XsdTypeDecimal scale;
        public XsdTypeDecimal Scale
        {
            get
            {
                if (this.scale != null)
                {
                    return this.scale; 
                }
                else if (this.scaleIDRef != null)
                {
                    scale = IDManager.getID(scaleIDRef) as XsdTypeDecimal;
                    return this.scale; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.scale != value)
                {
                    this.scale = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region SensitivityDefinition
        private List<SensitivityDefinition> sensitivityDefinition;
        public List<SensitivityDefinition> SensitivityDefinition
        {
            get
            {
                if (this.sensitivityDefinition != null)
                {
                    return this.sensitivityDefinition; 
                }
                else if (this.sensitivityDefinitionIDRef != null)
                {
                    sensitivityDefinition = IDManager.getID(sensitivityDefinitionIDRef) as List<SensitivityDefinition>;
                    return this.sensitivityDefinition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sensitivityDefinition != value)
                {
                    this.sensitivityDefinition = value;
                }
            }
        }
        #endregion
        
        public string SensitivityDefinitionIDRef { get; set; }
        #region CalculationProcedure
        private DerivativeCalculationProcedure calculationProcedure;
        public DerivativeCalculationProcedure CalculationProcedure
        {
            get
            {
                if (this.calculationProcedure != null)
                {
                    return this.calculationProcedure; 
                }
                else if (this.calculationProcedureIDRef != null)
                {
                    calculationProcedure = IDManager.getID(calculationProcedureIDRef) as DerivativeCalculationProcedure;
                    return this.calculationProcedure; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationProcedure != value)
                {
                    this.calculationProcedure = value;
                }
            }
        }
        #endregion
        
        public string DerivativeCalculationProcedureIDRef { get; set; }
        
    
        
    
    }
    
}

