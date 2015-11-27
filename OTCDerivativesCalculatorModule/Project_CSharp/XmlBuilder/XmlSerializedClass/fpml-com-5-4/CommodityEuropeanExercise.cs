using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityEuropeanExercise : Exercise
    {
        public CommodityEuropeanExercise(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

