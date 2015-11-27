using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PriceSourceDisruption
    {
        public PriceSourceDisruption(XmlNode xmlNode)
        {
            XmlNodeList fallbackReferencePriceNodeList = xmlNode.SelectNodes("fallbackReferencePrice");
            if (fallbackReferencePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackReferencePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackReferencePriceIDRef = item.Attributes["id"].Name;
                        FallbackReferencePrice ob = FallbackReferencePrice();
                        IDManager.SetID(fallbackReferencePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackReferencePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallbackReferencePrice = new FallbackReferencePrice(item);
                    }
                }
            }
            
        
        }
        
    
        #region FallbackReferencePrice
        private FallbackReferencePrice fallbackReferencePrice;
        public FallbackReferencePrice FallbackReferencePrice
        {
            get
            {
                if (this.fallbackReferencePrice != null)
                {
                    return this.fallbackReferencePrice; 
                }
                else if (this.fallbackReferencePriceIDRef != null)
                {
                    fallbackReferencePrice = IDManager.getID(fallbackReferencePriceIDRef) as FallbackReferencePrice;
                    return this.fallbackReferencePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackReferencePrice != value)
                {
                    this.fallbackReferencePrice = value;
                }
            }
        }
        #endregion
        
        public string FallbackReferencePriceIDRef { get; set; }
        
    
        
    
    }
    
}

