using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ServiceProcessingStatus
    {
        public ServiceProcessingStatus(XmlNode xmlNode)
        {
            XmlNodeList cycleNodeList = xmlNode.SelectNodes("cycle");
            if (cycleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cycleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cycleIDRef = item.Attributes["id"].Name;
                        ServiceProcessingCycle ob = ServiceProcessingCycle();
                        IDManager.SetID(cycleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cycleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cycle = new ServiceProcessingCycle(item);
                    }
                }
            }
            
        
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            if (stepNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepIDRef = item.Attributes["id"].Name;
                        ServiceProcessingStep ob = ServiceProcessingStep();
                        IDManager.SetID(stepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        step = new ServiceProcessingStep(item);
                    }
                }
            }
            
        
            XmlNodeList eventNodeList = xmlNode.SelectNodes("event");
            if (eventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventIDRef = item.Attributes["id"].Name;
                        ServiceProcessingEvent ob = ServiceProcessingEvent();
                        IDManager.SetID(eventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        event = new ServiceProcessingEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region Cycle
        private ServiceProcessingCycle cycle;
        public ServiceProcessingCycle Cycle
        {
            get
            {
                if (this.cycle != null)
                {
                    return this.cycle; 
                }
                else if (this.cycleIDRef != null)
                {
                    cycle = IDManager.getID(cycleIDRef) as ServiceProcessingCycle;
                    return this.cycle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cycle != value)
                {
                    this.cycle = value;
                }
            }
        }
        #endregion
        
        public string ServiceProcessingCycleIDRef { get; set; }
        #region Step
        private ServiceProcessingStep step;
        public ServiceProcessingStep Step
        {
            get
            {
                if (this.step != null)
                {
                    return this.step; 
                }
                else if (this.stepIDRef != null)
                {
                    step = IDManager.getID(stepIDRef) as ServiceProcessingStep;
                    return this.step; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.step != value)
                {
                    this.step = value;
                }
            }
        }
        #endregion
        
        public string ServiceProcessingStepIDRef { get; set; }
        #region Event
        private ServiceProcessingEvent event;
        public ServiceProcessingEvent Event
        {
            get
            {
                if (this.event != null)
                {
                    return this.event; 
                }
                else if (this.eventIDRef != null)
                {
                    event = IDManager.getID(eventIDRef) as ServiceProcessingEvent;
                    return this.event; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.event != value)
                {
                    this.event = value;
                }
            }
        }
        #endregion
        
        public string ServiceProcessingEventIDRef { get; set; }
        
    
        
    
    }
    
}

