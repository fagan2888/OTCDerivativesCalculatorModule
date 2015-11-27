using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCalculation : ISerialized
    {
        public EventCalculation() { }
        public EventCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
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
            
        
            XmlNode upperBarrierEventCalNode = xmlNode.SelectSingleNode("upperBarrierEventCal");
            
            if (upperBarrierEventCalNode != null)
            {
                if (upperBarrierEventCalNode.Attributes["href"] != null || upperBarrierEventCalNode.Attributes["id"] != null) 
                {
                    if (upperBarrierEventCalNode.Attributes["id"] != null) 
                    {
                        upperBarrierEventCalIDRef_ = upperBarrierEventCalNode.Attributes["id"].Value;
                        UpperBarrierEventCal ob = new UpperBarrierEventCal(upperBarrierEventCalNode);
                        IDManager.SetID(upperBarrierEventCalIDRef_, ob);
                    }
                    else if (upperBarrierEventCalNode.Attributes["href"] != null)
                    {
                        upperBarrierEventCalIDRef_ = upperBarrierEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperBarrierEventCal_ = new UpperBarrierEventCal(upperBarrierEventCalNode);
                    }
                }
                else
                {
                    upperBarrierEventCal_ = new UpperBarrierEventCal(upperBarrierEventCalNode);
                }
            }
            
        
            XmlNode lowerBarrierEventCalNode = xmlNode.SelectSingleNode("lowerBarrierEventCal");
            
            if (lowerBarrierEventCalNode != null)
            {
                if (lowerBarrierEventCalNode.Attributes["href"] != null || lowerBarrierEventCalNode.Attributes["id"] != null) 
                {
                    if (lowerBarrierEventCalNode.Attributes["id"] != null) 
                    {
                        lowerBarrierEventCalIDRef_ = lowerBarrierEventCalNode.Attributes["id"].Value;
                        LowerBarrierEventCal ob = new LowerBarrierEventCal(lowerBarrierEventCalNode);
                        IDManager.SetID(lowerBarrierEventCalIDRef_, ob);
                    }
                    else if (lowerBarrierEventCalNode.Attributes["href"] != null)
                    {
                        lowerBarrierEventCalIDRef_ = lowerBarrierEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerBarrierEventCal_ = new LowerBarrierEventCal(lowerBarrierEventCalNode);
                    }
                }
                else
                {
                    lowerBarrierEventCal_ = new LowerBarrierEventCal(lowerBarrierEventCalNode);
                }
            }
            
        
            XmlNode dualBarrierEventCalNode = xmlNode.SelectSingleNode("dualBarrierEventCal");
            
            if (dualBarrierEventCalNode != null)
            {
                if (dualBarrierEventCalNode.Attributes["href"] != null || dualBarrierEventCalNode.Attributes["id"] != null) 
                {
                    if (dualBarrierEventCalNode.Attributes["id"] != null) 
                    {
                        dualBarrierEventCalIDRef_ = dualBarrierEventCalNode.Attributes["id"].Value;
                        DualBarrierEventCal ob = new DualBarrierEventCal(dualBarrierEventCalNode);
                        IDManager.SetID(dualBarrierEventCalIDRef_, ob);
                    }
                    else if (dualBarrierEventCalNode.Attributes["href"] != null)
                    {
                        dualBarrierEventCalIDRef_ = dualBarrierEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dualBarrierEventCal_ = new DualBarrierEventCal(dualBarrierEventCalNode);
                    }
                }
                else
                {
                    dualBarrierEventCal_ = new DualBarrierEventCal(dualBarrierEventCalNode);
                }
            }
            
        
            XmlNode simpleRangeEventCalNode = xmlNode.SelectSingleNode("simpleRangeEventCal");
            
            if (simpleRangeEventCalNode != null)
            {
                if (simpleRangeEventCalNode.Attributes["href"] != null || simpleRangeEventCalNode.Attributes["id"] != null) 
                {
                    if (simpleRangeEventCalNode.Attributes["id"] != null) 
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["id"].Value;
                        SimpleRangeEventCal ob = new SimpleRangeEventCal(simpleRangeEventCalNode);
                        IDManager.SetID(simpleRangeEventCalIDRef_, ob);
                    }
                    else if (simpleRangeEventCalNode.Attributes["href"] != null)
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                    }
                }
                else
                {
                    simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                }
            }
            
        
            XmlNode referenceEventCalNode = xmlNode.SelectSingleNode("referenceEventCal");
            
            if (referenceEventCalNode != null)
            {
                if (referenceEventCalNode.Attributes["href"] != null || referenceEventCalNode.Attributes["id"] != null) 
                {
                    if (referenceEventCalNode.Attributes["id"] != null) 
                    {
                        referenceEventCalIDRef_ = referenceEventCalNode.Attributes["id"].Value;
                        ReferenceEventCal ob = new ReferenceEventCal(referenceEventCalNode);
                        IDManager.SetID(referenceEventCalIDRef_, ob);
                    }
                    else if (referenceEventCalNode.Attributes["href"] != null)
                    {
                        referenceEventCalIDRef_ = referenceEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEventCal_ = new ReferenceEventCal(referenceEventCalNode);
                    }
                }
                else
                {
                    referenceEventCal_ = new ReferenceEventCal(referenceEventCalNode);
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
        
    
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                    throw new Exception( "name_Node no exist!");
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
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
        #region UpperBarrierEventCal_
        private UpperBarrierEventCal upperBarrierEventCal_;
        public UpperBarrierEventCal UpperBarrierEventCal_
        {
            get
            {
                if (this.upperBarrierEventCal_ != null)
                {
                    return this.upperBarrierEventCal_; 
                }
                else if (this.upperBarrierEventCalIDRef_ != null)
                {
                    upperBarrierEventCal_ = IDManager.getID(upperBarrierEventCalIDRef_) as UpperBarrierEventCal;
                    return this.upperBarrierEventCal_; 
                }
                else
                {
                    throw new Exception( "upperBarrierEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.upperBarrierEventCal_ != value)
                {
                    this.upperBarrierEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string upperBarrierEventCalIDRef_ { get; set; }
        #region LowerBarrierEventCal_
        private LowerBarrierEventCal lowerBarrierEventCal_;
        public LowerBarrierEventCal LowerBarrierEventCal_
        {
            get
            {
                if (this.lowerBarrierEventCal_ != null)
                {
                    return this.lowerBarrierEventCal_; 
                }
                else if (this.lowerBarrierEventCalIDRef_ != null)
                {
                    lowerBarrierEventCal_ = IDManager.getID(lowerBarrierEventCalIDRef_) as LowerBarrierEventCal;
                    return this.lowerBarrierEventCal_; 
                }
                else
                {
                    throw new Exception( "lowerBarrierEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.lowerBarrierEventCal_ != value)
                {
                    this.lowerBarrierEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string lowerBarrierEventCalIDRef_ { get; set; }
        #region DualBarrierEventCal_
        private DualBarrierEventCal dualBarrierEventCal_;
        public DualBarrierEventCal DualBarrierEventCal_
        {
            get
            {
                if (this.dualBarrierEventCal_ != null)
                {
                    return this.dualBarrierEventCal_; 
                }
                else if (this.dualBarrierEventCalIDRef_ != null)
                {
                    dualBarrierEventCal_ = IDManager.getID(dualBarrierEventCalIDRef_) as DualBarrierEventCal;
                    return this.dualBarrierEventCal_; 
                }
                else
                {
                    throw new Exception( "dualBarrierEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.dualBarrierEventCal_ != value)
                {
                    this.dualBarrierEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string dualBarrierEventCalIDRef_ { get; set; }
        #region SimpleRangeEventCal_
        private SimpleRangeEventCal simpleRangeEventCal_;
        public SimpleRangeEventCal SimpleRangeEventCal_
        {
            get
            {
                if (this.simpleRangeEventCal_ != null)
                {
                    return this.simpleRangeEventCal_; 
                }
                else if (this.simpleRangeEventCalIDRef_ != null)
                {
                    simpleRangeEventCal_ = IDManager.getID(simpleRangeEventCalIDRef_) as SimpleRangeEventCal;
                    return this.simpleRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "simpleRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeEventCal_ != value)
                {
                    this.simpleRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeEventCalIDRef_ { get; set; }
        #region ReferenceEventCal_
        private ReferenceEventCal referenceEventCal_;
        public ReferenceEventCal ReferenceEventCal_
        {
            get
            {
                if (this.referenceEventCal_ != null)
                {
                    return this.referenceEventCal_; 
                }
                else if (this.referenceEventCalIDRef_ != null)
                {
                    referenceEventCal_ = IDManager.getID(referenceEventCalIDRef_) as ReferenceEventCal;
                    return this.referenceEventCal_; 
                }
                else
                {
                    throw new Exception( "referenceEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.referenceEventCal_ != value)
                {
                    this.referenceEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEventCalIDRef_ { get; set; }
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
        public string choiceStr_eventCalType;
        
    
        
    
    }
    
}

