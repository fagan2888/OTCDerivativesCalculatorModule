using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_indexType : ISerialized
    {
        public Excel_indexType() { }
        public Excel_indexType(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
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
            
        
            XmlNode rateTypeNode = xmlNode.SelectSingleNode("rateType");
            
            if (rateTypeNode != null)
            {
                if (rateTypeNode.Attributes["href"] != null || rateTypeNode.Attributes["id"] != null) 
                {
                    if (rateTypeNode.Attributes["id"] != null) 
                    {
                        rateTypeIDRef_ = rateTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(rateTypeNode);
                        IDManager.SetID(rateTypeIDRef_, ob);
                    }
                    else if (rateTypeNode.Attributes["href"] != null)
                    {
                        rateTypeIDRef_ = rateTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateType_ = new XsdTypeToken(rateTypeNode);
                    }
                }
                else
                {
                    rateType_ = new XsdTypeToken(rateTypeNode);
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
            
        
        }
        
    
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
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                    throw new Exception( "name_Node no exist!");
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
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
        #region RateType_
        private XsdTypeToken rateType_;
        public XsdTypeToken RateType_
        {
            get
            {
                if (this.rateType_ != null)
                {
                    return this.rateType_; 
                }
                else if (this.rateTypeIDRef_ != null)
                {
                    rateType_ = IDManager.getID(rateTypeIDRef_) as XsdTypeToken;
                    return this.rateType_; 
                }
                else
                {
                    throw new Exception( "rateType_Node no exist!");
                }
            }
            set
            {
                if (this.rateType_ != value)
                {
                    this.rateType_ = value;
                }
            }
        }
        #endregion
        
        public string rateTypeIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

