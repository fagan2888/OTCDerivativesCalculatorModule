using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExerciseProcedureOption : ISerialized
    {
        public ExerciseProcedureOption(XmlNode xmlNode)
        {
            XmlNode manualExerciseNode = xmlNode.SelectSingleNode("manualExercise");
            
            if (manualExerciseNode != null)
            {
                if (manualExerciseNode.Attributes["href"] != null || manualExerciseNode.Attributes["id"] != null) 
                {
                    if (manualExerciseNode.Attributes["id"] != null) 
                    {
                        manualExerciseIDRef_ = manualExerciseNode.Attributes["id"].Value;
                        Empty ob = new Empty(manualExerciseNode);
                        IDManager.SetID(manualExerciseIDRef_, ob);
                    }
                    else if (manualExerciseNode.Attributes["href"] != null)
                    {
                        manualExerciseIDRef_ = manualExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        manualExercise_ = new Empty(manualExerciseNode);
                    }
                }
                else
                {
                    manualExercise_ = new Empty(manualExerciseNode);
                }
            }
            
        
            XmlNode automaticExerciseNode = xmlNode.SelectSingleNode("automaticExercise");
            
            if (automaticExerciseNode != null)
            {
                if (automaticExerciseNode.Attributes["href"] != null || automaticExerciseNode.Attributes["id"] != null) 
                {
                    if (automaticExerciseNode.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["id"].Value;
                        Empty ob = new Empty(automaticExerciseNode);
                        IDManager.SetID(automaticExerciseIDRef_, ob);
                    }
                    else if (automaticExerciseNode.Attributes["href"] != null)
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        automaticExercise_ = new Empty(automaticExerciseNode);
                    }
                }
                else
                {
                    automaticExercise_ = new Empty(automaticExerciseNode);
                }
            }
            
        
        }
        
    
        #region ManualExercise_
        private Empty manualExercise_;
        public Empty ManualExercise_
        {
            get
            {
                if (this.manualExercise_ != null)
                {
                    return this.manualExercise_; 
                }
                else if (this.manualExerciseIDRef_ != null)
                {
                    manualExercise_ = IDManager.getID(manualExerciseIDRef_) as Empty;
                    return this.manualExercise_; 
                }
                else
                {
                      return this.manualExercise_; 
                }
            }
            set
            {
                if (this.manualExercise_ != value)
                {
                    this.manualExercise_ = value;
                }
            }
        }
        #endregion
        
        public string manualExerciseIDRef_ { get; set; }
        #region AutomaticExercise_
        private Empty automaticExercise_;
        public Empty AutomaticExercise_
        {
            get
            {
                if (this.automaticExercise_ != null)
                {
                    return this.automaticExercise_; 
                }
                else if (this.automaticExerciseIDRef_ != null)
                {
                    automaticExercise_ = IDManager.getID(automaticExerciseIDRef_) as Empty;
                    return this.automaticExercise_; 
                }
                else
                {
                      return this.automaticExercise_; 
                }
            }
            set
            {
                if (this.automaticExercise_ != value)
                {
                    this.automaticExercise_ = value;
                }
            }
        }
        #endregion
        
        public string automaticExerciseIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

