using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Cash : Asset
    {
        public Cash(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList instrumentIdNodeList = xmlNode.SelectNodes("instrumentId");
            
            if (instrumentIdNodeList != null)
            {
                this.instrumentId_ = new List<InstrumentId>();
                foreach (XmlNode item in instrumentIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            instrumentIdIDRef_ = item.Attributes["id"].Value;
                            instrumentId_.Add(new InstrumentId(item));
                            IDManager.SetID(instrumentIdIDRef_, instrumentId_[instrumentId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            instrumentIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        instrumentId_.Add(new InstrumentId(item));
                        }
                    }
                    else
                    {
                        instrumentId_.Add(new InstrumentId(item));
                    }
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeString(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeString(descriptionNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
        }
        
    
        #region InstrumentId_
        private List<InstrumentId> instrumentId_;
        public List<InstrumentId> InstrumentId_
        {
            get
            {
                if (this.instrumentId_ != null)
                {
                    return this.instrumentId_; 
                }
                else if (this.instrumentIdIDRef_ != null)
                {
                    return this.instrumentId_; 
                }
                else
                {
                      return this.instrumentId_; 
                }
            }
            set
            {
                if (this.instrumentId_ != value)
                {
                    this.instrumentId_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentIdIDRef_ { get; set; }
        #region Description_
        private XsdTypeString description_;
        public XsdTypeString Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeString;
                    return this.description_; 
                }
                else
                {
                      return this.description_; 
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        
    
        
    
    }
    
}

