using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CompressionActivity : ISerialized
    {
        public CompressionActivity(XmlNode xmlNode)
        {
            XmlNode compressionTypeNode = xmlNode.SelectSingleNode("compressionType");
            
            if (compressionTypeNode != null)
            {
                if (compressionTypeNode.Attributes["href"] != null || compressionTypeNode.Attributes["id"] != null) 
                {
                    if (compressionTypeNode.Attributes["id"] != null) 
                    {
                        compressionTypeIDRef_ = compressionTypeNode.Attributes["id"].Value;
                        CompressionType ob = new CompressionType(compressionTypeNode);
                        IDManager.SetID(compressionTypeIDRef_, ob);
                    }
                    else if (compressionTypeNode.Attributes["href"] != null)
                    {
                        compressionTypeIDRef_ = compressionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compressionType_ = new CompressionType(compressionTypeNode);
                    }
                }
                else
                {
                    compressionType_ = new CompressionType(compressionTypeNode);
                }
            }
            
        
            XmlNode replacementTradeIdentifierNode = xmlNode.SelectSingleNode("replacementTradeIdentifier");
            
            if (replacementTradeIdentifierNode != null)
            {
                if (replacementTradeIdentifierNode.Attributes["href"] != null || replacementTradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (replacementTradeIdentifierNode.Attributes["id"] != null) 
                    {
                        replacementTradeIdentifierIDRef_ = replacementTradeIdentifierNode.Attributes["id"].Value;
                        TradeIdentifier ob = new TradeIdentifier(replacementTradeIdentifierNode);
                        IDManager.SetID(replacementTradeIdentifierIDRef_, ob);
                    }
                    else if (replacementTradeIdentifierNode.Attributes["href"] != null)
                    {
                        replacementTradeIdentifierIDRef_ = replacementTradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        replacementTradeIdentifier_ = new TradeIdentifier(replacementTradeIdentifierNode);
                    }
                }
                else
                {
                    replacementTradeIdentifier_ = new TradeIdentifier(replacementTradeIdentifierNode);
                }
            }
            
        
            XmlNodeList originatingTradeIdentifierNodeList = xmlNode.SelectNodes("originatingTradeIdentifier");
            
            if (originatingTradeIdentifierNodeList != null)
            {
                this.originatingTradeIdentifier_ = new List<TradeIdentifier>();
                foreach (XmlNode item in originatingTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            originatingTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            originatingTradeIdentifier_.Add(new TradeIdentifier(item));
                            IDManager.SetID(originatingTradeIdentifierIDRef_, originatingTradeIdentifier_[originatingTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            originatingTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        originatingTradeIdentifier_.Add(new TradeIdentifier(item));
                        }
                    }
                    else
                    {
                        originatingTradeIdentifier_.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode replacementTradeIdNode = xmlNode.SelectSingleNode("replacementTradeId");
            
            if (replacementTradeIdNode != null)
            {
                if (replacementTradeIdNode.Attributes["href"] != null || replacementTradeIdNode.Attributes["id"] != null) 
                {
                    if (replacementTradeIdNode.Attributes["id"] != null) 
                    {
                        replacementTradeIdIDRef_ = replacementTradeIdNode.Attributes["id"].Value;
                        TradeId ob = new TradeId(replacementTradeIdNode);
                        IDManager.SetID(replacementTradeIdIDRef_, ob);
                    }
                    else if (replacementTradeIdNode.Attributes["href"] != null)
                    {
                        replacementTradeIdIDRef_ = replacementTradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        replacementTradeId_ = new TradeId(replacementTradeIdNode);
                    }
                }
                else
                {
                    replacementTradeId_ = new TradeId(replacementTradeIdNode);
                }
            }
            
        
            XmlNodeList originatingTradeIdNodeList = xmlNode.SelectNodes("originatingTradeId");
            
            if (originatingTradeIdNodeList != null)
            {
                this.originatingTradeId_ = new List<TradeId>();
                foreach (XmlNode item in originatingTradeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            originatingTradeIdIDRef_ = item.Attributes["id"].Value;
                            originatingTradeId_.Add(new TradeId(item));
                            IDManager.SetID(originatingTradeIdIDRef_, originatingTradeId_[originatingTradeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            originatingTradeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        originatingTradeId_.Add(new TradeId(item));
                        }
                    }
                    else
                    {
                        originatingTradeId_.Add(new TradeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region CompressionType_
        private CompressionType compressionType_;
        public CompressionType CompressionType_
        {
            get
            {
                if (this.compressionType_ != null)
                {
                    return this.compressionType_; 
                }
                else if (this.compressionTypeIDRef_ != null)
                {
                    compressionType_ = IDManager.getID(compressionTypeIDRef_) as CompressionType;
                    return this.compressionType_; 
                }
                else
                {
                      return this.compressionType_; 
                }
            }
            set
            {
                if (this.compressionType_ != value)
                {
                    this.compressionType_ = value;
                }
            }
        }
        #endregion
        
        public string compressionTypeIDRef_ { get; set; }
        #region ReplacementTradeIdentifier_
        private TradeIdentifier replacementTradeIdentifier_;
        public TradeIdentifier ReplacementTradeIdentifier_
        {
            get
            {
                if (this.replacementTradeIdentifier_ != null)
                {
                    return this.replacementTradeIdentifier_; 
                }
                else if (this.replacementTradeIdentifierIDRef_ != null)
                {
                    replacementTradeIdentifier_ = IDManager.getID(replacementTradeIdentifierIDRef_) as TradeIdentifier;
                    return this.replacementTradeIdentifier_; 
                }
                else
                {
                      return this.replacementTradeIdentifier_; 
                }
            }
            set
            {
                if (this.replacementTradeIdentifier_ != value)
                {
                    this.replacementTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string replacementTradeIdentifierIDRef_ { get; set; }
        #region OriginatingTradeIdentifier_
        private List<TradeIdentifier> originatingTradeIdentifier_;
        public List<TradeIdentifier> OriginatingTradeIdentifier_
        {
            get
            {
                if (this.originatingTradeIdentifier_ != null)
                {
                    return this.originatingTradeIdentifier_; 
                }
                else if (this.originatingTradeIdentifierIDRef_ != null)
                {
                    return this.originatingTradeIdentifier_; 
                }
                else
                {
                      return this.originatingTradeIdentifier_; 
                }
            }
            set
            {
                if (this.originatingTradeIdentifier_ != value)
                {
                    this.originatingTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string originatingTradeIdentifierIDRef_ { get; set; }
        #region ReplacementTradeId_
        private TradeId replacementTradeId_;
        public TradeId ReplacementTradeId_
        {
            get
            {
                if (this.replacementTradeId_ != null)
                {
                    return this.replacementTradeId_; 
                }
                else if (this.replacementTradeIdIDRef_ != null)
                {
                    replacementTradeId_ = IDManager.getID(replacementTradeIdIDRef_) as TradeId;
                    return this.replacementTradeId_; 
                }
                else
                {
                      return this.replacementTradeId_; 
                }
            }
            set
            {
                if (this.replacementTradeId_ != value)
                {
                    this.replacementTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string replacementTradeIdIDRef_ { get; set; }
        #region OriginatingTradeId_
        private List<TradeId> originatingTradeId_;
        public List<TradeId> OriginatingTradeId_
        {
            get
            {
                if (this.originatingTradeId_ != null)
                {
                    return this.originatingTradeId_; 
                }
                else if (this.originatingTradeIdIDRef_ != null)
                {
                    return this.originatingTradeId_; 
                }
                else
                {
                      return this.originatingTradeId_; 
                }
            }
            set
            {
                if (this.originatingTradeId_ != value)
                {
                    this.originatingTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string originatingTradeIdIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

