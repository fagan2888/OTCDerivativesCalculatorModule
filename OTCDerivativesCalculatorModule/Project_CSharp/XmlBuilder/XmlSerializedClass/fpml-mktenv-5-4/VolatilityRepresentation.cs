using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VolatilityRepresentation : PricingStructure
    {
        public VolatilityRepresentation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode assetNode = xmlNode.SelectSingleNode("asset");
            
            if (assetNode != null)
            {
                if (assetNode.Attributes["href"] != null || assetNode.Attributes["id"] != null) 
                {
                    if (assetNode.Attributes["id"] != null) 
                    {
                        assetIDRef_ = assetNode.Attributes["id"].Value;
                        AnyAssetReference ob = new AnyAssetReference(assetNode);
                        IDManager.SetID(assetIDRef_, ob);
                    }
                    else if (assetNode.Attributes["href"] != null)
                    {
                        assetIDRef_ = assetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        asset_ = new AnyAssetReference(assetNode);
                    }
                }
                else
                {
                    asset_ = new AnyAssetReference(assetNode);
                }
            }
            
        
        }
        
    
        #region Asset_
        private AnyAssetReference asset_;
        public AnyAssetReference Asset_
        {
            get
            {
                if (this.asset_ != null)
                {
                    return this.asset_; 
                }
                else if (this.assetIDRef_ != null)
                {
                    asset_ = IDManager.getID(assetIDRef_) as AnyAssetReference;
                    return this.asset_; 
                }
                else
                {
                      return this.asset_; 
                }
            }
            set
            {
                if (this.asset_ != value)
                {
                    this.asset_ = value;
                }
            }
        }
        #endregion
        
        public string assetIDRef_ { get; set; }
        
    
        
    
    }
    
}

