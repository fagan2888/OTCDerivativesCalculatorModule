using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyRelationshipDocumentation
    {
        public PartyRelationshipDocumentation(XmlNode xmlNode)
        {
            XmlNodeList masterAgreementNodeList = xmlNode.SelectNodes("masterAgreement");
            if (masterAgreementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementIDRef = item.Attributes["id"].Name;
                        MasterAgreement ob = MasterAgreement();
                        IDManager.SetID(masterAgreementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreement = new MasterAgreement(item);
                    }
                }
            }
            
        
            XmlNodeList creditSupportAgreementNodeList = xmlNode.SelectNodes("creditSupportAgreement");
            if (creditSupportAgreementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditSupportAgreementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditSupportAgreementIDRef = item.Attributes["id"].Name;
                        CreditSupportAgreement ob = CreditSupportAgreement();
                        IDManager.SetID(creditSupportAgreementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditSupportAgreementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditSupportAgreement = new CreditSupportAgreement(item);
                    }
                }
            }
            
        
            XmlNodeList agreementNodeList = xmlNode.SelectNodes("agreement");
            if (agreementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in agreementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        agreementIDRef = item.Attributes["id"].Name;
                        GenericAgreement ob = GenericAgreement();
                        IDManager.SetID(agreementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        agreementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        agreement = new GenericAgreement(item);
                    }
                }
            }
            
        
        }
        
    
        #region MasterAgreement
        private MasterAgreement masterAgreement;
        public MasterAgreement MasterAgreement
        {
            get
            {
                if (this.masterAgreement != null)
                {
                    return this.masterAgreement; 
                }
                else if (this.masterAgreementIDRef != null)
                {
                    masterAgreement = IDManager.getID(masterAgreementIDRef) as MasterAgreement;
                    return this.masterAgreement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreement != value)
                {
                    this.masterAgreement = value;
                }
            }
        }
        #endregion
        
        public string MasterAgreementIDRef { get; set; }
        #region CreditSupportAgreement
        private CreditSupportAgreement creditSupportAgreement;
        public CreditSupportAgreement CreditSupportAgreement
        {
            get
            {
                if (this.creditSupportAgreement != null)
                {
                    return this.creditSupportAgreement; 
                }
                else if (this.creditSupportAgreementIDRef != null)
                {
                    creditSupportAgreement = IDManager.getID(creditSupportAgreementIDRef) as CreditSupportAgreement;
                    return this.creditSupportAgreement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditSupportAgreement != value)
                {
                    this.creditSupportAgreement = value;
                }
            }
        }
        #endregion
        
        public string CreditSupportAgreementIDRef { get; set; }
        #region Agreement
        private GenericAgreement agreement;
        public GenericAgreement Agreement
        {
            get
            {
                if (this.agreement != null)
                {
                    return this.agreement; 
                }
                else if (this.agreementIDRef != null)
                {
                    agreement = IDManager.getID(agreementIDRef) as GenericAgreement;
                    return this.agreement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.agreement != value)
                {
                    this.agreement = value;
                }
            }
        }
        #endregion
        
        public string GenericAgreementIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

