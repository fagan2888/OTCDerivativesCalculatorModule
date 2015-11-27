using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExtensionEvent : ISerialized
    {
        public ExtensionEvent(XmlNode xmlNode)
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
            
        
            XmlNode adjustedExtendedTerminationDateNode = xmlNode.SelectSingleNode("adjustedExtendedTerminationDate");
            
            if (adjustedExtendedTerminationDateNode != null)
            {
                if (adjustedExtendedTerminationDateNode.Attributes["href"] != null || adjustedExtendedTerminationDateNode.Attributes["id"] != null) 
                {
                    if (adjustedExtendedTerminationDateNode.Attributes["id"] != null) 
                    {
                        adjustedExtendedTerminationDateIDRef_ = adjustedExtendedTerminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedExtendedTerminationDateNode);
                        IDManager.SetID(adjustedExtendedTerminationDateIDRef_, ob);
                    }
                    else if (adjustedExtendedTerminationDateNode.Attributes["href"] != null)
                    {
                        adjustedExtendedTerminationDateIDRef_ = adjustedExtendedTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedExtendedTerminationDate_ = new XsdTypeDate(adjustedExtendedTerminationDateNode);
                    }
                }
                else
                {
                    adjustedExtendedTerminationDate_ = new XsdTypeDate(adjustedExtendedTerminationDateNode);
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
        #region AdjustedExtendedTerminationDate_
        private XsdTypeDate adjustedExtendedTerminationDate_;
        public XsdTypeDate AdjustedExtendedTerminationDate_
        {
            get
            {
                if (this.adjustedExtendedTerminationDate_ != null)
                {
                    return this.adjustedExtendedTerminationDate_; 
                }
                else if (this.adjustedExtendedTerminationDateIDRef_ != null)
                {
                    adjustedExtendedTerminationDate_ = IDManager.getID(adjustedExtendedTerminationDateIDRef_) as XsdTypeDate;
                    return this.adjustedExtendedTerminationDate_; 
                }
                else
                {
                      return this.adjustedExtendedTerminationDate_; 
                }
            }
            set
            {
                if (this.adjustedExtendedTerminationDate_ != value)
                {
                    this.adjustedExtendedTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedExtendedTerminationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

