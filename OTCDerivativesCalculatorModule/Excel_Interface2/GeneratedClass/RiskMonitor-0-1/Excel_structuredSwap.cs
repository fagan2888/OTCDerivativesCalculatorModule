using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_structuredSwap : ISerialized
    {
        public Excel_structuredSwap() { }
        public Excel_structuredSwap(XmlNode xmlNode)
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
            
        
            XmlNodeList excel_swapLegNodeList = xmlNode.SelectNodes("excel_swapLeg");
            
            if (excel_swapLegNodeList != null)
            {
                this.excel_swapLeg_ = new List<Excel_swapLeg>();
                foreach (XmlNode item in excel_swapLegNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_swapLegIDRef_ = item.Attributes["id"].Value;
                            excel_swapLeg_.Add(new Excel_swapLeg(item));
                            IDManager.SetID(excel_swapLegIDRef_, excel_swapLeg_[excel_swapLeg_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_swapLegIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_swapLeg_.Add(new Excel_swapLeg(item));
                        }
                    }
                    else
                    {
                        excel_swapLeg_.Add(new Excel_swapLeg(item));
                    }
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
        #region Excel_swapLeg_
        private List<Excel_swapLeg> excel_swapLeg_;
        public List<Excel_swapLeg> Excel_swapLeg_
        {
            get
            {
                if (this.excel_swapLeg_ != null)
                {
                    return this.excel_swapLeg_; 
                }
                else if (this.excel_swapLegIDRef_ != null)
                {
                    return this.excel_swapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_swapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapLeg_ != value)
                {
                    this.excel_swapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapLegIDRef_ { get; set; }
        
    
        
    
    }
    
}

