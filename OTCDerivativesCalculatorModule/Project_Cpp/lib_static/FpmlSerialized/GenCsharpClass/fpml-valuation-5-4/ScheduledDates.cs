using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ScheduledDates
    {
        public ScheduledDates(XmlNode xmlNode)
        {
            XmlNodeList scheduledDateNodeList = xmlNode.SelectNodes("scheduledDate");
            
            foreach (XmlNode item in scheduledDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scheduledDateIDRef = item.Attributes["id"].Name;
                        List<ScheduledDate> ob = new List<ScheduledDate>();
                        ob.Add(new ScheduledDate(item));
                        IDManager.SetID(scheduledDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scheduledDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    scheduledDate.Add(new ScheduledDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region ScheduledDate
        private List<ScheduledDate> scheduledDate;
        public List<ScheduledDate> ScheduledDate
        {
            get
            {
                if (this.scheduledDate != null)
                {
                    return this.scheduledDate; 
                }
                else if (this.scheduledDateIDRef != null)
                {
                    scheduledDate = IDManager.getID(scheduledDateIDRef) as List<ScheduledDate>;
                    return this.scheduledDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.scheduledDate != value)
                {
                    this.scheduledDate = value;
                }
            }
        }
        #endregion
        
        public string ScheduledDateIDRef { get; set; }
        
    
        
    
    }
    
}

