using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferencePool : ISerialized
    {
        public ReferencePool(XmlNode xmlNode)
        {
            XmlNodeList referencePoolItemNodeList = xmlNode.SelectNodes("referencePoolItem");
            
            if (referencePoolItemNodeList != null)
            {
                this.referencePoolItem_ = new List<ReferencePoolItem>();
                foreach (XmlNode item in referencePoolItemNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referencePoolItemIDRef_ = item.Attributes["id"].Value;
                            referencePoolItem_.Add(new ReferencePoolItem(item));
                            IDManager.SetID(referencePoolItemIDRef_, referencePoolItem_[referencePoolItem_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referencePoolItemIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referencePoolItem_.Add(new ReferencePoolItem(item));
                        }
                    }
                    else
                    {
                        referencePoolItem_.Add(new ReferencePoolItem(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferencePoolItem_
        private List<ReferencePoolItem> referencePoolItem_;
        public List<ReferencePoolItem> ReferencePoolItem_
        {
            get
            {
                if (this.referencePoolItem_ != null)
                {
                    return this.referencePoolItem_; 
                }
                else if (this.referencePoolItemIDRef_ != null)
                {
                    return this.referencePoolItem_; 
                }
                else
                {
                      return this.referencePoolItem_; 
                }
            }
            set
            {
                if (this.referencePoolItem_ != value)
                {
                    this.referencePoolItem_ = value;
                }
            }
        }
        #endregion
        
        public string referencePoolItemIDRef_ { get; set; }
        
    
        
    
    }
    
}

