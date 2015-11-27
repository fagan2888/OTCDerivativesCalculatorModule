using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CDSSpreadTermstructure : TermstructureBase
    {
        public CDSSpreadTermstructure() { }
        public CDSSpreadTermstructure(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dateGenerationNode = xmlNode.SelectSingleNode("dateGeneration");
            
            if (dateGenerationNode != null)
            {
                if (dateGenerationNode.Attributes["href"] != null || dateGenerationNode.Attributes["id"] != null) 
                {
                    if (dateGenerationNode.Attributes["id"] != null) 
                    {
                        dateGenerationIDRef_ = dateGenerationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dateGenerationNode);
                        IDManager.SetID(dateGenerationIDRef_, ob);
                    }
                    else if (dateGenerationNode.Attributes["href"] != null)
                    {
                        dateGenerationIDRef_ = dateGenerationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateGeneration_ = new XsdTypeToken(dateGenerationNode);
                    }
                }
                else
                {
                    dateGeneration_ = new XsdTypeToken(dateGenerationNode);
                }
            }
            
        
            XmlNode recoveryRateNode = xmlNode.SelectSingleNode("recoveryRate");
            
            if (recoveryRateNode != null)
            {
                if (recoveryRateNode.Attributes["href"] != null || recoveryRateNode.Attributes["id"] != null) 
                {
                    if (recoveryRateNode.Attributes["id"] != null) 
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(recoveryRateNode);
                        IDManager.SetID(recoveryRateIDRef_, ob);
                    }
                    else if (recoveryRateNode.Attributes["href"] != null)
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryRate_ = new XsdTypeToken(recoveryRateNode);
                    }
                }
                else
                {
                    recoveryRate_ = new XsdTypeToken(recoveryRateNode);
                }
            }
            
        
        }
        
    
        #region DateGeneration_
        private XsdTypeToken dateGeneration_;
        public XsdTypeToken DateGeneration_
        {
            get
            {
                if (this.dateGeneration_ != null)
                {
                    return this.dateGeneration_; 
                }
                else if (this.dateGenerationIDRef_ != null)
                {
                    dateGeneration_ = IDManager.getID(dateGenerationIDRef_) as XsdTypeToken;
                    return this.dateGeneration_; 
                }
                else
                {
                      return this.dateGeneration_; 
                }
            }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                }
            }
        }
        #endregion
        
        public string dateGenerationIDRef_ { get; set; }
        #region RecoveryRate_
        private XsdTypeToken recoveryRate_;
        public XsdTypeToken RecoveryRate_
        {
            get
            {
                if (this.recoveryRate_ != null)
                {
                    return this.recoveryRate_; 
                }
                else if (this.recoveryRateIDRef_ != null)
                {
                    recoveryRate_ = IDManager.getID(recoveryRateIDRef_) as XsdTypeToken;
                    return this.recoveryRate_; 
                }
                else
                {
                      return this.recoveryRate_; 
                }
            }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

