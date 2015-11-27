using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapEarlyTermination
    {
        public ReturnSwapEarlyTermination(XmlNode xmlNode)
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
            
        
            XmlNodeList startingDateNodeList = xmlNode.SelectNodes("startingDate");
            if (startingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startingDateIDRef = item.Attributes["id"].Name;
                        StartingDate ob = StartingDate();
                        IDManager.SetID(startingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startingDate = new StartingDate(item);
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
        #region StartingDate
        private StartingDate startingDate;
        public StartingDate StartingDate
        {
            get
            {
                if (this.startingDate != null)
                {
                    return this.startingDate; 
                }
                else if (this.startingDateIDRef != null)
                {
                    startingDate = IDManager.getID(startingDateIDRef) as StartingDate;
                    return this.startingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startingDate != value)
                {
                    this.startingDate = value;
                }
            }
        }
        #endregion
        
        public string StartingDateIDRef { get; set; }
        
    
        
    
    }
    
}

