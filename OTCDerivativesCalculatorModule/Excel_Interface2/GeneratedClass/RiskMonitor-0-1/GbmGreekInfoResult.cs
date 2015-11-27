using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GbmGreekInfoResult : ISerialized
    {
        public GbmGreekInfoResult() { }
        public GbmGreekInfoResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList gbmGreekResultNodeList = xmlNode.SelectNodes("gbmGreekResult");
            
            if (gbmGreekResultNodeList != null)
            {
                this.gbmGreekResult_ = new List<GbmGreekResult>();
                foreach (XmlNode item in gbmGreekResultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            gbmGreekResultIDRef_ = item.Attributes["id"].Value;
                            gbmGreekResult_.Add(new GbmGreekResult(item));
                            IDManager.SetID(gbmGreekResultIDRef_, gbmGreekResult_[gbmGreekResult_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            gbmGreekResultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        gbmGreekResult_.Add(new GbmGreekResult(item));
                        }
                    }
                    else
                    {
                        gbmGreekResult_.Add(new GbmGreekResult(item));
                    }
                }
            }
            
        
        }
        
    
        #region GbmGreekResult_
        private List<GbmGreekResult> gbmGreekResult_;
        public List<GbmGreekResult> GbmGreekResult_
        {
            get
            {
                if (this.gbmGreekResult_ != null)
                {
                    return this.gbmGreekResult_; 
                }
                else if (this.gbmGreekResultIDRef_ != null)
                {
                    return this.gbmGreekResult_; 
                }
                else
                {
                    throw new Exception( "gbmGreekResult_Node no exist!");
                }
            }
            set
            {
                if (this.gbmGreekResult_ != value)
                {
                    this.gbmGreekResult_ = value;
                }
            }
        }
        #endregion
        
        public string gbmGreekResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

