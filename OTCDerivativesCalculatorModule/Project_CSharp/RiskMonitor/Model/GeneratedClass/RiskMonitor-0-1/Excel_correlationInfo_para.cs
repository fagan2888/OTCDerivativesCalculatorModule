using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_correlationInfo_para : ISerialized
    {
        public Excel_correlationInfo_para() { }
        public Excel_correlationInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dimensionNode = xmlNode.SelectSingleNode("dimension");
            
            if (dimensionNode != null)
            {
                if (dimensionNode.Attributes["href"] != null || dimensionNode.Attributes["id"] != null) 
                {
                    if (dimensionNode.Attributes["id"] != null) 
                    {
                        dimensionIDRef_ = dimensionNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(dimensionNode);
                        IDManager.SetID(dimensionIDRef_, ob);
                    }
                    else if (dimensionNode.Attributes["href"] != null)
                    {
                        dimensionIDRef_ = dimensionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dimension_ = new XsdTypeInteger(dimensionNode);
                    }
                }
                else
                {
                    dimension_ = new XsdTypeInteger(dimensionNode);
                }
            }
            
        
            XmlNodeList excel_correlation_paraNodeList = xmlNode.SelectNodes("excel_correlation_para");
            
            if (excel_correlation_paraNodeList != null)
            {
                this.excel_correlation_para_ = new List<Excel_correlation_para>();
                foreach (XmlNode item in excel_correlation_paraNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_correlation_paraIDRef_ = item.Attributes["id"].Value;
                            excel_correlation_para_.Add(new Excel_correlation_para(item));
                            IDManager.SetID(excel_correlation_paraIDRef_, excel_correlation_para_[excel_correlation_para_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_correlation_paraIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_correlation_para_.Add(new Excel_correlation_para(item));
                        }
                    }
                    else
                    {
                        excel_correlation_para_.Add(new Excel_correlation_para(item));
                    }
                }
            }
            
        
        }
        
    
        #region Dimension_
        private XsdTypeInteger dimension_;
        public XsdTypeInteger Dimension_
        {
            get
            {
                if (this.dimension_ != null)
                {
                    return this.dimension_; 
                }
                else if (this.dimensionIDRef_ != null)
                {
                    dimension_ = IDManager.getID(dimensionIDRef_) as XsdTypeInteger;
                    return this.dimension_; 
                }
                else
                {
                    throw new Exception( "dimension_Node no exist!");
                }
            }
            set
            {
                if (this.dimension_ != value)
                {
                    this.dimension_ = value;
                }
            }
        }
        #endregion
        
        public string dimensionIDRef_ { get; set; }
        #region Excel_correlation_para_
        private List<Excel_correlation_para> excel_correlation_para_;
        public List<Excel_correlation_para> Excel_correlation_para_
        {
            get
            {
                if (this.excel_correlation_para_ != null)
                {
                    return this.excel_correlation_para_; 
                }
                else if (this.excel_correlation_paraIDRef_ != null)
                {
                    return this.excel_correlation_para_; 
                }
                else
                {
                    throw new Exception( "excel_correlation_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_correlation_para_ != value)
                {
                    this.excel_correlation_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_correlation_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}

