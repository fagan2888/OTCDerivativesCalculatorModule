using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PassThrough : ISerialized
    {
        public PassThrough(XmlNode xmlNode)
        {
            XmlNodeList passThroughItemNodeList = xmlNode.SelectNodes("passThroughItem");
            
            if (passThroughItemNodeList != null)
            {
                this.passThroughItem_ = new List<PassThroughItem>();
                foreach (XmlNode item in passThroughItemNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            passThroughItemIDRef_ = item.Attributes["id"].Value;
                            passThroughItem_.Add(new PassThroughItem(item));
                            IDManager.SetID(passThroughItemIDRef_, passThroughItem_[passThroughItem_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            passThroughItemIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        passThroughItem_.Add(new PassThroughItem(item));
                        }
                    }
                    else
                    {
                        passThroughItem_.Add(new PassThroughItem(item));
                    }
                }
            }
            
        
        }
        
    
        #region PassThroughItem_
        private List<PassThroughItem> passThroughItem_;
        public List<PassThroughItem> PassThroughItem_
        {
            get
            {
                if (this.passThroughItem_ != null)
                {
                    return this.passThroughItem_; 
                }
                else if (this.passThroughItemIDRef_ != null)
                {
                    return this.passThroughItem_; 
                }
                else
                {
                      return this.passThroughItem_; 
                }
            }
            set
            {
                if (this.passThroughItem_ != value)
                {
                    this.passThroughItem_ = value;
                }
            }
        }
        #endregion
        
        public string passThroughItemIDRef_ { get; set; }
        
    
        
    
    }
    
}

