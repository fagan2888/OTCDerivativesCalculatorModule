using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExchangeTraded
    {
        public ExchangeTraded(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList relatedExchangeIdNodeList = xmlNode.SelectNodes("relatedExchangeId");
            
            foreach (XmlNode item in relatedExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(relatedExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeIdNodeList = xmlNode.SelectNodes("optionsExchangeId");
            
            foreach (XmlNode item in optionsExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionsExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(optionsExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionsExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    optionsExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList specifiedExchangeIdNodeList = xmlNode.SelectNodes("specifiedExchangeId");
            
            foreach (XmlNode item in specifiedExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specifiedExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(specifiedExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specifiedExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    specifiedExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region RelatedExchangeId
        private List<ExchangeId> relatedExchangeId;
        public List<ExchangeId> RelatedExchangeId
        {
            get
            {
                if (this.relatedExchangeId != null)
                {
                    return this.relatedExchangeId; 
                }
                else if (this.relatedExchangeIdIDRef != null)
                {
                    relatedExchangeId = IDManager.getID(relatedExchangeIdIDRef) as List<ExchangeId>;
                    return this.relatedExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedExchangeId != value)
                {
                    this.relatedExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region OptionsExchangeId
        private List<ExchangeId> optionsExchangeId;
        public List<ExchangeId> OptionsExchangeId
        {
            get
            {
                if (this.optionsExchangeId != null)
                {
                    return this.optionsExchangeId; 
                }
                else if (this.optionsExchangeIdIDRef != null)
                {
                    optionsExchangeId = IDManager.getID(optionsExchangeIdIDRef) as List<ExchangeId>;
                    return this.optionsExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionsExchangeId != value)
                {
                    this.optionsExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region SpecifiedExchangeId
        private List<ExchangeId> specifiedExchangeId;
        public List<ExchangeId> SpecifiedExchangeId
        {
            get
            {
                if (this.specifiedExchangeId != null)
                {
                    return this.specifiedExchangeId; 
                }
                else if (this.specifiedExchangeIdIDRef != null)
                {
                    specifiedExchangeId = IDManager.getID(specifiedExchangeIdIDRef) as List<ExchangeId>;
                    return this.specifiedExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specifiedExchangeId != value)
                {
                    this.specifiedExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        
    
        
    
    }
    
}

