using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingBond : ISerialized
    {
        public Excel_vanillaFloatingBond() { }
        public Excel_vanillaFloatingBond(XmlNode xmlNode)
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
            
        
            XmlNode excel_vanillaFloatingCouponScheduleListNode = xmlNode.SelectSingleNode("excel_vanillaFloatingCouponScheduleList");
            
            if (excel_vanillaFloatingCouponScheduleListNode != null)
            {
                if (excel_vanillaFloatingCouponScheduleListNode.Attributes["href"] != null || excel_vanillaFloatingCouponScheduleListNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingCouponScheduleListNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingCouponScheduleListIDRef_ = excel_vanillaFloatingCouponScheduleListNode.Attributes["id"].Value;
                        Excel_vanillaFloatingCouponScheduleList ob = new Excel_vanillaFloatingCouponScheduleList(excel_vanillaFloatingCouponScheduleListNode);
                        IDManager.SetID(excel_vanillaFloatingCouponScheduleListIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingCouponScheduleListNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingCouponScheduleListIDRef_ = excel_vanillaFloatingCouponScheduleListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingCouponScheduleList_ = new Excel_vanillaFloatingCouponScheduleList(excel_vanillaFloatingCouponScheduleListNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingCouponScheduleList_ = new Excel_vanillaFloatingCouponScheduleList(excel_vanillaFloatingCouponScheduleListNode);
                }
            }
            
        
            XmlNode excel_vanillaFloatingBond_subtypeNode = xmlNode.SelectSingleNode("excel_vanillaFloatingBond_subtype");
            
            if (excel_vanillaFloatingBond_subtypeNode != null)
            {
                if (excel_vanillaFloatingBond_subtypeNode.Attributes["href"] != null || excel_vanillaFloatingBond_subtypeNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingBond_subtypeNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingBond_subtypeIDRef_ = excel_vanillaFloatingBond_subtypeNode.Attributes["id"].Value;
                        Excel_vanillaFloatingBond_subtype ob = new Excel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypeNode);
                        IDManager.SetID(excel_vanillaFloatingBond_subtypeIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingBond_subtypeNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingBond_subtypeIDRef_ = excel_vanillaFloatingBond_subtypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingBond_subtype_ = new Excel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypeNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingBond_subtype_ = new Excel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypeNode);
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
        #region Excel_vanillaFloatingCouponScheduleList_
        private Excel_vanillaFloatingCouponScheduleList excel_vanillaFloatingCouponScheduleList_;
        public Excel_vanillaFloatingCouponScheduleList Excel_vanillaFloatingCouponScheduleList_
        {
            get
            {
                if (this.excel_vanillaFloatingCouponScheduleList_ != null)
                {
                    return this.excel_vanillaFloatingCouponScheduleList_; 
                }
                else if (this.excel_vanillaFloatingCouponScheduleListIDRef_ != null)
                {
                    excel_vanillaFloatingCouponScheduleList_ = IDManager.getID(excel_vanillaFloatingCouponScheduleListIDRef_) as Excel_vanillaFloatingCouponScheduleList;
                    return this.excel_vanillaFloatingCouponScheduleList_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingCouponScheduleList_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingCouponScheduleList_ != value)
                {
                    this.excel_vanillaFloatingCouponScheduleList_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingCouponScheduleListIDRef_ { get; set; }
        #region Excel_vanillaFloatingBond_subtype_
        private Excel_vanillaFloatingBond_subtype excel_vanillaFloatingBond_subtype_;
        public Excel_vanillaFloatingBond_subtype Excel_vanillaFloatingBond_subtype_
        {
            get
            {
                if (this.excel_vanillaFloatingBond_subtype_ != null)
                {
                    return this.excel_vanillaFloatingBond_subtype_; 
                }
                else if (this.excel_vanillaFloatingBond_subtypeIDRef_ != null)
                {
                    excel_vanillaFloatingBond_subtype_ = IDManager.getID(excel_vanillaFloatingBond_subtypeIDRef_) as Excel_vanillaFloatingBond_subtype;
                    return this.excel_vanillaFloatingBond_subtype_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingBond_subtype_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingBond_subtype_ != value)
                {
                    this.excel_vanillaFloatingBond_subtype_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingBond_subtypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

