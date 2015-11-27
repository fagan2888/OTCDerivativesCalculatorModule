using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionalEarlyTerminationAdjustedDates
    {
        public OptionalEarlyTerminationAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList earlyTerminationEventNodeList = xmlNode.SelectNodes("earlyTerminationEvent");
            
            foreach (XmlNode item in earlyTerminationEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earlyTerminationEventIDRef = item.Attributes["id"].Name;
                        List<EarlyTerminationEvent> ob = new List<EarlyTerminationEvent>();
                        ob.Add(new EarlyTerminationEvent(item));
                        IDManager.SetID(earlyTerminationEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earlyTerminationEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    earlyTerminationEvent.Add(new EarlyTerminationEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region EarlyTerminationEvent
        private List<EarlyTerminationEvent> earlyTerminationEvent;
        public List<EarlyTerminationEvent> EarlyTerminationEvent
        {
            get
            {
                if (this.earlyTerminationEvent != null)
                {
                    return this.earlyTerminationEvent; 
                }
                else if (this.earlyTerminationEventIDRef != null)
                {
                    earlyTerminationEvent = IDManager.getID(earlyTerminationEventIDRef) as List<EarlyTerminationEvent>;
                    return this.earlyTerminationEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earlyTerminationEvent != value)
                {
                    this.earlyTerminationEvent = value;
                }
            }
        }
        #endregion
        
        public string EarlyTerminationEventIDRef { get; set; }
        
    
        
    
    }
    
}

