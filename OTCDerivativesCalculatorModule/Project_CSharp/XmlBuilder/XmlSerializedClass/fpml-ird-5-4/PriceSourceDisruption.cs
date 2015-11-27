using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PriceSourceDisruption : ISerialized
    {
        public PriceSourceDisruption(XmlNode xmlNode)
        {
            XmlNode fallbackReferencePriceNode = xmlNode.SelectSingleNode("fallbackReferencePrice");
            
            if (fallbackReferencePriceNode != null)
            {
                if (fallbackReferencePriceNode.Attributes["href"] != null || fallbackReferencePriceNode.Attributes["id"] != null) 
                {
                    if (fallbackReferencePriceNode.Attributes["id"] != null) 
                    {
                        fallbackReferencePriceIDRef_ = fallbackReferencePriceNode.Attributes["id"].Value;
                        FallbackReferencePrice ob = new FallbackReferencePrice(fallbackReferencePriceNode);
                        IDManager.SetID(fallbackReferencePriceIDRef_, ob);
                    }
                    else if (fallbackReferencePriceNode.Attributes["href"] != null)
                    {
                        fallbackReferencePriceIDRef_ = fallbackReferencePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallbackReferencePrice_ = new FallbackReferencePrice(fallbackReferencePriceNode);
                    }
                }
                else
                {
                    fallbackReferencePrice_ = new FallbackReferencePrice(fallbackReferencePriceNode);
                }
            }
            
        
        }
        
    
        #region FallbackReferencePrice_
        private FallbackReferencePrice fallbackReferencePrice_;
        public FallbackReferencePrice FallbackReferencePrice_
        {
            get
            {
                if (this.fallbackReferencePrice_ != null)
                {
                    return this.fallbackReferencePrice_; 
                }
                else if (this.fallbackReferencePriceIDRef_ != null)
                {
                    fallbackReferencePrice_ = IDManager.getID(fallbackReferencePriceIDRef_) as FallbackReferencePrice;
                    return this.fallbackReferencePrice_; 
                }
                else
                {
                      return this.fallbackReferencePrice_; 
                }
            }
            set
            {
                if (this.fallbackReferencePrice_ != value)
                {
                    this.fallbackReferencePrice_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackReferencePriceIDRef_ { get; set; }
        
    
        
    
    }
    
}

