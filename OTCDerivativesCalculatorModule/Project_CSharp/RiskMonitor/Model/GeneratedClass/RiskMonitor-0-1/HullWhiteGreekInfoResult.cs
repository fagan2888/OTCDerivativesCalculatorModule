using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class HullWhiteGreekInfoResult : ISerialized
    {
        public HullWhiteGreekInfoResult() { }
        public HullWhiteGreekInfoResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList hullWhiteGreekResultNodeList = xmlNode.SelectNodes("hullWhiteGreekResult");
            
            if (hullWhiteGreekResultNodeList != null)
            {
                this.hullWhiteGreekResult_ = new List<HullWhiteGreekResult>();
                foreach (XmlNode item in hullWhiteGreekResultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            hullWhiteGreekResultIDRef_ = item.Attributes["id"].Value;
                            hullWhiteGreekResult_.Add(new HullWhiteGreekResult(item));
                            IDManager.SetID(hullWhiteGreekResultIDRef_, hullWhiteGreekResult_[hullWhiteGreekResult_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            hullWhiteGreekResultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        hullWhiteGreekResult_.Add(new HullWhiteGreekResult(item));
                        }
                    }
                    else
                    {
                        hullWhiteGreekResult_.Add(new HullWhiteGreekResult(item));
                    }
                }
            }
            
        
        }
        
    
        #region HullWhiteGreekResult_
        private List<HullWhiteGreekResult> hullWhiteGreekResult_;
        public List<HullWhiteGreekResult> HullWhiteGreekResult_
        {
            get
            {
                if (this.hullWhiteGreekResult_ != null)
                {
                    return this.hullWhiteGreekResult_; 
                }
                else if (this.hullWhiteGreekResultIDRef_ != null)
                {
                    return this.hullWhiteGreekResult_; 
                }
                else
                {
                    throw new Exception( "hullWhiteGreekResult_Node no exist!");
                }
            }
            set
            {
                if (this.hullWhiteGreekResult_ != value)
                {
                    this.hullWhiteGreekResult_ = value;
                }
            }
        }
        #endregion
        
        public string hullWhiteGreekResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

