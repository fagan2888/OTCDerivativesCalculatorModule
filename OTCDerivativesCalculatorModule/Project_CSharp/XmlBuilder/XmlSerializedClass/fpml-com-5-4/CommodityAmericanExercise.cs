using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityAmericanExercise : Exercise
    {
        public CommodityAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode exercisePeriodNode = xmlNode.SelectSingleNode("exercisePeriod");
            
            if (exercisePeriodNode != null)
            {
                if (exercisePeriodNode.Attributes["href"] != null || exercisePeriodNode.Attributes["id"] != null) 
                {
                    if (exercisePeriodNode.Attributes["id"] != null) 
                    {
                        exercisePeriodIDRef_ = exercisePeriodNode.Attributes["id"].Value;
                        CommodityExercisePeriods ob = new CommodityExercisePeriods(exercisePeriodNode);
                        IDManager.SetID(exercisePeriodIDRef_, ob);
                    }
                    else if (exercisePeriodNode.Attributes["href"] != null)
                    {
                        exercisePeriodIDRef_ = exercisePeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exercisePeriod_ = new CommodityExercisePeriods(exercisePeriodNode);
                    }
                }
                else
                {
                    exercisePeriod_ = new CommodityExercisePeriods(exercisePeriodNode);
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
                        Frequency ob = new Frequency(exerciseFrequencyNode);
                        IDManager.SetID(exerciseFrequencyIDRef_, ob);
                    }
                    else if (exerciseFrequencyNode.Attributes["href"] != null)
                    {
                        exerciseFrequencyIDRef_ = exerciseFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseFrequency_ = new Frequency(exerciseFrequencyNode);
                    }
                }
                else
                {
                    exerciseFrequency_ = new Frequency(exerciseFrequencyNode);
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
            
        
            XmlNode latestExerciseTimeDeterminationNode = xmlNode.SelectSingleNode("latestExerciseTimeDetermination");
            
            if (latestExerciseTimeDeterminationNode != null)
            {
                if (latestExerciseTimeDeterminationNode.Attributes["href"] != null || latestExerciseTimeDeterminationNode.Attributes["id"] != null) 
                {
                    if (latestExerciseTimeDeterminationNode.Attributes["id"] != null) 
                    {
                        latestExerciseTimeDeterminationIDRef_ = latestExerciseTimeDeterminationNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(latestExerciseTimeDeterminationNode);
                        IDManager.SetID(latestExerciseTimeDeterminationIDRef_, ob);
                    }
                    else if (latestExerciseTimeDeterminationNode.Attributes["href"] != null)
                    {
                        latestExerciseTimeDeterminationIDRef_ = latestExerciseTimeDeterminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        latestExerciseTimeDetermination_ = new DeterminationMethod(latestExerciseTimeDeterminationNode);
                    }
                }
                else
                {
                    latestExerciseTimeDetermination_ = new DeterminationMethod(latestExerciseTimeDeterminationNode);
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
                        CommodityMultipleExercise ob = new CommodityMultipleExercise(multipleExerciseNode);
                        IDManager.SetID(multipleExerciseIDRef_, ob);
                    }
                    else if (multipleExerciseNode.Attributes["href"] != null)
                    {
                        multipleExerciseIDRef_ = multipleExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleExercise_ = new CommodityMultipleExercise(multipleExerciseNode);
                    }
                }
                else
                {
                    multipleExercise_ = new CommodityMultipleExercise(multipleExerciseNode);
                }
            }
            
        
        }
        
    
        #region ExercisePeriod_
        private CommodityExercisePeriods exercisePeriod_;
        public CommodityExercisePeriods ExercisePeriod_
        {
            get
            {
                if (this.exercisePeriod_ != null)
                {
                    return this.exercisePeriod_; 
                }
                else if (this.exercisePeriodIDRef_ != null)
                {
                    exercisePeriod_ = IDManager.getID(exercisePeriodIDRef_) as CommodityExercisePeriods;
                    return this.exercisePeriod_; 
                }
                else
                {
                      return this.exercisePeriod_; 
                }
            }
            set
            {
                if (this.exercisePeriod_ != value)
                {
                    this.exercisePeriod_ = value;
                }
            }
        }
        #endregion
        
        public string exercisePeriodIDRef_ { get; set; }
        #region ExerciseFrequency_
        private Frequency exerciseFrequency_;
        public Frequency ExerciseFrequency_
        {
            get
            {
                if (this.exerciseFrequency_ != null)
                {
                    return this.exerciseFrequency_; 
                }
                else if (this.exerciseFrequencyIDRef_ != null)
                {
                    exerciseFrequency_ = IDManager.getID(exerciseFrequencyIDRef_) as Frequency;
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
        #region LatestExerciseTimeDetermination_
        private DeterminationMethod latestExerciseTimeDetermination_;
        public DeterminationMethod LatestExerciseTimeDetermination_
        {
            get
            {
                if (this.latestExerciseTimeDetermination_ != null)
                {
                    return this.latestExerciseTimeDetermination_; 
                }
                else if (this.latestExerciseTimeDeterminationIDRef_ != null)
                {
                    latestExerciseTimeDetermination_ = IDManager.getID(latestExerciseTimeDeterminationIDRef_) as DeterminationMethod;
                    return this.latestExerciseTimeDetermination_; 
                }
                else
                {
                      return this.latestExerciseTimeDetermination_; 
                }
            }
            set
            {
                if (this.latestExerciseTimeDetermination_ != value)
                {
                    this.latestExerciseTimeDetermination_ = value;
                }
            }
        }
        #endregion
        
        public string latestExerciseTimeDeterminationIDRef_ { get; set; }
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
        private CommodityMultipleExercise multipleExercise_;
        public CommodityMultipleExercise MultipleExercise_
        {
            get
            {
                if (this.multipleExercise_ != null)
                {
                    return this.multipleExercise_; 
                }
                else if (this.multipleExerciseIDRef_ != null)
                {
                    multipleExercise_ = IDManager.getID(multipleExerciseIDRef_) as CommodityMultipleExercise;
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

