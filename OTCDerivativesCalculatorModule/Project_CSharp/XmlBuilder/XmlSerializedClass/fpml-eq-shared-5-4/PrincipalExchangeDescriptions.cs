using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeDescriptions : ISerialized
    {
        public PrincipalExchangeDescriptions(XmlNode xmlNode)
        {
            XmlNode payerPartyReferenceNode = xmlNode.SelectSingleNode("payerPartyReference");
            
            if (payerPartyReferenceNode != null)
            {
                if (payerPartyReferenceNode.Attributes["href"] != null || payerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (payerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(payerPartyReferenceNode);
                        IDManager.SetID(payerPartyReferenceIDRef_, ob);
                    }
                    else if (payerPartyReferenceNode.Attributes["href"] != null)
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                    }
                }
                else
                {
                    payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                }
            }
            
        
            XmlNode payerAccountReferenceNode = xmlNode.SelectSingleNode("payerAccountReference");
            
            if (payerAccountReferenceNode != null)
            {
                if (payerAccountReferenceNode.Attributes["href"] != null || payerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (payerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(payerAccountReferenceNode);
                        IDManager.SetID(payerAccountReferenceIDRef_, ob);
                    }
                    else if (payerAccountReferenceNode.Attributes["href"] != null)
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                    }
                }
                else
                {
                    payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                }
            }
            
        
            XmlNode receiverPartyReferenceNode = xmlNode.SelectSingleNode("receiverPartyReference");
            
            if (receiverPartyReferenceNode != null)
            {
                if (receiverPartyReferenceNode.Attributes["href"] != null || receiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(receiverPartyReferenceNode);
                        IDManager.SetID(receiverPartyReferenceIDRef_, ob);
                    }
                    else if (receiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                    }
                }
                else
                {
                    receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                }
            }
            
        
            XmlNode receiverAccountReferenceNode = xmlNode.SelectSingleNode("receiverAccountReference");
            
            if (receiverAccountReferenceNode != null)
            {
                if (receiverAccountReferenceNode.Attributes["href"] != null || receiverAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverAccountReferenceNode.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(receiverAccountReferenceNode);
                        IDManager.SetID(receiverAccountReferenceIDRef_, ob);
                    }
                    else if (receiverAccountReferenceNode.Attributes["href"] != null)
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                    }
                }
                else
                {
                    receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                }
            }
            
        
            XmlNode principalExchangeAmountNode = xmlNode.SelectSingleNode("principalExchangeAmount");
            
            if (principalExchangeAmountNode != null)
            {
                if (principalExchangeAmountNode.Attributes["href"] != null || principalExchangeAmountNode.Attributes["id"] != null) 
                {
                    if (principalExchangeAmountNode.Attributes["id"] != null) 
                    {
                        principalExchangeAmountIDRef_ = principalExchangeAmountNode.Attributes["id"].Value;
                        PrincipalExchangeAmount ob = new PrincipalExchangeAmount(principalExchangeAmountNode);
                        IDManager.SetID(principalExchangeAmountIDRef_, ob);
                    }
                    else if (principalExchangeAmountNode.Attributes["href"] != null)
                    {
                        principalExchangeAmountIDRef_ = principalExchangeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchangeAmount_ = new PrincipalExchangeAmount(principalExchangeAmountNode);
                    }
                }
                else
                {
                    principalExchangeAmount_ = new PrincipalExchangeAmount(principalExchangeAmountNode);
                }
            }
            
        
            XmlNode principalExchangeDateNode = xmlNode.SelectSingleNode("principalExchangeDate");
            
            if (principalExchangeDateNode != null)
            {
                if (principalExchangeDateNode.Attributes["href"] != null || principalExchangeDateNode.Attributes["id"] != null) 
                {
                    if (principalExchangeDateNode.Attributes["id"] != null) 
                    {
                        principalExchangeDateIDRef_ = principalExchangeDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(principalExchangeDateNode);
                        IDManager.SetID(principalExchangeDateIDRef_, ob);
                    }
                    else if (principalExchangeDateNode.Attributes["href"] != null)
                    {
                        principalExchangeDateIDRef_ = principalExchangeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchangeDate_ = new AdjustableOrRelativeDate(principalExchangeDateNode);
                    }
                }
                else
                {
                    principalExchangeDate_ = new AdjustableOrRelativeDate(principalExchangeDateNode);
                }
            }
            
        
        }
        
    
        #region PayerPartyReference_
        private PartyReference payerPartyReference_;
        public PartyReference PayerPartyReference_
        {
            get
            {
                if (this.payerPartyReference_ != null)
                {
                    return this.payerPartyReference_; 
                }
                else if (this.payerPartyReferenceIDRef_ != null)
                {
                    payerPartyReference_ = IDManager.getID(payerPartyReferenceIDRef_) as PartyReference;
                    return this.payerPartyReference_; 
                }
                else
                {
                      return this.payerPartyReference_; 
                }
            }
            set
            {
                if (this.payerPartyReference_ != value)
                {
                    this.payerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerPartyReferenceIDRef_ { get; set; }
        #region PayerAccountReference_
        private AccountReference payerAccountReference_;
        public AccountReference PayerAccountReference_
        {
            get
            {
                if (this.payerAccountReference_ != null)
                {
                    return this.payerAccountReference_; 
                }
                else if (this.payerAccountReferenceIDRef_ != null)
                {
                    payerAccountReference_ = IDManager.getID(payerAccountReferenceIDRef_) as AccountReference;
                    return this.payerAccountReference_; 
                }
                else
                {
                      return this.payerAccountReference_; 
                }
            }
            set
            {
                if (this.payerAccountReference_ != value)
                {
                    this.payerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerAccountReferenceIDRef_ { get; set; }
        #region ReceiverPartyReference_
        private PartyReference receiverPartyReference_;
        public PartyReference ReceiverPartyReference_
        {
            get
            {
                if (this.receiverPartyReference_ != null)
                {
                    return this.receiverPartyReference_; 
                }
                else if (this.receiverPartyReferenceIDRef_ != null)
                {
                    receiverPartyReference_ = IDManager.getID(receiverPartyReferenceIDRef_) as PartyReference;
                    return this.receiverPartyReference_; 
                }
                else
                {
                      return this.receiverPartyReference_; 
                }
            }
            set
            {
                if (this.receiverPartyReference_ != value)
                {
                    this.receiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverPartyReferenceIDRef_ { get; set; }
        #region ReceiverAccountReference_
        private AccountReference receiverAccountReference_;
        public AccountReference ReceiverAccountReference_
        {
            get
            {
                if (this.receiverAccountReference_ != null)
                {
                    return this.receiverAccountReference_; 
                }
                else if (this.receiverAccountReferenceIDRef_ != null)
                {
                    receiverAccountReference_ = IDManager.getID(receiverAccountReferenceIDRef_) as AccountReference;
                    return this.receiverAccountReference_; 
                }
                else
                {
                      return this.receiverAccountReference_; 
                }
            }
            set
            {
                if (this.receiverAccountReference_ != value)
                {
                    this.receiverAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverAccountReferenceIDRef_ { get; set; }
        #region PrincipalExchangeAmount_
        private PrincipalExchangeAmount principalExchangeAmount_;
        public PrincipalExchangeAmount PrincipalExchangeAmount_
        {
            get
            {
                if (this.principalExchangeAmount_ != null)
                {
                    return this.principalExchangeAmount_; 
                }
                else if (this.principalExchangeAmountIDRef_ != null)
                {
                    principalExchangeAmount_ = IDManager.getID(principalExchangeAmountIDRef_) as PrincipalExchangeAmount;
                    return this.principalExchangeAmount_; 
                }
                else
                {
                      return this.principalExchangeAmount_; 
                }
            }
            set
            {
                if (this.principalExchangeAmount_ != value)
                {
                    this.principalExchangeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeAmountIDRef_ { get; set; }
        #region PrincipalExchangeDate_
        private AdjustableOrRelativeDate principalExchangeDate_;
        public AdjustableOrRelativeDate PrincipalExchangeDate_
        {
            get
            {
                if (this.principalExchangeDate_ != null)
                {
                    return this.principalExchangeDate_; 
                }
                else if (this.principalExchangeDateIDRef_ != null)
                {
                    principalExchangeDate_ = IDManager.getID(principalExchangeDateIDRef_) as AdjustableOrRelativeDate;
                    return this.principalExchangeDate_; 
                }
                else
                {
                      return this.principalExchangeDate_; 
                }
            }
            set
            {
                if (this.principalExchangeDate_ != value)
                {
                    this.principalExchangeDate_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

