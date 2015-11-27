using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SharedAmericanExercise : Exercise
    {
        public SharedAmericanExercise(XmlNode xmlNode)
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

