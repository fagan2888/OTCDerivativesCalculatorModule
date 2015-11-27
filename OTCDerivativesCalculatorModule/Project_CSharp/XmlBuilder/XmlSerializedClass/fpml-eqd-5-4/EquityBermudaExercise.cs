using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityBermudaExercise : SharedAmericanExercise
    {
        public EquityBermudaExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode bermudaExerciseDatesNode = xmlNode.SelectSingleNode("bermudaExerciseDates");
            
            if (bermudaExerciseDatesNode != null)
            {
                if (bermudaExerciseDatesNode.Attributes["href"] != null || bermudaExerciseDatesNode.Attributes["id"] != null) 
                {
                    if (bermudaExerciseDatesNode.Attributes["id"] != null) 
                    {
                        bermudaExerciseDatesIDRef_ = bermudaExerciseDatesNode.Attributes["id"].Value;
                        DateList ob = new DateList(bermudaExerciseDatesNode);
                        IDManager.SetID(bermudaExerciseDatesIDRef_, ob);
                    }
                    else if (bermudaExerciseDatesNode.Attributes["href"] != null)
                    {
                        bermudaExerciseDatesIDRef_ = bermudaExerciseDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bermudaExerciseDates_ = new DateList(bermudaExerciseDatesNode);
                    }
                }
                else
                {
                    bermudaExerciseDates_ = new DateList(bermudaExerciseDatesNode);
                }
            }
            
        
            XmlNode latestExerciseTimeTypeNode = xmlNode.SelectSingleNode("latestExerciseTimeType");
            
            if (latestExerciseTimeTypeNode != null)
            {
                if (latestExerciseTimeTypeNode.Attributes["href"] != null || latestExerciseTimeTypeNode.Attributes["id"] != null) 
                {
                    if (latestExerciseTimeTypeNode.Attributes["id"] != null) 
                    {
                        latestExerciseTimeTypeIDRef_ = latestExerciseTimeTypeNode.Attributes["id"].Value;
                        TimeTypeEnum ob = new TimeTypeEnum(latestExerciseTimeTypeNode);
                        IDManager.SetID(latestExerciseTimeTypeIDRef_, ob);
                    }
                    else if (latestExerciseTimeTypeNode.Attributes["href"] != null)
                    {
                        latestExerciseTimeTypeIDRef_ = latestExerciseTimeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        latestExerciseTimeType_ = new TimeTypeEnum(latestExerciseTimeTypeNode);
                    }
                }
                else
                {
                    latestExerciseTimeType_ = new TimeTypeEnum(latestExerciseTimeTypeNode);
                }
            }
            
        
            XmlNode equityExpirationTimeTypeNode = xmlNode.SelectSingleNode("equityExpirationTimeType");
            
            if (equityExpirationTimeTypeNode != null)
            {
                if (equityExpirationTimeTypeNode.Attributes["href"] != null || equityExpirationTimeTypeNode.Attributes["id"] != null) 
                {
                    if (equityExpirationTimeTypeNode.Attributes["id"] != null) 
                    {
                        equityExpirationTimeTypeIDRef_ = equityExpirationTimeTypeNode.Attributes["id"].Value;
                        TimeTypeEnum ob = new TimeTypeEnum(equityExpirationTimeTypeNode);
                        IDManager.SetID(equityExpirationTimeTypeIDRef_, ob);
                    }
                    else if (equityExpirationTimeTypeNode.Attributes["href"] != null)
                    {
                        equityExpirationTimeTypeIDRef_ = equityExpirationTimeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityExpirationTimeType_ = new TimeTypeEnum(equityExpirationTimeTypeNode);
                    }
                }
                else
                {
                    equityExpirationTimeType_ = new TimeTypeEnum(equityExpirationTimeTypeNode);
                }
            }
            
        
            XmlNode equityExpirationTimeNode = xmlNode.SelectSingleNode("equityExpirationTime");
            
            if (equityExpirationTimeNode != null)
            {
                if (equityExpirationTimeNode.Attributes["href"] != null || equityExpirationTimeNode.Attributes["id"] != null) 
                {
                    if (equityExpirationTimeNode.Attributes["id"] != null) 
                    {
                        equityExpirationTimeIDRef_ = equityExpirationTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(equityExpirationTimeNode);
                        IDManager.SetID(equityExpirationTimeIDRef_, ob);
                    }
                    else if (equityExpirationTimeNode.Attributes["href"] != null)
                    {
                        equityExpirationTimeIDRef_ = equityExpirationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityExpirationTime_ = new BusinessCenterTime(equityExpirationTimeNode);
                    }
                }
                else
                {
                    equityExpirationTime_ = new BusinessCenterTime(equityExpirationTimeNode);
                }
            }
            
        
            XmlNode expirationTimeDeterminationNode = xmlNode.SelectSingleNode("expirationTimeDetermination");
            
            if (expirationTimeDeterminationNode != null)
            {
                if (expirationTimeDeterminationNode.Attributes["href"] != null || expirationTimeDeterminationNode.Attributes["id"] != null) 
                {
                    if (expirationTimeDeterminationNode.Attributes["id"] != null) 
                    {
                        expirationTimeDeterminationIDRef_ = expirationTimeDeterminationNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(expirationTimeDeterminationNode);
                        IDManager.SetID(expirationTimeDeterminationIDRef_, ob);
                    }
                    else if (expirationTimeDeterminationNode.Attributes["href"] != null)
                    {
                        expirationTimeDeterminationIDRef_ = expirationTimeDeterminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationTimeDetermination_ = new DeterminationMethod(expirationTimeDeterminationNode);
                    }
                }
                else
                {
                    expirationTimeDetermination_ = new DeterminationMethod(expirationTimeDeterminationNode);
                }
            }
            
        
            XmlNode equityMultipleExerciseNode = xmlNode.SelectSingleNode("equityMultipleExercise");
            
            if (equityMultipleExerciseNode != null)
            {
                if (equityMultipleExerciseNode.Attributes["href"] != null || equityMultipleExerciseNode.Attributes["id"] != null) 
                {
                    if (equityMultipleExerciseNode.Attributes["id"] != null) 
                    {
                        equityMultipleExerciseIDRef_ = equityMultipleExerciseNode.Attributes["id"].Value;
                        EquityMultipleExercise ob = new EquityMultipleExercise(equityMultipleExerciseNode);
                        IDManager.SetID(equityMultipleExerciseIDRef_, ob);
                    }
                    else if (equityMultipleExerciseNode.Attributes["href"] != null)
                    {
                        equityMultipleExerciseIDRef_ = equityMultipleExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityMultipleExercise_ = new EquityMultipleExercise(equityMultipleExerciseNode);
                    }
                }
                else
                {
                    equityMultipleExercise_ = new EquityMultipleExercise(equityMultipleExerciseNode);
                }
            }
            
        
        }
        
    
        #region BermudaExerciseDates_
        private DateList bermudaExerciseDates_;
        public DateList BermudaExerciseDates_
        {
            get
            {
                if (this.bermudaExerciseDates_ != null)
                {
                    return this.bermudaExerciseDates_; 
                }
                else if (this.bermudaExerciseDatesIDRef_ != null)
                {
                    bermudaExerciseDates_ = IDManager.getID(bermudaExerciseDatesIDRef_) as DateList;
                    return this.bermudaExerciseDates_; 
                }
                else
                {
                      return this.bermudaExerciseDates_; 
                }
            }
            set
            {
                if (this.bermudaExerciseDates_ != value)
                {
                    this.bermudaExerciseDates_ = value;
                }
            }
        }
        #endregion
        
        public string bermudaExerciseDatesIDRef_ { get; set; }
        #region LatestExerciseTimeType_
        private TimeTypeEnum latestExerciseTimeType_;
        public TimeTypeEnum LatestExerciseTimeType_
        {
            get
            {
                if (this.latestExerciseTimeType_ != null)
                {
                    return this.latestExerciseTimeType_; 
                }
                else if (this.latestExerciseTimeTypeIDRef_ != null)
                {
                    latestExerciseTimeType_ = IDManager.getID(latestExerciseTimeTypeIDRef_) as TimeTypeEnum;
                    return this.latestExerciseTimeType_; 
                }
                else
                {
                      return this.latestExerciseTimeType_; 
                }
            }
            set
            {
                if (this.latestExerciseTimeType_ != value)
                {
                    this.latestExerciseTimeType_ = value;
                }
            }
        }
        #endregion
        
        public string latestExerciseTimeTypeIDRef_ { get; set; }
        #region EquityExpirationTimeType_
        private TimeTypeEnum equityExpirationTimeType_;
        public TimeTypeEnum EquityExpirationTimeType_
        {
            get
            {
                if (this.equityExpirationTimeType_ != null)
                {
                    return this.equityExpirationTimeType_; 
                }
                else if (this.equityExpirationTimeTypeIDRef_ != null)
                {
                    equityExpirationTimeType_ = IDManager.getID(equityExpirationTimeTypeIDRef_) as TimeTypeEnum;
                    return this.equityExpirationTimeType_; 
                }
                else
                {
                      return this.equityExpirationTimeType_; 
                }
            }
            set
            {
                if (this.equityExpirationTimeType_ != value)
                {
                    this.equityExpirationTimeType_ = value;
                }
            }
        }
        #endregion
        
        public string equityExpirationTimeTypeIDRef_ { get; set; }
        #region EquityExpirationTime_
        private BusinessCenterTime equityExpirationTime_;
        public BusinessCenterTime EquityExpirationTime_
        {
            get
            {
                if (this.equityExpirationTime_ != null)
                {
                    return this.equityExpirationTime_; 
                }
                else if (this.equityExpirationTimeIDRef_ != null)
                {
                    equityExpirationTime_ = IDManager.getID(equityExpirationTimeIDRef_) as BusinessCenterTime;
                    return this.equityExpirationTime_; 
                }
                else
                {
                      return this.equityExpirationTime_; 
                }
            }
            set
            {
                if (this.equityExpirationTime_ != value)
                {
                    this.equityExpirationTime_ = value;
                }
            }
        }
        #endregion
        
        public string equityExpirationTimeIDRef_ { get; set; }
        #region ExpirationTimeDetermination_
        private DeterminationMethod expirationTimeDetermination_;
        public DeterminationMethod ExpirationTimeDetermination_
        {
            get
            {
                if (this.expirationTimeDetermination_ != null)
                {
                    return this.expirationTimeDetermination_; 
                }
                else if (this.expirationTimeDeterminationIDRef_ != null)
                {
                    expirationTimeDetermination_ = IDManager.getID(expirationTimeDeterminationIDRef_) as DeterminationMethod;
                    return this.expirationTimeDetermination_; 
                }
                else
                {
                      return this.expirationTimeDetermination_; 
                }
            }
            set
            {
                if (this.expirationTimeDetermination_ != value)
                {
                    this.expirationTimeDetermination_ = value;
                }
            }
        }
        #endregion
        
        public string expirationTimeDeterminationIDRef_ { get; set; }
        #region EquityMultipleExercise_
        private EquityMultipleExercise equityMultipleExercise_;
        public EquityMultipleExercise EquityMultipleExercise_
        {
            get
            {
                if (this.equityMultipleExercise_ != null)
                {
                    return this.equityMultipleExercise_; 
                }
                else if (this.equityMultipleExerciseIDRef_ != null)
                {
                    equityMultipleExercise_ = IDManager.getID(equityMultipleExerciseIDRef_) as EquityMultipleExercise;
                    return this.equityMultipleExercise_; 
                }
                else
                {
                      return this.equityMultipleExercise_; 
                }
            }
            set
            {
                if (this.equityMultipleExercise_ != value)
                {
                    this.equityMultipleExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityMultipleExerciseIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

