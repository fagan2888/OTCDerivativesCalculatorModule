using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_crs : ISerialized
    {
        public Excel_crs() { }
        public Excel_crs(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_swapLegNodeList = xmlNode.SelectNodes("excel_swapLeg");
            
            if (excel_swapLegNodeList != null)
            {
                this.excel_swapLeg_ = new List<Excel_swapLeg>();
                foreach (XmlNode item in excel_swapLegNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_swapLegIDRef_ = item.Attributes["id"].Value;
                            excel_swapLeg_.Add(new Excel_swapLeg(item));
                            IDManager.SetID(excel_swapLegIDRef_, excel_swapLeg_[excel_swapLeg_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_swapLegIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_swapLeg_.Add(new Excel_swapLeg(item));
                        }
                    }
                    else
                    {
                        excel_swapLeg_.Add(new Excel_swapLeg(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_swapLeg_
        private List<Excel_swapLeg> excel_swapLeg_;
        public List<Excel_swapLeg> Excel_swapLeg_
        {
            get
            {
                if (this.excel_swapLeg_ != null)
                {
                    return this.excel_swapLeg_; 
                }
                else if (this.excel_swapLegIDRef_ != null)
                {
                    return this.excel_swapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_swapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapLeg_ != value)
                {
                    this.excel_swapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapLegIDRef_ { get; set; }
        
    
        
    
    }
    
}

