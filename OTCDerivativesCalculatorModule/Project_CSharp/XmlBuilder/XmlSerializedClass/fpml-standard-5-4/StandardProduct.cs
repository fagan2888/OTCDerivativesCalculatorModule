using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StandardProduct : Product
    {
        public StandardProduct(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        CashflowNotional ob = new CashflowNotional(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new CashflowNotional(notionalNode);
                    }
                }
                else
                {
                    notional_ = new CashflowNotional(notionalNode);
                }
            }
            
        
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
        
    
        #region Notional_
        private CashflowNotional notional_;
        public CashflowNotional Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as CashflowNotional;
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
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

