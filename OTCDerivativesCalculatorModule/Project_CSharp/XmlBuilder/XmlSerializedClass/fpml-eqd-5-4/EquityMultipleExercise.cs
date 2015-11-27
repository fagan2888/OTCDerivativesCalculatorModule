using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityMultipleExercise : ISerialized
    {
        public EquityMultipleExercise(XmlNode xmlNode)
        {
            XmlNode integralMultipleExerciseNode = xmlNode.SelectSingleNode("integralMultipleExercise");
            
            if (integralMultipleExerciseNode != null)
            {
                if (integralMultipleExerciseNode.Attributes["href"] != null || integralMultipleExerciseNode.Attributes["id"] != null) 
                {
                    if (integralMultipleExerciseNode.Attributes["id"] != null) 
                    {
                        integralMultipleExerciseIDRef_ = integralMultipleExerciseNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(integralMultipleExerciseNode);
                        IDManager.SetID(integralMultipleExerciseIDRef_, ob);
                    }
                    else if (integralMultipleExerciseNode.Attributes["href"] != null)
                    {
                        integralMultipleExerciseIDRef_ = integralMultipleExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        integralMultipleExercise_ = new PositiveDecimal(integralMultipleExerciseNode);
                    }
                }
                else
                {
                    integralMultipleExercise_ = new PositiveDecimal(integralMultipleExerciseNode);
                }
            }
            
        
            XmlNode minimumNumberOfOptionsNode = xmlNode.SelectSingleNode("minimumNumberOfOptions");
            
            if (minimumNumberOfOptionsNode != null)
            {
                if (minimumNumberOfOptionsNode.Attributes["href"] != null || minimumNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (minimumNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(minimumNumberOfOptionsNode);
                        IDManager.SetID(minimumNumberOfOptionsIDRef_, ob);
                    }
                    else if (minimumNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumNumberOfOptions_ = new NonNegativeDecimal(minimumNumberOfOptionsNode);
                    }
                }
                else
                {
                    minimumNumberOfOptions_ = new NonNegativeDecimal(minimumNumberOfOptionsNode);
                }
            }
            
        
            XmlNode maximumNumberOfOptionsNode = xmlNode.SelectSingleNode("maximumNumberOfOptions");
            
            if (maximumNumberOfOptionsNode != null)
            {
                if (maximumNumberOfOptionsNode.Attributes["href"] != null || maximumNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (maximumNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                        IDManager.SetID(maximumNumberOfOptionsIDRef_, ob);
                    }
                    else if (maximumNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumNumberOfOptions_ = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                    }
                }
                else
                {
                    maximumNumberOfOptions_ = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                }
            }
            
        
        }
        
    
        #region IntegralMultipleExercise_
        private PositiveDecimal integralMultipleExercise_;
        public PositiveDecimal IntegralMultipleExercise_
        {
            get
            {
                if (this.integralMultipleExercise_ != null)
                {
                    return this.integralMultipleExercise_; 
                }
                else if (this.integralMultipleExerciseIDRef_ != null)
                {
                    integralMultipleExercise_ = IDManager.getID(integralMultipleExerciseIDRef_) as PositiveDecimal;
                    return this.integralMultipleExercise_; 
                }
                else
                {
                      return this.integralMultipleExercise_; 
                }
            }
            set
            {
                if (this.integralMultipleExercise_ != value)
                {
                    this.integralMultipleExercise_ = value;
                }
            }
        }
        #endregion
        
        public string integralMultipleExerciseIDRef_ { get; set; }
        #region MinimumNumberOfOptions_
        private NonNegativeDecimal minimumNumberOfOptions_;
        public NonNegativeDecimal MinimumNumberOfOptions_
        {
            get
            {
                if (this.minimumNumberOfOptions_ != null)
                {
                    return this.minimumNumberOfOptions_; 
                }
                else if (this.minimumNumberOfOptionsIDRef_ != null)
                {
                    minimumNumberOfOptions_ = IDManager.getID(minimumNumberOfOptionsIDRef_) as NonNegativeDecimal;
                    return this.minimumNumberOfOptions_; 
                }
                else
                {
                      return this.minimumNumberOfOptions_; 
                }
            }
            set
            {
                if (this.minimumNumberOfOptions_ != value)
                {
                    this.minimumNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string minimumNumberOfOptionsIDRef_ { get; set; }
        #region MaximumNumberOfOptions_
        private NonNegativeDecimal maximumNumberOfOptions_;
        public NonNegativeDecimal MaximumNumberOfOptions_
        {
            get
            {
                if (this.maximumNumberOfOptions_ != null)
                {
                    return this.maximumNumberOfOptions_; 
                }
                else if (this.maximumNumberOfOptionsIDRef_ != null)
                {
                    maximumNumberOfOptions_ = IDManager.getID(maximumNumberOfOptionsIDRef_) as NonNegativeDecimal;
                    return this.maximumNumberOfOptions_; 
                }
                else
                {
                      return this.maximumNumberOfOptions_; 
                }
            }
            set
            {
                if (this.maximumNumberOfOptions_ != value)
                {
                    this.maximumNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string maximumNumberOfOptionsIDRef_ { get; set; }
        
    
        
    
    }
    
}

