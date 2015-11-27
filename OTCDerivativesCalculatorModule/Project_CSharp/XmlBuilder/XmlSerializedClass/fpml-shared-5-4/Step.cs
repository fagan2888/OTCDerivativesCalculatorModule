using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Step : StepBase
    {
        public Step(XmlNode xmlNode)
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
                        XsdTypeDecimal ob = new XsdTypeDecimal(stepValueNode);
                        IDManager.SetID(stepValueIDRef_, ob);
                    }
                    else if (stepValueNode.Attributes["href"] != null)
                    {
                        stepValueIDRef_ = stepValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepValue_ = new XsdTypeDecimal(stepValueNode);
                    }
                }
                else
                {
                    stepValue_ = new XsdTypeDecimal(stepValueNode);
                }
            }
            
        
        }
        
    
        #region StepValue_
        private XsdTypeDecimal stepValue_;
        public XsdTypeDecimal StepValue_
        {
            get
            {
                if (this.stepValue_ != null)
                {
                    return this.stepValue_; 
                }
                else if (this.stepValueIDRef_ != null)
                {
                    stepValue_ = IDManager.getID(stepValueIDRef_) as XsdTypeDecimal;
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

