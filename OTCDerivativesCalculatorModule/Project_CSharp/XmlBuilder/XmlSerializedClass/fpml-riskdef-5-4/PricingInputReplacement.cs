using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingInputReplacement : ISerialized
    {
        public PricingInputReplacement(XmlNode xmlNode)
        {
            XmlNode originalInputReferenceNode = xmlNode.SelectSingleNode("originalInputReference");
            
            if (originalInputReferenceNode != null)
            {
                if (originalInputReferenceNode.Attributes["href"] != null || originalInputReferenceNode.Attributes["id"] != null) 
                {
                    if (originalInputReferenceNode.Attributes["id"] != null) 
                    {
                        originalInputReferenceIDRef_ = originalInputReferenceNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(originalInputReferenceNode);
                        IDManager.SetID(originalInputReferenceIDRef_, ob);
                    }
                    else if (originalInputReferenceNode.Attributes["href"] != null)
                    {
                        originalInputReferenceIDRef_ = originalInputReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originalInputReference_ = new PricingStructureReference(originalInputReferenceNode);
                    }
                }
                else
                {
                    originalInputReference_ = new PricingStructureReference(originalInputReferenceNode);
                }
            }
            
        
            XmlNode replacementInputReferenceNode = xmlNode.SelectSingleNode("replacementInputReference");
            
            if (replacementInputReferenceNode != null)
            {
                if (replacementInputReferenceNode.Attributes["href"] != null || replacementInputReferenceNode.Attributes["id"] != null) 
                {
                    if (replacementInputReferenceNode.Attributes["id"] != null) 
                    {
                        replacementInputReferenceIDRef_ = replacementInputReferenceNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(replacementInputReferenceNode);
                        IDManager.SetID(replacementInputReferenceIDRef_, ob);
                    }
                    else if (replacementInputReferenceNode.Attributes["href"] != null)
                    {
                        replacementInputReferenceIDRef_ = replacementInputReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        replacementInputReference_ = new PricingStructureReference(replacementInputReferenceNode);
                    }
                }
                else
                {
                    replacementInputReference_ = new PricingStructureReference(replacementInputReferenceNode);
                }
            }
            
        
        }
        
    
        #region OriginalInputReference_
        private PricingStructureReference originalInputReference_;
        public PricingStructureReference OriginalInputReference_
        {
            get
            {
                if (this.originalInputReference_ != null)
                {
                    return this.originalInputReference_; 
                }
                else if (this.originalInputReferenceIDRef_ != null)
                {
                    originalInputReference_ = IDManager.getID(originalInputReferenceIDRef_) as PricingStructureReference;
                    return this.originalInputReference_; 
                }
                else
                {
                      return this.originalInputReference_; 
                }
            }
            set
            {
                if (this.originalInputReference_ != value)
                {
                    this.originalInputReference_ = value;
                }
            }
        }
        #endregion
        
        public string originalInputReferenceIDRef_ { get; set; }
        #region ReplacementInputReference_
        private PricingStructureReference replacementInputReference_;
        public PricingStructureReference ReplacementInputReference_
        {
            get
            {
                if (this.replacementInputReference_ != null)
                {
                    return this.replacementInputReference_; 
                }
                else if (this.replacementInputReferenceIDRef_ != null)
                {
                    replacementInputReference_ = IDManager.getID(replacementInputReferenceIDRef_) as PricingStructureReference;
                    return this.replacementInputReference_; 
                }
                else
                {
                      return this.replacementInputReference_; 
                }
            }
            set
            {
                if (this.replacementInputReference_ != value)
                {
                    this.replacementInputReference_ = value;
                }
            }
        }
        #endregion
        
        public string replacementInputReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

