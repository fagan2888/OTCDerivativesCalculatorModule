using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventCheckBase
    {
        public EventCheckBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventIndexTransformationNodeList = xmlNode.SelectNodes("eventIndexTransformation");
            if (eventIndexTransformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventIndexTransformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventIndexTransformationIDRef = item.Attributes["id"].Name;
                        EventIndexTransformation ob = EventIndexTransformation();
                        IDManager.SetID(eventIndexTransformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventIndexTransformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventIndexTransformation = new EventIndexTransformation(item);
                    }
                }
            }
            
        
            XmlNodeList functionEventsNodeList = xmlNode.SelectNodes("functionEvents");
            if (functionEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in functionEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        functionEventsIDRef = item.Attributes["id"].Name;
                        FunctionEvents ob = FunctionEvents();
                        IDManager.SetID(functionEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        functionEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        functionEvents = new FunctionEvents(item);
                    }
                }
            }
            
        
            XmlNodeList payoffBaseNodeList = xmlNode.SelectNodes("payoffBase");
            if (payoffBaseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payoffBaseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payoffBaseIDRef = item.Attributes["id"].Name;
                        PayoffBase ob = PayoffBase();
                        IDManager.SetID(payoffBaseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payoffBaseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payoffBase = new PayoffBase(item);
                    }
                }
            }
            
        
            XmlNodeList subEventNodeList = xmlNode.SelectNodes("subEvent");
            if (subEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in subEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        subEventIDRef = item.Attributes["id"].Name;
                        SubEvent ob = SubEvent();
                        IDManager.SetID(subEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        subEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        subEvent = new SubEvent(item);
                    }
                }
            }
            
        
            XmlNodeList jointSubEventNodeList = xmlNode.SelectNodes("jointSubEvent");
            if (jointSubEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in jointSubEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jointSubEventIDRef = item.Attributes["id"].Name;
                        JointSubEvent ob = JointSubEvent();
                        IDManager.SetID(jointSubEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jointSubEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        jointSubEvent = new JointSubEvent(item);
                    }
                }
            }
            
        
            XmlNodeList jointFSubEventNodeList = xmlNode.SelectNodes("jointFSubEvent");
            if (jointFSubEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in jointFSubEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jointFSubEventIDRef = item.Attributes["id"].Name;
                        JointFSubEvent ob = JointFSubEvent();
                        IDManager.SetID(jointFSubEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jointFSubEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        jointFSubEvent = new JointFSubEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region EventIndexTransformation
        private EventIndexTransformation eventIndexTransformation;
        public EventIndexTransformation EventIndexTransformation
        {
            get
            {
                if (this.eventIndexTransformation != null)
                {
                    return this.eventIndexTransformation; 
                }
                else if (this.eventIndexTransformationIDRef != null)
                {
                    eventIndexTransformation = IDManager.getID(eventIndexTransformationIDRef) as EventIndexTransformation;
                    return this.eventIndexTransformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventIndexTransformation != value)
                {
                    this.eventIndexTransformation = value;
                }
            }
        }
        #endregion
        
        public string EventIndexTransformationIDRef { get; set; }
        #region FunctionEvents
        private FunctionEvents functionEvents;
        public FunctionEvents FunctionEvents
        {
            get
            {
                if (this.functionEvents != null)
                {
                    return this.functionEvents; 
                }
                else if (this.functionEventsIDRef != null)
                {
                    functionEvents = IDManager.getID(functionEventsIDRef) as FunctionEvents;
                    return this.functionEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.functionEvents != value)
                {
                    this.functionEvents = value;
                }
            }
        }
        #endregion
        
        public string FunctionEventsIDRef { get; set; }
        #region PayoffBase
        private PayoffBase payoffBase;
        public PayoffBase PayoffBase
        {
            get
            {
                if (this.payoffBase != null)
                {
                    return this.payoffBase; 
                }
                else if (this.payoffBaseIDRef != null)
                {
                    payoffBase = IDManager.getID(payoffBaseIDRef) as PayoffBase;
                    return this.payoffBase; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payoffBase != value)
                {
                    this.payoffBase = value;
                }
            }
        }
        #endregion
        
        public string PayoffBaseIDRef { get; set; }
        #region SubEvent
        private SubEvent subEvent;
        public SubEvent SubEvent
        {
            get
            {
                if (this.subEvent != null)
                {
                    return this.subEvent; 
                }
                else if (this.subEventIDRef != null)
                {
                    subEvent = IDManager.getID(subEventIDRef) as SubEvent;
                    return this.subEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.subEvent != value)
                {
                    this.subEvent = value;
                }
            }
        }
        #endregion
        
        public string SubEventIDRef { get; set; }
        #region JointSubEvent
        private JointSubEvent jointSubEvent;
        public JointSubEvent JointSubEvent
        {
            get
            {
                if (this.jointSubEvent != null)
                {
                    return this.jointSubEvent; 
                }
                else if (this.jointSubEventIDRef != null)
                {
                    jointSubEvent = IDManager.getID(jointSubEventIDRef) as JointSubEvent;
                    return this.jointSubEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jointSubEvent != value)
                {
                    this.jointSubEvent = value;
                }
            }
        }
        #endregion
        
        public string JointSubEventIDRef { get; set; }
        #region JointFSubEvent
        private JointFSubEvent jointFSubEvent;
        public JointFSubEvent JointFSubEvent
        {
            get
            {
                if (this.jointFSubEvent != null)
                {
                    return this.jointFSubEvent; 
                }
                else if (this.jointFSubEventIDRef != null)
                {
                    jointFSubEvent = IDManager.getID(jointFSubEventIDRef) as JointFSubEvent;
                    return this.jointFSubEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jointFSubEvent != value)
                {
                    this.jointFSubEvent = value;
                }
            }
        }
        #endregion
        
        public string JointFSubEventIDRef { get; set; }
        
    
        
    
    }
    
}

