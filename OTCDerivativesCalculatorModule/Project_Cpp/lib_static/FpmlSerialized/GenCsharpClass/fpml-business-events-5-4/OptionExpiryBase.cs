using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionExpiryBase
    {
        public OptionExpiryBase(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    tradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            if (dateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        date = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList timeNodeList = xmlNode.SelectNodes("time");
            if (timeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timeIDRef = item.Attributes["id"].Name;
                        XsdTypeTime ob = XsdTypeTime();
                        IDManager.SetID(timeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        time = new XsdTypeTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier
        private List<PartyTradeIdentifier> tradeIdentifier;
        public List<PartyTradeIdentifier> TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.tradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifier != value)
                {
                    this.tradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region Date
        private XsdTypeDate date;
        public XsdTypeDate Date
        {
            get
            {
                if (this.date != null)
                {
                    return this.date; 
                }
                else if (this.dateIDRef != null)
                {
                    date = IDManager.getID(dateIDRef) as XsdTypeDate;
                    return this.date; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.date != value)
                {
                    this.date = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Time
        private XsdTypeTime time;
        public XsdTypeTime Time
        {
            get
            {
                if (this.time != null)
                {
                    return this.time; 
                }
                else if (this.timeIDRef != null)
                {
                    time = IDManager.getID(timeIDRef) as XsdTypeTime;
                    return this.time; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.time != value)
                {
                    this.time = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTimeIDRef { get; set; }
        
    
        
    
    }
    
}

