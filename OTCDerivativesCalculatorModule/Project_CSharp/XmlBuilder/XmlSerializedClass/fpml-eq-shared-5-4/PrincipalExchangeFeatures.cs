using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeFeatures : ISerialized
    {
        public PrincipalExchangeFeatures(XmlNode xmlNode)
        {
            XmlNode principalExchangesNode = xmlNode.SelectSingleNode("principalExchanges");
            
            if (principalExchangesNode != null)
            {
                if (principalExchangesNode.Attributes["href"] != null || principalExchangesNode.Attributes["id"] != null) 
                {
                    if (principalExchangesNode.Attributes["id"] != null) 
                    {
                        principalExchangesIDRef_ = principalExchangesNode.Attributes["id"].Value;
                        PrincipalExchanges ob = new PrincipalExchanges(principalExchangesNode);
                        IDManager.SetID(principalExchangesIDRef_, ob);
                    }
                    else if (principalExchangesNode.Attributes["href"] != null)
                    {
                        principalExchangesIDRef_ = principalExchangesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchanges_ = new PrincipalExchanges(principalExchangesNode);
                    }
                }
                else
                {
                    principalExchanges_ = new PrincipalExchanges(principalExchangesNode);
                }
            }
            
        
            XmlNodeList principalExchangeDescriptionsNodeList = xmlNode.SelectNodes("principalExchangeDescriptions");
            
            if (principalExchangeDescriptionsNodeList != null)
            {
                this.principalExchangeDescriptions_ = new List<PrincipalExchangeDescriptions>();
                foreach (XmlNode item in principalExchangeDescriptionsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            principalExchangeDescriptionsIDRef_ = item.Attributes["id"].Value;
                            principalExchangeDescriptions_.Add(new PrincipalExchangeDescriptions(item));
                            IDManager.SetID(principalExchangeDescriptionsIDRef_, principalExchangeDescriptions_[principalExchangeDescriptions_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            principalExchangeDescriptionsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        principalExchangeDescriptions_.Add(new PrincipalExchangeDescriptions(item));
                        }
                    }
                    else
                    {
                        principalExchangeDescriptions_.Add(new PrincipalExchangeDescriptions(item));
                    }
                }
            }
            
        
        }
        
    
        #region PrincipalExchanges_
        private PrincipalExchanges principalExchanges_;
        public PrincipalExchanges PrincipalExchanges_
        {
            get
            {
                if (this.principalExchanges_ != null)
                {
                    return this.principalExchanges_; 
                }
                else if (this.principalExchangesIDRef_ != null)
                {
                    principalExchanges_ = IDManager.getID(principalExchangesIDRef_) as PrincipalExchanges;
                    return this.principalExchanges_; 
                }
                else
                {
                      return this.principalExchanges_; 
                }
            }
            set
            {
                if (this.principalExchanges_ != value)
                {
                    this.principalExchanges_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangesIDRef_ { get; set; }
        #region PrincipalExchangeDescriptions_
        private List<PrincipalExchangeDescriptions> principalExchangeDescriptions_;
        public List<PrincipalExchangeDescriptions> PrincipalExchangeDescriptions_
        {
            get
            {
                if (this.principalExchangeDescriptions_ != null)
                {
                    return this.principalExchangeDescriptions_; 
                }
                else if (this.principalExchangeDescriptionsIDRef_ != null)
                {
                    return this.principalExchangeDescriptions_; 
                }
                else
                {
                      return this.principalExchangeDescriptions_; 
                }
            }
            set
            {
                if (this.principalExchangeDescriptions_ != value)
                {
                    this.principalExchangeDescriptions_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeDescriptionsIDRef_ { get; set; }
        
    
        
    
    }
    
}

