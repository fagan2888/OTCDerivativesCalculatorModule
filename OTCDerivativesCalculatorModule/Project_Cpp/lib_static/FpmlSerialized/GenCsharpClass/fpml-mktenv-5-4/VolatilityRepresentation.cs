using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VolatilityRepresentation
    {
        public VolatilityRepresentation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList assetNodeList = xmlNode.SelectNodes("asset");
            if (assetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetIDRef = item.Attributes["id"].Name;
                        AnyAssetReference ob = AnyAssetReference();
                        IDManager.SetID(assetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        asset = new AnyAssetReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Asset
        private AnyAssetReference asset;
        public AnyAssetReference Asset
        {
            get
            {
                if (this.asset != null)
                {
                    return this.asset; 
                }
                else if (this.assetIDRef != null)
                {
                    asset = IDManager.getID(assetIDRef) as AnyAssetReference;
                    return this.asset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.asset != value)
                {
                    this.asset = value;
                }
            }
        }
        #endregion
        
        public string AnyAssetReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

