using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaReturnCal : ISerialized
    {
        public VanillaReturnCal() { }
        public VanillaReturnCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode gearingNode = xmlNode.SelectSingleNode("gearing");
            
            if (gearingNode != null)
            {
                if (gearingNode.Attributes["href"] != null || gearingNode.Attributes["id"] != null) 
                {
                    if (gearingNode.Attributes["id"] != null) 
                    {
                        gearingIDRef_ = gearingNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeDouble(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeDouble(gearingNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDouble(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDouble(spreadNode);
                }
            }
            
        
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
            
        
        }
        
    
        #region Gearing_
        private XsdTypeDouble gearing_;
        public XsdTypeDouble Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeDouble;
                    return this.gearing_; 
                }
                else
                {
                    throw new Exception( "gearing_Node no exist!");
                }
            }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                }
            }
        }
        #endregion
        
        public string gearingIDRef_ { get; set; }
        #region Spread_
        private XsdTypeDouble spread_;
        public XsdTypeDouble Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDouble;
                    return this.spread_; 
                }
                else
                {
                    throw new Exception( "spread_Node no exist!");
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

