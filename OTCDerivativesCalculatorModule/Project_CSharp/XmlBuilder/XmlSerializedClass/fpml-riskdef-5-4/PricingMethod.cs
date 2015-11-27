using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingMethod : ISerialized
    {
        public PricingMethod(XmlNode xmlNode)
        {
            XmlNode assetReferenceNode = xmlNode.SelectSingleNode("assetReference");
            
            if (assetReferenceNode != null)
            {
                if (assetReferenceNode.Attributes["href"] != null || assetReferenceNode.Attributes["id"] != null) 
                {
                    if (assetReferenceNode.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["id"].Value;
                        AnyAssetReference ob = new AnyAssetReference(assetReferenceNode);
                        IDManager.SetID(assetReferenceIDRef_, ob);
                    }
                    else if (assetReferenceNode.Attributes["href"] != null)
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        assetReference_ = new AnyAssetReference(assetReferenceNode);
                    }
                }
                else
                {
                    assetReference_ = new AnyAssetReference(assetReferenceNode);
                }
            }
            
        
            XmlNode pricingInputReferenceNode = xmlNode.SelectSingleNode("pricingInputReference");
            
            if (pricingInputReferenceNode != null)
            {
                if (pricingInputReferenceNode.Attributes["href"] != null || pricingInputReferenceNode.Attributes["id"] != null) 
                {
                    if (pricingInputReferenceNode.Attributes["id"] != null) 
                    {
                        pricingInputReferenceIDRef_ = pricingInputReferenceNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(pricingInputReferenceNode);
                        IDManager.SetID(pricingInputReferenceIDRef_, ob);
                    }
                    else if (pricingInputReferenceNode.Attributes["href"] != null)
                    {
                        pricingInputReferenceIDRef_ = pricingInputReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingInputReference_ = new PricingStructureReference(pricingInputReferenceNode);
                    }
                }
                else
                {
                    pricingInputReference_ = new PricingStructureReference(pricingInputReferenceNode);
                }
            }
            
        
        }
        
    
        #region AssetReference_
        private AnyAssetReference assetReference_;
        public AnyAssetReference AssetReference_
        {
            get
            {
                if (this.assetReference_ != null)
                {
                    return this.assetReference_; 
                }
                else if (this.assetReferenceIDRef_ != null)
                {
                    assetReference_ = IDManager.getID(assetReferenceIDRef_) as AnyAssetReference;
                    return this.assetReference_; 
                }
                else
                {
                      return this.assetReference_; 
                }
            }
            set
            {
                if (this.assetReference_ != value)
                {
                    this.assetReference_ = value;
                }
            }
        }
        #endregion
        
        public string assetReferenceIDRef_ { get; set; }
        #region PricingInputReference_
        private PricingStructureReference pricingInputReference_;
        public PricingStructureReference PricingInputReference_
        {
            get
            {
                if (this.pricingInputReference_ != null)
                {
                    return this.pricingInputReference_; 
                }
                else if (this.pricingInputReferenceIDRef_ != null)
                {
                    pricingInputReference_ = IDManager.getID(pricingInputReferenceIDRef_) as PricingStructureReference;
                    return this.pricingInputReference_; 
                }
                else
                {
                      return this.pricingInputReference_; 
                }
            }
            set
            {
                if (this.pricingInputReference_ != value)
                {
                    this.pricingInputReference_ = value;
                }
            }
        }
        #endregion
        
        public string pricingInputReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

