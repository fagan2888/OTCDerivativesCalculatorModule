using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SingleValuationDate : ISerialized
    {
        public SingleValuationDate(XmlNode xmlNode)
        {
            XmlNode businessDaysNode = xmlNode.SelectSingleNode("businessDays");
            
            if (businessDaysNode != null)
            {
                if (businessDaysNode.Attributes["href"] != null || businessDaysNode.Attributes["id"] != null) 
                {
                    if (businessDaysNode.Attributes["id"] != null) 
                    {
                        businessDaysIDRef_ = businessDaysNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(businessDaysNode);
                        IDManager.SetID(businessDaysIDRef_, ob);
                    }
                    else if (businessDaysNode.Attributes["href"] != null)
                    {
                        businessDaysIDRef_ = businessDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDays_ = new XsdTypeNonNegativeInteger(businessDaysNode);
                    }
                }
                else
                {
                    businessDays_ = new XsdTypeNonNegativeInteger(businessDaysNode);
                }
            }
            
        
        }
        
    
        #region BusinessDays_
        private XsdTypeNonNegativeInteger businessDays_;
        public XsdTypeNonNegativeInteger BusinessDays_
        {
            get
            {
                if (this.businessDays_ != null)
                {
                    return this.businessDays_; 
                }
                else if (this.businessDaysIDRef_ != null)
                {
                    businessDays_ = IDManager.getID(businessDaysIDRef_) as XsdTypeNonNegativeInteger;
                    return this.businessDays_; 
                }
                else
                {
                      return this.businessDays_; 
                }
            }
            set
            {
                if (this.businessDays_ != value)
                {
                    this.businessDays_ = value;
                }
            }
        }
        #endregion
        
        public string businessDaysIDRef_ { get; set; }
        
    
        
    
    }
    
}

