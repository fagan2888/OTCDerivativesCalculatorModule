using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UpperBarrierEventCal : ISerialized
    {
        public UpperBarrierEventCal() { }
        public UpperBarrierEventCal(XmlNode xmlNode)
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

