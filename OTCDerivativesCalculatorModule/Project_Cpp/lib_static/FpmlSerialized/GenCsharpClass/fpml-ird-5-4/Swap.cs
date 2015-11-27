using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Swap
    {
        public Swap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList swapStreamNodeList = xmlNode.SelectNodes("swapStream");
            
            foreach (XmlNode item in swapStreamNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapStreamIDRef = item.Attributes["id"].Name;
                        List<InterestRateStream> ob = new List<InterestRateStream>();
                        ob.Add(new InterestRateStream(item));
                        IDManager.SetID(swapStreamIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapStreamIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    swapStream.Add(new InterestRateStream(item));
                    }
                }
            }
            
        
            XmlNodeList earlyTerminationProvisionNodeList = xmlNode.SelectNodes("earlyTerminationProvision");
            if (earlyTerminationProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in earlyTerminationProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earlyTerminationProvisionIDRef = item.Attributes["id"].Name;
                        EarlyTerminationProvision ob = EarlyTerminationProvision();
                        IDManager.SetID(earlyTerminationProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earlyTerminationProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        earlyTerminationProvision = new EarlyTerminationProvision(item);
                    }
                }
            }
            
        
            XmlNodeList cancelableProvisionNodeList = xmlNode.SelectNodes("cancelableProvision");
            if (cancelableProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cancelableProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cancelableProvisionIDRef = item.Attributes["id"].Name;
                        CancelableProvision ob = CancelableProvision();
                        IDManager.SetID(cancelableProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cancelableProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cancelableProvision = new CancelableProvision(item);
                    }
                }
            }
            
        
            XmlNodeList extendibleProvisionNodeList = xmlNode.SelectNodes("extendibleProvision");
            if (extendibleProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extendibleProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extendibleProvisionIDRef = item.Attributes["id"].Name;
                        ExtendibleProvision ob = ExtendibleProvision();
                        IDManager.SetID(extendibleProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extendibleProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extendibleProvision = new ExtendibleProvision(item);
                    }
                }
            }
            
        
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            foreach (XmlNode item in additionalPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalPaymentIDRef = item.Attributes["id"].Name;
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(additionalPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalPayment.Add(new Payment(item));
                    }
                }
            }
            
        
            XmlNodeList additionalTermsNodeList = xmlNode.SelectNodes("additionalTerms");
            if (additionalTermsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalTermsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalTermsIDRef = item.Attributes["id"].Name;
                        SwapAdditionalTerms ob = SwapAdditionalTerms();
                        IDManager.SetID(additionalTermsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalTermsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalTerms = new SwapAdditionalTerms(item);
                    }
                }
            }
            
        
        }
        
    
        #region SwapStream
        private List<InterestRateStream> swapStream;
        public List<InterestRateStream> SwapStream
        {
            get
            {
                if (this.swapStream != null)
                {
                    return this.swapStream; 
                }
                else if (this.swapStreamIDRef != null)
                {
                    swapStream = IDManager.getID(swapStreamIDRef) as List<InterestRateStream>;
                    return this.swapStream; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swapStream != value)
                {
                    this.swapStream = value;
                }
            }
        }
        #endregion
        
        public string InterestRateStreamIDRef { get; set; }
        #region EarlyTerminationProvision
        private EarlyTerminationProvision earlyTerminationProvision;
        public EarlyTerminationProvision EarlyTerminationProvision
        {
            get
            {
                if (this.earlyTerminationProvision != null)
                {
                    return this.earlyTerminationProvision; 
                }
                else if (this.earlyTerminationProvisionIDRef != null)
                {
                    earlyTerminationProvision = IDManager.getID(earlyTerminationProvisionIDRef) as EarlyTerminationProvision;
                    return this.earlyTerminationProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earlyTerminationProvision != value)
                {
                    this.earlyTerminationProvision = value;
                }
            }
        }
        #endregion
        
        public string EarlyTerminationProvisionIDRef { get; set; }
        #region CancelableProvision
        private CancelableProvision cancelableProvision;
        public CancelableProvision CancelableProvision
        {
            get
            {
                if (this.cancelableProvision != null)
                {
                    return this.cancelableProvision; 
                }
                else if (this.cancelableProvisionIDRef != null)
                {
                    cancelableProvision = IDManager.getID(cancelableProvisionIDRef) as CancelableProvision;
                    return this.cancelableProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cancelableProvision != value)
                {
                    this.cancelableProvision = value;
                }
            }
        }
        #endregion
        
        public string CancelableProvisionIDRef { get; set; }
        #region ExtendibleProvision
        private ExtendibleProvision extendibleProvision;
        public ExtendibleProvision ExtendibleProvision
        {
            get
            {
                if (this.extendibleProvision != null)
                {
                    return this.extendibleProvision; 
                }
                else if (this.extendibleProvisionIDRef != null)
                {
                    extendibleProvision = IDManager.getID(extendibleProvisionIDRef) as ExtendibleProvision;
                    return this.extendibleProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extendibleProvision != value)
                {
                    this.extendibleProvision = value;
                }
            }
        }
        #endregion
        
        public string ExtendibleProvisionIDRef { get; set; }
        #region AdditionalPayment
        private List<Payment> additionalPayment;
        public List<Payment> AdditionalPayment
        {
            get
            {
                if (this.additionalPayment != null)
                {
                    return this.additionalPayment; 
                }
                else if (this.additionalPaymentIDRef != null)
                {
                    additionalPayment = IDManager.getID(additionalPaymentIDRef) as List<Payment>;
                    return this.additionalPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalPayment != value)
                {
                    this.additionalPayment = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        #region AdditionalTerms
        private SwapAdditionalTerms additionalTerms;
        public SwapAdditionalTerms AdditionalTerms
        {
            get
            {
                if (this.additionalTerms != null)
                {
                    return this.additionalTerms; 
                }
                else if (this.additionalTermsIDRef != null)
                {
                    additionalTerms = IDManager.getID(additionalTermsIDRef) as SwapAdditionalTerms;
                    return this.additionalTerms; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalTerms != value)
                {
                    this.additionalTerms = value;
                }
            }
        }
        #endregion
        
        public string SwapAdditionalTermsIDRef { get; set; }
        
    
        
    
    }
    
}

