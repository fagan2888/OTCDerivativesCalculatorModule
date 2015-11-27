using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeightedPartialDerivative
    {
        public WeightedPartialDerivative(XmlNode xmlNode)
        {
            XmlNodeList partialDerivativeReferenceNodeList = xmlNode.SelectNodes("partialDerivativeReference");
            if (partialDerivativeReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partialDerivativeReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partialDerivativeReferenceIDRef = item.Attributes["id"].Name;
                        PricingParameterDerivativeReference ob = PricingParameterDerivativeReference();
                        IDManager.SetID(partialDerivativeReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partialDerivativeReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partialDerivativeReference = new PricingParameterDerivativeReference(item);
                    }
                }
            }
            
        
            XmlNodeList weightNodeList = xmlNode.SelectNodes("weight");
            if (weightNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weightNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weightIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(weightIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weightIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weight = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartialDerivativeReference
        private PricingParameterDerivativeReference partialDerivativeReference;
        public PricingParameterDerivativeReference PartialDerivativeReference
        {
            get
            {
                if (this.partialDerivativeReference != null)
                {
                    return this.partialDerivativeReference; 
                }
                else if (this.partialDerivativeReferenceIDRef != null)
                {
                    partialDerivativeReference = IDManager.getID(partialDerivativeReferenceIDRef) as PricingParameterDerivativeReference;
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
        #region Weight
        private XsdTypeDecimal weight;
        public XsdTypeDecimal Weight
        {
            get
            {
                if (this.weight != null)
                {
                    return this.weight; 
                }
                else if (this.weightIDRef != null)
                {
                    weight = IDManager.getID(weightIDRef) as XsdTypeDecimal;
                    return this.weight; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weight != value)
                {
                    this.weight = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

