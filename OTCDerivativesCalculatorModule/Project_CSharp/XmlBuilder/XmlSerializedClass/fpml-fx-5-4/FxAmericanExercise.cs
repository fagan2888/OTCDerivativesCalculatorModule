using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxAmericanExercise : FxDigitalAmericanExercise
    {
        public FxAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode multipleExerciseNode = xmlNode.SelectSingleNode("multipleExercise");
            
            if (multipleExerciseNode != null)
            {
                if (multipleExerciseNode.Attributes["href"] != null || multipleExerciseNode.Attributes["id"] != null) 
                {
                    if (multipleExerciseNode.Attributes["id"] != null) 
                    {
                        multipleExerciseIDRef_ = multipleExerciseNode.Attributes["id"].Value;
                        FxMultipleExercise ob = new FxMultipleExercise(multipleExerciseNode);
                        IDManager.SetID(multipleExerciseIDRef_, ob);
                    }
                    else if (multipleExerciseNode.Attributes["href"] != null)
                    {
                        multipleExerciseIDRef_ = multipleExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleExercise_ = new FxMultipleExercise(multipleExerciseNode);
                    }
                }
                else
                {
                    multipleExercise_ = new FxMultipleExercise(multipleExerciseNode);
                }
            }
            
        
        }
        
    
        #region MultipleExercise_
        private FxMultipleExercise multipleExercise_;
        public FxMultipleExercise MultipleExercise_
        {
            get
            {
                if (this.multipleExercise_ != null)
                {
                    return this.multipleExercise_; 
                }
                else if (this.multipleExerciseIDRef_ != null)
                {
                    multipleExercise_ = IDManager.getID(multipleExerciseIDRef_) as FxMultipleExercise;
                    return this.multipleExercise_; 
                }
                else
                {
                      return this.multipleExercise_; 
                }
            }
            set
            {
                if (this.multipleExercise_ != value)
                {
                    this.multipleExercise_ = value;
                }
            }
        }
        #endregion
        
        public string multipleExerciseIDRef_ { get; set; }
        
    
        
    
    }
    
}

