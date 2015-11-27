using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GridCalculation : ISerialized
    {
        public GridCalculation() { }
        public GridCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode inst_codeNode = xmlNode.SelectSingleNode("inst_code");
            
            if (inst_codeNode != null)
            {
                if (inst_codeNode.Attributes["href"] != null || inst_codeNode.Attributes["id"] != null) 
                {
                    if (inst_codeNode.Attributes["id"] != null) 
                    {
                        inst_codeIDRef_ = inst_codeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(inst_codeNode);
                        IDManager.SetID(inst_codeIDRef_, ob);
                    }
                    else if (inst_codeNode.Attributes["href"] != null)
                    {
                        inst_codeIDRef_ = inst_codeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inst_code_ = new XsdTypeToken(inst_codeNode);
                    }
                }
                else
                {
                    inst_code_ = new XsdTypeToken(inst_codeNode);
                }
            }
            
        
            XmlNode inst_nameNode = xmlNode.SelectSingleNode("inst_name");
            
            if (inst_nameNode != null)
            {
                if (inst_nameNode.Attributes["href"] != null || inst_nameNode.Attributes["id"] != null) 
                {
                    if (inst_nameNode.Attributes["id"] != null) 
                    {
                        inst_nameIDRef_ = inst_nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(inst_nameNode);
                        IDManager.SetID(inst_nameIDRef_, ob);
                    }
                    else if (inst_nameNode.Attributes["href"] != null)
                    {
                        inst_nameIDRef_ = inst_nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inst_name_ = new XsdTypeToken(inst_nameNode);
                    }
                }
                else
                {
                    inst_name_ = new XsdTypeToken(inst_nameNode);
                }
            }
            
        
            XmlNode inst_typeNode = xmlNode.SelectSingleNode("inst_type");
            
            if (inst_typeNode != null)
            {
                if (inst_typeNode.Attributes["href"] != null || inst_typeNode.Attributes["id"] != null) 
                {
                    if (inst_typeNode.Attributes["id"] != null) 
                    {
                        inst_typeIDRef_ = inst_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(inst_typeNode);
                        IDManager.SetID(inst_typeIDRef_, ob);
                    }
                    else if (inst_typeNode.Attributes["href"] != null)
                    {
                        inst_typeIDRef_ = inst_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inst_type_ = new XsdTypeToken(inst_typeNode);
                    }
                }
                else
                {
                    inst_type_ = new XsdTypeToken(inst_typeNode);
                }
            }
            
        
            XmlNode para_refDateNode = xmlNode.SelectSingleNode("para_refDate");
            
            if (para_refDateNode != null)
            {
                if (para_refDateNode.Attributes["href"] != null || para_refDateNode.Attributes["id"] != null) 
                {
                    if (para_refDateNode.Attributes["id"] != null) 
                    {
                        para_refDateIDRef_ = para_refDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(para_refDateNode);
                        IDManager.SetID(para_refDateIDRef_, ob);
                    }
                    else if (para_refDateNode.Attributes["href"] != null)
                    {
                        para_refDateIDRef_ = para_refDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        para_refDate_ = new XsdTypeToken(para_refDateNode);
                    }
                }
                else
                {
                    para_refDate_ = new XsdTypeToken(para_refDateNode);
                }
            }
            
        
            XmlNode productInnerXmlNode = xmlNode.SelectSingleNode("productInnerXml");
            
            if (productInnerXmlNode != null)
            {
                if (productInnerXmlNode.Attributes["href"] != null || productInnerXmlNode.Attributes["id"] != null) 
                {
                    if (productInnerXmlNode.Attributes["id"] != null) 
                    {
                        productInnerXmlIDRef_ = productInnerXmlNode.Attributes["id"].Value;
                        ProductInnerXml ob = new ProductInnerXml(productInnerXmlNode);
                        IDManager.SetID(productInnerXmlIDRef_, ob);
                    }
                    else if (productInnerXmlNode.Attributes["href"] != null)
                    {
                        productInnerXmlIDRef_ = productInnerXmlNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productInnerXml_ = new ProductInnerXml(productInnerXmlNode);
                    }
                }
                else
                {
                    productInnerXml_ = new ProductInnerXml(productInnerXmlNode);
                }
            }
            
        
        }
        
    
        #region Inst_code_
        private XsdTypeToken inst_code_;
        public XsdTypeToken Inst_code_
        {
            get
            {
                if (this.inst_code_ != null)
                {
                    return this.inst_code_; 
                }
                else if (this.inst_codeIDRef_ != null)
                {
                    inst_code_ = IDManager.getID(inst_codeIDRef_) as XsdTypeToken;
                    return this.inst_code_; 
                }
                else
                {
                    throw new Exception( "inst_code_Node no exist!");
                }
            }
            set
            {
                if (this.inst_code_ != value)
                {
                    this.inst_code_ = value;
                }
            }
        }
        #endregion
        
        public string inst_codeIDRef_ { get; set; }
        #region Inst_name_
        private XsdTypeToken inst_name_;
        public XsdTypeToken Inst_name_
        {
            get
            {
                if (this.inst_name_ != null)
                {
                    return this.inst_name_; 
                }
                else if (this.inst_nameIDRef_ != null)
                {
                    inst_name_ = IDManager.getID(inst_nameIDRef_) as XsdTypeToken;
                    return this.inst_name_; 
                }
                else
                {
                    throw new Exception( "inst_name_Node no exist!");
                }
            }
            set
            {
                if (this.inst_name_ != value)
                {
                    this.inst_name_ = value;
                }
            }
        }
        #endregion
        
        public string inst_nameIDRef_ { get; set; }
        #region Inst_type_
        private XsdTypeToken inst_type_;
        public XsdTypeToken Inst_type_
        {
            get
            {
                if (this.inst_type_ != null)
                {
                    return this.inst_type_; 
                }
                else if (this.inst_typeIDRef_ != null)
                {
                    inst_type_ = IDManager.getID(inst_typeIDRef_) as XsdTypeToken;
                    return this.inst_type_; 
                }
                else
                {
                    throw new Exception( "inst_type_Node no exist!");
                }
            }
            set
            {
                if (this.inst_type_ != value)
                {
                    this.inst_type_ = value;
                }
            }
        }
        #endregion
        
        public string inst_typeIDRef_ { get; set; }
        #region Para_refDate_
        private XsdTypeToken para_refDate_;
        public XsdTypeToken Para_refDate_
        {
            get
            {
                if (this.para_refDate_ != null)
                {
                    return this.para_refDate_; 
                }
                else if (this.para_refDateIDRef_ != null)
                {
                    para_refDate_ = IDManager.getID(para_refDateIDRef_) as XsdTypeToken;
                    return this.para_refDate_; 
                }
                else
                {
                    throw new Exception( "para_refDate_Node no exist!");
                }
            }
            set
            {
                if (this.para_refDate_ != value)
                {
                    this.para_refDate_ = value;
                }
            }
        }
        #endregion
        
        public string para_refDateIDRef_ { get; set; }
        #region ProductInnerXml_
        private ProductInnerXml productInnerXml_;
        public ProductInnerXml ProductInnerXml_
        {
            get
            {
                if (this.productInnerXml_ != null)
                {
                    return this.productInnerXml_; 
                }
                else if (this.productInnerXmlIDRef_ != null)
                {
                    productInnerXml_ = IDManager.getID(productInnerXmlIDRef_) as ProductInnerXml;
                    return this.productInnerXml_; 
                }
                else
                {
                    throw new Exception( "productInnerXml_Node no exist!");
                }
            }
            set
            {
                if (this.productInnerXml_ != value)
                {
                    this.productInnerXml_ = value;
                }
            }
        }
        #endregion
        
        public string productInnerXmlIDRef_ { get; set; }
        
    
        
    
    }
    
}

