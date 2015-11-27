using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceCalcInfo_para : ISerialized
    {
        public Excel_referenceCalcInfo_para() { }
        public Excel_referenceCalcInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_referenceInfo_paraNodeList = xmlNode.SelectNodes("excel_referenceInfo_para");
            
            if (excel_referenceInfo_paraNodeList != null)
            {
                this.excel_referenceInfo_para_ = new List<Excel_referenceInfo_para>();
                foreach (XmlNode item in excel_referenceInfo_paraNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_referenceInfo_paraIDRef_ = item.Attributes["id"].Value;
                            excel_referenceInfo_para_.Add(new Excel_referenceInfo_para(item));
                            IDManager.SetID(excel_referenceInfo_paraIDRef_, excel_referenceInfo_para_[excel_referenceInfo_para_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_referenceInfo_paraIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_referenceInfo_para_.Add(new Excel_referenceInfo_para(item));
                        }
                    }
                    else
                    {
                        excel_referenceInfo_para_.Add(new Excel_referenceInfo_para(item));
                    }
                }
            }
            
        
            XmlNode coupula_correlationNode = xmlNode.SelectSingleNode("coupula_correlation");
            
            if (coupula_correlationNode != null)
            {
                if (coupula_correlationNode.Attributes["href"] != null || coupula_correlationNode.Attributes["id"] != null) 
                {
                    if (coupula_correlationNode.Attributes["id"] != null) 
                    {
                        coupula_correlationIDRef_ = coupula_correlationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(coupula_correlationNode);
                        IDManager.SetID(coupula_correlationIDRef_, ob);
                    }
                    else if (coupula_correlationNode.Attributes["href"] != null)
                    {
                        coupula_correlationIDRef_ = coupula_correlationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coupula_correlation_ = new XsdTypeToken(coupula_correlationNode);
                    }
                }
                else
                {
                    coupula_correlation_ = new XsdTypeToken(coupula_correlationNode);
                }
            }
            
        
        }
        
    
        #region Excel_referenceInfo_para_
        private List<Excel_referenceInfo_para> excel_referenceInfo_para_;
        public List<Excel_referenceInfo_para> Excel_referenceInfo_para_
        {
            get
            {
                if (this.excel_referenceInfo_para_ != null)
                {
                    return this.excel_referenceInfo_para_; 
                }
                else if (this.excel_referenceInfo_paraIDRef_ != null)
                {
                    return this.excel_referenceInfo_para_; 
                }
                else
                {
                    throw new Exception( "excel_referenceInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceInfo_para_ != value)
                {
                    this.excel_referenceInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceInfo_paraIDRef_ { get; set; }
        #region Coupula_correlation_
        private XsdTypeToken coupula_correlation_;
        public XsdTypeToken Coupula_correlation_
        {
            get
            {
                if (this.coupula_correlation_ != null)
                {
                    return this.coupula_correlation_; 
                }
                else if (this.coupula_correlationIDRef_ != null)
                {
                    coupula_correlation_ = IDManager.getID(coupula_correlationIDRef_) as XsdTypeToken;
                    return this.coupula_correlation_; 
                }
                else
                {
                    throw new Exception( "coupula_correlation_Node no exist!");
                }
            }
            set
            {
                if (this.coupula_correlation_ != value)
                {
                    this.coupula_correlation_ = value;
                }
            }
        }
        #endregion
        
        public string coupula_correlationIDRef_ { get; set; }
        
    
        
    
    }
    
}

