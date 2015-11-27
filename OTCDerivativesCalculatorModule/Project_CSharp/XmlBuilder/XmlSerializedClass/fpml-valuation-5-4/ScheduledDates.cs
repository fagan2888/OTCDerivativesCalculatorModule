using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ScheduledDates : ISerialized
    {
        public ScheduledDates(XmlNode xmlNode)
        {
            XmlNodeList scheduledDateNodeList = xmlNode.SelectNodes("scheduledDate");
            
            if (scheduledDateNodeList != null)
            {
                this.scheduledDate_ = new List<ScheduledDate>();
                foreach (XmlNode item in scheduledDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            scheduledDateIDRef_ = item.Attributes["id"].Value;
                            scheduledDate_.Add(new ScheduledDate(item));
                            IDManager.SetID(scheduledDateIDRef_, scheduledDate_[scheduledDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            scheduledDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        scheduledDate_.Add(new ScheduledDate(item));
                        }
                    }
                    else
                    {
                        scheduledDate_.Add(new ScheduledDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region ScheduledDate_
        private List<ScheduledDate> scheduledDate_;
        public List<ScheduledDate> ScheduledDate_
        {
            get
            {
                if (this.scheduledDate_ != null)
                {
                    return this.scheduledDate_; 
                }
                else if (this.scheduledDateIDRef_ != null)
                {
                    return this.scheduledDate_; 
                }
                else
                {
                      return this.scheduledDate_; 
                }
            }
            set
            {
                if (this.scheduledDate_ != value)
                {
                    this.scheduledDate_ = value;
                }
            }
        }
        #endregion
        
        public string scheduledDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

