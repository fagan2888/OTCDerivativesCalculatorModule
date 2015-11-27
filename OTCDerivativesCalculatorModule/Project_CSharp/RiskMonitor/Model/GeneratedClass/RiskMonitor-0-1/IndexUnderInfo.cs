using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexUnderInfo : ISerialized
    {
        public IndexUnderInfo() { }
        public IndexUnderInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList indexNodeList = xmlNode.SelectNodes("index");
            
            if (indexNodeList != null)
            {
                this.index_ = new List<Index>();
                foreach (XmlNode item in indexNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            indexIDRef_ = item.Attributes["id"].Value;
                            index_.Add(new Index(item));
                            IDManager.SetID(indexIDRef_, index_[index_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            indexIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        index_.Add(new Index(item));
                        }
                    }
                    else
                    {
                        index_.Add(new Index(item));
                    }
                }
            }
            
        
        }
        
    
        #region Index_
        private List<Index> index_;
        public List<Index> Index_
        {
            get
            {
                if (this.index_ != null)
                {
                    return this.index_; 
                }
                else if (this.indexIDRef_ != null)
                {
                    return this.index_; 
                }
                else
                {
                    throw new Exception( "index_Node no exist!");
                }
            }
            set
            {
                if (this.index_ != value)
                {
                    this.index_ = value;
                }
            }
        }
        #endregion
        
        public string indexIDRef_ { get; set; }
        
    
        
    
    }
    
}

