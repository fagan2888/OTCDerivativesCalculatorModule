using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_creditEventSwapLeg : ISerialized
    {
        public Excel_creditEventSwapLeg() { }
        public Excel_creditEventSwapLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_creditEventInfoNode = xmlNode.SelectSingleNode("excel_creditEventInfo");
            
            if (excel_creditEventInfoNode != null)
            {
                if (excel_creditEventInfoNode.Attributes["href"] != null || excel_creditEventInfoNode.Attributes["id"] != null) 
                {
                    if (excel_creditEventInfoNode.Attributes["id"] != null) 
                    {
                        excel_creditEventInfoIDRef_ = excel_creditEventInfoNode.Attributes["id"].Value;
                        Excel_creditEventInfo ob = new Excel_creditEventInfo(excel_creditEventInfoNode);
                        IDManager.SetID(excel_creditEventInfoIDRef_, ob);
                    }
                    else if (excel_creditEventInfoNode.Attributes["href"] != null)
                    {
                        excel_creditEventInfoIDRef_ = excel_creditEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_creditEventInfo_ = new Excel_creditEventInfo(excel_creditEventInfoNode);
                    }
                }
                else
                {
                    excel_creditEventInfo_ = new Excel_creditEventInfo(excel_creditEventInfoNode);
                }
            }
            
        
        }
        
    
        #region Excel_creditEventInfo_
        private Excel_creditEventInfo excel_creditEventInfo_;
        public Excel_creditEventInfo Excel_creditEventInfo_
        {
            get
            {
                if (this.excel_creditEventInfo_ != null)
                {
                    return this.excel_creditEventInfo_; 
                }
                else if (this.excel_creditEventInfoIDRef_ != null)
                {
                    excel_creditEventInfo_ = IDManager.getID(excel_creditEventInfoIDRef_) as Excel_creditEventInfo;
                    return this.excel_creditEventInfo_; 
                }
                else
                {
                    throw new Exception( "excel_creditEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_creditEventInfo_ != value)
                {
                    this.excel_creditEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_creditEventInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

