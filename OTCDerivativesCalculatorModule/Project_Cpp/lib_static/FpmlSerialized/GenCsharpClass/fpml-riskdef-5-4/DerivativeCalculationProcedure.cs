using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DerivativeCalculationProcedure
    {
        public DerivativeCalculationProcedure(XmlNode xmlNode)
        {
            XmlNodeList methodNodeList = xmlNode.SelectNodes("method");
            if (methodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in methodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        methodIDRef = item.Attributes["id"].Name;
                        DerivativeCalculationMethod ob = DerivativeCalculationMethod();
                        IDManager.SetID(methodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        methodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        method = new DerivativeCalculationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList perturbationAmountNodeList = xmlNode.SelectNodes("perturbationAmount");
            if (perturbationAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in perturbationAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        perturbationAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(perturbationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        perturbationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        perturbationAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList averagedNodeList = xmlNode.SelectNodes("averaged");
            if (averagedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(averagedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averaged = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList perturbationTypeNodeList = xmlNode.SelectNodes("perturbationType");
            if (perturbationTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in perturbationTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        perturbationTypeIDRef = item.Attributes["id"].Name;
                        PerturbationType ob = PerturbationType();
                        IDManager.SetID(perturbationTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        perturbationTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        perturbationType = new PerturbationType(item);
                    }
                }
            }
            
        
            XmlNodeList derivativeFormulaNodeList = xmlNode.SelectNodes("derivativeFormula");
            if (derivativeFormulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in derivativeFormulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        derivativeFormulaIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(derivativeFormulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        derivativeFormulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        derivativeFormula = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList replacementMarketInputNodeList = xmlNode.SelectNodes("replacementMarketInput");
            if (replacementMarketInputNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in replacementMarketInputNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        replacementMarketInputIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(replacementMarketInputIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        replacementMarketInputIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        replacementMarketInput = new PricingStructureReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Method
        private DerivativeCalculationMethod method;
        public DerivativeCalculationMethod Method
        {
            get
            {
                if (this.method != null)
                {
                    return this.method; 
                }
                else if (this.methodIDRef != null)
                {
                    method = IDManager.getID(methodIDRef) as DerivativeCalculationMethod;
                    return this.method; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.method != value)
                {
                    this.method = value;
                }
            }
        }
        #endregion
        
        public string DerivativeCalculationMethodIDRef { get; set; }
        #region PerturbationAmount
        private XsdTypeDecimal perturbationAmount;
        public XsdTypeDecimal PerturbationAmount
        {
            get
            {
                if (this.perturbationAmount != null)
                {
                    return this.perturbationAmount; 
                }
                else if (this.perturbationAmountIDRef != null)
                {
                    perturbationAmount = IDManager.getID(perturbationAmountIDRef) as XsdTypeDecimal;
                    return this.perturbationAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.perturbationAmount != value)
                {
                    this.perturbationAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Averaged
        private XsdTypeBoolean averaged;
        public XsdTypeBoolean Averaged
        {
            get
            {
                if (this.averaged != null)
                {
                    return this.averaged; 
                }
                else if (this.averagedIDRef != null)
                {
                    averaged = IDManager.getID(averagedIDRef) as XsdTypeBoolean;
                    return this.averaged; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averaged != value)
                {
                    this.averaged = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PerturbationType
        private PerturbationType perturbationType;
        public PerturbationType PerturbationType
        {
            get
            {
                if (this.perturbationType != null)
                {
                    return this.perturbationType; 
                }
                else if (this.perturbationTypeIDRef != null)
                {
                    perturbationType = IDManager.getID(perturbationTypeIDRef) as PerturbationType;
                    return this.perturbationType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.perturbationType != value)
                {
                    this.perturbationType = value;
                }
            }
        }
        #endregion
        
        public string PerturbationTypeIDRef { get; set; }
        #region DerivativeFormula
        private XsdTypeString derivativeFormula;
        public XsdTypeString DerivativeFormula
        {
            get
            {
                if (this.derivativeFormula != null)
                {
                    return this.derivativeFormula; 
                }
                else if (this.derivativeFormulaIDRef != null)
                {
                    derivativeFormula = IDManager.getID(derivativeFormulaIDRef) as XsdTypeString;
                    return this.derivativeFormula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.derivativeFormula != value)
                {
                    this.derivativeFormula = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ReplacementMarketInput
        private PricingStructureReference replacementMarketInput;
        public PricingStructureReference ReplacementMarketInput
        {
            get
            {
                if (this.replacementMarketInput != null)
                {
                    return this.replacementMarketInput; 
                }
                else if (this.replacementMarketInputIDRef != null)
                {
                    replacementMarketInput = IDManager.getID(replacementMarketInputIDRef) as PricingStructureReference;
                    return this.replacementMarketInput; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.replacementMarketInput != value)
                {
                    this.replacementMarketInput = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

