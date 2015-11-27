using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedBond : ISerialized
    {
        public Excel_fixedBond() { }
        public Excel_fixedBond(XmlNode xmlNode)
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
            
        
            XmlNode excel_fixedCouponScheduleListNode = xmlNode.SelectSingleNode("excel_fixedCouponScheduleList");
            
            if (excel_fixedCouponScheduleListNode != null)
            {
                if (excel_fixedCouponScheduleListNode.Attributes["href"] != null || excel_fixedCouponScheduleListNode.Attributes["id"] != null) 
                {
                    if (excel_fixedCouponScheduleListNode.Attributes["id"] != null) 
                    {
                        excel_fixedCouponScheduleListIDRef_ = excel_fixedCouponScheduleListNode.Attributes["id"].Value;
                        Excel_fixedCouponScheduleList ob = new Excel_fixedCouponScheduleList(excel_fixedCouponScheduleListNode);
                        IDManager.SetID(excel_fixedCouponScheduleListIDRef_, ob);
                    }
                    else if (excel_fixedCouponScheduleListNode.Attributes["href"] != null)
                    {
                        excel_fixedCouponScheduleListIDRef_ = excel_fixedCouponScheduleListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedCouponScheduleList_ = new Excel_fixedCouponScheduleList(excel_fixedCouponScheduleListNode);
                    }
                }
                else
                {
                    excel_fixedCouponScheduleList_ = new Excel_fixedCouponScheduleList(excel_fixedCouponScheduleListNode);
                }
            }
            
        
            XmlNode excel_fixedBond_subtypeNode = xmlNode.SelectSingleNode("excel_fixedBond_subtype");
            
            if (excel_fixedBond_subtypeNode != null)
            {
                if (excel_fixedBond_subtypeNode.Attributes["href"] != null || excel_fixedBond_subtypeNode.Attributes["id"] != null) 
                {
                    if (excel_fixedBond_subtypeNode.Attributes["id"] != null) 
                    {
                        excel_fixedBond_subtypeIDRef_ = excel_fixedBond_subtypeNode.Attributes["id"].Value;
                        Excel_fixedBond_subtype ob = new Excel_fixedBond_subtype(excel_fixedBond_subtypeNode);
                        IDManager.SetID(excel_fixedBond_subtypeIDRef_, ob);
                    }
                    else if (excel_fixedBond_subtypeNode.Attributes["href"] != null)
                    {
                        excel_fixedBond_subtypeIDRef_ = excel_fixedBond_subtypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedBond_subtype_ = new Excel_fixedBond_subtype(excel_fixedBond_subtypeNode);
                    }
                }
                else
                {
                    excel_fixedBond_subtype_ = new Excel_fixedBond_subtype(excel_fixedBond_subtypeNode);
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
        #region Excel_fixedCouponScheduleList_
        private Excel_fixedCouponScheduleList excel_fixedCouponScheduleList_;
        public Excel_fixedCouponScheduleList Excel_fixedCouponScheduleList_
        {
            get
            {
                if (this.excel_fixedCouponScheduleList_ != null)
                {
                    return this.excel_fixedCouponScheduleList_; 
                }
                else if (this.excel_fixedCouponScheduleListIDRef_ != null)
                {
                    excel_fixedCouponScheduleList_ = IDManager.getID(excel_fixedCouponScheduleListIDRef_) as Excel_fixedCouponScheduleList;
                    return this.excel_fixedCouponScheduleList_; 
                }
                else
                {
                    throw new Exception( "excel_fixedCouponScheduleList_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedCouponScheduleList_ != value)
                {
                    this.excel_fixedCouponScheduleList_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedCouponScheduleListIDRef_ { get; set; }
        #region Excel_fixedBond_subtype_
        private Excel_fixedBond_subtype excel_fixedBond_subtype_;
        public Excel_fixedBond_subtype Excel_fixedBond_subtype_
        {
            get
            {
                if (this.excel_fixedBond_subtype_ != null)
                {
                    return this.excel_fixedBond_subtype_; 
                }
                else if (this.excel_fixedBond_subtypeIDRef_ != null)
                {
                    excel_fixedBond_subtype_ = IDManager.getID(excel_fixedBond_subtypeIDRef_) as Excel_fixedBond_subtype;
                    return this.excel_fixedBond_subtype_; 
                }
                else
                {
                    throw new Exception( "excel_fixedBond_subtype_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedBond_subtype_ != value)
                {
                    this.excel_fixedBond_subtype_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedBond_subtypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

