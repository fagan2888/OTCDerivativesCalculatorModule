using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestRetransmission
    {
        public RequestRetransmission(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList portfolioReferenceNodeList = xmlNode.SelectNodes("portfolioReference");
            if (portfolioReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in portfolioReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioReferenceIDRef = item.Attributes["id"].Name;
                        PortfolioConstituentReference ob = PortfolioConstituentReference();
                        IDManager.SetID(portfolioReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        portfolioReference = new PortfolioConstituentReference(item);
                    }
                }
            }
            
        
            XmlNodeList reportIdentificationNodeList = xmlNode.SelectNodes("reportIdentification");
            if (reportIdentificationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reportIdentificationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportIdentificationIDRef = item.Attributes["id"].Name;
                        ReportSectionIdentification ob = ReportSectionIdentification();
                        IDManager.SetID(reportIdentificationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportIdentificationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reportIdentification = new ReportSectionIdentification(item);
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            foreach (XmlNode item in partyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIDRef = item.Attributes["id"].Name;
                        List<Party> ob = new List<Party>();
                        ob.Add(new Party(item));
                        IDManager.SetID(partyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    party.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            foreach (XmlNode item in accountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIDRef = item.Attributes["id"].Name;
                        List<Account> ob = new List<Account>();
                        ob.Add(new Account(item));
                        IDManager.SetID(accountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    account.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region PortfolioReference
        private PortfolioConstituentReference portfolioReference;
        public PortfolioConstituentReference PortfolioReference
        {
            get
            {
                if (this.portfolioReference != null)
                {
                    return this.portfolioReference; 
                }
                else if (this.portfolioReferenceIDRef != null)
                {
                    portfolioReference = IDManager.getID(portfolioReferenceIDRef) as PortfolioConstituentReference;
                    return this.portfolioReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.portfolioReference != value)
                {
                    this.portfolioReference = value;
                }
            }
        }
        #endregion
        
        public string PortfolioConstituentReferenceIDRef { get; set; }
        #region ReportIdentification
        private ReportSectionIdentification reportIdentification;
        public ReportSectionIdentification ReportIdentification
        {
            get
            {
                if (this.reportIdentification != null)
                {
                    return this.reportIdentification; 
                }
                else if (this.reportIdentificationIDRef != null)
                {
                    reportIdentification = IDManager.getID(reportIdentificationIDRef) as ReportSectionIdentification;
                    return this.reportIdentification; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportIdentification != value)
                {
                    this.reportIdentification = value;
                }
            }
        }
        #endregion
        
        public string ReportSectionIdentificationIDRef { get; set; }
        #region Party
        private List<Party> party;
        public List<Party> Party
        {
            get
            {
                if (this.party != null)
                {
                    return this.party; 
                }
                else if (this.partyIDRef != null)
                {
                    party = IDManager.getID(partyIDRef) as List<Party>;
                    return this.party; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.party != value)
                {
                    this.party = value;
                }
            }
        }
        #endregion
        
        public string PartyIDRef { get; set; }
        #region Account
        private List<Account> account;
        public List<Account> Account
        {
            get
            {
                if (this.account != null)
                {
                    return this.account; 
                }
                else if (this.accountIDRef != null)
                {
                    account = IDManager.getID(accountIDRef) as List<Account>;
                    return this.account; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.account != value)
                {
                    this.account = value;
                }
            }
        }
        #endregion
        
        public string AccountIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

