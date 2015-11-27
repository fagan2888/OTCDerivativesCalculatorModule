using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingCalcInfo : ISerialized
    {
        public Excel_underlyingCalcInfo() { }
        public Excel_underlyingCalcInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_underlyingInfoNodeList = xmlNode.SelectNodes("excel_underlyingInfo");
            
            if (excel_underlyingInfoNodeList != null)
            {
                this.excel_underlyingInfo_ = new List<Excel_underlyingInfo>();
                foreach (XmlNode item in excel_underlyingInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_underlyingInfoIDRef_ = item.Attributes["id"].Value;
                            excel_underlyingInfo_.Add(new Excel_underlyingInfo(item));
                            IDManager.SetID(excel_underlyingInfoIDRef_, excel_underlyingInfo_[excel_underlyingInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_underlyingInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_underlyingInfo_.Add(new Excel_underlyingInfo(item));
                        }
                    }
                    else
                    {
                        excel_underlyingInfo_.Add(new Excel_underlyingInfo(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_underlyingInfo_
        private List<Excel_underlyingInfo> excel_underlyingInfo_;
        public List<Excel_underlyingInfo> Excel_underlyingInfo_
        {
            get
            {
                if (this.excel_underlyingInfo_ != null)
                {
                    return this.excel_underlyingInfo_; 
                }
                else if (this.excel_underlyingInfoIDRef_ != null)
                {
                    return this.excel_underlyingInfo_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingInfo_ != value)
                {
                    this.excel_underlyingInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

