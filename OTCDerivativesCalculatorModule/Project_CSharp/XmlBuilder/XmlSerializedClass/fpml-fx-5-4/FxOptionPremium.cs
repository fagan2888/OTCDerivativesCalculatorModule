using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxOptionPremium : NonNegativePayment
    {
        public FxOptionPremium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode settlementInformationNode = xmlNode.SelectSingleNode("settlementInformation");
            
            if (settlementInformationNode != null)
            {
                if (settlementInformationNode.Attributes["href"] != null || settlementInformationNode.Attributes["id"] != null) 
                {
                    if (settlementInformationNode.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["id"].Value;
                        SettlementInformation ob = new SettlementInformation(settlementInformationNode);
                        IDManager.SetID(settlementInformationIDRef_, ob);
                    }
                    else if (settlementInformationNode.Attributes["href"] != null)
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementInformation_ = new SettlementInformation(settlementInformationNode);
                    }
                }
                else
                {
                    settlementInformation_ = new SettlementInformation(settlementInformationNode);
                }
            }
            
        
            XmlNode quoteNode = xmlNode.SelectSingleNode("quote");
            
            if (quoteNode != null)
            {
                if (quoteNode.Attributes["href"] != null || quoteNode.Attributes["id"] != null) 
                {
                    if (quoteNode.Attributes["id"] != null) 
                    {
                        quoteIDRef_ = quoteNode.Attributes["id"].Value;
                        PremiumQuote ob = new PremiumQuote(quoteNode);
                        IDManager.SetID(quoteIDRef_, ob);
                    }
                    else if (quoteNode.Attributes["href"] != null)
                    {
                        quoteIDRef_ = quoteNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quote_ = new PremiumQuote(quoteNode);
                    }
                }
                else
                {
                    quote_ = new PremiumQuote(quoteNode);
                }
            }
            
        
        }
        
    
        #region SettlementInformation_
        private SettlementInformation settlementInformation_;
        public SettlementInformation SettlementInformation_
        {
            get
            {
                if (this.settlementInformation_ != null)
                {
                    return this.settlementInformation_; 
                }
                else if (this.settlementInformationIDRef_ != null)
                {
                    settlementInformation_ = IDManager.getID(settlementInformationIDRef_) as SettlementInformation;
                    return this.settlementInformation_; 
                }
                else
                {
                      return this.settlementInformation_; 
                }
            }
            set
            {
                if (this.settlementInformation_ != value)
                {
                    this.settlementInformation_ = value;
                }
            }
        }
        #endregion
        
        public string settlementInformationIDRef_ { get; set; }
        #region Quote_
        private PremiumQuote quote_;
        public PremiumQuote Quote_
        {
            get
            {
                if (this.quote_ != null)
                {
                    return this.quote_; 
                }
                else if (this.quoteIDRef_ != null)
                {
                    quote_ = IDManager.getID(quoteIDRef_) as PremiumQuote;
                    return this.quote_; 
                }
                else
                {
                      return this.quote_; 
                }
            }
            set
            {
                if (this.quote_ != value)
                {
                    this.quote_ = value;
                }
            }
        }
        #endregion
        
        public string quoteIDRef_ { get; set; }
        
    
        
    
    }
    
}

