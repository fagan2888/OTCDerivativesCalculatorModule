using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateRange
    {
        public DateRange(XmlNode xmlNode)
        {
            XmlNodeList unadjustedFirstDateNodeList = xmlNode.SelectNodes("unadjustedFirstDate");
            if (unadjustedFirstDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedFirstDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedFirstDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedFirstDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedFirstDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedFirstDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList unadjustedLastDateNodeList = xmlNode.SelectNodes("unadjustedLastDate");
            if (unadjustedLastDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedLastDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedLastDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedLastDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedLastDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedLastDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedFirstDate
        private XsdTypeDate unadjustedFirstDate;
        public XsdTypeDate UnadjustedFirstDate
        {
            get
            {
                if (this.unadjustedFirstDate != null)
                {
                    return this.unadjustedFirstDate; 
                }
                else if (this.unadjustedFirstDateIDRef != null)
                {
                    unadjustedFirstDate = IDManager.getID(unadjustedFirstDateIDRef) as XsdTypeDate;
                    return this.unadjustedFirstDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedFirstDate != value)
                {
                    this.unadjustedFirstDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region UnadjustedLastDate
        private XsdTypeDate unadjustedLastDate;
        public XsdTypeDate UnadjustedLastDate
        {
            get
            {
                if (this.unadjustedLastDate != null)
                {
                    return this.unadjustedLastDate; 
                }
                else if (this.unadjustedLastDateIDRef != null)
                {
                    unadjustedLastDate = IDManager.getID(unadjustedLastDateIDRef) as XsdTypeDate;
                    return this.unadjustedLastDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedLastDate != value)
                {
                    this.unadjustedLastDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

