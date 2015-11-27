using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditDerivativesNotices : ISerialized
    {
        public CreditDerivativesNotices(XmlNode xmlNode)
        {
            XmlNode creditEventNode = xmlNode.SelectSingleNode("creditEvent");
            
            if (creditEventNode != null)
            {
                if (creditEventNode.Attributes["href"] != null || creditEventNode.Attributes["id"] != null) 
                {
                    if (creditEventNode.Attributes["id"] != null) 
                    {
                        creditEventIDRef_ = creditEventNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(creditEventNode);
                        IDManager.SetID(creditEventIDRef_, ob);
                    }
                    else if (creditEventNode.Attributes["href"] != null)
                    {
                        creditEventIDRef_ = creditEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvent_ = new XsdTypeBoolean(creditEventNode);
                    }
                }
                else
                {
                    creditEvent_ = new XsdTypeBoolean(creditEventNode);
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
                        XsdTypeBoolean ob = new XsdTypeBoolean(publiclyAvailableInformationNode);
                        IDManager.SetID(publiclyAvailableInformationIDRef_, ob);
                    }
                    else if (publiclyAvailableInformationNode.Attributes["href"] != null)
                    {
                        publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publiclyAvailableInformation_ = new XsdTypeBoolean(publiclyAvailableInformationNode);
                    }
                }
                else
                {
                    publiclyAvailableInformation_ = new XsdTypeBoolean(publiclyAvailableInformationNode);
                }
            }
            
        
            XmlNode physicalSettlementNode = xmlNode.SelectSingleNode("physicalSettlement");
            
            if (physicalSettlementNode != null)
            {
                if (physicalSettlementNode.Attributes["href"] != null || physicalSettlementNode.Attributes["id"] != null) 
                {
                    if (physicalSettlementNode.Attributes["id"] != null) 
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(physicalSettlementNode);
                        IDManager.SetID(physicalSettlementIDRef_, ob);
                    }
                    else if (physicalSettlementNode.Attributes["href"] != null)
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalSettlement_ = new XsdTypeBoolean(physicalSettlementNode);
                    }
                }
                else
                {
                    physicalSettlement_ = new XsdTypeBoolean(physicalSettlementNode);
                }
            }
            
        
        }
        
    
        #region CreditEvent_
        private XsdTypeBoolean creditEvent_;
        public XsdTypeBoolean CreditEvent_
        {
            get
            {
                if (this.creditEvent_ != null)
                {
                    return this.creditEvent_; 
                }
                else if (this.creditEventIDRef_ != null)
                {
                    creditEvent_ = IDManager.getID(creditEventIDRef_) as XsdTypeBoolean;
                    return this.creditEvent_; 
                }
                else
                {
                      return this.creditEvent_; 
                }
            }
            set
            {
                if (this.creditEvent_ != value)
                {
                    this.creditEvent_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventIDRef_ { get; set; }
        #region PubliclyAvailableInformation_
        private XsdTypeBoolean publiclyAvailableInformation_;
        public XsdTypeBoolean PubliclyAvailableInformation_
        {
            get
            {
                if (this.publiclyAvailableInformation_ != null)
                {
                    return this.publiclyAvailableInformation_; 
                }
                else if (this.publiclyAvailableInformationIDRef_ != null)
                {
                    publiclyAvailableInformation_ = IDManager.getID(publiclyAvailableInformationIDRef_) as XsdTypeBoolean;
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
        #region PhysicalSettlement_
        private XsdTypeBoolean physicalSettlement_;
        public XsdTypeBoolean PhysicalSettlement_
        {
            get
            {
                if (this.physicalSettlement_ != null)
                {
                    return this.physicalSettlement_; 
                }
                else if (this.physicalSettlementIDRef_ != null)
                {
                    physicalSettlement_ = IDManager.getID(physicalSettlementIDRef_) as XsdTypeBoolean;
                    return this.physicalSettlement_; 
                }
                else
                {
                      return this.physicalSettlement_; 
                }
            }
            set
            {
                if (this.physicalSettlement_ != value)
                {
                    this.physicalSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string physicalSettlementIDRef_ { get; set; }
        
    
        
    
    }
    
}

