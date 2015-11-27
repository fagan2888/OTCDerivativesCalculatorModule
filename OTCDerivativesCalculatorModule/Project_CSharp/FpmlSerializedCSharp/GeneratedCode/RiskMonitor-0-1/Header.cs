using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Header : ISerialized
    {
        public Header() { }
        public Header(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode productNameNode = xmlNode.SelectSingleNode("productName");
            
            if (productNameNode != null)
            {
                if (productNameNode.Attributes["href"] != null || productNameNode.Attributes["id"] != null) 
                {
                    if (productNameNode.Attributes["id"] != null) 
                    {
                        productNameIDRef_ = productNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(productNameNode);
                        IDManager.SetID(productNameIDRef_, ob);
                    }
                    else if (productNameNode.Attributes["href"] != null)
                    {
                        productNameIDRef_ = productNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productName_ = new XsdTypeToken(productNameNode);
                    }
                }
                else
                {
                    productName_ = new XsdTypeToken(productNameNode);
                }
            }
            
        
            XmlNode productTypeNode = xmlNode.SelectSingleNode("productType");
            
            if (productTypeNode != null)
            {
                if (productTypeNode.Attributes["href"] != null || productTypeNode.Attributes["id"] != null) 
                {
                    if (productTypeNode.Attributes["id"] != null) 
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(productTypeNode);
                        IDManager.SetID(productTypeIDRef_, ob);
                    }
                    else if (productTypeNode.Attributes["href"] != null)
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productType_ = new XsdTypeToken(productTypeNode);
                    }
                }
                else
                {
                    productType_ = new XsdTypeToken(productTypeNode);
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
            
        
        }
        
    
        #region ProductName_
        private XsdTypeToken productName_;
        public XsdTypeToken ProductName_
        {
            get
            {
                if (this.productName_ != null)
                {
                    return this.productName_; 
                }
                else if (this.productNameIDRef_ != null)
                {
                    productName_ = IDManager.getID(productNameIDRef_) as XsdTypeToken;
                    return this.productName_; 
                }
                else
                {
                      return this.productName_; 
                }
            }
            set
            {
                if (this.productName_ != value)
                {
                    this.productName_ = value;
                }
            }
        }
        #endregion
        
        public string productNameIDRef_ { get; set; }
        #region ProductType_
        private XsdTypeToken productType_;
        public XsdTypeToken ProductType_
        {
            get
            {
                if (this.productType_ != null)
                {
                    return this.productType_; 
                }
                else if (this.productTypeIDRef_ != null)
                {
                    productType_ = IDManager.getID(productTypeIDRef_) as XsdTypeToken;
                    return this.productType_; 
                }
                else
                {
                      return this.productType_; 
                }
            }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                }
            }
        }
        #endregion
        
        public string productTypeIDRef_ { get; set; }
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
                      return this.krCode_; 
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
        
    
        
    
    }
    
}

