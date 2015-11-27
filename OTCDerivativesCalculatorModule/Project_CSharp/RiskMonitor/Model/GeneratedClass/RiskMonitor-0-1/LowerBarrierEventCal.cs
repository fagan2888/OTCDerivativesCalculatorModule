using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LowerBarrierEventCal : ISerialized
    {
        public LowerBarrierEventCal() { }
        public LowerBarrierEventCal(XmlNode xmlNode)
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

