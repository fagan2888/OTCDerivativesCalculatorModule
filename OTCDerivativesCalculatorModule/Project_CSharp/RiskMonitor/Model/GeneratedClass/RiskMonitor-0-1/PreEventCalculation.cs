using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PreEventCalculation : ISerialized
    {
        public PreEventCalculation() { }
        public PreEventCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventCalculationListNodeList = xmlNode.SelectNodes("eventCalculationList");
            
            if (eventCalculationListNodeList != null)
            {
                this.eventCalculationList_ = new List<EventCalculationList>();
                foreach (XmlNode item in eventCalculationListNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventCalculationListIDRef_ = item.Attributes["id"].Value;
                            eventCalculationList_.Add(new EventCalculationList(item));
                            IDManager.SetID(eventCalculationListIDRef_, eventCalculationList_[eventCalculationList_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventCalculationListIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventCalculationList_.Add(new EventCalculationList(item));
                        }
                    }
                    else
                    {
                        eventCalculationList_.Add(new EventCalculationList(item));
                    }
                }
            }
            
        
            XmlNodeList jointEventCalculationNodeList = xmlNode.SelectNodes("jointEventCalculation");
            
            if (jointEventCalculationNodeList != null)
            {
                this.jointEventCalculation_ = new List<JointEventCalculation>();
                foreach (XmlNode item in jointEventCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            jointEventCalculationIDRef_ = item.Attributes["id"].Value;
                            jointEventCalculation_.Add(new JointEventCalculation(item));
                            IDManager.SetID(jointEventCalculationIDRef_, jointEventCalculation_[jointEventCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            jointEventCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        jointEventCalculation_.Add(new JointEventCalculation(item));
                        }
                    }
                    else
                    {
                        jointEventCalculation_.Add(new JointEventCalculation(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventCalculationList_
        private List<EventCalculationList> eventCalculationList_;
        public List<EventCalculationList> EventCalculationList_
        {
            get
            {
                if (this.eventCalculationList_ != null)
                {
                    return this.eventCalculationList_; 
                }
                else if (this.eventCalculationListIDRef_ != null)
                {
                    return this.eventCalculationList_; 
                }
                else
                {
                    throw new Exception( "eventCalculationList_Node no exist!");
                }
            }
            set
            {
                if (this.eventCalculationList_ != value)
                {
                    this.eventCalculationList_ = value;
                }
            }
        }
        #endregion
        
        public string eventCalculationListIDRef_ { get; set; }
        #region JointEventCalculation_
        private List<JointEventCalculation> jointEventCalculation_;
        public List<JointEventCalculation> JointEventCalculation_
        {
            get
            {
                if (this.jointEventCalculation_ != null)
                {
                    return this.jointEventCalculation_; 
                }
                else if (this.jointEventCalculationIDRef_ != null)
                {
                    return this.jointEventCalculation_; 
                }
                else
                {
                    throw new Exception( "jointEventCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.jointEventCalculation_ != value)
                {
                    this.jointEventCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string jointEventCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

