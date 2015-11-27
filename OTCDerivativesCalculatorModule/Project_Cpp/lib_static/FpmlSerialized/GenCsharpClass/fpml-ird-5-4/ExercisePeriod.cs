using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExercisePeriod
    {
        public ExercisePeriod(XmlNode xmlNode)
        {
            XmlNodeList earliestExerciseDateTenorNodeList = xmlNode.SelectNodes("earliestExerciseDateTenor");
            if (earliestExerciseDateTenorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in earliestExerciseDateTenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earliestExerciseDateTenorIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(earliestExerciseDateTenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earliestExerciseDateTenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        earliestExerciseDateTenor = new Period(item);
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
                        Period ob = Period();
                        IDManager.SetID(exerciseFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseFrequency = new Period(item);
                    }
                }
            }
            
        
        }
        
    
        #region EarliestExerciseDateTenor
        private Period earliestExerciseDateTenor;
        public Period EarliestExerciseDateTenor
        {
            get
            {
                if (this.earliestExerciseDateTenor != null)
                {
                    return this.earliestExerciseDateTenor; 
                }
                else if (this.earliestExerciseDateTenorIDRef != null)
                {
                    earliestExerciseDateTenor = IDManager.getID(earliestExerciseDateTenorIDRef) as Period;
                    return this.earliestExerciseDateTenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earliestExerciseDateTenor != value)
                {
                    this.earliestExerciseDateTenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region ExerciseFrequency
        private Period exerciseFrequency;
        public Period ExerciseFrequency
        {
            get
            {
                if (this.exerciseFrequency != null)
                {
                    return this.exerciseFrequency; 
                }
                else if (this.exerciseFrequencyIDRef != null)
                {
                    exerciseFrequency = IDManager.getID(exerciseFrequencyIDRef) as Period;
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
        
        public string PeriodIDRef { get; set; }
        
    
        
    
    }
    
}

