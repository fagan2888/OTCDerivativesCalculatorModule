using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BaseIndexes : ISerialized
    {
        public BaseIndexes(XmlNode xmlNode)
        {
            XmlNodeList underlyingIndexNodeList = xmlNode.SelectNodes("underlyingIndex");
            
            if (underlyingIndexNodeList != null)
            {
                this.underlyingIndex_ = new List<UnderlyingIndex>();
                foreach (XmlNode item in underlyingIndexNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            underlyingIndexIDRef_ = item.Attributes["id"].Value;
                            underlyingIndex_.Add(new UnderlyingIndex(item));
                            IDManager.SetID(underlyingIndexIDRef_, underlyingIndex_[underlyingIndex_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            underlyingIndexIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        underlyingIndex_.Add(new UnderlyingIndex(item));
                        }
                    }
                    else
                    {
                        underlyingIndex_.Add(new UnderlyingIndex(item));
                    }
                }
            }
            
        
        }
        
    
        #region UnderlyingIndex_
        private List<UnderlyingIndex> underlyingIndex_;
        public List<UnderlyingIndex> UnderlyingIndex_
        {
            get
            {
                if (this.underlyingIndex_ != null)
                {
                    return this.underlyingIndex_; 
                }
                else if (this.underlyingIndexIDRef_ != null)
                {
                    return this.underlyingIndex_; 
                }
                else
                {
                      return this.underlyingIndex_; 
                }
            }
            set
            {
                if (this.underlyingIndex_ != value)
                {
                    this.underlyingIndex_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingIndexIDRef_ { get; set; }
        
    
        
    
    }
    
}

