using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionOperND : ISerialized
    {
        public AdditionOperND() { }
        public AdditionOperND(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList weightNodeList = xmlNode.SelectNodes("weight");
            
            if (weightNodeList != null)
            {
                this.weight_ = new List<XsdTypeToken>();
                foreach (XmlNode item in weightNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            weightIDRef_ = item.Attributes["id"].Value;
                            weight_.Add(new XsdTypeToken(item));
                            IDManager.SetID(weightIDRef_, weight_[weight_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            weightIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        weight_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        weight_.Add(new XsdTypeToken(item));
                    }
                }
            }
            
        
        }
        
    
        #region Weight_
        private List<XsdTypeToken> weight_;
        public List<XsdTypeToken> Weight_
        {
            get
            {
                if (this.weight_ != null)
                {
                    return this.weight_; 
                }
                else if (this.weightIDRef_ != null)
                {
                    return this.weight_; 
                }
                else
                {
                    throw new Exception( "weight_Node no exist!");
                }
            }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                }
            }
        }
        #endregion
        
        public string weightIDRef_ { get; set; }
        
    
        
    
    }
    
}

