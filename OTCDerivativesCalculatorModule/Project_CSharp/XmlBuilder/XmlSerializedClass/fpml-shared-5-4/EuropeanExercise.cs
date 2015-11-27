using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EuropeanExercise : Exercise
    {
        public EuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode expirationDateNode = xmlNode.SelectSingleNode("expirationDate");
            
            if (expirationDateNode != null)
            {
                if (expirationDateNode.Attributes["href"] != null || expirationDateNode.Attributes["id"] != null) 
                {
                    if (expirationDateNode.Attributes["id"] != null) 
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(expirationDateNode);
                        IDManager.SetID(expirationDateIDRef_, ob);
                    }
                    else if (expirationDateNode.Attributes["href"] != null)
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                    }
                }
                else
                {
                    expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                }
            }
            
        
            XmlNode relevantUnderlyingDateNode = xmlNode.SelectSingleNode("relevantUnderlyingDate");
            
            if (relevantUnderlyingDateNode != null)
            {
                if (relevantUnderlyingDateNode.Attributes["href"] != null || relevantUnderlyingDateNode.Attributes["id"] != null) 
                {
                    if (relevantUnderlyingDateNode.Attributes["id"] != null) 
                    {
                        relevantUnderlyingDateIDRef_ = relevantUnderlyingDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDates ob = new AdjustableOrRelativeDates(relevantUnderlyingDateNode);
                        IDManager.SetID(relevantUnderlyingDateIDRef_, ob);
                    }
                    else if (relevantUnderlyingDateNode.Attributes["href"] != null)
                    {
                        relevantUnderlyingDateIDRef_ = relevantUnderlyingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relevantUnderlyingDate_ = new AdjustableOrRelativeDates(relevantUnderlyingDateNode);
                    }
                }
                else
                {
                    relevantUnderlyingDate_ = new AdjustableOrRelativeDates(relevantUnderlyingDateNode);
                }
            }
            
        
            XmlNode earliestExerciseTimeNode = xmlNode.SelectSingleNode("earliestExerciseTime");
            
            if (earliestExerciseTimeNode != null)
            {
                if (earliestExerciseTimeNode.Attributes["href"] != null || earliestExerciseTimeNode.Attributes["id"] != null) 
                {
                    if (earliestExerciseTimeNode.Attributes["id"] != null) 
                    {
                        earliestExerciseTimeIDRef_ = earliestExerciseTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(earliestExerciseTimeNode);
                        IDManager.SetID(earliestExerciseTimeIDRef_, ob);
                    }
                    else if (earliestExerciseTimeNode.Attributes["href"] != null)
                    {
                        earliestExerciseTimeIDRef_ = earliestExerciseTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        earliestExerciseTime_ = new BusinessCenterTime(earliestExerciseTimeNode);
                    }
                }
                else
                {
                    earliestExerciseTime_ = new BusinessCenterTime(earliestExerciseTimeNode);
                }
            }
            
        
            XmlNode expirationTimeNode = xmlNode.SelectSingleNode("expirationTime");
            
            if (expirationTimeNode != null)
            {
                if (expirationTimeNode.Attributes["href"] != null || expirationTimeNode.Attributes["id"] != null) 
                {
                    if (expirationTimeNode.Attributes["id"] != null) 
                    {
                        expirationTimeIDRef_ = expirationTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(expirationTimeNode);
                        IDManager.SetID(expirationTimeIDRef_, ob);
                    }
                    else if (expirationTimeNode.Attributes["href"] != null)
                    {
                        expirationTimeIDRef_ = expirationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationTime_ = new BusinessCenterTime(expirationTimeNode);
                    }
                }
                else
                {
                    expirationTime_ = new BusinessCenterTime(expirationTimeNode);
                }
            }
            
        
            XmlNode partialExerciseNode = xmlNode.SelectSingleNode("partialExercise");
            
            if (partialExerciseNode != null)
            {
                if (partialExerciseNode.Attributes["href"] != null || partialExerciseNode.Attributes["id"] != null) 
                {
                    if (partialExerciseNode.Attributes["id"] != null) 
                    {
                        partialExerciseIDRef_ = partialExerciseNode.Attributes["id"].Value;
                        PartialExercise ob = new PartialExercise(partialExerciseNode);
                        IDManager.SetID(partialExerciseIDRef_, ob);
                    }
                    else if (partialExerciseNode.Attributes["href"] != null)
                    {
                        partialExerciseIDRef_ = partialExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partialExercise_ = new PartialExercise(partialExerciseNode);
                    }
                }
                else
                {
                    partialExercise_ = new PartialExercise(partialExerciseNode);
                }
            }
            
        
            XmlNode exerciseFeeNode = xmlNode.SelectSingleNode("exerciseFee");
            
            if (exerciseFeeNode != null)
            {
                if (exerciseFeeNode.Attributes["href"] != null || exerciseFeeNode.Attributes["id"] != null) 
                {
                    if (exerciseFeeNode.Attributes["id"] != null) 
                    {
                        exerciseFeeIDRef_ = exerciseFeeNode.Attributes["id"].Value;
                        ExerciseFee ob = new ExerciseFee(exerciseFeeNode);
                        IDManager.SetID(exerciseFeeIDRef_, ob);
                    }
                    else if (exerciseFeeNode.Attributes["href"] != null)
                    {
                        exerciseFeeIDRef_ = exerciseFeeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseFee_ = new ExerciseFee(exerciseFeeNode);
                    }
                }
                else
                {
                    exerciseFee_ = new ExerciseFee(exerciseFeeNode);
                }
            }
            
        
        }
        
    
        #region ExpirationDate_
        private AdjustableOrRelativeDate expirationDate_;
        public AdjustableOrRelativeDate ExpirationDate_
        {
            get
            {
                if (this.expirationDate_ != null)
                {
                    return this.expirationDate_; 
                }
                else if (this.expirationDateIDRef_ != null)
                {
                    expirationDate_ = IDManager.getID(expirationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.expirationDate_; 
                }
                else
                {
                      return this.expirationDate_; 
                }
            }
            set
            {
                if (this.expirationDate_ != value)
                {
                    this.expirationDate_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateIDRef_ { get; set; }
        #region RelevantUnderlyingDate_
        private AdjustableOrRelativeDates relevantUnderlyingDate_;
        public AdjustableOrRelativeDates RelevantUnderlyingDate_
        {
            get
            {
                if (this.relevantUnderlyingDate_ != null)
                {
                    return this.relevantUnderlyingDate_; 
                }
                else if (this.relevantUnderlyingDateIDRef_ != null)
                {
                    relevantUnderlyingDate_ = IDManager.getID(relevantUnderlyingDateIDRef_) as AdjustableOrRelativeDates;
                    return this.relevantUnderlyingDate_; 
                }
                else
                {
                      return this.relevantUnderlyingDate_; 
                }
            }
            set
            {
                if (this.relevantUnderlyingDate_ != value)
                {
                    this.relevantUnderlyingDate_ = value;
                }
            }
        }
        #endregion
        
        public string relevantUnderlyingDateIDRef_ { get; set; }
        #region EarliestExerciseTime_
        private BusinessCenterTime earliestExerciseTime_;
        public BusinessCenterTime EarliestExerciseTime_
        {
            get
            {
                if (this.earliestExerciseTime_ != null)
                {
                    return this.earliestExerciseTime_; 
                }
                else if (this.earliestExerciseTimeIDRef_ != null)
                {
                    earliestExerciseTime_ = IDManager.getID(earliestExerciseTimeIDRef_) as BusinessCenterTime;
                    return this.earliestExerciseTime_; 
                }
                else
                {
                      return this.earliestExerciseTime_; 
                }
            }
            set
            {
                if (this.earliestExerciseTime_ != value)
                {
                    this.earliestExerciseTime_ = value;
                }
            }
        }
        #endregion
        
        public string earliestExerciseTimeIDRef_ { get; set; }
        #region ExpirationTime_
        private BusinessCenterTime expirationTime_;
        public BusinessCenterTime ExpirationTime_
        {
            get
            {
                if (this.expirationTime_ != null)
                {
                    return this.expirationTime_; 
                }
                else if (this.expirationTimeIDRef_ != null)
                {
                    expirationTime_ = IDManager.getID(expirationTimeIDRef_) as BusinessCenterTime;
                    return this.expirationTime_; 
                }
                else
                {
                      return this.expirationTime_; 
                }
            }
            set
            {
                if (this.expirationTime_ != value)
                {
                    this.expirationTime_ = value;
                }
            }
        }
        #endregion
        
        public string expirationTimeIDRef_ { get; set; }
        #region PartialExercise_
        private PartialExercise partialExercise_;
        public PartialExercise PartialExercise_
        {
            get
            {
                if (this.partialExercise_ != null)
                {
                    return this.partialExercise_; 
                }
                else if (this.partialExerciseIDRef_ != null)
                {
                    partialExercise_ = IDManager.getID(partialExerciseIDRef_) as PartialExercise;
                    return this.partialExercise_; 
                }
                else
                {
                      return this.partialExercise_; 
                }
            }
            set
            {
                if (this.partialExercise_ != value)
                {
                    this.partialExercise_ = value;
                }
            }
        }
        #endregion
        
        public string partialExerciseIDRef_ { get; set; }
        #region ExerciseFee_
        private ExerciseFee exerciseFee_;
        public ExerciseFee ExerciseFee_
        {
            get
            {
                if (this.exerciseFee_ != null)
                {
                    return this.exerciseFee_; 
                }
                else if (this.exerciseFeeIDRef_ != null)
                {
                    exerciseFee_ = IDManager.getID(exerciseFeeIDRef_) as ExerciseFee;
                    return this.exerciseFee_; 
                }
                else
                {
                      return this.exerciseFee_; 
                }
            }
            set
            {
                if (this.exerciseFee_ != value)
                {
                    this.exerciseFee_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseFeeIDRef_ { get; set; }
        
    
        
    
    }
    
}

