using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_dualKiEventCalc : ISerialized
    {
        public Excel_dualKiEventCalc() { }
        public Excel_dualKiEventCalc(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_eventCalcInfoNodeList = xmlNode.SelectNodes("excel_eventCalcInfo");
            
            if (excel_eventCalcInfoNodeList != null)
            {
                this.excel_eventCalcInfo_ = new List<Excel_eventCalcInfo>();
                foreach (XmlNode item in excel_eventCalcInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_eventCalcInfoIDRef_ = item.Attributes["id"].Value;
                            excel_eventCalcInfo_.Add(new Excel_eventCalcInfo(item));
                            IDManager.SetID(excel_eventCalcInfoIDRef_, excel_eventCalcInfo_[excel_eventCalcInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_eventCalcInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_eventCalcInfo_.Add(new Excel_eventCalcInfo(item));
                        }
                    }
                    else
                    {
                        excel_eventCalcInfo_.Add(new Excel_eventCalcInfo(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_eventCalcInfo_
        private List<Excel_eventCalcInfo> excel_eventCalcInfo_;
        public List<Excel_eventCalcInfo> Excel_eventCalcInfo_
        {
            get
            {
                if (this.excel_eventCalcInfo_ != null)
                {
                    return this.excel_eventCalcInfo_; 
                }
                else if (this.excel_eventCalcInfoIDRef_ != null)
                {
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

