using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AbstractEvent
    {
        public AbstractEvent(XmlNode xmlNode)
        {
            XmlNodeList eventIdentifierNodeList = xmlNode.SelectNodes("eventIdentifier");
            
            foreach (XmlNode item in eventIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventIdentifierIDRef = item.Attributes["id"].Name;
                        List<BusinessEventIdentifier> ob = new List<BusinessEventIdentifier>();
                        ob.Add(new BusinessEventIdentifier(item));
                        IDManager.SetID(eventIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    eventIdentifier.Add(new BusinessEventIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventIdentifier
        private List<BusinessEventIdentifier> eventIdentifier;
        public List<BusinessEventIdentifier> EventIdentifier
        {
            get
            {
                if (this.eventIdentifier != null)
                {
                    return this.eventIdentifier; 
                }
                else if (this.eventIdentifierIDRef != null)
                {
                    eventIdentifier = IDManager.getID(eventIdentifierIDRef) as List<BusinessEventIdentifier>;
                    return this.eventIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventIdentifier != value)
                {
                    this.eventIdentifier = value;
                }
            }
        }
        #endregion
        
        public string BusinessEventIdentifierIDRef { get; set; }
        
    
        
    
    }
    
}

