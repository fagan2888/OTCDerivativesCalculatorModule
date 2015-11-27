using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingParameterDerivative
    {
        public PricingParameterDerivative(XmlNode xmlNode)
        {
            XmlNodeList descriptionNodeList = xmlNode.SelectNodes("description");
            if (descriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in descriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        descriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(descriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        descriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        description = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList parameterReferenceNodeList = xmlNode.SelectNodes("parameterReference");
            if (parameterReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parameterReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parameterReferenceIDRef = item.Attributes["id"].Name;
                        AssetOrTermPointOrPricingStructureReference ob = AssetOrTermPointOrPricingStructureReference();
                        IDManager.SetID(parameterReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parameterReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parameterReference = new AssetOrTermPointOrPricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList inputDateReferenceNodeList = xmlNode.SelectNodes("inputDateReference");
            
            foreach (XmlNode item in inputDateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inputDateReferenceIDRef = item.Attributes["id"].Name;
                        List<ValuationReference> ob = new List<ValuationReference>();
                        ob.Add(new ValuationReference(item));
                        IDManager.SetID(inputDateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inputDateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    inputDateReference.Add(new ValuationReference(item));
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
        
    
        #region Description
        private XsdTypeString description;
        public XsdTypeString Description
        {
            get
            {
                if (this.description != null)
                {
                    return this.description; 
                }
                else if (this.descriptionIDRef != null)
                {
                    description = IDManager.getID(descriptionIDRef) as XsdTypeString;
                    return this.description; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ParameterReference
        private AssetOrTermPointOrPricingStructureReference parameterReference;
        public AssetOrTermPointOrPricingStructureReference ParameterReference
        {
            get
            {
                if (this.parameterReference != null)
                {
                    return this.parameterReference; 
                }
                else if (this.parameterReferenceIDRef != null)
                {
                    parameterReference = IDManager.getID(parameterReferenceIDRef) as AssetOrTermPointOrPricingStructureReference;
                    return this.parameterReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parameterReference != value)
                {
                    this.parameterReference = value;
                }
            }
        }
        #endregion
        
        public string AssetOrTermPointOrPricingStructureReferenceIDRef { get; set; }
        #region InputDateReference
        private List<ValuationReference> inputDateReference;
        public List<ValuationReference> InputDateReference
        {
            get
            {
                if (this.inputDateReference != null)
                {
                    return this.inputDateReference; 
                }
                else if (this.inputDateReferenceIDRef != null)
                {
                    inputDateReference = IDManager.getID(inputDateReferenceIDRef) as List<ValuationReference>;
                    return this.inputDateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inputDateReference != value)
                {
                    this.inputDateReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationReferenceIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

