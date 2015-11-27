using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ClearingStatusItem : ISerialized
    {
        public ClearingStatusItem(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            if (tradeIdentifierNodeList != null)
            {
                this.tradeIdentifier_ = new List<TradeIdentifier>();
                foreach (XmlNode item in tradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            tradeIdentifier_.Add(new TradeIdentifier(item));
                            IDManager.SetID(tradeIdentifierIDRef_, tradeIdentifier_[tradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tradeIdentifier_.Add(new TradeIdentifier(item));
                        }
                    }
                    else
                    {
                        tradeIdentifier_.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode tradeReferenceInformationNode = xmlNode.SelectSingleNode("tradeReferenceInformation");
            
            if (tradeReferenceInformationNode != null)
            {
                if (tradeReferenceInformationNode.Attributes["href"] != null || tradeReferenceInformationNode.Attributes["id"] != null) 
                {
                    if (tradeReferenceInformationNode.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["id"].Value;
                        TradeReferenceInformation ob = new TradeReferenceInformation(tradeReferenceInformationNode);
                        IDManager.SetID(tradeReferenceInformationIDRef_, ob);
                    }
                    else if (tradeReferenceInformationNode.Attributes["href"] != null)
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
                    }
                }
                else
                {
                    tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
                }
            }
            
        
            XmlNode tradeNode = xmlNode.SelectSingleNode("trade");
            
            if (tradeNode != null)
            {
                if (tradeNode.Attributes["href"] != null || tradeNode.Attributes["id"] != null) 
                {
                    if (tradeNode.Attributes["id"] != null) 
                    {
                        tradeIDRef_ = tradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(tradeNode);
                        IDManager.SetID(tradeIDRef_, ob);
                    }
                    else if (tradeNode.Attributes["href"] != null)
                    {
                        tradeIDRef_ = tradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trade_ = new Trade(tradeNode);
                    }
                }
                else
                {
                    trade_ = new Trade(tradeNode);
                }
            }
            
        
            XmlNode clearingStatusValueNode = xmlNode.SelectSingleNode("clearingStatusValue");
            
            if (clearingStatusValueNode != null)
            {
                if (clearingStatusValueNode.Attributes["href"] != null || clearingStatusValueNode.Attributes["id"] != null) 
                {
                    if (clearingStatusValueNode.Attributes["id"] != null) 
                    {
                        clearingStatusValueIDRef_ = clearingStatusValueNode.Attributes["id"].Value;
                        ClearingStatusValue ob = new ClearingStatusValue(clearingStatusValueNode);
                        IDManager.SetID(clearingStatusValueIDRef_, ob);
                    }
                    else if (clearingStatusValueNode.Attributes["href"] != null)
                    {
                        clearingStatusValueIDRef_ = clearingStatusValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearingStatusValue_ = new ClearingStatusValue(clearingStatusValueNode);
                    }
                }
                else
                {
                    clearingStatusValue_ = new ClearingStatusValue(clearingStatusValueNode);
                }
            }
            
        
            XmlNode updatedDateTimeNode = xmlNode.SelectSingleNode("updatedDateTime");
            
            if (updatedDateTimeNode != null)
            {
                if (updatedDateTimeNode.Attributes["href"] != null || updatedDateTimeNode.Attributes["id"] != null) 
                {
                    if (updatedDateTimeNode.Attributes["id"] != null) 
                    {
                        updatedDateTimeIDRef_ = updatedDateTimeNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(updatedDateTimeNode);
                        IDManager.SetID(updatedDateTimeIDRef_, ob);
                    }
                    else if (updatedDateTimeNode.Attributes["href"] != null)
                    {
                        updatedDateTimeIDRef_ = updatedDateTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        updatedDateTime_ = new XsdTypeDateTime(updatedDateTimeNode);
                    }
                }
                else
                {
                    updatedDateTime_ = new XsdTypeDateTime(updatedDateTimeNode);
                }
            }
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            if (reasonNodeList != null)
            {
                this.reason_ = new List<Reason>();
                foreach (XmlNode item in reasonNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reasonIDRef_ = item.Attributes["id"].Value;
                            reason_.Add(new Reason(item));
                            IDManager.SetID(reasonIDRef_, reason_[reason_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reasonIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reason_.Add(new Reason(item));
                        }
                    }
                    else
                    {
                        reason_.Add(new Reason(item));
                    }
                }
            }
            
        
            XmlNodeList statusAppliesToNodeList = xmlNode.SelectNodes("statusAppliesTo");
            
            if (statusAppliesToNodeList != null)
            {
                this.statusAppliesTo_ = new List<PartyReference>();
                foreach (XmlNode item in statusAppliesToNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            statusAppliesToIDRef_ = item.Attributes["id"].Value;
                            statusAppliesTo_.Add(new PartyReference(item));
                            IDManager.SetID(statusAppliesToIDRef_, statusAppliesTo_[statusAppliesTo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            statusAppliesToIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        statusAppliesTo_.Add(new PartyReference(item));
                        }
                    }
                    else
                    {
                        statusAppliesTo_.Add(new PartyReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier_
        private List<TradeIdentifier> tradeIdentifier_;
        public List<TradeIdentifier> TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        #region TradeReferenceInformation_
        private TradeReferenceInformation tradeReferenceInformation_;
        public TradeReferenceInformation TradeReferenceInformation_
        {
            get
            {
                if (this.tradeReferenceInformation_ != null)
                {
                    return this.tradeReferenceInformation_; 
                }
                else if (this.tradeReferenceInformationIDRef_ != null)
                {
                    tradeReferenceInformation_ = IDManager.getID(tradeReferenceInformationIDRef_) as TradeReferenceInformation;
                    return this.tradeReferenceInformation_; 
                }
                else
                {
                      return this.tradeReferenceInformation_; 
                }
            }
            set
            {
                if (this.tradeReferenceInformation_ != value)
                {
                    this.tradeReferenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string tradeReferenceInformationIDRef_ { get; set; }
        #region Trade_
        private Trade trade_;
        public Trade Trade_
        {
            get
            {
                if (this.trade_ != null)
                {
                    return this.trade_; 
                }
                else if (this.tradeIDRef_ != null)
                {
                    trade_ = IDManager.getID(tradeIDRef_) as Trade;
                    return this.trade_; 
                }
                else
                {
                      return this.trade_; 
                }
            }
            set
            {
                if (this.trade_ != value)
                {
                    this.trade_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIDRef_ { get; set; }
        #region ClearingStatusValue_
        private ClearingStatusValue clearingStatusValue_;
        public ClearingStatusValue ClearingStatusValue_
        {
            get
            {
                if (this.clearingStatusValue_ != null)
                {
                    return this.clearingStatusValue_; 
                }
                else if (this.clearingStatusValueIDRef_ != null)
                {
                    clearingStatusValue_ = IDManager.getID(clearingStatusValueIDRef_) as ClearingStatusValue;
                    return this.clearingStatusValue_; 
                }
                else
                {
                      return this.clearingStatusValue_; 
                }
            }
            set
            {
                if (this.clearingStatusValue_ != value)
                {
                    this.clearingStatusValue_ = value;
                }
            }
        }
        #endregion
        
        public string clearingStatusValueIDRef_ { get; set; }
        #region UpdatedDateTime_
        private XsdTypeDateTime updatedDateTime_;
        public XsdTypeDateTime UpdatedDateTime_
        {
            get
            {
                if (this.updatedDateTime_ != null)
                {
                    return this.updatedDateTime_; 
                }
                else if (this.updatedDateTimeIDRef_ != null)
                {
                    updatedDateTime_ = IDManager.getID(updatedDateTimeIDRef_) as XsdTypeDateTime;
                    return this.updatedDateTime_; 
                }
                else
                {
                      return this.updatedDateTime_; 
                }
            }
            set
            {
                if (this.updatedDateTime_ != value)
                {
                    this.updatedDateTime_ = value;
                }
            }
        }
        #endregion
        
        public string updatedDateTimeIDRef_ { get; set; }
        #region Reason_
        private List<Reason> reason_;
        public List<Reason> Reason_
        {
            get
            {
                if (this.reason_ != null)
                {
                    return this.reason_; 
                }
                else if (this.reasonIDRef_ != null)
                {
                    return this.reason_; 
                }
                else
                {
                      return this.reason_; 
                }
            }
            set
            {
                if (this.reason_ != value)
                {
                    this.reason_ = value;
                }
            }
        }
        #endregion
        
        public string reasonIDRef_ { get; set; }
        #region StatusAppliesTo_
        private List<PartyReference> statusAppliesTo_;
        public List<PartyReference> StatusAppliesTo_
        {
            get
            {
                if (this.statusAppliesTo_ != null)
                {
                    return this.statusAppliesTo_; 
                }
                else if (this.statusAppliesToIDRef_ != null)
                {
                    return this.statusAppliesTo_; 
                }
                else
                {
                      return this.statusAppliesTo_; 
                }
            }
            set
            {
                if (this.statusAppliesTo_ != value)
                {
                    this.statusAppliesTo_ = value;
                }
            }
        }
        #endregion
        
        public string statusAppliesToIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

