using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PortfolioReferenceBase : ISerialized
    {
        public PortfolioReferenceBase(XmlNode xmlNode)
        {
            XmlNode portfolioNameNode = xmlNode.SelectSingleNode("portfolioName");
            
            if (portfolioNameNode != null)
            {
                if (portfolioNameNode.Attributes["href"] != null || portfolioNameNode.Attributes["id"] != null) 
                {
                    if (portfolioNameNode.Attributes["id"] != null) 
                    {
                        portfolioNameIDRef_ = portfolioNameNode.Attributes["id"].Value;
                        PortfolioName ob = new PortfolioName(portfolioNameNode);
                        IDManager.SetID(portfolioNameIDRef_, ob);
                    }
                    else if (portfolioNameNode.Attributes["href"] != null)
                    {
                        portfolioNameIDRef_ = portfolioNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        portfolioName_ = new PortfolioName(portfolioNameNode);
                    }
                }
                else
                {
                    portfolioName_ = new PortfolioName(portfolioNameNode);
                }
            }
            
        
        }
        
    
        #region PortfolioName_
        private PortfolioName portfolioName_;
        public PortfolioName PortfolioName_
        {
            get
            {
                if (this.portfolioName_ != null)
                {
                    return this.portfolioName_; 
                }
                else if (this.portfolioNameIDRef_ != null)
                {
                    portfolioName_ = IDManager.getID(portfolioNameIDRef_) as PortfolioName;
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

