using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_counterUnderlyingCalcInfo : ISerialized
    {
        public Excel_counterUnderlyingCalcInfo() { }
        public Excel_counterUnderlyingCalcInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}

