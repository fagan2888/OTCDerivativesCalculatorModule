using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_rateInfo : ISerialized
    {
        public Excel_rateInfo() { }
        public Excel_rateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode indexTypeNode = xmlNode.SelectSingleNode("indexType");
            
            if (indexTypeNode != null)
            {
                if (indexTypeNode.Attributes["href"] != null || indexTypeNode.Attributes["id"] != null) 
                {
                    if (indexTypeNode.Attributes["id"] != null) 
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(indexTypeNode);
                        IDManager.SetID(indexTypeIDRef_, ob);
                    }
                    else if (indexTypeNode.Attributes["href"] != null)
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexType_ = new XsdTypeToken(indexTypeNode);
                    }
                }
                else
                {
                    indexType_ = new XsdTypeToken(indexTypeNode);
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
            
        
        }
        
    
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
        #region IndexType_
        private XsdTypeToken indexType_;
        public XsdTypeToken IndexType_
        {
            get
            {
                if (this.indexType_ != null)
                {
                    return this.indexType_; 
                }
                else if (this.indexTypeIDRef_ != null)
                {
                    indexType_ = IDManager.getID(indexTypeIDRef_) as XsdTypeToken;
                    return this.indexType_; 
                }
                else
                {
                    throw new Exception( "indexType_Node no exist!");
                }
            }
            set
            {
                if (this.indexType_ != value)
                {
                    this.indexType_ = value;
                }
            }
        }
        #endregion
        
        public string indexTypeIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

