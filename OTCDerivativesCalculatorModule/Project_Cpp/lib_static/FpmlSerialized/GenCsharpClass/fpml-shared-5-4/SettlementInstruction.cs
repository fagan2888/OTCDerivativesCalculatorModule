using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementInstruction
    {
        public SettlementInstruction(XmlNode xmlNode)
        {
            XmlNodeList settlementMethodNodeList = xmlNode.SelectNodes("settlementMethod");
            if (settlementMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementMethodIDRef = item.Attributes["id"].Name;
                        SettlementMethod ob = SettlementMethod();
                        IDManager.SetID(settlementMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementMethod = new SettlementMethod(item);
                    }
                }
            }
            
        
            XmlNodeList correspondentInformationNodeList = xmlNode.SelectNodes("correspondentInformation");
            if (correspondentInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correspondentInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correspondentInformationIDRef = item.Attributes["id"].Name;
                        CorrespondentInformation ob = CorrespondentInformation();
                        IDManager.SetID(correspondentInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correspondentInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correspondentInformation = new CorrespondentInformation(item);
                    }
                }
            }
            
        
            XmlNodeList intermediaryInformationNodeList = xmlNode.SelectNodes("intermediaryInformation");
            
            foreach (XmlNode item in intermediaryInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intermediaryInformationIDRef = item.Attributes["id"].Name;
                        List<IntermediaryInformation> ob = new List<IntermediaryInformation>();
                        ob.Add(new IntermediaryInformation(item));
                        IDManager.SetID(intermediaryInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intermediaryInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    intermediaryInformation.Add(new IntermediaryInformation(item));
                    }
                }
            }
            
        
            XmlNodeList beneficiaryBankNodeList = xmlNode.SelectNodes("beneficiaryBank");
            if (beneficiaryBankNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in beneficiaryBankNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        beneficiaryBankIDRef = item.Attributes["id"].Name;
                        Beneficiary ob = Beneficiary();
                        IDManager.SetID(beneficiaryBankIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        beneficiaryBankIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        beneficiaryBank = new Beneficiary(item);
                    }
                }
            }
            
        
            XmlNodeList beneficiaryNodeList = xmlNode.SelectNodes("beneficiary");
            if (beneficiaryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in beneficiaryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        beneficiaryIDRef = item.Attributes["id"].Name;
                        Beneficiary ob = Beneficiary();
                        IDManager.SetID(beneficiaryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        beneficiaryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        beneficiary = new Beneficiary(item);
                    }
                }
            }
            
        
            XmlNodeList depositoryPartyReferenceNodeList = xmlNode.SelectNodes("depositoryPartyReference");
            if (depositoryPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in depositoryPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        depositoryPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(depositoryPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        depositoryPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        depositoryPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList splitSettlementNodeList = xmlNode.SelectNodes("splitSettlement");
            
            foreach (XmlNode item in splitSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        splitSettlementIDRef = item.Attributes["id"].Name;
                        List<SplitSettlement> ob = new List<SplitSettlement>();
                        ob.Add(new SplitSettlement(item));
                        IDManager.SetID(splitSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        splitSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    splitSettlement.Add(new SplitSettlement(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementMethod
        private SettlementMethod settlementMethod;
        public SettlementMethod SettlementMethod
        {
            get
            {
                if (this.settlementMethod != null)
                {
                    return this.settlementMethod; 
                }
                else if (this.settlementMethodIDRef != null)
                {
                    settlementMethod = IDManager.getID(settlementMethodIDRef) as SettlementMethod;
                    return this.settlementMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementMethod != value)
                {
                    this.settlementMethod = value;
                }
            }
        }
        #endregion
        
        public string SettlementMethodIDRef { get; set; }
        #region CorrespondentInformation
        private CorrespondentInformation correspondentInformation;
        public CorrespondentInformation CorrespondentInformation
        {
            get
            {
                if (this.correspondentInformation != null)
                {
                    return this.correspondentInformation; 
                }
                else if (this.correspondentInformationIDRef != null)
                {
                    correspondentInformation = IDManager.getID(correspondentInformationIDRef) as CorrespondentInformation;
                    return this.correspondentInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correspondentInformation != value)
                {
                    this.correspondentInformation = value;
                }
            }
        }
        #endregion
        
        public string CorrespondentInformationIDRef { get; set; }
        #region IntermediaryInformation
        private List<IntermediaryInformation> intermediaryInformation;
        public List<IntermediaryInformation> IntermediaryInformation
        {
            get
            {
                if (this.intermediaryInformation != null)
                {
                    return this.intermediaryInformation; 
                }
                else if (this.intermediaryInformationIDRef != null)
                {
                    intermediaryInformation = IDManager.getID(intermediaryInformationIDRef) as List<IntermediaryInformation>;
                    return this.intermediaryInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intermediaryInformation != value)
                {
                    this.intermediaryInformation = value;
                }
            }
        }
        #endregion
        
        public string IntermediaryInformationIDRef { get; set; }
        #region BeneficiaryBank
        private Beneficiary beneficiaryBank;
        public Beneficiary BeneficiaryBank
        {
            get
            {
                if (this.beneficiaryBank != null)
                {
                    return this.beneficiaryBank; 
                }
                else if (this.beneficiaryBankIDRef != null)
                {
                    beneficiaryBank = IDManager.getID(beneficiaryBankIDRef) as Beneficiary;
                    return this.beneficiaryBank; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.beneficiaryBank != value)
                {
                    this.beneficiaryBank = value;
                }
            }
        }
        #endregion
        
        public string BeneficiaryIDRef { get; set; }
        #region Beneficiary
        private Beneficiary beneficiary;
        public Beneficiary Beneficiary
        {
            get
            {
                if (this.beneficiary != null)
                {
                    return this.beneficiary; 
                }
                else if (this.beneficiaryIDRef != null)
                {
                    beneficiary = IDManager.getID(beneficiaryIDRef) as Beneficiary;
                    return this.beneficiary; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.beneficiary != value)
                {
                    this.beneficiary = value;
                }
            }
        }
        #endregion
        
        public string BeneficiaryIDRef { get; set; }
        #region DepositoryPartyReference
        private PartyReference depositoryPartyReference;
        public PartyReference DepositoryPartyReference
        {
            get
            {
                if (this.depositoryPartyReference != null)
                {
                    return this.depositoryPartyReference; 
                }
                else if (this.depositoryPartyReferenceIDRef != null)
                {
                    depositoryPartyReference = IDManager.getID(depositoryPartyReferenceIDRef) as PartyReference;
                    return this.depositoryPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.depositoryPartyReference != value)
                {
                    this.depositoryPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SplitSettlement
        private List<SplitSettlement> splitSettlement;
        public List<SplitSettlement> SplitSettlement
        {
            get
            {
                if (this.splitSettlement != null)
                {
                    return this.splitSettlement; 
                }
                else if (this.splitSettlementIDRef != null)
                {
                    splitSettlement = IDManager.getID(splitSettlementIDRef) as List<SplitSettlement>;
                    return this.splitSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.splitSettlement != value)
                {
                    this.splitSettlement = value;
                }
            }
        }
        #endregion
        
        public string SplitSettlementIDRef { get; set; }
        
    
        
    
    }
    
}

