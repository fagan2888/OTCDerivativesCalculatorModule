using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_discountCurve_para : ISerialized
    {
        public Excel_discountCurve_para() { }
        public Excel_discountCurve_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_yieldCurveNodeList = xmlNode.SelectNodes("excel_yieldCurve");
            
            if (excel_yieldCurveNodeList != null)
            {
                this.excel_yieldCurve_ = new List<Excel_yieldCurve>();
                foreach (XmlNode item in excel_yieldCurveNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_yieldCurveIDRef_ = item.Attributes["id"].Value;
                            excel_yieldCurve_.Add(new Excel_yieldCurve(item));
                            IDManager.SetID(excel_yieldCurveIDRef_, excel_yieldCurve_[excel_yieldCurve_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_yieldCurveIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_yieldCurve_.Add(new Excel_yieldCurve(item));
                        }
                    }
                    else
                    {
                        excel_yieldCurve_.Add(new Excel_yieldCurve(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_yieldCurve_
        private List<Excel_yieldCurve> excel_yieldCurve_;
        public List<Excel_yieldCurve> Excel_yieldCurve_
        {
            get
            {
                if (this.excel_yieldCurve_ != null)
                {
                    return this.excel_yieldCurve_; 
                }
                else if (this.excel_yieldCurveIDRef_ != null)
                {
                    return this.excel_yieldCurve_; 
                }
                else
                {
                    throw new Exception( "excel_yieldCurve_Node no exist!");
                }
            }
            set
            {
                if (this.excel_yieldCurve_ != value)
                {
                    this.excel_yieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string excel_yieldCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

