using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffInfoAnalytic : ISerialized
    {
        public PayoffInfoAnalytic() { }
        public PayoffInfoAnalytic(XmlNode xmlNode)
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
            
        
            XmlNode standardPayoff_ANode = xmlNode.SelectSingleNode("standardPayoff_A");
            
            if (standardPayoff_ANode != null)
            {
                if (standardPayoff_ANode.Attributes["href"] != null || standardPayoff_ANode.Attributes["id"] != null) 
                {
                    if (standardPayoff_ANode.Attributes["id"] != null) 
                    {
                        standardPayoff_AIDRef_ = standardPayoff_ANode.Attributes["id"].Value;
                        StandardPayoff_A ob = new StandardPayoff_A(standardPayoff_ANode);
                        IDManager.SetID(standardPayoff_AIDRef_, ob);
                    }
                    else if (standardPayoff_ANode.Attributes["href"] != null)
                    {
                        standardPayoff_AIDRef_ = standardPayoff_ANode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardPayoff_A_ = new StandardPayoff_A(standardPayoff_ANode);
                    }
                }
                else
                {
                    standardPayoff_A_ = new StandardPayoff_A(standardPayoff_ANode);
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
        #region StandardPayoff_A_
        private StandardPayoff_A standardPayoff_A_;
        public StandardPayoff_A StandardPayoff_A_
        {
            get
            {
                if (this.standardPayoff_A_ != null)
                {
                    return this.standardPayoff_A_; 
                }
                else if (this.standardPayoff_AIDRef_ != null)
                {
                    standardPayoff_A_ = IDManager.getID(standardPayoff_AIDRef_) as StandardPayoff_A;
                    return this.standardPayoff_A_; 
                }
                else
                {
                    throw new Exception( "standardPayoff_A_Node no exist!");
                }
            }
            set
            {
                if (this.standardPayoff_A_ != value)
                {
                    this.standardPayoff_A_ = value;
                }
            }
        }
        #endregion
        
        public string standardPayoff_AIDRef_ { get; set; }
        public string choiceStr_payoffType_A;
        
    
        
    
    }
    
}

