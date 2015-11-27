using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalEuropeanExercise
    {
        public CommodityPhysicalEuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList expirationDateNodeList = xmlNode.SelectNodes("expirationDate");
            if (expirationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(expirationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList expirationDatesNodeList = xmlNode.SelectNodes("expirationDates");
            if (expirationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates2 ob = AdjustableRelativeOrPeriodicDates2();
                        IDManager.SetID(expirationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDates = new AdjustableRelativeOrPeriodicDates2(item);
                    }
                }
            }
            
        
            XmlNodeList relativeExpirationDatesNodeList = xmlNode.SelectNodes("relativeExpirationDates");
            if (relativeExpirationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeExpirationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeExpirationDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativeExpirationDates ob = CommodityRelativeExpirationDates();
                        IDManager.SetID(relativeExpirationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeExpirationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeExpirationDates = new CommodityRelativeExpirationDates(item);
                    }
                }
            }
            
        
            XmlNodeList expirationTimeNodeList = xmlNode.SelectNodes("expirationTime");
            if (expirationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationTimeIDRef = item.Attributes["id"].Name;
                        PrevailingTime ob = PrevailingTime();
                        IDManager.SetID(expirationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationTime = new PrevailingTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExpirationDate
        private AdjustableOrRelativeDate expirationDate;
        public AdjustableOrRelativeDate ExpirationDate
        {
            get
            {
                if (this.expirationDate != null)
                {
                    return this.expirationDate; 
                }
                else if (this.expirationDateIDRef != null)
                {
                    expirationDate = IDManager.getID(expirationDateIDRef) as AdjustableOrRelativeDate;
                    return this.expirationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDate != value)
                {
                    this.expirationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region ExpirationDates
        private AdjustableRelativeOrPeriodicDates2 expirationDates;
        public AdjustableRelativeOrPeriodicDates2 ExpirationDates
        {
            get
            {
                if (this.expirationDates != null)
                {
                    return this.expirationDates; 
                }
                else if (this.expirationDatesIDRef != null)
                {
                    expirationDates = IDManager.getID(expirationDatesIDRef) as AdjustableRelativeOrPeriodicDates2;
                    return this.expirationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDates != value)
                {
                    this.expirationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDates2IDRef { get; set; }
        #region RelativeExpirationDates
        private CommodityRelativeExpirationDates relativeExpirationDates;
        public CommodityRelativeExpirationDates RelativeExpirationDates
        {
            get
            {
                if (this.relativeExpirationDates != null)
                {
                    return this.relativeExpirationDates; 
                }
                else if (this.relativeExpirationDatesIDRef != null)
                {
                    relativeExpirationDates = IDManager.getID(relativeExpirationDatesIDRef) as CommodityRelativeExpirationDates;
                    return this.relativeExpirationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeExpirationDates != value)
                {
                    this.relativeExpirationDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativeExpirationDatesIDRef { get; set; }
        #region ExpirationTime
        private PrevailingTime expirationTime;
        public PrevailingTime ExpirationTime
        {
            get
            {
                if (this.expirationTime != null)
                {
                    return this.expirationTime; 
                }
                else if (this.expirationTimeIDRef != null)
                {
                    expirationTime = IDManager.getID(expirationTimeIDRef) as PrevailingTime;
                    return this.expirationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationTime != value)
                {
                    this.expirationTime = value;
                }
            }
        }
        #endregion
        
        public string PrevailingTimeIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

