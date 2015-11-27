using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCheckBase : IEventCheck
    {
        public EventCheckBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventIndexTransformationNode = xmlNode.SelectSingleNode("eventIndexTransformation");
            
            if (eventIndexTransformationNode != null)
            {
                if (eventIndexTransformationNode.Attributes["href"] != null || eventIndexTransformationNode.Attributes["id"] != null) 
                {
                    if (eventIndexTransformationNode.Attributes["id"] != null) 
                    {
                        eventIndexTransformationIDRef_ = eventIndexTransformationNode.Attributes["id"].Value;
                        EventIndexTransformation ob = new EventIndexTransformation(eventIndexTransformationNode);
                        IDManager.SetID(eventIndexTransformationIDRef_, ob);
                    }
                    else if (eventIndexTransformationNode.Attributes["href"] != null)
                    {
                        eventIndexTransformationIDRef_ = eventIndexTransformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventIndexTransformation_ = new EventIndexTransformation(eventIndexTransformationNode);
                    }
                }
                else
                {
                    eventIndexTransformation_ = new EventIndexTransformation(eventIndexTransformationNode);
                }
            }
            
        
            XmlNode functionEventsNode = xmlNode.SelectSingleNode("functionEvents");
            
            if (functionEventsNode != null)
            {
                if (functionEventsNode.Attributes["href"] != null || functionEventsNode.Attributes["id"] != null) 
                {
                    if (functionEventsNode.Attributes["id"] != null) 
                    {
                        functionEventsIDRef_ = functionEventsNode.Attributes["id"].Value;
                        FunctionEvents ob = new FunctionEvents(functionEventsNode);
                        IDManager.SetID(functionEventsIDRef_, ob);
                    }
                    else if (functionEventsNode.Attributes["href"] != null)
                    {
                        functionEventsIDRef_ = functionEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        functionEvents_ = new FunctionEvents(functionEventsNode);
                    }
                }
                else
                {
                    functionEvents_ = new FunctionEvents(functionEventsNode);
                }
            }
            
        
            XmlNode payoffBaseNode = xmlNode.SelectSingleNode("payoffBase");
            
            if (payoffBaseNode != null)
            {
                if (payoffBaseNode.Attributes["href"] != null || payoffBaseNode.Attributes["id"] != null) 
                {
                    if (payoffBaseNode.Attributes["id"] != null) 
                    {
                        payoffBaseIDRef_ = payoffBaseNode.Attributes["id"].Value;
                        PayoffBase ob = new PayoffBase(payoffBaseNode);
                        IDManager.SetID(payoffBaseIDRef_, ob);
                    }
                    else if (payoffBaseNode.Attributes["href"] != null)
                    {
                        payoffBaseIDRef_ = payoffBaseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffBase_ = new PayoffBase(payoffBaseNode);
                    }
                }
                else
                {
                    payoffBase_ = new PayoffBase(payoffBaseNode);
                }
            }
            
        
            XmlNode subEventNode = xmlNode.SelectSingleNode("subEvent");
            
            if (subEventNode != null)
            {
                if (subEventNode.Attributes["href"] != null || subEventNode.Attributes["id"] != null) 
                {
                    if (subEventNode.Attributes["id"] != null) 
                    {
                        subEventIDRef_ = subEventNode.Attributes["id"].Value;
                        SubEvent ob = new SubEvent(subEventNode);
                        IDManager.SetID(subEventIDRef_, ob);
                    }
                    else if (subEventNode.Attributes["href"] != null)
                    {
                        subEventIDRef_ = subEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        subEvent_ = new SubEvent(subEventNode);
                    }
                }
                else
                {
                    subEvent_ = new SubEvent(subEventNode);
                }
            }
            
        
            XmlNode jointSubEventNode = xmlNode.SelectSingleNode("jointSubEvent");
            
            if (jointSubEventNode != null)
            {
                if (jointSubEventNode.Attributes["href"] != null || jointSubEventNode.Attributes["id"] != null) 
                {
                    if (jointSubEventNode.Attributes["id"] != null) 
                    {
                        jointSubEventIDRef_ = jointSubEventNode.Attributes["id"].Value;
                        JointSubEvent ob = new JointSubEvent(jointSubEventNode);
                        IDManager.SetID(jointSubEventIDRef_, ob);
                    }
                    else if (jointSubEventNode.Attributes["href"] != null)
                    {
                        jointSubEventIDRef_ = jointSubEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointSubEvent_ = new JointSubEvent(jointSubEventNode);
                    }
                }
                else
                {
                    jointSubEvent_ = new JointSubEvent(jointSubEventNode);
                }
            }
            
        
            XmlNode jointFSubEventNode = xmlNode.SelectSingleNode("jointFSubEvent");
            
            if (jointFSubEventNode != null)
            {
                if (jointFSubEventNode.Attributes["href"] != null || jointFSubEventNode.Attributes["id"] != null) 
                {
                    if (jointFSubEventNode.Attributes["id"] != null) 
                    {
                        jointFSubEventIDRef_ = jointFSubEventNode.Attributes["id"].Value;
                        JointFSubEvent ob = new JointFSubEvent(jointFSubEventNode);
                        IDManager.SetID(jointFSubEventIDRef_, ob);
                    }
                    else if (jointFSubEventNode.Attributes["href"] != null)
                    {
                        jointFSubEventIDRef_ = jointFSubEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointFSubEvent_ = new JointFSubEvent(jointFSubEventNode);
                    }
                }
                else
                {
                    jointFSubEvent_ = new JointFSubEvent(jointFSubEventNode);
                }
            }
            
        
        }
        
    
        #region EventIndexTransformation_
        private EventIndexTransformation eventIndexTransformation_;
        public EventIndexTransformation EventIndexTransformation_
        {
            get
            {
                if (this.eventIndexTransformation_ != null)
                {
                    return this.eventIndexTransformation_; 
                }
                else if (this.eventIndexTransformationIDRef_ != null)
                {
                    eventIndexTransformation_ = IDManager.getID(eventIndexTransformationIDRef_) as EventIndexTransformation;
                    return this.eventIndexTransformation_; 
                }
                else
                {
                      return this.eventIndexTransformation_; 
                }
            }
            set
            {
                if (this.eventIndexTransformation_ != value)
                {
                    this.eventIndexTransformation_ = value;
                }
            }
        }
        #endregion
        
        public string eventIndexTransformationIDRef_ { get; set; }
        #region FunctionEvents_
        private FunctionEvents functionEvents_;
        public FunctionEvents FunctionEvents_
        {
            get
            {
                if (this.functionEvents_ != null)
                {
                    return this.functionEvents_; 
                }
                else if (this.functionEventsIDRef_ != null)
                {
                    functionEvents_ = IDManager.getID(functionEventsIDRef_) as FunctionEvents;
                    return this.functionEvents_; 
                }
                else
                {
                      return this.functionEvents_; 
                }
            }
            set
            {
                if (this.functionEvents_ != value)
                {
                    this.functionEvents_ = value;
                }
            }
        }
        #endregion
        
        public string functionEventsIDRef_ { get; set; }
        #region PayoffBase_
        private PayoffBase payoffBase_;
        public PayoffBase PayoffBase_
        {
            get
            {
                if (this.payoffBase_ != null)
                {
                    return this.payoffBase_; 
                }
                else if (this.payoffBaseIDRef_ != null)
                {
                    payoffBase_ = IDManager.getID(payoffBaseIDRef_) as PayoffBase;
                    return this.payoffBase_; 
                }
                else
                {
                      return this.payoffBase_; 
                }
            }
            set
            {
                if (this.payoffBase_ != value)
                {
                    this.payoffBase_ = value;
                }
            }
        }
        #endregion
        
        public string payoffBaseIDRef_ { get; set; }
        #region SubEvent_
        private SubEvent subEvent_;
        public SubEvent SubEvent_
        {
            get
            {
                if (this.subEvent_ != null)
                {
                    return this.subEvent_; 
                }
                else if (this.subEventIDRef_ != null)
                {
                    subEvent_ = IDManager.getID(subEventIDRef_) as SubEvent;
                    return this.subEvent_; 
                }
                else
                {
                      return this.subEvent_; 
                }
            }
            set
            {
                if (this.subEvent_ != value)
                {
                    this.subEvent_ = value;
                }
            }
        }
        #endregion
        
        public string subEventIDRef_ { get; set; }
        #region JointSubEvent_
        private JointSubEvent jointSubEvent_;
        public JointSubEvent JointSubEvent_
        {
            get
            {
                if (this.jointSubEvent_ != null)
                {
                    return this.jointSubEvent_; 
                }
                else if (this.jointSubEventIDRef_ != null)
                {
                    jointSubEvent_ = IDManager.getID(jointSubEventIDRef_) as JointSubEvent;
                    return this.jointSubEvent_; 
                }
                else
                {
                      return this.jointSubEvent_; 
                }
            }
            set
            {
                if (this.jointSubEvent_ != value)
                {
                    this.jointSubEvent_ = value;
                }
            }
        }
        #endregion
        
        public string jointSubEventIDRef_ { get; set; }
        #region JointFSubEvent_
        private JointFSubEvent jointFSubEvent_;
        public JointFSubEvent JointFSubEvent_
        {
            get
            {
                if (this.jointFSubEvent_ != null)
                {
                    return this.jointFSubEvent_; 
                }
                else if (this.jointFSubEventIDRef_ != null)
                {
                    jointFSubEvent_ = IDManager.getID(jointFSubEventIDRef_) as JointFSubEvent;
                    return this.jointFSubEvent_; 
                }
                else
                {
                      return this.jointFSubEvent_; 
                }
            }
            set
            {
                if (this.jointFSubEvent_ != value)
                {
                    this.jointFSubEvent_ = value;
                }
            }
        }
        #endregion
        
        public string jointFSubEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

