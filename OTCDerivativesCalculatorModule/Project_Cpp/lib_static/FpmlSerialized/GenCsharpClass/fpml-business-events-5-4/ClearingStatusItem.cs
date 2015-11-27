using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ClearingStatusItem
    {
        public ClearingStatusItem(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<TradeIdentifier> ob = new List<TradeIdentifier>();
                        ob.Add(new TradeIdentifier(item));
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    tradeIdentifier.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList tradeReferenceInformationNodeList = xmlNode.SelectNodes("tradeReferenceInformation");
            if (tradeReferenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeReferenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef = item.Attributes["id"].Name;
                        TradeReferenceInformation ob = TradeReferenceInformation();
                        IDManager.SetID(tradeReferenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeReferenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeReferenceInformation = new TradeReferenceInformation(item);
                    }
                }
            }
            
        
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            if (tradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(tradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList clearingStatusValueNodeList = xmlNode.SelectNodes("clearingStatusValue");
            if (clearingStatusValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearingStatusValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearingStatusValueIDRef = item.Attributes["id"].Name;
                        ClearingStatusValue ob = ClearingStatusValue();
                        IDManager.SetID(clearingStatusValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearingStatusValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearingStatusValue = new ClearingStatusValue(item);
                    }
                }
            }
            
        
            XmlNodeList updatedDateTimeNodeList = xmlNode.SelectNodes("updatedDateTime");
            if (updatedDateTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in updatedDateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        updatedDateTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(updatedDateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        updatedDateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        updatedDateTime = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            foreach (XmlNode item in reasonNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reasonIDRef = item.Attributes["id"].Name;
                        List<Reason> ob = new List<Reason>();
                        ob.Add(new Reason(item));
                        IDManager.SetID(reasonIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reasonIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reason.Add(new Reason(item));
                    }
                }
            }
            
        
            XmlNodeList statusAppliesToNodeList = xmlNode.SelectNodes("statusAppliesTo");
            
            foreach (XmlNode item in statusAppliesToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        statusAppliesToIDRef = item.Attributes["id"].Name;
                        List<PartyReference> ob = new List<PartyReference>();
                        ob.Add(new PartyReference(item));
                        IDManager.SetID(statusAppliesToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        statusAppliesToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    statusAppliesTo.Add(new PartyReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier
        private List<TradeIdentifier> tradeIdentifier;
        public List<TradeIdentifier> TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as List<TradeIdentifier>;
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
        
        public string TradeIdentifierIDRef { get; set; }
        #region TradeReferenceInformation
        private TradeReferenceInformation tradeReferenceInformation;
        public TradeReferenceInformation TradeReferenceInformation
        {
            get
            {
                if (this.tradeReferenceInformation != null)
                {
                    return this.tradeReferenceInformation; 
                }
                else if (this.tradeReferenceInformationIDRef != null)
                {
                    tradeReferenceInformation = IDManager.getID(tradeReferenceInformationIDRef) as TradeReferenceInformation;
                    return this.tradeReferenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeReferenceInformation != value)
                {
                    this.tradeReferenceInformation = value;
                }
            }
        }
        #endregion
        
        public string TradeReferenceInformationIDRef { get; set; }
        #region Trade
        private Trade trade;
        public Trade Trade
        {
            get
            {
                if (this.trade != null)
                {
                    return this.trade; 
                }
                else if (this.tradeIDRef != null)
                {
                    trade = IDManager.getID(tradeIDRef) as Trade;
                    return this.trade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trade != value)
                {
                    this.trade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region ClearingStatusValue
        private ClearingStatusValue clearingStatusValue;
        public ClearingStatusValue ClearingStatusValue
        {
            get
            {
                if (this.clearingStatusValue != null)
                {
                    return this.clearingStatusValue; 
                }
                else if (this.clearingStatusValueIDRef != null)
                {
                    clearingStatusValue = IDManager.getID(clearingStatusValueIDRef) as ClearingStatusValue;
                    return this.clearingStatusValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearingStatusValue != value)
                {
                    this.clearingStatusValue = value;
                }
            }
        }
        #endregion
        
        public string ClearingStatusValueIDRef { get; set; }
        #region UpdatedDateTime
        private XsdTypeDateTime updatedDateTime;
        public XsdTypeDateTime UpdatedDateTime
        {
            get
            {
                if (this.updatedDateTime != null)
                {
                    return this.updatedDateTime; 
                }
                else if (this.updatedDateTimeIDRef != null)
                {
                    updatedDateTime = IDManager.getID(updatedDateTimeIDRef) as XsdTypeDateTime;
                    return this.updatedDateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.updatedDateTime != value)
                {
                    this.updatedDateTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region Reason
        private List<Reason> reason;
        public List<Reason> Reason
        {
            get
            {
                if (this.reason != null)
                {
                    return this.reason; 
                }
                else if (this.reasonIDRef != null)
                {
                    reason = IDManager.getID(reasonIDRef) as List<Reason>;
                    return this.reason; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reason != value)
                {
                    this.reason = value;
                }
            }
        }
        #endregion
        
        public string ReasonIDRef { get; set; }
        #region StatusAppliesTo
        private List<PartyReference> statusAppliesTo;
        public List<PartyReference> StatusAppliesTo
        {
            get
            {
                if (this.statusAppliesTo != null)
                {
                    return this.statusAppliesTo; 
                }
                else if (this.statusAppliesToIDRef != null)
                {
                    statusAppliesTo = IDManager.getID(statusAppliesToIDRef) as List<PartyReference>;
                    return this.statusAppliesTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.statusAppliesTo != value)
                {
                    this.statusAppliesTo = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

