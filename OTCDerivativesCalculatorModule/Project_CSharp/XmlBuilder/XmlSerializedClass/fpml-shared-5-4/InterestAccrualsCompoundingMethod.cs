using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestAccrualsCompoundingMethod : InterestAccrualsMethod
    {
        public InterestAccrualsCompoundingMethod(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode compoundingMethodNode = xmlNode.SelectSingleNode("compoundingMethod");
            
            if (compoundingMethodNode != null)
            {
                if (compoundingMethodNode.Attributes["href"] != null || compoundingMethodNode.Attributes["id"] != null) 
                {
                    if (compoundingMethodNode.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["id"].Value;
                        CompoundingMethodEnum ob = new CompoundingMethodEnum(compoundingMethodNode);
                        IDManager.SetID(compoundingMethodIDRef_, ob);
                    }
                    else if (compoundingMethodNode.Attributes["href"] != null)
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                    }
                }
                else
                {
                    compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                }
            }
            
        
        }
        
    
        #region CompoundingMethod_
        private CompoundingMethodEnum compoundingMethod_;
        public CompoundingMethodEnum CompoundingMethod_
        {
            get
            {
                if (this.compoundingMethod_ != null)
                {
                    return this.compoundingMethod_; 
                }
                else if (this.compoundingMethodIDRef_ != null)
                {
                    compoundingMethod_ = IDManager.getID(compoundingMethodIDRef_) as CompoundingMethodEnum;
                    return this.compoundingMethod_; 
                }
                else
                {
                      return this.compoundingMethod_; 
                }
            }
            set
            {
                if (this.compoundingMethod_ != value)
                {
                    this.compoundingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingMethodIDRef_ { get; set; }
        
    
        
    
    }
    
}

