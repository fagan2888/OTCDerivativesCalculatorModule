using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Swap : Product
    {
        public Swap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList swapStreamNodeList = xmlNode.SelectNodes("swapStream");
            
            if (swapStreamNodeList != null)
            {
                this.swapStream_ = new List<InterestRateStream>();
                foreach (XmlNode item in swapStreamNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            swapStreamIDRef_ = item.Attributes["id"].Value;
                            swapStream_.Add(new InterestRateStream(item));
                            IDManager.SetID(swapStreamIDRef_, swapStream_[swapStream_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            swapStreamIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        swapStream_.Add(new InterestRateStream(item));
                        }
                    }
                    else
                    {
                        swapStream_.Add(new InterestRateStream(item));
                    }
                }
            }
            
        
            XmlNode earlyTerminationProvisionNode = xmlNode.SelectSingleNode("earlyTerminationProvision");
            
            if (earlyTerminationProvisionNode != null)
            {
                if (earlyTerminationProvisionNode.Attributes["href"] != null || earlyTerminationProvisionNode.Attributes["id"] != null) 
                {
                    if (earlyTerminationProvisionNode.Attributes["id"] != null) 
                    {
                        earlyTerminationProvisionIDRef_ = earlyTerminationProvisionNode.Attributes["id"].Value;
                        EarlyTerminationProvision ob = new EarlyTerminationProvision(earlyTerminationProvisionNode);
                        IDManager.SetID(earlyTerminationProvisionIDRef_, ob);
                    }
                    else if (earlyTerminationProvisionNode.Attributes["href"] != null)
                    {
                        earlyTerminationProvisionIDRef_ = earlyTerminationProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        earlyTerminationProvision_ = new EarlyTerminationProvision(earlyTerminationProvisionNode);
                    }
                }
                else
                {
                    earlyTerminationProvision_ = new EarlyTerminationProvision(earlyTerminationProvisionNode);
                }
            }
            
        
            XmlNode cancelableProvisionNode = xmlNode.SelectSingleNode("cancelableProvision");
            
            if (cancelableProvisionNode != null)
            {
                if (cancelableProvisionNode.Attributes["href"] != null || cancelableProvisionNode.Attributes["id"] != null) 
                {
                    if (cancelableProvisionNode.Attributes["id"] != null) 
                    {
                        cancelableProvisionIDRef_ = cancelableProvisionNode.Attributes["id"].Value;
                        CancelableProvision ob = new CancelableProvision(cancelableProvisionNode);
                        IDManager.SetID(cancelableProvisionIDRef_, ob);
                    }
                    else if (cancelableProvisionNode.Attributes["href"] != null)
                    {
                        cancelableProvisionIDRef_ = cancelableProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cancelableProvision_ = new CancelableProvision(cancelableProvisionNode);
                    }
                }
                else
                {
                    cancelableProvision_ = new CancelableProvision(cancelableProvisionNode);
                }
            }
            
        
            XmlNode extendibleProvisionNode = xmlNode.SelectSingleNode("extendibleProvision");
            
            if (extendibleProvisionNode != null)
            {
                if (extendibleProvisionNode.Attributes["href"] != null || extendibleProvisionNode.Attributes["id"] != null) 
                {
                    if (extendibleProvisionNode.Attributes["id"] != null) 
                    {
                        extendibleProvisionIDRef_ = extendibleProvisionNode.Attributes["id"].Value;
                        ExtendibleProvision ob = new ExtendibleProvision(extendibleProvisionNode);
                        IDManager.SetID(extendibleProvisionIDRef_, ob);
                    }
                    else if (extendibleProvisionNode.Attributes["href"] != null)
                    {
                        extendibleProvisionIDRef_ = extendibleProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extendibleProvision_ = new ExtendibleProvision(extendibleProvisionNode);
                    }
                }
                else
                {
                    extendibleProvision_ = new ExtendibleProvision(extendibleProvisionNode);
                }
            }
            
        
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            if (additionalPaymentNodeList != null)
            {
                this.additionalPayment_ = new List<Payment>();
                foreach (XmlNode item in additionalPaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalPaymentIDRef_ = item.Attributes["id"].Value;
                            additionalPayment_.Add(new Payment(item));
                            IDManager.SetID(additionalPaymentIDRef_, additionalPayment_[additionalPayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalPaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalPayment_.Add(new Payment(item));
                        }
                    }
                    else
                    {
                        additionalPayment_.Add(new Payment(item));
                    }
                }
            }
            
        
            XmlNode additionalTermsNode = xmlNode.SelectSingleNode("additionalTerms");
            
            if (additionalTermsNode != null)
            {
                if (additionalTermsNode.Attributes["href"] != null || additionalTermsNode.Attributes["id"] != null) 
                {
                    if (additionalTermsNode.Attributes["id"] != null) 
                    {
                        additionalTermsIDRef_ = additionalTermsNode.Attributes["id"].Value;
                        SwapAdditionalTerms ob = new SwapAdditionalTerms(additionalTermsNode);
                        IDManager.SetID(additionalTermsIDRef_, ob);
                    }
                    else if (additionalTermsNode.Attributes["href"] != null)
                    {
                        additionalTermsIDRef_ = additionalTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalTerms_ = new SwapAdditionalTerms(additionalTermsNode);
                    }
                }
                else
                {
                    additionalTerms_ = new SwapAdditionalTerms(additionalTermsNode);
                }
            }
            
        
        }
        
    
        #region SwapStream_
        private List<InterestRateStream> swapStream_;
        public List<InterestRateStream> SwapStream_
        {
            get
            {
                if (this.swapStream_ != null)
                {
                    return this.swapStream_; 
                }
                else if (this.swapStreamIDRef_ != null)
                {
                    return this.swapStream_; 
                }
                else
                {
                      return this.swapStream_; 
                }
            }
            set
            {
                if (this.swapStream_ != value)
                {
                    this.swapStream_ = value;
                }
            }
        }
        #endregion
        
        public string swapStreamIDRef_ { get; set; }
        #region EarlyTerminationProvision_
        private EarlyTerminationProvision earlyTerminationProvision_;
        public EarlyTerminationProvision EarlyTerminationProvision_
        {
            get
            {
                if (this.earlyTerminationProvision_ != null)
                {
                    return this.earlyTerminationProvision_; 
                }
                else if (this.earlyTerminationProvisionIDRef_ != null)
                {
                    earlyTerminationProvision_ = IDManager.getID(earlyTerminationProvisionIDRef_) as EarlyTerminationProvision;
                    return this.earlyTerminationProvision_; 
                }
                else
                {
                      return this.earlyTerminationProvision_; 
                }
            }
            set
            {
                if (this.earlyTerminationProvision_ != value)
                {
                    this.earlyTerminationProvision_ = value;
                }
            }
        }
        #endregion
        
        public string earlyTerminationProvisionIDRef_ { get; set; }
        #region CancelableProvision_
        private CancelableProvision cancelableProvision_;
        public CancelableProvision CancelableProvision_
        {
            get
            {
                if (this.cancelableProvision_ != null)
                {
                    return this.cancelableProvision_; 
                }
                else if (this.cancelableProvisionIDRef_ != null)
                {
                    cancelableProvision_ = IDManager.getID(cancelableProvisionIDRef_) as CancelableProvision;
                    return this.cancelableProvision_; 
                }
                else
                {
                      return this.cancelableProvision_; 
                }
            }
            set
            {
                if (this.cancelableProvision_ != value)
                {
                    this.cancelableProvision_ = value;
                }
            }
        }
        #endregion
        
        public string cancelableProvisionIDRef_ { get; set; }
        #region ExtendibleProvision_
        private ExtendibleProvision extendibleProvision_;
        public ExtendibleProvision ExtendibleProvision_
        {
            get
            {
                if (this.extendibleProvision_ != null)
                {
                    return this.extendibleProvision_; 
                }
                else if (this.extendibleProvisionIDRef_ != null)
                {
                    extendibleProvision_ = IDManager.getID(extendibleProvisionIDRef_) as ExtendibleProvision;
                    return this.extendibleProvision_; 
                }
                else
                {
                      return this.extendibleProvision_; 
                }
            }
            set
            {
                if (this.extendibleProvision_ != value)
                {
                    this.extendibleProvision_ = value;
                }
            }
        }
        #endregion
        
        public string extendibleProvisionIDRef_ { get; set; }
        #region AdditionalPayment_
        private List<Payment> additionalPayment_;
        public List<Payment> AdditionalPayment_
        {
            get
            {
                if (this.additionalPayment_ != null)
                {
                    return this.additionalPayment_; 
                }
                else if (this.additionalPaymentIDRef_ != null)
                {
                    return this.additionalPayment_; 
                }
                else
                {
                      return this.additionalPayment_; 
                }
            }
            set
            {
                if (this.additionalPayment_ != value)
                {
                    this.additionalPayment_ = value;
                }
            }
        }
        #endregion
        
        public string additionalPaymentIDRef_ { get; set; }
        #region AdditionalTerms_
        private SwapAdditionalTerms additionalTerms_;
        public SwapAdditionalTerms AdditionalTerms_
        {
            get
            {
                if (this.additionalTerms_ != null)
                {
                    return this.additionalTerms_; 
                }
                else if (this.additionalTermsIDRef_ != null)
                {
                    additionalTerms_ = IDManager.getID(additionalTermsIDRef_) as SwapAdditionalTerms;
                    return this.additionalTerms_; 
                }
                else
                {
                      return this.additionalTerms_; 
                }
            }
            set
            {
                if (this.additionalTerms_ != value)
                {
                    this.additionalTerms_ = value;
                }
            }
        }
        #endregion
        
        public string additionalTermsIDRef_ { get; set; }
        
    
        
    
    }
    
}

