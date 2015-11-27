using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_structuredBond : ISerialized
    {
        public Excel_structuredBond() { }
        public Excel_structuredBond(XmlNode xmlNode)
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
            
        
            XmlNode excel_couponScheduleListNode = xmlNode.SelectSingleNode("excel_couponScheduleList");
            
            if (excel_couponScheduleListNode != null)
            {
                if (excel_couponScheduleListNode.Attributes["href"] != null || excel_couponScheduleListNode.Attributes["id"] != null) 
                {
                    if (excel_couponScheduleListNode.Attributes["id"] != null) 
                    {
                        excel_couponScheduleListIDRef_ = excel_couponScheduleListNode.Attributes["id"].Value;
                        Excel_couponScheduleList ob = new Excel_couponScheduleList(excel_couponScheduleListNode);
                        IDManager.SetID(excel_couponScheduleListIDRef_, ob);
                    }
                    else if (excel_couponScheduleListNode.Attributes["href"] != null)
                    {
                        excel_couponScheduleListIDRef_ = excel_couponScheduleListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_couponScheduleList_ = new Excel_couponScheduleList(excel_couponScheduleListNode);
                    }
                }
                else
                {
                    excel_couponScheduleList_ = new Excel_couponScheduleList(excel_couponScheduleListNode);
                }
            }
            
        
            XmlNode excel_structuredBond_subtypeNode = xmlNode.SelectSingleNode("excel_structuredBond_subtype");
            
            if (excel_structuredBond_subtypeNode != null)
            {
                if (excel_structuredBond_subtypeNode.Attributes["href"] != null || excel_structuredBond_subtypeNode.Attributes["id"] != null) 
                {
                    if (excel_structuredBond_subtypeNode.Attributes["id"] != null) 
                    {
                        excel_structuredBond_subtypeIDRef_ = excel_structuredBond_subtypeNode.Attributes["id"].Value;
                        Excel_structuredBond_subtype ob = new Excel_structuredBond_subtype(excel_structuredBond_subtypeNode);
                        IDManager.SetID(excel_structuredBond_subtypeIDRef_, ob);
                    }
                    else if (excel_structuredBond_subtypeNode.Attributes["href"] != null)
                    {
                        excel_structuredBond_subtypeIDRef_ = excel_structuredBond_subtypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredBond_subtype_ = new Excel_structuredBond_subtype(excel_structuredBond_subtypeNode);
                    }
                }
                else
                {
                    excel_structuredBond_subtype_ = new Excel_structuredBond_subtype(excel_structuredBond_subtypeNode);
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
        #region Excel_couponScheduleList_
        private Excel_couponScheduleList excel_couponScheduleList_;
        public Excel_couponScheduleList Excel_couponScheduleList_
        {
            get
            {
                if (this.excel_couponScheduleList_ != null)
                {
                    return this.excel_couponScheduleList_; 
                }
                else if (this.excel_couponScheduleListIDRef_ != null)
                {
                    excel_couponScheduleList_ = IDManager.getID(excel_couponScheduleListIDRef_) as Excel_couponScheduleList;
                    return this.excel_couponScheduleList_; 
                }
                else
                {
                    throw new Exception( "excel_couponScheduleList_Node no exist!");
                }
            }
            set
            {
                if (this.excel_couponScheduleList_ != value)
                {
                    this.excel_couponScheduleList_ = value;
                }
            }
        }
        #endregion
        
        public string excel_couponScheduleListIDRef_ { get; set; }
        #region Excel_structuredBond_subtype_
        private Excel_structuredBond_subtype excel_structuredBond_subtype_;
        public Excel_structuredBond_subtype Excel_structuredBond_subtype_
        {
            get
            {
                if (this.excel_structuredBond_subtype_ != null)
                {
                    return this.excel_structuredBond_subtype_; 
                }
                else if (this.excel_structuredBond_subtypeIDRef_ != null)
                {
                    excel_structuredBond_subtype_ = IDManager.getID(excel_structuredBond_subtypeIDRef_) as Excel_structuredBond_subtype;
                    return this.excel_structuredBond_subtype_; 
                }
                else
                {
                    throw new Exception( "excel_structuredBond_subtype_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredBond_subtype_ != value)
                {
                    this.excel_structuredBond_subtype_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredBond_subtypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

