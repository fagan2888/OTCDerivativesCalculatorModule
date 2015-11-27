using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CapFloor : Product
    {
        public CapFloor(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode capFloorStreamNode = xmlNode.SelectSingleNode("capFloorStream");
            
            if (capFloorStreamNode != null)
            {
                if (capFloorStreamNode.Attributes["href"] != null || capFloorStreamNode.Attributes["id"] != null) 
                {
                    if (capFloorStreamNode.Attributes["id"] != null) 
                    {
                        capFloorStreamIDRef_ = capFloorStreamNode.Attributes["id"].Value;
                        InterestRateStream ob = new InterestRateStream(capFloorStreamNode);
                        IDManager.SetID(capFloorStreamIDRef_, ob);
                    }
                    else if (capFloorStreamNode.Attributes["href"] != null)
                    {
                        capFloorStreamIDRef_ = capFloorStreamNode.Attributes["href"].Value;
                    }
                    else
                    {
                        capFloorStream_ = new InterestRateStream(capFloorStreamNode);
                    }
                }
                else
                {
                    capFloorStream_ = new InterestRateStream(capFloorStreamNode);
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            if (premiumNodeList != null)
            {
                this.premium_ = new List<Payment>();
                foreach (XmlNode item in premiumNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            premiumIDRef_ = item.Attributes["id"].Value;
                            premium_.Add(new Payment(item));
                            IDManager.SetID(premiumIDRef_, premium_[premium_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            premiumIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        premium_.Add(new Payment(item));
                        }
                    }
                    else
                    {
                        premium_.Add(new Payment(item));
                    }
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
            
        
        }
        
    
        #region CapFloorStream_
        private InterestRateStream capFloorStream_;
        public InterestRateStream CapFloorStream_
        {
            get
            {
                if (this.capFloorStream_ != null)
                {
                    return this.capFloorStream_; 
                }
                else if (this.capFloorStreamIDRef_ != null)
                {
                    capFloorStream_ = IDManager.getID(capFloorStreamIDRef_) as InterestRateStream;
                    return this.capFloorStream_; 
                }
                else
                {
                      return this.capFloorStream_; 
                }
            }
            set
            {
                if (this.capFloorStream_ != value)
                {
                    this.capFloorStream_ = value;
                }
            }
        }
        #endregion
        
        public string capFloorStreamIDRef_ { get; set; }
        #region Premium_
        private List<Payment> premium_;
        public List<Payment> Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    return this.premium_; 
                }
                else
                {
                      return this.premium_; 
                }
            }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                }
            }
        }
        #endregion
        
        public string premiumIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

