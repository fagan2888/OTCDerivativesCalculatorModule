using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Withdrawal
    {
        public Withdrawal(XmlNode xmlNode)
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
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList requestedActionNodeList = xmlNode.SelectNodes("requestedAction");
            if (requestedActionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in requestedActionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        requestedActionIDRef = item.Attributes["id"].Name;
                        RequestedWithdrawalAction ob = RequestedWithdrawalAction();
                        IDManager.SetID(requestedActionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        requestedActionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        requestedAction = new RequestedWithdrawalAction(item);
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
                        List<WithdrawalReason> ob = new List<WithdrawalReason>();
                        ob.Add(new WithdrawalReason(item));
                        IDManager.SetID(reasonIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reasonIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reason.Add(new WithdrawalReason(item));
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
        #region EffectiveDate
        private XsdTypeDate effectiveDate;
        public XsdTypeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as XsdTypeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region RequestedAction
        private RequestedWithdrawalAction requestedAction;
        public RequestedWithdrawalAction RequestedAction
        {
            get
            {
                if (this.requestedAction != null)
                {
                    return this.requestedAction; 
                }
                else if (this.requestedActionIDRef != null)
                {
                    requestedAction = IDManager.getID(requestedActionIDRef) as RequestedWithdrawalAction;
                    return this.requestedAction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.requestedAction != value)
                {
                    this.requestedAction = value;
                }
            }
        }
        #endregion
        
        public string RequestedWithdrawalActionIDRef { get; set; }
        #region Reason
        private List<WithdrawalReason> reason;
        public List<WithdrawalReason> Reason
        {
            get
            {
                if (this.reason != null)
                {
                    return this.reason; 
                }
                else if (this.reasonIDRef != null)
                {
                    reason = IDManager.getID(reasonIDRef) as List<WithdrawalReason>;
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
        
        public string WithdrawalReasonIDRef { get; set; }
        
    
        
    
    }
    
}

