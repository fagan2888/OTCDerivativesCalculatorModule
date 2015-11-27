using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnderylingResult : ISerialized
    {
        public UnderylingResult() { }
        public UnderylingResult(XmlNode xmlNode)
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
            
        
            XmlNode gbmGreekInfoResultNode = xmlNode.SelectSingleNode("gbmGreekInfoResult");
            
            if (gbmGreekInfoResultNode != null)
            {
                if (gbmGreekInfoResultNode.Attributes["href"] != null || gbmGreekInfoResultNode.Attributes["id"] != null) 
                {
                    if (gbmGreekInfoResultNode.Attributes["id"] != null) 
                    {
                        gbmGreekInfoResultIDRef_ = gbmGreekInfoResultNode.Attributes["id"].Value;
                        GbmGreekInfoResult ob = new GbmGreekInfoResult(gbmGreekInfoResultNode);
                        IDManager.SetID(gbmGreekInfoResultIDRef_, ob);
                    }
                    else if (gbmGreekInfoResultNode.Attributes["href"] != null)
                    {
                        gbmGreekInfoResultIDRef_ = gbmGreekInfoResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gbmGreekInfoResult_ = new GbmGreekInfoResult(gbmGreekInfoResultNode);
                    }
                }
                else
                {
                    gbmGreekInfoResult_ = new GbmGreekInfoResult(gbmGreekInfoResultNode);
                }
            }
            
        
            XmlNode hullWhiteGreekInfoResultNode = xmlNode.SelectSingleNode("hullWhiteGreekInfoResult");
            
            if (hullWhiteGreekInfoResultNode != null)
            {
                if (hullWhiteGreekInfoResultNode.Attributes["href"] != null || hullWhiteGreekInfoResultNode.Attributes["id"] != null) 
                {
                    if (hullWhiteGreekInfoResultNode.Attributes["id"] != null) 
                    {
                        hullWhiteGreekInfoResultIDRef_ = hullWhiteGreekInfoResultNode.Attributes["id"].Value;
                        HullWhiteGreekInfoResult ob = new HullWhiteGreekInfoResult(hullWhiteGreekInfoResultNode);
                        IDManager.SetID(hullWhiteGreekInfoResultIDRef_, ob);
                    }
                    else if (hullWhiteGreekInfoResultNode.Attributes["href"] != null)
                    {
                        hullWhiteGreekInfoResultIDRef_ = hullWhiteGreekInfoResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hullWhiteGreekInfoResult_ = new HullWhiteGreekInfoResult(hullWhiteGreekInfoResultNode);
                    }
                }
                else
                {
                    hullWhiteGreekInfoResult_ = new HullWhiteGreekInfoResult(hullWhiteGreekInfoResultNode);
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
        #region GbmGreekInfoResult_
        private GbmGreekInfoResult gbmGreekInfoResult_;
        public GbmGreekInfoResult GbmGreekInfoResult_
        {
            get
            {
                if (this.gbmGreekInfoResult_ != null)
                {
                    return this.gbmGreekInfoResult_; 
                }
                else if (this.gbmGreekInfoResultIDRef_ != null)
                {
                    gbmGreekInfoResult_ = IDManager.getID(gbmGreekInfoResultIDRef_) as GbmGreekInfoResult;
                    return this.gbmGreekInfoResult_; 
                }
                else
                {
                    throw new Exception( "gbmGreekInfoResult_Node no exist!");
                }
            }
            set
            {
                if (this.gbmGreekInfoResult_ != value)
                {
                    this.gbmGreekInfoResult_ = value;
                }
            }
        }
        #endregion
        
        public string gbmGreekInfoResultIDRef_ { get; set; }
        #region HullWhiteGreekInfoResult_
        private HullWhiteGreekInfoResult hullWhiteGreekInfoResult_;
        public HullWhiteGreekInfoResult HullWhiteGreekInfoResult_
        {
            get
            {
                if (this.hullWhiteGreekInfoResult_ != null)
                {
                    return this.hullWhiteGreekInfoResult_; 
                }
                else if (this.hullWhiteGreekInfoResultIDRef_ != null)
                {
                    hullWhiteGreekInfoResult_ = IDManager.getID(hullWhiteGreekInfoResultIDRef_) as HullWhiteGreekInfoResult;
                    return this.hullWhiteGreekInfoResult_; 
                }
                else
                {
                    throw new Exception( "hullWhiteGreekInfoResult_Node no exist!");
                }
            }
            set
            {
                if (this.hullWhiteGreekInfoResult_ != value)
                {
                    this.hullWhiteGreekInfoResult_ = value;
                }
            }
        }
        #endregion
        
        public string hullWhiteGreekInfoResultIDRef_ { get; set; }
        public string choiceStr_underylingGreekType;
        
    
        
    
    }
    
}

