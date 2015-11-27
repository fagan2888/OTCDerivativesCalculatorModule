using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CompressionActivity
    {
        public CompressionActivity(XmlNode xmlNode)
        {
            XmlNodeList compressionTypeNodeList = xmlNode.SelectNodes("compressionType");
            if (compressionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compressionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compressionTypeIDRef = item.Attributes["id"].Name;
                        CompressionType ob = CompressionType();
                        IDManager.SetID(compressionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compressionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compressionType = new CompressionType(item);
                    }
                }
            }
            
        
            XmlNodeList replacementTradeIdentifierNodeList = xmlNode.SelectNodes("replacementTradeIdentifier");
            if (replacementTradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in replacementTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        replacementTradeIdentifierIDRef = item.Attributes["id"].Name;
                        TradeIdentifier ob = TradeIdentifier();
                        IDManager.SetID(replacementTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        replacementTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        replacementTradeIdentifier = new TradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList originatingTradeIdentifierNodeList = xmlNode.SelectNodes("originatingTradeIdentifier");
            
            foreach (XmlNode item in originatingTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<TradeIdentifier> ob = new List<TradeIdentifier>();
                        ob.Add(new TradeIdentifier(item));
                        IDManager.SetID(originatingTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    originatingTradeIdentifier.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList replacementTradeIdNodeList = xmlNode.SelectNodes("replacementTradeId");
            if (replacementTradeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in replacementTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        replacementTradeIdIDRef = item.Attributes["id"].Name;
                        TradeId ob = TradeId();
                        IDManager.SetID(replacementTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        replacementTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        replacementTradeId = new TradeId(item);
                    }
                }
            }
            
        
            XmlNodeList originatingTradeIdNodeList = xmlNode.SelectNodes("originatingTradeId");
            
            foreach (XmlNode item in originatingTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingTradeIdIDRef = item.Attributes["id"].Name;
                        List<TradeId> ob = new List<TradeId>();
                        ob.Add(new TradeId(item));
                        IDManager.SetID(originatingTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    originatingTradeId.Add(new TradeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region CompressionType
        private CompressionType compressionType;
        public CompressionType CompressionType
        {
            get
            {
                if (this.compressionType != null)
                {
                    return this.compressionType; 
                }
                else if (this.compressionTypeIDRef != null)
                {
                    compressionType = IDManager.getID(compressionTypeIDRef) as CompressionType;
                    return this.compressionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compressionType != value)
                {
                    this.compressionType = value;
                }
            }
        }
        #endregion
        
        public string CompressionTypeIDRef { get; set; }
        #region ReplacementTradeIdentifier
        private TradeIdentifier replacementTradeIdentifier;
        public TradeIdentifier ReplacementTradeIdentifier
        {
            get
            {
                if (this.replacementTradeIdentifier != null)
                {
                    return this.replacementTradeIdentifier; 
                }
                else if (this.replacementTradeIdentifierIDRef != null)
                {
                    replacementTradeIdentifier = IDManager.getID(replacementTradeIdentifierIDRef) as TradeIdentifier;
                    return this.replacementTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.replacementTradeIdentifier != value)
                {
                    this.replacementTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region OriginatingTradeIdentifier
        private List<TradeIdentifier> originatingTradeIdentifier;
        public List<TradeIdentifier> OriginatingTradeIdentifier
        {
            get
            {
                if (this.originatingTradeIdentifier != null)
                {
                    return this.originatingTradeIdentifier; 
                }
                else if (this.originatingTradeIdentifierIDRef != null)
                {
                    originatingTradeIdentifier = IDManager.getID(originatingTradeIdentifierIDRef) as List<TradeIdentifier>;
                    return this.originatingTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingTradeIdentifier != value)
                {
                    this.originatingTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region ReplacementTradeId
        private TradeId replacementTradeId;
        public TradeId ReplacementTradeId
        {
            get
            {
                if (this.replacementTradeId != null)
                {
                    return this.replacementTradeId; 
                }
                else if (this.replacementTradeIdIDRef != null)
                {
                    replacementTradeId = IDManager.getID(replacementTradeIdIDRef) as TradeId;
                    return this.replacementTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.replacementTradeId != value)
                {
                    this.replacementTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdIDRef { get; set; }
        #region OriginatingTradeId
        private List<TradeId> originatingTradeId;
        public List<TradeId> OriginatingTradeId
        {
            get
            {
                if (this.originatingTradeId != null)
                {
                    return this.originatingTradeId; 
                }
                else if (this.originatingTradeIdIDRef != null)
                {
                    originatingTradeId = IDManager.getID(originatingTradeIdIDRef) as List<TradeId>;
                    return this.originatingTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingTradeId != value)
                {
                    this.originatingTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

