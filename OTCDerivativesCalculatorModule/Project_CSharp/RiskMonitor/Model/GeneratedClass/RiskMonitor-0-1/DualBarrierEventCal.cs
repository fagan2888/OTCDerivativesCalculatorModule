using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DualBarrierEventCal : ISerialized
    {
        public DualBarrierEventCal() { }
        public DualBarrierEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dateInformationNodeList = xmlNode.SelectNodes("dateInformation");
            
            if (dateInformationNodeList != null)
            {
                this.dateInformation_ = new List<DateInformation>();
                foreach (XmlNode item in dateInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dateInformationIDRef_ = item.Attributes["id"].Value;
                            dateInformation_.Add(new DateInformation(item));
                            IDManager.SetID(dateInformationIDRef_, dateInformation_[dateInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dateInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dateInformation_.Add(new DateInformation(item));
                        }
                    }
                    else
                    {
                        dateInformation_.Add(new DateInformation(item));
                    }
                }
            }
            
        
            XmlNodeList upperTriggerNodeList = xmlNode.SelectNodes("upperTrigger");
            
            if (upperTriggerNodeList != null)
            {
                this.upperTrigger_ = new List<XsdTypeDouble>();
                foreach (XmlNode item in upperTriggerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            upperTriggerIDRef_ = item.Attributes["id"].Value;
                            upperTrigger_.Add(new XsdTypeDouble(item));
                            IDManager.SetID(upperTriggerIDRef_, upperTrigger_[upperTrigger_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            upperTriggerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        upperTrigger_.Add(new XsdTypeDouble(item));
                        }
                    }
                    else
                    {
                        upperTrigger_.Add(new XsdTypeDouble(item));
                    }
                }
            }
            
        
            XmlNodeList lowerTriggerNodeList = xmlNode.SelectNodes("lowerTrigger");
            
            if (lowerTriggerNodeList != null)
            {
                this.lowerTrigger_ = new List<XsdTypeDouble>();
                foreach (XmlNode item in lowerTriggerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            lowerTriggerIDRef_ = item.Attributes["id"].Value;
                            lowerTrigger_.Add(new XsdTypeDouble(item));
                            IDManager.SetID(lowerTriggerIDRef_, lowerTrigger_[lowerTrigger_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            lowerTriggerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        lowerTrigger_.Add(new XsdTypeDouble(item));
                        }
                    }
                    else
                    {
                        lowerTrigger_.Add(new XsdTypeDouble(item));
                    }
                }
            }
            
        
            XmlNodeList referenceCalculationInfoNodeList = xmlNode.SelectNodes("referenceCalculationInfo");
            
            if (referenceCalculationInfoNodeList != null)
            {
                this.referenceCalculationInfo_ = new List<ReferenceCalculationInfo>();
                foreach (XmlNode item in referenceCalculationInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceCalculationInfoIDRef_ = item.Attributes["id"].Value;
                            referenceCalculationInfo_.Add(new ReferenceCalculationInfo(item));
                            IDManager.SetID(referenceCalculationInfoIDRef_, referenceCalculationInfo_[referenceCalculationInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceCalculationInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceCalculationInfo_.Add(new ReferenceCalculationInfo(item));
                        }
                    }
                    else
                    {
                        referenceCalculationInfo_.Add(new ReferenceCalculationInfo(item));
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
            
        
        }
        
    
        #region DateInformation_
        private List<DateInformation> dateInformation_;
        public List<DateInformation> DateInformation_
        {
            get
            {
                if (this.dateInformation_ != null)
                {
                    return this.dateInformation_; 
                }
                else if (this.dateInformationIDRef_ != null)
                {
                    return this.dateInformation_; 
                }
                else
                {
                    throw new Exception( "dateInformation_Node no exist!");
                }
            }
            set
            {
                if (this.dateInformation_ != value)
                {
                    this.dateInformation_ = value;
                }
            }
        }
        #endregion
        
        public string dateInformationIDRef_ { get; set; }
        #region UpperTrigger_
        private List<XsdTypeDouble> upperTrigger_;
        public List<XsdTypeDouble> UpperTrigger_
        {
            get
            {
                if (this.upperTrigger_ != null)
                {
                    return this.upperTrigger_; 
                }
                else if (this.upperTriggerIDRef_ != null)
                {
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
        private List<XsdTypeDouble> lowerTrigger_;
        public List<XsdTypeDouble> LowerTrigger_
        {
            get
            {
                if (this.lowerTrigger_ != null)
                {
                    return this.lowerTrigger_; 
                }
                else if (this.lowerTriggerIDRef_ != null)
                {
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
        #region ReferenceCalculationInfo_
        private List<ReferenceCalculationInfo> referenceCalculationInfo_;
        public List<ReferenceCalculationInfo> ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
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
        
    
        
    
    }
    
}

