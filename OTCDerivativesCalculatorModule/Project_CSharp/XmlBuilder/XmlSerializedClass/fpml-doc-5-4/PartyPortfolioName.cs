using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyPortfolioName : ISerialized
    {
        public PartyPortfolioName(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNodeList portfolioNameNodeList = xmlNode.SelectNodes("portfolioName");
            
            if (portfolioNameNodeList != null)
            {
                this.portfolioName_ = new List<PortfolioName>();
                foreach (XmlNode item in portfolioNameNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            portfolioNameIDRef_ = item.Attributes["id"].Value;
                            portfolioName_.Add(new PortfolioName(item));
                            IDManager.SetID(portfolioNameIDRef_, portfolioName_[portfolioName_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            portfolioNameIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        portfolioName_.Add(new PortfolioName(item));
                        }
                    }
                    else
                    {
                        portfolioName_.Add(new PortfolioName(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region PortfolioName_
        private List<PortfolioName> portfolioName_;
        public List<PortfolioName> PortfolioName_
        {
            get
            {
                if (this.portfolioName_ != null)
                {
                    return this.portfolioName_; 
                }
                else if (this.portfolioNameIDRef_ != null)
                {
                    return this.portfolioName_; 
                }
                else
                {
                      return this.portfolioName_; 
                }
            }
            set
            {
                if (this.portfolioName_ != value)
                {
                    this.portfolioName_ = value;
                }
            }
        }
        #endregion
        
        public string portfolioNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

