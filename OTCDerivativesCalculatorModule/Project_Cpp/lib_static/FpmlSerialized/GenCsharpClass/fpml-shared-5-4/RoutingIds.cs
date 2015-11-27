using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RoutingIds
    {
        public RoutingIds(XmlNode xmlNode)
        {
            XmlNodeList routingIdNodeList = xmlNode.SelectNodes("routingId");
            
            foreach (XmlNode item in routingIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingIdIDRef = item.Attributes["id"].Name;
                        List<RoutingId> ob = new List<RoutingId>();
                        ob.Add(new RoutingId(item));
                        IDManager.SetID(routingIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    routingId.Add(new RoutingId(item));
                    }
                }
            }
            
        
        }
        
    
        #region RoutingId
        private List<RoutingId> routingId;
        public List<RoutingId> RoutingId
        {
            get
            {
                if (this.routingId != null)
                {
                    return this.routingId; 
                }
                else if (this.routingIdIDRef != null)
                {
                    routingId = IDManager.getID(routingIdIDRef) as List<RoutingId>;
                    return this.routingId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingId != value)
                {
                    this.routingId = value;
                }
            }
        }
        #endregion
        
        public string RoutingIdIDRef { get; set; }
        
    
        
    
    }
    
}

