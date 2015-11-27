using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceCal_ID : ISerialized
    {
        public Excel_referenceCal_ID() { }
        public Excel_referenceCal_ID(XmlNode xmlNode)
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
            
        
            XmlNode excel_referSimpleCalculationNode = xmlNode.SelectSingleNode("excel_referSimpleCalculation");
            
            if (excel_referSimpleCalculationNode != null)
            {
                if (excel_referSimpleCalculationNode.Attributes["href"] != null || excel_referSimpleCalculationNode.Attributes["id"] != null) 
                {
                    if (excel_referSimpleCalculationNode.Attributes["id"] != null) 
                    {
                        excel_referSimpleCalculationIDRef_ = excel_referSimpleCalculationNode.Attributes["id"].Value;
                        Excel_referSimpleCalculation ob = new Excel_referSimpleCalculation(excel_referSimpleCalculationNode);
                        IDManager.SetID(excel_referSimpleCalculationIDRef_, ob);
                    }
                    else if (excel_referSimpleCalculationNode.Attributes["href"] != null)
                    {
                        excel_referSimpleCalculationIDRef_ = excel_referSimpleCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_referSimpleCalculation_ = new Excel_referSimpleCalculation(excel_referSimpleCalculationNode);
                    }
                }
                else
                {
                    excel_referSimpleCalculation_ = new Excel_referSimpleCalculation(excel_referSimpleCalculationNode);
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
        #region Excel_referSimpleCalculation_
        private Excel_referSimpleCalculation excel_referSimpleCalculation_;
        public Excel_referSimpleCalculation Excel_referSimpleCalculation_
        {
            get
            {
                if (this.excel_referSimpleCalculation_ != null)
                {
                    return this.excel_referSimpleCalculation_; 
                }
                else if (this.excel_referSimpleCalculationIDRef_ != null)
                {
                    excel_referSimpleCalculation_ = IDManager.getID(excel_referSimpleCalculationIDRef_) as Excel_referSimpleCalculation;
                    return this.excel_referSimpleCalculation_; 
                }
                else
                {
                    throw new Exception( "excel_referSimpleCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referSimpleCalculation_ != value)
                {
                    this.excel_referSimpleCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referSimpleCalculationIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

