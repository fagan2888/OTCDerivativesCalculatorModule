using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RequestRetransmission : NonCorrectableRequestMessage
    {
        public RequestRetransmission(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode portfolioReferenceNode = xmlNode.SelectSingleNode("portfolioReference");
            
            if (portfolioReferenceNode != null)
            {
                if (portfolioReferenceNode.Attributes["href"] != null || portfolioReferenceNode.Attributes["id"] != null) 
                {
                    if (portfolioReferenceNode.Attributes["id"] != null) 
                    {
                        portfolioReferenceIDRef_ = portfolioReferenceNode.Attributes["id"].Value;
                        PortfolioConstituentReference ob = new PortfolioConstituentReference(portfolioReferenceNode);
                        IDManager.SetID(portfolioReferenceIDRef_, ob);
                    }
                    else if (portfolioReferenceNode.Attributes["href"] != null)
                    {
                        portfolioReferenceIDRef_ = portfolioReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        portfolioReference_ = new PortfolioConstituentReference(portfolioReferenceNode);
                    }
                }
                else
                {
                    portfolioReference_ = new PortfolioConstituentReference(portfolioReferenceNode);
                }
            }
            
        
            XmlNode reportIdentificationNode = xmlNode.SelectSingleNode("reportIdentification");
            
            if (reportIdentificationNode != null)
            {
                if (reportIdentificationNode.Attributes["href"] != null || reportIdentificationNode.Attributes["id"] != null) 
                {
                    if (reportIdentificationNode.Attributes["id"] != null) 
                    {
                        reportIdentificationIDRef_ = reportIdentificationNode.Attributes["id"].Value;
                        ReportSectionIdentification ob = new ReportSectionIdentification(reportIdentificationNode);
                        IDManager.SetID(reportIdentificationIDRef_, ob);
                    }
                    else if (reportIdentificationNode.Attributes["href"] != null)
                    {
                        reportIdentificationIDRef_ = reportIdentificationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reportIdentification_ = new ReportSectionIdentification(reportIdentificationNode);
                    }
                }
                else
                {
                    reportIdentification_ = new ReportSectionIdentification(reportIdentificationNode);
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region PortfolioReference_
        private PortfolioConstituentReference portfolioReference_;
        public PortfolioConstituentReference PortfolioReference_
        {
            get
            {
                if (this.portfolioReference_ != null)
                {
                    return this.portfolioReference_; 
                }
                else if (this.portfolioReferenceIDRef_ != null)
                {
                    portfolioReference_ = IDManager.getID(portfolioReferenceIDRef_) as PortfolioConstituentReference;
                    return this.portfolioReference_; 
                }
                else
                {
                      return this.portfolioReference_; 
                }
            }
            set
            {
                if (this.portfolioReference_ != value)
                {
                    this.portfolioReference_ = value;
                }
            }
        }
        #endregion
        
        public string portfolioReferenceIDRef_ { get; set; }
        #region ReportIdentification_
        private ReportSectionIdentification reportIdentification_;
        public ReportSectionIdentification ReportIdentification_
        {
            get
            {
                if (this.reportIdentification_ != null)
                {
                    return this.reportIdentification_; 
                }
                else if (this.reportIdentificationIDRef_ != null)
                {
                    reportIdentification_ = IDManager.getID(reportIdentificationIDRef_) as ReportSectionIdentification;
                    return this.reportIdentification_; 
                }
                else
                {
                      return this.reportIdentification_; 
                }
            }
            set
            {
                if (this.reportIdentification_ != value)
                {
                    this.reportIdentification_ = value;
                }
            }
        }
        #endregion
        
        public string reportIdentificationIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

