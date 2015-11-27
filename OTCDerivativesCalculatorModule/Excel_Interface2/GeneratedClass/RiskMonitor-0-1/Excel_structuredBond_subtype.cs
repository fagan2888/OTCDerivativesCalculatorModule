using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_structuredBond_subtype : ISerialized
    {
        public Excel_structuredBond_subtype() { }
        public Excel_structuredBond_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_structuredBond_fixedAccrualNode = xmlNode.SelectSingleNode("excel_structuredBond_fixedAccrual");
            
            if (excel_structuredBond_fixedAccrualNode != null)
            {
                if (excel_structuredBond_fixedAccrualNode.Attributes["href"] != null || excel_structuredBond_fixedAccrualNode.Attributes["id"] != null) 
                {
                    if (excel_structuredBond_fixedAccrualNode.Attributes["id"] != null) 
                    {
                        excel_structuredBond_fixedAccrualIDRef_ = excel_structuredBond_fixedAccrualNode.Attributes["id"].Value;
                        Excel_structuredBond_fixedAccrual ob = new Excel_structuredBond_fixedAccrual(excel_structuredBond_fixedAccrualNode);
                        IDManager.SetID(excel_structuredBond_fixedAccrualIDRef_, ob);
                    }
                    else if (excel_structuredBond_fixedAccrualNode.Attributes["href"] != null)
                    {
                        excel_structuredBond_fixedAccrualIDRef_ = excel_structuredBond_fixedAccrualNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredBond_fixedAccrual_ = new Excel_structuredBond_fixedAccrual(excel_structuredBond_fixedAccrualNode);
                    }
                }
                else
                {
                    excel_structuredBond_fixedAccrual_ = new Excel_structuredBond_fixedAccrual(excel_structuredBond_fixedAccrualNode);
                }
            }
            
        
            XmlNode excel_structuredBond_floatingAccrualNode = xmlNode.SelectSingleNode("excel_structuredBond_floatingAccrual");
            
            if (excel_structuredBond_floatingAccrualNode != null)
            {
                if (excel_structuredBond_floatingAccrualNode.Attributes["href"] != null || excel_structuredBond_floatingAccrualNode.Attributes["id"] != null) 
                {
                    if (excel_structuredBond_floatingAccrualNode.Attributes["id"] != null) 
                    {
                        excel_structuredBond_floatingAccrualIDRef_ = excel_structuredBond_floatingAccrualNode.Attributes["id"].Value;
                        Excel_structuredBond_floatingAccrual ob = new Excel_structuredBond_floatingAccrual(excel_structuredBond_floatingAccrualNode);
                        IDManager.SetID(excel_structuredBond_floatingAccrualIDRef_, ob);
                    }
                    else if (excel_structuredBond_floatingAccrualNode.Attributes["href"] != null)
                    {
                        excel_structuredBond_floatingAccrualIDRef_ = excel_structuredBond_floatingAccrualNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredBond_floatingAccrual_ = new Excel_structuredBond_floatingAccrual(excel_structuredBond_floatingAccrualNode);
                    }
                }
                else
                {
                    excel_structuredBond_floatingAccrual_ = new Excel_structuredBond_floatingAccrual(excel_structuredBond_floatingAccrualNode);
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
        #region Excel_structuredBond_fixedAccrual_
        private Excel_structuredBond_fixedAccrual excel_structuredBond_fixedAccrual_;
        public Excel_structuredBond_fixedAccrual Excel_structuredBond_fixedAccrual_
        {
            get
            {
                if (this.excel_structuredBond_fixedAccrual_ != null)
                {
                    return this.excel_structuredBond_fixedAccrual_; 
                }
                else if (this.excel_structuredBond_fixedAccrualIDRef_ != null)
                {
                    excel_structuredBond_fixedAccrual_ = IDManager.getID(excel_structuredBond_fixedAccrualIDRef_) as Excel_structuredBond_fixedAccrual;
                    return this.excel_structuredBond_fixedAccrual_; 
                }
                else
                {
                    throw new Exception( "excel_structuredBond_fixedAccrual_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredBond_fixedAccrual_ != value)
                {
                    this.excel_structuredBond_fixedAccrual_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredBond_fixedAccrualIDRef_ { get; set; }
        #region Excel_structuredBond_floatingAccrual_
        private Excel_structuredBond_floatingAccrual excel_structuredBond_floatingAccrual_;
        public Excel_structuredBond_floatingAccrual Excel_structuredBond_floatingAccrual_
        {
            get
            {
                if (this.excel_structuredBond_floatingAccrual_ != null)
                {
                    return this.excel_structuredBond_floatingAccrual_; 
                }
                else if (this.excel_structuredBond_floatingAccrualIDRef_ != null)
                {
                    excel_structuredBond_floatingAccrual_ = IDManager.getID(excel_structuredBond_floatingAccrualIDRef_) as Excel_structuredBond_floatingAccrual;
                    return this.excel_structuredBond_floatingAccrual_; 
                }
                else
                {
                    throw new Exception( "excel_structuredBond_floatingAccrual_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredBond_floatingAccrual_ != value)
                {
                    this.excel_structuredBond_floatingAccrual_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredBond_floatingAccrualIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

