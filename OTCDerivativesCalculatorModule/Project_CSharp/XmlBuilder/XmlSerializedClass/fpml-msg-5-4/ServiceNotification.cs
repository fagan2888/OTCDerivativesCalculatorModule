using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ServiceNotification : NotificationMessage
    {
        public ServiceNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode serviceNameNode = xmlNode.SelectSingleNode("serviceName");
            
            if (serviceNameNode != null)
            {
                if (serviceNameNode.Attributes["href"] != null || serviceNameNode.Attributes["id"] != null) 
                {
                    if (serviceNameNode.Attributes["id"] != null) 
                    {
                        serviceNameIDRef_ = serviceNameNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(serviceNameNode);
                        IDManager.SetID(serviceNameIDRef_, ob);
                    }
                    else if (serviceNameNode.Attributes["href"] != null)
                    {
                        serviceNameIDRef_ = serviceNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        serviceName_ = new XsdTypeNormalizedString(serviceNameNode);
                    }
                }
                else
                {
                    serviceName_ = new XsdTypeNormalizedString(serviceNameNode);
                }
            }
            
        
            XmlNode statusNode = xmlNode.SelectSingleNode("status");
            
            if (statusNode != null)
            {
                if (statusNode.Attributes["href"] != null || statusNode.Attributes["id"] != null) 
                {
                    if (statusNode.Attributes["id"] != null) 
                    {
                        statusIDRef_ = statusNode.Attributes["id"].Value;
                        ServiceStatus ob = new ServiceStatus(statusNode);
                        IDManager.SetID(statusIDRef_, ob);
                    }
                    else if (statusNode.Attributes["href"] != null)
                    {
                        statusIDRef_ = statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        status_ = new ServiceStatus(statusNode);
                    }
                }
                else
                {
                    status_ = new ServiceStatus(statusNode);
                }
            }
            
        
            XmlNode processingStatusNode = xmlNode.SelectSingleNode("processingStatus");
            
            if (processingStatusNode != null)
            {
                if (processingStatusNode.Attributes["href"] != null || processingStatusNode.Attributes["id"] != null) 
                {
                    if (processingStatusNode.Attributes["id"] != null) 
                    {
                        processingStatusIDRef_ = processingStatusNode.Attributes["id"].Value;
                        ServiceProcessingStatus ob = new ServiceProcessingStatus(processingStatusNode);
                        IDManager.SetID(processingStatusIDRef_, ob);
                    }
                    else if (processingStatusNode.Attributes["href"] != null)
                    {
                        processingStatusIDRef_ = processingStatusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        processingStatus_ = new ServiceProcessingStatus(processingStatusNode);
                    }
                }
                else
                {
                    processingStatus_ = new ServiceProcessingStatus(processingStatusNode);
                }
            }
            
        
            XmlNode advisoryNode = xmlNode.SelectSingleNode("advisory");
            
            if (advisoryNode != null)
            {
                if (advisoryNode.Attributes["href"] != null || advisoryNode.Attributes["id"] != null) 
                {
                    if (advisoryNode.Attributes["id"] != null) 
                    {
                        advisoryIDRef_ = advisoryNode.Attributes["id"].Value;
                        ServiceAdvisory ob = new ServiceAdvisory(advisoryNode);
                        IDManager.SetID(advisoryIDRef_, ob);
                    }
                    else if (advisoryNode.Attributes["href"] != null)
                    {
                        advisoryIDRef_ = advisoryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        advisory_ = new ServiceAdvisory(advisoryNode);
                    }
                }
                else
                {
                    advisory_ = new ServiceAdvisory(advisoryNode);
                }
            }
            
        
        }
        
    
        #region ServiceName_
        private XsdTypeNormalizedString serviceName_;
        public XsdTypeNormalizedString ServiceName_
        {
            get
            {
                if (this.serviceName_ != null)
                {
                    return this.serviceName_; 
                }
                else if (this.serviceNameIDRef_ != null)
                {
                    serviceName_ = IDManager.getID(serviceNameIDRef_) as XsdTypeNormalizedString;
                    return this.serviceName_; 
                }
                else
                {
                      return this.serviceName_; 
                }
            }
            set
            {
                if (this.serviceName_ != value)
                {
                    this.serviceName_ = value;
                }
            }
        }
        #endregion
        
        public string serviceNameIDRef_ { get; set; }
        #region Status_
        private ServiceStatus status_;
        public ServiceStatus Status_
        {
            get
            {
                if (this.status_ != null)
                {
                    return this.status_; 
                }
                else if (this.statusIDRef_ != null)
                {
                    status_ = IDManager.getID(statusIDRef_) as ServiceStatus;
                    return this.status_; 
                }
                else
                {
                      return this.status_; 
                }
            }
            set
            {
                if (this.status_ != value)
                {
                    this.status_ = value;
                }
            }
        }
        #endregion
        
        public string statusIDRef_ { get; set; }
        #region ProcessingStatus_
        private ServiceProcessingStatus processingStatus_;
        public ServiceProcessingStatus ProcessingStatus_
        {
            get
            {
                if (this.processingStatus_ != null)
                {
                    return this.processingStatus_; 
                }
                else if (this.processingStatusIDRef_ != null)
                {
                    processingStatus_ = IDManager.getID(processingStatusIDRef_) as ServiceProcessingStatus;
                    return this.processingStatus_; 
                }
                else
                {
                      return this.processingStatus_; 
                }
            }
            set
            {
                if (this.processingStatus_ != value)
                {
                    this.processingStatus_ = value;
                }
            }
        }
        #endregion
        
        public string processingStatusIDRef_ { get; set; }
        #region Advisory_
        private ServiceAdvisory advisory_;
        public ServiceAdvisory Advisory_
        {
            get
            {
                if (this.advisory_ != null)
                {
                    return this.advisory_; 
                }
                else if (this.advisoryIDRef_ != null)
                {
                    advisory_ = IDManager.getID(advisoryIDRef_) as ServiceAdvisory;
                    return this.advisory_; 
                }
                else
                {
                      return this.advisory_; 
                }
            }
            set
            {
                if (this.advisory_ != value)
                {
                    this.advisory_ = value;
                }
            }
        }
        #endregion
        
        public string advisoryIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

