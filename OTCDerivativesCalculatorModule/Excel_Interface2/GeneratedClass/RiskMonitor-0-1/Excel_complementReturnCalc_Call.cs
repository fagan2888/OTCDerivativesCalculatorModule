using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_complementReturnCalc_Call : ISerialized
    {
        public Excel_complementReturnCalc_Call() { }
        public Excel_complementReturnCalc_Call(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_returnCalcInfoNode = xmlNode.SelectSingleNode("excel_returnCalcInfo");
            
            if (excel_returnCalcInfoNode != null)
            {
                if (excel_returnCalcInfoNode.Attributes["href"] != null || excel_returnCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_returnCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_returnCalcInfoIDRef_ = excel_returnCalcInfoNode.Attributes["id"].Value;
                        Excel_returnCalcInfo ob = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                        IDManager.SetID(excel_returnCalcInfoIDRef_, ob);
                    }
                    else if (excel_returnCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_returnCalcInfoIDRef_ = excel_returnCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_returnCalcInfo_ = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                    }
                }
                else
                {
                    excel_returnCalcInfo_ = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                }
            }
            
        
        }
        
    
        #region Excel_returnCalcInfo_
        private Excel_returnCalcInfo excel_returnCalcInfo_;
        public Excel_returnCalcInfo Excel_returnCalcInfo_
        {
            get
            {
                if (this.excel_returnCalcInfo_ != null)
                {
                    return this.excel_returnCalcInfo_; 
                }
                else if (this.excel_returnCalcInfoIDRef_ != null)
                {
                    excel_returnCalcInfo_ = IDManager.getID(excel_returnCalcInfoIDRef_) as Excel_returnCalcInfo;
                    return this.excel_returnCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_returnCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_returnCalcInfo_ != value)
                {
                    this.excel_returnCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_returnCalcInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

