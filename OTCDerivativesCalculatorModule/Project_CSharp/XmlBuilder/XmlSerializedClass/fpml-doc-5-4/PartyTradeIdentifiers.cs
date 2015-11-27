using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyTradeIdentifiers : ISerialized
    {
        public PartyTradeIdentifiers(XmlNode xmlNode)
        {
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            if (partyTradeIdentifierNodeList != null)
            {
                this.partyTradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in partyTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(partyTradeIdentifierIDRef_, partyTradeIdentifier_[partyTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyTradeIdentifier_
        private List<PartyTradeIdentifier> partyTradeIdentifier_;
        public List<PartyTradeIdentifier> PartyTradeIdentifier_
        {
            get
            {
                if (this.partyTradeIdentifier_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else if (this.partyTradeIdentifierIDRef_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else
                {
                      return this.partyTradeIdentifier_; 
                }
            }
            set
            {
                if (this.partyTradeIdentifier_ != value)
                {
                    this.partyTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeIdentifierIDRef_ { get; set; }
        
    
        
    
    }
    
}

