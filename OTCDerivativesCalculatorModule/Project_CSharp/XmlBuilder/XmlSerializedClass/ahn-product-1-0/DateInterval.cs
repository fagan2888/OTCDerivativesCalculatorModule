using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateInterval : ISerialized
    {
        public DateInterval(XmlNode xmlNode)
        {
            XmlNode firstDateNode = xmlNode.SelectSingleNode("firstDate");
            
            if (firstDateNode != null)
            {
                if (firstDateNode.Attributes["href"] != null || firstDateNode.Attributes["id"] != null) 
                {
                    if (firstDateNode.Attributes["id"] != null) 
                    {
                        firstDateIDRef_ = firstDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstDateNode);
                        IDManager.SetID(firstDateIDRef_, ob);
                    }
                    else if (firstDateNode.Attributes["href"] != null)
                    {
                        firstDateIDRef_ = firstDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstDate_ = new XsdTypeDate(firstDateNode);
                    }
                }
                else
                {
                    firstDate_ = new XsdTypeDate(firstDateNode);
                }
            }
            
        
            XmlNode lastDateNode = xmlNode.SelectSingleNode("lastDate");
            
            if (lastDateNode != null)
            {
                if (lastDateNode.Attributes["href"] != null || lastDateNode.Attributes["id"] != null) 
                {
                    if (lastDateNode.Attributes["id"] != null) 
                    {
                        lastDateIDRef_ = lastDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(lastDateNode);
                        IDManager.SetID(lastDateIDRef_, ob);
                    }
                    else if (lastDateNode.Attributes["href"] != null)
                    {
                        lastDateIDRef_ = lastDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lastDate_ = new XsdTypeDate(lastDateNode);
                    }
                }
                else
                {
                    lastDate_ = new XsdTypeDate(lastDateNode);
                }
            }
            
        
            XmlNode dateForMonthlyNode = xmlNode.SelectSingleNode("dateForMonthly");
            
            if (dateForMonthlyNode != null)
            {
                if (dateForMonthlyNode.Attributes["href"] != null || dateForMonthlyNode.Attributes["id"] != null) 
                {
                    if (dateForMonthlyNode.Attributes["id"] != null) 
                    {
                        dateForMonthlyIDRef_ = dateForMonthlyNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateForMonthlyNode);
                        IDManager.SetID(dateForMonthlyIDRef_, ob);
                    }
                    else if (dateForMonthlyNode.Attributes["href"] != null)
                    {
                        dateForMonthlyIDRef_ = dateForMonthlyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateForMonthly_ = new XsdTypeDate(dateForMonthlyNode);
                    }
                }
                else
                {
                    dateForMonthly_ = new XsdTypeDate(dateForMonthlyNode);
                }
            }
            
        
            XmlNode dayOfWeekForWeeklyNode = xmlNode.SelectSingleNode("dayOfWeekForWeekly");
            
            if (dayOfWeekForWeeklyNode != null)
            {
                if (dayOfWeekForWeeklyNode.Attributes["href"] != null || dayOfWeekForWeeklyNode.Attributes["id"] != null) 
                {
                    if (dayOfWeekForWeeklyNode.Attributes["id"] != null) 
                    {
                        dayOfWeekForWeeklyIDRef_ = dayOfWeekForWeeklyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayOfWeekForWeeklyNode);
                        IDManager.SetID(dayOfWeekForWeeklyIDRef_, ob);
                    }
                    else if (dayOfWeekForWeeklyNode.Attributes["href"] != null)
                    {
                        dayOfWeekForWeeklyIDRef_ = dayOfWeekForWeeklyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayOfWeekForWeekly_ = new XsdTypeToken(dayOfWeekForWeeklyNode);
                    }
                }
                else
                {
                    dayOfWeekForWeekly_ = new XsdTypeToken(dayOfWeekForWeeklyNode);
                }
            }
            
        
        }
        
    
        #region FirstDate_
        private XsdTypeDate firstDate_;
        public XsdTypeDate FirstDate_
        {
            get
            {
                if (this.firstDate_ != null)
                {
                    return this.firstDate_; 
                }
                else if (this.firstDateIDRef_ != null)
                {
                    firstDate_ = IDManager.getID(firstDateIDRef_) as XsdTypeDate;
                    return this.firstDate_; 
                }
                else
                {
                      return this.firstDate_; 
                }
            }
            set
            {
                if (this.firstDate_ != value)
                {
                    this.firstDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstDateIDRef_ { get; set; }
        #region LastDate_
        private XsdTypeDate lastDate_;
        public XsdTypeDate LastDate_
        {
            get
            {
                if (this.lastDate_ != null)
                {
                    return this.lastDate_; 
                }
                else if (this.lastDateIDRef_ != null)
                {
                    lastDate_ = IDManager.getID(lastDateIDRef_) as XsdTypeDate;
                    return this.lastDate_; 
                }
                else
                {
                      return this.lastDate_; 
                }
            }
            set
            {
                if (this.lastDate_ != value)
                {
                    this.lastDate_ = value;
                }
            }
        }
        #endregion
        
        public string lastDateIDRef_ { get; set; }
        #region DateForMonthly_
        private XsdTypeDate dateForMonthly_;
        public XsdTypeDate DateForMonthly_
        {
            get
            {
                if (this.dateForMonthly_ != null)
                {
                    return this.dateForMonthly_; 
                }
                else if (this.dateForMonthlyIDRef_ != null)
                {
                    dateForMonthly_ = IDManager.getID(dateForMonthlyIDRef_) as XsdTypeDate;
                    return this.dateForMonthly_; 
                }
                else
                {
                      return this.dateForMonthly_; 
                }
            }
            set
            {
                if (this.dateForMonthly_ != value)
                {
                    this.dateForMonthly_ = value;
                }
            }
        }
        #endregion
        
        public string dateForMonthlyIDRef_ { get; set; }
        #region DayOfWeekForWeekly_
        private XsdTypeToken dayOfWeekForWeekly_;
        public XsdTypeToken DayOfWeekForWeekly_
        {
            get
            {
                if (this.dayOfWeekForWeekly_ != null)
                {
                    return this.dayOfWeekForWeekly_; 
                }
                else if (this.dayOfWeekForWeeklyIDRef_ != null)
                {
                    dayOfWeekForWeekly_ = IDManager.getID(dayOfWeekForWeeklyIDRef_) as XsdTypeToken;
                    return this.dayOfWeekForWeekly_; 
                }
                else
                {
                      return this.dayOfWeekForWeekly_; 
                }
            }
            set
            {
                if (this.dayOfWeekForWeekly_ != value)
                {
                    this.dayOfWeekForWeekly_ = value;
                }
            }
        }
        #endregion
        
        public string dayOfWeekForWeeklyIDRef_ { get; set; }
        public string choiceStr_timeType;
        
    
        
    
    }
    
}

