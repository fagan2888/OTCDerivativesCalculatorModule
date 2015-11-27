using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedCalculatedPrice : ExchangeTraded
    {
        public ExchangeTradedCalculatedPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList constituentExchangeIdNodeList = xmlNode.SelectNodes("constituentExchangeId");
            
            if (constituentExchangeIdNodeList != null)
            {
                this.constituentExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in constituentExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            constituentExchangeIdIDRef_ = item.Attributes["id"].Value;
                            constituentExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(constituentExchangeIdIDRef_, constituentExchangeId_[constituentExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            constituentExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        constituentExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        constituentExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region ConstituentExchangeId_
        private List<ExchangeId> constituentExchangeId_;
        public List<ExchangeId> ConstituentExchangeId_
        {
            get
            {
                if (this.constituentExchangeId_ != null)
                {
                    return this.constituentExchangeId_; 
                }
                else if (this.constituentExchangeIdIDRef_ != null)
                {
                    return this.constituentExchangeId_; 
                }
                else
                {
                      return this.constituentExchangeId_; 
                }
            }
            set
            {
                if (this.constituentExchangeId_ != value)
                {
                    this.constituentExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string constituentExchangeIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

