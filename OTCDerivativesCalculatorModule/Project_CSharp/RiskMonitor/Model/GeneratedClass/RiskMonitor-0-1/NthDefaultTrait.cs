using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NthDefaultTrait : ISerialized
    {
        public NthDefaultTrait() { }
        public NthDefaultTrait(XmlNode xmlNode)
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
            
        
            XmlNode nthNode = xmlNode.SelectSingleNode("nth");
            
            if (nthNode != null)
            {
                if (nthNode.Attributes["href"] != null || nthNode.Attributes["id"] != null) 
                {
                    if (nthNode.Attributes["id"] != null) 
                    {
                        nthIDRef_ = nthNode.Attributes["id"].Value;
                        XsdTypeInt ob = new XsdTypeInt(nthNode);
                        IDManager.SetID(nthIDRef_, ob);
                    }
                    else if (nthNode.Attributes["href"] != null)
                    {
                        nthIDRef_ = nthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nth_ = new XsdTypeInt(nthNode);
                    }
                }
                else
                {
                    nth_ = new XsdTypeInt(nthNode);
                }
            }
            
        
            XmlNode correlationNode = xmlNode.SelectSingleNode("correlation");
            
            if (correlationNode != null)
            {
                if (correlationNode.Attributes["href"] != null || correlationNode.Attributes["id"] != null) 
                {
                    if (correlationNode.Attributes["id"] != null) 
                    {
                        correlationIDRef_ = correlationNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(correlationNode);
                        IDManager.SetID(correlationIDRef_, ob);
                    }
                    else if (correlationNode.Attributes["href"] != null)
                    {
                        correlationIDRef_ = correlationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlation_ = new XsdTypeDouble(correlationNode);
                    }
                }
                else
                {
                    correlation_ = new XsdTypeDouble(correlationNode);
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
        #region Nth_
        private XsdTypeInt nth_;
        public XsdTypeInt Nth_
        {
            get
            {
                if (this.nth_ != null)
                {
                    return this.nth_; 
                }
                else if (this.nthIDRef_ != null)
                {
                    nth_ = IDManager.getID(nthIDRef_) as XsdTypeInt;
                    return this.nth_; 
                }
                else
                {
                    throw new Exception( "nth_Node no exist!");
                }
            }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                }
            }
        }
        #endregion
        
        public string nthIDRef_ { get; set; }
        #region Correlation_
        private XsdTypeDouble correlation_;
        public XsdTypeDouble Correlation_
        {
            get
            {
                if (this.correlation_ != null)
                {
                    return this.correlation_; 
                }
                else if (this.correlationIDRef_ != null)
                {
                    correlation_ = IDManager.getID(correlationIDRef_) as XsdTypeDouble;
                    return this.correlation_; 
                }
                else
                {
                    throw new Exception( "correlation_Node no exist!");
                }
            }
            set
            {
                if (this.correlation_ != value)
                {
                    this.correlation_ = value;
                }
            }
        }
        #endregion
        
        public string correlationIDRef_ { get; set; }
        
    
        
    
    }
    
}

