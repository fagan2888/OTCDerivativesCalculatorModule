using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExercisePeriod : ISerialized
    {
        public ExercisePeriod(XmlNode xmlNode)
        {
            XmlNode earliestExerciseDateTenorNode = xmlNode.SelectSingleNode("earliestExerciseDateTenor");
            
            if (earliestExerciseDateTenorNode != null)
            {
                if (earliestExerciseDateTenorNode.Attributes["href"] != null || earliestExerciseDateTenorNode.Attributes["id"] != null) 
                {
                    if (earliestExerciseDateTenorNode.Attributes["id"] != null) 
                    {
                        earliestExerciseDateTenorIDRef_ = earliestExerciseDateTenorNode.Attributes["id"].Value;
                        Period ob = new Period(earliestExerciseDateTenorNode);
                        IDManager.SetID(earliestExerciseDateTenorIDRef_, ob);
                    }
                    else if (earliestExerciseDateTenorNode.Attributes["href"] != null)
                    {
                        earliestExerciseDateTenorIDRef_ = earliestExerciseDateTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        earliestExerciseDateTenor_ = new Period(earliestExerciseDateTenorNode);
                    }
                }
                else
                {
                    earliestExerciseDateTenor_ = new Period(earliestExerciseDateTenorNode);
                }
            }
            
        
            XmlNode exerciseFrequencyNode = xmlNode.SelectSingleNode("exerciseFrequency");
            
            if (exerciseFrequencyNode != null)
            {
                if (exerciseFrequencyNode.Attributes["href"] != null || exerciseFrequencyNode.Attributes["id"] != null) 
                {
                    if (exerciseFrequencyNode.Attributes["id"] != null) 
                    {
                        exerciseFrequencyIDRef_ = exerciseFrequencyNode.Attributes["id"].Value;
                        Period ob = new Period(exerciseFrequencyNode);
                        IDManager.SetID(exerciseFrequencyIDRef_, ob);
                    }
                    else if (exerciseFrequencyNode.Attributes["href"] != null)
                    {
                        exerciseFrequencyIDRef_ = exerciseFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseFrequency_ = new Period(exerciseFrequencyNode);
                    }
                }
                else
                {
                    exerciseFrequency_ = new Period(exerciseFrequencyNode);
                }
            }
            
        
        }
        
    
        #region EarliestExerciseDateTenor_
        private Period earliestExerciseDateTenor_;
        public Period EarliestExerciseDateTenor_
        {
            get
            {
                if (this.earliestExerciseDateTenor_ != null)
                {
                    return this.earliestExerciseDateTenor_; 
                }
                else if (this.earliestExerciseDateTenorIDRef_ != null)
                {
                    earliestExerciseDateTenor_ = IDManager.getID(earliestExerciseDateTenorIDRef_) as Period;
                    return this.earliestExerciseDateTenor_; 
                }
                else
                {
                      return this.earliestExerciseDateTenor_; 
                }
            }
            set
            {
                if (this.earliestExerciseDateTenor_ != value)
                {
                    this.earliestExerciseDateTenor_ = value;
                }
            }
        }
        #endregion
        
        public string earliestExerciseDateTenorIDRef_ { get; set; }
        #region ExerciseFrequency_
        private Period exerciseFrequency_;
        public Period ExerciseFrequency_
        {
            get
            {
                if (this.exerciseFrequency_ != null)
                {
                    return this.exerciseFrequency_; 
                }
                else if (this.exerciseFrequencyIDRef_ != null)
                {
                    exerciseFrequency_ = IDManager.getID(exerciseFrequencyIDRef_) as Period;
                    return this.exerciseFrequency_; 
                }
                else
                {
                      return this.exerciseFrequency_; 
                }
            }
            set
            {
                if (this.exerciseFrequency_ != value)
                {
                    this.exerciseFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseFrequencyIDRef_ { get; set; }
        
    
        
    
    }
    
}

