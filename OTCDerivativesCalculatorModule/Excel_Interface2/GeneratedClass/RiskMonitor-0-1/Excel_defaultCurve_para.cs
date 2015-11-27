using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_defaultCurve_para : ISerialized
    {
        public Excel_defaultCurve_para() { }
        public Excel_defaultCurve_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_defaultCurveNodeList = xmlNode.SelectNodes("excel_defaultCurve");
            
            if (excel_defaultCurveNodeList != null)
            {
                this.excel_defaultCurve_ = new List<Excel_defaultCurve>();
                foreach (XmlNode item in excel_defaultCurveNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_defaultCurveIDRef_ = item.Attributes["id"].Value;
                            excel_defaultCurve_.Add(new Excel_defaultCurve(item));
                            IDManager.SetID(excel_defaultCurveIDRef_, excel_defaultCurve_[excel_defaultCurve_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_defaultCurveIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_defaultCurve_.Add(new Excel_defaultCurve(item));
                        }
                    }
                    else
                    {
                        excel_defaultCurve_.Add(new Excel_defaultCurve(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_defaultCurve_
        private List<Excel_defaultCurve> excel_defaultCurve_;
        public List<Excel_defaultCurve> Excel_defaultCurve_
        {
            get
            {
                if (this.excel_defaultCurve_ != null)
                {
                    return this.excel_defaultCurve_; 
                }
                else if (this.excel_defaultCurveIDRef_ != null)
                {
                    return this.excel_defaultCurve_; 
                }
                else
                {
                    throw new Exception( "excel_defaultCurve_Node no exist!");
                }
            }
            set
            {
                if (this.excel_defaultCurve_ != value)
                {
                    this.excel_defaultCurve_ = value;
                }
            }
        }
        #endregion
        
        public string excel_defaultCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

