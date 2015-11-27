using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IdentifiedAsset : Asset
    {
        public IdentifiedAsset(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

