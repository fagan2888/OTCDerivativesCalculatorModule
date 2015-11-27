using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CreditEvents : ISerialized
    {
        public CreditEvents() { }
        public CreditEvents(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode failureToPayNode = xmlNode.SelectSingleNode("failureToPay");
            
            if (failureToPayNode != null)
            {
                if (failureToPayNode.Attributes["href"] != null || failureToPayNode.Attributes["id"] != null) 
                {
                    if (failureToPayNode.Attributes["id"] != null) 
                    {
                        failureToPayIDRef_ = failureToPayNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(failureToPayNode);
                        IDManager.SetID(failureToPayIDRef_, ob);
                    }
                    else if (failureToPayNode.Attributes["href"] != null)
                    {
                        failureToPayIDRef_ = failureToPayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPay_ = new XsdTypeToken(failureToPayNode);
                    }
                }
                else
                {
                    failureToPay_ = new XsdTypeToken(failureToPayNode);
                }
            }
            
        
            XmlNode obligationAccelerationNode = xmlNode.SelectSingleNode("obligationAcceleration");
            
            if (obligationAccelerationNode != null)
            {
                if (obligationAccelerationNode.Attributes["href"] != null || obligationAccelerationNode.Attributes["id"] != null) 
                {
                    if (obligationAccelerationNode.Attributes["id"] != null) 
                    {
                        obligationAccelerationIDRef_ = obligationAccelerationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(obligationAccelerationNode);
                        IDManager.SetID(obligationAccelerationIDRef_, ob);
                    }
                    else if (obligationAccelerationNode.Attributes["href"] != null)
                    {
                        obligationAccelerationIDRef_ = obligationAccelerationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationAcceleration_ = new XsdTypeToken(obligationAccelerationNode);
                    }
                }
                else
                {
                    obligationAcceleration_ = new XsdTypeToken(obligationAccelerationNode);
                }
            }
            
        
            XmlNode repudiationMoratoriumNode = xmlNode.SelectSingleNode("repudiationMoratorium");
            
            if (repudiationMoratoriumNode != null)
            {
                if (repudiationMoratoriumNode.Attributes["href"] != null || repudiationMoratoriumNode.Attributes["id"] != null) 
                {
                    if (repudiationMoratoriumNode.Attributes["id"] != null) 
                    {
                        repudiationMoratoriumIDRef_ = repudiationMoratoriumNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(repudiationMoratoriumNode);
                        IDManager.SetID(repudiationMoratoriumIDRef_, ob);
                    }
                    else if (repudiationMoratoriumNode.Attributes["href"] != null)
                    {
                        repudiationMoratoriumIDRef_ = repudiationMoratoriumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        repudiationMoratorium_ = new XsdTypeToken(repudiationMoratoriumNode);
                    }
                }
                else
                {
                    repudiationMoratorium_ = new XsdTypeToken(repudiationMoratoriumNode);
                }
            }
            
        
            XmlNode restructuringNode = xmlNode.SelectSingleNode("restructuring");
            
            if (restructuringNode != null)
            {
                if (restructuringNode.Attributes["href"] != null || restructuringNode.Attributes["id"] != null) 
                {
                    if (restructuringNode.Attributes["id"] != null) 
                    {
                        restructuringIDRef_ = restructuringNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(restructuringNode);
                        IDManager.SetID(restructuringIDRef_, ob);
                    }
                    else if (restructuringNode.Attributes["href"] != null)
                    {
                        restructuringIDRef_ = restructuringNode.Attributes["href"].Value;
                    }
                    else
                    {
                        restructuring_ = new XsdTypeToken(restructuringNode);
                    }
                }
                else
                {
                    restructuring_ = new XsdTypeToken(restructuringNode);
                }
            }
            
        
            XmlNode defaultRequirementNode = xmlNode.SelectSingleNode("defaultRequirement");
            
            if (defaultRequirementNode != null)
            {
                if (defaultRequirementNode.Attributes["href"] != null || defaultRequirementNode.Attributes["id"] != null) 
                {
                    if (defaultRequirementNode.Attributes["id"] != null) 
                    {
                        defaultRequirementIDRef_ = defaultRequirementNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(defaultRequirementNode);
                        IDManager.SetID(defaultRequirementIDRef_, ob);
                    }
                    else if (defaultRequirementNode.Attributes["href"] != null)
                    {
                        defaultRequirementIDRef_ = defaultRequirementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        defaultRequirement_ = new XsdTypeToken(defaultRequirementNode);
                    }
                }
                else
                {
                    defaultRequirement_ = new XsdTypeToken(defaultRequirementNode);
                }
            }
            
        
        }
        
    
        #region FailureToPay_
        private XsdTypeToken failureToPay_;
        public XsdTypeToken FailureToPay_
        {
            get
            {
                if (this.failureToPay_ != null)
                {
                    return this.failureToPay_; 
                }
                else if (this.failureToPayIDRef_ != null)
                {
                    failureToPay_ = IDManager.getID(failureToPayIDRef_) as XsdTypeToken;
                    return this.failureToPay_; 
                }
                else
                {
                      return this.failureToPay_; 
                }
            }
            set
            {
                if (this.failureToPay_ != value)
                {
                    this.failureToPay_ = value;
                }
            }
        }
        #endregion
        
        public string failureToPayIDRef_ { get; set; }
        #region ObligationAcceleration_
        private XsdTypeToken obligationAcceleration_;
        public XsdTypeToken ObligationAcceleration_
        {
            get
            {
                if (this.obligationAcceleration_ != null)
                {
                    return this.obligationAcceleration_; 
                }
                else if (this.obligationAccelerationIDRef_ != null)
                {
                    obligationAcceleration_ = IDManager.getID(obligationAccelerationIDRef_) as XsdTypeToken;
                    return this.obligationAcceleration_; 
                }
                else
                {
                      return this.obligationAcceleration_; 
                }
            }
            set
            {
                if (this.obligationAcceleration_ != value)
                {
                    this.obligationAcceleration_ = value;
                }
            }
        }
        #endregion
        
        public string obligationAccelerationIDRef_ { get; set; }
        #region RepudiationMoratorium_
        private XsdTypeToken repudiationMoratorium_;
        public XsdTypeToken RepudiationMoratorium_
        {
            get
            {
                if (this.repudiationMoratorium_ != null)
                {
                    return this.repudiationMoratorium_; 
                }
                else if (this.repudiationMoratoriumIDRef_ != null)
                {
                    repudiationMoratorium_ = IDManager.getID(repudiationMoratoriumIDRef_) as XsdTypeToken;
                    return this.repudiationMoratorium_; 
                }
                else
                {
                      return this.repudiationMoratorium_; 
                }
            }
            set
            {
                if (this.repudiationMoratorium_ != value)
                {
                    this.repudiationMoratorium_ = value;
                }
            }
        }
        #endregion
        
        public string repudiationMoratoriumIDRef_ { get; set; }
        #region Restructuring_
        private XsdTypeToken restructuring_;
        public XsdTypeToken Restructuring_
        {
            get
            {
                if (this.restructuring_ != null)
                {
                    return this.restructuring_; 
                }
                else if (this.restructuringIDRef_ != null)
                {
                    restructuring_ = IDManager.getID(restructuringIDRef_) as XsdTypeToken;
                    return this.restructuring_; 
                }
                else
                {
                      return this.restructuring_; 
                }
            }
            set
            {
                if (this.restructuring_ != value)
                {
                    this.restructuring_ = value;
                }
            }
        }
        #endregion
        
        public string restructuringIDRef_ { get; set; }
        #region DefaultRequirement_
        private XsdTypeToken defaultRequirement_;
        public XsdTypeToken DefaultRequirement_
        {
            get
            {
                if (this.defaultRequirement_ != null)
                {
                    return this.defaultRequirement_; 
                }
                else if (this.defaultRequirementIDRef_ != null)
                {
                    defaultRequirement_ = IDManager.getID(defaultRequirementIDRef_) as XsdTypeToken;
                    return this.defaultRequirement_; 
                }
                else
                {
                      return this.defaultRequirement_; 
                }
            }
            set
            {
                if (this.defaultRequirement_ != value)
                {
                    this.defaultRequirement_ = value;
                }
            }
        }
        #endregion
        
        public string defaultRequirementIDRef_ { get; set; }
        
    
        
    
    }
    
}

