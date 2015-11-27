using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradePricing : ISerialized
    {
        public InstrumentTradePricing(XmlNode xmlNode)
        {
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            if (quoteNodeList != null)
            {
                this.quote_ = new List<BasicQuotation>();
                foreach (XmlNode item in quoteNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            quoteIDRef_ = item.Attributes["id"].Value;
                            quote_.Add(new BasicQuotation(item));
                            IDManager.SetID(quoteIDRef_, quote_[quote_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            quoteIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        quote_.Add(new BasicQuotation(item));
                        }
                    }
                    else
                    {
                        quote_.Add(new BasicQuotation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Quote_
        private List<BasicQuotation> quote_;
        public List<BasicQuotation> Quote_
        {
            get
            {
                if (this.quote_ != null)
                {
                    return this.quote_; 
                }
                else if (this.quoteIDRef_ != null)
                {
                    return this.quote_; 
                }
                else
                {
                      return this.quote_; 
                }
            }
            set
            {
                if (this.quote_ != value)
                {
                    this.quote_ = value;
                }
            }
        }
        #endregion
        
        public string quoteIDRef_ { get; set; }
        
    
        
    
    }
    
}

