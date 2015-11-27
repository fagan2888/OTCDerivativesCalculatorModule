using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityAmericanExercise
    {
        public CommodityAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList exercisePeriodNodeList = xmlNode.SelectNodes("exercisePeriod");
            if (exercisePeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exercisePeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exercisePeriodIDRef = item.Attributes["id"].Name;
                        CommodityExercisePeriods ob = CommodityExercisePeriods();
                        IDManager.SetID(exercisePeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exercisePeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exercisePeriod = new CommodityExercisePeriods(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseFrequencyNodeList = xmlNode.SelectNodes("exerciseFrequency");
            if (exerciseFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseFrequencyIDRef = item.Attributes["id"].Name;
                        Frequency ob = Frequency();
                        IDManager.SetID(exerciseFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseFrequency = new Frequency(item);
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
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(expirationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList multipleExerciseNodeList = xmlNode.SelectNodes("multipleExercise");
            if (multipleExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleExerciseIDRef = item.Attributes["id"].Name;
                        CommodityMultipleExercise ob = CommodityMultipleExercise();
                        IDManager.SetID(multipleExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleExercise = new CommodityMultipleExercise(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExercisePeriod
        private CommodityExercisePeriods exercisePeriod;
        public CommodityExercisePeriods ExercisePeriod
        {
            get
            {
                if (this.exercisePeriod != null)
                {
                    return this.exercisePeriod; 
                }
                else if (this.exercisePeriodIDRef != null)
                {
                    exercisePeriod = IDManager.getID(exercisePeriodIDRef) as CommodityExercisePeriods;
                    return this.exercisePeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exercisePeriod != value)
                {
                    this.exercisePeriod = value;
                }
            }
        }
        #endregion
        
        public string CommodityExercisePeriodsIDRef { get; set; }
        #region ExerciseFrequency
        private Frequency exerciseFrequency;
        public Frequency ExerciseFrequency
        {
            get
            {
                if (this.exerciseFrequency != null)
                {
                    return this.exerciseFrequency; 
                }
                else if (this.exerciseFrequencyIDRef != null)
                {
                    exerciseFrequency = IDManager.getID(exerciseFrequencyIDRef) as Frequency;
                    return this.exerciseFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseFrequency != value)
                {
                    this.exerciseFrequency = value;
                }
            }
        }
        #endregion
        
        public string FrequencyIDRef { get; set; }
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
        #region ExpirationTime
        private BusinessCenterTime expirationTime;
        public BusinessCenterTime ExpirationTime
        {
            get
            {
                if (this.expirationTime != null)
                {
                    return this.expirationTime; 
                }
                else if (this.expirationTimeIDRef != null)
                {
                    expirationTime = IDManager.getID(expirationTimeIDRef) as BusinessCenterTime;
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
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region MultipleExercise
        private CommodityMultipleExercise multipleExercise;
        public CommodityMultipleExercise MultipleExercise
        {
            get
            {
                if (this.multipleExercise != null)
                {
                    return this.multipleExercise; 
                }
                else if (this.multipleExerciseIDRef != null)
                {
                    multipleExercise = IDManager.getID(multipleExerciseIDRef) as CommodityMultipleExercise;
                    return this.multipleExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleExercise != value)
                {
                    this.multipleExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityMultipleExerciseIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

