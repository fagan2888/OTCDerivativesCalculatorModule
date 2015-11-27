using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MutualFund : UnderlyingAsset
    {
        public MutualFund(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode openEndedFundNode = xmlNode.SelectSingleNode("openEndedFund");
            
            if (openEndedFundNode != null)
            {
                if (openEndedFundNode.Attributes["href"] != null || openEndedFundNode.Attributes["id"] != null) 
                {
                    if (openEndedFundNode.Attributes["id"] != null) 
                    {
                        openEndedFundIDRef_ = openEndedFundNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(openEndedFundNode);
                        IDManager.SetID(openEndedFundIDRef_, ob);
                    }
                    else if (openEndedFundNode.Attributes["href"] != null)
                    {
                        openEndedFundIDRef_ = openEndedFundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        openEndedFund_ = new XsdTypeBoolean(openEndedFundNode);
                    }
                }
                else
                {
                    openEndedFund_ = new XsdTypeBoolean(openEndedFundNode);
                }
            }
            
        
            XmlNode fundManagerNode = xmlNode.SelectSingleNode("fundManager");
            
            if (fundManagerNode != null)
            {
                if (fundManagerNode.Attributes["href"] != null || fundManagerNode.Attributes["id"] != null) 
                {
                    if (fundManagerNode.Attributes["id"] != null) 
                    {
                        fundManagerIDRef_ = fundManagerNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(fundManagerNode);
                        IDManager.SetID(fundManagerIDRef_, ob);
                    }
                    else if (fundManagerNode.Attributes["href"] != null)
                    {
                        fundManagerIDRef_ = fundManagerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fundManager_ = new XsdTypeString(fundManagerNode);
                    }
                }
                else
                {
                    fundManager_ = new XsdTypeString(fundManagerNode);
                }
            }
            
        
        }
        
    
        #region OpenEndedFund_
        private XsdTypeBoolean openEndedFund_;
        public XsdTypeBoolean OpenEndedFund_
        {
            get
            {
                if (this.openEndedFund_ != null)
                {
                    return this.openEndedFund_; 
                }
                else if (this.openEndedFundIDRef_ != null)
                {
                    openEndedFund_ = IDManager.getID(openEndedFundIDRef_) as XsdTypeBoolean;
                    return this.openEndedFund_; 
                }
                else
                {
                      return this.openEndedFund_; 
                }
            }
            set
            {
                if (this.openEndedFund_ != value)
                {
                    this.openEndedFund_ = value;
                }
            }
        }
        #endregion
        
        public string openEndedFundIDRef_ { get; set; }
        #region FundManager_
        private XsdTypeString fundManager_;
        public XsdTypeString FundManager_
        {
            get
            {
                if (this.fundManager_ != null)
                {
                    return this.fundManager_; 
                }
                else if (this.fundManagerIDRef_ != null)
                {
                    fundManager_ = IDManager.getID(fundManagerIDRef_) as XsdTypeString;
                    return this.fundManager_; 
                }
                else
                {
                      return this.fundManager_; 
                }
            }
            set
            {
                if (this.fundManager_ != value)
                {
                    this.fundManager_ = value;
                }
            }
        }
        #endregion
        
        public string fundManagerIDRef_ { get; set; }
        
    
        
    
    }
    
}

