using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConstUpperBarrierInfo : ISerialized
    {
        public ConstUpperBarrierInfo() { }
        public ConstUpperBarrierInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceCalculationInfoNode = xmlNode.SelectSingleNode("referenceCalculationInfo");
            
            if (referenceCalculationInfoNode != null)
            {
                if (referenceCalculationInfoNode.Attributes["href"] != null || referenceCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (referenceCalculationInfoNode.Attributes["id"] != null) 
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["id"].Value;
                        ReferenceCalculationInfo ob = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                        IDManager.SetID(referenceCalculationInfoIDRef_, ob);
                    }
                    else if (referenceCalculationInfoNode.Attributes["href"] != null)
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                    }
                }
                else
                {
                    referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                }
            }
            
        
            XmlNode barrierDateInfoNode = xmlNode.SelectSingleNode("barrierDateInfo");
            
            if (barrierDateInfoNode != null)
            {
                if (barrierDateInfoNode.Attributes["href"] != null || barrierDateInfoNode.Attributes["id"] != null) 
                {
                    if (barrierDateInfoNode.Attributes["id"] != null) 
                    {
                        barrierDateInfoIDRef_ = barrierDateInfoNode.Attributes["id"].Value;
                        BarrierDateInfo ob = new BarrierDateInfo(barrierDateInfoNode);
                        IDManager.SetID(barrierDateInfoIDRef_, ob);
                    }
                    else if (barrierDateInfoNode.Attributes["href"] != null)
                    {
                        barrierDateInfoIDRef_ = barrierDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierDateInfo_ = new BarrierDateInfo(barrierDateInfoNode);
                    }
                }
                else
                {
                    barrierDateInfo_ = new BarrierDateInfo(barrierDateInfoNode);
                }
            }
            
        
            XmlNode triggerNode = xmlNode.SelectSingleNode("trigger");
            
            if (triggerNode != null)
            {
                if (triggerNode.Attributes["href"] != null || triggerNode.Attributes["id"] != null) 
                {
                    if (triggerNode.Attributes["id"] != null) 
                    {
                        triggerIDRef_ = triggerNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(triggerNode);
                        IDManager.SetID(triggerIDRef_, ob);
                    }
                    else if (triggerNode.Attributes["href"] != null)
                    {
                        triggerIDRef_ = triggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trigger_ = new XsdTypeDouble(triggerNode);
                    }
                }
                else
                {
                    trigger_ = new XsdTypeDouble(triggerNode);
                }
            }
            
        
            XmlNode pastEventOccDateNode = xmlNode.SelectSingleNode("pastEventOccDate");
            
            if (pastEventOccDateNode != null)
            {
                if (pastEventOccDateNode.Attributes["href"] != null || pastEventOccDateNode.Attributes["id"] != null) 
                {
                    if (pastEventOccDateNode.Attributes["id"] != null) 
                    {
                        pastEventOccDateIDRef_ = pastEventOccDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(pastEventOccDateNode);
                        IDManager.SetID(pastEventOccDateIDRef_, ob);
                    }
                    else if (pastEventOccDateNode.Attributes["href"] != null)
                    {
                        pastEventOccDateIDRef_ = pastEventOccDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pastEventOccDate_ = new XsdTypeDate(pastEventOccDateNode);
                    }
                }
                else
                {
                    pastEventOccDate_ = new XsdTypeDate(pastEventOccDateNode);
                }
            }
            
        
            XmlNode pastEventOccValueNode = xmlNode.SelectSingleNode("pastEventOccValue");
            
            if (pastEventOccValueNode != null)
            {
                if (pastEventOccValueNode.Attributes["href"] != null || pastEventOccValueNode.Attributes["id"] != null) 
                {
                    if (pastEventOccValueNode.Attributes["id"] != null) 
                    {
                        pastEventOccValueIDRef_ = pastEventOccValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(pastEventOccValueNode);
                        IDManager.SetID(pastEventOccValueIDRef_, ob);
                    }
                    else if (pastEventOccValueNode.Attributes["href"] != null)
                    {
                        pastEventOccValueIDRef_ = pastEventOccValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pastEventOccValue_ = new XsdTypeDouble(pastEventOccValueNode);
                    }
                }
                else
                {
                    pastEventOccValue_ = new XsdTypeDouble(pastEventOccValueNode);
                }
            }
            
        
            XmlNode refVariableFlag_eventOccDateNode = xmlNode.SelectSingleNode("refVariableFlag_eventOccDate");
            
            if (refVariableFlag_eventOccDateNode != null)
            {
                if (refVariableFlag_eventOccDateNode.Attributes["href"] != null || refVariableFlag_eventOccDateNode.Attributes["id"] != null) 
                {
                    if (refVariableFlag_eventOccDateNode.Attributes["id"] != null) 
                    {
                        refVariableFlag_eventOccDateIDRef_ = refVariableFlag_eventOccDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refVariableFlag_eventOccDateNode);
                        IDManager.SetID(refVariableFlag_eventOccDateIDRef_, ob);
                    }
                    else if (refVariableFlag_eventOccDateNode.Attributes["href"] != null)
                    {
                        refVariableFlag_eventOccDateIDRef_ = refVariableFlag_eventOccDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariableFlag_eventOccDate_ = new XsdTypeToken(refVariableFlag_eventOccDateNode);
                    }
                }
                else
                {
                    refVariableFlag_eventOccDate_ = new XsdTypeToken(refVariableFlag_eventOccDateNode);
                }
            }
            
        
            XmlNode refVariableFlag_eventOccValueNode = xmlNode.SelectSingleNode("refVariableFlag_eventOccValue");
            
            if (refVariableFlag_eventOccValueNode != null)
            {
                if (refVariableFlag_eventOccValueNode.Attributes["href"] != null || refVariableFlag_eventOccValueNode.Attributes["id"] != null) 
                {
                    if (refVariableFlag_eventOccValueNode.Attributes["id"] != null) 
                    {
                        refVariableFlag_eventOccValueIDRef_ = refVariableFlag_eventOccValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refVariableFlag_eventOccValueNode);
                        IDManager.SetID(refVariableFlag_eventOccValueIDRef_, ob);
                    }
                    else if (refVariableFlag_eventOccValueNode.Attributes["href"] != null)
                    {
                        refVariableFlag_eventOccValueIDRef_ = refVariableFlag_eventOccValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariableFlag_eventOccValue_ = new XsdTypeToken(refVariableFlag_eventOccValueNode);
                    }
                }
                else
                {
                    refVariableFlag_eventOccValue_ = new XsdTypeToken(refVariableFlag_eventOccValueNode);
                }
            }
            
        
        }
        
    
        #region ReferenceCalculationInfo_
        private ReferenceCalculationInfo referenceCalculationInfo_;
        public ReferenceCalculationInfo ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
                    referenceCalculationInfo_ = IDManager.getID(referenceCalculationInfoIDRef_) as ReferenceCalculationInfo;
                    return this.referenceCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "referenceCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculationInfo_ != value)
                {
                    this.referenceCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationInfoIDRef_ { get; set; }
        #region BarrierDateInfo_
        private BarrierDateInfo barrierDateInfo_;
        public BarrierDateInfo BarrierDateInfo_
        {
            get
            {
                if (this.barrierDateInfo_ != null)
                {
                    return this.barrierDateInfo_; 
                }
                else if (this.barrierDateInfoIDRef_ != null)
                {
                    barrierDateInfo_ = IDManager.getID(barrierDateInfoIDRef_) as BarrierDateInfo;
                    return this.barrierDateInfo_; 
                }
                else
                {
                    throw new Exception( "barrierDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.barrierDateInfo_ != value)
                {
                    this.barrierDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string barrierDateInfoIDRef_ { get; set; }
        #region Trigger_
        private XsdTypeDouble trigger_;
        public XsdTypeDouble Trigger_
        {
            get
            {
                if (this.trigger_ != null)
                {
                    return this.trigger_; 
                }
                else if (this.triggerIDRef_ != null)
                {
                    trigger_ = IDManager.getID(triggerIDRef_) as XsdTypeDouble;
                    return this.trigger_; 
                }
                else
                {
                    throw new Exception( "trigger_Node no exist!");
                }
            }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                }
            }
        }
        #endregion
        
        public string triggerIDRef_ { get; set; }
        #region PastEventOccDate_
        private XsdTypeDate pastEventOccDate_;
        public XsdTypeDate PastEventOccDate_
        {
            get
            {
                if (this.pastEventOccDate_ != null)
                {
                    return this.pastEventOccDate_; 
                }
                else if (this.pastEventOccDateIDRef_ != null)
                {
                    pastEventOccDate_ = IDManager.getID(pastEventOccDateIDRef_) as XsdTypeDate;
                    return this.pastEventOccDate_; 
                }
                else
                {
                    throw new Exception( "pastEventOccDate_Node no exist!");
                }
            }
            set
            {
                if (this.pastEventOccDate_ != value)
                {
                    this.pastEventOccDate_ = value;
                }
            }
        }
        #endregion
        
        public string pastEventOccDateIDRef_ { get; set; }
        #region PastEventOccValue_
        private XsdTypeDouble pastEventOccValue_;
        public XsdTypeDouble PastEventOccValue_
        {
            get
            {
                if (this.pastEventOccValue_ != null)
                {
                    return this.pastEventOccValue_; 
                }
                else if (this.pastEventOccValueIDRef_ != null)
                {
                    pastEventOccValue_ = IDManager.getID(pastEventOccValueIDRef_) as XsdTypeDouble;
                    return this.pastEventOccValue_; 
                }
                else
                {
                    throw new Exception( "pastEventOccValue_Node no exist!");
                }
            }
            set
            {
                if (this.pastEventOccValue_ != value)
                {
                    this.pastEventOccValue_ = value;
                }
            }
        }
        #endregion
        
        public string pastEventOccValueIDRef_ { get; set; }
        #region RefVariableFlag_eventOccDate_
        private XsdTypeToken refVariableFlag_eventOccDate_;
        public XsdTypeToken RefVariableFlag_eventOccDate_
        {
            get
            {
                if (this.refVariableFlag_eventOccDate_ != null)
                {
                    return this.refVariableFlag_eventOccDate_; 
                }
                else if (this.refVariableFlag_eventOccDateIDRef_ != null)
                {
                    refVariableFlag_eventOccDate_ = IDManager.getID(refVariableFlag_eventOccDateIDRef_) as XsdTypeToken;
                    return this.refVariableFlag_eventOccDate_; 
                }
                else
                {
                    throw new Exception( "refVariableFlag_eventOccDate_Node no exist!");
                }
            }
            set
            {
                if (this.refVariableFlag_eventOccDate_ != value)
                {
                    this.refVariableFlag_eventOccDate_ = value;
                }
            }
        }
        #endregion
        
        public string refVariableFlag_eventOccDateIDRef_ { get; set; }
        #region RefVariableFlag_eventOccValue_
        private XsdTypeToken refVariableFlag_eventOccValue_;
        public XsdTypeToken RefVariableFlag_eventOccValue_
        {
            get
            {
                if (this.refVariableFlag_eventOccValue_ != null)
                {
                    return this.refVariableFlag_eventOccValue_; 
                }
                else if (this.refVariableFlag_eventOccValueIDRef_ != null)
                {
                    refVariableFlag_eventOccValue_ = IDManager.getID(refVariableFlag_eventOccValueIDRef_) as XsdTypeToken;
                    return this.refVariableFlag_eventOccValue_; 
                }
                else
                {
                    throw new Exception( "refVariableFlag_eventOccValue_Node no exist!");
                }
            }
            set
            {
                if (this.refVariableFlag_eventOccValue_ != value)
                {
                    this.refVariableFlag_eventOccValue_ = value;
                }
            }
        }
        #endregion
        
        public string refVariableFlag_eventOccValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

