using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyMessageInformation : ISerialized
    {
        public PartyMessageInformation(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

