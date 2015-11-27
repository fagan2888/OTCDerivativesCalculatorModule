using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReportingRoles : ISerialized
    {
        public ReportingRoles(XmlNode xmlNode)
        {
            XmlNode basePartyNode = xmlNode.SelectSingleNode("baseParty");
            
            if (basePartyNode != null)
            {
                if (basePartyNode.Attributes["href"] != null || basePartyNode.Attributes["id"] != null) 
                {
                    if (basePartyNode.Attributes["id"] != null) 
                    {
                        basePartyIDRef_ = basePartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(basePartyNode);
                        IDManager.SetID(basePartyIDRef_, ob);
                    }
                    else if (basePartyNode.Attributes["href"] != null)
                    {
                        basePartyIDRef_ = basePartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseParty_ = new PartyReference(basePartyNode);
                    }
                }
                else
                {
                    baseParty_ = new PartyReference(basePartyNode);
                }
            }
            
        
            XmlNode baseAccountNode = xmlNode.SelectSingleNode("baseAccount");
            
            if (baseAccountNode != null)
            {
                if (baseAccountNode.Attributes["href"] != null || baseAccountNode.Attributes["id"] != null) 
                {
                    if (baseAccountNode.Attributes["id"] != null) 
                    {
                        baseAccountIDRef_ = baseAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(baseAccountNode);
                        IDManager.SetID(baseAccountIDRef_, ob);
                    }
                    else if (baseAccountNode.Attributes["href"] != null)
                    {
                        baseAccountIDRef_ = baseAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseAccount_ = new AccountReference(baseAccountNode);
                    }
                }
                else
                {
                    baseAccount_ = new AccountReference(baseAccountNode);
                }
            }
            
        
            XmlNode activityProviderNode = xmlNode.SelectSingleNode("activityProvider");
            
            if (activityProviderNode != null)
            {
                if (activityProviderNode.Attributes["href"] != null || activityProviderNode.Attributes["id"] != null) 
                {
                    if (activityProviderNode.Attributes["id"] != null) 
                    {
                        activityProviderIDRef_ = activityProviderNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(activityProviderNode);
                        IDManager.SetID(activityProviderIDRef_, ob);
                    }
                    else if (activityProviderNode.Attributes["href"] != null)
                    {
                        activityProviderIDRef_ = activityProviderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        activityProvider_ = new PartyReference(activityProviderNode);
                    }
                }
                else
                {
                    activityProvider_ = new PartyReference(activityProviderNode);
                }
            }
            
        
            XmlNode positionProviderNode = xmlNode.SelectSingleNode("positionProvider");
            
            if (positionProviderNode != null)
            {
                if (positionProviderNode.Attributes["href"] != null || positionProviderNode.Attributes["id"] != null) 
                {
                    if (positionProviderNode.Attributes["id"] != null) 
                    {
                        positionProviderIDRef_ = positionProviderNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(positionProviderNode);
                        IDManager.SetID(positionProviderIDRef_, ob);
                    }
                    else if (positionProviderNode.Attributes["href"] != null)
                    {
                        positionProviderIDRef_ = positionProviderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        positionProvider_ = new PartyReference(positionProviderNode);
                    }
                }
                else
                {
                    positionProvider_ = new PartyReference(positionProviderNode);
                }
            }
            
        
            XmlNode valuationProviderNode = xmlNode.SelectSingleNode("valuationProvider");
            
            if (valuationProviderNode != null)
            {
                if (valuationProviderNode.Attributes["href"] != null || valuationProviderNode.Attributes["id"] != null) 
                {
                    if (valuationProviderNode.Attributes["id"] != null) 
                    {
                        valuationProviderIDRef_ = valuationProviderNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(valuationProviderNode);
                        IDManager.SetID(valuationProviderIDRef_, ob);
                    }
                    else if (valuationProviderNode.Attributes["href"] != null)
                    {
                        valuationProviderIDRef_ = valuationProviderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationProvider_ = new PartyReference(valuationProviderNode);
                    }
                }
                else
                {
                    valuationProvider_ = new PartyReference(valuationProviderNode);
                }
            }
            
        
        }
        
    
        #region BaseParty_
        private PartyReference baseParty_;
        public PartyReference BaseParty_
        {
            get
            {
                if (this.baseParty_ != null)
                {
                    return this.baseParty_; 
                }
                else if (this.basePartyIDRef_ != null)
                {
                    baseParty_ = IDManager.getID(basePartyIDRef_) as PartyReference;
                    return this.baseParty_; 
                }
                else
                {
                      return this.baseParty_; 
                }
            }
            set
            {
                if (this.baseParty_ != value)
                {
                    this.baseParty_ = value;
                }
            }
        }
        #endregion
        
        public string basePartyIDRef_ { get; set; }
        #region BaseAccount_
        private AccountReference baseAccount_;
        public AccountReference BaseAccount_
        {
            get
            {
                if (this.baseAccount_ != null)
                {
                    return this.baseAccount_; 
                }
                else if (this.baseAccountIDRef_ != null)
                {
                    baseAccount_ = IDManager.getID(baseAccountIDRef_) as AccountReference;
                    return this.baseAccount_; 
                }
                else
                {
                      return this.baseAccount_; 
                }
            }
            set
            {
                if (this.baseAccount_ != value)
                {
                    this.baseAccount_ = value;
                }
            }
        }
        #endregion
        
        public string baseAccountIDRef_ { get; set; }
        #region ActivityProvider_
        private PartyReference activityProvider_;
        public PartyReference ActivityProvider_
        {
            get
            {
                if (this.activityProvider_ != null)
                {
                    return this.activityProvider_; 
                }
                else if (this.activityProviderIDRef_ != null)
                {
                    activityProvider_ = IDManager.getID(activityProviderIDRef_) as PartyReference;
                    return this.activityProvider_; 
                }
                else
                {
                      return this.activityProvider_; 
                }
            }
            set
            {
                if (this.activityProvider_ != value)
                {
                    this.activityProvider_ = value;
                }
            }
        }
        #endregion
        
        public string activityProviderIDRef_ { get; set; }
        #region PositionProvider_
        private PartyReference positionProvider_;
        public PartyReference PositionProvider_
        {
            get
            {
                if (this.positionProvider_ != null)
                {
                    return this.positionProvider_; 
                }
                else if (this.positionProviderIDRef_ != null)
                {
                    positionProvider_ = IDManager.getID(positionProviderIDRef_) as PartyReference;
                    return this.positionProvider_; 
                }
                else
                {
                      return this.positionProvider_; 
                }
            }
            set
            {
                if (this.positionProvider_ != value)
                {
                    this.positionProvider_ = value;
                }
            }
        }
        #endregion
        
        public string positionProviderIDRef_ { get; set; }
        #region ValuationProvider_
        private PartyReference valuationProvider_;
        public PartyReference ValuationProvider_
        {
            get
            {
                if (this.valuationProvider_ != null)
                {
                    return this.valuationProvider_; 
                }
                else if (this.valuationProviderIDRef_ != null)
                {
                    valuationProvider_ = IDManager.getID(valuationProviderIDRef_) as PartyReference;
                    return this.valuationProvider_; 
                }
                else
                {
                      return this.valuationProvider_; 
                }
            }
            set
            {
                if (this.valuationProvider_ != value)
                {
                    this.valuationProvider_ = value;
                }
            }
        }
        #endregion
        
        public string valuationProviderIDRef_ { get; set; }
        
    
        
    
    }
    
}

