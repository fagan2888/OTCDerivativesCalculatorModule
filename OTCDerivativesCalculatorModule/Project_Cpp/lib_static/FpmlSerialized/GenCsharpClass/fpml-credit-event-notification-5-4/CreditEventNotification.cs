using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditEventNotification
    {
        public CreditEventNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList creditEventNoticeNodeList = xmlNode.SelectNodes("creditEventNotice");
            if (creditEventNoticeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventNoticeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventNoticeIDRef = item.Attributes["id"].Name;
                        CreditEventNoticeDocument ob = CreditEventNoticeDocument();
                        IDManager.SetID(creditEventNoticeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventNoticeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEventNotice = new CreditEventNoticeDocument(item);
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
            
        
        }
        
    
        #region CreditEventNotice
        private CreditEventNoticeDocument creditEventNotice;
        public CreditEventNoticeDocument CreditEventNotice
        {
            get
            {
                if (this.creditEventNotice != null)
                {
                    return this.creditEventNotice; 
                }
                else if (this.creditEventNoticeIDRef != null)
                {
                    creditEventNotice = IDManager.getID(creditEventNoticeIDRef) as CreditEventNoticeDocument;
                    return this.creditEventNotice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEventNotice != value)
                {
                    this.creditEventNotice = value;
                }
            }
        }
        #endregion
        
        public string CreditEventNoticeDocumentIDRef { get; set; }
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
        
    
        
    
    }
    
}

