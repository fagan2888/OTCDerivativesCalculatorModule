using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeEventList : ISerialized
    {
        public SimpleRangeEventList() { }
        public SimpleRangeEventList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList simpleRangeEventCalNodeList = xmlNode.SelectNodes("simpleRangeEventCal");
            
            if (simpleRangeEventCalNodeList != null)
            {
                this.simpleRangeEventCal_ = new List<SimpleRangeEventCal>();
                foreach (XmlNode item in simpleRangeEventCalNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            simpleRangeEventCalIDRef_ = item.Attributes["id"].Value;
                            simpleRangeEventCal_.Add(new SimpleRangeEventCal(item));
                            IDManager.SetID(simpleRangeEventCalIDRef_, simpleRangeEventCal_[simpleRangeEventCal_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            simpleRangeEventCalIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        simpleRangeEventCal_.Add(new SimpleRangeEventCal(item));
                        }
                    }
                    else
                    {
                        simpleRangeEventCal_.Add(new SimpleRangeEventCal(item));
                    }
                }
            }
            
        
        }
        
    
        #region SimpleRangeEventCal_
        private List<SimpleRangeEventCal> simpleRangeEventCal_;
        public List<SimpleRangeEventCal> SimpleRangeEventCal_
        {
            get
            {
                if (this.simpleRangeEventCal_ != null)
                {
                    return this.simpleRangeEventCal_; 
                }
                else if (this.simpleRangeEventCalIDRef_ != null)
                {
                    return this.simpleRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "simpleRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeEventCal_ != value)
                {
                    this.simpleRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeEventCalIDRef_ { get; set; }
        
    
        
    
    }
    
}

