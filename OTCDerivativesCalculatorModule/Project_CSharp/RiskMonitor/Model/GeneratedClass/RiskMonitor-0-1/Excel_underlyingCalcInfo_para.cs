using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingCalcInfo_para : ISerialized
    {
        public Excel_underlyingCalcInfo_para() { }
        public Excel_underlyingCalcInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_underlyingInfo_paraNodeList = xmlNode.SelectNodes("excel_underlyingInfo_para");
            
            if (excel_underlyingInfo_paraNodeList != null)
            {
                this.excel_underlyingInfo_para_ = new List<Excel_underlyingInfo_para>();
                foreach (XmlNode item in excel_underlyingInfo_paraNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_underlyingInfo_paraIDRef_ = item.Attributes["id"].Value;
                            excel_underlyingInfo_para_.Add(new Excel_underlyingInfo_para(item));
                            IDManager.SetID(excel_underlyingInfo_paraIDRef_, excel_underlyingInfo_para_[excel_underlyingInfo_para_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_underlyingInfo_paraIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_underlyingInfo_para_.Add(new Excel_underlyingInfo_para(item));
                        }
                    }
                    else
                    {
                        excel_underlyingInfo_para_.Add(new Excel_underlyingInfo_para(item));
                    }
                }
            }
            
        
            XmlNode excel_correlationInfo_paraNode = xmlNode.SelectSingleNode("excel_correlationInfo_para");
            
            if (excel_correlationInfo_paraNode != null)
            {
                if (excel_correlationInfo_paraNode.Attributes["href"] != null || excel_correlationInfo_paraNode.Attributes["id"] != null) 
                {
                    if (excel_correlationInfo_paraNode.Attributes["id"] != null) 
                    {
                        excel_correlationInfo_paraIDRef_ = excel_correlationInfo_paraNode.Attributes["id"].Value;
                        Excel_correlationInfo_para ob = new Excel_correlationInfo_para(excel_correlationInfo_paraNode);
                        IDManager.SetID(excel_correlationInfo_paraIDRef_, ob);
                    }
                    else if (excel_correlationInfo_paraNode.Attributes["href"] != null)
                    {
                        excel_correlationInfo_paraIDRef_ = excel_correlationInfo_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_correlationInfo_para_ = new Excel_correlationInfo_para(excel_correlationInfo_paraNode);
                    }
                }
                else
                {
                    excel_correlationInfo_para_ = new Excel_correlationInfo_para(excel_correlationInfo_paraNode);
                }
            }
            
        
        }
        
    
        #region Excel_underlyingInfo_para_
        private List<Excel_underlyingInfo_para> excel_underlyingInfo_para_;
        public List<Excel_underlyingInfo_para> Excel_underlyingInfo_para_
        {
            get
            {
                if (this.excel_underlyingInfo_para_ != null)
                {
                    return this.excel_underlyingInfo_para_; 
                }
                else if (this.excel_underlyingInfo_paraIDRef_ != null)
                {
                    return this.excel_underlyingInfo_para_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingInfo_para_ != value)
                {
                    this.excel_underlyingInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingInfo_paraIDRef_ { get; set; }
        #region Excel_correlationInfo_para_
        private Excel_correlationInfo_para excel_correlationInfo_para_;
        public Excel_correlationInfo_para Excel_correlationInfo_para_
        {
            get
            {
                if (this.excel_correlationInfo_para_ != null)
                {
                    return this.excel_correlationInfo_para_; 
                }
                else if (this.excel_correlationInfo_paraIDRef_ != null)
                {
                    excel_correlationInfo_para_ = IDManager.getID(excel_correlationInfo_paraIDRef_) as Excel_correlationInfo_para;
                    return this.excel_correlationInfo_para_; 
                }
                else
                {
                    throw new Exception( "excel_correlationInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_correlationInfo_para_ != value)
                {
                    this.excel_correlationInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_correlationInfo_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}

