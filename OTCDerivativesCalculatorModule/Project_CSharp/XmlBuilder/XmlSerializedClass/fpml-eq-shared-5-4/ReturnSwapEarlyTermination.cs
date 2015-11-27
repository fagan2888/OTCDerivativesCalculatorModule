using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapEarlyTermination : ISerialized
    {
        public ReturnSwapEarlyTermination(XmlNode xmlNode)
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
            
        
            XmlNode startingDateNode = xmlNode.SelectSingleNode("startingDate");
            
            if (startingDateNode != null)
            {
                if (startingDateNode.Attributes["href"] != null || startingDateNode.Attributes["id"] != null) 
                {
                    if (startingDateNode.Attributes["id"] != null) 
                    {
                        startingDateIDRef_ = startingDateNode.Attributes["id"].Value;
                        StartingDate ob = new StartingDate(startingDateNode);
                        IDManager.SetID(startingDateIDRef_, ob);
                    }
                    else if (startingDateNode.Attributes["href"] != null)
                    {
                        startingDateIDRef_ = startingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        startingDate_ = new StartingDate(startingDateNode);
                    }
                }
                else
                {
                    startingDate_ = new StartingDate(startingDateNode);
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
        #region StartingDate_
        private StartingDate startingDate_;
        public StartingDate StartingDate_
        {
            get
            {
                if (this.startingDate_ != null)
                {
                    return this.startingDate_; 
                }
                else if (this.startingDateIDRef_ != null)
                {
                    startingDate_ = IDManager.getID(startingDateIDRef_) as StartingDate;
                    return this.startingDate_; 
                }
                else
                {
                      return this.startingDate_; 
                }
            }
            set
            {
                if (this.startingDate_ != value)
                {
                    this.startingDate_ = value;
                }
            }
        }
        #endregion
        
        public string startingDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

