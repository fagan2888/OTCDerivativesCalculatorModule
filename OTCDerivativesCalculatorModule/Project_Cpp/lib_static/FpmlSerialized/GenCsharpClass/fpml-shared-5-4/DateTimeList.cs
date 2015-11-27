using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateTimeList
    {
        public DateTimeList(XmlNode xmlNode)
        {
            XmlNodeList dateTimeNodeList = xmlNode.SelectNodes("dateTime");
            
            foreach (XmlNode item in dateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = new XsdTypeDateTime();
                        ob.Add(new XsdTypeDateTime(item));
                        IDManager.SetID(dateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dateTime.Add(new XsdTypeDateTime(item));
                    }
                }
            }
            
        
        }
        
    
        #region DateTime
        private XsdTypeDateTime dateTime;
        public XsdTypeDateTime DateTime
        {
            get
            {
                if (this.dateTime != null)
                {
                    return this.dateTime; 
                }
                else if (this.dateTimeIDRef != null)
                {
                    dateTime = IDManager.getID(dateTimeIDRef) as XsdTypeDateTime;
                    return this.dateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateTime != value)
                {
                    this.dateTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        
    
        
    
    }
    
}

