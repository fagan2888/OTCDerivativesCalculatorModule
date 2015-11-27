using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_valueResult : ISerialized
    {
        public Excel_valueResult() { }
        public Excel_valueResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_valueSideResultNodeList = xmlNode.SelectNodes("excel_valueSideResult");
            
            if (excel_valueSideResultNodeList != null)
            {
                this.excel_valueSideResult_ = new List<Excel_valueSideResult>();
                foreach (XmlNode item in excel_valueSideResultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_valueSideResultIDRef_ = item.Attributes["id"].Value;
                            excel_valueSideResult_.Add(new Excel_valueSideResult(item));
                            IDManager.SetID(excel_valueSideResultIDRef_, excel_valueSideResult_[excel_valueSideResult_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_valueSideResultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_valueSideResult_.Add(new Excel_valueSideResult(item));
                        }
                    }
                    else
                    {
                        excel_valueSideResult_.Add(new Excel_valueSideResult(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_valueSideResult_
        private List<Excel_valueSideResult> excel_valueSideResult_;
        public List<Excel_valueSideResult> Excel_valueSideResult_
        {
            get
            {
                if (this.excel_valueSideResult_ != null)
                {
                    return this.excel_valueSideResult_; 
                }
                else if (this.excel_valueSideResultIDRef_ != null)
                {
                    return this.excel_valueSideResult_; 
                }
                else
                {
                    throw new Exception( "excel_valueSideResult_Node no exist!");
                }
            }
            set
            {
                if (this.excel_valueSideResult_ != value)
                {
                    this.excel_valueSideResult_ = value;
                }
            }
        }
        #endregion
        
        public string excel_valueSideResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

