using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FunctionEvents : ISerialized
    {
        public FunctionEvents(XmlNode xmlNode)
        {
            XmlNodeList eventFunctionMNodeList = xmlNode.SelectNodes("eventFunctionM");
            
            if (eventFunctionMNodeList != null)
            {
                this.eventFunctionM_ = new List<EventFunctionM>();
                foreach (XmlNode item in eventFunctionMNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventFunctionMIDRef_ = item.Attributes["id"].Value;
                            eventFunctionM_.Add(new EventFunctionM(item));
                            IDManager.SetID(eventFunctionMIDRef_, eventFunctionM_[eventFunctionM_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventFunctionMIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventFunctionM_.Add(new EventFunctionM(item));
                        }
                    }
                    else
                    {
                        eventFunctionM_.Add(new EventFunctionM(item));
                    }
                }
            }
            
        
            XmlNode jointFunctionEventNode = xmlNode.SelectSingleNode("jointFunctionEvent");
            
            if (jointFunctionEventNode != null)
            {
                if (jointFunctionEventNode.Attributes["href"] != null || jointFunctionEventNode.Attributes["id"] != null) 
                {
                    if (jointFunctionEventNode.Attributes["id"] != null) 
                    {
                        jointFunctionEventIDRef_ = jointFunctionEventNode.Attributes["id"].Value;
                        JointFunctionEvent ob = new JointFunctionEvent(jointFunctionEventNode);
                        IDManager.SetID(jointFunctionEventIDRef_, ob);
                    }
                    else if (jointFunctionEventNode.Attributes["href"] != null)
                    {
                        jointFunctionEventIDRef_ = jointFunctionEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointFunctionEvent_ = new JointFunctionEvent(jointFunctionEventNode);
                    }
                }
                else
                {
                    jointFunctionEvent_ = new JointFunctionEvent(jointFunctionEventNode);
                }
            }
            
        
        }
        
    
        #region EventFunctionM_
        private List<EventFunctionM> eventFunctionM_;
        public List<EventFunctionM> EventFunctionM_
        {
            get
            {
                if (this.eventFunctionM_ != null)
                {
                    return this.eventFunctionM_; 
                }
                else if (this.eventFunctionMIDRef_ != null)
                {
                    return this.eventFunctionM_; 
                }
                else
                {
                      return this.eventFunctionM_; 
                }
            }
            set
            {
                if (this.eventFunctionM_ != value)
                {
                    this.eventFunctionM_ = value;
                }
            }
        }
        #endregion
        
        public string eventFunctionMIDRef_ { get; set; }
        #region JointFunctionEvent_
        private JointFunctionEvent jointFunctionEvent_;
        public JointFunctionEvent JointFunctionEvent_
        {
            get
            {
                if (this.jointFunctionEvent_ != null)
                {
                    return this.jointFunctionEvent_; 
                }
                else if (this.jointFunctionEventIDRef_ != null)
                {
                    jointFunctionEvent_ = IDManager.getID(jointFunctionEventIDRef_) as JointFunctionEvent;
                    return this.jointFunctionEvent_; 
                }
                else
                {
                      return this.jointFunctionEvent_; 
                }
            }
            set
            {
                if (this.jointFunctionEvent_ != value)
                {
                    this.jointFunctionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string jointFunctionEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

