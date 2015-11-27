using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PositiveStep : StepBase
    {
        public PositiveStep(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode stepValueNode = xmlNode.SelectSingleNode("stepValue");
            
            if (stepValueNode != null)
            {
                if (stepValueNode.Attributes["href"] != null || stepValueNode.Attributes["id"] != null) 
                {
                    if (stepValueNode.Attributes["id"] != null) 
                    {
                        stepValueIDRef_ = stepValueNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(stepValueNode);
                        IDManager.SetID(stepValueIDRef_, ob);
                    }
                    else if (stepValueNode.Attributes["href"] != null)
                    {
                        stepValueIDRef_ = stepValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepValue_ = new PositiveDecimal(stepValueNode);
                    }
                }
                else
                {
                    stepValue_ = new PositiveDecimal(stepValueNode);
                }
            }
            
        
        }
        
    
        #region StepValue_
        private PositiveDecimal stepValue_;
        public PositiveDecimal StepValue_
        {
            get
            {
                if (this.stepValue_ != null)
                {
                    return this.stepValue_; 
                }
                else if (this.stepValueIDRef_ != null)
                {
                    stepValue_ = IDManager.getID(stepValueIDRef_) as PositiveDecimal;
                    return this.stepValue_; 
                }
                else
                {
                      return this.stepValue_; 
                }
            }
            set
            {
                if (this.stepValue_ != value)
                {
                    this.stepValue_ = value;
                }
            }
        }
        #endregion
        
        public string stepValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

