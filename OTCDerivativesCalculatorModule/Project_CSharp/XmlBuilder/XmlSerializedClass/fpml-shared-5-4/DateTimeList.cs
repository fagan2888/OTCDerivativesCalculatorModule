using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateTimeList : ISerialized
    {
        public DateTimeList(XmlNode xmlNode)
        {
            XmlNodeList dateTimeNodeList = xmlNode.SelectNodes("dateTime");
            
            if (dateTimeNodeList != null)
            {
                this.dateTime_ = new List<XsdTypeDateTime>();
                foreach (XmlNode item in dateTimeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dateTimeIDRef_ = item.Attributes["id"].Value;
                            dateTime_.Add(new XsdTypeDateTime(item));
                            IDManager.SetID(dateTimeIDRef_, dateTime_[dateTime_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dateTimeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dateTime_.Add(new XsdTypeDateTime(item));
                        }
                    }
                    else
                    {
                        dateTime_.Add(new XsdTypeDateTime(item));
                    }
                }
            }
            
        
        }
        
    
        #region DateTime_
        private List<XsdTypeDateTime> dateTime_;
        public List<XsdTypeDateTime> DateTime_
        {
            get
            {
                if (this.dateTime_ != null)
                {
                    return this.dateTime_; 
                }
                else if (this.dateTimeIDRef_ != null)
                {
                    return this.dateTime_; 
                }
                else
                {
                      return this.dateTime_; 
                }
            }
            set
            {
                if (this.dateTime_ != value)
                {
                    this.dateTime_ = value;
                }
            }
        }
        #endregion
        
        public string dateTimeIDRef_ { get; set; }
        
    
        
    
    }
    
}

