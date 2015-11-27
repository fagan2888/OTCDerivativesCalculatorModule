using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReportingRegime
    {
        public ReportingRegime(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        ReportingRegimeName ob = ReportingRegimeName();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new ReportingRegimeName(item);
                    }
                }
            }
            
        
            XmlNodeList supervisorRegistrationNodeList = xmlNode.SelectNodes("supervisorRegistration");
            
            foreach (XmlNode item in supervisorRegistrationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        supervisorRegistrationIDRef = item.Attributes["id"].Name;
                        List<SupervisorRegistration> ob = new List<SupervisorRegistration>();
                        ob.Add(new SupervisorRegistration(item));
                        IDManager.SetID(supervisorRegistrationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        supervisorRegistrationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    supervisorRegistration.Add(new SupervisorRegistration(item));
                    }
                }
            }
            
        
            XmlNodeList reportingRoleNodeList = xmlNode.SelectNodes("reportingRole");
            if (reportingRoleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reportingRoleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportingRoleIDRef = item.Attributes["id"].Name;
                        ReportingRole ob = ReportingRole();
                        IDManager.SetID(reportingRoleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportingRoleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reportingRole = new ReportingRole(item);
                    }
                }
            }
            
        
            XmlNodeList reportingPurposeNodeList = xmlNode.SelectNodes("reportingPurpose");
            
            foreach (XmlNode item in reportingPurposeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportingPurposeIDRef = item.Attributes["id"].Name;
                        List<ReportingPurpose> ob = new List<ReportingPurpose>();
                        ob.Add(new ReportingPurpose(item));
                        IDManager.SetID(reportingPurposeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportingPurposeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reportingPurpose.Add(new ReportingPurpose(item));
                    }
                }
            }
            
        
            XmlNodeList mandatorilyClearableNodeList = xmlNode.SelectNodes("mandatorilyClearable");
            if (mandatorilyClearableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mandatorilyClearableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mandatorilyClearableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(mandatorilyClearableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mandatorilyClearableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mandatorilyClearable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private ReportingRegimeName name;
        public ReportingRegimeName Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as ReportingRegimeName;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string ReportingRegimeNameIDRef { get; set; }
        #region SupervisorRegistration
        private List<SupervisorRegistration> supervisorRegistration;
        public List<SupervisorRegistration> SupervisorRegistration
        {
            get
            {
                if (this.supervisorRegistration != null)
                {
                    return this.supervisorRegistration; 
                }
                else if (this.supervisorRegistrationIDRef != null)
                {
                    supervisorRegistration = IDManager.getID(supervisorRegistrationIDRef) as List<SupervisorRegistration>;
                    return this.supervisorRegistration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.supervisorRegistration != value)
                {
                    this.supervisorRegistration = value;
                }
            }
        }
        #endregion
        
        public string SupervisorRegistrationIDRef { get; set; }
        #region ReportingRole
        private ReportingRole reportingRole;
        public ReportingRole ReportingRole
        {
            get
            {
                if (this.reportingRole != null)
                {
                    return this.reportingRole; 
                }
                else if (this.reportingRoleIDRef != null)
                {
                    reportingRole = IDManager.getID(reportingRoleIDRef) as ReportingRole;
                    return this.reportingRole; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportingRole != value)
                {
                    this.reportingRole = value;
                }
            }
        }
        #endregion
        
        public string ReportingRoleIDRef { get; set; }
        #region ReportingPurpose
        private List<ReportingPurpose> reportingPurpose;
        public List<ReportingPurpose> ReportingPurpose
        {
            get
            {
                if (this.reportingPurpose != null)
                {
                    return this.reportingPurpose; 
                }
                else if (this.reportingPurposeIDRef != null)
                {
                    reportingPurpose = IDManager.getID(reportingPurposeIDRef) as List<ReportingPurpose>;
                    return this.reportingPurpose; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportingPurpose != value)
                {
                    this.reportingPurpose = value;
                }
            }
        }
        #endregion
        
        public string ReportingPurposeIDRef { get; set; }
        #region MandatorilyClearable
        private XsdTypeBoolean mandatorilyClearable;
        public XsdTypeBoolean MandatorilyClearable
        {
            get
            {
                if (this.mandatorilyClearable != null)
                {
                    return this.mandatorilyClearable; 
                }
                else if (this.mandatorilyClearableIDRef != null)
                {
                    mandatorilyClearable = IDManager.getID(mandatorilyClearableIDRef) as XsdTypeBoolean;
                    return this.mandatorilyClearable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mandatorilyClearable != value)
                {
                    this.mandatorilyClearable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

