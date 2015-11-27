using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyPortfolioName
    {
        public PartyPortfolioName(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList portfolioNameNodeList = xmlNode.SelectNodes("portfolioName");
            
            foreach (XmlNode item in portfolioNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioNameIDRef = item.Attributes["id"].Name;
                        List<PortfolioName> ob = new List<PortfolioName>();
                        ob.Add(new PortfolioName(item));
                        IDManager.SetID(portfolioNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    portfolioName.Add(new PortfolioName(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PortfolioName
        private List<PortfolioName> portfolioName;
        public List<PortfolioName> PortfolioName
        {
            get
            {
                if (this.portfolioName != null)
                {
                    return this.portfolioName; 
                }
                else if (this.portfolioNameIDRef != null)
                {
                    portfolioName = IDManager.getID(portfolioNameIDRef) as List<PortfolioName>;
                    return this.portfolioName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.portfolioName != value)
                {
                    this.portfolioName = value;
                }
            }
        }
        #endregion
        
        public string PortfolioNameIDRef { get; set; }
        
    
        
    
    }
    
}

