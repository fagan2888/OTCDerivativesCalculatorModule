using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PhysicalSettlementPeriod : ISerialized
    {
        public PhysicalSettlementPeriod(XmlNode xmlNode)
        {
            XmlNode businessDaysNotSpecifiedNode = xmlNode.SelectSingleNode("businessDaysNotSpecified");
            
            if (businessDaysNotSpecifiedNode != null)
            {
                if (businessDaysNotSpecifiedNode.Attributes["href"] != null || businessDaysNotSpecifiedNode.Attributes["id"] != null) 
                {
                    if (businessDaysNotSpecifiedNode.Attributes["id"] != null) 
                    {
                        businessDaysNotSpecifiedIDRef_ = businessDaysNotSpecifiedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(businessDaysNotSpecifiedNode);
                        IDManager.SetID(businessDaysNotSpecifiedIDRef_, ob);
                    }
                    else if (businessDaysNotSpecifiedNode.Attributes["href"] != null)
                    {
                        businessDaysNotSpecifiedIDRef_ = businessDaysNotSpecifiedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDaysNotSpecified_ = new XsdTypeBoolean(businessDaysNotSpecifiedNode);
                    }
                }
                else
                {
                    businessDaysNotSpecified_ = new XsdTypeBoolean(businessDaysNotSpecifiedNode);
                }
            }
            
        
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
            
        
            XmlNode maximumBusinessDaysNode = xmlNode.SelectSingleNode("maximumBusinessDays");
            
            if (maximumBusinessDaysNode != null)
            {
                if (maximumBusinessDaysNode.Attributes["href"] != null || maximumBusinessDaysNode.Attributes["id"] != null) 
                {
                    if (maximumBusinessDaysNode.Attributes["id"] != null) 
                    {
                        maximumBusinessDaysIDRef_ = maximumBusinessDaysNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(maximumBusinessDaysNode);
                        IDManager.SetID(maximumBusinessDaysIDRef_, ob);
                    }
                    else if (maximumBusinessDaysNode.Attributes["href"] != null)
                    {
                        maximumBusinessDaysIDRef_ = maximumBusinessDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumBusinessDays_ = new XsdTypeNonNegativeInteger(maximumBusinessDaysNode);
                    }
                }
                else
                {
                    maximumBusinessDays_ = new XsdTypeNonNegativeInteger(maximumBusinessDaysNode);
                }
            }
            
        
        }
        
    
        #region BusinessDaysNotSpecified_
        private XsdTypeBoolean businessDaysNotSpecified_;
        public XsdTypeBoolean BusinessDaysNotSpecified_
        {
            get
            {
                if (this.businessDaysNotSpecified_ != null)
                {
                    return this.businessDaysNotSpecified_; 
                }
                else if (this.businessDaysNotSpecifiedIDRef_ != null)
                {
                    businessDaysNotSpecified_ = IDManager.getID(businessDaysNotSpecifiedIDRef_) as XsdTypeBoolean;
                    return this.businessDaysNotSpecified_; 
                }
                else
                {
                      return this.businessDaysNotSpecified_; 
                }
            }
            set
            {
                if (this.businessDaysNotSpecified_ != value)
                {
                    this.businessDaysNotSpecified_ = value;
                }
            }
        }
        #endregion
        
        public string businessDaysNotSpecifiedIDRef_ { get; set; }
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
        #region MaximumBusinessDays_
        private XsdTypeNonNegativeInteger maximumBusinessDays_;
        public XsdTypeNonNegativeInteger MaximumBusinessDays_
        {
            get
            {
                if (this.maximumBusinessDays_ != null)
                {
                    return this.maximumBusinessDays_; 
                }
                else if (this.maximumBusinessDaysIDRef_ != null)
                {
                    maximumBusinessDays_ = IDManager.getID(maximumBusinessDaysIDRef_) as XsdTypeNonNegativeInteger;
                    return this.maximumBusinessDays_; 
                }
                else
                {
                      return this.maximumBusinessDays_; 
                }
            }
            set
            {
                if (this.maximumBusinessDays_ != value)
                {
                    this.maximumBusinessDays_ = value;
                }
            }
        }
        #endregion
        
        public string maximumBusinessDaysIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

