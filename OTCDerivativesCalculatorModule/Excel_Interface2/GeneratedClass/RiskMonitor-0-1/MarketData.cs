using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MarketData : ISerialized
    {
        public MarketData() { }
        public MarketData(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode krcodeNode = xmlNode.SelectSingleNode("krcode");
            
            if (krcodeNode != null)
            {
                if (krcodeNode.Attributes["href"] != null || krcodeNode.Attributes["id"] != null) 
                {
                    if (krcodeNode.Attributes["id"] != null) 
                    {
                        krcodeIDRef_ = krcodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krcodeNode);
                        IDManager.SetID(krcodeIDRef_, ob);
                    }
                    else if (krcodeNode.Attributes["href"] != null)
                    {
                        krcodeIDRef_ = krcodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krcode_ = new XsdTypeToken(krcodeNode);
                    }
                }
                else
                {
                    krcode_ = new XsdTypeToken(krcodeNode);
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
            
        
            XmlNode dataValueInfoNode = xmlNode.SelectSingleNode("dataValueInfo");
            
            if (dataValueInfoNode != null)
            {
                if (dataValueInfoNode.Attributes["href"] != null || dataValueInfoNode.Attributes["id"] != null) 
                {
                    if (dataValueInfoNode.Attributes["id"] != null) 
                    {
                        dataValueInfoIDRef_ = dataValueInfoNode.Attributes["id"].Value;
                        DataValueInfo ob = new DataValueInfo(dataValueInfoNode);
                        IDManager.SetID(dataValueInfoIDRef_, ob);
                    }
                    else if (dataValueInfoNode.Attributes["href"] != null)
                    {
                        dataValueInfoIDRef_ = dataValueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dataValueInfo_ = new DataValueInfo(dataValueInfoNode);
                    }
                }
                else
                {
                    dataValueInfo_ = new DataValueInfo(dataValueInfoNode);
                }
            }
            
        
        }
        
    
        #region Krcode_
        private XsdTypeToken krcode_;
        public XsdTypeToken Krcode_
        {
            get
            {
                if (this.krcode_ != null)
                {
                    return this.krcode_; 
                }
                else if (this.krcodeIDRef_ != null)
                {
                    krcode_ = IDManager.getID(krcodeIDRef_) as XsdTypeToken;
                    return this.krcode_; 
                }
                else
                {
                    throw new Exception( "krcode_Node no exist!");
                }
            }
            set
            {
                if (this.krcode_ != value)
                {
                    this.krcode_ = value;
                }
            }
        }
        #endregion
        
        public string krcodeIDRef_ { get; set; }
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
        #region DataValueInfo_
        private DataValueInfo dataValueInfo_;
        public DataValueInfo DataValueInfo_
        {
            get
            {
                if (this.dataValueInfo_ != null)
                {
                    return this.dataValueInfo_; 
                }
                else if (this.dataValueInfoIDRef_ != null)
                {
                    dataValueInfo_ = IDManager.getID(dataValueInfoIDRef_) as DataValueInfo;
                    return this.dataValueInfo_; 
                }
                else
                {
                    throw new Exception( "dataValueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.dataValueInfo_ != value)
                {
                    this.dataValueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string dataValueInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

