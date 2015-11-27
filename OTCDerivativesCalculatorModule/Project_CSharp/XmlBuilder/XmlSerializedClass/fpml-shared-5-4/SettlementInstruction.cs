using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementInstruction : ISerialized
    {
        public SettlementInstruction(XmlNode xmlNode)
        {
            XmlNode settlementMethodNode = xmlNode.SelectSingleNode("settlementMethod");
            
            if (settlementMethodNode != null)
            {
                if (settlementMethodNode.Attributes["href"] != null || settlementMethodNode.Attributes["id"] != null) 
                {
                    if (settlementMethodNode.Attributes["id"] != null) 
                    {
                        settlementMethodIDRef_ = settlementMethodNode.Attributes["id"].Value;
                        SettlementMethod ob = new SettlementMethod(settlementMethodNode);
                        IDManager.SetID(settlementMethodIDRef_, ob);
                    }
                    else if (settlementMethodNode.Attributes["href"] != null)
                    {
                        settlementMethodIDRef_ = settlementMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementMethod_ = new SettlementMethod(settlementMethodNode);
                    }
                }
                else
                {
                    settlementMethod_ = new SettlementMethod(settlementMethodNode);
                }
            }
            
        
            XmlNode correspondentInformationNode = xmlNode.SelectSingleNode("correspondentInformation");
            
            if (correspondentInformationNode != null)
            {
                if (correspondentInformationNode.Attributes["href"] != null || correspondentInformationNode.Attributes["id"] != null) 
                {
                    if (correspondentInformationNode.Attributes["id"] != null) 
                    {
                        correspondentInformationIDRef_ = correspondentInformationNode.Attributes["id"].Value;
                        CorrespondentInformation ob = new CorrespondentInformation(correspondentInformationNode);
                        IDManager.SetID(correspondentInformationIDRef_, ob);
                    }
                    else if (correspondentInformationNode.Attributes["href"] != null)
                    {
                        correspondentInformationIDRef_ = correspondentInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correspondentInformation_ = new CorrespondentInformation(correspondentInformationNode);
                    }
                }
                else
                {
                    correspondentInformation_ = new CorrespondentInformation(correspondentInformationNode);
                }
            }
            
        
            XmlNodeList intermediaryInformationNodeList = xmlNode.SelectNodes("intermediaryInformation");
            
            if (intermediaryInformationNodeList != null)
            {
                this.intermediaryInformation_ = new List<IntermediaryInformation>();
                foreach (XmlNode item in intermediaryInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            intermediaryInformationIDRef_ = item.Attributes["id"].Value;
                            intermediaryInformation_.Add(new IntermediaryInformation(item));
                            IDManager.SetID(intermediaryInformationIDRef_, intermediaryInformation_[intermediaryInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            intermediaryInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        intermediaryInformation_.Add(new IntermediaryInformation(item));
                        }
                    }
                    else
                    {
                        intermediaryInformation_.Add(new IntermediaryInformation(item));
                    }
                }
            }
            
        
            XmlNode beneficiaryBankNode = xmlNode.SelectSingleNode("beneficiaryBank");
            
            if (beneficiaryBankNode != null)
            {
                if (beneficiaryBankNode.Attributes["href"] != null || beneficiaryBankNode.Attributes["id"] != null) 
                {
                    if (beneficiaryBankNode.Attributes["id"] != null) 
                    {
                        beneficiaryBankIDRef_ = beneficiaryBankNode.Attributes["id"].Value;
                        Beneficiary ob = new Beneficiary(beneficiaryBankNode);
                        IDManager.SetID(beneficiaryBankIDRef_, ob);
                    }
                    else if (beneficiaryBankNode.Attributes["href"] != null)
                    {
                        beneficiaryBankIDRef_ = beneficiaryBankNode.Attributes["href"].Value;
                    }
                    else
                    {
                        beneficiaryBank_ = new Beneficiary(beneficiaryBankNode);
                    }
                }
                else
                {
                    beneficiaryBank_ = new Beneficiary(beneficiaryBankNode);
                }
            }
            
        
            XmlNode beneficiaryNode = xmlNode.SelectSingleNode("beneficiary");
            
            if (beneficiaryNode != null)
            {
                if (beneficiaryNode.Attributes["href"] != null || beneficiaryNode.Attributes["id"] != null) 
                {
                    if (beneficiaryNode.Attributes["id"] != null) 
                    {
                        beneficiaryIDRef_ = beneficiaryNode.Attributes["id"].Value;
                        Beneficiary ob = new Beneficiary(beneficiaryNode);
                        IDManager.SetID(beneficiaryIDRef_, ob);
                    }
                    else if (beneficiaryNode.Attributes["href"] != null)
                    {
                        beneficiaryIDRef_ = beneficiaryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        beneficiary_ = new Beneficiary(beneficiaryNode);
                    }
                }
                else
                {
                    beneficiary_ = new Beneficiary(beneficiaryNode);
                }
            }
            
        
            XmlNode depositoryPartyReferenceNode = xmlNode.SelectSingleNode("depositoryPartyReference");
            
            if (depositoryPartyReferenceNode != null)
            {
                if (depositoryPartyReferenceNode.Attributes["href"] != null || depositoryPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (depositoryPartyReferenceNode.Attributes["id"] != null) 
                    {
                        depositoryPartyReferenceIDRef_ = depositoryPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(depositoryPartyReferenceNode);
                        IDManager.SetID(depositoryPartyReferenceIDRef_, ob);
                    }
                    else if (depositoryPartyReferenceNode.Attributes["href"] != null)
                    {
                        depositoryPartyReferenceIDRef_ = depositoryPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        depositoryPartyReference_ = new PartyReference(depositoryPartyReferenceNode);
                    }
                }
                else
                {
                    depositoryPartyReference_ = new PartyReference(depositoryPartyReferenceNode);
                }
            }
            
        
            XmlNodeList splitSettlementNodeList = xmlNode.SelectNodes("splitSettlement");
            
            if (splitSettlementNodeList != null)
            {
                this.splitSettlement_ = new List<SplitSettlement>();
                foreach (XmlNode item in splitSettlementNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            splitSettlementIDRef_ = item.Attributes["id"].Value;
                            splitSettlement_.Add(new SplitSettlement(item));
                            IDManager.SetID(splitSettlementIDRef_, splitSettlement_[splitSettlement_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            splitSettlementIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        splitSettlement_.Add(new SplitSettlement(item));
                        }
                    }
                    else
                    {
                        splitSettlement_.Add(new SplitSettlement(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementMethod_
        private SettlementMethod settlementMethod_;
        public SettlementMethod SettlementMethod_
        {
            get
            {
                if (this.settlementMethod_ != null)
                {
                    return this.settlementMethod_; 
                }
                else if (this.settlementMethodIDRef_ != null)
                {
                    settlementMethod_ = IDManager.getID(settlementMethodIDRef_) as SettlementMethod;
                    return this.settlementMethod_; 
                }
                else
                {
                      return this.settlementMethod_; 
                }
            }
            set
            {
                if (this.settlementMethod_ != value)
                {
                    this.settlementMethod_ = value;
                }
            }
        }
        #endregion
        
        public string settlementMethodIDRef_ { get; set; }
        #region CorrespondentInformation_
        private CorrespondentInformation correspondentInformation_;
        public CorrespondentInformation CorrespondentInformation_
        {
            get
            {
                if (this.correspondentInformation_ != null)
                {
                    return this.correspondentInformation_; 
                }
                else if (this.correspondentInformationIDRef_ != null)
                {
                    correspondentInformation_ = IDManager.getID(correspondentInformationIDRef_) as CorrespondentInformation;
                    return this.correspondentInformation_; 
                }
                else
                {
                      return this.correspondentInformation_; 
                }
            }
            set
            {
                if (this.correspondentInformation_ != value)
                {
                    this.correspondentInformation_ = value;
                }
            }
        }
        #endregion
        
        public string correspondentInformationIDRef_ { get; set; }
        #region IntermediaryInformation_
        private List<IntermediaryInformation> intermediaryInformation_;
        public List<IntermediaryInformation> IntermediaryInformation_
        {
            get
            {
                if (this.intermediaryInformation_ != null)
                {
                    return this.intermediaryInformation_; 
                }
                else if (this.intermediaryInformationIDRef_ != null)
                {
                    return this.intermediaryInformation_; 
                }
                else
                {
                      return this.intermediaryInformation_; 
                }
            }
            set
            {
                if (this.intermediaryInformation_ != value)
                {
                    this.intermediaryInformation_ = value;
                }
            }
        }
        #endregion
        
        public string intermediaryInformationIDRef_ { get; set; }
        #region BeneficiaryBank_
        private Beneficiary beneficiaryBank_;
        public Beneficiary BeneficiaryBank_
        {
            get
            {
                if (this.beneficiaryBank_ != null)
                {
                    return this.beneficiaryBank_; 
                }
                else if (this.beneficiaryBankIDRef_ != null)
                {
                    beneficiaryBank_ = IDManager.getID(beneficiaryBankIDRef_) as Beneficiary;
                    return this.beneficiaryBank_; 
                }
                else
                {
                      return this.beneficiaryBank_; 
                }
            }
            set
            {
                if (this.beneficiaryBank_ != value)
                {
                    this.beneficiaryBank_ = value;
                }
            }
        }
        #endregion
        
        public string beneficiaryBankIDRef_ { get; set; }
        #region Beneficiary_
        private Beneficiary beneficiary_;
        public Beneficiary Beneficiary_
        {
            get
            {
                if (this.beneficiary_ != null)
                {
                    return this.beneficiary_; 
                }
                else if (this.beneficiaryIDRef_ != null)
                {
                    beneficiary_ = IDManager.getID(beneficiaryIDRef_) as Beneficiary;
                    return this.beneficiary_; 
                }
                else
                {
                      return this.beneficiary_; 
                }
            }
            set
            {
                if (this.beneficiary_ != value)
                {
                    this.beneficiary_ = value;
                }
            }
        }
        #endregion
        
        public string beneficiaryIDRef_ { get; set; }
        #region DepositoryPartyReference_
        private PartyReference depositoryPartyReference_;
        public PartyReference DepositoryPartyReference_
        {
            get
            {
                if (this.depositoryPartyReference_ != null)
                {
                    return this.depositoryPartyReference_; 
                }
                else if (this.depositoryPartyReferenceIDRef_ != null)
                {
                    depositoryPartyReference_ = IDManager.getID(depositoryPartyReferenceIDRef_) as PartyReference;
                    return this.depositoryPartyReference_; 
                }
                else
                {
                      return this.depositoryPartyReference_; 
                }
            }
            set
            {
                if (this.depositoryPartyReference_ != value)
                {
                    this.depositoryPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string depositoryPartyReferenceIDRef_ { get; set; }
        #region SplitSettlement_
        private List<SplitSettlement> splitSettlement_;
        public List<SplitSettlement> SplitSettlement_
        {
            get
            {
                if (this.splitSettlement_ != null)
                {
                    return this.splitSettlement_; 
                }
                else if (this.splitSettlementIDRef_ != null)
                {
                    return this.splitSettlement_; 
                }
                else
                {
                      return this.splitSettlement_; 
                }
            }
            set
            {
                if (this.splitSettlement_ != value)
                {
                    this.splitSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string splitSettlementIDRef_ { get; set; }
        
    
        
    
    }
    
}

