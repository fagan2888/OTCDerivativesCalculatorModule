using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_kiEventCalculation : ISerialized
    {
        public Excel_kiEventCalculation() { }
        public Excel_kiEventCalculation(XmlNode xmlNode)
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
            
        
            XmlNode excel_simpleKiEventCalcNode = xmlNode.SelectSingleNode("excel_simpleKiEventCalc");
            
            if (excel_simpleKiEventCalcNode != null)
            {
                if (excel_simpleKiEventCalcNode.Attributes["href"] != null || excel_simpleKiEventCalcNode.Attributes["id"] != null) 
                {
                    if (excel_simpleKiEventCalcNode.Attributes["id"] != null) 
                    {
                        excel_simpleKiEventCalcIDRef_ = excel_simpleKiEventCalcNode.Attributes["id"].Value;
                        Excel_simpleKiEventCalc ob = new Excel_simpleKiEventCalc(excel_simpleKiEventCalcNode);
                        IDManager.SetID(excel_simpleKiEventCalcIDRef_, ob);
                    }
                    else if (excel_simpleKiEventCalcNode.Attributes["href"] != null)
                    {
                        excel_simpleKiEventCalcIDRef_ = excel_simpleKiEventCalcNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_simpleKiEventCalc_ = new Excel_simpleKiEventCalc(excel_simpleKiEventCalcNode);
                    }
                }
                else
                {
                    excel_simpleKiEventCalc_ = new Excel_simpleKiEventCalc(excel_simpleKiEventCalcNode);
                }
            }
            
        
            XmlNode excel_dualKiEventCalcNode = xmlNode.SelectSingleNode("excel_dualKiEventCalc");
            
            if (excel_dualKiEventCalcNode != null)
            {
                if (excel_dualKiEventCalcNode.Attributes["href"] != null || excel_dualKiEventCalcNode.Attributes["id"] != null) 
                {
                    if (excel_dualKiEventCalcNode.Attributes["id"] != null) 
                    {
                        excel_dualKiEventCalcIDRef_ = excel_dualKiEventCalcNode.Attributes["id"].Value;
                        Excel_dualKiEventCalc ob = new Excel_dualKiEventCalc(excel_dualKiEventCalcNode);
                        IDManager.SetID(excel_dualKiEventCalcIDRef_, ob);
                    }
                    else if (excel_dualKiEventCalcNode.Attributes["href"] != null)
                    {
                        excel_dualKiEventCalcIDRef_ = excel_dualKiEventCalcNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_dualKiEventCalc_ = new Excel_dualKiEventCalc(excel_dualKiEventCalcNode);
                    }
                }
                else
                {
                    excel_dualKiEventCalc_ = new Excel_dualKiEventCalc(excel_dualKiEventCalcNode);
                }
            }
            
        
            XmlNode excel_targetKiEventCalcNode = xmlNode.SelectSingleNode("excel_targetKiEventCalc");
            
            if (excel_targetKiEventCalcNode != null)
            {
                if (excel_targetKiEventCalcNode.Attributes["href"] != null || excel_targetKiEventCalcNode.Attributes["id"] != null) 
                {
                    if (excel_targetKiEventCalcNode.Attributes["id"] != null) 
                    {
                        excel_targetKiEventCalcIDRef_ = excel_targetKiEventCalcNode.Attributes["id"].Value;
                        Excel_targetKiEventCalc ob = new Excel_targetKiEventCalc(excel_targetKiEventCalcNode);
                        IDManager.SetID(excel_targetKiEventCalcIDRef_, ob);
                    }
                    else if (excel_targetKiEventCalcNode.Attributes["href"] != null)
                    {
                        excel_targetKiEventCalcIDRef_ = excel_targetKiEventCalcNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_targetKiEventCalc_ = new Excel_targetKiEventCalc(excel_targetKiEventCalcNode);
                    }
                }
                else
                {
                    excel_targetKiEventCalc_ = new Excel_targetKiEventCalc(excel_targetKiEventCalcNode);
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
        #region Excel_simpleKiEventCalc_
        private Excel_simpleKiEventCalc excel_simpleKiEventCalc_;
        public Excel_simpleKiEventCalc Excel_simpleKiEventCalc_
        {
            get
            {
                if (this.excel_simpleKiEventCalc_ != null)
                {
                    return this.excel_simpleKiEventCalc_; 
                }
                else if (this.excel_simpleKiEventCalcIDRef_ != null)
                {
                    excel_simpleKiEventCalc_ = IDManager.getID(excel_simpleKiEventCalcIDRef_) as Excel_simpleKiEventCalc;
                    return this.excel_simpleKiEventCalc_; 
                }
                else
                {
                    throw new Exception( "excel_simpleKiEventCalc_Node no exist!");
                }
            }
            set
            {
                if (this.excel_simpleKiEventCalc_ != value)
                {
                    this.excel_simpleKiEventCalc_ = value;
                }
            }
        }
        #endregion
        
        public string excel_simpleKiEventCalcIDRef_ { get; set; }
        #region Excel_dualKiEventCalc_
        private Excel_dualKiEventCalc excel_dualKiEventCalc_;
        public Excel_dualKiEventCalc Excel_dualKiEventCalc_
        {
            get
            {
                if (this.excel_dualKiEventCalc_ != null)
                {
                    return this.excel_dualKiEventCalc_; 
                }
                else if (this.excel_dualKiEventCalcIDRef_ != null)
                {
                    excel_dualKiEventCalc_ = IDManager.getID(excel_dualKiEventCalcIDRef_) as Excel_dualKiEventCalc;
                    return this.excel_dualKiEventCalc_; 
                }
                else
                {
                    throw new Exception( "excel_dualKiEventCalc_Node no exist!");
                }
            }
            set
            {
                if (this.excel_dualKiEventCalc_ != value)
                {
                    this.excel_dualKiEventCalc_ = value;
                }
            }
        }
        #endregion
        
        public string excel_dualKiEventCalcIDRef_ { get; set; }
        #region Excel_targetKiEventCalc_
        private Excel_targetKiEventCalc excel_targetKiEventCalc_;
        public Excel_targetKiEventCalc Excel_targetKiEventCalc_
        {
            get
            {
                if (this.excel_targetKiEventCalc_ != null)
                {
                    return this.excel_targetKiEventCalc_; 
                }
                else if (this.excel_targetKiEventCalcIDRef_ != null)
                {
                    excel_targetKiEventCalc_ = IDManager.getID(excel_targetKiEventCalcIDRef_) as Excel_targetKiEventCalc;
                    return this.excel_targetKiEventCalc_; 
                }
                else
                {
                    throw new Exception( "excel_targetKiEventCalc_Node no exist!");
                }
            }
            set
            {
                if (this.excel_targetKiEventCalc_ != value)
                {
                    this.excel_targetKiEventCalc_ = value;
                }
            }
        }
        #endregion
        
        public string excel_targetKiEventCalcIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

