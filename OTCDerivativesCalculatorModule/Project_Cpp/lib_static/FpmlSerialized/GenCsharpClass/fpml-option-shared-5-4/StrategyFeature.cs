using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StrategyFeature
    {
        public StrategyFeature(XmlNode xmlNode)
        {
            XmlNodeList strikeSpreadNodeList = xmlNode.SelectNodes("strikeSpread");
            if (strikeSpreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeSpreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeSpreadIDRef = item.Attributes["id"].Name;
                        StrikeSpread ob = StrikeSpread();
                        IDManager.SetID(strikeSpreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeSpreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeSpread = new StrikeSpread(item);
                    }
                }
            }
            
        
            XmlNodeList calendarSpreadNodeList = xmlNode.SelectNodes("calendarSpread");
            if (calendarSpreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calendarSpreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calendarSpreadIDRef = item.Attributes["id"].Name;
                        CalendarSpread ob = CalendarSpread();
                        IDManager.SetID(calendarSpreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calendarSpreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calendarSpread = new CalendarSpread(item);
                    }
                }
            }
            
        
        }
        
    
        #region StrikeSpread
        private StrikeSpread strikeSpread;
        public StrikeSpread StrikeSpread
        {
            get
            {
                if (this.strikeSpread != null)
                {
                    return this.strikeSpread; 
                }
                else if (this.strikeSpreadIDRef != null)
                {
                    strikeSpread = IDManager.getID(strikeSpreadIDRef) as StrikeSpread;
                    return this.strikeSpread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeSpread != value)
                {
                    this.strikeSpread = value;
                }
            }
        }
        #endregion
        
        public string StrikeSpreadIDRef { get; set; }
        #region CalendarSpread
        private CalendarSpread calendarSpread;
        public CalendarSpread CalendarSpread
        {
            get
            {
                if (this.calendarSpread != null)
                {
                    return this.calendarSpread; 
                }
                else if (this.calendarSpreadIDRef != null)
                {
                    calendarSpread = IDManager.getID(calendarSpreadIDRef) as CalendarSpread;
                    return this.calendarSpread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calendarSpread != value)
                {
                    this.calendarSpread = value;
                }
            }
        }
        #endregion
        
        public string CalendarSpreadIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

