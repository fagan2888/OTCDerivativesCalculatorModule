using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ServiceProcessingStatus : ISerialized
    {
        public ServiceProcessingStatus(XmlNode xmlNode)
        {
            XmlNode cycleNode = xmlNode.SelectSingleNode("cycle");
            
            if (cycleNode != null)
            {
                if (cycleNode.Attributes["href"] != null || cycleNode.Attributes["id"] != null) 
                {
                    if (cycleNode.Attributes["id"] != null) 
                    {
                        cycleIDRef_ = cycleNode.Attributes["id"].Value;
                        ServiceProcessingCycle ob = new ServiceProcessingCycle(cycleNode);
                        IDManager.SetID(cycleIDRef_, ob);
                    }
                    else if (cycleNode.Attributes["href"] != null)
                    {
                        cycleIDRef_ = cycleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cycle_ = new ServiceProcessingCycle(cycleNode);
                    }
                }
                else
                {
                    cycle_ = new ServiceProcessingCycle(cycleNode);
                }
            }
            
        
            XmlNode stepNode = xmlNode.SelectSingleNode("step");
            
            if (stepNode != null)
            {
                if (stepNode.Attributes["href"] != null || stepNode.Attributes["id"] != null) 
                {
                    if (stepNode.Attributes["id"] != null) 
                    {
                        stepIDRef_ = stepNode.Attributes["id"].Value;
                        ServiceProcessingStep ob = new ServiceProcessingStep(stepNode);
                        IDManager.SetID(stepIDRef_, ob);
                    }
                    else if (stepNode.Attributes["href"] != null)
                    {
                        stepIDRef_ = stepNode.Attributes["href"].Value;
                    }
                    else
                    {
                        step_ = new ServiceProcessingStep(stepNode);
                    }
                }
                else
                {
                    step_ = new ServiceProcessingStep(stepNode);
                }
            }
            
        
            XmlNode eventNode = xmlNode.SelectSingleNode("event");
            
            if (eventNode != null)
            {
                if (eventNode.Attributes["href"] != null || eventNode.Attributes["id"] != null) 
                {
                    if (eventNode.Attributes["id"] != null) 
                    {
                        eventIDRef_ = eventNode.Attributes["id"].Value;
                        ServiceProcessingEvent ob = new ServiceProcessingEvent(eventNode);
                        IDManager.SetID(eventIDRef_, ob);
                    }
                    else if (eventNode.Attributes["href"] != null)
                    {
                        eventIDRef_ = eventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        event_ = new ServiceProcessingEvent(eventNode);
                    }
                }
                else
                {
                    event_ = new ServiceProcessingEvent(eventNode);
                }
            }
            
        
        }
        
    
        #region Cycle_
        private ServiceProcessingCycle cycle_;
        public ServiceProcessingCycle Cycle_
        {
            get
            {
                if (this.cycle_ != null)
                {
                    return this.cycle_; 
                }
                else if (this.cycleIDRef_ != null)
                {
                    cycle_ = IDManager.getID(cycleIDRef_) as ServiceProcessingCycle;
                    return this.cycle_; 
                }
                else
                {
                      return this.cycle_; 
                }
            }
            set
            {
                if (this.cycle_ != value)
                {
                    this.cycle_ = value;
                }
            }
        }
        #endregion
        
        public string cycleIDRef_ { get; set; }
        #region Step_
        private ServiceProcessingStep step_;
        public ServiceProcessingStep Step_
        {
            get
            {
                if (this.step_ != null)
                {
                    return this.step_; 
                }
                else if (this.stepIDRef_ != null)
                {
                    step_ = IDManager.getID(stepIDRef_) as ServiceProcessingStep;
                    return this.step_; 
                }
                else
                {
                      return this.step_; 
                }
            }
            set
            {
                if (this.step_ != value)
                {
                    this.step_ = value;
                }
            }
        }
        #endregion
        
        public string stepIDRef_ { get; set; }
        #region Event_
        private ServiceProcessingEvent event_;
        public ServiceProcessingEvent Event_
        {
            get
            {
                if (this.event_ != null)
                {
                    return this.event_; 
                }
                else if (this.eventIDRef_ != null)
                {
                    event_ = IDManager.getID(eventIDRef_) as ServiceProcessingEvent;
                    return this.event_; 
                }
                else
                {
                      return this.event_; 
                }
            }
            set
            {
                if (this.event_ != value)
                {
                    this.event_ = value;
                }
            }
        }
        #endregion
        
        public string eventIDRef_ { get; set; }
        
    
        
    
    }
    
}

