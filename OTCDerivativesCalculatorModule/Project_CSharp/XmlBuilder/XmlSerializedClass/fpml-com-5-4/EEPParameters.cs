using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EEPParameters : ISerialized
    {
        public EEPParameters(XmlNode xmlNode)
        {
            XmlNode eEPApplicableNode = xmlNode.SelectSingleNode("eEPApplicable");
            
            if (eEPApplicableNode != null)
            {
                if (eEPApplicableNode.Attributes["href"] != null || eEPApplicableNode.Attributes["id"] != null) 
                {
                    if (eEPApplicableNode.Attributes["id"] != null) 
                    {
                        eEPApplicableIDRef_ = eEPApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(eEPApplicableNode);
                        IDManager.SetID(eEPApplicableIDRef_, ob);
                    }
                    else if (eEPApplicableNode.Attributes["href"] != null)
                    {
                        eEPApplicableIDRef_ = eEPApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eEPApplicable_ = new XsdTypeBoolean(eEPApplicableNode);
                    }
                }
                else
                {
                    eEPApplicable_ = new XsdTypeBoolean(eEPApplicableNode);
                }
            }
            
        
            XmlNode riskPeriodNode = xmlNode.SelectSingleNode("riskPeriod");
            
            if (riskPeriodNode != null)
            {
                if (riskPeriodNode.Attributes["href"] != null || riskPeriodNode.Attributes["id"] != null) 
                {
                    if (riskPeriodNode.Attributes["id"] != null) 
                    {
                        riskPeriodIDRef_ = riskPeriodNode.Attributes["id"].Value;
                        EEPRiskPeriod ob = new EEPRiskPeriod(riskPeriodNode);
                        IDManager.SetID(riskPeriodIDRef_, ob);
                    }
                    else if (riskPeriodNode.Attributes["href"] != null)
                    {
                        riskPeriodIDRef_ = riskPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        riskPeriod_ = new EEPRiskPeriod(riskPeriodNode);
                    }
                }
                else
                {
                    riskPeriod_ = new EEPRiskPeriod(riskPeriodNode);
                }
            }
            
        
            XmlNode equivalentApplicableNode = xmlNode.SelectSingleNode("equivalentApplicable");
            
            if (equivalentApplicableNode != null)
            {
                if (equivalentApplicableNode.Attributes["href"] != null || equivalentApplicableNode.Attributes["id"] != null) 
                {
                    if (equivalentApplicableNode.Attributes["id"] != null) 
                    {
                        equivalentApplicableIDRef_ = equivalentApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(equivalentApplicableNode);
                        IDManager.SetID(equivalentApplicableIDRef_, ob);
                    }
                    else if (equivalentApplicableNode.Attributes["href"] != null)
                    {
                        equivalentApplicableIDRef_ = equivalentApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equivalentApplicable_ = new XsdTypeBoolean(equivalentApplicableNode);
                    }
                }
                else
                {
                    equivalentApplicable_ = new XsdTypeBoolean(equivalentApplicableNode);
                }
            }
            
        
            XmlNode penaltyApplicableNode = xmlNode.SelectSingleNode("penaltyApplicable");
            
            if (penaltyApplicableNode != null)
            {
                if (penaltyApplicableNode.Attributes["href"] != null || penaltyApplicableNode.Attributes["id"] != null) 
                {
                    if (penaltyApplicableNode.Attributes["id"] != null) 
                    {
                        penaltyApplicableIDRef_ = penaltyApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(penaltyApplicableNode);
                        IDManager.SetID(penaltyApplicableIDRef_, ob);
                    }
                    else if (penaltyApplicableNode.Attributes["href"] != null)
                    {
                        penaltyApplicableIDRef_ = penaltyApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        penaltyApplicable_ = new XsdTypeBoolean(penaltyApplicableNode);
                    }
                }
                else
                {
                    penaltyApplicable_ = new XsdTypeBoolean(penaltyApplicableNode);
                }
            }
            
        
        }
        
    
        #region EEPApplicable_
        private XsdTypeBoolean eEPApplicable_;
        public XsdTypeBoolean EEPApplicable_
        {
            get
            {
                if (this.eEPApplicable_ != null)
                {
                    return this.eEPApplicable_; 
                }
                else if (this.eEPApplicableIDRef_ != null)
                {
                    eEPApplicable_ = IDManager.getID(eEPApplicableIDRef_) as XsdTypeBoolean;
                    return this.eEPApplicable_; 
                }
                else
                {
                      return this.eEPApplicable_; 
                }
            }
            set
            {
                if (this.eEPApplicable_ != value)
                {
                    this.eEPApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string eEPApplicableIDRef_ { get; set; }
        #region RiskPeriod_
        private EEPRiskPeriod riskPeriod_;
        public EEPRiskPeriod RiskPeriod_
        {
            get
            {
                if (this.riskPeriod_ != null)
                {
                    return this.riskPeriod_; 
                }
                else if (this.riskPeriodIDRef_ != null)
                {
                    riskPeriod_ = IDManager.getID(riskPeriodIDRef_) as EEPRiskPeriod;
                    return this.riskPeriod_; 
                }
                else
                {
                      return this.riskPeriod_; 
                }
            }
            set
            {
                if (this.riskPeriod_ != value)
                {
                    this.riskPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string riskPeriodIDRef_ { get; set; }
        #region EquivalentApplicable_
        private XsdTypeBoolean equivalentApplicable_;
        public XsdTypeBoolean EquivalentApplicable_
        {
            get
            {
                if (this.equivalentApplicable_ != null)
                {
                    return this.equivalentApplicable_; 
                }
                else if (this.equivalentApplicableIDRef_ != null)
                {
                    equivalentApplicable_ = IDManager.getID(equivalentApplicableIDRef_) as XsdTypeBoolean;
                    return this.equivalentApplicable_; 
                }
                else
                {
                      return this.equivalentApplicable_; 
                }
            }
            set
            {
                if (this.equivalentApplicable_ != value)
                {
                    this.equivalentApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string equivalentApplicableIDRef_ { get; set; }
        #region PenaltyApplicable_
        private XsdTypeBoolean penaltyApplicable_;
        public XsdTypeBoolean PenaltyApplicable_
        {
            get
            {
                if (this.penaltyApplicable_ != null)
                {
                    return this.penaltyApplicable_; 
                }
                else if (this.penaltyApplicableIDRef_ != null)
                {
                    penaltyApplicable_ = IDManager.getID(penaltyApplicableIDRef_) as XsdTypeBoolean;
                    return this.penaltyApplicable_; 
                }
                else
                {
                      return this.penaltyApplicable_; 
                }
            }
            set
            {
                if (this.penaltyApplicable_ != value)
                {
                    this.penaltyApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string penaltyApplicableIDRef_ { get; set; }
        
    
        
    
    }
    
}

