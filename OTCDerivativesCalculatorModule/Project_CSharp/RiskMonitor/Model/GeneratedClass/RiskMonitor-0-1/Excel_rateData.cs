using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_rateData : ISerialized
    {
        public Excel_rateData() { }
        public Excel_rateData(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}

