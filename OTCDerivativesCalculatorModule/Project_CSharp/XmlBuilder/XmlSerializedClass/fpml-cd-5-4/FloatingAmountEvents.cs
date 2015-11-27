using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingAmountEvents : ISerialized
    {
        public FloatingAmountEvents(XmlNode xmlNode)
        {
            XmlNode failureToPayPrincipalNode = xmlNode.SelectSingleNode("failureToPayPrincipal");
            
            if (failureToPayPrincipalNode != null)
            {
                if (failureToPayPrincipalNode.Attributes["href"] != null || failureToPayPrincipalNode.Attributes["id"] != null) 
                {
                    if (failureToPayPrincipalNode.Attributes["id"] != null) 
                    {
                        failureToPayPrincipalIDRef_ = failureToPayPrincipalNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToPayPrincipalNode);
                        IDManager.SetID(failureToPayPrincipalIDRef_, ob);
                    }
                    else if (failureToPayPrincipalNode.Attributes["href"] != null)
                    {
                        failureToPayPrincipalIDRef_ = failureToPayPrincipalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPayPrincipal_ = new XsdTypeBoolean(failureToPayPrincipalNode);
                    }
                }
                else
                {
                    failureToPayPrincipal_ = new XsdTypeBoolean(failureToPayPrincipalNode);
                }
            }
            
        
            XmlNode interestShortfallNode = xmlNode.SelectSingleNode("interestShortfall");
            
            if (interestShortfallNode != null)
            {
                if (interestShortfallNode.Attributes["href"] != null || interestShortfallNode.Attributes["id"] != null) 
                {
                    if (interestShortfallNode.Attributes["id"] != null) 
                    {
                        interestShortfallIDRef_ = interestShortfallNode.Attributes["id"].Value;
                        InterestShortFall ob = new InterestShortFall(interestShortfallNode);
                        IDManager.SetID(interestShortfallIDRef_, ob);
                    }
                    else if (interestShortfallNode.Attributes["href"] != null)
                    {
                        interestShortfallIDRef_ = interestShortfallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestShortfall_ = new InterestShortFall(interestShortfallNode);
                    }
                }
                else
                {
                    interestShortfall_ = new InterestShortFall(interestShortfallNode);
                }
            }
            
        
            XmlNode writedownNode = xmlNode.SelectSingleNode("writedown");
            
            if (writedownNode != null)
            {
                if (writedownNode.Attributes["href"] != null || writedownNode.Attributes["id"] != null) 
                {
                    if (writedownNode.Attributes["id"] != null) 
                    {
                        writedownIDRef_ = writedownNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(writedownNode);
                        IDManager.SetID(writedownIDRef_, ob);
                    }
                    else if (writedownNode.Attributes["href"] != null)
                    {
                        writedownIDRef_ = writedownNode.Attributes["href"].Value;
                    }
                    else
                    {
                        writedown_ = new XsdTypeBoolean(writedownNode);
                    }
                }
                else
                {
                    writedown_ = new XsdTypeBoolean(writedownNode);
                }
            }
            
        
            XmlNode impliedWritedownNode = xmlNode.SelectSingleNode("impliedWritedown");
            
            if (impliedWritedownNode != null)
            {
                if (impliedWritedownNode.Attributes["href"] != null || impliedWritedownNode.Attributes["id"] != null) 
                {
                    if (impliedWritedownNode.Attributes["id"] != null) 
                    {
                        impliedWritedownIDRef_ = impliedWritedownNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(impliedWritedownNode);
                        IDManager.SetID(impliedWritedownIDRef_, ob);
                    }
                    else if (impliedWritedownNode.Attributes["href"] != null)
                    {
                        impliedWritedownIDRef_ = impliedWritedownNode.Attributes["href"].Value;
                    }
                    else
                    {
                        impliedWritedown_ = new XsdTypeBoolean(impliedWritedownNode);
                    }
                }
                else
                {
                    impliedWritedown_ = new XsdTypeBoolean(impliedWritedownNode);
                }
            }
            
        
            XmlNode floatingAmountProvisionsNode = xmlNode.SelectSingleNode("floatingAmountProvisions");
            
            if (floatingAmountProvisionsNode != null)
            {
                if (floatingAmountProvisionsNode.Attributes["href"] != null || floatingAmountProvisionsNode.Attributes["id"] != null) 
                {
                    if (floatingAmountProvisionsNode.Attributes["id"] != null) 
                    {
                        floatingAmountProvisionsIDRef_ = floatingAmountProvisionsNode.Attributes["id"].Value;
                        FloatingAmountProvisions ob = new FloatingAmountProvisions(floatingAmountProvisionsNode);
                        IDManager.SetID(floatingAmountProvisionsIDRef_, ob);
                    }
                    else if (floatingAmountProvisionsNode.Attributes["href"] != null)
                    {
                        floatingAmountProvisionsIDRef_ = floatingAmountProvisionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingAmountProvisions_ = new FloatingAmountProvisions(floatingAmountProvisionsNode);
                    }
                }
                else
                {
                    floatingAmountProvisions_ = new FloatingAmountProvisions(floatingAmountProvisionsNode);
                }
            }
            
        
            XmlNode additionalFixedPaymentsNode = xmlNode.SelectSingleNode("additionalFixedPayments");
            
            if (additionalFixedPaymentsNode != null)
            {
                if (additionalFixedPaymentsNode.Attributes["href"] != null || additionalFixedPaymentsNode.Attributes["id"] != null) 
                {
                    if (additionalFixedPaymentsNode.Attributes["id"] != null) 
                    {
                        additionalFixedPaymentsIDRef_ = additionalFixedPaymentsNode.Attributes["id"].Value;
                        AdditionalFixedPayments ob = new AdditionalFixedPayments(additionalFixedPaymentsNode);
                        IDManager.SetID(additionalFixedPaymentsIDRef_, ob);
                    }
                    else if (additionalFixedPaymentsNode.Attributes["href"] != null)
                    {
                        additionalFixedPaymentsIDRef_ = additionalFixedPaymentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalFixedPayments_ = new AdditionalFixedPayments(additionalFixedPaymentsNode);
                    }
                }
                else
                {
                    additionalFixedPayments_ = new AdditionalFixedPayments(additionalFixedPaymentsNode);
                }
            }
            
        
        }
        
    
        #region FailureToPayPrincipal_
        private XsdTypeBoolean failureToPayPrincipal_;
        public XsdTypeBoolean FailureToPayPrincipal_
        {
            get
            {
                if (this.failureToPayPrincipal_ != null)
                {
                    return this.failureToPayPrincipal_; 
                }
                else if (this.failureToPayPrincipalIDRef_ != null)
                {
                    failureToPayPrincipal_ = IDManager.getID(failureToPayPrincipalIDRef_) as XsdTypeBoolean;
                    return this.failureToPayPrincipal_; 
                }
                else
                {
                      return this.failureToPayPrincipal_; 
                }
            }
            set
            {
                if (this.failureToPayPrincipal_ != value)
                {
                    this.failureToPayPrincipal_ = value;
                }
            }
        }
        #endregion
        
        public string failureToPayPrincipalIDRef_ { get; set; }
        #region InterestShortfall_
        private InterestShortFall interestShortfall_;
        public InterestShortFall InterestShortfall_
        {
            get
            {
                if (this.interestShortfall_ != null)
                {
                    return this.interestShortfall_; 
                }
                else if (this.interestShortfallIDRef_ != null)
                {
                    interestShortfall_ = IDManager.getID(interestShortfallIDRef_) as InterestShortFall;
                    return this.interestShortfall_; 
                }
                else
                {
                      return this.interestShortfall_; 
                }
            }
            set
            {
                if (this.interestShortfall_ != value)
                {
                    this.interestShortfall_ = value;
                }
            }
        }
        #endregion
        
        public string interestShortfallIDRef_ { get; set; }
        #region Writedown_
        private XsdTypeBoolean writedown_;
        public XsdTypeBoolean Writedown_
        {
            get
            {
                if (this.writedown_ != null)
                {
                    return this.writedown_; 
                }
                else if (this.writedownIDRef_ != null)
                {
                    writedown_ = IDManager.getID(writedownIDRef_) as XsdTypeBoolean;
                    return this.writedown_; 
                }
                else
                {
                      return this.writedown_; 
                }
            }
            set
            {
                if (this.writedown_ != value)
                {
                    this.writedown_ = value;
                }
            }
        }
        #endregion
        
        public string writedownIDRef_ { get; set; }
        #region ImpliedWritedown_
        private XsdTypeBoolean impliedWritedown_;
        public XsdTypeBoolean ImpliedWritedown_
        {
            get
            {
                if (this.impliedWritedown_ != null)
                {
                    return this.impliedWritedown_; 
                }
                else if (this.impliedWritedownIDRef_ != null)
                {
                    impliedWritedown_ = IDManager.getID(impliedWritedownIDRef_) as XsdTypeBoolean;
                    return this.impliedWritedown_; 
                }
                else
                {
                      return this.impliedWritedown_; 
                }
            }
            set
            {
                if (this.impliedWritedown_ != value)
                {
                    this.impliedWritedown_ = value;
                }
            }
        }
        #endregion
        
        public string impliedWritedownIDRef_ { get; set; }
        #region FloatingAmountProvisions_
        private FloatingAmountProvisions floatingAmountProvisions_;
        public FloatingAmountProvisions FloatingAmountProvisions_
        {
            get
            {
                if (this.floatingAmountProvisions_ != null)
                {
                    return this.floatingAmountProvisions_; 
                }
                else if (this.floatingAmountProvisionsIDRef_ != null)
                {
                    floatingAmountProvisions_ = IDManager.getID(floatingAmountProvisionsIDRef_) as FloatingAmountProvisions;
                    return this.floatingAmountProvisions_; 
                }
                else
                {
                      return this.floatingAmountProvisions_; 
                }
            }
            set
            {
                if (this.floatingAmountProvisions_ != value)
                {
                    this.floatingAmountProvisions_ = value;
                }
            }
        }
        #endregion
        
        public string floatingAmountProvisionsIDRef_ { get; set; }
        #region AdditionalFixedPayments_
        private AdditionalFixedPayments additionalFixedPayments_;
        public AdditionalFixedPayments AdditionalFixedPayments_
        {
            get
            {
                if (this.additionalFixedPayments_ != null)
                {
                    return this.additionalFixedPayments_; 
                }
                else if (this.additionalFixedPaymentsIDRef_ != null)
                {
                    additionalFixedPayments_ = IDManager.getID(additionalFixedPaymentsIDRef_) as AdditionalFixedPayments;
                    return this.additionalFixedPayments_; 
                }
                else
                {
                      return this.additionalFixedPayments_; 
                }
            }
            set
            {
                if (this.additionalFixedPayments_ != value)
                {
                    this.additionalFixedPayments_ = value;
                }
            }
        }
        #endregion
        
        public string additionalFixedPaymentsIDRef_ { get; set; }
        
    
        
    
    }
    
}

