using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hifive : ISerialized
    {
        public Excel_hifive() { }
        public Excel_hifive(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_issueInfoNode = xmlNode.SelectSingleNode("excel_issueInfo");
            
            if (excel_issueInfoNode != null)
            {
                if (excel_issueInfoNode.Attributes["href"] != null || excel_issueInfoNode.Attributes["id"] != null) 
                {
                    if (excel_issueInfoNode.Attributes["id"] != null) 
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["id"].Value;
                        Excel_issueInfo ob = new Excel_issueInfo(excel_issueInfoNode);
                        IDManager.SetID(excel_issueInfoIDRef_, ob);
                    }
                    else if (excel_issueInfoNode.Attributes["href"] != null)
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                    }
                }
                else
                {
                    excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcInfoNode = xmlNode.SelectSingleNode("excel_underlyingCalcInfo");
            
            if (excel_underlyingCalcInfoNode != null)
            {
                if (excel_underlyingCalcInfoNode.Attributes["href"] != null || excel_underlyingCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcInfoIDRef_ = excel_underlyingCalcInfoNode.Attributes["id"].Value;
                        Excel_underlyingCalcInfo ob = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                        IDManager.SetID(excel_underlyingCalcInfoIDRef_, ob);
                    }
                    else if (excel_underlyingCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcInfoIDRef_ = excel_underlyingCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcInfo_ = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                    }
                }
                else
                {
                    excel_underlyingCalcInfo_ = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                }
            }
            
        
            XmlNode excel_hifive_subtypeNode = xmlNode.SelectSingleNode("excel_hifive_subtype");
            
            if (excel_hifive_subtypeNode != null)
            {
                if (excel_hifive_subtypeNode.Attributes["href"] != null || excel_hifive_subtypeNode.Attributes["id"] != null) 
                {
                    if (excel_hifive_subtypeNode.Attributes["id"] != null) 
                    {
                        excel_hifive_subtypeIDRef_ = excel_hifive_subtypeNode.Attributes["id"].Value;
                        Excel_hifive_subtype ob = new Excel_hifive_subtype(excel_hifive_subtypeNode);
                        IDManager.SetID(excel_hifive_subtypeIDRef_, ob);
                    }
                    else if (excel_hifive_subtypeNode.Attributes["href"] != null)
                    {
                        excel_hifive_subtypeIDRef_ = excel_hifive_subtypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hifive_subtype_ = new Excel_hifive_subtype(excel_hifive_subtypeNode);
                    }
                }
                else
                {
                    excel_hifive_subtype_ = new Excel_hifive_subtype(excel_hifive_subtypeNode);
                }
            }
            
        
            XmlNode excel_scheduleListNode = xmlNode.SelectSingleNode("excel_scheduleList");
            
            if (excel_scheduleListNode != null)
            {
                if (excel_scheduleListNode.Attributes["href"] != null || excel_scheduleListNode.Attributes["id"] != null) 
                {
                    if (excel_scheduleListNode.Attributes["id"] != null) 
                    {
                        excel_scheduleListIDRef_ = excel_scheduleListNode.Attributes["id"].Value;
                        Excel_scheduleList ob = new Excel_scheduleList(excel_scheduleListNode);
                        IDManager.SetID(excel_scheduleListIDRef_, ob);
                    }
                    else if (excel_scheduleListNode.Attributes["href"] != null)
                    {
                        excel_scheduleListIDRef_ = excel_scheduleListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_scheduleList_ = new Excel_scheduleList(excel_scheduleListNode);
                    }
                }
                else
                {
                    excel_scheduleList_ = new Excel_scheduleList(excel_scheduleListNode);
                }
            }
            
        
            XmlNode excel_kiEventCalculationNode = xmlNode.SelectSingleNode("excel_kiEventCalculation");
            
            if (excel_kiEventCalculationNode != null)
            {
                if (excel_kiEventCalculationNode.Attributes["href"] != null || excel_kiEventCalculationNode.Attributes["id"] != null) 
                {
                    if (excel_kiEventCalculationNode.Attributes["id"] != null) 
                    {
                        excel_kiEventCalculationIDRef_ = excel_kiEventCalculationNode.Attributes["id"].Value;
                        Excel_kiEventCalculation ob = new Excel_kiEventCalculation(excel_kiEventCalculationNode);
                        IDManager.SetID(excel_kiEventCalculationIDRef_, ob);
                    }
                    else if (excel_kiEventCalculationNode.Attributes["href"] != null)
                    {
                        excel_kiEventCalculationIDRef_ = excel_kiEventCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_kiEventCalculation_ = new Excel_kiEventCalculation(excel_kiEventCalculationNode);
                    }
                }
                else
                {
                    excel_kiEventCalculation_ = new Excel_kiEventCalculation(excel_kiEventCalculationNode);
                }
            }
            
        
        }
        
    
        #region Excel_issueInfo_
        private Excel_issueInfo excel_issueInfo_;
        public Excel_issueInfo Excel_issueInfo_
        {
            get
            {
                if (this.excel_issueInfo_ != null)
                {
                    return this.excel_issueInfo_; 
                }
                else if (this.excel_issueInfoIDRef_ != null)
                {
                    excel_issueInfo_ = IDManager.getID(excel_issueInfoIDRef_) as Excel_issueInfo;
                    return this.excel_issueInfo_; 
                }
                else
                {
                    throw new Exception( "excel_issueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_issueInfo_ != value)
                {
                    this.excel_issueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_issueInfoIDRef_ { get; set; }
        #region Excel_underlyingCalcInfo_
        private Excel_underlyingCalcInfo excel_underlyingCalcInfo_;
        public Excel_underlyingCalcInfo Excel_underlyingCalcInfo_
        {
            get
            {
                if (this.excel_underlyingCalcInfo_ != null)
                {
                    return this.excel_underlyingCalcInfo_; 
                }
                else if (this.excel_underlyingCalcInfoIDRef_ != null)
                {
                    excel_underlyingCalcInfo_ = IDManager.getID(excel_underlyingCalcInfoIDRef_) as Excel_underlyingCalcInfo;
                    return this.excel_underlyingCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcInfo_ != value)
                {
                    this.excel_underlyingCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcInfoIDRef_ { get; set; }
        #region Excel_hifive_subtype_
        private Excel_hifive_subtype excel_hifive_subtype_;
        public Excel_hifive_subtype Excel_hifive_subtype_
        {
            get
            {
                if (this.excel_hifive_subtype_ != null)
                {
                    return this.excel_hifive_subtype_; 
                }
                else if (this.excel_hifive_subtypeIDRef_ != null)
                {
                    excel_hifive_subtype_ = IDManager.getID(excel_hifive_subtypeIDRef_) as Excel_hifive_subtype;
                    return this.excel_hifive_subtype_; 
                }
                else
                {
                    throw new Exception( "excel_hifive_subtype_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hifive_subtype_ != value)
                {
                    this.excel_hifive_subtype_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hifive_subtypeIDRef_ { get; set; }
        #region Excel_scheduleList_
        private Excel_scheduleList excel_scheduleList_;
        public Excel_scheduleList Excel_scheduleList_
        {
            get
            {
                if (this.excel_scheduleList_ != null)
                {
                    return this.excel_scheduleList_; 
                }
                else if (this.excel_scheduleListIDRef_ != null)
                {
                    excel_scheduleList_ = IDManager.getID(excel_scheduleListIDRef_) as Excel_scheduleList;
                    return this.excel_scheduleList_; 
                }
                else
                {
                    throw new Exception( "excel_scheduleList_Node no exist!");
                }
            }
            set
            {
                if (this.excel_scheduleList_ != value)
                {
                    this.excel_scheduleList_ = value;
                }
            }
        }
        #endregion
        
        public string excel_scheduleListIDRef_ { get; set; }
        #region Excel_kiEventCalculation_
        private Excel_kiEventCalculation excel_kiEventCalculation_;
        public Excel_kiEventCalculation Excel_kiEventCalculation_
        {
            get
            {
                if (this.excel_kiEventCalculation_ != null)
                {
                    return this.excel_kiEventCalculation_; 
                }
                else if (this.excel_kiEventCalculationIDRef_ != null)
                {
                    excel_kiEventCalculation_ = IDManager.getID(excel_kiEventCalculationIDRef_) as Excel_kiEventCalculation;
                    return this.excel_kiEventCalculation_; 
                }
                else
                {
                    throw new Exception( "excel_kiEventCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_kiEventCalculation_ != value)
                {
                    this.excel_kiEventCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_kiEventCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

