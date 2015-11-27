using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RoutingIds : ISerialized
    {
        public RoutingIds(XmlNode xmlNode)
        {
            XmlNodeList routingIdNodeList = xmlNode.SelectNodes("routingId");
            
            if (routingIdNodeList != null)
            {
                this.routingId_ = new List<RoutingId>();
                foreach (XmlNode item in routingIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            routingIdIDRef_ = item.Attributes["id"].Value;
                            routingId_.Add(new RoutingId(item));
                            IDManager.SetID(routingIdIDRef_, routingId_[routingId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            routingIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        routingId_.Add(new RoutingId(item));
                        }
                    }
                    else
                    {
                        routingId_.Add(new RoutingId(item));
                    }
                }
            }
            
        
        }
        
    
        #region RoutingId_
        private List<RoutingId> routingId_;
        public List<RoutingId> RoutingId_
        {
            get
            {
                if (this.routingId_ != null)
                {
                    return this.routingId_; 
                }
                else if (this.routingIdIDRef_ != null)
                {
                    return this.routingId_; 
                }
                else
                {
                      return this.routingId_; 
                }
            }
            set
            {
                if (this.routingId_ != value)
                {
                    this.routingId_ = value;
                }
            }
        }
        #endregion
        
        public string routingIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

