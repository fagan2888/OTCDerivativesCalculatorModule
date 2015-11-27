using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FunctionEvents
    {
        public FunctionEvents(XmlNode xmlNode)
        {
            XmlNodeList eventFunctionMNodeList = xmlNode.SelectNodes("eventFunctionM");
            
            foreach (XmlNode item in eventFunctionMNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventFunctionMIDRef = item.Attributes["id"].Name;
                        List<EventFunctionM> ob = new List<EventFunctionM>();
                        ob.Add(new EventFunctionM(item));
                        IDManager.SetID(eventFunctionMIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventFunctionMIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    eventFunctionM.Add(new EventFunctionM(item));
                    }
                }
            }
            
        
            XmlNodeList jointFunctionEventNodeList = xmlNode.SelectNodes("jointFunctionEvent");
            if (jointFunctionEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in jointFunctionEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jointFunctionEventIDRef = item.Attributes["id"].Name;
                        JointFunctionEvent ob = JointFunctionEvent();
                        IDManager.SetID(jointFunctionEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jointFunctionEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        jointFunctionEvent = new JointFunctionEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region EventFunctionM
        private List<EventFunctionM> eventFunctionM;
        public List<EventFunctionM> EventFunctionM
        {
            get
            {
                if (this.eventFunctionM != null)
                {
                    return this.eventFunctionM; 
                }
                else if (this.eventFunctionMIDRef != null)
                {
                    eventFunctionM = IDManager.getID(eventFunctionMIDRef) as List<EventFunctionM>;
                    return this.eventFunctionM; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventFunctionM != value)
                {
                    this.eventFunctionM = value;
                }
            }
        }
        #endregion
        
        public string EventFunctionMIDRef { get; set; }
        #region JointFunctionEvent
        private JointFunctionEvent jointFunctionEvent;
        public JointFunctionEvent JointFunctionEvent
        {
            get
            {
                if (this.jointFunctionEvent != null)
                {
                    return this.jointFunctionEvent; 
                }
                else if (this.jointFunctionEventIDRef != null)
                {
                    jointFunctionEvent = IDManager.getID(jointFunctionEventIDRef) as JointFunctionEvent;
                    return this.jointFunctionEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jointFunctionEvent != value)
                {
                    this.jointFunctionEvent = value;
                }
            }
        }
        #endregion
        
        public string JointFunctionEventIDRef { get; set; }
        
    
        
    
    }
    
}

