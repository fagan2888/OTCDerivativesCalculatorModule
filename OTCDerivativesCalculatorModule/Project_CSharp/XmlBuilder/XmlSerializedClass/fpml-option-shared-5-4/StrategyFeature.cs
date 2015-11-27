using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StrategyFeature : ISerialized
    {
        public StrategyFeature(XmlNode xmlNode)
        {
            XmlNode strikeSpreadNode = xmlNode.SelectSingleNode("strikeSpread");
            
            if (strikeSpreadNode != null)
            {
                if (strikeSpreadNode.Attributes["href"] != null || strikeSpreadNode.Attributes["id"] != null) 
                {
                    if (strikeSpreadNode.Attributes["id"] != null) 
                    {
                        strikeSpreadIDRef_ = strikeSpreadNode.Attributes["id"].Value;
                        StrikeSpread ob = new StrikeSpread(strikeSpreadNode);
                        IDManager.SetID(strikeSpreadIDRef_, ob);
                    }
                    else if (strikeSpreadNode.Attributes["href"] != null)
                    {
                        strikeSpreadIDRef_ = strikeSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeSpread_ = new StrikeSpread(strikeSpreadNode);
                    }
                }
                else
                {
                    strikeSpread_ = new StrikeSpread(strikeSpreadNode);
                }
            }
            
        
            XmlNode calendarSpreadNode = xmlNode.SelectSingleNode("calendarSpread");
            
            if (calendarSpreadNode != null)
            {
                if (calendarSpreadNode.Attributes["href"] != null || calendarSpreadNode.Attributes["id"] != null) 
                {
                    if (calendarSpreadNode.Attributes["id"] != null) 
                    {
                        calendarSpreadIDRef_ = calendarSpreadNode.Attributes["id"].Value;
                        CalendarSpread ob = new CalendarSpread(calendarSpreadNode);
                        IDManager.SetID(calendarSpreadIDRef_, ob);
                    }
                    else if (calendarSpreadNode.Attributes["href"] != null)
                    {
                        calendarSpreadIDRef_ = calendarSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calendarSpread_ = new CalendarSpread(calendarSpreadNode);
                    }
                }
                else
                {
                    calendarSpread_ = new CalendarSpread(calendarSpreadNode);
                }
            }
            
        
        }
        
    
        #region StrikeSpread_
        private StrikeSpread strikeSpread_;
        public StrikeSpread StrikeSpread_
        {
            get
            {
                if (this.strikeSpread_ != null)
                {
                    return this.strikeSpread_; 
                }
                else if (this.strikeSpreadIDRef_ != null)
                {
                    strikeSpread_ = IDManager.getID(strikeSpreadIDRef_) as StrikeSpread;
                    return this.strikeSpread_; 
                }
                else
                {
                      return this.strikeSpread_; 
                }
            }
            set
            {
                if (this.strikeSpread_ != value)
                {
                    this.strikeSpread_ = value;
                }
            }
        }
        #endregion
        
        public string strikeSpreadIDRef_ { get; set; }
        #region CalendarSpread_
        private CalendarSpread calendarSpread_;
        public CalendarSpread CalendarSpread_
        {
            get
            {
                if (this.calendarSpread_ != null)
                {
                    return this.calendarSpread_; 
                }
                else if (this.calendarSpreadIDRef_ != null)
                {
                    calendarSpread_ = IDManager.getID(calendarSpreadIDRef_) as CalendarSpread;
                    return this.calendarSpread_; 
                }
                else
                {
                      return this.calendarSpread_; 
                }
            }
            set
            {
                if (this.calendarSpread_ != value)
                {
                    this.calendarSpread_ = value;
                }
            }
        }
        #endregion
        
        public string calendarSpreadIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

