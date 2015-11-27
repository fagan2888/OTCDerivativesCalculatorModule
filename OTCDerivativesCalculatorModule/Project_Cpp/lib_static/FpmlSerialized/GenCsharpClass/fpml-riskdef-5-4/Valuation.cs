using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Valuation
    {
        public Valuation(XmlNode xmlNode)
        {
            XmlNodeList objectReferenceNodeList = xmlNode.SelectNodes("objectReference");
            if (objectReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in objectReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        objectReferenceIDRef = item.Attributes["id"].Name;
                        AnyAssetReference ob = AnyAssetReference();
                        IDManager.SetID(objectReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        objectReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        objectReference = new AnyAssetReference(item);
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
            
        
        }
        
    
        #region ObjectReference
        private AnyAssetReference objectReference;
        public AnyAssetReference ObjectReference
        {
            get
            {
                if (this.objectReference != null)
                {
                    return this.objectReference; 
                }
                else if (this.objectReferenceIDRef != null)
                {
                    objectReference = IDManager.getID(objectReferenceIDRef) as AnyAssetReference;
                    return this.objectReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.objectReference != value)
                {
                    this.objectReference = value;
                }
            }
        }
        #endregion
        
        public string AnyAssetReferenceIDRef { get; set; }
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
        
    
        
    
    }
    
}

