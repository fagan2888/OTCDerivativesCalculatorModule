using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeWrapper : ISerialized
    {
        public TradeWrapper(XmlNode xmlNode)
        {
            XmlNode originatingEventNode = xmlNode.SelectSingleNode("originatingEvent");
            
            if (originatingEventNode != null)
            {
                if (originatingEventNode.Attributes["href"] != null || originatingEventNode.Attributes["id"] != null) 
                {
                    if (originatingEventNode.Attributes["id"] != null) 
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["id"].Value;
                        OriginatingEvent ob = new OriginatingEvent(originatingEventNode);
                        IDManager.SetID(originatingEventIDRef_, ob);
                    }
                    else if (originatingEventNode.Attributes["href"] != null)
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originatingEvent_ = new OriginatingEvent(originatingEventNode);
                    }
                }
                else
                {
                    originatingEvent_ = new OriginatingEvent(originatingEventNode);
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
            
        
        }
        
    
        #region OriginatingEvent_
        private OriginatingEvent originatingEvent_;
        public OriginatingEvent OriginatingEvent_
        {
            get
            {
                if (this.originatingEvent_ != null)
                {
                    return this.originatingEvent_; 
                }
                else if (this.originatingEventIDRef_ != null)
                {
                    originatingEvent_ = IDManager.getID(originatingEventIDRef_) as OriginatingEvent;
                    return this.originatingEvent_; 
                }
                else
                {
                      return this.originatingEvent_; 
                }
            }
            set
            {
                if (this.originatingEvent_ != value)
                {
                    this.originatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string originatingEventIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

