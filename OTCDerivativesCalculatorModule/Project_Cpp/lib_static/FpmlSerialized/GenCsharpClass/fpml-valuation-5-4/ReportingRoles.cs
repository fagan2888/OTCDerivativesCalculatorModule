using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReportingRoles
    {
        public ReportingRoles(XmlNode xmlNode)
        {
            XmlNodeList basePartyNodeList = xmlNode.SelectNodes("baseParty");
            if (basePartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basePartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basePartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(basePartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basePartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseParty = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList baseAccountNodeList = xmlNode.SelectNodes("baseAccount");
            if (baseAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(baseAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList activityProviderNodeList = xmlNode.SelectNodes("activityProvider");
            if (activityProviderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in activityProviderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        activityProviderIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(activityProviderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        activityProviderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        activityProvider = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList positionProviderNodeList = xmlNode.SelectNodes("positionProvider");
            if (positionProviderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in positionProviderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        positionProviderIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(positionProviderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        positionProviderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        positionProvider = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList valuationProviderNodeList = xmlNode.SelectNodes("valuationProvider");
            if (valuationProviderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationProviderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationProviderIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(valuationProviderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationProviderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationProvider = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region BaseParty
        private PartyReference baseParty;
        public PartyReference BaseParty
        {
            get
            {
                if (this.baseParty != null)
                {
                    return this.baseParty; 
                }
                else if (this.basePartyIDRef != null)
                {
                    baseParty = IDManager.getID(basePartyIDRef) as PartyReference;
                    return this.baseParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseParty != value)
                {
                    this.baseParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BaseAccount
        private AccountReference baseAccount;
        public AccountReference BaseAccount
        {
            get
            {
                if (this.baseAccount != null)
                {
                    return this.baseAccount; 
                }
                else if (this.baseAccountIDRef != null)
                {
                    baseAccount = IDManager.getID(baseAccountIDRef) as AccountReference;
                    return this.baseAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseAccount != value)
                {
                    this.baseAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ActivityProvider
        private PartyReference activityProvider;
        public PartyReference ActivityProvider
        {
            get
            {
                if (this.activityProvider != null)
                {
                    return this.activityProvider; 
                }
                else if (this.activityProviderIDRef != null)
                {
                    activityProvider = IDManager.getID(activityProviderIDRef) as PartyReference;
                    return this.activityProvider; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.activityProvider != value)
                {
                    this.activityProvider = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PositionProvider
        private PartyReference positionProvider;
        public PartyReference PositionProvider
        {
            get
            {
                if (this.positionProvider != null)
                {
                    return this.positionProvider; 
                }
                else if (this.positionProviderIDRef != null)
                {
                    positionProvider = IDManager.getID(positionProviderIDRef) as PartyReference;
                    return this.positionProvider; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.positionProvider != value)
                {
                    this.positionProvider = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ValuationProvider
        private PartyReference valuationProvider;
        public PartyReference ValuationProvider
        {
            get
            {
                if (this.valuationProvider != null)
                {
                    return this.valuationProvider; 
                }
                else if (this.valuationProviderIDRef != null)
                {
                    valuationProvider = IDManager.getID(valuationProviderIDRef) as PartyReference;
                    return this.valuationProvider; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationProvider != value)
                {
                    this.valuationProvider = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

