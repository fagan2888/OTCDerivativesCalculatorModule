using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BermudaExercise
    {
        public BermudaExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList bermudaExerciseDatesNodeList = xmlNode.SelectNodes("bermudaExerciseDates");
            if (bermudaExerciseDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bermudaExerciseDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bermudaExerciseDatesIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDates ob = AdjustableOrRelativeDates();
                        IDManager.SetID(bermudaExerciseDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bermudaExerciseDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bermudaExerciseDates = new AdjustableOrRelativeDates(item);
                    }
                }
            }
            
        
            XmlNodeList relevantUnderlyingDateNodeList = xmlNode.SelectNodes("relevantUnderlyingDate");
            if (relevantUnderlyingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relevantUnderlyingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relevantUnderlyingDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDates ob = AdjustableOrRelativeDates();
                        IDManager.SetID(relevantUnderlyingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relevantUnderlyingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relevantUnderlyingDate = new AdjustableOrRelativeDates(item);
                    }
                }
            }
            
        
            XmlNodeList earliestExerciseTimeNodeList = xmlNode.SelectNodes("earliestExerciseTime");
            if (earliestExerciseTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in earliestExerciseTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earliestExerciseTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(earliestExerciseTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earliestExerciseTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        earliestExerciseTime = new BusinessCenterTime(item);
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
                        MultipleExercise ob = MultipleExercise();
                        IDManager.SetID(multipleExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleExercise = new MultipleExercise(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseFeeScheduleNodeList = xmlNode.SelectNodes("exerciseFeeSchedule");
            if (exerciseFeeScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseFeeScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseFeeScheduleIDRef = item.Attributes["id"].Name;
                        ExerciseFeeSchedule ob = ExerciseFeeSchedule();
                        IDManager.SetID(exerciseFeeScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseFeeScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseFeeSchedule = new ExerciseFeeSchedule(item);
                    }
                }
            }
            
        
        }
        
    
        #region BermudaExerciseDates
        private AdjustableOrRelativeDates bermudaExerciseDates;
        public AdjustableOrRelativeDates BermudaExerciseDates
        {
            get
            {
                if (this.bermudaExerciseDates != null)
                {
                    return this.bermudaExerciseDates; 
                }
                else if (this.bermudaExerciseDatesIDRef != null)
                {
                    bermudaExerciseDates = IDManager.getID(bermudaExerciseDatesIDRef) as AdjustableOrRelativeDates;
                    return this.bermudaExerciseDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bermudaExerciseDates != value)
                {
                    this.bermudaExerciseDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDatesIDRef { get; set; }
        #region RelevantUnderlyingDate
        private AdjustableOrRelativeDates relevantUnderlyingDate;
        public AdjustableOrRelativeDates RelevantUnderlyingDate
        {
            get
            {
                if (this.relevantUnderlyingDate != null)
                {
                    return this.relevantUnderlyingDate; 
                }
                else if (this.relevantUnderlyingDateIDRef != null)
                {
                    relevantUnderlyingDate = IDManager.getID(relevantUnderlyingDateIDRef) as AdjustableOrRelativeDates;
                    return this.relevantUnderlyingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relevantUnderlyingDate != value)
                {
                    this.relevantUnderlyingDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDatesIDRef { get; set; }
        #region EarliestExerciseTime
        private BusinessCenterTime earliestExerciseTime;
        public BusinessCenterTime EarliestExerciseTime
        {
            get
            {
                if (this.earliestExerciseTime != null)
                {
                    return this.earliestExerciseTime; 
                }
                else if (this.earliestExerciseTimeIDRef != null)
                {
                    earliestExerciseTime = IDManager.getID(earliestExerciseTimeIDRef) as BusinessCenterTime;
                    return this.earliestExerciseTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earliestExerciseTime != value)
                {
                    this.earliestExerciseTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
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
        private MultipleExercise multipleExercise;
        public MultipleExercise MultipleExercise
        {
            get
            {
                if (this.multipleExercise != null)
                {
                    return this.multipleExercise; 
                }
                else if (this.multipleExerciseIDRef != null)
                {
                    multipleExercise = IDManager.getID(multipleExerciseIDRef) as MultipleExercise;
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
        
        public string MultipleExerciseIDRef { get; set; }
        #region ExerciseFeeSchedule
        private ExerciseFeeSchedule exerciseFeeSchedule;
        public ExerciseFeeSchedule ExerciseFeeSchedule
        {
            get
            {
                if (this.exerciseFeeSchedule != null)
                {
                    return this.exerciseFeeSchedule; 
                }
                else if (this.exerciseFeeScheduleIDRef != null)
                {
                    exerciseFeeSchedule = IDManager.getID(exerciseFeeScheduleIDRef) as ExerciseFeeSchedule;
                    return this.exerciseFeeSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseFeeSchedule != value)
                {
                    this.exerciseFeeSchedule = value;
                }
            }
        }
        #endregion
        
        public string ExerciseFeeScheduleIDRef { get; set; }
        
    
        
    
    }
    
}

