using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SupervisorRegistration
    {
        public SupervisorRegistration(XmlNode xmlNode)
        {
            XmlNodeList supervisoryBodyNodeList = xmlNode.SelectNodes("supervisoryBody");
            if (supervisoryBodyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in supervisoryBodyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        supervisoryBodyIDRef = item.Attributes["id"].Name;
                        SupervisoryBody ob = SupervisoryBody();
                        IDManager.SetID(supervisoryBodyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        supervisoryBodyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        supervisoryBody = new SupervisoryBody(item);
                    }
                }
            }
            
        
            XmlNodeList registrationNumberNodeList = xmlNode.SelectNodes("registrationNumber");
            if (registrationNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in registrationNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        registrationNumberIDRef = item.Attributes["id"].Name;
                        RegulatorId ob = RegulatorId();
                        IDManager.SetID(registrationNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        registrationNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        registrationNumber = new RegulatorId(item);
                    }
                }
            }
            
        
        }
        
    
        #region SupervisoryBody
        private SupervisoryBody supervisoryBody;
        public SupervisoryBody SupervisoryBody
        {
            get
            {
                if (this.supervisoryBody != null)
                {
                    return this.supervisoryBody; 
                }
                else if (this.supervisoryBodyIDRef != null)
                {
                    supervisoryBody = IDManager.getID(supervisoryBodyIDRef) as SupervisoryBody;
                    return this.supervisoryBody; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.supervisoryBody != value)
                {
                    this.supervisoryBody = value;
                }
            }
        }
        #endregion
        
        public string SupervisoryBodyIDRef { get; set; }
        #region RegistrationNumber
        private RegulatorId registrationNumber;
        public RegulatorId RegistrationNumber
        {
            get
            {
                if (this.registrationNumber != null)
                {
                    return this.registrationNumber; 
                }
                else if (this.registrationNumberIDRef != null)
                {
                    registrationNumber = IDManager.getID(registrationNumberIDRef) as RegulatorId;
                    return this.registrationNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.registrationNumber != value)
                {
                    this.registrationNumber = value;
                }
            }
        }
        #endregion
        
        public string RegulatorIdIDRef { get; set; }
        
    
        
    
    }
    
}

