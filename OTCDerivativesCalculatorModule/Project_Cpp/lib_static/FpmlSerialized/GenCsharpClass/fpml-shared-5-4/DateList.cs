using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateList
    {
        public DateList(XmlNode xmlNode)
        {
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = new XsdTypeDate();
                        ob.Add(new XsdTypeDate(item));
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    date.Add(new XsdTypeDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region Date
        private XsdTypeDate date;
        public XsdTypeDate Date
        {
            get
            {
                if (this.date != null)
                {
                    return this.date; 
                }
                else if (this.dateIDRef != null)
                {
                    date = IDManager.getID(dateIDRef) as XsdTypeDate;
                    return this.date; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.date != value)
                {
                    this.date = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

