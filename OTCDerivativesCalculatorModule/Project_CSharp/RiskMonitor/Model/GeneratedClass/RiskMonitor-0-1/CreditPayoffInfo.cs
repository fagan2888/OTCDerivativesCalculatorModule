using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditPayoffInfo : ISerialized
    {
        public CreditPayoffInfo() { }
        public CreditPayoffInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode creditDefaultSwapNode = xmlNode.SelectSingleNode("creditDefaultSwap");
            
            if (creditDefaultSwapNode != null)
            {
                if (creditDefaultSwapNode.Attributes["href"] != null || creditDefaultSwapNode.Attributes["id"] != null) 
                {
                    if (creditDefaultSwapNode.Attributes["id"] != null) 
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["id"].Value;
                        CreditDefaultSwap ob = new CreditDefaultSwap(creditDefaultSwapNode);
                        IDManager.SetID(creditDefaultSwapIDRef_, ob);
                    }
                    else if (creditDefaultSwapNode.Attributes["href"] != null)
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                    }
                }
                else
                {
                    creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region CreditDefaultSwap_
        private CreditDefaultSwap creditDefaultSwap_;
        public CreditDefaultSwap CreditDefaultSwap_
        {
            get
            {
                if (this.creditDefaultSwap_ != null)
                {
                    return this.creditDefaultSwap_; 
                }
                else if (this.creditDefaultSwapIDRef_ != null)
                {
                    creditDefaultSwap_ = IDManager.getID(creditDefaultSwapIDRef_) as CreditDefaultSwap;
                    return this.creditDefaultSwap_; 
                }
                else
                {
                    throw new Exception( "creditDefaultSwap_Node no exist!");
                }
            }
            set
            {
                if (this.creditDefaultSwap_ != value)
                {
                    this.creditDefaultSwap_ = value;
                }
            }
        }
        #endregion
        
        public string creditDefaultSwapIDRef_ { get; set; }
        public string choiceStr_creditPayoffType;
        
    
        
    
    }
    
}

