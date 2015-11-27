using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CapOption : ISerialized
    {
        public CapOption() { }
        public CapOption(XmlNode xmlNode)
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
            
        
            XmlNode capRateNode = xmlNode.SelectSingleNode("capRate");
            
            if (capRateNode != null)
            {
                if (capRateNode.Attributes["href"] != null || capRateNode.Attributes["id"] != null) 
                {
                    if (capRateNode.Attributes["id"] != null) 
                    {
                        capRateIDRef_ = capRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(capRateNode);
                        IDManager.SetID(capRateIDRef_, ob);
                    }
                    else if (capRateNode.Attributes["href"] != null)
                    {
                        capRateIDRef_ = capRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        capRate_ = new XsdTypeToken(capRateNode);
                    }
                }
                else
                {
                    capRate_ = new XsdTypeToken(capRateNode);
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
        #region CapRate_
        private XsdTypeToken capRate_;
        public XsdTypeToken CapRate_
        {
            get
            {
                if (this.capRate_ != null)
                {
                    return this.capRate_; 
                }
                else if (this.capRateIDRef_ != null)
                {
                    capRate_ = IDManager.getID(capRateIDRef_) as XsdTypeToken;
                    return this.capRate_; 
                }
                else
                {
                    throw new Exception( "capRate_Node no exist!");
                }
            }
            set
            {
                if (this.capRate_ != value)
                {
                    this.capRate_ = value;
                }
            }
        }
        #endregion
        
        public string capRateIDRef_ { get; set; }
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

