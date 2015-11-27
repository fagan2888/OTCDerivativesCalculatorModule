using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingInfo_para : ISerialized
    {
        public Excel_underlyingInfo_para() { }
        public Excel_underlyingInfo_para(XmlNode xmlNode)
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
            
        
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode underNameNode = xmlNode.SelectSingleNode("underName");
            
            if (underNameNode != null)
            {
                if (underNameNode.Attributes["href"] != null || underNameNode.Attributes["id"] != null) 
                {
                    if (underNameNode.Attributes["id"] != null) 
                    {
                        underNameIDRef_ = underNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underNameNode);
                        IDManager.SetID(underNameIDRef_, ob);
                    }
                    else if (underNameNode.Attributes["href"] != null)
                    {
                        underNameIDRef_ = underNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underName_ = new XsdTypeToken(underNameNode);
                    }
                }
                else
                {
                    underName_ = new XsdTypeToken(underNameNode);
                }
            }
            
        
            XmlNode modelNode = xmlNode.SelectSingleNode("model");
            
            if (modelNode != null)
            {
                if (modelNode.Attributes["href"] != null || modelNode.Attributes["id"] != null) 
                {
                    if (modelNode.Attributes["id"] != null) 
                    {
                        modelIDRef_ = modelNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(modelNode);
                        IDManager.SetID(modelIDRef_, ob);
                    }
                    else if (modelNode.Attributes["href"] != null)
                    {
                        modelIDRef_ = modelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        model_ = new XsdTypeToken(modelNode);
                    }
                }
                else
                {
                    model_ = new XsdTypeToken(modelNode);
                }
            }
            
        
            XmlNode basePriceNode = xmlNode.SelectSingleNode("basePrice");
            
            if (basePriceNode != null)
            {
                if (basePriceNode.Attributes["href"] != null || basePriceNode.Attributes["id"] != null) 
                {
                    if (basePriceNode.Attributes["id"] != null) 
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(basePriceNode);
                        IDManager.SetID(basePriceIDRef_, ob);
                    }
                    else if (basePriceNode.Attributes["href"] != null)
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basePrice_ = new XsdTypeToken(basePriceNode);
                    }
                }
                else
                {
                    basePrice_ = new XsdTypeToken(basePriceNode);
                }
            }
            
        
            XmlNode excel_underlyingModel_paraNode = xmlNode.SelectSingleNode("excel_underlyingModel_para");
            
            if (excel_underlyingModel_paraNode != null)
            {
                if (excel_underlyingModel_paraNode.Attributes["href"] != null || excel_underlyingModel_paraNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingModel_paraNode.Attributes["id"] != null) 
                    {
                        excel_underlyingModel_paraIDRef_ = excel_underlyingModel_paraNode.Attributes["id"].Value;
                        Excel_underlyingModel_para ob = new Excel_underlyingModel_para(excel_underlyingModel_paraNode);
                        IDManager.SetID(excel_underlyingModel_paraIDRef_, ob);
                    }
                    else if (excel_underlyingModel_paraNode.Attributes["href"] != null)
                    {
                        excel_underlyingModel_paraIDRef_ = excel_underlyingModel_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingModel_para_ = new Excel_underlyingModel_para(excel_underlyingModel_paraNode);
                    }
                }
                else
                {
                    excel_underlyingModel_para_ = new Excel_underlyingModel_para(excel_underlyingModel_paraNode);
                }
            }
            
        
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeToken(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeToken(valueNode);
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeToken(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeToken(descriptionNode);
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
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region UnderName_
        private XsdTypeToken underName_;
        public XsdTypeToken UnderName_
        {
            get
            {
                if (this.underName_ != null)
                {
                    return this.underName_; 
                }
                else if (this.underNameIDRef_ != null)
                {
                    underName_ = IDManager.getID(underNameIDRef_) as XsdTypeToken;
                    return this.underName_; 
                }
                else
                {
                    throw new Exception( "underName_Node no exist!");
                }
            }
            set
            {
                if (this.underName_ != value)
                {
                    this.underName_ = value;
                }
            }
        }
        #endregion
        
        public string underNameIDRef_ { get; set; }
        #region Model_
        private XsdTypeToken model_;
        public XsdTypeToken Model_
        {
            get
            {
                if (this.model_ != null)
                {
                    return this.model_; 
                }
                else if (this.modelIDRef_ != null)
                {
                    model_ = IDManager.getID(modelIDRef_) as XsdTypeToken;
                    return this.model_; 
                }
                else
                {
                    throw new Exception( "model_Node no exist!");
                }
            }
            set
            {
                if (this.model_ != value)
                {
                    this.model_ = value;
                }
            }
        }
        #endregion
        
        public string modelIDRef_ { get; set; }
        #region BasePrice_
        private XsdTypeToken basePrice_;
        public XsdTypeToken BasePrice_
        {
            get
            {
                if (this.basePrice_ != null)
                {
                    return this.basePrice_; 
                }
                else if (this.basePriceIDRef_ != null)
                {
                    basePrice_ = IDManager.getID(basePriceIDRef_) as XsdTypeToken;
                    return this.basePrice_; 
                }
                else
                {
                    throw new Exception( "basePrice_Node no exist!");
                }
            }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                }
            }
        }
        #endregion
        
        public string basePriceIDRef_ { get; set; }
        #region Excel_underlyingModel_para_
        private Excel_underlyingModel_para excel_underlyingModel_para_;
        public Excel_underlyingModel_para Excel_underlyingModel_para_
        {
            get
            {
                if (this.excel_underlyingModel_para_ != null)
                {
                    return this.excel_underlyingModel_para_; 
                }
                else if (this.excel_underlyingModel_paraIDRef_ != null)
                {
                    excel_underlyingModel_para_ = IDManager.getID(excel_underlyingModel_paraIDRef_) as Excel_underlyingModel_para;
                    return this.excel_underlyingModel_para_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingModel_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingModel_para_ != value)
                {
                    this.excel_underlyingModel_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingModel_paraIDRef_ { get; set; }
        #region Value_
        private XsdTypeToken value_;
        public XsdTypeToken Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeToken;
                    return this.value_; 
                }
                else
                {
                    throw new Exception( "value_Node no exist!");
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        #region Description_
        private XsdTypeToken description_;
        public XsdTypeToken Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeToken;
                    return this.description_; 
                }
                else
                {
                    throw new Exception( "description_Node no exist!");
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

