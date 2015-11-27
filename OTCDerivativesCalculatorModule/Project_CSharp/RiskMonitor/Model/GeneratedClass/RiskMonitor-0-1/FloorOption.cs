using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloorOption : ISerialized
    {
        public FloorOption() { }
        public FloorOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceStrNode = xmlNode.SelectSingleNode("referenceStr");
            
            if (referenceStrNode != null)
            {
                if (referenceStrNode.Attributes["href"] != null || referenceStrNode.Attributes["id"] != null) 
                {
                    if (referenceStrNode.Attributes["id"] != null) 
                    {
                        referenceStrIDRef_ = referenceStrNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceStrNode);
                        IDManager.SetID(referenceStrIDRef_, ob);
                    }
                    else if (referenceStrNode.Attributes["href"] != null)
                    {
                        referenceStrIDRef_ = referenceStrNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceStr_ = new XsdTypeToken(referenceStrNode);
                    }
                }
                else
                {
                    referenceStr_ = new XsdTypeToken(referenceStrNode);
                }
            }
            
        
            XmlNode floorRateNode = xmlNode.SelectSingleNode("floorRate");
            
            if (floorRateNode != null)
            {
                if (floorRateNode.Attributes["href"] != null || floorRateNode.Attributes["id"] != null) 
                {
                    if (floorRateNode.Attributes["id"] != null) 
                    {
                        floorRateIDRef_ = floorRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(floorRateNode);
                        IDManager.SetID(floorRateIDRef_, ob);
                    }
                    else if (floorRateNode.Attributes["href"] != null)
                    {
                        floorRateIDRef_ = floorRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floorRate_ = new XsdTypeToken(floorRateNode);
                    }
                }
                else
                {
                    floorRate_ = new XsdTypeToken(floorRateNode);
                }
            }
            
        
            XmlNode volNode = xmlNode.SelectSingleNode("vol");
            
            if (volNode != null)
            {
                if (volNode.Attributes["href"] != null || volNode.Attributes["id"] != null) 
                {
                    if (volNode.Attributes["id"] != null) 
                    {
                        volIDRef_ = volNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(volNode);
                        IDManager.SetID(volIDRef_, ob);
                    }
                    else if (volNode.Attributes["href"] != null)
                    {
                        volIDRef_ = volNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vol_ = new XsdTypeToken(volNode);
                    }
                }
                else
                {
                    vol_ = new XsdTypeToken(volNode);
                }
            }
            
        
        }
        
    
        #region ReferenceStr_
        private XsdTypeToken referenceStr_;
        public XsdTypeToken ReferenceStr_
        {
            get
            {
                if (this.referenceStr_ != null)
                {
                    return this.referenceStr_; 
                }
                else if (this.referenceStrIDRef_ != null)
                {
                    referenceStr_ = IDManager.getID(referenceStrIDRef_) as XsdTypeToken;
                    return this.referenceStr_; 
                }
                else
                {
                    throw new Exception( "referenceStr_Node no exist!");
                }
            }
            set
            {
                if (this.referenceStr_ != value)
                {
                    this.referenceStr_ = value;
                }
            }
        }
        #endregion
        
        public string referenceStrIDRef_ { get; set; }
        #region FloorRate_
        private XsdTypeToken floorRate_;
        public XsdTypeToken FloorRate_
        {
            get
            {
                if (this.floorRate_ != null)
                {
                    return this.floorRate_; 
                }
                else if (this.floorRateIDRef_ != null)
                {
                    floorRate_ = IDManager.getID(floorRateIDRef_) as XsdTypeToken;
                    return this.floorRate_; 
                }
                else
                {
                    throw new Exception( "floorRate_Node no exist!");
                }
            }
            set
            {
                if (this.floorRate_ != value)
                {
                    this.floorRate_ = value;
                }
            }
        }
        #endregion
        
        public string floorRateIDRef_ { get; set; }
        #region Vol_
        private XsdTypeToken vol_;
        public XsdTypeToken Vol_
        {
            get
            {
                if (this.vol_ != null)
                {
                    return this.vol_; 
                }
                else if (this.volIDRef_ != null)
                {
                    vol_ = IDManager.getID(volIDRef_) as XsdTypeToken;
                    return this.vol_; 
                }
                else
                {
                    throw new Exception( "vol_Node no exist!");
                }
            }
            set
            {
                if (this.vol_ != value)
                {
                    this.vol_ = value;
                }
            }
        }
        #endregion
        
        public string volIDRef_ { get; set; }
        
    
        
    
    }
    
}

