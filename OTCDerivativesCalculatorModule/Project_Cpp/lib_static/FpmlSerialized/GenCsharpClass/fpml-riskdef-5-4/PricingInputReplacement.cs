using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingInputReplacement
    {
        public PricingInputReplacement(XmlNode xmlNode)
        {
            XmlNodeList originalInputReferenceNodeList = xmlNode.SelectNodes("originalInputReference");
            if (originalInputReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originalInputReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originalInputReferenceIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(originalInputReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originalInputReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originalInputReference = new PricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList replacementInputReferenceNodeList = xmlNode.SelectNodes("replacementInputReference");
            if (replacementInputReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in replacementInputReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        replacementInputReferenceIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(replacementInputReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        replacementInputReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        replacementInputReference = new PricingStructureReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region OriginalInputReference
        private PricingStructureReference originalInputReference;
        public PricingStructureReference OriginalInputReference
        {
            get
            {
                if (this.originalInputReference != null)
                {
                    return this.originalInputReference; 
                }
                else if (this.originalInputReferenceIDRef != null)
                {
                    originalInputReference = IDManager.getID(originalInputReferenceIDRef) as PricingStructureReference;
                    return this.originalInputReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originalInputReference != value)
                {
                    this.originalInputReference = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        #region ReplacementInputReference
        private PricingStructureReference replacementInputReference;
        public PricingStructureReference ReplacementInputReference
        {
            get
            {
                if (this.replacementInputReference != null)
                {
                    return this.replacementInputReference; 
                }
                else if (this.replacementInputReferenceIDRef != null)
                {
                    replacementInputReference = IDManager.getID(replacementInputReferenceIDRef) as PricingStructureReference;
                    return this.replacementInputReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.replacementInputReference != value)
                {
                    this.replacementInputReference = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

