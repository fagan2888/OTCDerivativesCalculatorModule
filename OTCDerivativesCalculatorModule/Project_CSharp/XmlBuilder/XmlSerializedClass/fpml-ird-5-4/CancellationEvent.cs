using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CancellationEvent : ISerialized
    {
        public CancellationEvent(XmlNode xmlNode)
        {
            XmlNode adjustedExerciseDateNode = xmlNode.SelectSingleNode("adjustedExerciseDate");
            
            if (adjustedExerciseDateNode != null)
            {
                if (adjustedExerciseDateNode.Attributes["href"] != null || adjustedExerciseDateNode.Attributes["id"] != null) 
                {
                    if (adjustedExerciseDateNode.Attributes["id"] != null) 
                    {
                        adjustedExerciseDateIDRef_ = adjustedExerciseDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedExerciseDateNode);
                        IDManager.SetID(adjustedExerciseDateIDRef_, ob);
                    }
                    else if (adjustedExerciseDateNode.Attributes["href"] != null)
                    {
                        adjustedExerciseDateIDRef_ = adjustedExerciseDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedExerciseDate_ = new XsdTypeDate(adjustedExerciseDateNode);
                    }
                }
                else
                {
                    adjustedExerciseDate_ = new XsdTypeDate(adjustedExerciseDateNode);
                }
            }
            
        
            XmlNode adjustedEarlyTerminationDateNode = xmlNode.SelectSingleNode("adjustedEarlyTerminationDate");
            
            if (adjustedEarlyTerminationDateNode != null)
            {
                if (adjustedEarlyTerminationDateNode.Attributes["href"] != null || adjustedEarlyTerminationDateNode.Attributes["id"] != null) 
                {
                    if (adjustedEarlyTerminationDateNode.Attributes["id"] != null) 
                    {
                        adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                        IDManager.SetID(adjustedEarlyTerminationDateIDRef_, ob);
                    }
                    else if (adjustedEarlyTerminationDateNode.Attributes["href"] != null)
                    {
                        adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedEarlyTerminationDate_ = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                    }
                }
                else
                {
                    adjustedEarlyTerminationDate_ = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                }
            }
            
        
        }
        
    
        #region AdjustedExerciseDate_
        private XsdTypeDate adjustedExerciseDate_;
        public XsdTypeDate AdjustedExerciseDate_
        {
            get
            {
                if (this.adjustedExerciseDate_ != null)
                {
                    return this.adjustedExerciseDate_; 
                }
                else if (this.adjustedExerciseDateIDRef_ != null)
                {
                    adjustedExerciseDate_ = IDManager.getID(adjustedExerciseDateIDRef_) as XsdTypeDate;
                    return this.adjustedExerciseDate_; 
                }
                else
                {
                      return this.adjustedExerciseDate_; 
                }
            }
            set
            {
                if (this.adjustedExerciseDate_ != value)
                {
                    this.adjustedExerciseDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedExerciseDateIDRef_ { get; set; }
        #region AdjustedEarlyTerminationDate_
        private XsdTypeDate adjustedEarlyTerminationDate_;
        public XsdTypeDate AdjustedEarlyTerminationDate_
        {
            get
            {
                if (this.adjustedEarlyTerminationDate_ != null)
                {
                    return this.adjustedEarlyTerminationDate_; 
                }
                else if (this.adjustedEarlyTerminationDateIDRef_ != null)
                {
                    adjustedEarlyTerminationDate_ = IDManager.getID(adjustedEarlyTerminationDateIDRef_) as XsdTypeDate;
                    return this.adjustedEarlyTerminationDate_; 
                }
                else
                {
                      return this.adjustedEarlyTerminationDate_; 
                }
            }
            set
            {
                if (this.adjustedEarlyTerminationDate_ != value)
                {
                    this.adjustedEarlyTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedEarlyTerminationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

