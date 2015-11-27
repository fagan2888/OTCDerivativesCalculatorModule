using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EuropeanExercise
    {
        public EuropeanExercise(XmlNode xmlNode)
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
            
        
            XmlNodeList partialExerciseNodeList = xmlNode.SelectNodes("partialExercise");
            if (partialExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partialExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partialExerciseIDRef = item.Attributes["id"].Name;
                        PartialExercise ob = PartialExercise();
                        IDManager.SetID(partialExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partialExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partialExercise = new PartialExercise(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseFeeNodeList = xmlNode.SelectNodes("exerciseFee");
            if (exerciseFeeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseFeeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseFeeIDRef = item.Attributes["id"].Name;
                        ExerciseFee ob = ExerciseFee();
                        IDManager.SetID(exerciseFeeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseFeeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseFee = new ExerciseFee(item);
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
        #region PartialExercise
        private PartialExercise partialExercise;
        public PartialExercise PartialExercise
        {
            get
            {
                if (this.partialExercise != null)
                {
                    return this.partialExercise; 
                }
                else if (this.partialExerciseIDRef != null)
                {
                    partialExercise = IDManager.getID(partialExerciseIDRef) as PartialExercise;
                    return this.partialExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partialExercise != value)
                {
                    this.partialExercise = value;
                }
            }
        }
        #endregion
        
        public string PartialExerciseIDRef { get; set; }
        #region ExerciseFee
        private ExerciseFee exerciseFee;
        public ExerciseFee ExerciseFee
        {
            get
            {
                if (this.exerciseFee != null)
                {
                    return this.exerciseFee; 
                }
                else if (this.exerciseFeeIDRef != null)
                {
                    exerciseFee = IDManager.getID(exerciseFeeIDRef) as ExerciseFee;
                    return this.exerciseFee; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseFee != value)
                {
                    this.exerciseFee = value;
                }
            }
        }
        #endregion
        
        public string ExerciseFeeIDRef { get; set; }
        
    
        
    
    }
    
}

