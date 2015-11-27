using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SharedAmericanExercise
    {
        public SharedAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList commencementDateNodeList = xmlNode.SelectNodes("commencementDate");
            if (commencementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commencementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commencementDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(commencementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commencementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commencementDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
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
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(latestExerciseTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        latestExerciseTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        latestExerciseTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList latestExerciseTimeDeterminationNodeList = xmlNode.SelectNodes("latestExerciseTimeDetermination");
            if (latestExerciseTimeDeterminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in latestExerciseTimeDeterminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        latestExerciseTimeDeterminationIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(latestExerciseTimeDeterminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        latestExerciseTimeDeterminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        latestExerciseTimeDetermination = new DeterminationMethod(item);
                    }
                }
            }
            
        
        }
        
    
        #region CommencementDate
        private AdjustableOrRelativeDate commencementDate;
        public AdjustableOrRelativeDate CommencementDate
        {
            get
            {
                if (this.commencementDate != null)
                {
                    return this.commencementDate; 
                }
                else if (this.commencementDateIDRef != null)
                {
                    commencementDate = IDManager.getID(commencementDateIDRef) as AdjustableOrRelativeDate;
                    return this.commencementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commencementDate != value)
                {
                    this.commencementDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
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
        #region LatestExerciseTime
        private BusinessCenterTime latestExerciseTime;
        public BusinessCenterTime LatestExerciseTime
        {
            get
            {
                if (this.latestExerciseTime != null)
                {
                    return this.latestExerciseTime; 
                }
                else if (this.latestExerciseTimeIDRef != null)
                {
                    latestExerciseTime = IDManager.getID(latestExerciseTimeIDRef) as BusinessCenterTime;
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
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region LatestExerciseTimeDetermination
        private DeterminationMethod latestExerciseTimeDetermination;
        public DeterminationMethod LatestExerciseTimeDetermination
        {
            get
            {
                if (this.latestExerciseTimeDetermination != null)
                {
                    return this.latestExerciseTimeDetermination; 
                }
                else if (this.latestExerciseTimeDeterminationIDRef != null)
                {
                    latestExerciseTimeDetermination = IDManager.getID(latestExerciseTimeDeterminationIDRef) as DeterminationMethod;
                    return this.latestExerciseTimeDetermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.latestExerciseTimeDetermination != value)
                {
                    this.latestExerciseTimeDetermination = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

