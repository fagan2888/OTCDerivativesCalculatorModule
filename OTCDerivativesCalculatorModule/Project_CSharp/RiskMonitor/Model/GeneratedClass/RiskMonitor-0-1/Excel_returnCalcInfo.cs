using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_returnCalcInfo : ISerialized
    {
        public Excel_returnCalcInfo() { }
        public Excel_returnCalcInfo(XmlNode xmlNode)
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
            
        
            XmlNode excel_constReturnCalNode = xmlNode.SelectSingleNode("excel_constReturnCal");
            
            if (excel_constReturnCalNode != null)
            {
                if (excel_constReturnCalNode.Attributes["href"] != null || excel_constReturnCalNode.Attributes["id"] != null) 
                {
                    if (excel_constReturnCalNode.Attributes["id"] != null) 
                    {
                        excel_constReturnCalIDRef_ = excel_constReturnCalNode.Attributes["id"].Value;
                        Excel_constReturnCal ob = new Excel_constReturnCal(excel_constReturnCalNode);
                        IDManager.SetID(excel_constReturnCalIDRef_, ob);
                    }
                    else if (excel_constReturnCalNode.Attributes["href"] != null)
                    {
                        excel_constReturnCalIDRef_ = excel_constReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_constReturnCal_ = new Excel_constReturnCal(excel_constReturnCalNode);
                    }
                }
                else
                {
                    excel_constReturnCal_ = new Excel_constReturnCal(excel_constReturnCalNode);
                }
            }
            
        
            XmlNode excel_vanillaReturnCalNode = xmlNode.SelectSingleNode("excel_vanillaReturnCal");
            
            if (excel_vanillaReturnCalNode != null)
            {
                if (excel_vanillaReturnCalNode.Attributes["href"] != null || excel_vanillaReturnCalNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaReturnCalNode.Attributes["id"] != null) 
                    {
                        excel_vanillaReturnCalIDRef_ = excel_vanillaReturnCalNode.Attributes["id"].Value;
                        Excel_vanillaReturnCal ob = new Excel_vanillaReturnCal(excel_vanillaReturnCalNode);
                        IDManager.SetID(excel_vanillaReturnCalIDRef_, ob);
                    }
                    else if (excel_vanillaReturnCalNode.Attributes["href"] != null)
                    {
                        excel_vanillaReturnCalIDRef_ = excel_vanillaReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaReturnCal_ = new Excel_vanillaReturnCal(excel_vanillaReturnCalNode);
                    }
                }
                else
                {
                    excel_vanillaReturnCal_ = new Excel_vanillaReturnCal(excel_vanillaReturnCalNode);
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
        #region Excel_constReturnCal_
        private Excel_constReturnCal excel_constReturnCal_;
        public Excel_constReturnCal Excel_constReturnCal_
        {
            get
            {
                if (this.excel_constReturnCal_ != null)
                {
                    return this.excel_constReturnCal_; 
                }
                else if (this.excel_constReturnCalIDRef_ != null)
                {
                    excel_constReturnCal_ = IDManager.getID(excel_constReturnCalIDRef_) as Excel_constReturnCal;
                    return this.excel_constReturnCal_; 
                }
                else
                {
                    throw new Exception( "excel_constReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_constReturnCal_ != value)
                {
                    this.excel_constReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_constReturnCalIDRef_ { get; set; }
        #region Excel_vanillaReturnCal_
        private Excel_vanillaReturnCal excel_vanillaReturnCal_;
        public Excel_vanillaReturnCal Excel_vanillaReturnCal_
        {
            get
            {
                if (this.excel_vanillaReturnCal_ != null)
                {
                    return this.excel_vanillaReturnCal_; 
                }
                else if (this.excel_vanillaReturnCalIDRef_ != null)
                {
                    excel_vanillaReturnCal_ = IDManager.getID(excel_vanillaReturnCalIDRef_) as Excel_vanillaReturnCal;
                    return this.excel_vanillaReturnCal_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaReturnCal_ != value)
                {
                    this.excel_vanillaReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaReturnCalIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

