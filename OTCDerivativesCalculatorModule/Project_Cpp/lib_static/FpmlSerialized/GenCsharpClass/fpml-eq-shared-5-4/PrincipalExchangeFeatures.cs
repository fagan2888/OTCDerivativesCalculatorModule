using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeFeatures
    {
        public PrincipalExchangeFeatures(XmlNode xmlNode)
        {
            XmlNodeList principalExchangesNodeList = xmlNode.SelectNodes("principalExchanges");
            if (principalExchangesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangesIDRef = item.Attributes["id"].Name;
                        PrincipalExchanges ob = PrincipalExchanges();
                        IDManager.SetID(principalExchangesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchanges = new PrincipalExchanges(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeDescriptionsNodeList = xmlNode.SelectNodes("principalExchangeDescriptions");
            
            foreach (XmlNode item in principalExchangeDescriptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeDescriptionsIDRef = item.Attributes["id"].Name;
                        List<PrincipalExchangeDescriptions> ob = new List<PrincipalExchangeDescriptions>();
                        ob.Add(new PrincipalExchangeDescriptions(item));
                        IDManager.SetID(principalExchangeDescriptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeDescriptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    principalExchangeDescriptions.Add(new PrincipalExchangeDescriptions(item));
                    }
                }
            }
            
        
        }
        
    
        #region PrincipalExchanges
        private PrincipalExchanges principalExchanges;
        public PrincipalExchanges PrincipalExchanges
        {
            get
            {
                if (this.principalExchanges != null)
                {
                    return this.principalExchanges; 
                }
                else if (this.principalExchangesIDRef != null)
                {
                    principalExchanges = IDManager.getID(principalExchangesIDRef) as PrincipalExchanges;
                    return this.principalExchanges; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchanges != value)
                {
                    this.principalExchanges = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangesIDRef { get; set; }
        #region PrincipalExchangeDescriptions
        private List<PrincipalExchangeDescriptions> principalExchangeDescriptions;
        public List<PrincipalExchangeDescriptions> PrincipalExchangeDescriptions
        {
            get
            {
                if (this.principalExchangeDescriptions != null)
                {
                    return this.principalExchangeDescriptions; 
                }
                else if (this.principalExchangeDescriptionsIDRef != null)
                {
                    principalExchangeDescriptions = IDManager.getID(principalExchangeDescriptionsIDRef) as List<PrincipalExchangeDescriptions>;
                    return this.principalExchangeDescriptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchangeDescriptions != value)
                {
                    this.principalExchangeDescriptions = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangeDescriptionsIDRef { get; set; }
        
    
        
    
    }
    
}

