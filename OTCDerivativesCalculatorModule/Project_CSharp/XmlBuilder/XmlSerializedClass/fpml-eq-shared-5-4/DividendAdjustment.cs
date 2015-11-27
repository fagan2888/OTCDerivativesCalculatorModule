using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendAdjustment : ISerialized
    {
        public DividendAdjustment(XmlNode xmlNode)
        {
            XmlNodeList dividendPeriodNodeList = xmlNode.SelectNodes("dividendPeriod");
            
            if (dividendPeriodNodeList != null)
            {
                this.dividendPeriod_ = new List<DividendPeriodDividend>();
                foreach (XmlNode item in dividendPeriodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dividendPeriodIDRef_ = item.Attributes["id"].Value;
                            dividendPeriod_.Add(new DividendPeriodDividend(item));
                            IDManager.SetID(dividendPeriodIDRef_, dividendPeriod_[dividendPeriod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dividendPeriodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dividendPeriod_.Add(new DividendPeriodDividend(item));
                        }
                    }
                    else
                    {
                        dividendPeriod_.Add(new DividendPeriodDividend(item));
                    }
                }
            }
            
        
        }
        
    
        #region DividendPeriod_
        private List<DividendPeriodDividend> dividendPeriod_;
        public List<DividendPeriodDividend> DividendPeriod_
        {
            get
            {
                if (this.dividendPeriod_ != null)
                {
                    return this.dividendPeriod_; 
                }
                else if (this.dividendPeriodIDRef_ != null)
                {
                    return this.dividendPeriod_; 
                }
                else
                {
                      return this.dividendPeriod_; 
                }
            }
            set
            {
                if (this.dividendPeriod_ != value)
                {
                    this.dividendPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

