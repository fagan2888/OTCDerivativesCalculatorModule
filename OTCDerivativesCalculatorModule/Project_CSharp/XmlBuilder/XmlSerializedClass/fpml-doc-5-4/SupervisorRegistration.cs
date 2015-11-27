using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SupervisorRegistration : ISerialized
    {
        public SupervisorRegistration(XmlNode xmlNode)
        {
            XmlNode supervisoryBodyNode = xmlNode.SelectSingleNode("supervisoryBody");
            
            if (supervisoryBodyNode != null)
            {
                if (supervisoryBodyNode.Attributes["href"] != null || supervisoryBodyNode.Attributes["id"] != null) 
                {
                    if (supervisoryBodyNode.Attributes["id"] != null) 
                    {
                        supervisoryBodyIDRef_ = supervisoryBodyNode.Attributes["id"].Value;
                        SupervisoryBody ob = new SupervisoryBody(supervisoryBodyNode);
                        IDManager.SetID(supervisoryBodyIDRef_, ob);
                    }
                    else if (supervisoryBodyNode.Attributes["href"] != null)
                    {
                        supervisoryBodyIDRef_ = supervisoryBodyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        supervisoryBody_ = new SupervisoryBody(supervisoryBodyNode);
                    }
                }
                else
                {
                    supervisoryBody_ = new SupervisoryBody(supervisoryBodyNode);
                }
            }
            
        
            XmlNode registrationNumberNode = xmlNode.SelectSingleNode("registrationNumber");
            
            if (registrationNumberNode != null)
            {
                if (registrationNumberNode.Attributes["href"] != null || registrationNumberNode.Attributes["id"] != null) 
                {
                    if (registrationNumberNode.Attributes["id"] != null) 
                    {
                        registrationNumberIDRef_ = registrationNumberNode.Attributes["id"].Value;
                        RegulatorId ob = new RegulatorId(registrationNumberNode);
                        IDManager.SetID(registrationNumberIDRef_, ob);
                    }
                    else if (registrationNumberNode.Attributes["href"] != null)
                    {
                        registrationNumberIDRef_ = registrationNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        registrationNumber_ = new RegulatorId(registrationNumberNode);
                    }
                }
                else
                {
                    registrationNumber_ = new RegulatorId(registrationNumberNode);
                }
            }
            
        
        }
        
    
        #region SupervisoryBody_
        private SupervisoryBody supervisoryBody_;
        public SupervisoryBody SupervisoryBody_
        {
            get
            {
                if (this.supervisoryBody_ != null)
                {
                    return this.supervisoryBody_; 
                }
                else if (this.supervisoryBodyIDRef_ != null)
                {
                    supervisoryBody_ = IDManager.getID(supervisoryBodyIDRef_) as SupervisoryBody;
                    return this.supervisoryBody_; 
                }
                else
                {
                      return this.supervisoryBody_; 
                }
            }
            set
            {
                if (this.supervisoryBody_ != value)
                {
                    this.supervisoryBody_ = value;
                }
            }
        }
        #endregion
        
        public string supervisoryBodyIDRef_ { get; set; }
        #region RegistrationNumber_
        private RegulatorId registrationNumber_;
        public RegulatorId RegistrationNumber_
        {
            get
            {
                if (this.registrationNumber_ != null)
                {
                    return this.registrationNumber_; 
                }
                else if (this.registrationNumberIDRef_ != null)
                {
                    registrationNumber_ = IDManager.getID(registrationNumberIDRef_) as RegulatorId;
                    return this.registrationNumber_; 
                }
                else
                {
                      return this.registrationNumber_; 
                }
            }
            set
            {
                if (this.registrationNumber_ != value)
                {
                    this.registrationNumber_ = value;
                }
            }
        }
        #endregion
        
        public string registrationNumberIDRef_ { get; set; }
        
    
        
    
    }
    
}

