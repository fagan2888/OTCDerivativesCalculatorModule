using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TriggerAtleast : ISerialized
    {
        public TriggerAtleast(XmlNode xmlNode)
        {
            XmlNode countNode = xmlNode.SelectSingleNode("count");
            
            if (countNode != null)
            {
                if (countNode.Attributes["href"] != null || countNode.Attributes["id"] != null) 
                {
                    if (countNode.Attributes["id"] != null) 
                    {
                        countIDRef_ = countNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(countNode);
                        IDManager.SetID(countIDRef_, ob);
                    }
                    else if (countNode.Attributes["href"] != null)
                    {
                        countIDRef_ = countNode.Attributes["href"].Value;
                    }
                    else
                    {
                        count_ = new XsdTypeDouble(countNode);
                    }
                }
                else
                {
                    count_ = new XsdTypeDouble(countNode);
                }
            }
            
        
        }
        
    
        #region Count_
        private XsdTypeDouble count_;
        public XsdTypeDouble Count_
        {
            get
            {
                if (this.count_ != null)
                {
                    return this.count_; 
                }
                else if (this.countIDRef_ != null)
                {
                    count_ = IDManager.getID(countIDRef_) as XsdTypeDouble;
                    return this.count_; 
                }
                else
                {
                      return this.count_; 
                }
            }
            set
            {
                if (this.count_ != value)
                {
                    this.count_ = value;
                }
            }
        }
        #endregion
        
        public string countIDRef_ { get; set; }
        
    
        
    
    }
    
}

