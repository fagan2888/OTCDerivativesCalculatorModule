using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityEuropeanExercise : Exercise
    {
        public EquityEuropeanExercise(XmlNode xmlNode)
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

