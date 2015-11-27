using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class InterestRateSwap : ISerialized
    {
        public InterestRateSwap() { }
        public InterestRateSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList swapStreamNodeList = xmlNode.SelectNodes("swapStream");
            
            if (swapStreamNodeList != null)
            {
                this.swapStream_ = new List<SwapStream>();
                foreach (XmlNode item in swapStreamNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            swapStreamIDRef_ = item.Attributes["id"].Value;
                            swapStream_.Add(new SwapStream(item));
                            IDManager.SetID(swapStreamIDRef_, swapStream_[swapStream_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            swapStreamIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        swapStream_.Add(new SwapStream(item));
                        }
                    }
                    else
                    {
                        swapStream_.Add(new SwapStream(item));
                    }
                }
            }
            
        
        }
        
    
        #region SwapStream_
        private List<SwapStream> swapStream_;
        public List<SwapStream> SwapStream_
        {
            get
            {
                if (this.swapStream_ != null)
                {
                    return this.swapStream_; 
                }
                else if (this.swapStreamIDRef_ != null)
                {
                    return this.swapStream_; 
                }
                else
                {
                      return this.swapStream_; 
                }
            }
            set
            {
                if (this.swapStream_ != value)
                {
                    this.swapStream_ = value;
                }
            }
        }
        #endregion
        
        public string swapStreamIDRef_ { get; set; }
        
    
        
    
    }
    
}

