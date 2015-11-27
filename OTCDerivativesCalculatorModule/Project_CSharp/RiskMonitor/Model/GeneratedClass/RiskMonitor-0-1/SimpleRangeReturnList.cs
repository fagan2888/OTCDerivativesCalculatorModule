using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeReturnList : ISerialized
    {
        public SimpleRangeReturnList() { }
        public SimpleRangeReturnList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList simpleRangeReturnNodeList = xmlNode.SelectNodes("simpleRangeReturn");
            
            if (simpleRangeReturnNodeList != null)
            {
                this.simpleRangeReturn_ = new List<SimpleRangeReturn>();
                foreach (XmlNode item in simpleRangeReturnNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            simpleRangeReturnIDRef_ = item.Attributes["id"].Value;
                            simpleRangeReturn_.Add(new SimpleRangeReturn(item));
                            IDManager.SetID(simpleRangeReturnIDRef_, simpleRangeReturn_[simpleRangeReturn_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            simpleRangeReturnIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        simpleRangeReturn_.Add(new SimpleRangeReturn(item));
                        }
                    }
                    else
                    {
                        simpleRangeReturn_.Add(new SimpleRangeReturn(item));
                    }
                }
            }
            
        
        }
        
    
        #region SimpleRangeReturn_
        private List<SimpleRangeReturn> simpleRangeReturn_;
        public List<SimpleRangeReturn> SimpleRangeReturn_
        {
            get
            {
                if (this.simpleRangeReturn_ != null)
                {
                    return this.simpleRangeReturn_; 
                }
                else if (this.simpleRangeReturnIDRef_ != null)
                {
                    return this.simpleRangeReturn_; 
                }
                else
                {
                    throw new Exception( "simpleRangeReturn_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeReturn_ != value)
                {
                    this.simpleRangeReturn_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeReturnIDRef_ { get; set; }
        
    
        
    
    }
    
}

