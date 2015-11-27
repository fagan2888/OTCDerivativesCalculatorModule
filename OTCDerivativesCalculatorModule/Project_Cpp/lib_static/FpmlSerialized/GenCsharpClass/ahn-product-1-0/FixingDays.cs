using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FixingDays
    {
        public FixingDays(XmlNode xmlNode)
        {
            XmlNodeList daysNodeList = xmlNode.SelectNodes("days");
            if (daysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in daysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        daysIDRef = item.Attributes["id"].Name;
                        XsdTypeInteger ob = XsdTypeInteger();
                        IDManager.SetID(daysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        daysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        days = new XsdTypeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList monthsNodeList = xmlNode.SelectNodes("months");
            if (monthsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in monthsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        monthsIDRef = item.Attributes["id"].Name;
                        XsdTypeInteger ob = XsdTypeInteger();
                        IDManager.SetID(monthsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        monthsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        months = new XsdTypeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList yearsNodeList = xmlNode.SelectNodes("years");
            if (yearsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in yearsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        yearsIDRef = item.Attributes["id"].Name;
                        XsdTypeInteger ob = XsdTypeInteger();
                        IDManager.SetID(yearsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        yearsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        years = new XsdTypeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region Days
        private XsdTypeInteger days;
        public XsdTypeInteger Days
        {
            get
            {
                if (this.days != null)
                {
                    return this.days; 
                }
                else if (this.daysIDRef != null)
                {
                    days = IDManager.getID(daysIDRef) as XsdTypeInteger;
                    return this.days; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.days != value)
                {
                    this.days = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeIntegerIDRef { get; set; }
        #region Months
        private XsdTypeInteger months;
        public XsdTypeInteger Months
        {
            get
            {
                if (this.months != null)
                {
                    return this.months; 
                }
                else if (this.monthsIDRef != null)
                {
                    months = IDManager.getID(monthsIDRef) as XsdTypeInteger;
                    return this.months; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.months != value)
                {
                    this.months = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeIntegerIDRef { get; set; }
        #region Years
        private XsdTypeInteger years;
        public XsdTypeInteger Years
        {
            get
            {
                if (this.years != null)
                {
                    return this.years; 
                }
                else if (this.yearsIDRef != null)
                {
                    years = IDManager.getID(yearsIDRef) as XsdTypeInteger;
                    return this.years; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.years != value)
                {
                    this.years = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeIntegerIDRef { get; set; }
        public string choiceStr_fixingType;
        
    
        
    
    }
    
}

