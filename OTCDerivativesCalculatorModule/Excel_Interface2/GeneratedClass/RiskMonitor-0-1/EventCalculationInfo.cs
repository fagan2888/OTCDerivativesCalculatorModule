using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCalculationInfo : ISerialized
    {
        public EventCalculationInfo() { }
        public EventCalculationInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode preConditionEventNode = xmlNode.SelectSingleNode("preConditionEvent");
            
            if (preConditionEventNode != null)
            {
                if (preConditionEventNode.Attributes["href"] != null || preConditionEventNode.Attributes["id"] != null) 
                {
                    if (preConditionEventNode.Attributes["id"] != null) 
                    {
                        preConditionEventIDRef_ = preConditionEventNode.Attributes["id"].Value;
                        PreConditionEvent ob = new PreConditionEvent(preConditionEventNode);
                        IDManager.SetID(preConditionEventIDRef_, ob);
                    }
                    else if (preConditionEventNode.Attributes["href"] != null)
                    {
                        preConditionEventIDRef_ = preConditionEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preConditionEvent_ = new PreConditionEvent(preConditionEventNode);
                    }
                }
                else
                {
                    preConditionEvent_ = new PreConditionEvent(preConditionEventNode);
                }
            }
            
        
            XmlNodeList eventCalculationNodeList = xmlNode.SelectNodes("eventCalculation");
            
            if (eventCalculationNodeList != null)
            {
                this.eventCalculation_ = new List<EventCalculation>();
                foreach (XmlNode item in eventCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventCalculationIDRef_ = item.Attributes["id"].Value;
                            eventCalculation_.Add(new EventCalculation(item));
                            IDManager.SetID(eventCalculationIDRef_, eventCalculation_[eventCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventCalculation_.Add(new EventCalculation(item));
                        }
                    }
                    else
                    {
                        eventCalculation_.Add(new EventCalculation(item));
                    }
                }
            }
            
        
            XmlNode jointSimpleCalculationNode = xmlNode.SelectSingleNode("jointSimpleCalculation");
            
            if (jointSimpleCalculationNode != null)
            {
                if (jointSimpleCalculationNode.Attributes["href"] != null || jointSimpleCalculationNode.Attributes["id"] != null) 
                {
                    if (jointSimpleCalculationNode.Attributes["id"] != null) 
                    {
                        jointSimpleCalculationIDRef_ = jointSimpleCalculationNode.Attributes["id"].Value;
                        JointSimpleCalculation ob = new JointSimpleCalculation(jointSimpleCalculationNode);
                        IDManager.SetID(jointSimpleCalculationIDRef_, ob);
                    }
                    else if (jointSimpleCalculationNode.Attributes["href"] != null)
                    {
                        jointSimpleCalculationIDRef_ = jointSimpleCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointSimpleCalculation_ = new JointSimpleCalculation(jointSimpleCalculationNode);
                    }
                }
                else
                {
                    jointSimpleCalculation_ = new JointSimpleCalculation(jointSimpleCalculationNode);
                }
            }
            
        
            XmlNode pastEventOccNode = xmlNode.SelectSingleNode("pastEventOcc");
            
            if (pastEventOccNode != null)
            {
                if (pastEventOccNode.Attributes["href"] != null || pastEventOccNode.Attributes["id"] != null) 
                {
                    if (pastEventOccNode.Attributes["id"] != null) 
                    {
                        pastEventOccIDRef_ = pastEventOccNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(pastEventOccNode);
                        IDManager.SetID(pastEventOccIDRef_, ob);
                    }
                    else if (pastEventOccNode.Attributes["href"] != null)
                    {
                        pastEventOccIDRef_ = pastEventOccNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pastEventOcc_ = new XsdTypeBoolean(pastEventOccNode);
                    }
                }
                else
                {
                    pastEventOcc_ = new XsdTypeBoolean(pastEventOccNode);
                }
            }
            
        
            XmlNode refVariable_eventOccNode = xmlNode.SelectSingleNode("refVariable_eventOcc");
            
            if (refVariable_eventOccNode != null)
            {
                if (refVariable_eventOccNode.Attributes["href"] != null || refVariable_eventOccNode.Attributes["id"] != null) 
                {
                    if (refVariable_eventOccNode.Attributes["id"] != null) 
                    {
                        refVariable_eventOccIDRef_ = refVariable_eventOccNode.Attributes["id"].Value;
                        RefVariable_eventOcc ob = new RefVariable_eventOcc(refVariable_eventOccNode);
                        IDManager.SetID(refVariable_eventOccIDRef_, ob);
                    }
                    else if (refVariable_eventOccNode.Attributes["href"] != null)
                    {
                        refVariable_eventOccIDRef_ = refVariable_eventOccNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariable_eventOcc_ = new RefVariable_eventOcc(refVariable_eventOccNode);
                    }
                }
                else
                {
                    refVariable_eventOcc_ = new RefVariable_eventOcc(refVariable_eventOccNode);
                }
            }
            
        
        }
        
    
        #region PreConditionEvent_
        private PreConditionEvent preConditionEvent_;
        public PreConditionEvent PreConditionEvent_
        {
            get
            {
                if (this.preConditionEvent_ != null)
                {
                    return this.preConditionEvent_; 
                }
                else if (this.preConditionEventIDRef_ != null)
                {
                    preConditionEvent_ = IDManager.getID(preConditionEventIDRef_) as PreConditionEvent;
                    return this.preConditionEvent_; 
                }
                else
                {
                    throw new Exception( "preConditionEvent_Node no exist!");
                }
            }
            set
            {
                if (this.preConditionEvent_ != value)
                {
                    this.preConditionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string preConditionEventIDRef_ { get; set; }
        #region EventCalculation_
        private List<EventCalculation> eventCalculation_;
        public List<EventCalculation> EventCalculation_
        {
            get
            {
                if (this.eventCalculation_ != null)
                {
                    return this.eventCalculation_; 
                }
                else if (this.eventCalculationIDRef_ != null)
                {
                    return this.eventCalculation_; 
                }
                else
                {
                    throw new Exception( "eventCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.eventCalculation_ != value)
                {
                    this.eventCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string eventCalculationIDRef_ { get; set; }
        #region JointSimpleCalculation_
        private JointSimpleCalculation jointSimpleCalculation_;
        public JointSimpleCalculation JointSimpleCalculation_
        {
            get
            {
                if (this.jointSimpleCalculation_ != null)
                {
                    return this.jointSimpleCalculation_; 
                }
                else if (this.jointSimpleCalculationIDRef_ != null)
                {
                    jointSimpleCalculation_ = IDManager.getID(jointSimpleCalculationIDRef_) as JointSimpleCalculation;
                    return this.jointSimpleCalculation_; 
                }
                else
                {
                    throw new Exception( "jointSimpleCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.jointSimpleCalculation_ != value)
                {
                    this.jointSimpleCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string jointSimpleCalculationIDRef_ { get; set; }
        #region PastEventOcc_
        private XsdTypeBoolean pastEventOcc_;
        public XsdTypeBoolean PastEventOcc_
        {
            get
            {
                if (this.pastEventOcc_ != null)
                {
                    return this.pastEventOcc_; 
                }
                else if (this.pastEventOccIDRef_ != null)
                {
                    pastEventOcc_ = IDManager.getID(pastEventOccIDRef_) as XsdTypeBoolean;
                    return this.pastEventOcc_; 
                }
                else
                {
                    throw new Exception( "pastEventOcc_Node no exist!");
                }
            }
            set
            {
                if (this.pastEventOcc_ != value)
                {
                    this.pastEventOcc_ = value;
                }
            }
        }
        #endregion
        
        public string pastEventOccIDRef_ { get; set; }
        #region RefVariable_eventOcc_
        private RefVariable_eventOcc refVariable_eventOcc_;
        public RefVariable_eventOcc RefVariable_eventOcc_
        {
            get
            {
                if (this.refVariable_eventOcc_ != null)
                {
                    return this.refVariable_eventOcc_; 
                }
                else if (this.refVariable_eventOccIDRef_ != null)
                {
                    refVariable_eventOcc_ = IDManager.getID(refVariable_eventOccIDRef_) as RefVariable_eventOcc;
                    return this.refVariable_eventOcc_; 
                }
                else
                {
                    throw new Exception( "refVariable_eventOcc_Node no exist!");
                }
            }
            set
            {
                if (this.refVariable_eventOcc_ != value)
                {
                    this.refVariable_eventOcc_ = value;
                }
            }
        }
        #endregion
        
        public string refVariable_eventOccIDRef_ { get; set; }
        
    
        
    
    }
    
}

