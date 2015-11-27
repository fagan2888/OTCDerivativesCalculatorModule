using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReportingRegime : ISerialized
    {
        public ReportingRegime(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        ReportingRegimeName ob = new ReportingRegimeName(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new ReportingRegimeName(nameNode);
                    }
                }
                else
                {
                    name_ = new ReportingRegimeName(nameNode);
                }
            }
            
        
            XmlNodeList supervisorRegistrationNodeList = xmlNode.SelectNodes("supervisorRegistration");
            
            if (supervisorRegistrationNodeList != null)
            {
                this.supervisorRegistration_ = new List<SupervisorRegistration>();
                foreach (XmlNode item in supervisorRegistrationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            supervisorRegistrationIDRef_ = item.Attributes["id"].Value;
                            supervisorRegistration_.Add(new SupervisorRegistration(item));
                            IDManager.SetID(supervisorRegistrationIDRef_, supervisorRegistration_[supervisorRegistration_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            supervisorRegistrationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        supervisorRegistration_.Add(new SupervisorRegistration(item));
                        }
                    }
                    else
                    {
                        supervisorRegistration_.Add(new SupervisorRegistration(item));
                    }
                }
            }
            
        
            XmlNode reportingRoleNode = xmlNode.SelectSingleNode("reportingRole");
            
            if (reportingRoleNode != null)
            {
                if (reportingRoleNode.Attributes["href"] != null || reportingRoleNode.Attributes["id"] != null) 
                {
                    if (reportingRoleNode.Attributes["id"] != null) 
                    {
                        reportingRoleIDRef_ = reportingRoleNode.Attributes["id"].Value;
                        ReportingRole ob = new ReportingRole(reportingRoleNode);
                        IDManager.SetID(reportingRoleIDRef_, ob);
                    }
                    else if (reportingRoleNode.Attributes["href"] != null)
                    {
                        reportingRoleIDRef_ = reportingRoleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reportingRole_ = new ReportingRole(reportingRoleNode);
                    }
                }
                else
                {
                    reportingRole_ = new ReportingRole(reportingRoleNode);
                }
            }
            
        
            XmlNodeList reportingPurposeNodeList = xmlNode.SelectNodes("reportingPurpose");
            
            if (reportingPurposeNodeList != null)
            {
                this.reportingPurpose_ = new List<ReportingPurpose>();
                foreach (XmlNode item in reportingPurposeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reportingPurposeIDRef_ = item.Attributes["id"].Value;
                            reportingPurpose_.Add(new ReportingPurpose(item));
                            IDManager.SetID(reportingPurposeIDRef_, reportingPurpose_[reportingPurpose_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reportingPurposeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reportingPurpose_.Add(new ReportingPurpose(item));
                        }
                    }
                    else
                    {
                        reportingPurpose_.Add(new ReportingPurpose(item));
                    }
                }
            }
            
        
            XmlNode mandatorilyClearableNode = xmlNode.SelectSingleNode("mandatorilyClearable");
            
            if (mandatorilyClearableNode != null)
            {
                if (mandatorilyClearableNode.Attributes["href"] != null || mandatorilyClearableNode.Attributes["id"] != null) 
                {
                    if (mandatorilyClearableNode.Attributes["id"] != null) 
                    {
                        mandatorilyClearableIDRef_ = mandatorilyClearableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(mandatorilyClearableNode);
                        IDManager.SetID(mandatorilyClearableIDRef_, ob);
                    }
                    else if (mandatorilyClearableNode.Attributes["href"] != null)
                    {
                        mandatorilyClearableIDRef_ = mandatorilyClearableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mandatorilyClearable_ = new XsdTypeBoolean(mandatorilyClearableNode);
                    }
                }
                else
                {
                    mandatorilyClearable_ = new XsdTypeBoolean(mandatorilyClearableNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private ReportingRegimeName name_;
        public ReportingRegimeName Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as ReportingRegimeName;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region SupervisorRegistration_
        private List<SupervisorRegistration> supervisorRegistration_;
        public List<SupervisorRegistration> SupervisorRegistration_
        {
            get
            {
                if (this.supervisorRegistration_ != null)
                {
                    return this.supervisorRegistration_; 
                }
                else if (this.supervisorRegistrationIDRef_ != null)
                {
                    return this.supervisorRegistration_; 
                }
                else
                {
                      return this.supervisorRegistration_; 
                }
            }
            set
            {
                if (this.supervisorRegistration_ != value)
                {
                    this.supervisorRegistration_ = value;
                }
            }
        }
        #endregion
        
        public string supervisorRegistrationIDRef_ { get; set; }
        #region ReportingRole_
        private ReportingRole reportingRole_;
        public ReportingRole ReportingRole_
        {
            get
            {
                if (this.reportingRole_ != null)
                {
                    return this.reportingRole_; 
                }
                else if (this.reportingRoleIDRef_ != null)
                {
                    reportingRole_ = IDManager.getID(reportingRoleIDRef_) as ReportingRole;
                    return this.reportingRole_; 
                }
                else
                {
                      return this.reportingRole_; 
                }
            }
            set
            {
                if (this.reportingRole_ != value)
                {
                    this.reportingRole_ = value;
                }
            }
        }
        #endregion
        
        public string reportingRoleIDRef_ { get; set; }
        #region ReportingPurpose_
        private List<ReportingPurpose> reportingPurpose_;
        public List<ReportingPurpose> ReportingPurpose_
        {
            get
            {
                if (this.reportingPurpose_ != null)
                {
                    return this.reportingPurpose_; 
                }
                else if (this.reportingPurposeIDRef_ != null)
                {
                    return this.reportingPurpose_; 
                }
                else
                {
                      return this.reportingPurpose_; 
                }
            }
            set
            {
                if (this.reportingPurpose_ != value)
                {
                    this.reportingPurpose_ = value;
                }
            }
        }
        #endregion
        
        public string reportingPurposeIDRef_ { get; set; }
        #region MandatorilyClearable_
        private XsdTypeBoolean mandatorilyClearable_;
        public XsdTypeBoolean MandatorilyClearable_
        {
            get
            {
                if (this.mandatorilyClearable_ != null)
                {
                    return this.mandatorilyClearable_; 
                }
                else if (this.mandatorilyClearableIDRef_ != null)
                {
                    mandatorilyClearable_ = IDManager.getID(mandatorilyClearableIDRef_) as XsdTypeBoolean;
                    return this.mandatorilyClearable_; 
                }
                else
                {
                      return this.mandatorilyClearable_; 
                }
            }
            set
            {
                if (this.mandatorilyClearable_ != value)
                {
                    this.mandatorilyClearable_ = value;
                }
            }
        }
        #endregion
        
        public string mandatorilyClearableIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

