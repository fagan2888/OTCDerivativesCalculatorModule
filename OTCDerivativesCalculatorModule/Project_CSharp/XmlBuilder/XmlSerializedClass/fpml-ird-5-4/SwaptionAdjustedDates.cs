using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwaptionAdjustedDates : ISerialized
    {
        public SwaptionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList exerciseEventNodeList = xmlNode.SelectNodes("exerciseEvent");
            
            if (exerciseEventNodeList != null)
            {
                this.exerciseEvent_ = new List<ExerciseEvent>();
                foreach (XmlNode item in exerciseEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            exerciseEventIDRef_ = item.Attributes["id"].Value;
                            exerciseEvent_.Add(new ExerciseEvent(item));
                            IDManager.SetID(exerciseEventIDRef_, exerciseEvent_[exerciseEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            exerciseEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        exerciseEvent_.Add(new ExerciseEvent(item));
                        }
                    }
                    else
                    {
                        exerciseEvent_.Add(new ExerciseEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region ExerciseEvent_
        private List<ExerciseEvent> exerciseEvent_;
        public List<ExerciseEvent> ExerciseEvent_
        {
            get
            {
                if (this.exerciseEvent_ != null)
                {
                    return this.exerciseEvent_; 
                }
                else if (this.exerciseEventIDRef_ != null)
                {
                    return this.exerciseEvent_; 
                }
                else
                {
                      return this.exerciseEvent_; 
                }
            }
            set
            {
                if (this.exerciseEvent_ != value)
                {
                    this.exerciseEvent_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

