using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_eventCalcInfo_Call : ISerialized
    {
        public Excel_eventCalcInfo_Call() { }
        public Excel_eventCalcInfo_Call(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_eventCalcInfoNode = xmlNode.SelectSingleNode("excel_eventCalcInfo");
            
            if (excel_eventCalcInfoNode != null)
            {
                if (excel_eventCalcInfoNode.Attributes["href"] != null || excel_eventCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_eventCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_eventCalcInfoIDRef_ = excel_eventCalcInfoNode.Attributes["id"].Value;
                        Excel_eventCalcInfo ob = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                        IDManager.SetID(excel_eventCalcInfoIDRef_, ob);
                    }
                    else if (excel_eventCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_eventCalcInfoIDRef_ = excel_eventCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_eventCalcInfo_ = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                    }
                }
                else
                {
                    excel_eventCalcInfo_ = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                }
            }
            
        
        }
        
    
        #region Excel_eventCalcInfo_
        private Excel_eventCalcInfo excel_eventCalcInfo_;
        public Excel_eventCalcInfo Excel_eventCalcInfo_
        {
            get
            {
                if (this.excel_eventCalcInfo_ != null)
                {
                    return this.excel_eventCalcInfo_; 
                }
                else if (this.excel_eventCalcInfoIDRef_ != null)
                {
                    excel_eventCalcInfo_ = IDManager.getID(excel_eventCalcInfoIDRef_) as Excel_eventCalcInfo;
                    return this.excel_eventCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_eventCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_eventCalcInfo_ != value)
                {
                    this.excel_eventCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_eventCalcInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

