using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ServiceNotification
    {
        public ServiceNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList serviceNameNodeList = xmlNode.SelectNodes("serviceName");
            if (serviceNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in serviceNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        serviceNameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(serviceNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        serviceNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        serviceName = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList statusNodeList = xmlNode.SelectNodes("status");
            if (statusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in statusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        statusIDRef = item.Attributes["id"].Name;
                        ServiceStatus ob = ServiceStatus();
                        IDManager.SetID(statusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        statusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        status = new ServiceStatus(item);
                    }
                }
            }
            
        
            XmlNodeList processingStatusNodeList = xmlNode.SelectNodes("processingStatus");
            if (processingStatusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in processingStatusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        processingStatusIDRef = item.Attributes["id"].Name;
                        ServiceProcessingStatus ob = ServiceProcessingStatus();
                        IDManager.SetID(processingStatusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        processingStatusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        processingStatus = new ServiceProcessingStatus(item);
                    }
                }
            }
            
        
            XmlNodeList advisoryNodeList = xmlNode.SelectNodes("advisory");
            if (advisoryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in advisoryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        advisoryIDRef = item.Attributes["id"].Name;
                        ServiceAdvisory ob = ServiceAdvisory();
                        IDManager.SetID(advisoryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        advisoryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        advisory = new ServiceAdvisory(item);
                    }
                }
            }
            
        
        }
        
    
        #region ServiceName
        private XsdTypeNormalizedString serviceName;
        public XsdTypeNormalizedString ServiceName
        {
            get
            {
                if (this.serviceName != null)
                {
                    return this.serviceName; 
                }
                else if (this.serviceNameIDRef != null)
                {
                    serviceName = IDManager.getID(serviceNameIDRef) as XsdTypeNormalizedString;
                    return this.serviceName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.serviceName != value)
                {
                    this.serviceName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Status
        private ServiceStatus status;
        public ServiceStatus Status
        {
            get
            {
                if (this.status != null)
                {
                    return this.status; 
                }
                else if (this.statusIDRef != null)
                {
                    status = IDManager.getID(statusIDRef) as ServiceStatus;
                    return this.status; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                }
            }
        }
        #endregion
        
        public string ServiceStatusIDRef { get; set; }
        #region ProcessingStatus
        private ServiceProcessingStatus processingStatus;
        public ServiceProcessingStatus ProcessingStatus
        {
            get
            {
                if (this.processingStatus != null)
                {
                    return this.processingStatus; 
                }
                else if (this.processingStatusIDRef != null)
                {
                    processingStatus = IDManager.getID(processingStatusIDRef) as ServiceProcessingStatus;
                    return this.processingStatus; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.processingStatus != value)
                {
                    this.processingStatus = value;
                }
            }
        }
        #endregion
        
        public string ServiceProcessingStatusIDRef { get; set; }
        #region Advisory
        private ServiceAdvisory advisory;
        public ServiceAdvisory Advisory
        {
            get
            {
                if (this.advisory != null)
                {
                    return this.advisory; 
                }
                else if (this.advisoryIDRef != null)
                {
                    advisory = IDManager.getID(advisoryIDRef) as ServiceAdvisory;
                    return this.advisory; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.advisory != value)
                {
                    this.advisory = value;
                }
            }
        }
        #endregion
        
        public string ServiceAdvisoryIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

