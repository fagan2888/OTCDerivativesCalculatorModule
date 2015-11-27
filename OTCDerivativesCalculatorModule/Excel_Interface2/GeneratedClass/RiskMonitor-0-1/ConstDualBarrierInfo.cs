using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConstDualBarrierInfo : ISerialized
    {
        public ConstDualBarrierInfo() { }
        public ConstDualBarrierInfo(XmlNode xmlNode)
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
            
        
            XmlNode upperTriggerNode = xmlNode.SelectSingleNode("upperTrigger");
            
            if (upperTriggerNode != null)
            {
                if (upperTriggerNode.Attributes["href"] != null || upperTriggerNode.Attributes["id"] != null) 
                {
                    if (upperTriggerNode.Attributes["id"] != null) 
                    {
                        upperTriggerIDRef_ = upperTriggerNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(upperTriggerNode);
                        IDManager.SetID(upperTriggerIDRef_, ob);
                    }
                    else if (upperTriggerNode.Attributes["href"] != null)
                    {
                        upperTriggerIDRef_ = upperTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperTrigger_ = new XsdTypeDouble(upperTriggerNode);
                    }
                }
                else
                {
                    upperTrigger_ = new XsdTypeDouble(upperTriggerNode);
                }
            }
            
        
            XmlNode lowerTriggerNode = xmlNode.SelectSingleNode("lowerTrigger");
            
            if (lowerTriggerNode != null)
            {
                if (lowerTriggerNode.Attributes["href"] != null || lowerTriggerNode.Attributes["id"] != null) 
                {
                    if (lowerTriggerNode.Attributes["id"] != null) 
                    {
                        lowerTriggerIDRef_ = lowerTriggerNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(lowerTriggerNode);
                        IDManager.SetID(lowerTriggerIDRef_, ob);
                    }
                    else if (lowerTriggerNode.Attributes["href"] != null)
                    {
                        lowerTriggerIDRef_ = lowerTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerTrigger_ = new XsdTypeDouble(lowerTriggerNode);
                    }
                }
                else
                {
                    lowerTrigger_ = new XsdTypeDouble(lowerTriggerNode);
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
        #region UpperTrigger_
        private XsdTypeDouble upperTrigger_;
        public XsdTypeDouble UpperTrigger_
        {
            get
            {
                if (this.upperTrigger_ != null)
                {
                    return this.upperTrigger_; 
                }
                else if (this.upperTriggerIDRef_ != null)
                {
                    upperTrigger_ = IDManager.getID(upperTriggerIDRef_) as XsdTypeDouble;
                    return this.upperTrigger_; 
                }
                else
                {
                    throw new Exception( "upperTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string upperTriggerIDRef_ { get; set; }
        #region LowerTrigger_
        private XsdTypeDouble lowerTrigger_;
        public XsdTypeDouble LowerTrigger_
        {
            get
            {
                if (this.lowerTrigger_ != null)
                {
                    return this.lowerTrigger_; 
                }
                else if (this.lowerTriggerIDRef_ != null)
                {
                    lowerTrigger_ = IDManager.getID(lowerTriggerIDRef_) as XsdTypeDouble;
                    return this.lowerTrigger_; 
                }
                else
                {
                    throw new Exception( "lowerTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string lowerTriggerIDRef_ { get; set; }
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

