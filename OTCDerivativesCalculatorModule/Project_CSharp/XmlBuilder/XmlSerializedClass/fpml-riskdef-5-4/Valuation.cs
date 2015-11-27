using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Valuation : ISerialized
    {
        public Valuation(XmlNode xmlNode)
        {
            XmlNode objectReferenceNode = xmlNode.SelectSingleNode("objectReference");
            
            if (objectReferenceNode != null)
            {
                if (objectReferenceNode.Attributes["href"] != null || objectReferenceNode.Attributes["id"] != null) 
                {
                    if (objectReferenceNode.Attributes["id"] != null) 
                    {
                        objectReferenceIDRef_ = objectReferenceNode.Attributes["id"].Value;
                        AnyAssetReference ob = new AnyAssetReference(objectReferenceNode);
                        IDManager.SetID(objectReferenceIDRef_, ob);
                    }
                    else if (objectReferenceNode.Attributes["href"] != null)
                    {
                        objectReferenceIDRef_ = objectReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        objectReference_ = new AnyAssetReference(objectReferenceNode);
                    }
                }
                else
                {
                    objectReference_ = new AnyAssetReference(objectReferenceNode);
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
            
        
        }
        
    
        #region ObjectReference_
        private AnyAssetReference objectReference_;
        public AnyAssetReference ObjectReference_
        {
            get
            {
                if (this.objectReference_ != null)
                {
                    return this.objectReference_; 
                }
                else if (this.objectReferenceIDRef_ != null)
                {
                    objectReference_ = IDManager.getID(objectReferenceIDRef_) as AnyAssetReference;
                    return this.objectReference_; 
                }
                else
                {
                      return this.objectReference_; 
                }
            }
            set
            {
                if (this.objectReference_ != value)
                {
                    this.objectReference_ = value;
                }
            }
        }
        #endregion
        
        public string objectReferenceIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

