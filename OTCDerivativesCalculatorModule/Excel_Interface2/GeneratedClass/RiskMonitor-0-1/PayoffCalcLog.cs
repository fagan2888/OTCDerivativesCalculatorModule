using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffCalcLog : ISerialized
    {
        public PayoffCalcLog() { }
        public PayoffCalcLog(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList pathDateNodeList = xmlNode.SelectNodes("pathDate");
            
            if (pathDateNodeList != null)
            {
                this.pathDate_ = new List<XsdTypeToken>();
                foreach (XmlNode item in pathDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            pathDateIDRef_ = item.Attributes["id"].Value;
                            pathDate_.Add(new XsdTypeToken(item));
                            IDManager.SetID(pathDateIDRef_, pathDate_[pathDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            pathDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        pathDate_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        pathDate_.Add(new XsdTypeToken(item));
                    }
                }
            }
            
        
        }
        
    
        #region PathDate_
        private List<XsdTypeToken> pathDate_;
        public List<XsdTypeToken> PathDate_
        {
            get
            {
                if (this.pathDate_ != null)
                {
                    return this.pathDate_; 
                }
                else if (this.pathDateIDRef_ != null)
                {
                    return this.pathDate_; 
                }
                else
                {
                    throw new Exception( "pathDate_Node no exist!");
                }
            }
            set
            {
                if (this.pathDate_ != value)
                {
                    this.pathDate_ = value;
                }
            }
        }
        #endregion
        
        public string pathDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

