using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExchangeTraded : UnderlyingAsset
    {
        public ExchangeTraded(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList relatedExchangeIdNodeList = xmlNode.SelectNodes("relatedExchangeId");
            
            if (relatedExchangeIdNodeList != null)
            {
                this.relatedExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in relatedExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedExchangeIdIDRef_ = item.Attributes["id"].Value;
                            relatedExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(relatedExchangeIdIDRef_, relatedExchangeId_[relatedExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        relatedExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeIdNodeList = xmlNode.SelectNodes("optionsExchangeId");
            
            if (optionsExchangeIdNodeList != null)
            {
                this.optionsExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in optionsExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            optionsExchangeIdIDRef_ = item.Attributes["id"].Value;
                            optionsExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(optionsExchangeIdIDRef_, optionsExchangeId_[optionsExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            optionsExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        optionsExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        optionsExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList specifiedExchangeIdNodeList = xmlNode.SelectNodes("specifiedExchangeId");
            
            if (specifiedExchangeIdNodeList != null)
            {
                this.specifiedExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in specifiedExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            specifiedExchangeIdIDRef_ = item.Attributes["id"].Value;
                            specifiedExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(specifiedExchangeIdIDRef_, specifiedExchangeId_[specifiedExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            specifiedExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        specifiedExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        specifiedExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region RelatedExchangeId_
        private List<ExchangeId> relatedExchangeId_;
        public List<ExchangeId> RelatedExchangeId_
        {
            get
            {
                if (this.relatedExchangeId_ != null)
                {
                    return this.relatedExchangeId_; 
                }
                else if (this.relatedExchangeIdIDRef_ != null)
                {
                    return this.relatedExchangeId_; 
                }
                else
                {
                      return this.relatedExchangeId_; 
                }
            }
            set
            {
                if (this.relatedExchangeId_ != value)
                {
                    this.relatedExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string relatedExchangeIdIDRef_ { get; set; }
        #region OptionsExchangeId_
        private List<ExchangeId> optionsExchangeId_;
        public List<ExchangeId> OptionsExchangeId_
        {
            get
            {
                if (this.optionsExchangeId_ != null)
                {
                    return this.optionsExchangeId_; 
                }
                else if (this.optionsExchangeIdIDRef_ != null)
                {
                    return this.optionsExchangeId_; 
                }
                else
                {
                      return this.optionsExchangeId_; 
                }
            }
            set
            {
                if (this.optionsExchangeId_ != value)
                {
                    this.optionsExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string optionsExchangeIdIDRef_ { get; set; }
        #region SpecifiedExchangeId_
        private List<ExchangeId> specifiedExchangeId_;
        public List<ExchangeId> SpecifiedExchangeId_
        {
            get
            {
                if (this.specifiedExchangeId_ != null)
                {
                    return this.specifiedExchangeId_; 
                }
                else if (this.specifiedExchangeIdIDRef_ != null)
                {
                    return this.specifiedExchangeId_; 
                }
                else
                {
                      return this.specifiedExchangeId_; 
                }
            }
            set
            {
                if (this.specifiedExchangeId_ != value)
                {
                    this.specifiedExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string specifiedExchangeIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

