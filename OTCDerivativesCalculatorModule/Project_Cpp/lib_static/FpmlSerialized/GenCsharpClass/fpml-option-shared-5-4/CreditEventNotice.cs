using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditEventNotice
    {
        public CreditEventNotice(XmlNode xmlNode)
        {
            XmlNodeList notifyingPartyNodeList = xmlNode.SelectNodes("notifyingParty");
            if (notifyingPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notifyingPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notifyingPartyIDRef = item.Attributes["id"].Name;
                        NotifyingParty ob = NotifyingParty();
                        IDManager.SetID(notifyingPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notifyingPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notifyingParty = new NotifyingParty(item);
                    }
                }
            }
            
        
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            if (businessCenterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCenterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCenterIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(businessCenterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCenterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenter = new BusinessCenter(item);
                    }
                }
            }
            
        
            XmlNodeList publiclyAvailableInformationNodeList = xmlNode.SelectNodes("publiclyAvailableInformation");
            if (publiclyAvailableInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publiclyAvailableInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["id"].Name;
                        PubliclyAvailableInformation ob = PubliclyAvailableInformation();
                        IDManager.SetID(publiclyAvailableInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publiclyAvailableInformation = new PubliclyAvailableInformation(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotifyingParty
        private NotifyingParty notifyingParty;
        public NotifyingParty NotifyingParty
        {
            get
            {
                if (this.notifyingParty != null)
                {
                    return this.notifyingParty; 
                }
                else if (this.notifyingPartyIDRef != null)
                {
                    notifyingParty = IDManager.getID(notifyingPartyIDRef) as NotifyingParty;
                    return this.notifyingParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notifyingParty != value)
                {
                    this.notifyingParty = value;
                }
            }
        }
        #endregion
        
        public string NotifyingPartyIDRef { get; set; }
        #region BusinessCenter
        private BusinessCenter businessCenter;
        public BusinessCenter BusinessCenter
        {
            get
            {
                if (this.businessCenter != null)
                {
                    return this.businessCenter; 
                }
                else if (this.businessCenterIDRef != null)
                {
                    businessCenter = IDManager.getID(businessCenterIDRef) as BusinessCenter;
                    return this.businessCenter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenter != value)
                {
                    this.businessCenter = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        #region PubliclyAvailableInformation
        private PubliclyAvailableInformation publiclyAvailableInformation;
        public PubliclyAvailableInformation PubliclyAvailableInformation
        {
            get
            {
                if (this.publiclyAvailableInformation != null)
                {
                    return this.publiclyAvailableInformation; 
                }
                else if (this.publiclyAvailableInformationIDRef != null)
                {
                    publiclyAvailableInformation = IDManager.getID(publiclyAvailableInformationIDRef) as PubliclyAvailableInformation;
                    return this.publiclyAvailableInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publiclyAvailableInformation != value)
                {
                    this.publiclyAvailableInformation = value;
                }
            }
        }
        #endregion
        
        public string PubliclyAvailableInformationIDRef { get; set; }
        
    
        
    
    }
    
}

