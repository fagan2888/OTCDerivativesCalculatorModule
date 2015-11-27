using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalPhysicalLeg : PhysicalSwapLeg
    {
        public EnvironmentalPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode numberOfAllowancesNode = xmlNode.SelectSingleNode("numberOfAllowances");
            
            if (numberOfAllowancesNode != null)
            {
                if (numberOfAllowancesNode.Attributes["href"] != null || numberOfAllowancesNode.Attributes["id"] != null) 
                {
                    if (numberOfAllowancesNode.Attributes["id"] != null) 
                    {
                        numberOfAllowancesIDRef_ = numberOfAllowancesNode.Attributes["id"].Value;
                        UnitQuantity ob = new UnitQuantity(numberOfAllowancesNode);
                        IDManager.SetID(numberOfAllowancesIDRef_, ob);
                    }
                    else if (numberOfAllowancesNode.Attributes["href"] != null)
                    {
                        numberOfAllowancesIDRef_ = numberOfAllowancesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfAllowances_ = new UnitQuantity(numberOfAllowancesNode);
                    }
                }
                else
                {
                    numberOfAllowances_ = new UnitQuantity(numberOfAllowancesNode);
                }
            }
            
        
            XmlNode environmentalNode = xmlNode.SelectSingleNode("environmental");
            
            if (environmentalNode != null)
            {
                if (environmentalNode.Attributes["href"] != null || environmentalNode.Attributes["id"] != null) 
                {
                    if (environmentalNode.Attributes["id"] != null) 
                    {
                        environmentalIDRef_ = environmentalNode.Attributes["id"].Value;
                        EnvironmentalProduct ob = new EnvironmentalProduct(environmentalNode);
                        IDManager.SetID(environmentalIDRef_, ob);
                    }
                    else if (environmentalNode.Attributes["href"] != null)
                    {
                        environmentalIDRef_ = environmentalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        environmental_ = new EnvironmentalProduct(environmentalNode);
                    }
                }
                else
                {
                    environmental_ = new EnvironmentalProduct(environmentalNode);
                }
            }
            
        
            XmlNode abandonmentOfSchemeNode = xmlNode.SelectSingleNode("abandonmentOfScheme");
            
            if (abandonmentOfSchemeNode != null)
            {
                if (abandonmentOfSchemeNode.Attributes["href"] != null || abandonmentOfSchemeNode.Attributes["id"] != null) 
                {
                    if (abandonmentOfSchemeNode.Attributes["id"] != null) 
                    {
                        abandonmentOfSchemeIDRef_ = abandonmentOfSchemeNode.Attributes["id"].Value;
                        EnvironmentalAbandonmentOfSchemeEnum ob = new EnvironmentalAbandonmentOfSchemeEnum(abandonmentOfSchemeNode);
                        IDManager.SetID(abandonmentOfSchemeIDRef_, ob);
                    }
                    else if (abandonmentOfSchemeNode.Attributes["href"] != null)
                    {
                        abandonmentOfSchemeIDRef_ = abandonmentOfSchemeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        abandonmentOfScheme_ = new EnvironmentalAbandonmentOfSchemeEnum(abandonmentOfSchemeNode);
                    }
                }
                else
                {
                    abandonmentOfScheme_ = new EnvironmentalAbandonmentOfSchemeEnum(abandonmentOfSchemeNode);
                }
            }
            
        
            XmlNode deliveryDateNode = xmlNode.SelectSingleNode("deliveryDate");
            
            if (deliveryDateNode != null)
            {
                if (deliveryDateNode.Attributes["href"] != null || deliveryDateNode.Attributes["id"] != null) 
                {
                    if (deliveryDateNode.Attributes["id"] != null) 
                    {
                        deliveryDateIDRef_ = deliveryDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(deliveryDateNode);
                        IDManager.SetID(deliveryDateIDRef_, ob);
                    }
                    else if (deliveryDateNode.Attributes["href"] != null)
                    {
                        deliveryDateIDRef_ = deliveryDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryDate_ = new AdjustableOrRelativeDate(deliveryDateNode);
                    }
                }
                else
                {
                    deliveryDate_ = new AdjustableOrRelativeDate(deliveryDateNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        DateOffset ob = new DateOffset(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new DateOffset(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new DateOffset(paymentDateNode);
                }
            }
            
        
            XmlNode businessCentersReferenceNode = xmlNode.SelectSingleNode("businessCentersReference");
            
            if (businessCentersReferenceNode != null)
            {
                if (businessCentersReferenceNode.Attributes["href"] != null || businessCentersReferenceNode.Attributes["id"] != null) 
                {
                    if (businessCentersReferenceNode.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["id"].Value;
                        BusinessCentersReference ob = new BusinessCentersReference(businessCentersReferenceNode);
                        IDManager.SetID(businessCentersReferenceIDRef_, ob);
                    }
                    else if (businessCentersReferenceNode.Attributes["href"] != null)
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                    }
                }
                else
                {
                    businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                }
            }
            
        
            XmlNode businessCentersNode = xmlNode.SelectSingleNode("businessCenters");
            
            if (businessCentersNode != null)
            {
                if (businessCentersNode.Attributes["href"] != null || businessCentersNode.Attributes["id"] != null) 
                {
                    if (businessCentersNode.Attributes["id"] != null) 
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["id"].Value;
                        BusinessCenters ob = new BusinessCenters(businessCentersNode);
                        IDManager.SetID(businessCentersIDRef_, ob);
                    }
                    else if (businessCentersNode.Attributes["href"] != null)
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenters_ = new BusinessCenters(businessCentersNode);
                    }
                }
                else
                {
                    businessCenters_ = new BusinessCenters(businessCentersNode);
                }
            }
            
        
            XmlNode failureToDeliverApplicableNode = xmlNode.SelectSingleNode("failureToDeliverApplicable");
            
            if (failureToDeliverApplicableNode != null)
            {
                if (failureToDeliverApplicableNode.Attributes["href"] != null || failureToDeliverApplicableNode.Attributes["id"] != null) 
                {
                    if (failureToDeliverApplicableNode.Attributes["id"] != null) 
                    {
                        failureToDeliverApplicableIDRef_ = failureToDeliverApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToDeliverApplicableNode);
                        IDManager.SetID(failureToDeliverApplicableIDRef_, ob);
                    }
                    else if (failureToDeliverApplicableNode.Attributes["href"] != null)
                    {
                        failureToDeliverApplicableIDRef_ = failureToDeliverApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToDeliverApplicable_ = new XsdTypeBoolean(failureToDeliverApplicableNode);
                    }
                }
                else
                {
                    failureToDeliverApplicable_ = new XsdTypeBoolean(failureToDeliverApplicableNode);
                }
            }
            
        
            XmlNode eEPParametersNode = xmlNode.SelectSingleNode("eEPParameters");
            
            if (eEPParametersNode != null)
            {
                if (eEPParametersNode.Attributes["href"] != null || eEPParametersNode.Attributes["id"] != null) 
                {
                    if (eEPParametersNode.Attributes["id"] != null) 
                    {
                        eEPParametersIDRef_ = eEPParametersNode.Attributes["id"].Value;
                        EEPParameters ob = new EEPParameters(eEPParametersNode);
                        IDManager.SetID(eEPParametersIDRef_, ob);
                    }
                    else if (eEPParametersNode.Attributes["href"] != null)
                    {
                        eEPParametersIDRef_ = eEPParametersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eEPParameters_ = new EEPParameters(eEPParametersNode);
                    }
                }
                else
                {
                    eEPParameters_ = new EEPParameters(eEPParametersNode);
                }
            }
            
        
        }
        
    
        #region NumberOfAllowances_
        private UnitQuantity numberOfAllowances_;
        public UnitQuantity NumberOfAllowances_
        {
            get
            {
                if (this.numberOfAllowances_ != null)
                {
                    return this.numberOfAllowances_; 
                }
                else if (this.numberOfAllowancesIDRef_ != null)
                {
                    numberOfAllowances_ = IDManager.getID(numberOfAllowancesIDRef_) as UnitQuantity;
                    return this.numberOfAllowances_; 
                }
                else
                {
                      return this.numberOfAllowances_; 
                }
            }
            set
            {
                if (this.numberOfAllowances_ != value)
                {
                    this.numberOfAllowances_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfAllowancesIDRef_ { get; set; }
        #region Environmental_
        private EnvironmentalProduct environmental_;
        public EnvironmentalProduct Environmental_
        {
            get
            {
                if (this.environmental_ != null)
                {
                    return this.environmental_; 
                }
                else if (this.environmentalIDRef_ != null)
                {
                    environmental_ = IDManager.getID(environmentalIDRef_) as EnvironmentalProduct;
                    return this.environmental_; 
                }
                else
                {
                      return this.environmental_; 
                }
            }
            set
            {
                if (this.environmental_ != value)
                {
                    this.environmental_ = value;
                }
            }
        }
        #endregion
        
        public string environmentalIDRef_ { get; set; }
        #region AbandonmentOfScheme_
        private EnvironmentalAbandonmentOfSchemeEnum abandonmentOfScheme_;
        public EnvironmentalAbandonmentOfSchemeEnum AbandonmentOfScheme_
        {
            get
            {
                if (this.abandonmentOfScheme_ != null)
                {
                    return this.abandonmentOfScheme_; 
                }
                else if (this.abandonmentOfSchemeIDRef_ != null)
                {
                    abandonmentOfScheme_ = IDManager.getID(abandonmentOfSchemeIDRef_) as EnvironmentalAbandonmentOfSchemeEnum;
                    return this.abandonmentOfScheme_; 
                }
                else
                {
                      return this.abandonmentOfScheme_; 
                }
            }
            set
            {
                if (this.abandonmentOfScheme_ != value)
                {
                    this.abandonmentOfScheme_ = value;
                }
            }
        }
        #endregion
        
        public string abandonmentOfSchemeIDRef_ { get; set; }
        #region DeliveryDate_
        private AdjustableOrRelativeDate deliveryDate_;
        public AdjustableOrRelativeDate DeliveryDate_
        {
            get
            {
                if (this.deliveryDate_ != null)
                {
                    return this.deliveryDate_; 
                }
                else if (this.deliveryDateIDRef_ != null)
                {
                    deliveryDate_ = IDManager.getID(deliveryDateIDRef_) as AdjustableOrRelativeDate;
                    return this.deliveryDate_; 
                }
                else
                {
                      return this.deliveryDate_; 
                }
            }
            set
            {
                if (this.deliveryDate_ != value)
                {
                    this.deliveryDate_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryDateIDRef_ { get; set; }
        #region PaymentDate_
        private DateOffset paymentDate_;
        public DateOffset PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as DateOffset;
                    return this.paymentDate_; 
                }
                else
                {
                      return this.paymentDate_; 
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
        #region BusinessCentersReference_
        private BusinessCentersReference businessCentersReference_;
        public BusinessCentersReference BusinessCentersReference_
        {
            get
            {
                if (this.businessCentersReference_ != null)
                {
                    return this.businessCentersReference_; 
                }
                else if (this.businessCentersReferenceIDRef_ != null)
                {
                    businessCentersReference_ = IDManager.getID(businessCentersReferenceIDRef_) as BusinessCentersReference;
                    return this.businessCentersReference_; 
                }
                else
                {
                      return this.businessCentersReference_; 
                }
            }
            set
            {
                if (this.businessCentersReference_ != value)
                {
                    this.businessCentersReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersReferenceIDRef_ { get; set; }
        #region BusinessCenters_
        private BusinessCenters businessCenters_;
        public BusinessCenters BusinessCenters_
        {
            get
            {
                if (this.businessCenters_ != null)
                {
                    return this.businessCenters_; 
                }
                else if (this.businessCentersIDRef_ != null)
                {
                    businessCenters_ = IDManager.getID(businessCentersIDRef_) as BusinessCenters;
                    return this.businessCenters_; 
                }
                else
                {
                      return this.businessCenters_; 
                }
            }
            set
            {
                if (this.businessCenters_ != value)
                {
                    this.businessCenters_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersIDRef_ { get; set; }
        #region FailureToDeliverApplicable_
        private XsdTypeBoolean failureToDeliverApplicable_;
        public XsdTypeBoolean FailureToDeliverApplicable_
        {
            get
            {
                if (this.failureToDeliverApplicable_ != null)
                {
                    return this.failureToDeliverApplicable_; 
                }
                else if (this.failureToDeliverApplicableIDRef_ != null)
                {
                    failureToDeliverApplicable_ = IDManager.getID(failureToDeliverApplicableIDRef_) as XsdTypeBoolean;
                    return this.failureToDeliverApplicable_; 
                }
                else
                {
                      return this.failureToDeliverApplicable_; 
                }
            }
            set
            {
                if (this.failureToDeliverApplicable_ != value)
                {
                    this.failureToDeliverApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string failureToDeliverApplicableIDRef_ { get; set; }
        #region EEPParameters_
        private EEPParameters eEPParameters_;
        public EEPParameters EEPParameters_
        {
            get
            {
                if (this.eEPParameters_ != null)
                {
                    return this.eEPParameters_; 
                }
                else if (this.eEPParametersIDRef_ != null)
                {
                    eEPParameters_ = IDManager.getID(eEPParametersIDRef_) as EEPParameters;
                    return this.eEPParameters_; 
                }
                else
                {
                      return this.eEPParameters_; 
                }
            }
            set
            {
                if (this.eEPParameters_ != value)
                {
                    this.eEPParameters_ = value;
                }
            }
        }
        #endregion
        
        public string eEPParametersIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

