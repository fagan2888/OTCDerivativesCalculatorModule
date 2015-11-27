using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditEventNotice : ISerialized
    {
        public CreditEventNotice(XmlNode xmlNode)
        {
            XmlNode notifyingPartyNode = xmlNode.SelectSingleNode("notifyingParty");
            
            if (notifyingPartyNode != null)
            {
                if (notifyingPartyNode.Attributes["href"] != null || notifyingPartyNode.Attributes["id"] != null) 
                {
                    if (notifyingPartyNode.Attributes["id"] != null) 
                    {
                        notifyingPartyIDRef_ = notifyingPartyNode.Attributes["id"].Value;
                        NotifyingParty ob = new NotifyingParty(notifyingPartyNode);
                        IDManager.SetID(notifyingPartyIDRef_, ob);
                    }
                    else if (notifyingPartyNode.Attributes["href"] != null)
                    {
                        notifyingPartyIDRef_ = notifyingPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notifyingParty_ = new NotifyingParty(notifyingPartyNode);
                    }
                }
                else
                {
                    notifyingParty_ = new NotifyingParty(notifyingPartyNode);
                }
            }
            
        
            XmlNode businessCenterNode = xmlNode.SelectSingleNode("businessCenter");
            
            if (businessCenterNode != null)
            {
                if (businessCenterNode.Attributes["href"] != null || businessCenterNode.Attributes["id"] != null) 
                {
                    if (businessCenterNode.Attributes["id"] != null) 
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(businessCenterNode);
                        IDManager.SetID(businessCenterIDRef_, ob);
                    }
                    else if (businessCenterNode.Attributes["href"] != null)
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenter_ = new BusinessCenter(businessCenterNode);
                    }
                }
                else
                {
                    businessCenter_ = new BusinessCenter(businessCenterNode);
                }
            }
            
        
            XmlNode publiclyAvailableInformationNode = xmlNode.SelectSingleNode("publiclyAvailableInformation");
            
            if (publiclyAvailableInformationNode != null)
            {
                if (publiclyAvailableInformationNode.Attributes["href"] != null || publiclyAvailableInformationNode.Attributes["id"] != null) 
                {
                    if (publiclyAvailableInformationNode.Attributes["id"] != null) 
                    {
                        publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode.Attributes["id"].Value;
                        PubliclyAvailableInformation ob = new PubliclyAvailableInformation(publiclyAvailableInformationNode);
                        IDManager.SetID(publiclyAvailableInformationIDRef_, ob);
                    }
                    else if (publiclyAvailableInformationNode.Attributes["href"] != null)
                    {
                        publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publiclyAvailableInformation_ = new PubliclyAvailableInformation(publiclyAvailableInformationNode);
                    }
                }
                else
                {
                    publiclyAvailableInformation_ = new PubliclyAvailableInformation(publiclyAvailableInformationNode);
                }
            }
            
        
        }
        
    
        #region NotifyingParty_
        private NotifyingParty notifyingParty_;
        public NotifyingParty NotifyingParty_
        {
            get
            {
                if (this.notifyingParty_ != null)
                {
                    return this.notifyingParty_; 
                }
                else if (this.notifyingPartyIDRef_ != null)
                {
                    notifyingParty_ = IDManager.getID(notifyingPartyIDRef_) as NotifyingParty;
                    return this.notifyingParty_; 
                }
                else
                {
                      return this.notifyingParty_; 
                }
            }
            set
            {
                if (this.notifyingParty_ != value)
                {
                    this.notifyingParty_ = value;
                }
            }
        }
        #endregion
        
        public string notifyingPartyIDRef_ { get; set; }
        #region BusinessCenter_
        private BusinessCenter businessCenter_;
        public BusinessCenter BusinessCenter_
        {
            get
            {
                if (this.businessCenter_ != null)
                {
                    return this.businessCenter_; 
                }
                else if (this.businessCenterIDRef_ != null)
                {
                    businessCenter_ = IDManager.getID(businessCenterIDRef_) as BusinessCenter;
                    return this.businessCenter_; 
                }
                else
                {
                      return this.businessCenter_; 
                }
            }
            set
            {
                if (this.businessCenter_ != value)
                {
                    this.businessCenter_ = value;
                }
            }
        }
        #endregion
        
        public string businessCenterIDRef_ { get; set; }
        #region PubliclyAvailableInformation_
        private PubliclyAvailableInformation publiclyAvailableInformation_;
        public PubliclyAvailableInformation PubliclyAvailableInformation_
        {
            get
            {
                if (this.publiclyAvailableInformation_ != null)
                {
                    return this.publiclyAvailableInformation_; 
                }
                else if (this.publiclyAvailableInformationIDRef_ != null)
                {
                    publiclyAvailableInformation_ = IDManager.getID(publiclyAvailableInformationIDRef_) as PubliclyAvailableInformation;
                    return this.publiclyAvailableInformation_; 
                }
                else
                {
                      return this.publiclyAvailableInformation_; 
                }
            }
            set
            {
                if (this.publiclyAvailableInformation_ != value)
                {
                    this.publiclyAvailableInformation_ = value;
                }
            }
        }
        #endregion
        
        public string publiclyAvailableInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}

