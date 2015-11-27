using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingResult : ISerialized
    {
        public PricingResult() { }
        public PricingResult(XmlNode xmlNode)
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
            
        
            XmlNode commonResultNode = xmlNode.SelectSingleNode("commonResult");
            
            if (commonResultNode != null)
            {
                if (commonResultNode.Attributes["href"] != null || commonResultNode.Attributes["id"] != null) 
                {
                    if (commonResultNode.Attributes["id"] != null) 
                    {
                        commonResultIDRef_ = commonResultNode.Attributes["id"].Value;
                        CommonResult ob = new CommonResult(commonResultNode);
                        IDManager.SetID(commonResultIDRef_, ob);
                    }
                    else if (commonResultNode.Attributes["href"] != null)
                    {
                        commonResultIDRef_ = commonResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commonResult_ = new CommonResult(commonResultNode);
                    }
                }
                else
                {
                    commonResult_ = new CommonResult(commonResultNode);
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
        #region CommonResult_
        private CommonResult commonResult_;
        public CommonResult CommonResult_
        {
            get
            {
                if (this.commonResult_ != null)
                {
                    return this.commonResult_; 
                }
                else if (this.commonResultIDRef_ != null)
                {
                    commonResult_ = IDManager.getID(commonResultIDRef_) as CommonResult;
                    return this.commonResult_; 
                }
                else
                {
                    throw new Exception( "commonResult_Node no exist!");
                }
            }
            set
            {
                if (this.commonResult_ != value)
                {
                    this.commonResult_ = value;
                }
            }
        }
        #endregion
        
        public string commonResultIDRef_ { get; set; }

        public string choiceStr_resultType;
        
    
        
    
    }
    
}

