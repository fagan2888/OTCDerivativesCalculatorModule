using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalProductComplaincePeriod
    {
        public EnvironmentalProductComplaincePeriod(XmlNode xmlNode)
        {
            XmlNodeList startYearNodeList = xmlNode.SelectNodes("startYear");
            if (startYearNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startYearNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startYearIDRef = item.Attributes["id"].Name;
                        XsdTypeGYear ob = XsdTypeGYear();
                        IDManager.SetID(startYearIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startYearIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startYear = new XsdTypeGYear(item);
                    }
                }
            }
            
        
            XmlNodeList endYearNodeList = xmlNode.SelectNodes("endYear");
            if (endYearNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endYearNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endYearIDRef = item.Attributes["id"].Name;
                        XsdTypeGYear ob = XsdTypeGYear();
                        IDManager.SetID(endYearIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endYearIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endYear = new XsdTypeGYear(item);
                    }
                }
            }
            
        
        }
        
    
        #region StartYear
        private XsdTypeGYear startYear;
        public XsdTypeGYear StartYear
        {
            get
            {
                if (this.startYear != null)
                {
                    return this.startYear; 
                }
                else if (this.startYearIDRef != null)
                {
                    startYear = IDManager.getID(startYearIDRef) as XsdTypeGYear;
                    return this.startYear; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startYear != value)
                {
                    this.startYear = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeGYearIDRef { get; set; }
        #region EndYear
        private XsdTypeGYear endYear;
        public XsdTypeGYear EndYear
        {
            get
            {
                if (this.endYear != null)
                {
                    return this.endYear; 
                }
                else if (this.endYearIDRef != null)
                {
                    endYear = IDManager.getID(endYearIDRef) as XsdTypeGYear;
                    return this.endYear; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endYear != value)
                {
                    this.endYear = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeGYearIDRef { get; set; }
        
    
        
    
    }
    
}

