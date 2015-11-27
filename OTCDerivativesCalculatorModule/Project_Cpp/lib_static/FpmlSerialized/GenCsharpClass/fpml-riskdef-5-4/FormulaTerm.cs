using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FormulaTerm
    {
        public FormulaTerm(XmlNode xmlNode)
        {
            XmlNodeList coefficientNodeList = xmlNode.SelectNodes("coefficient");
            if (coefficientNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coefficientNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coefficientIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(coefficientIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coefficientIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coefficient = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList partialDerivativeReferenceNodeList = xmlNode.SelectNodes("partialDerivativeReference");
            
            foreach (XmlNode item in partialDerivativeReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partialDerivativeReferenceIDRef = item.Attributes["id"].Name;
                        List<PricingParameterDerivativeReference> ob = new List<PricingParameterDerivativeReference>();
                        ob.Add(new PricingParameterDerivativeReference(item));
                        IDManager.SetID(partialDerivativeReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partialDerivativeReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partialDerivativeReference.Add(new PricingParameterDerivativeReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region Coefficient
        private XsdTypeDecimal coefficient;
        public XsdTypeDecimal Coefficient
        {
            get
            {
                if (this.coefficient != null)
                {
                    return this.coefficient; 
                }
                else if (this.coefficientIDRef != null)
                {
                    coefficient = IDManager.getID(coefficientIDRef) as XsdTypeDecimal;
                    return this.coefficient; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coefficient != value)
                {
                    this.coefficient = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PartialDerivativeReference
        private List<PricingParameterDerivativeReference> partialDerivativeReference;
        public List<PricingParameterDerivativeReference> PartialDerivativeReference
        {
            get
            {
                if (this.partialDerivativeReference != null)
                {
                    return this.partialDerivativeReference; 
                }
                else if (this.partialDerivativeReferenceIDRef != null)
                {
                    partialDerivativeReference = IDManager.getID(partialDerivativeReferenceIDRef) as List<PricingParameterDerivativeReference>;
                    return this.partialDerivativeReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partialDerivativeReference != value)
                {
                    this.partialDerivativeReference = value;
                }
            }
        }
        #endregion
        
        public string PricingParameterDerivativeReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

