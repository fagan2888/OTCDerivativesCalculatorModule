using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Reason : ISerialized
    {
        public Reason(XmlNode xmlNode)
        {
            XmlNode reasonCodeNode = xmlNode.SelectSingleNode("reasonCode");
            
            if (reasonCodeNode != null)
            {
                if (reasonCodeNode.Attributes["href"] != null || reasonCodeNode.Attributes["id"] != null) 
                {
                    if (reasonCodeNode.Attributes["id"] != null) 
                    {
                        reasonCodeIDRef_ = reasonCodeNode.Attributes["id"].Value;
                        ReasonCode ob = new ReasonCode(reasonCodeNode);
                        IDManager.SetID(reasonCodeIDRef_, ob);
                    }
                    else if (reasonCodeNode.Attributes["href"] != null)
                    {
                        reasonCodeIDRef_ = reasonCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reasonCode_ = new ReasonCode(reasonCodeNode);
                    }
                }
                else
                {
                    reasonCode_ = new ReasonCode(reasonCodeNode);
                }
            }
            
        
            XmlNode locationNode = xmlNode.SelectSingleNode("location");
            
            if (locationNode != null)
            {
                if (locationNode.Attributes["href"] != null || locationNode.Attributes["id"] != null) 
                {
                    if (locationNode.Attributes["id"] != null) 
                    {
                        locationIDRef_ = locationNode.Attributes["id"].Value;
                        ProblemLocation ob = new ProblemLocation(locationNode);
                        IDManager.SetID(locationIDRef_, ob);
                    }
                    else if (locationNode.Attributes["href"] != null)
                    {
                        locationIDRef_ = locationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        location_ = new ProblemLocation(locationNode);
                    }
                }
                else
                {
                    location_ = new ProblemLocation(locationNode);
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeString(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeString(descriptionNode);
                }
            }
            
        
            XmlNode validationRuleIdNode = xmlNode.SelectSingleNode("validationRuleId");
            
            if (validationRuleIdNode != null)
            {
                if (validationRuleIdNode.Attributes["href"] != null || validationRuleIdNode.Attributes["id"] != null) 
                {
                    if (validationRuleIdNode.Attributes["id"] != null) 
                    {
                        validationRuleIdIDRef_ = validationRuleIdNode.Attributes["id"].Value;
                        Validation ob = new Validation(validationRuleIdNode);
                        IDManager.SetID(validationRuleIdIDRef_, ob);
                    }
                    else if (validationRuleIdNode.Attributes["href"] != null)
                    {
                        validationRuleIdIDRef_ = validationRuleIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        validationRuleId_ = new Validation(validationRuleIdNode);
                    }
                }
                else
                {
                    validationRuleId_ = new Validation(validationRuleIdNode);
                }
            }
            
        
            XmlNodeList additionalDataNodeList = xmlNode.SelectNodes("additionalData");
            
            if (additionalDataNodeList != null)
            {
                this.additionalData_ = new List<AdditionalData>();
                foreach (XmlNode item in additionalDataNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalDataIDRef_ = item.Attributes["id"].Value;
                            additionalData_.Add(new AdditionalData(item));
                            IDManager.SetID(additionalDataIDRef_, additionalData_[additionalData_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalDataIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalData_.Add(new AdditionalData(item));
                        }
                    }
                    else
                    {
                        additionalData_.Add(new AdditionalData(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReasonCode_
        private ReasonCode reasonCode_;
        public ReasonCode ReasonCode_
        {
            get
            {
                if (this.reasonCode_ != null)
                {
                    return this.reasonCode_; 
                }
                else if (this.reasonCodeIDRef_ != null)
                {
                    reasonCode_ = IDManager.getID(reasonCodeIDRef_) as ReasonCode;
                    return this.reasonCode_; 
                }
                else
                {
                      return this.reasonCode_; 
                }
            }
            set
            {
                if (this.reasonCode_ != value)
                {
                    this.reasonCode_ = value;
                }
            }
        }
        #endregion
        
        public string reasonCodeIDRef_ { get; set; }
        #region Location_
        private ProblemLocation location_;
        public ProblemLocation Location_
        {
            get
            {
                if (this.location_ != null)
                {
                    return this.location_; 
                }
                else if (this.locationIDRef_ != null)
                {
                    location_ = IDManager.getID(locationIDRef_) as ProblemLocation;
                    return this.location_; 
                }
                else
                {
                      return this.location_; 
                }
            }
            set
            {
                if (this.location_ != value)
                {
                    this.location_ = value;
                }
            }
        }
        #endregion
        
        public string locationIDRef_ { get; set; }
        #region Description_
        private XsdTypeString description_;
        public XsdTypeString Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeString;
                    return this.description_; 
                }
                else
                {
                      return this.description_; 
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        #region ValidationRuleId_
        private Validation validationRuleId_;
        public Validation ValidationRuleId_
        {
            get
            {
                if (this.validationRuleId_ != null)
                {
                    return this.validationRuleId_; 
                }
                else if (this.validationRuleIdIDRef_ != null)
                {
                    validationRuleId_ = IDManager.getID(validationRuleIdIDRef_) as Validation;
                    return this.validationRuleId_; 
                }
                else
                {
                      return this.validationRuleId_; 
                }
            }
            set
            {
                if (this.validationRuleId_ != value)
                {
                    this.validationRuleId_ = value;
                }
            }
        }
        #endregion
        
        public string validationRuleIdIDRef_ { get; set; }
        #region AdditionalData_
        private List<AdditionalData> additionalData_;
        public List<AdditionalData> AdditionalData_
        {
            get
            {
                if (this.additionalData_ != null)
                {
                    return this.additionalData_; 
                }
                else if (this.additionalDataIDRef_ != null)
                {
                    return this.additionalData_; 
                }
                else
                {
                      return this.additionalData_; 
                }
            }
            set
            {
                if (this.additionalData_ != value)
                {
                    this.additionalData_ = value;
                }
            }
        }
        #endregion
        
        public string additionalDataIDRef_ { get; set; }
        
    
        
    
    }
    
}

