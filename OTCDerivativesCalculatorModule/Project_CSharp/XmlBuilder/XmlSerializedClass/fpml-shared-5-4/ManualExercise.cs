using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ManualExercise : ISerialized
    {
        public ManualExercise(XmlNode xmlNode)
        {
            XmlNode exerciseNoticeNode = xmlNode.SelectSingleNode("exerciseNotice");
            
            if (exerciseNoticeNode != null)
            {
                if (exerciseNoticeNode.Attributes["href"] != null || exerciseNoticeNode.Attributes["id"] != null) 
                {
                    if (exerciseNoticeNode.Attributes["id"] != null) 
                    {
                        exerciseNoticeIDRef_ = exerciseNoticeNode.Attributes["id"].Value;
                        ExerciseNotice ob = new ExerciseNotice(exerciseNoticeNode);
                        IDManager.SetID(exerciseNoticeIDRef_, ob);
                    }
                    else if (exerciseNoticeNode.Attributes["href"] != null)
                    {
                        exerciseNoticeIDRef_ = exerciseNoticeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseNotice_ = new ExerciseNotice(exerciseNoticeNode);
                    }
                }
                else
                {
                    exerciseNotice_ = new ExerciseNotice(exerciseNoticeNode);
                }
            }
            
        
            XmlNode fallbackExerciseNode = xmlNode.SelectSingleNode("fallbackExercise");
            
            if (fallbackExerciseNode != null)
            {
                if (fallbackExerciseNode.Attributes["href"] != null || fallbackExerciseNode.Attributes["id"] != null) 
                {
                    if (fallbackExerciseNode.Attributes["id"] != null) 
                    {
                        fallbackExerciseIDRef_ = fallbackExerciseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fallbackExerciseNode);
                        IDManager.SetID(fallbackExerciseIDRef_, ob);
                    }
                    else if (fallbackExerciseNode.Attributes["href"] != null)
                    {
                        fallbackExerciseIDRef_ = fallbackExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallbackExercise_ = new XsdTypeBoolean(fallbackExerciseNode);
                    }
                }
                else
                {
                    fallbackExercise_ = new XsdTypeBoolean(fallbackExerciseNode);
                }
            }
            
        
        }
        
    
        #region ExerciseNotice_
        private ExerciseNotice exerciseNotice_;
        public ExerciseNotice ExerciseNotice_
        {
            get
            {
                if (this.exerciseNotice_ != null)
                {
                    return this.exerciseNotice_; 
                }
                else if (this.exerciseNoticeIDRef_ != null)
                {
                    exerciseNotice_ = IDManager.getID(exerciseNoticeIDRef_) as ExerciseNotice;
                    return this.exerciseNotice_; 
                }
                else
                {
                      return this.exerciseNotice_; 
                }
            }
            set
            {
                if (this.exerciseNotice_ != value)
                {
                    this.exerciseNotice_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseNoticeIDRef_ { get; set; }
        #region FallbackExercise_
        private XsdTypeBoolean fallbackExercise_;
        public XsdTypeBoolean FallbackExercise_
        {
            get
            {
                if (this.fallbackExercise_ != null)
                {
                    return this.fallbackExercise_; 
                }
                else if (this.fallbackExerciseIDRef_ != null)
                {
                    fallbackExercise_ = IDManager.getID(fallbackExerciseIDRef_) as XsdTypeBoolean;
                    return this.fallbackExercise_; 
                }
                else
                {
                      return this.fallbackExercise_; 
                }
            }
            set
            {
                if (this.fallbackExercise_ != value)
                {
                    this.fallbackExercise_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackExerciseIDRef_ { get; set; }
        
    
        
    
    }
    
}

