using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingBond_subtype : ISerialized
    {
        public Excel_vanillaFloatingBond_subtype() { }
        public Excel_vanillaFloatingBond_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_vanillaFloatingBond_simpleNode = xmlNode.SelectSingleNode("excel_vanillaFloatingBond_simple");
            
            if (excel_vanillaFloatingBond_simpleNode != null)
            {
                if (excel_vanillaFloatingBond_simpleNode.Attributes["href"] != null || excel_vanillaFloatingBond_simpleNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingBond_simpleNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingBond_simpleIDRef_ = excel_vanillaFloatingBond_simpleNode.Attributes["id"].Value;
                        Excel_vanillaFloatingBond_simple ob = new Excel_vanillaFloatingBond_simple(excel_vanillaFloatingBond_simpleNode);
                        IDManager.SetID(excel_vanillaFloatingBond_simpleIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingBond_simpleNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingBond_simpleIDRef_ = excel_vanillaFloatingBond_simpleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingBond_simple_ = new Excel_vanillaFloatingBond_simple(excel_vanillaFloatingBond_simpleNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingBond_simple_ = new Excel_vanillaFloatingBond_simple(excel_vanillaFloatingBond_simpleNode);
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
        #region Excel_vanillaFloatingBond_simple_
        private Excel_vanillaFloatingBond_simple excel_vanillaFloatingBond_simple_;
        public Excel_vanillaFloatingBond_simple Excel_vanillaFloatingBond_simple_
        {
            get
            {
                if (this.excel_vanillaFloatingBond_simple_ != null)
                {
                    return this.excel_vanillaFloatingBond_simple_; 
                }
                else if (this.excel_vanillaFloatingBond_simpleIDRef_ != null)
                {
                    excel_vanillaFloatingBond_simple_ = IDManager.getID(excel_vanillaFloatingBond_simpleIDRef_) as Excel_vanillaFloatingBond_simple;
                    return this.excel_vanillaFloatingBond_simple_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingBond_simple_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingBond_simple_ != value)
                {
                    this.excel_vanillaFloatingBond_simple_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingBond_simpleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

