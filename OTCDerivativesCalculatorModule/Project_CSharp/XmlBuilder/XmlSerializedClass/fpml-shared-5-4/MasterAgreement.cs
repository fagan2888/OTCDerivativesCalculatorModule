using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MasterAgreement : ISerialized
    {
        public MasterAgreement(XmlNode xmlNode)
        {
            XmlNode masterAgreementTypeNode = xmlNode.SelectSingleNode("masterAgreementType");
            
            if (masterAgreementTypeNode != null)
            {
                if (masterAgreementTypeNode.Attributes["href"] != null || masterAgreementTypeNode.Attributes["id"] != null) 
                {
                    if (masterAgreementTypeNode.Attributes["id"] != null) 
                    {
                        masterAgreementTypeIDRef_ = masterAgreementTypeNode.Attributes["id"].Value;
                        MasterAgreementType ob = new MasterAgreementType(masterAgreementTypeNode);
                        IDManager.SetID(masterAgreementTypeIDRef_, ob);
                    }
                    else if (masterAgreementTypeNode.Attributes["href"] != null)
                    {
                        masterAgreementTypeIDRef_ = masterAgreementTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementType_ = new MasterAgreementType(masterAgreementTypeNode);
                    }
                }
                else
                {
                    masterAgreementType_ = new MasterAgreementType(masterAgreementTypeNode);
                }
            }
            
        
            XmlNode masterAgreementVersionNode = xmlNode.SelectSingleNode("masterAgreementVersion");
            
            if (masterAgreementVersionNode != null)
            {
                if (masterAgreementVersionNode.Attributes["href"] != null || masterAgreementVersionNode.Attributes["id"] != null) 
                {
                    if (masterAgreementVersionNode.Attributes["id"] != null) 
                    {
                        masterAgreementVersionIDRef_ = masterAgreementVersionNode.Attributes["id"].Value;
                        MasterAgreementVersion ob = new MasterAgreementVersion(masterAgreementVersionNode);
                        IDManager.SetID(masterAgreementVersionIDRef_, ob);
                    }
                    else if (masterAgreementVersionNode.Attributes["href"] != null)
                    {
                        masterAgreementVersionIDRef_ = masterAgreementVersionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementVersion_ = new MasterAgreementVersion(masterAgreementVersionNode);
                    }
                }
                else
                {
                    masterAgreementVersion_ = new MasterAgreementVersion(masterAgreementVersionNode);
                }
            }
            
        
            XmlNode masterAgreementDateNode = xmlNode.SelectSingleNode("masterAgreementDate");
            
            if (masterAgreementDateNode != null)
            {
                if (masterAgreementDateNode.Attributes["href"] != null || masterAgreementDateNode.Attributes["id"] != null) 
                {
                    if (masterAgreementDateNode.Attributes["id"] != null) 
                    {
                        masterAgreementDateIDRef_ = masterAgreementDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(masterAgreementDateNode);
                        IDManager.SetID(masterAgreementDateIDRef_, ob);
                    }
                    else if (masterAgreementDateNode.Attributes["href"] != null)
                    {
                        masterAgreementDateIDRef_ = masterAgreementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementDate_ = new XsdTypeDate(masterAgreementDateNode);
                    }
                }
                else
                {
                    masterAgreementDate_ = new XsdTypeDate(masterAgreementDateNode);
                }
            }
            
        
        }
        
    
        #region MasterAgreementType_
        private MasterAgreementType masterAgreementType_;
        public MasterAgreementType MasterAgreementType_
        {
            get
            {
                if (this.masterAgreementType_ != null)
                {
                    return this.masterAgreementType_; 
                }
                else if (this.masterAgreementTypeIDRef_ != null)
                {
                    masterAgreementType_ = IDManager.getID(masterAgreementTypeIDRef_) as MasterAgreementType;
                    return this.masterAgreementType_; 
                }
                else
                {
                      return this.masterAgreementType_; 
                }
            }
            set
            {
                if (this.masterAgreementType_ != value)
                {
                    this.masterAgreementType_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementTypeIDRef_ { get; set; }
        #region MasterAgreementVersion_
        private MasterAgreementVersion masterAgreementVersion_;
        public MasterAgreementVersion MasterAgreementVersion_
        {
            get
            {
                if (this.masterAgreementVersion_ != null)
                {
                    return this.masterAgreementVersion_; 
                }
                else if (this.masterAgreementVersionIDRef_ != null)
                {
                    masterAgreementVersion_ = IDManager.getID(masterAgreementVersionIDRef_) as MasterAgreementVersion;
                    return this.masterAgreementVersion_; 
                }
                else
                {
                      return this.masterAgreementVersion_; 
                }
            }
            set
            {
                if (this.masterAgreementVersion_ != value)
                {
                    this.masterAgreementVersion_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementVersionIDRef_ { get; set; }
        #region MasterAgreementDate_
        private XsdTypeDate masterAgreementDate_;
        public XsdTypeDate MasterAgreementDate_
        {
            get
            {
                if (this.masterAgreementDate_ != null)
                {
                    return this.masterAgreementDate_; 
                }
                else if (this.masterAgreementDateIDRef_ != null)
                {
                    masterAgreementDate_ = IDManager.getID(masterAgreementDateIDRef_) as XsdTypeDate;
                    return this.masterAgreementDate_; 
                }
                else
                {
                      return this.masterAgreementDate_; 
                }
            }
            set
            {
                if (this.masterAgreementDate_ != value)
                {
                    this.masterAgreementDate_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

