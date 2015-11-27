using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Index : ISerialized
    {
        public Index() { }
        public Index(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode basePriceNode = xmlNode.SelectSingleNode("basePrice");
            
            if (basePriceNode != null)
            {
                if (basePriceNode.Attributes["href"] != null || basePriceNode.Attributes["id"] != null) 
                {
                    if (basePriceNode.Attributes["id"] != null) 
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(basePriceNode);
                        IDManager.SetID(basePriceIDRef_, ob);
                    }
                    else if (basePriceNode.Attributes["href"] != null)
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basePrice_ = new XsdTypeToken(basePriceNode);
                    }
                }
                else
                {
                    basePrice_ = new XsdTypeToken(basePriceNode);
                }
            }
            
        
            XmlNode interestRateIndexNode = xmlNode.SelectSingleNode("interestRateIndex");
            
            if (interestRateIndexNode != null)
            {
                if (interestRateIndexNode.Attributes["href"] != null || interestRateIndexNode.Attributes["id"] != null) 
                {
                    if (interestRateIndexNode.Attributes["id"] != null) 
                    {
                        interestRateIndexIDRef_ = interestRateIndexNode.Attributes["id"].Value;
                        InterestRateIndex ob = new InterestRateIndex(interestRateIndexNode);
                        IDManager.SetID(interestRateIndexIDRef_, ob);
                    }
                    else if (interestRateIndexNode.Attributes["href"] != null)
                    {
                        interestRateIndexIDRef_ = interestRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestRateIndex_ = new InterestRateIndex(interestRateIndexNode);
                    }
                }
                else
                {
                    interestRateIndex_ = new InterestRateIndex(interestRateIndexNode);
                }
            }
            
        
            XmlNode stockIndexNode = xmlNode.SelectSingleNode("stockIndex");
            
            if (stockIndexNode != null)
            {
                if (stockIndexNode.Attributes["href"] != null || stockIndexNode.Attributes["id"] != null) 
                {
                    if (stockIndexNode.Attributes["id"] != null) 
                    {
                        stockIndexIDRef_ = stockIndexNode.Attributes["id"].Value;
                        StockIndex ob = new StockIndex(stockIndexNode);
                        IDManager.SetID(stockIndexIDRef_, ob);
                    }
                    else if (stockIndexNode.Attributes["href"] != null)
                    {
                        stockIndexIDRef_ = stockIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stockIndex_ = new StockIndex(stockIndexNode);
                    }
                }
                else
                {
                    stockIndex_ = new StockIndex(stockIndexNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                    throw new Exception( "name_Node no exist!");
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region BasePrice_
        private XsdTypeToken basePrice_;
        public XsdTypeToken BasePrice_
        {
            get
            {
                if (this.basePrice_ != null)
                {
                    return this.basePrice_; 
                }
                else if (this.basePriceIDRef_ != null)
                {
                    basePrice_ = IDManager.getID(basePriceIDRef_) as XsdTypeToken;
                    return this.basePrice_; 
                }
                else
                {
                    throw new Exception( "basePrice_Node no exist!");
                }
            }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                }
            }
        }
        #endregion
        
        public string basePriceIDRef_ { get; set; }
        #region InterestRateIndex_
        private InterestRateIndex interestRateIndex_;
        public InterestRateIndex InterestRateIndex_
        {
            get
            {
                if (this.interestRateIndex_ != null)
                {
                    return this.interestRateIndex_; 
                }
                else if (this.interestRateIndexIDRef_ != null)
                {
                    interestRateIndex_ = IDManager.getID(interestRateIndexIDRef_) as InterestRateIndex;
                    return this.interestRateIndex_; 
                }
                else
                {
                    throw new Exception( "interestRateIndex_Node no exist!");
                }
            }
            set
            {
                if (this.interestRateIndex_ != value)
                {
                    this.interestRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string interestRateIndexIDRef_ { get; set; }
        #region StockIndex_
        private StockIndex stockIndex_;
        public StockIndex StockIndex_
        {
            get
            {
                if (this.stockIndex_ != null)
                {
                    return this.stockIndex_; 
                }
                else if (this.stockIndexIDRef_ != null)
                {
                    stockIndex_ = IDManager.getID(stockIndexIDRef_) as StockIndex;
                    return this.stockIndex_; 
                }
                else
                {
                    throw new Exception( "stockIndex_Node no exist!");
                }
            }
            set
            {
                if (this.stockIndex_ != value)
                {
                    this.stockIndex_ = value;
                }
            }
        }
        #endregion
        
        public string stockIndexIDRef_ { get; set; }
        public string choiceStr_indexType;
        
    
        
    
    }
    
}

