using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Bond : ISerialized
    {
        public Bond() { }
        public Bond(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode instrumentIdNode = xmlNode.SelectSingleNode("instrumentId");
            
            if (instrumentIdNode != null)
            {
                if (instrumentIdNode.Attributes["href"] != null || instrumentIdNode.Attributes["id"] != null) 
                {
                    if (instrumentIdNode.Attributes["id"] != null) 
                    {
                        instrumentIdIDRef_ = instrumentIdNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(instrumentIdNode);
                        IDManager.SetID(instrumentIdIDRef_, ob);
                    }
                    else if (instrumentIdNode.Attributes["href"] != null)
                    {
                        instrumentIdIDRef_ = instrumentIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrumentId_ = new XsdTypeToken(instrumentIdNode);
                    }
                }
                else
                {
                    instrumentId_ = new XsdTypeToken(instrumentIdNode);
                }
            }
            
        
            XmlNode couponRateNode = xmlNode.SelectSingleNode("couponRate");
            
            if (couponRateNode != null)
            {
                if (couponRateNode.Attributes["href"] != null || couponRateNode.Attributes["id"] != null) 
                {
                    if (couponRateNode.Attributes["id"] != null) 
                    {
                        couponRateIDRef_ = couponRateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(couponRateNode);
                        IDManager.SetID(couponRateIDRef_, ob);
                    }
                    else if (couponRateNode.Attributes["href"] != null)
                    {
                        couponRateIDRef_ = couponRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponRate_ = new XsdTypeDouble(couponRateNode);
                    }
                }
                else
                {
                    couponRate_ = new XsdTypeDouble(couponRateNode);
                }
            }
            
        
            XmlNode maturityNode = xmlNode.SelectSingleNode("maturity");
            
            if (maturityNode != null)
            {
                if (maturityNode.Attributes["href"] != null || maturityNode.Attributes["id"] != null) 
                {
                    if (maturityNode.Attributes["id"] != null) 
                    {
                        maturityIDRef_ = maturityNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(maturityNode);
                        IDManager.SetID(maturityIDRef_, ob);
                    }
                    else if (maturityNode.Attributes["href"] != null)
                    {
                        maturityIDRef_ = maturityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturity_ = new XsdTypeDate(maturityNode);
                    }
                }
                else
                {
                    maturity_ = new XsdTypeDate(maturityNode);
                }
            }
            
        
        }
        
    
        #region InstrumentId_
        private XsdTypeToken instrumentId_;
        public XsdTypeToken InstrumentId_
        {
            get
            {
                if (this.instrumentId_ != null)
                {
                    return this.instrumentId_; 
                }
                else if (this.instrumentIdIDRef_ != null)
                {
                    instrumentId_ = IDManager.getID(instrumentIdIDRef_) as XsdTypeToken;
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
        #region CouponRate_
        private XsdTypeDouble couponRate_;
        public XsdTypeDouble CouponRate_
        {
            get
            {
                if (this.couponRate_ != null)
                {
                    return this.couponRate_; 
                }
                else if (this.couponRateIDRef_ != null)
                {
                    couponRate_ = IDManager.getID(couponRateIDRef_) as XsdTypeDouble;
                    return this.couponRate_; 
                }
                else
                {
                      return this.couponRate_; 
                }
            }
            set
            {
                if (this.couponRate_ != value)
                {
                    this.couponRate_ = value;
                }
            }
        }
        #endregion
        
        public string couponRateIDRef_ { get; set; }
        #region Maturity_
        private XsdTypeDate maturity_;
        public XsdTypeDate Maturity_
        {
            get
            {
                if (this.maturity_ != null)
                {
                    return this.maturity_; 
                }
                else if (this.maturityIDRef_ != null)
                {
                    maturity_ = IDManager.getID(maturityIDRef_) as XsdTypeDate;
                    return this.maturity_; 
                }
                else
                {
                      return this.maturity_; 
                }
            }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                }
            }
        }
        #endregion
        
        public string maturityIDRef_ { get; set; }
        
    
        
    
    }
    
}

