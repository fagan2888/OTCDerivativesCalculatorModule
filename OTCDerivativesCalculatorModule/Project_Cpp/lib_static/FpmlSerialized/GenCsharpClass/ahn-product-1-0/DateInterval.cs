using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateInterval
    {
        public DateInterval(XmlNode xmlNode)
        {
            XmlNodeList firstDateNodeList = xmlNode.SelectNodes("firstDate");
            if (firstDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList lastDateNodeList = xmlNode.SelectNodes("lastDate");
            if (lastDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lastDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lastDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(lastDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lastDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lastDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList dateForMonthlyNodeList = xmlNode.SelectNodes("dateForMonthly");
            if (dateForMonthlyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateForMonthlyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateForMonthlyIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateForMonthlyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateForMonthlyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateForMonthly = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList dayOfWeekForWeeklyNodeList = xmlNode.SelectNodes("dayOfWeekForWeekly");
            if (dayOfWeekForWeeklyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayOfWeekForWeeklyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayOfWeekForWeeklyIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(dayOfWeekForWeeklyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayOfWeekForWeeklyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayOfWeekForWeekly = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region FirstDate
        private XsdTypeDate firstDate;
        public XsdTypeDate FirstDate
        {
            get
            {
                if (this.firstDate != null)
                {
                    return this.firstDate; 
                }
                else if (this.firstDateIDRef != null)
                {
                    firstDate = IDManager.getID(firstDateIDRef) as XsdTypeDate;
                    return this.firstDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstDate != value)
                {
                    this.firstDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region LastDate
        private XsdTypeDate lastDate;
        public XsdTypeDate LastDate
        {
            get
            {
                if (this.lastDate != null)
                {
                    return this.lastDate; 
                }
                else if (this.lastDateIDRef != null)
                {
                    lastDate = IDManager.getID(lastDateIDRef) as XsdTypeDate;
                    return this.lastDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lastDate != value)
                {
                    this.lastDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region DateForMonthly
        private XsdTypeDate dateForMonthly;
        public XsdTypeDate DateForMonthly
        {
            get
            {
                if (this.dateForMonthly != null)
                {
                    return this.dateForMonthly; 
                }
                else if (this.dateForMonthlyIDRef != null)
                {
                    dateForMonthly = IDManager.getID(dateForMonthlyIDRef) as XsdTypeDate;
                    return this.dateForMonthly; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateForMonthly != value)
                {
                    this.dateForMonthly = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region DayOfWeekForWeekly
        private XsdTypeToken dayOfWeekForWeekly;
        public XsdTypeToken DayOfWeekForWeekly
        {
            get
            {
                if (this.dayOfWeekForWeekly != null)
                {
                    return this.dayOfWeekForWeekly; 
                }
                else if (this.dayOfWeekForWeeklyIDRef != null)
                {
                    dayOfWeekForWeekly = IDManager.getID(dayOfWeekForWeeklyIDRef) as XsdTypeToken;
                    return this.dayOfWeekForWeekly; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayOfWeekForWeekly != value)
                {
                    this.dayOfWeekForWeekly = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        public string choiceStr_timeType;
        
    
        
    
    }
    
}

