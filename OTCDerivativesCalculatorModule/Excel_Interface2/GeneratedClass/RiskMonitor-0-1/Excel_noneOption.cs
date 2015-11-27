using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_noneOption : ISerialized
    {
        public Excel_noneOption() { }
        public Excel_noneOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode optionTypeNode = xmlNode.SelectSingleNode("optionType");
            
            if (optionTypeNode != null)
            {
                if (optionTypeNode.Attributes["href"] != null || optionTypeNode.Attributes["id"] != null) 
                {
                    if (optionTypeNode.Attributes["id"] != null) 
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new XsdTypeToken(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new XsdTypeToken(optionTypeNode);
                }
            }
            
        
        }
        
    
        #region OptionType_
        private XsdTypeToken optionType_;
        public XsdTypeToken OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as XsdTypeToken;
                    return this.optionType_; 
                }
                else
                {
                    throw new Exception( "optionType_Node no exist!");
                }
            }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                }
            }
        }
        #endregion
        
        public string optionTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

