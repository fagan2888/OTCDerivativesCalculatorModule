using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DirectionalLeg : Leg
    {
        public DirectionalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList legIdentifierNodeList = xmlNode.SelectNodes("legIdentifier");
            
            if (legIdentifierNodeList != null)
            {
                this.legIdentifier_ = new List<LegIdentifier>();
                foreach (XmlNode item in legIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            legIdentifierIDRef_ = item.Attributes["id"].Value;
                            legIdentifier_.Add(new LegIdentifier(item));
                            IDManager.SetID(legIdentifierIDRef_, legIdentifier_[legIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            legIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        legIdentifier_.Add(new LegIdentifier(item));
                        }
                    }
                    else
                    {
                        legIdentifier_.Add(new LegIdentifier(item));
                    }
                }
            }
            
        
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
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                }
            }
            
        
        }
        
    
        #region LegIdentifier_
        private List<LegIdentifier> legIdentifier_;
        public List<LegIdentifier> LegIdentifier_
        {
            get
            {
                if (this.legIdentifier_ != null)
                {
                    return this.legIdentifier_; 
                }
                else if (this.legIdentifierIDRef_ != null)
                {
                    return this.legIdentifier_; 
                }
                else
                {
                      return this.legIdentifier_; 
                }
            }
            set
            {
                if (this.legIdentifier_ != value)
                {
                    this.legIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string legIdentifierIDRef_ { get; set; }
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
        #region EffectiveDate_
        private AdjustableOrRelativeDate effectiveDate_;
        public AdjustableOrRelativeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableOrRelativeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableOrRelativeDate terminationDate_;
        public AdjustableOrRelativeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

