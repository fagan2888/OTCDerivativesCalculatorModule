using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MasterConfirmation : ISerialized
    {
        public MasterConfirmation(XmlNode xmlNode)
        {
            XmlNode masterConfirmationTypeNode = xmlNode.SelectSingleNode("masterConfirmationType");
            
            if (masterConfirmationTypeNode != null)
            {
                if (masterConfirmationTypeNode.Attributes["href"] != null || masterConfirmationTypeNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationTypeNode.Attributes["id"] != null) 
                    {
                        masterConfirmationTypeIDRef_ = masterConfirmationTypeNode.Attributes["id"].Value;
                        MasterConfirmationType ob = new MasterConfirmationType(masterConfirmationTypeNode);
                        IDManager.SetID(masterConfirmationTypeIDRef_, ob);
                    }
                    else if (masterConfirmationTypeNode.Attributes["href"] != null)
                    {
                        masterConfirmationTypeIDRef_ = masterConfirmationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmationType_ = new MasterConfirmationType(masterConfirmationTypeNode);
                    }
                }
                else
                {
                    masterConfirmationType_ = new MasterConfirmationType(masterConfirmationTypeNode);
                }
            }
            
        
            XmlNode masterConfirmationDateNode = xmlNode.SelectSingleNode("masterConfirmationDate");
            
            if (masterConfirmationDateNode != null)
            {
                if (masterConfirmationDateNode.Attributes["href"] != null || masterConfirmationDateNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationDateNode.Attributes["id"] != null) 
                    {
                        masterConfirmationDateIDRef_ = masterConfirmationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(masterConfirmationDateNode);
                        IDManager.SetID(masterConfirmationDateIDRef_, ob);
                    }
                    else if (masterConfirmationDateNode.Attributes["href"] != null)
                    {
                        masterConfirmationDateIDRef_ = masterConfirmationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmationDate_ = new XsdTypeDate(masterConfirmationDateNode);
                    }
                }
                else
                {
                    masterConfirmationDate_ = new XsdTypeDate(masterConfirmationDateNode);
                }
            }
            
        
            XmlNode masterConfirmationAnnexDateNode = xmlNode.SelectSingleNode("masterConfirmationAnnexDate");
            
            if (masterConfirmationAnnexDateNode != null)
            {
                if (masterConfirmationAnnexDateNode.Attributes["href"] != null || masterConfirmationAnnexDateNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationAnnexDateNode.Attributes["id"] != null) 
                    {
                        masterConfirmationAnnexDateIDRef_ = masterConfirmationAnnexDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(masterConfirmationAnnexDateNode);
                        IDManager.SetID(masterConfirmationAnnexDateIDRef_, ob);
                    }
                    else if (masterConfirmationAnnexDateNode.Attributes["href"] != null)
                    {
                        masterConfirmationAnnexDateIDRef_ = masterConfirmationAnnexDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmationAnnexDate_ = new XsdTypeDate(masterConfirmationAnnexDateNode);
                    }
                }
                else
                {
                    masterConfirmationAnnexDate_ = new XsdTypeDate(masterConfirmationAnnexDateNode);
                }
            }
            
        
            XmlNode masterConfirmationAnnexTypeNode = xmlNode.SelectSingleNode("masterConfirmationAnnexType");
            
            if (masterConfirmationAnnexTypeNode != null)
            {
                if (masterConfirmationAnnexTypeNode.Attributes["href"] != null || masterConfirmationAnnexTypeNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationAnnexTypeNode.Attributes["id"] != null) 
                    {
                        masterConfirmationAnnexTypeIDRef_ = masterConfirmationAnnexTypeNode.Attributes["id"].Value;
                        MasterConfirmationAnnexType ob = new MasterConfirmationAnnexType(masterConfirmationAnnexTypeNode);
                        IDManager.SetID(masterConfirmationAnnexTypeIDRef_, ob);
                    }
                    else if (masterConfirmationAnnexTypeNode.Attributes["href"] != null)
                    {
                        masterConfirmationAnnexTypeIDRef_ = masterConfirmationAnnexTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmationAnnexType_ = new MasterConfirmationAnnexType(masterConfirmationAnnexTypeNode);
                    }
                }
                else
                {
                    masterConfirmationAnnexType_ = new MasterConfirmationAnnexType(masterConfirmationAnnexTypeNode);
                }
            }
            
        
        }
        
    
        #region MasterConfirmationType_
        private MasterConfirmationType masterConfirmationType_;
        public MasterConfirmationType MasterConfirmationType_
        {
            get
            {
                if (this.masterConfirmationType_ != null)
                {
                    return this.masterConfirmationType_; 
                }
                else if (this.masterConfirmationTypeIDRef_ != null)
                {
                    masterConfirmationType_ = IDManager.getID(masterConfirmationTypeIDRef_) as MasterConfirmationType;
                    return this.masterConfirmationType_; 
                }
                else
                {
                      return this.masterConfirmationType_; 
                }
            }
            set
            {
                if (this.masterConfirmationType_ != value)
                {
                    this.masterConfirmationType_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationTypeIDRef_ { get; set; }
        #region MasterConfirmationDate_
        private XsdTypeDate masterConfirmationDate_;
        public XsdTypeDate MasterConfirmationDate_
        {
            get
            {
                if (this.masterConfirmationDate_ != null)
                {
                    return this.masterConfirmationDate_; 
                }
                else if (this.masterConfirmationDateIDRef_ != null)
                {
                    masterConfirmationDate_ = IDManager.getID(masterConfirmationDateIDRef_) as XsdTypeDate;
                    return this.masterConfirmationDate_; 
                }
                else
                {
                      return this.masterConfirmationDate_; 
                }
            }
            set
            {
                if (this.masterConfirmationDate_ != value)
                {
                    this.masterConfirmationDate_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationDateIDRef_ { get; set; }
        #region MasterConfirmationAnnexDate_
        private XsdTypeDate masterConfirmationAnnexDate_;
        public XsdTypeDate MasterConfirmationAnnexDate_
        {
            get
            {
                if (this.masterConfirmationAnnexDate_ != null)
                {
                    return this.masterConfirmationAnnexDate_; 
                }
                else if (this.masterConfirmationAnnexDateIDRef_ != null)
                {
                    masterConfirmationAnnexDate_ = IDManager.getID(masterConfirmationAnnexDateIDRef_) as XsdTypeDate;
                    return this.masterConfirmationAnnexDate_; 
                }
                else
                {
                      return this.masterConfirmationAnnexDate_; 
                }
            }
            set
            {
                if (this.masterConfirmationAnnexDate_ != value)
                {
                    this.masterConfirmationAnnexDate_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationAnnexDateIDRef_ { get; set; }
        #region MasterConfirmationAnnexType_
        private MasterConfirmationAnnexType masterConfirmationAnnexType_;
        public MasterConfirmationAnnexType MasterConfirmationAnnexType_
        {
            get
            {
                if (this.masterConfirmationAnnexType_ != null)
                {
                    return this.masterConfirmationAnnexType_; 
                }
                else if (this.masterConfirmationAnnexTypeIDRef_ != null)
                {
                    masterConfirmationAnnexType_ = IDManager.getID(masterConfirmationAnnexTypeIDRef_) as MasterConfirmationAnnexType;
                    return this.masterConfirmationAnnexType_; 
                }
                else
                {
                      return this.masterConfirmationAnnexType_; 
                }
            }
            set
            {
                if (this.masterConfirmationAnnexType_ != value)
                {
                    this.masterConfirmationAnnexType_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationAnnexTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

