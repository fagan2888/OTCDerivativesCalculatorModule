using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AssetValuation : Valuation
    {
        public AssetValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            if (quoteNodeList != null)
            {
                this.quote_ = new List<Quotation>();
                foreach (XmlNode item in quoteNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            quoteIDRef_ = item.Attributes["id"].Value;
                            quote_.Add(new Quotation(item));
                            IDManager.SetID(quoteIDRef_, quote_[quote_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            quoteIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        quote_.Add(new Quotation(item));
                        }
                    }
                    else
                    {
                        quote_.Add(new Quotation(item));
                    }
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            if (fxRateNodeList != null)
            {
                this.fxRate_ = new List<FxRate>();
                foreach (XmlNode item in fxRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fxRateIDRef_ = item.Attributes["id"].Value;
                            fxRate_.Add(new FxRate(item));
                            IDManager.SetID(fxRateIDRef_, fxRate_[fxRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fxRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fxRate_.Add(new FxRate(item));
                        }
                    }
                    else
                    {
                        fxRate_.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region Quote_
        private List<Quotation> quote_;
        public List<Quotation> Quote_
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
        #region FxRate_
        private List<FxRate> fxRate_;
        public List<FxRate> FxRate_
        {
            get
            {
                if (this.fxRate_ != null)
                {
                    return this.fxRate_; 
                }
                else if (this.fxRateIDRef_ != null)
                {
                    return this.fxRate_; 
                }
                else
                {
                      return this.fxRate_; 
                }
            }
            set
            {
                if (this.fxRate_ != value)
                {
                    this.fxRate_ = value;
                }
            }
        }
        #endregion
        
        public string fxRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

