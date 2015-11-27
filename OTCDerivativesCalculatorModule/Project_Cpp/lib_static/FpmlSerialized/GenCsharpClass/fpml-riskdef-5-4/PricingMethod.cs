using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingMethod
    {
        public PricingMethod(XmlNode xmlNode)
        {
            XmlNodeList assetReferenceNodeList = xmlNode.SelectNodes("assetReference");
            if (assetReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assetReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef = item.Attributes["id"].Name;
                        AnyAssetReference ob = AnyAssetReference();
                        IDManager.SetID(assetReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        assetReference = new AnyAssetReference(item);
                    }
                }
            }
            
        
            XmlNodeList pricingInputReferenceNodeList = xmlNode.SelectNodes("pricingInputReference");
            if (pricingInputReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingInputReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingInputReferenceIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(pricingInputReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingInputReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingInputReference = new PricingStructureReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region AssetReference
        private AnyAssetReference assetReference;
        public AnyAssetReference AssetReference
        {
            get
            {
                if (this.assetReference != null)
                {
                    return this.assetReference; 
                }
                else if (this.assetReferenceIDRef != null)
                {
                    assetReference = IDManager.getID(assetReferenceIDRef) as AnyAssetReference;
                    return this.assetReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assetReference != value)
                {
                    this.assetReference = value;
                }
            }
        }
        #endregion
        
        public string AnyAssetReferenceIDRef { get; set; }
        #region PricingInputReference
        private PricingStructureReference pricingInputReference;
        public PricingStructureReference PricingInputReference
        {
            get
            {
                if (this.pricingInputReference != null)
                {
                    return this.pricingInputReference; 
                }
                else if (this.pricingInputReferenceIDRef != null)
                {
                    pricingInputReference = IDManager.getID(pricingInputReferenceIDRef) as PricingStructureReference;
                    return this.pricingInputReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingInputReference != value)
                {
                    this.pricingInputReference = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

