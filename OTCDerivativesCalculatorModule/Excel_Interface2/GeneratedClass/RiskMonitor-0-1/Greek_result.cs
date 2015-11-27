using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Greek_result : ISerialized
    {
        public Greek_result() { }
        public Greek_result(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList greek_underlyingNodeList = xmlNode.SelectNodes("greek_underlying");
            
            if (greek_underlyingNodeList != null)
            {
                this.greek_underlying_ = new List<Greek_underlying>();
                foreach (XmlNode item in greek_underlyingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            greek_underlyingIDRef_ = item.Attributes["id"].Value;
                            greek_underlying_.Add(new Greek_underlying(item));
                            IDManager.SetID(greek_underlyingIDRef_, greek_underlying_[greek_underlying_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            greek_underlyingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        greek_underlying_.Add(new Greek_underlying(item));
                        }
                    }
                    else
                    {
                        greek_underlying_.Add(new Greek_underlying(item));
                    }
                }
            }
            
        
        }
        
    
        #region Greek_underlying_
        private List<Greek_underlying> greek_underlying_;
        public List<Greek_underlying> Greek_underlying_
        {
            get
            {
                if (this.greek_underlying_ != null)
                {
                    return this.greek_underlying_; 
                }
                else if (this.greek_underlyingIDRef_ != null)
                {
                    return this.greek_underlying_; 
                }
                else
                {
                    throw new Exception( "greek_underlying_Node no exist!");
                }
            }
            set
            {
                if (this.greek_underlying_ != value)
                {
                    this.greek_underlying_ = value;
                }
            }
        }
        #endregion
        
        public string greek_underlyingIDRef_ { get; set; }
        
    
        
    
    }
    
}

