using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Representations : ISerialized
    {
        public Representations(XmlNode xmlNode)
        {
            XmlNode nonRelianceNode = xmlNode.SelectSingleNode("nonReliance");
            
            if (nonRelianceNode != null)
            {
                if (nonRelianceNode.Attributes["href"] != null || nonRelianceNode.Attributes["id"] != null) 
                {
                    if (nonRelianceNode.Attributes["id"] != null) 
                    {
                        nonRelianceIDRef_ = nonRelianceNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(nonRelianceNode);
                        IDManager.SetID(nonRelianceIDRef_, ob);
                    }
                    else if (nonRelianceNode.Attributes["href"] != null)
                    {
                        nonRelianceIDRef_ = nonRelianceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonReliance_ = new XsdTypeBoolean(nonRelianceNode);
                    }
                }
                else
                {
                    nonReliance_ = new XsdTypeBoolean(nonRelianceNode);
                }
            }
            
        
            XmlNode agreementsRegardingHedgingNode = xmlNode.SelectSingleNode("agreementsRegardingHedging");
            
            if (agreementsRegardingHedgingNode != null)
            {
                if (agreementsRegardingHedgingNode.Attributes["href"] != null || agreementsRegardingHedgingNode.Attributes["id"] != null) 
                {
                    if (agreementsRegardingHedgingNode.Attributes["id"] != null) 
                    {
                        agreementsRegardingHedgingIDRef_ = agreementsRegardingHedgingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(agreementsRegardingHedgingNode);
                        IDManager.SetID(agreementsRegardingHedgingIDRef_, ob);
                    }
                    else if (agreementsRegardingHedgingNode.Attributes["href"] != null)
                    {
                        agreementsRegardingHedgingIDRef_ = agreementsRegardingHedgingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        agreementsRegardingHedging_ = new XsdTypeBoolean(agreementsRegardingHedgingNode);
                    }
                }
                else
                {
                    agreementsRegardingHedging_ = new XsdTypeBoolean(agreementsRegardingHedgingNode);
                }
            }
            
        
            XmlNode indexDisclaimerNode = xmlNode.SelectSingleNode("indexDisclaimer");
            
            if (indexDisclaimerNode != null)
            {
                if (indexDisclaimerNode.Attributes["href"] != null || indexDisclaimerNode.Attributes["id"] != null) 
                {
                    if (indexDisclaimerNode.Attributes["id"] != null) 
                    {
                        indexDisclaimerIDRef_ = indexDisclaimerNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(indexDisclaimerNode);
                        IDManager.SetID(indexDisclaimerIDRef_, ob);
                    }
                    else if (indexDisclaimerNode.Attributes["href"] != null)
                    {
                        indexDisclaimerIDRef_ = indexDisclaimerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexDisclaimer_ = new XsdTypeBoolean(indexDisclaimerNode);
                    }
                }
                else
                {
                    indexDisclaimer_ = new XsdTypeBoolean(indexDisclaimerNode);
                }
            }
            
        
            XmlNode additionalAcknowledgementsNode = xmlNode.SelectSingleNode("additionalAcknowledgements");
            
            if (additionalAcknowledgementsNode != null)
            {
                if (additionalAcknowledgementsNode.Attributes["href"] != null || additionalAcknowledgementsNode.Attributes["id"] != null) 
                {
                    if (additionalAcknowledgementsNode.Attributes["id"] != null) 
                    {
                        additionalAcknowledgementsIDRef_ = additionalAcknowledgementsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(additionalAcknowledgementsNode);
                        IDManager.SetID(additionalAcknowledgementsIDRef_, ob);
                    }
                    else if (additionalAcknowledgementsNode.Attributes["href"] != null)
                    {
                        additionalAcknowledgementsIDRef_ = additionalAcknowledgementsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalAcknowledgements_ = new XsdTypeBoolean(additionalAcknowledgementsNode);
                    }
                }
                else
                {
                    additionalAcknowledgements_ = new XsdTypeBoolean(additionalAcknowledgementsNode);
                }
            }
            
        
        }
        
    
        #region NonReliance_
        private XsdTypeBoolean nonReliance_;
        public XsdTypeBoolean NonReliance_
        {
            get
            {
                if (this.nonReliance_ != null)
                {
                    return this.nonReliance_; 
                }
                else if (this.nonRelianceIDRef_ != null)
                {
                    nonReliance_ = IDManager.getID(nonRelianceIDRef_) as XsdTypeBoolean;
                    return this.nonReliance_; 
                }
                else
                {
                      return this.nonReliance_; 
                }
            }
            set
            {
                if (this.nonReliance_ != value)
                {
                    this.nonReliance_ = value;
                }
            }
        }
        #endregion
        
        public string nonRelianceIDRef_ { get; set; }
        #region AgreementsRegardingHedging_
        private XsdTypeBoolean agreementsRegardingHedging_;
        public XsdTypeBoolean AgreementsRegardingHedging_
        {
            get
            {
                if (this.agreementsRegardingHedging_ != null)
                {
                    return this.agreementsRegardingHedging_; 
                }
                else if (this.agreementsRegardingHedgingIDRef_ != null)
                {
                    agreementsRegardingHedging_ = IDManager.getID(agreementsRegardingHedgingIDRef_) as XsdTypeBoolean;
                    return this.agreementsRegardingHedging_; 
                }
                else
                {
                      return this.agreementsRegardingHedging_; 
                }
            }
            set
            {
                if (this.agreementsRegardingHedging_ != value)
                {
                    this.agreementsRegardingHedging_ = value;
                }
            }
        }
        #endregion
        
        public string agreementsRegardingHedgingIDRef_ { get; set; }
        #region IndexDisclaimer_
        private XsdTypeBoolean indexDisclaimer_;
        public XsdTypeBoolean IndexDisclaimer_
        {
            get
            {
                if (this.indexDisclaimer_ != null)
                {
                    return this.indexDisclaimer_; 
                }
                else if (this.indexDisclaimerIDRef_ != null)
                {
                    indexDisclaimer_ = IDManager.getID(indexDisclaimerIDRef_) as XsdTypeBoolean;
                    return this.indexDisclaimer_; 
                }
                else
                {
                      return this.indexDisclaimer_; 
                }
            }
            set
            {
                if (this.indexDisclaimer_ != value)
                {
                    this.indexDisclaimer_ = value;
                }
            }
        }
        #endregion
        
        public string indexDisclaimerIDRef_ { get; set; }
        #region AdditionalAcknowledgements_
        private XsdTypeBoolean additionalAcknowledgements_;
        public XsdTypeBoolean AdditionalAcknowledgements_
        {
            get
            {
                if (this.additionalAcknowledgements_ != null)
                {
                    return this.additionalAcknowledgements_; 
                }
                else if (this.additionalAcknowledgementsIDRef_ != null)
                {
                    additionalAcknowledgements_ = IDManager.getID(additionalAcknowledgementsIDRef_) as XsdTypeBoolean;
                    return this.additionalAcknowledgements_; 
                }
                else
                {
                      return this.additionalAcknowledgements_; 
                }
            }
            set
            {
                if (this.additionalAcknowledgements_ != value)
                {
                    this.additionalAcknowledgements_ = value;
                }
            }
        }
        #endregion
        
        public string additionalAcknowledgementsIDRef_ { get; set; }
        
    
        
    
    }
    
}

