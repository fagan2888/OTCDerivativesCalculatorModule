using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalPhysicalLeg
    {
        public EnvironmentalPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList numberOfAllowancesNodeList = xmlNode.SelectNodes("numberOfAllowances");
            if (numberOfAllowancesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfAllowancesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfAllowancesIDRef = item.Attributes["id"].Name;
                        UnitQuantity ob = UnitQuantity();
                        IDManager.SetID(numberOfAllowancesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfAllowancesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfAllowances = new UnitQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList environmentalNodeList = xmlNode.SelectNodes("environmental");
            if (environmentalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in environmentalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        environmentalIDRef = item.Attributes["id"].Name;
                        EnvironmentalProduct ob = EnvironmentalProduct();
                        IDManager.SetID(environmentalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        environmentalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        environmental = new EnvironmentalProduct(item);
                    }
                }
            }
            
        
            XmlNodeList abandonmentOfSchemeNodeList = xmlNode.SelectNodes("abandonmentOfScheme");
            if (abandonmentOfSchemeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in abandonmentOfSchemeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        abandonmentOfSchemeIDRef = item.Attributes["id"].Name;
                        EnvironmentalAbandonmentOfSchemeEnum ob = EnvironmentalAbandonmentOfSchemeEnum();
                        IDManager.SetID(abandonmentOfSchemeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        abandonmentOfSchemeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        abandonmentOfScheme = new EnvironmentalAbandonmentOfSchemeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryDateNodeList = xmlNode.SelectNodes("deliveryDate");
            if (deliveryDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(deliveryDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateNodeList = xmlNode.SelectNodes("paymentDate");
            if (paymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateIDRef = item.Attributes["id"].Name;
                        DateOffset ob = DateOffset();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new DateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersReferenceNodeList = xmlNode.SelectNodes("businessCentersReference");
            if (businessCentersReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef = item.Attributes["id"].Name;
                        BusinessCentersReference ob = BusinessCentersReference();
                        IDManager.SetID(businessCentersReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCentersReference = new BusinessCentersReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersNodeList = xmlNode.SelectNodes("businessCenters");
            if (businessCentersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersIDRef = item.Attributes["id"].Name;
                        BusinessCenters ob = BusinessCenters();
                        IDManager.SetID(businessCentersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenters = new BusinessCenters(item);
                    }
                }
            }
            
        
            XmlNodeList failureToDeliverApplicableNodeList = xmlNode.SelectNodes("failureToDeliverApplicable");
            if (failureToDeliverApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToDeliverApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToDeliverApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToDeliverApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToDeliverApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToDeliverApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList eEPParametersNodeList = xmlNode.SelectNodes("eEPParameters");
            if (eEPParametersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eEPParametersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eEPParametersIDRef = item.Attributes["id"].Name;
                        EEPParameters ob = EEPParameters();
                        IDManager.SetID(eEPParametersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eEPParametersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eEPParameters = new EEPParameters(item);
                    }
                }
            }
            
        
        }
        
    
        #region NumberOfAllowances
        private UnitQuantity numberOfAllowances;
        public UnitQuantity NumberOfAllowances
        {
            get
            {
                if (this.numberOfAllowances != null)
                {
                    return this.numberOfAllowances; 
                }
                else if (this.numberOfAllowancesIDRef != null)
                {
                    numberOfAllowances = IDManager.getID(numberOfAllowancesIDRef) as UnitQuantity;
                    return this.numberOfAllowances; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfAllowances != value)
                {
                    this.numberOfAllowances = value;
                }
            }
        }
        #endregion
        
        public string UnitQuantityIDRef { get; set; }
        #region Environmental
        private EnvironmentalProduct environmental;
        public EnvironmentalProduct Environmental
        {
            get
            {
                if (this.environmental != null)
                {
                    return this.environmental; 
                }
                else if (this.environmentalIDRef != null)
                {
                    environmental = IDManager.getID(environmentalIDRef) as EnvironmentalProduct;
                    return this.environmental; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.environmental != value)
                {
                    this.environmental = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalProductIDRef { get; set; }
        #region AbandonmentOfScheme
        private EnvironmentalAbandonmentOfSchemeEnum abandonmentOfScheme;
        public EnvironmentalAbandonmentOfSchemeEnum AbandonmentOfScheme
        {
            get
            {
                if (this.abandonmentOfScheme != null)
                {
                    return this.abandonmentOfScheme; 
                }
                else if (this.abandonmentOfSchemeIDRef != null)
                {
                    abandonmentOfScheme = IDManager.getID(abandonmentOfSchemeIDRef) as EnvironmentalAbandonmentOfSchemeEnum;
                    return this.abandonmentOfScheme; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.abandonmentOfScheme != value)
                {
                    this.abandonmentOfScheme = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalAbandonmentOfSchemeEnumIDRef { get; set; }
        #region DeliveryDate
        private AdjustableOrRelativeDate deliveryDate;
        public AdjustableOrRelativeDate DeliveryDate
        {
            get
            {
                if (this.deliveryDate != null)
                {
                    return this.deliveryDate; 
                }
                else if (this.deliveryDateIDRef != null)
                {
                    deliveryDate = IDManager.getID(deliveryDateIDRef) as AdjustableOrRelativeDate;
                    return this.deliveryDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryDate != value)
                {
                    this.deliveryDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region PaymentDate
        private DateOffset paymentDate;
        public DateOffset PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as DateOffset;
                    return this.paymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDate != value)
                {
                    this.paymentDate = value;
                }
            }
        }
        #endregion
        
        public string DateOffsetIDRef { get; set; }
        #region BusinessCentersReference
        private BusinessCentersReference businessCentersReference;
        public BusinessCentersReference BusinessCentersReference
        {
            get
            {
                if (this.businessCentersReference != null)
                {
                    return this.businessCentersReference; 
                }
                else if (this.businessCentersReferenceIDRef != null)
                {
                    businessCentersReference = IDManager.getID(businessCentersReferenceIDRef) as BusinessCentersReference;
                    return this.businessCentersReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCentersReference != value)
                {
                    this.businessCentersReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersReferenceIDRef { get; set; }
        #region BusinessCenters
        private BusinessCenters businessCenters;
        public BusinessCenters BusinessCenters
        {
            get
            {
                if (this.businessCenters != null)
                {
                    return this.businessCenters; 
                }
                else if (this.businessCentersIDRef != null)
                {
                    businessCenters = IDManager.getID(businessCentersIDRef) as BusinessCenters;
                    return this.businessCenters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenters != value)
                {
                    this.businessCenters = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersIDRef { get; set; }
        #region FailureToDeliverApplicable
        private XsdTypeBoolean failureToDeliverApplicable;
        public XsdTypeBoolean FailureToDeliverApplicable
        {
            get
            {
                if (this.failureToDeliverApplicable != null)
                {
                    return this.failureToDeliverApplicable; 
                }
                else if (this.failureToDeliverApplicableIDRef != null)
                {
                    failureToDeliverApplicable = IDManager.getID(failureToDeliverApplicableIDRef) as XsdTypeBoolean;
                    return this.failureToDeliverApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToDeliverApplicable != value)
                {
                    this.failureToDeliverApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region EEPParameters
        private EEPParameters eEPParameters;
        public EEPParameters EEPParameters
        {
            get
            {
                if (this.eEPParameters != null)
                {
                    return this.eEPParameters; 
                }
                else if (this.eEPParametersIDRef != null)
                {
                    eEPParameters = IDManager.getID(eEPParametersIDRef) as EEPParameters;
                    return this.eEPParameters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eEPParameters != value)
                {
                    this.eEPParameters = value;
                }
            }
        }
        #endregion
        
        public string EEPParametersIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

