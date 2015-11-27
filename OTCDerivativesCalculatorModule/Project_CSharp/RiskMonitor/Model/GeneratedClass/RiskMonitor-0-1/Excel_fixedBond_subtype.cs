using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedBond_subtype : ISerialized
    {
        public Excel_fixedBond_subtype() { }
        public Excel_fixedBond_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_fixedBond_constantRateNode = xmlNode.SelectSingleNode("excel_fixedBond_constantRate");
            
            if (excel_fixedBond_constantRateNode != null)
            {
                if (excel_fixedBond_constantRateNode.Attributes["href"] != null || excel_fixedBond_constantRateNode.Attributes["id"] != null) 
                {
                    if (excel_fixedBond_constantRateNode.Attributes["id"] != null) 
                    {
                        excel_fixedBond_constantRateIDRef_ = excel_fixedBond_constantRateNode.Attributes["id"].Value;
                        Excel_fixedBond_constantRate ob = new Excel_fixedBond_constantRate(excel_fixedBond_constantRateNode);
                        IDManager.SetID(excel_fixedBond_constantRateIDRef_, ob);
                    }
                    else if (excel_fixedBond_constantRateNode.Attributes["href"] != null)
                    {
                        excel_fixedBond_constantRateIDRef_ = excel_fixedBond_constantRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedBond_constantRate_ = new Excel_fixedBond_constantRate(excel_fixedBond_constantRateNode);
                    }
                }
                else
                {
                    excel_fixedBond_constantRate_ = new Excel_fixedBond_constantRate(excel_fixedBond_constantRateNode);
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
        #region Excel_fixedBond_constantRate_
        private Excel_fixedBond_constantRate excel_fixedBond_constantRate_;
        public Excel_fixedBond_constantRate Excel_fixedBond_constantRate_
        {
            get
            {
                if (this.excel_fixedBond_constantRate_ != null)
                {
                    return this.excel_fixedBond_constantRate_; 
                }
                else if (this.excel_fixedBond_constantRateIDRef_ != null)
                {
                    excel_fixedBond_constantRate_ = IDManager.getID(excel_fixedBond_constantRateIDRef_) as Excel_fixedBond_constantRate;
                    return this.excel_fixedBond_constantRate_; 
                }
                else
                {
                    throw new Exception( "excel_fixedBond_constantRate_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedBond_constantRate_ != value)
                {
                    this.excel_fixedBond_constantRate_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedBond_constantRateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

