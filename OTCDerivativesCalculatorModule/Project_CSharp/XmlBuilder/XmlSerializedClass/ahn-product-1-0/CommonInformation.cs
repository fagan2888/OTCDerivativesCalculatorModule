using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommonInformation : ISerialized
    {
        public CommonInformation(XmlNode xmlNode)
        {
            XmlNode businessDayNode = xmlNode.SelectSingleNode("businessDay");
            
            if (businessDayNode != null)
            {
                if (businessDayNode.Attributes["href"] != null || businessDayNode.Attributes["id"] != null) 
                {
                    if (businessDayNode.Attributes["id"] != null) 
                    {
                        businessDayIDRef_ = businessDayNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(businessDayNode);
                        IDManager.SetID(businessDayIDRef_, ob);
                    }
                    else if (businessDayNode.Attributes["href"] != null)
                    {
                        businessDayIDRef_ = businessDayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDay_ = new XsdTypeToken(businessDayNode);
                    }
                }
                else
                {
                    businessDay_ = new XsdTypeToken(businessDayNode);
                }
            }
            
        
            XmlNode businessDayConvenctionNode = xmlNode.SelectSingleNode("businessDayConvenction");
            
            if (businessDayConvenctionNode != null)
            {
                if (businessDayConvenctionNode.Attributes["href"] != null || businessDayConvenctionNode.Attributes["id"] != null) 
                {
                    if (businessDayConvenctionNode.Attributes["id"] != null) 
                    {
                        businessDayConvenctionIDRef_ = businessDayConvenctionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(businessDayConvenctionNode);
                        IDManager.SetID(businessDayConvenctionIDRef_, ob);
                    }
                    else if (businessDayConvenctionNode.Attributes["href"] != null)
                    {
                        businessDayConvenctionIDRef_ = businessDayConvenctionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDayConvenction_ = new XsdTypeToken(businessDayConvenctionNode);
                    }
                }
                else
                {
                    businessDayConvenction_ = new XsdTypeToken(businessDayConvenctionNode);
                }
            }
            
        
            XmlNode daycounterNode = xmlNode.SelectSingleNode("daycounter");
            
            if (daycounterNode != null)
            {
                if (daycounterNode.Attributes["href"] != null || daycounterNode.Attributes["id"] != null) 
                {
                    if (daycounterNode.Attributes["id"] != null) 
                    {
                        daycounterIDRef_ = daycounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(daycounterNode);
                        IDManager.SetID(daycounterIDRef_, ob);
                    }
                    else if (daycounterNode.Attributes["href"] != null)
                    {
                        daycounterIDRef_ = daycounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        daycounter_ = new XsdTypeToken(daycounterNode);
                    }
                }
                else
                {
                    daycounter_ = new XsdTypeToken(daycounterNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeToken(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeToken(currencyNode);
                }
            }
            
        
            XmlNode imbededOptionNode = xmlNode.SelectSingleNode("imbededOption");
            
            if (imbededOptionNode != null)
            {
                if (imbededOptionNode.Attributes["href"] != null || imbededOptionNode.Attributes["id"] != null) 
                {
                    if (imbededOptionNode.Attributes["id"] != null) 
                    {
                        imbededOptionIDRef_ = imbededOptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(imbededOptionNode);
                        IDManager.SetID(imbededOptionIDRef_, ob);
                    }
                    else if (imbededOptionNode.Attributes["href"] != null)
                    {
                        imbededOptionIDRef_ = imbededOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        imbededOption_ = new XsdTypeToken(imbededOptionNode);
                    }
                }
                else
                {
                    imbededOption_ = new XsdTypeToken(imbededOptionNode);
                }
            }
            
        
            XmlNode calendarNode = xmlNode.SelectSingleNode("calendar");
            
            if (calendarNode != null)
            {
                if (calendarNode.Attributes["href"] != null || calendarNode.Attributes["id"] != null) 
                {
                    if (calendarNode.Attributes["id"] != null) 
                    {
                        calendarIDRef_ = calendarNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calendarNode);
                        IDManager.SetID(calendarIDRef_, ob);
                    }
                    else if (calendarNode.Attributes["href"] != null)
                    {
                        calendarIDRef_ = calendarNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calendar_ = new XsdTypeToken(calendarNode);
                    }
                }
                else
                {
                    calendar_ = new XsdTypeToken(calendarNode);
                }
            }
            
        
        }
        
    
        #region BusinessDay_
        private XsdTypeToken businessDay_;
        public XsdTypeToken BusinessDay_
        {
            get
            {
                if (this.businessDay_ != null)
                {
                    return this.businessDay_; 
                }
                else if (this.businessDayIDRef_ != null)
                {
                    businessDay_ = IDManager.getID(businessDayIDRef_) as XsdTypeToken;
                    return this.businessDay_; 
                }
                else
                {
                      return this.businessDay_; 
                }
            }
            set
            {
                if (this.businessDay_ != value)
                {
                    this.businessDay_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayIDRef_ { get; set; }
        #region BusinessDayConvenction_
        private XsdTypeToken businessDayConvenction_;
        public XsdTypeToken BusinessDayConvenction_
        {
            get
            {
                if (this.businessDayConvenction_ != null)
                {
                    return this.businessDayConvenction_; 
                }
                else if (this.businessDayConvenctionIDRef_ != null)
                {
                    businessDayConvenction_ = IDManager.getID(businessDayConvenctionIDRef_) as XsdTypeToken;
                    return this.businessDayConvenction_; 
                }
                else
                {
                      return this.businessDayConvenction_; 
                }
            }
            set
            {
                if (this.businessDayConvenction_ != value)
                {
                    this.businessDayConvenction_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayConvenctionIDRef_ { get; set; }
        #region Daycounter_
        private XsdTypeToken daycounter_;
        public XsdTypeToken Daycounter_
        {
            get
            {
                if (this.daycounter_ != null)
                {
                    return this.daycounter_; 
                }
                else if (this.daycounterIDRef_ != null)
                {
                    daycounter_ = IDManager.getID(daycounterIDRef_) as XsdTypeToken;
                    return this.daycounter_; 
                }
                else
                {
                      return this.daycounter_; 
                }
            }
            set
            {
                if (this.daycounter_ != value)
                {
                    this.daycounter_ = value;
                }
            }
        }
        #endregion
        
        public string daycounterIDRef_ { get; set; }
        #region Currency_
        private XsdTypeToken currency_;
        public XsdTypeToken Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeToken;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region ImbededOption_
        private XsdTypeToken imbededOption_;
        public XsdTypeToken ImbededOption_
        {
            get
            {
                if (this.imbededOption_ != null)
                {
                    return this.imbededOption_; 
                }
                else if (this.imbededOptionIDRef_ != null)
                {
                    imbededOption_ = IDManager.getID(imbededOptionIDRef_) as XsdTypeToken;
                    return this.imbededOption_; 
                }
                else
                {
                      return this.imbededOption_; 
                }
            }
            set
            {
                if (this.imbededOption_ != value)
                {
                    this.imbededOption_ = value;
                }
            }
        }
        #endregion
        
        public string imbededOptionIDRef_ { get; set; }
        #region Calendar_
        private XsdTypeToken calendar_;
        public XsdTypeToken Calendar_
        {
            get
            {
                if (this.calendar_ != null)
                {
                    return this.calendar_; 
                }
                else if (this.calendarIDRef_ != null)
                {
                    calendar_ = IDManager.getID(calendarIDRef_) as XsdTypeToken;
                    return this.calendar_; 
                }
                else
                {
                      return this.calendar_; 
                }
            }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                }
            }
        }
        #endregion
        
        public string calendarIDRef_ { get; set; }
        
    
        
    
    }
    
}

