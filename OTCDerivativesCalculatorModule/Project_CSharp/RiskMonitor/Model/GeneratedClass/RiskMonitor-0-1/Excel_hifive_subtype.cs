using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hifive_subtype : ISerialized
    {
        public Excel_hifive_subtype() { }
        public Excel_hifive_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_hifive_stepDown_kiNode = xmlNode.SelectSingleNode("excel_hifive_stepDown_ki");
            
            if (excel_hifive_stepDown_kiNode != null)
            {
                if (excel_hifive_stepDown_kiNode.Attributes["href"] != null || excel_hifive_stepDown_kiNode.Attributes["id"] != null) 
                {
                    if (excel_hifive_stepDown_kiNode.Attributes["id"] != null) 
                    {
                        excel_hifive_stepDown_kiIDRef_ = excel_hifive_stepDown_kiNode.Attributes["id"].Value;
                        Excel_hifive_stepDown_ki ob = new Excel_hifive_stepDown_ki(excel_hifive_stepDown_kiNode);
                        IDManager.SetID(excel_hifive_stepDown_kiIDRef_, ob);
                    }
                    else if (excel_hifive_stepDown_kiNode.Attributes["href"] != null)
                    {
                        excel_hifive_stepDown_kiIDRef_ = excel_hifive_stepDown_kiNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hifive_stepDown_ki_ = new Excel_hifive_stepDown_ki(excel_hifive_stepDown_kiNode);
                    }
                }
                else
                {
                    excel_hifive_stepDown_ki_ = new Excel_hifive_stepDown_ki(excel_hifive_stepDown_kiNode);
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
        #region Excel_hifive_stepDown_ki_
        private Excel_hifive_stepDown_ki excel_hifive_stepDown_ki_;
        public Excel_hifive_stepDown_ki Excel_hifive_stepDown_ki_
        {
            get
            {
                if (this.excel_hifive_stepDown_ki_ != null)
                {
                    return this.excel_hifive_stepDown_ki_; 
                }
                else if (this.excel_hifive_stepDown_kiIDRef_ != null)
                {
                    excel_hifive_stepDown_ki_ = IDManager.getID(excel_hifive_stepDown_kiIDRef_) as Excel_hifive_stepDown_ki;
                    return this.excel_hifive_stepDown_ki_; 
                }
                else
                {
                    throw new Exception( "excel_hifive_stepDown_ki_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hifive_stepDown_ki_ != value)
                {
                    this.excel_hifive_stepDown_ki_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hifive_stepDown_kiIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

