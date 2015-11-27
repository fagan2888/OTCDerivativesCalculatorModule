using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_schedule : ISerialized
    {
        public Excel_schedule() { }
        public Excel_schedule(XmlNode xmlNode)
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
            
        
            XmlNode excel_additionalOptionNode = xmlNode.SelectSingleNode("excel_additionalOption");
            
            if (excel_additionalOptionNode != null)
            {
                if (excel_additionalOptionNode.Attributes["href"] != null || excel_additionalOptionNode.Attributes["id"] != null) 
                {
                    if (excel_additionalOptionNode.Attributes["id"] != null) 
                    {
                        excel_additionalOptionIDRef_ = excel_additionalOptionNode.Attributes["id"].Value;
                        Excel_additionalOption ob = new Excel_additionalOption(excel_additionalOptionNode);
                        IDManager.SetID(excel_additionalOptionIDRef_, ob);
                    }
                    else if (excel_additionalOptionNode.Attributes["href"] != null)
                    {
                        excel_additionalOptionIDRef_ = excel_additionalOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_additionalOption_ = new Excel_additionalOption(excel_additionalOptionNode);
                    }
                }
                else
                {
                    excel_additionalOption_ = new Excel_additionalOption(excel_additionalOptionNode);
                }
            }
            
        
            XmlNode excel_simpleCalculationNode = xmlNode.SelectSingleNode("excel_simpleCalculation");
            
            if (excel_simpleCalculationNode != null)
            {
                if (excel_simpleCalculationNode.Attributes["href"] != null || excel_simpleCalculationNode.Attributes["id"] != null) 
                {
                    if (excel_simpleCalculationNode.Attributes["id"] != null) 
                    {
                        excel_simpleCalculationIDRef_ = excel_simpleCalculationNode.Attributes["id"].Value;
                        Excel_simpleCalculation ob = new Excel_simpleCalculation(excel_simpleCalculationNode);
                        IDManager.SetID(excel_simpleCalculationIDRef_, ob);
                    }
                    else if (excel_simpleCalculationNode.Attributes["href"] != null)
                    {
                        excel_simpleCalculationIDRef_ = excel_simpleCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_simpleCalculation_ = new Excel_simpleCalculation(excel_simpleCalculationNode);
                    }
                }
                else
                {
                    excel_simpleCalculation_ = new Excel_simpleCalculation(excel_simpleCalculationNode);
                }
            }
            
        
            XmlNode excel_choiceReturnCalculationNode = xmlNode.SelectSingleNode("excel_choiceReturnCalculation");
            
            if (excel_choiceReturnCalculationNode != null)
            {
                if (excel_choiceReturnCalculationNode.Attributes["href"] != null || excel_choiceReturnCalculationNode.Attributes["id"] != null) 
                {
                    if (excel_choiceReturnCalculationNode.Attributes["id"] != null) 
                    {
                        excel_choiceReturnCalculationIDRef_ = excel_choiceReturnCalculationNode.Attributes["id"].Value;
                        Excel_choiceReturnCalculation ob = new Excel_choiceReturnCalculation(excel_choiceReturnCalculationNode);
                        IDManager.SetID(excel_choiceReturnCalculationIDRef_, ob);
                    }
                    else if (excel_choiceReturnCalculationNode.Attributes["href"] != null)
                    {
                        excel_choiceReturnCalculationIDRef_ = excel_choiceReturnCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_choiceReturnCalculation_ = new Excel_choiceReturnCalculation(excel_choiceReturnCalculationNode);
                    }
                }
                else
                {
                    excel_choiceReturnCalculation_ = new Excel_choiceReturnCalculation(excel_choiceReturnCalculationNode);
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
        #region Excel_additionalOption_
        private Excel_additionalOption excel_additionalOption_;
        public Excel_additionalOption Excel_additionalOption_
        {
            get
            {
                if (this.excel_additionalOption_ != null)
                {
                    return this.excel_additionalOption_; 
                }
                else if (this.excel_additionalOptionIDRef_ != null)
                {
                    excel_additionalOption_ = IDManager.getID(excel_additionalOptionIDRef_) as Excel_additionalOption;
                    return this.excel_additionalOption_; 
                }
                else
                {
                    throw new Exception( "excel_additionalOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_additionalOption_ != value)
                {
                    this.excel_additionalOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_additionalOptionIDRef_ { get; set; }
        #region Excel_simpleCalculation_
        private Excel_simpleCalculation excel_simpleCalculation_;
        public Excel_simpleCalculation Excel_simpleCalculation_
        {
            get
            {
                if (this.excel_simpleCalculation_ != null)
                {
                    return this.excel_simpleCalculation_; 
                }
                else if (this.excel_simpleCalculationIDRef_ != null)
                {
                    excel_simpleCalculation_ = IDManager.getID(excel_simpleCalculationIDRef_) as Excel_simpleCalculation;
                    return this.excel_simpleCalculation_; 
                }
                else
                {
                    throw new Exception( "excel_simpleCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_simpleCalculation_ != value)
                {
                    this.excel_simpleCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_simpleCalculationIDRef_ { get; set; }
        #region Excel_choiceReturnCalculation_
        private Excel_choiceReturnCalculation excel_choiceReturnCalculation_;
        public Excel_choiceReturnCalculation Excel_choiceReturnCalculation_
        {
            get
            {
                if (this.excel_choiceReturnCalculation_ != null)
                {
                    return this.excel_choiceReturnCalculation_; 
                }
                else if (this.excel_choiceReturnCalculationIDRef_ != null)
                {
                    excel_choiceReturnCalculation_ = IDManager.getID(excel_choiceReturnCalculationIDRef_) as Excel_choiceReturnCalculation;
                    return this.excel_choiceReturnCalculation_; 
                }
                else
                {
                    throw new Exception( "excel_choiceReturnCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_choiceReturnCalculation_ != value)
                {
                    this.excel_choiceReturnCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_choiceReturnCalculationIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

