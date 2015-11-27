using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Valuations
    {
        public Valuations(XmlNode xmlNode)
        {
            XmlNodeList valuationNodeList = xmlNode.SelectNodes("valuation");
            if (valuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationIDRef = item.Attributes["id"].Name;
                        AssetValuation ob = AssetValuation();
                        IDManager.SetID(valuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuation = new AssetValuation(item);
                    }
                }
            }
            
        
            XmlNodeList valuationReferenceNodeList = xmlNode.SelectNodes("valuationReference");
            if (valuationReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationReferenceIDRef = item.Attributes["id"].Name;
                        ValuationReference ob = ValuationReference();
                        IDManager.SetID(valuationReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationReference = new ValuationReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Valuation
        private AssetValuation valuation;
        public AssetValuation Valuation
        {
            get
            {
                if (this.valuation != null)
                {
                    return this.valuation; 
                }
                else if (this.valuationIDRef != null)
                {
                    valuation = IDManager.getID(valuationIDRef) as AssetValuation;
                    return this.valuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuation != value)
                {
                    this.valuation = value;
                }
            }
        }
        #endregion
        
        public string AssetValuationIDRef { get; set; }
        #region ValuationReference
        private ValuationReference valuationReference;
        public ValuationReference ValuationReference
        {
            get
            {
                if (this.valuationReference != null)
                {
                    return this.valuationReference; 
                }
                else if (this.valuationReferenceIDRef != null)
                {
                    valuationReference = IDManager.getID(valuationReferenceIDRef) as ValuationReference;
                    return this.valuationReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationReference != value)
                {
                    this.valuationReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

