using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalAmericanExercise : Exercise
    {
        public CommodityPhysicalAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode commencementDatesNode = xmlNode.SelectSingleNode("commencementDates");
            
            if (commencementDatesNode != null)
            {
                if (commencementDatesNode.Attributes["href"] != null || commencementDatesNode.Attributes["id"] != null) 
                {
                    if (commencementDatesNode.Attributes["id"] != null) 
                    {
                        commencementDatesIDRef_ = commencementDatesNode.Attributes["id"].Value;
                        AdjustableOrRelativeDates ob = new AdjustableOrRelativeDates(commencementDatesNode);
                        IDManager.SetID(commencementDatesIDRef_, ob);
                    }
                    else if (commencementDatesNode.Attributes["href"] != null)
                    {
                        commencementDatesIDRef_ = commencementDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commencementDates_ = new AdjustableOrRelativeDates(commencementDatesNode);
                    }
                }
                else
                {
                    commencementDates_ = new AdjustableOrRelativeDates(commencementDatesNode);
                }
            }
            
        
            XmlNode expirationDatesNode = xmlNode.SelectSingleNode("expirationDates");
            
            if (expirationDatesNode != null)
            {
                if (expirationDatesNode.Attributes["href"] != null || expirationDatesNode.Attributes["id"] != null) 
                {
                    if (expirationDatesNode.Attributes["id"] != null) 
                    {
                        expirationDatesIDRef_ = expirationDatesNode.Attributes["id"].Value;
                        AdjustableOrRelativeDates ob = new AdjustableOrRelativeDates(expirationDatesNode);
                        IDManager.SetID(expirationDatesIDRef_, ob);
                    }
                    else if (expirationDatesNode.Attributes["href"] != null)
                    {
                        expirationDatesIDRef_ = expirationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDates_ = new AdjustableOrRelativeDates(expirationDatesNode);
                    }
                }
                else
                {
                    expirationDates_ = new AdjustableOrRelativeDates(expirationDatesNode);
                }
            }
            
        
            XmlNode relativeCommencementDatesNode = xmlNode.SelectSingleNode("relativeCommencementDates");
            
            if (relativeCommencementDatesNode != null)
            {
                if (relativeCommencementDatesNode.Attributes["href"] != null || relativeCommencementDatesNode.Attributes["id"] != null) 
                {
                    if (relativeCommencementDatesNode.Attributes["id"] != null) 
                    {
                        relativeCommencementDatesIDRef_ = relativeCommencementDatesNode.Attributes["id"].Value;
                        CommodityRelativeExpirationDates ob = new CommodityRelativeExpirationDates(relativeCommencementDatesNode);
                        IDManager.SetID(relativeCommencementDatesIDRef_, ob);
                    }
                    else if (relativeCommencementDatesNode.Attributes["href"] != null)
                    {
                        relativeCommencementDatesIDRef_ = relativeCommencementDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeCommencementDates_ = new CommodityRelativeExpirationDates(relativeCommencementDatesNode);
                    }
                }
                else
                {
                    relativeCommencementDates_ = new CommodityRelativeExpirationDates(relativeCommencementDatesNode);
                }
            }
            
        
            XmlNode relativeExpirationDatesNode = xmlNode.SelectSingleNode("relativeExpirationDates");
            
            if (relativeExpirationDatesNode != null)
            {
                if (relativeExpirationDatesNode.Attributes["href"] != null || relativeExpirationDatesNode.Attributes["id"] != null) 
                {
                    if (relativeExpirationDatesNode.Attributes["id"] != null) 
                    {
                        relativeExpirationDatesIDRef_ = relativeExpirationDatesNode.Attributes["id"].Value;
                        CommodityRelativeExpirationDates ob = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
                        IDManager.SetID(relativeExpirationDatesIDRef_, ob);
                    }
                    else if (relativeExpirationDatesNode.Attributes["href"] != null)
                    {
                        relativeExpirationDatesIDRef_ = relativeExpirationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeExpirationDates_ = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
                    }
                }
                else
                {
                    relativeExpirationDates_ = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
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
                        PrevailingTime ob = new PrevailingTime(latestExerciseTimeNode);
                        IDManager.SetID(latestExerciseTimeIDRef_, ob);
                    }
                    else if (latestExerciseTimeNode.Attributes["href"] != null)
                    {
                        latestExerciseTimeIDRef_ = latestExerciseTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        latestExerciseTime_ = new PrevailingTime(latestExerciseTimeNode);
                    }
                }
                else
                {
                    latestExerciseTime_ = new PrevailingTime(latestExerciseTimeNode);
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
                        PrevailingTime ob = new PrevailingTime(expirationTimeNode);
                        IDManager.SetID(expirationTimeIDRef_, ob);
                    }
                    else if (expirationTimeNode.Attributes["href"] != null)
                    {
                        expirationTimeIDRef_ = expirationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationTime_ = new PrevailingTime(expirationTimeNode);
                    }
                }
                else
                {
                    expirationTime_ = new PrevailingTime(expirationTimeNode);
                }
            }
            
        
        }
        
    
        #region CommencementDates_
        private AdjustableOrRelativeDates commencementDates_;
        public AdjustableOrRelativeDates CommencementDates_
        {
            get
            {
                if (this.commencementDates_ != null)
                {
                    return this.commencementDates_; 
                }
                else if (this.commencementDatesIDRef_ != null)
                {
                    commencementDates_ = IDManager.getID(commencementDatesIDRef_) as AdjustableOrRelativeDates;
                    return this.commencementDates_; 
                }
                else
                {
                      return this.commencementDates_; 
                }
            }
            set
            {
                if (this.commencementDates_ != value)
                {
                    this.commencementDates_ = value;
                }
            }
        }
        #endregion
        
        public string commencementDatesIDRef_ { get; set; }
        #region ExpirationDates_
        private AdjustableOrRelativeDates expirationDates_;
        public AdjustableOrRelativeDates ExpirationDates_
        {
            get
            {
                if (this.expirationDates_ != null)
                {
                    return this.expirationDates_; 
                }
                else if (this.expirationDatesIDRef_ != null)
                {
                    expirationDates_ = IDManager.getID(expirationDatesIDRef_) as AdjustableOrRelativeDates;
                    return this.expirationDates_; 
                }
                else
                {
                      return this.expirationDates_; 
                }
            }
            set
            {
                if (this.expirationDates_ != value)
                {
                    this.expirationDates_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDatesIDRef_ { get; set; }
        #region RelativeCommencementDates_
        private CommodityRelativeExpirationDates relativeCommencementDates_;
        public CommodityRelativeExpirationDates RelativeCommencementDates_
        {
            get
            {
                if (this.relativeCommencementDates_ != null)
                {
                    return this.relativeCommencementDates_; 
                }
                else if (this.relativeCommencementDatesIDRef_ != null)
                {
                    relativeCommencementDates_ = IDManager.getID(relativeCommencementDatesIDRef_) as CommodityRelativeExpirationDates;
                    return this.relativeCommencementDates_; 
                }
                else
                {
                      return this.relativeCommencementDates_; 
                }
            }
            set
            {
                if (this.relativeCommencementDates_ != value)
                {
                    this.relativeCommencementDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativeCommencementDatesIDRef_ { get; set; }
        #region RelativeExpirationDates_
        private CommodityRelativeExpirationDates relativeExpirationDates_;
        public CommodityRelativeExpirationDates RelativeExpirationDates_
        {
            get
            {
                if (this.relativeExpirationDates_ != null)
                {
                    return this.relativeExpirationDates_; 
                }
                else if (this.relativeExpirationDatesIDRef_ != null)
                {
                    relativeExpirationDates_ = IDManager.getID(relativeExpirationDatesIDRef_) as CommodityRelativeExpirationDates;
                    return this.relativeExpirationDates_; 
                }
                else
                {
                      return this.relativeExpirationDates_; 
                }
            }
            set
            {
                if (this.relativeExpirationDates_ != value)
                {
                    this.relativeExpirationDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativeExpirationDatesIDRef_ { get; set; }
        #region LatestExerciseTime_
        private PrevailingTime latestExerciseTime_;
        public PrevailingTime LatestExerciseTime_
        {
            get
            {
                if (this.latestExerciseTime_ != null)
                {
                    return this.latestExerciseTime_; 
                }
                else if (this.latestExerciseTimeIDRef_ != null)
                {
                    latestExerciseTime_ = IDManager.getID(latestExerciseTimeIDRef_) as PrevailingTime;
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
        private PrevailingTime expirationTime_;
        public PrevailingTime ExpirationTime_
        {
            get
            {
                if (this.expirationTime_ != null)
                {
                    return this.expirationTime_; 
                }
                else if (this.expirationTimeIDRef_ != null)
                {
                    expirationTime_ = IDManager.getID(expirationTimeIDRef_) as PrevailingTime;
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

