using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_cashFlowsResult : ISerialized
    {
        public Excel_cashFlowsResult() { }
        public Excel_cashFlowsResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_cashFlowResultNodeList = xmlNode.SelectNodes("excel_cashFlowResult");
            
            if (excel_cashFlowResultNodeList != null)
            {
                this.excel_cashFlowResult_ = new List<Excel_cashFlowResult>();
                foreach (XmlNode item in excel_cashFlowResultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_cashFlowResultIDRef_ = item.Attributes["id"].Value;
                            excel_cashFlowResult_.Add(new Excel_cashFlowResult(item));
                            IDManager.SetID(excel_cashFlowResultIDRef_, excel_cashFlowResult_[excel_cashFlowResult_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_cashFlowResultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_cashFlowResult_.Add(new Excel_cashFlowResult(item));
                        }
                    }
                    else
                    {
                        excel_cashFlowResult_.Add(new Excel_cashFlowResult(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_cashFlowResult_
        private List<Excel_cashFlowResult> excel_cashFlowResult_;
        public List<Excel_cashFlowResult> Excel_cashFlowResult_
        {
            get
            {
                if (this.excel_cashFlowResult_ != null)
                {
                    return this.excel_cashFlowResult_; 
                }
                else if (this.excel_cashFlowResultIDRef_ != null)
                {
                    return this.excel_cashFlowResult_; 
                }
                else
                {
                    throw new Exception( "excel_cashFlowResult_Node no exist!");
                }
            }
            set
            {
                if (this.excel_cashFlowResult_ != value)
                {
                    this.excel_cashFlowResult_ = value;
                }
            }
        }
        #endregion
        
        public string excel_cashFlowResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

