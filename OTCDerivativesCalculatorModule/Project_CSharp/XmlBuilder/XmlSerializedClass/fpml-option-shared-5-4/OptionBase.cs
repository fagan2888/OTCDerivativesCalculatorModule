using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionBase : Option
    {
        public OptionBase(XmlNode xmlNode)
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
                        OptionTypeEnum ob = new OptionTypeEnum(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new OptionTypeEnum(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new OptionTypeEnum(optionTypeNode);
                }
            }
            
        
        }
        
    
        #region OptionType_
        private OptionTypeEnum optionType_;
        public OptionTypeEnum OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as OptionTypeEnum;
                    return this.optionType_; 
                }
                else
                {
                      return this.optionType_; 
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

