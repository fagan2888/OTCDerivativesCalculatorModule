using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FailureToPay : ISerialized
    {
        public FailureToPay(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode gracePeriodExtensionNode = xmlNode.SelectSingleNode("gracePeriodExtension");
            
            if (gracePeriodExtensionNode != null)
            {
                if (gracePeriodExtensionNode.Attributes["href"] != null || gracePeriodExtensionNode.Attributes["id"] != null) 
                {
                    if (gracePeriodExtensionNode.Attributes["id"] != null) 
                    {
                        gracePeriodExtensionIDRef_ = gracePeriodExtensionNode.Attributes["id"].Value;
                        GracePeriodExtension ob = new GracePeriodExtension(gracePeriodExtensionNode);
                        IDManager.SetID(gracePeriodExtensionIDRef_, ob);
                    }
                    else if (gracePeriodExtensionNode.Attributes["href"] != null)
                    {
                        gracePeriodExtensionIDRef_ = gracePeriodExtensionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gracePeriodExtension_ = new GracePeriodExtension(gracePeriodExtensionNode);
                    }
                }
                else
                {
                    gracePeriodExtension_ = new GracePeriodExtension(gracePeriodExtensionNode);
                }
            }
            
        
            XmlNode paymentRequirementNode = xmlNode.SelectSingleNode("paymentRequirement");
            
            if (paymentRequirementNode != null)
            {
                if (paymentRequirementNode.Attributes["href"] != null || paymentRequirementNode.Attributes["id"] != null) 
                {
                    if (paymentRequirementNode.Attributes["id"] != null) 
                    {
                        paymentRequirementIDRef_ = paymentRequirementNode.Attributes["id"].Value;
                        Money ob = new Money(paymentRequirementNode);
                        IDManager.SetID(paymentRequirementIDRef_, ob);
                    }
                    else if (paymentRequirementNode.Attributes["href"] != null)
                    {
                        paymentRequirementIDRef_ = paymentRequirementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentRequirement_ = new Money(paymentRequirementNode);
                    }
                }
                else
                {
                    paymentRequirement_ = new Money(paymentRequirementNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region GracePeriodExtension_
        private GracePeriodExtension gracePeriodExtension_;
        public GracePeriodExtension GracePeriodExtension_
        {
            get
            {
                if (this.gracePeriodExtension_ != null)
                {
                    return this.gracePeriodExtension_; 
                }
                else if (this.gracePeriodExtensionIDRef_ != null)
                {
                    gracePeriodExtension_ = IDManager.getID(gracePeriodExtensionIDRef_) as GracePeriodExtension;
                    return this.gracePeriodExtension_; 
                }
                else
                {
                      return this.gracePeriodExtension_; 
                }
            }
            set
            {
                if (this.gracePeriodExtension_ != value)
                {
                    this.gracePeriodExtension_ = value;
                }
            }
        }
        #endregion
        
        public string gracePeriodExtensionIDRef_ { get; set; }
        #region PaymentRequirement_
        private Money paymentRequirement_;
        public Money PaymentRequirement_
        {
            get
            {
                if (this.paymentRequirement_ != null)
                {
                    return this.paymentRequirement_; 
                }
                else if (this.paymentRequirementIDRef_ != null)
                {
                    paymentRequirement_ = IDManager.getID(paymentRequirementIDRef_) as Money;
                    return this.paymentRequirement_; 
                }
                else
                {
                      return this.paymentRequirement_; 
                }
            }
            set
            {
                if (this.paymentRequirement_ != value)
                {
                    this.paymentRequirement_ = value;
                }
            }
        }
        #endregion
        
        public string paymentRequirementIDRef_ { get; set; }
        
    
        
    
    }
    
}

