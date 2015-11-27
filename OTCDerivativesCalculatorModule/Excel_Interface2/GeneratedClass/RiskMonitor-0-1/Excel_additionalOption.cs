using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_additionalOption : ISerialized
    {
        public Excel_additionalOption() { }
        public Excel_additionalOption(XmlNode xmlNode)
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
            
        
            XmlNode excel_noneOptionNode = xmlNode.SelectSingleNode("excel_noneOption");
            
            if (excel_noneOptionNode != null)
            {
                if (excel_noneOptionNode.Attributes["href"] != null || excel_noneOptionNode.Attributes["id"] != null) 
                {
                    if (excel_noneOptionNode.Attributes["id"] != null) 
                    {
                        excel_noneOptionIDRef_ = excel_noneOptionNode.Attributes["id"].Value;
                        Excel_noneOption ob = new Excel_noneOption(excel_noneOptionNode);
                        IDManager.SetID(excel_noneOptionIDRef_, ob);
                    }
                    else if (excel_noneOptionNode.Attributes["href"] != null)
                    {
                        excel_noneOptionIDRef_ = excel_noneOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_noneOption_ = new Excel_noneOption(excel_noneOptionNode);
                    }
                }
                else
                {
                    excel_noneOption_ = new Excel_noneOption(excel_noneOptionNode);
                }
            }
            
        
            XmlNode excel_callableOptionNode = xmlNode.SelectSingleNode("excel_callableOption");
            
            if (excel_callableOptionNode != null)
            {
                if (excel_callableOptionNode.Attributes["href"] != null || excel_callableOptionNode.Attributes["id"] != null) 
                {
                    if (excel_callableOptionNode.Attributes["id"] != null) 
                    {
                        excel_callableOptionIDRef_ = excel_callableOptionNode.Attributes["id"].Value;
                        Excel_callableOption ob = new Excel_callableOption(excel_callableOptionNode);
                        IDManager.SetID(excel_callableOptionIDRef_, ob);
                    }
                    else if (excel_callableOptionNode.Attributes["href"] != null)
                    {
                        excel_callableOptionIDRef_ = excel_callableOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_callableOption_ = new Excel_callableOption(excel_callableOptionNode);
                    }
                }
                else
                {
                    excel_callableOption_ = new Excel_callableOption(excel_callableOptionNode);
                }
            }
            
        
            XmlNode excel_puttableOptionNode = xmlNode.SelectSingleNode("excel_puttableOption");
            
            if (excel_puttableOptionNode != null)
            {
                if (excel_puttableOptionNode.Attributes["href"] != null || excel_puttableOptionNode.Attributes["id"] != null) 
                {
                    if (excel_puttableOptionNode.Attributes["id"] != null) 
                    {
                        excel_puttableOptionIDRef_ = excel_puttableOptionNode.Attributes["id"].Value;
                        Excel_puttableOption ob = new Excel_puttableOption(excel_puttableOptionNode);
                        IDManager.SetID(excel_puttableOptionIDRef_, ob);
                    }
                    else if (excel_puttableOptionNode.Attributes["href"] != null)
                    {
                        excel_puttableOptionIDRef_ = excel_puttableOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_puttableOption_ = new Excel_puttableOption(excel_puttableOptionNode);
                    }
                }
                else
                {
                    excel_puttableOption_ = new Excel_puttableOption(excel_puttableOptionNode);
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
        #region Excel_noneOption_
        private Excel_noneOption excel_noneOption_;
        public Excel_noneOption Excel_noneOption_
        {
            get
            {
                if (this.excel_noneOption_ != null)
                {
                    return this.excel_noneOption_; 
                }
                else if (this.excel_noneOptionIDRef_ != null)
                {
                    excel_noneOption_ = IDManager.getID(excel_noneOptionIDRef_) as Excel_noneOption;
                    return this.excel_noneOption_; 
                }
                else
                {
                    throw new Exception( "excel_noneOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_noneOption_ != value)
                {
                    this.excel_noneOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_noneOptionIDRef_ { get; set; }
        #region Excel_callableOption_
        private Excel_callableOption excel_callableOption_;
        public Excel_callableOption Excel_callableOption_
        {
            get
            {
                if (this.excel_callableOption_ != null)
                {
                    return this.excel_callableOption_; 
                }
                else if (this.excel_callableOptionIDRef_ != null)
                {
                    excel_callableOption_ = IDManager.getID(excel_callableOptionIDRef_) as Excel_callableOption;
                    return this.excel_callableOption_; 
                }
                else
                {
                    throw new Exception( "excel_callableOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_callableOption_ != value)
                {
                    this.excel_callableOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_callableOptionIDRef_ { get; set; }
        #region Excel_puttableOption_
        private Excel_puttableOption excel_puttableOption_;
        public Excel_puttableOption Excel_puttableOption_
        {
            get
            {
                if (this.excel_puttableOption_ != null)
                {
                    return this.excel_puttableOption_; 
                }
                else if (this.excel_puttableOptionIDRef_ != null)
                {
                    excel_puttableOption_ = IDManager.getID(excel_puttableOptionIDRef_) as Excel_puttableOption;
                    return this.excel_puttableOption_; 
                }
                else
                {
                    throw new Exception( "excel_puttableOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_puttableOption_ != value)
                {
                    this.excel_puttableOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_puttableOptionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

