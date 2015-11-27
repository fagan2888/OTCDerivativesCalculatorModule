using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PortfolioReferenceBase
    {
        public PortfolioReferenceBase(XmlNode xmlNode)
        {
            XmlNodeList portfolioNameNodeList = xmlNode.SelectNodes("portfolioName");
            if (portfolioNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in portfolioNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioNameIDRef = item.Attributes["id"].Name;
                        PortfolioName ob = PortfolioName();
                        IDManager.SetID(portfolioNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        portfolioName = new PortfolioName(item);
                    }
                }
            }
            
        
        }
        
    
        #region PortfolioName
        private PortfolioName portfolioName;
        public PortfolioName PortfolioName
        {
            get
            {
                if (this.portfolioName != null)
                {
                    return this.portfolioName; 
                }
                else if (this.portfolioNameIDRef != null)
                {
                    portfolioName = IDManager.getID(portfolioNameIDRef) as PortfolioName;
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

