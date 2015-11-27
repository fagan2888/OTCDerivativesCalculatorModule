using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_swapInterface : ISerialized
    {
        public Excel_swapInterface() { }
        public Excel_swapInterface(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_typeNode = xmlNode.SelectSingleNode("excel_type");
            
            if (excel_typeNode != null)
            {
                if (excel_typeNode.Attributes["href"] != null || excel_typeNode.Attributes["id"] != null) 
                {
                    if (excel_typeNode.Attributes["id"] != null) 
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(excel_typeNode);
                        IDManager.SetID(excel_typeIDRef_, ob);
                    }
                    else if (excel_typeNode.Attributes["href"] != null)
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_type_ = new XsdTypeToken(excel_typeNode);
                    }
                }
                else
                {
                    excel_type_ = new XsdTypeToken(excel_typeNode);
                }
            }
            
        
            XmlNode excel_irsNode = xmlNode.SelectSingleNode("excel_irs");
            
            if (excel_irsNode != null)
            {
                if (excel_irsNode.Attributes["href"] != null || excel_irsNode.Attributes["id"] != null) 
                {
                    if (excel_irsNode.Attributes["id"] != null) 
                    {
                        excel_irsIDRef_ = excel_irsNode.Attributes["id"].Value;
                        Excel_irs ob = new Excel_irs(excel_irsNode);
                        IDManager.SetID(excel_irsIDRef_, ob);
                    }
                    else if (excel_irsNode.Attributes["href"] != null)
                    {
                        excel_irsIDRef_ = excel_irsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_irs_ = new Excel_irs(excel_irsNode);
                    }
                }
                else
                {
                    excel_irs_ = new Excel_irs(excel_irsNode);
                }
            }
            
        
            XmlNode excel_crsNode = xmlNode.SelectSingleNode("excel_crs");
            
            if (excel_crsNode != null)
            {
                if (excel_crsNode.Attributes["href"] != null || excel_crsNode.Attributes["id"] != null) 
                {
                    if (excel_crsNode.Attributes["id"] != null) 
                    {
                        excel_crsIDRef_ = excel_crsNode.Attributes["id"].Value;
                        Excel_crs ob = new Excel_crs(excel_crsNode);
                        IDManager.SetID(excel_crsIDRef_, ob);
                    }
                    else if (excel_crsNode.Attributes["href"] != null)
                    {
                        excel_crsIDRef_ = excel_crsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_crs_ = new Excel_crs(excel_crsNode);
                    }
                }
                else
                {
                    excel_crs_ = new Excel_crs(excel_crsNode);
                }
            }
            
        
            XmlNode excel_cdsNode = xmlNode.SelectSingleNode("excel_cds");
            
            if (excel_cdsNode != null)
            {
                if (excel_cdsNode.Attributes["href"] != null || excel_cdsNode.Attributes["id"] != null) 
                {
                    if (excel_cdsNode.Attributes["id"] != null) 
                    {
                        excel_cdsIDRef_ = excel_cdsNode.Attributes["id"].Value;
                        Excel_cds ob = new Excel_cds(excel_cdsNode);
                        IDManager.SetID(excel_cdsIDRef_, ob);
                    }
                    else if (excel_cdsNode.Attributes["href"] != null)
                    {
                        excel_cdsIDRef_ = excel_cdsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_cds_ = new Excel_cds(excel_cdsNode);
                    }
                }
                else
                {
                    excel_cds_ = new Excel_cds(excel_cdsNode);
                }
            }
            
        
            XmlNode excel_structuredSwapNode = xmlNode.SelectSingleNode("excel_structuredSwap");
            
            if (excel_structuredSwapNode != null)
            {
                if (excel_structuredSwapNode.Attributes["href"] != null || excel_structuredSwapNode.Attributes["id"] != null) 
                {
                    if (excel_structuredSwapNode.Attributes["id"] != null) 
                    {
                        excel_structuredSwapIDRef_ = excel_structuredSwapNode.Attributes["id"].Value;
                        Excel_structuredSwap ob = new Excel_structuredSwap(excel_structuredSwapNode);
                        IDManager.SetID(excel_structuredSwapIDRef_, ob);
                    }
                    else if (excel_structuredSwapNode.Attributes["href"] != null)
                    {
                        excel_structuredSwapIDRef_ = excel_structuredSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredSwap_ = new Excel_structuredSwap(excel_structuredSwapNode);
                    }
                }
                else
                {
                    excel_structuredSwap_ = new Excel_structuredSwap(excel_structuredSwapNode);
                }
            }
            
        
        }
        
    
        #region Excel_type_
        private XsdTypeToken excel_type_;
        public XsdTypeToken Excel_type_
        {
            get
            {
                if (this.excel_type_ != null)
                {
                    return this.excel_type_; 
                }
                else if (this.excel_typeIDRef_ != null)
                {
                    excel_type_ = IDManager.getID(excel_typeIDRef_) as XsdTypeToken;
                    return this.excel_type_; 
                }
                else
                {
                    throw new Exception( "excel_type_Node no exist!");
                }
            }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                }
            }
        }
        #endregion
        
        public string excel_typeIDRef_ { get; set; }
        #region Excel_irs_
        private Excel_irs excel_irs_;
        public Excel_irs Excel_irs_
        {
            get
            {
                if (this.excel_irs_ != null)
                {
                    return this.excel_irs_; 
                }
                else if (this.excel_irsIDRef_ != null)
                {
                    excel_irs_ = IDManager.getID(excel_irsIDRef_) as Excel_irs;
                    return this.excel_irs_; 
                }
                else
                {
                    throw new Exception( "excel_irs_Node no exist!");
                }
            }
            set
            {
                if (this.excel_irs_ != value)
                {
                    this.excel_irs_ = value;
                }
            }
        }
        #endregion
        
        public string excel_irsIDRef_ { get; set; }
        #region Excel_crs_
        private Excel_crs excel_crs_;
        public Excel_crs Excel_crs_
        {
            get
            {
                if (this.excel_crs_ != null)
                {
                    return this.excel_crs_; 
                }
                else if (this.excel_crsIDRef_ != null)
                {
                    excel_crs_ = IDManager.getID(excel_crsIDRef_) as Excel_crs;
                    return this.excel_crs_; 
                }
                else
                {
                    throw new Exception( "excel_crs_Node no exist!");
                }
            }
            set
            {
                if (this.excel_crs_ != value)
                {
                    this.excel_crs_ = value;
                }
            }
        }
        #endregion
        
        public string excel_crsIDRef_ { get; set; }
        #region Excel_cds_
        private Excel_cds excel_cds_;
        public Excel_cds Excel_cds_
        {
            get
            {
                if (this.excel_cds_ != null)
                {
                    return this.excel_cds_; 
                }
                else if (this.excel_cdsIDRef_ != null)
                {
                    excel_cds_ = IDManager.getID(excel_cdsIDRef_) as Excel_cds;
                    return this.excel_cds_; 
                }
                else
                {
                    throw new Exception( "excel_cds_Node no exist!");
                }
            }
            set
            {
                if (this.excel_cds_ != value)
                {
                    this.excel_cds_ = value;
                }
            }
        }
        #endregion
        
        public string excel_cdsIDRef_ { get; set; }
        #region Excel_structuredSwap_
        private Excel_structuredSwap excel_structuredSwap_;
        public Excel_structuredSwap Excel_structuredSwap_
        {
            get
            {
                if (this.excel_structuredSwap_ != null)
                {
                    return this.excel_structuredSwap_; 
                }
                else if (this.excel_structuredSwapIDRef_ != null)
                {
                    excel_structuredSwap_ = IDManager.getID(excel_structuredSwapIDRef_) as Excel_structuredSwap;
                    return this.excel_structuredSwap_; 
                }
                else
                {
                    throw new Exception( "excel_structuredSwap_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredSwap_ != value)
                {
                    this.excel_structuredSwap_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredSwapIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

