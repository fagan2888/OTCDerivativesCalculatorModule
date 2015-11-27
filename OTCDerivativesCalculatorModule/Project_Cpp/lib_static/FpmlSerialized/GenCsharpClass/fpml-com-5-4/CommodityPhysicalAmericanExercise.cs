using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalAmericanExercise
    {
        public CommodityPhysicalAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList commencementDatesNodeList = xmlNode.SelectNodes("commencementDates");
            if (commencementDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commencementDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commencementDatesIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDates ob = AdjustableOrRelativeDates();
                        IDManager.SetID(commencementDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commencementDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commencementDates = new AdjustableOrRelativeDates(item);
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
                        AdjustableOrRelativeDates ob = AdjustableOrRelativeDates();
                        IDManager.SetID(expirationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDates = new AdjustableOrRelativeDates(item);
                    }
                }
            }
            
        
            XmlNodeList relativeCommencementDatesNodeList = xmlNode.SelectNodes("relativeCommencementDates");
            if (relativeCommencementDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeCommencementDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeCommencementDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativeExpirationDates ob = CommodityRelativeExpirationDates();
                        IDManager.SetID(relativeCommencementDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeCommencementDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeCommencementDates = new CommodityRelativeExpirationDates(item);
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
            
        
            XmlNodeList latestExerciseTimeNodeList = xmlNode.SelectNodes("latestExerciseTime");
            if (latestExerciseTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in latestExerciseTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        latestExerciseTimeIDRef = item.Attributes["id"].Name;
                        PrevailingTime ob = PrevailingTime();
                        IDManager.SetID(latestExerciseTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        latestExerciseTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        latestExerciseTime = new PrevailingTime(item);
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
        
    
        #region CommencementDates
        private AdjustableOrRelativeDates commencementDates;
        public AdjustableOrRelativeDates CommencementDates
        {
            get
            {
                if (this.commencementDates != null)
                {
                    return this.commencementDates; 
                }
                else if (this.commencementDatesIDRef != null)
                {
                    commencementDates = IDManager.getID(commencementDatesIDRef) as AdjustableOrRelativeDates;
                    return this.commencementDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commencementDates != value)
                {
                    this.commencementDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDatesIDRef { get; set; }
        #region ExpirationDates
        private AdjustableOrRelativeDates expirationDates;
        public AdjustableOrRelativeDates ExpirationDates
        {
            get
            {
                if (this.expirationDates != null)
                {
                    return this.expirationDates; 
                }
                else if (this.expirationDatesIDRef != null)
                {
                    expirationDates = IDManager.getID(expirationDatesIDRef) as AdjustableOrRelativeDates;
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
        
        public string AdjustableOrRelativeDatesIDRef { get; set; }
        #region RelativeCommencementDates
        private CommodityRelativeExpirationDates relativeCommencementDates;
        public CommodityRelativeExpirationDates RelativeCommencementDates
        {
            get
            {
                if (this.relativeCommencementDates != null)
                {
                    return this.relativeCommencementDates; 
                }
                else if (this.relativeCommencementDatesIDRef != null)
                {
                    relativeCommencementDates = IDManager.getID(relativeCommencementDatesIDRef) as CommodityRelativeExpirationDates;
                    return this.relativeCommencementDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeCommencementDates != value)
                {
                    this.relativeCommencementDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativeExpirationDatesIDRef { get; set; }
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
        #region LatestExerciseTime
        private PrevailingTime latestExerciseTime;
        public PrevailingTime LatestExerciseTime
        {
            get
            {
                if (this.latestExerciseTime != null)
                {
                    return this.latestExerciseTime; 
                }
                else if (this.latestExerciseTimeIDRef != null)
                {
                    latestExerciseTime = IDManager.getID(latestExerciseTimeIDRef) as PrevailingTime;
                    return this.latestExerciseTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.latestExerciseTime != value)
                {
                    this.latestExerciseTime = value;
                }
            }
        }
        #endregion
        
        public string PrevailingTimeIDRef { get; set; }
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

