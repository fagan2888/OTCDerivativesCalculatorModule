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
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeToken(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeToken(currencyNode);
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
            
        
            XmlNode sub_typeNode = xmlNode.SelectSingleNode("sub_type");
            
            if (sub_typeNode != null)
            {
                if (sub_typeNode.Attributes["href"] != null || sub_typeNode.Attributes["id"] != null) 
                {
                    if (sub_typeNode.Attributes["id"] != null) 
                    {
                        sub_typeIDRef_ = sub_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(sub_typeNode);
                        IDManager.SetID(sub_typeIDRef_, ob);
                    }
                    else if (sub_typeNode.Attributes["href"] != null)
                    {
                        sub_typeIDRef_ = sub_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sub_type_ = new XsdTypeToken(sub_typeNode);
                    }
                }
                else
                {
                    sub_type_ = new XsdTypeToken(sub_typeNode);
                }
            }
            
        
            XmlNode rate_typeNode = xmlNode.SelectSingleNode("rate_type");
            
            if (rate_typeNode != null)
            {
                if (rate_typeNode.Attributes["href"] != null || rate_typeNode.Attributes["id"] != null) 
                {
                    if (rate_typeNode.Attributes["id"] != null) 
                    {
                        rate_typeIDRef_ = rate_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(rate_typeNode);
                        IDManager.SetID(rate_typeIDRef_, ob);
                    }
                    else if (rate_typeNode.Attributes["href"] != null)
                    {
                        rate_typeIDRef_ = rate_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rate_type_ = new XsdTypeToken(rate_typeNode);
                    }
                }
                else
                {
                    rate_type_ = new XsdTypeToken(rate_typeNode);
                }
            }
            
        
            XmlNode tenorNode = xmlNode.SelectSingleNode("tenor");
            
            if (tenorNode != null)
            {
                if (tenorNode.Attributes["href"] != null || tenorNode.Attributes["id"] != null) 
                {
                    if (tenorNode.Attributes["id"] != null) 
                    {
                        tenorIDRef_ = tenorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new XsdTypeToken(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new XsdTypeToken(tenorNode);
                }
            }
            
        
            XmlNode legTenorNode = xmlNode.SelectSingleNode("legTenor");
            
            if (legTenorNode != null)
            {
                if (legTenorNode.Attributes["href"] != null || legTenorNode.Attributes["id"] != null) 
                {
                    if (legTenorNode.Attributes["id"] != null) 
                    {
                        legTenorIDRef_ = legTenorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(legTenorNode);
                        IDManager.SetID(legTenorIDRef_, ob);
                    }
                    else if (legTenorNode.Attributes["href"] != null)
                    {
                        legTenorIDRef_ = legTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        legTenor_ = new XsdTypeToken(legTenorNode);
                    }
                }
                else
                {
                    legTenor_ = new XsdTypeToken(legTenorNode);
                }
            }
            
        
            XmlNode linkedCurveNode = xmlNode.SelectSingleNode("linkedCurve");
            
            if (linkedCurveNode != null)
            {
                if (linkedCurveNode.Attributes["href"] != null || linkedCurveNode.Attributes["id"] != null) 
                {
                    if (linkedCurveNode.Attributes["id"] != null) 
                    {
                        linkedCurveIDRef_ = linkedCurveNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(linkedCurveNode);
                        IDManager.SetID(linkedCurveIDRef_, ob);
                    }
                    else if (linkedCurveNode.Attributes["href"] != null)
                    {
                        linkedCurveIDRef_ = linkedCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        linkedCurve_ = new XsdTypeToken(linkedCurveNode);
                    }
                }
                else
                {
                    linkedCurve_ = new XsdTypeToken(linkedCurveNode);
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
        #region Currency_
        private XsdTypeToken currency_;
        public XsdTypeToken Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeToken;
                    return this.currency_; 
                }
                else
                {
                    throw new Exception( "currency_Node no exist!");
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
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
        #region Sub_type_
        private XsdTypeToken sub_type_;
        public XsdTypeToken Sub_type_
        {
            get
            {
                if (this.sub_type_ != null)
                {
                    return this.sub_type_; 
                }
                else if (this.sub_typeIDRef_ != null)
                {
                    sub_type_ = IDManager.getID(sub_typeIDRef_) as XsdTypeToken;
                    return this.sub_type_; 
                }
                else
                {
                    throw new Exception( "sub_type_Node no exist!");
                }
            }
            set
            {
                if (this.sub_type_ != value)
                {
                    this.sub_type_ = value;
                }
            }
        }
        #endregion
        
        public string sub_typeIDRef_ { get; set; }
        #region Rate_type_
        private XsdTypeToken rate_type_;
        public XsdTypeToken Rate_type_
        {
            get
            {
                if (this.rate_type_ != null)
                {
                    return this.rate_type_; 
                }
                else if (this.rate_typeIDRef_ != null)
                {
                    rate_type_ = IDManager.getID(rate_typeIDRef_) as XsdTypeToken;
                    return this.rate_type_; 
                }
                else
                {
                    throw new Exception( "rate_type_Node no exist!");
                }
            }
            set
            {
                if (this.rate_type_ != value)
                {
                    this.rate_type_ = value;
                }
            }
        }
        #endregion
        
        public string rate_typeIDRef_ { get; set; }
        #region Tenor_
        private XsdTypeToken tenor_;
        public XsdTypeToken Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as XsdTypeToken;
                    return this.tenor_; 
                }
                else
                {
                    throw new Exception( "tenor_Node no exist!");
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region LegTenor_
        private XsdTypeToken legTenor_;
        public XsdTypeToken LegTenor_
        {
            get
            {
                if (this.legTenor_ != null)
                {
                    return this.legTenor_; 
                }
                else if (this.legTenorIDRef_ != null)
                {
                    legTenor_ = IDManager.getID(legTenorIDRef_) as XsdTypeToken;
                    return this.legTenor_; 
                }
                else
                {
                    throw new Exception( "legTenor_Node no exist!");
                }
            }
            set
            {
                if (this.legTenor_ != value)
                {
                    this.legTenor_ = value;
                }
            }
        }
        #endregion
        
        public string legTenorIDRef_ { get; set; }
        #region LinkedCurve_
        private XsdTypeToken linkedCurve_;
        public XsdTypeToken LinkedCurve_
        {
            get
            {
                if (this.linkedCurve_ != null)
                {
                    return this.linkedCurve_; 
                }
                else if (this.linkedCurveIDRef_ != null)
                {
                    linkedCurve_ = IDManager.getID(linkedCurveIDRef_) as XsdTypeToken;
                    return this.linkedCurve_; 
                }
                else
                {
                    throw new Exception( "linkedCurve_Node no exist!");
                }
            }
            set
            {
                if (this.linkedCurve_ != value)
                {
                    this.linkedCurve_ = value;
                }
            }
        }
        #endregion
        
        public string linkedCurveIDRef_ { get; set; }
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

