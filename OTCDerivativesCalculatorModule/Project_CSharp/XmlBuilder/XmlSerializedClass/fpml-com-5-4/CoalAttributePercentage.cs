using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalAttributePercentage : ISerialized
    {
        public CoalAttributePercentage(XmlNode xmlNode)
        {
            XmlNode standardContentNode = xmlNode.SelectSingleNode("standardContent");
            
            if (standardContentNode != null)
            {
                if (standardContentNode.Attributes["href"] != null || standardContentNode.Attributes["id"] != null) 
                {
                    if (standardContentNode.Attributes["id"] != null) 
                    {
                        standardContentIDRef_ = standardContentNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(standardContentNode);
                        IDManager.SetID(standardContentIDRef_, ob);
                    }
                    else if (standardContentNode.Attributes["href"] != null)
                    {
                        standardContentIDRef_ = standardContentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardContent_ = new RestrictedPercentage(standardContentNode);
                    }
                }
                else
                {
                    standardContent_ = new RestrictedPercentage(standardContentNode);
                }
            }
            
        
            XmlNode rejectionLimitNode = xmlNode.SelectSingleNode("rejectionLimit");
            
            if (rejectionLimitNode != null)
            {
                if (rejectionLimitNode.Attributes["href"] != null || rejectionLimitNode.Attributes["id"] != null) 
                {
                    if (rejectionLimitNode.Attributes["id"] != null) 
                    {
                        rejectionLimitIDRef_ = rejectionLimitNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(rejectionLimitNode);
                        IDManager.SetID(rejectionLimitIDRef_, ob);
                    }
                    else if (rejectionLimitNode.Attributes["href"] != null)
                    {
                        rejectionLimitIDRef_ = rejectionLimitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rejectionLimit_ = new RestrictedPercentage(rejectionLimitNode);
                    }
                }
                else
                {
                    rejectionLimit_ = new RestrictedPercentage(rejectionLimitNode);
                }
            }
            
        
        }
        
    
        #region StandardContent_
        private RestrictedPercentage standardContent_;
        public RestrictedPercentage StandardContent_
        {
            get
            {
                if (this.standardContent_ != null)
                {
                    return this.standardContent_; 
                }
                else if (this.standardContentIDRef_ != null)
                {
                    standardContent_ = IDManager.getID(standardContentIDRef_) as RestrictedPercentage;
                    return this.standardContent_; 
                }
                else
                {
                      return this.standardContent_; 
                }
            }
            set
            {
                if (this.standardContent_ != value)
                {
                    this.standardContent_ = value;
                }
            }
        }
        #endregion
        
        public string standardContentIDRef_ { get; set; }
        #region RejectionLimit_
        private RestrictedPercentage rejectionLimit_;
        public RestrictedPercentage RejectionLimit_
        {
            get
            {
                if (this.rejectionLimit_ != null)
                {
                    return this.rejectionLimit_; 
                }
                else if (this.rejectionLimitIDRef_ != null)
                {
                    rejectionLimit_ = IDManager.getID(rejectionLimitIDRef_) as RestrictedPercentage;
                    return this.rejectionLimit_; 
                }
                else
                {
                      return this.rejectionLimit_; 
                }
            }
            set
            {
                if (this.rejectionLimit_ != value)
                {
                    this.rejectionLimit_ = value;
                }
            }
        }
        #endregion
        
        public string rejectionLimitIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

