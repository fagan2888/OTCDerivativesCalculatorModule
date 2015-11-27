using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AmericanExercise : Exercise
    {
        public AmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode commencementDateNode = xmlNode.SelectSingleNode("commencementDate");
            
            if (commencementDateNode != null)
            {
                if (commencementDateNode.Attributes["href"] != null || commencementDateNode.Attributes["id"] != null) 
                {
                    if (commencementDateNode.Attributes["id"] != null) 
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(commencementDateNode);
                        IDManager.SetID(commencementDateIDRef_, ob);
                    }
                    else if (commencementDateNode.Attributes["href"] != null)
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                    }
                }
                else
                {
                    commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                }
            }
            
        
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
            
        
            XmlNode latestExerciseTimeNode = xmlNode.SelectSingleNode("latestExerciseTime");
            
            if (latestExerciseTimeNode != null)
            {
                if (latestExerciseTimeNode.Attributes["href"] != null || latestExerciseTimeNode.Attributes["id"] != null) 
                {
                    if (latestExerciseTimeNode.Attributes["id"] != null) 
                    {
                        latestExerciseTimeIDRef_ = latestExerciseTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(latestExerciseTimeNode);
                        IDManager.SetID(latestExerciseTimeIDRef_, ob);
                    }
                    else if (latestExerciseTimeNode.Attributes["href"] != null)
                    {
                        latestExerciseTimeIDRef_ = latestExerciseTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        latestExerciseTime_ = new BusinessCenterTime(latestExerciseTimeNode);
                    }
                }
                else
                {
                    latestExerciseTime_ = new BusinessCenterTime(latestExerciseTimeNode);
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
            
        
            XmlNode multipleExerciseNode = xmlNode.SelectSingleNode("multipleExercise");
            
            if (multipleExerciseNode != null)
            {
                if (multipleExerciseNode.Attributes["href"] != null || multipleExerciseNode.Attributes["id"] != null) 
                {
                    if (multipleExerciseNode.Attributes["id"] != null) 
                    {
                        multipleExerciseIDRef_ = multipleExerciseNode.Attributes["id"].Value;
                        MultipleExercise ob = new MultipleExercise(multipleExerciseNode);
                        IDManager.SetID(multipleExerciseIDRef_, ob);
                    }
                    else if (multipleExerciseNode.Attributes["href"] != null)
                    {
                        multipleExerciseIDRef_ = multipleExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleExercise_ = new MultipleExercise(multipleExerciseNode);
                    }
                }
                else
                {
                    multipleExercise_ = new MultipleExercise(multipleExerciseNode);
                }
            }
            
        
            XmlNode exerciseFeeScheduleNode = xmlNode.SelectSingleNode("exerciseFeeSchedule");
            
            if (exerciseFeeScheduleNode != null)
            {
                if (exerciseFeeScheduleNode.Attributes["href"] != null || exerciseFeeScheduleNode.Attributes["id"] != null) 
                {
                    if (exerciseFeeScheduleNode.Attributes["id"] != null) 
                    {
                        exerciseFeeScheduleIDRef_ = exerciseFeeScheduleNode.Attributes["id"].Value;
                        ExerciseFeeSchedule ob = new ExerciseFeeSchedule(exerciseFeeScheduleNode);
                        IDManager.SetID(exerciseFeeScheduleIDRef_, ob);
                    }
                    else if (exerciseFeeScheduleNode.Attributes["href"] != null)
                    {
                        exerciseFeeScheduleIDRef_ = exerciseFeeScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseFeeSchedule_ = new ExerciseFeeSchedule(exerciseFeeScheduleNode);
                    }
                }
                else
                {
                    exerciseFeeSchedule_ = new ExerciseFeeSchedule(exerciseFeeScheduleNode);
                }
            }
            
        
        }
        
    
        #region CommencementDate_
        private AdjustableOrRelativeDate commencementDate_;
        public AdjustableOrRelativeDate CommencementDate_
        {
            get
            {
                if (this.commencementDate_ != null)
                {
                    return this.commencementDate_; 
                }
                else if (this.commencementDateIDRef_ != null)
                {
                    commencementDate_ = IDManager.getID(commencementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.commencementDate_; 
                }
                else
                {
                      return this.commencementDate_; 
                }
            }
            set
            {
                if (this.commencementDate_ != value)
                {
                    this.commencementDate_ = value;
                }
            }
        }
        #endregion
        
        public string commencementDateIDRef_ { get; set; }
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
        #region LatestExerciseTime_
        private BusinessCenterTime latestExerciseTime_;
        public BusinessCenterTime LatestExerciseTime_
        {
            get
            {
                if (this.latestExerciseTime_ != null)
                {
                    return this.latestExerciseTime_; 
                }
                else if (this.latestExerciseTimeIDRef_ != null)
                {
                    latestExerciseTime_ = IDManager.getID(latestExerciseTimeIDRef_) as BusinessCenterTime;
                    return this.latestExerciseTime_; 
                }
                else
                {
                      return this.latestExerciseTime_; 
                }
            }
            set
            {
                if (this.latestExerciseTime_ != value)
                {
                    this.latestExerciseTime_ = value;
                }
            }
        }
        #endregion
        
        public string latestExerciseTimeIDRef_ { get; set; }
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
        #region MultipleExercise_
        private MultipleExercise multipleExercise_;
        public MultipleExercise MultipleExercise_
        {
            get
            {
                if (this.multipleExercise_ != null)
                {
                    return this.multipleExercise_; 
                }
                else if (this.multipleExerciseIDRef_ != null)
                {
                    multipleExercise_ = IDManager.getID(multipleExerciseIDRef_) as MultipleExercise;
                    return this.multipleExercise_; 
                }
                else
                {
                      return this.multipleExercise_; 
                }
            }
            set
            {
                if (this.multipleExercise_ != value)
                {
                    this.multipleExercise_ = value;
                }
            }
        }
        #endregion
        
        public string multipleExerciseIDRef_ { get; set; }
        #region ExerciseFeeSchedule_
        private ExerciseFeeSchedule exerciseFeeSchedule_;
        public ExerciseFeeSchedule ExerciseFeeSchedule_
        {
            get
            {
                if (this.exerciseFeeSchedule_ != null)
                {
                    return this.exerciseFeeSchedule_; 
                }
                else if (this.exerciseFeeScheduleIDRef_ != null)
                {
                    exerciseFeeSchedule_ = IDManager.getID(exerciseFeeScheduleIDRef_) as ExerciseFeeSchedule;
                    return this.exerciseFeeSchedule_; 
                }
                else
                {
                      return this.exerciseFeeSchedule_; 
                }
            }
            set
            {
                if (this.exerciseFeeSchedule_ != value)
                {
                    this.exerciseFeeSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseFeeScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}
