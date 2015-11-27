using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StreetAddress : ISerialized
    {
        public StreetAddress(XmlNode xmlNode)
        {
            XmlNodeList streetLineNodeList = xmlNode.SelectNodes("streetLine");
            
            if (streetLineNodeList != null)
            {
                this.streetLine_ = new List<XsdTypeString>();
                foreach (XmlNode item in streetLineNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            streetLineIDRef_ = item.Attributes["id"].Value;
                            streetLine_.Add(new XsdTypeString(item));
                            IDManager.SetID(streetLineIDRef_, streetLine_[streetLine_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            streetLineIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        streetLine_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        streetLine_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
        }
        
    
        #region StreetLine_
        private List<XsdTypeString> streetLine_;
        public List<XsdTypeString> StreetLine_
        {
            get
            {
                if (this.streetLine_ != null)
                {
                    return this.streetLine_; 
                }
                else if (this.streetLineIDRef_ != null)
                {
                    return this.streetLine_; 
                }
                else
                {
                      return this.streetLine_; 
                }
            }
            set
            {
                if (this.streetLine_ != value)
                {
                    this.streetLine_ = value;
                }
            }
        }
        #endregion
        
        public string streetLineIDRef_ { get; set; }
        
    
        
    
    }
    
}

