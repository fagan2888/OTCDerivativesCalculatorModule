using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationAmount : Money
    {
        public CalculationAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            
            if (stepNodeList != null)
            {
                this.step_ = new List<Step>();
                foreach (XmlNode item in stepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            stepIDRef_ = item.Attributes["id"].Value;
                            step_.Add(new Step(item));
                            IDManager.SetID(stepIDRef_, step_[step_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            stepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        step_.Add(new Step(item));
                        }
                    }
                    else
                    {
                        step_.Add(new Step(item));
                    }
                }
            }
            
        
        }
        
    
        #region Step_
        private List<Step> step_;
        public List<Step> Step_
        {
            get
            {
                if (this.step_ != null)
                {
                    return this.step_; 
                }
                else if (this.stepIDRef_ != null)
                {
                    return this.step_; 
                }
                else
                {
                      return this.step_; 
                }
            }
            set
            {
                if (this.step_ != value)
                {
                    this.step_ = value;
                }
            }
        }
        #endregion
        
        public string stepIDRef_ { get; set; }
        
    
        
    
    }
    
}

