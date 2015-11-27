using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TimeDimension
    {
        public TimeDimension(XmlNode xmlNode)
        {
            XmlNodeList tenorNodeList = xmlNode.SelectNodes("tenor");
            if (tenorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(tenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenor = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            if (dateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        date = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region Tenor
        private Period tenor;
        public Period Tenor
        {
            get
            {
                if (this.tenor != null)
                {
                    return this.tenor; 
                }
                else if (this.tenorIDRef != null)
                {
                    tenor = IDManager.getID(tenorIDRef) as Period;
                    return this.tenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenor != value)
                {
                    this.tenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

