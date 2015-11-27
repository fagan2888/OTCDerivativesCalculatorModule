using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommonInformation
    {
        public CommonInformation(XmlNode xmlNode)
        {
            XmlNodeList businessDayNodeList = xmlNode.SelectNodes("businessDay");
            if (businessDayNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDayIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(businessDayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDay = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList businessDayConvenctionNodeList = xmlNode.SelectNodes("businessDayConvenction");
            if (businessDayConvenctionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDayConvenctionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDayConvenctionIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(businessDayConvenctionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDayConvenctionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDayConvenction = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList daycounterNodeList = xmlNode.SelectNodes("daycounter");
            if (daycounterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in daycounterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        daycounterIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(daycounterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        daycounterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        daycounter = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList currencyNodeList = xmlNode.SelectNodes("currency");
            if (currencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList imbededOptionNodeList = xmlNode.SelectNodes("imbededOption");
            if (imbededOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in imbededOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        imbededOptionIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(imbededOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        imbededOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        imbededOption = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList calendarNodeList = xmlNode.SelectNodes("calendar");
            if (calendarNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calendarNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calendarIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(calendarIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calendarIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calendar = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDay
        private XsdTypeToken businessDay;
        public XsdTypeToken BusinessDay
        {
            get
            {
                if (this.businessDay != null)
                {
                    return this.businessDay; 
                }
                else if (this.businessDayIDRef != null)
                {
                    businessDay = IDManager.getID(businessDayIDRef) as XsdTypeToken;
                    return this.businessDay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDay != value)
                {
                    this.businessDay = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region BusinessDayConvenction
        private XsdTypeToken businessDayConvenction;
        public XsdTypeToken BusinessDayConvenction
        {
            get
            {
                if (this.businessDayConvenction != null)
                {
                    return this.businessDayConvenction; 
                }
                else if (this.businessDayConvenctionIDRef != null)
                {
                    businessDayConvenction = IDManager.getID(businessDayConvenctionIDRef) as XsdTypeToken;
                    return this.businessDayConvenction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDayConvenction != value)
                {
                    this.businessDayConvenction = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Daycounter
        private XsdTypeToken daycounter;
        public XsdTypeToken Daycounter
        {
            get
            {
                if (this.daycounter != null)
                {
                    return this.daycounter; 
                }
                else if (this.daycounterIDRef != null)
                {
                    daycounter = IDManager.getID(daycounterIDRef) as XsdTypeToken;
                    return this.daycounter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.daycounter != value)
                {
                    this.daycounter = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Currency
        private XsdTypeToken currency;
        public XsdTypeToken Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as XsdTypeToken;
                    return this.currency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region ImbededOption
        private XsdTypeToken imbededOption;
        public XsdTypeToken ImbededOption
        {
            get
            {
                if (this.imbededOption != null)
                {
                    return this.imbededOption; 
                }
                else if (this.imbededOptionIDRef != null)
                {
                    imbededOption = IDManager.getID(imbededOptionIDRef) as XsdTypeToken;
                    return this.imbededOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.imbededOption != value)
                {
                    this.imbededOption = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Calendar
        private XsdTypeToken calendar;
        public XsdTypeToken Calendar
        {
            get
            {
                if (this.calendar != null)
                {
                    return this.calendar; 
                }
                else if (this.calendarIDRef != null)
                {
                    calendar = IDManager.getID(calendarIDRef) as XsdTypeToken;
                    return this.calendar; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calendar != value)
                {
                    this.calendar = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        
    
        
    
    }
    
}

