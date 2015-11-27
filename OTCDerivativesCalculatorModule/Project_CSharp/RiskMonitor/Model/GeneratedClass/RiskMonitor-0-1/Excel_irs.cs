using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_irs : ISerialized
    {
        public Excel_irs() { }
        public Excel_irs(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_counterUnderlyingCalcInfoNode = xmlNode.SelectSingleNode("excel_counterUnderlyingCalcInfo");
            
            if (excel_counterUnderlyingCalcInfoNode != null)
            {
                if (excel_counterUnderlyingCalcInfoNode.Attributes["href"] != null || excel_counterUnderlyingCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_counterUnderlyingCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_counterUnderlyingCalcInfoIDRef_ = excel_counterUnderlyingCalcInfoNode.Attributes["id"].Value;
                        Excel_counterUnderlyingCalcInfo ob = new Excel_counterUnderlyingCalcInfo(excel_counterUnderlyingCalcInfoNode);
                        IDManager.SetID(excel_counterUnderlyingCalcInfoIDRef_, ob);
                    }
                    else if (excel_counterUnderlyingCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_counterUnderlyingCalcInfoIDRef_ = excel_counterUnderlyingCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_counterUnderlyingCalcInfo_ = new Excel_counterUnderlyingCalcInfo(excel_counterUnderlyingCalcInfoNode);
                    }
                }
                else
                {
                    excel_counterUnderlyingCalcInfo_ = new Excel_counterUnderlyingCalcInfo(excel_counterUnderlyingCalcInfoNode);
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
        
    
        #region Excel_counterUnderlyingCalcInfo_
        private Excel_counterUnderlyingCalcInfo excel_counterUnderlyingCalcInfo_;
        public Excel_counterUnderlyingCalcInfo Excel_counterUnderlyingCalcInfo_
        {
            get
            {
                if (this.excel_counterUnderlyingCalcInfo_ != null)
                {
                    return this.excel_counterUnderlyingCalcInfo_; 
                }
                else if (this.excel_counterUnderlyingCalcInfoIDRef_ != null)
                {
                    excel_counterUnderlyingCalcInfo_ = IDManager.getID(excel_counterUnderlyingCalcInfoIDRef_) as Excel_counterUnderlyingCalcInfo;
                    return this.excel_counterUnderlyingCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_counterUnderlyingCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_counterUnderlyingCalcInfo_ != value)
                {
                    this.excel_counterUnderlyingCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_counterUnderlyingCalcInfoIDRef_ { get; set; }
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

