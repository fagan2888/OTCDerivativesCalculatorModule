using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableDates
    {
        public AdjustableDates(XmlNode xmlNode)
        {
            XmlNodeList unadjustedDateNodeList = xmlNode.SelectNodes("unadjustedDate");
            
            foreach (XmlNode item in unadjustedDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedDateIDRef = item.Attributes["id"].Name;
                        List<IdentifiedDate> ob = new List<IdentifiedDate>();
                        ob.Add(new IdentifiedDate(item));
                        IDManager.SetID(unadjustedDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    unadjustedDate.Add(new IdentifiedDate(item));
                    }
                }
            }
            
        
            XmlNodeList dateAdjustmentsNodeList = xmlNode.SelectNodes("dateAdjustments");
            if (dateAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(dateAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedDateNodeList = xmlNode.SelectNodes("adjustedDate");
            
            foreach (XmlNode item in adjustedDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedDateIDRef = item.Attributes["id"].Name;
                        List<IdentifiedDate> ob = new List<IdentifiedDate>();
                        ob.Add(new IdentifiedDate(item));
                        IDManager.SetID(adjustedDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    adjustedDate.Add(new IdentifiedDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedDate
        private List<IdentifiedDate> unadjustedDate;
        public List<IdentifiedDate> UnadjustedDate
        {
            get
            {
                if (this.unadjustedDate != null)
                {
                    return this.unadjustedDate; 
                }
                else if (this.unadjustedDateIDRef != null)
                {
                    unadjustedDate = IDManager.getID(unadjustedDateIDRef) as List<IdentifiedDate>;
                    return this.unadjustedDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedDate != value)
                {
                    this.unadjustedDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region DateAdjustments
        private BusinessDayAdjustments dateAdjustments;
        public BusinessDayAdjustments DateAdjustments
        {
            get
            {
                if (this.dateAdjustments != null)
                {
                    return this.dateAdjustments; 
                }
                else if (this.dateAdjustmentsIDRef != null)
                {
                    dateAdjustments = IDManager.getID(dateAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.dateAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateAdjustments != value)
                {
                    this.dateAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        #region AdjustedDate
        private List<IdentifiedDate> adjustedDate;
        public List<IdentifiedDate> AdjustedDate
        {
            get
            {
                if (this.adjustedDate != null)
                {
                    return this.adjustedDate; 
                }
                else if (this.adjustedDateIDRef != null)
                {
                    adjustedDate = IDManager.getID(adjustedDateIDRef) as List<IdentifiedDate>;
                    return this.adjustedDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedDate != value)
                {
                    this.adjustedDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}

