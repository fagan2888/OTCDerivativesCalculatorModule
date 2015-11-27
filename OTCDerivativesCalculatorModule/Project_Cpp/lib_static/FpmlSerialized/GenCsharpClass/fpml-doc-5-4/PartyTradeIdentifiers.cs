using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyTradeIdentifiers
    {
        public PartyTradeIdentifiers(XmlNode xmlNode)
        {
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            foreach (XmlNode item in partyTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(partyTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyTradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyTradeIdentifier
        private List<PartyTradeIdentifier> partyTradeIdentifier;
        public List<PartyTradeIdentifier> PartyTradeIdentifier
        {
            get
            {
                if (this.partyTradeIdentifier != null)
                {
                    return this.partyTradeIdentifier; 
                }
                else if (this.partyTradeIdentifierIDRef != null)
                {
                    partyTradeIdentifier = IDManager.getID(partyTradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.partyTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyTradeIdentifier != value)
                {
                    this.partyTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        
    
        
    
    }
    
}

