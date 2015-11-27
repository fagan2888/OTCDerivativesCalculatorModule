using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NonNegativeSchedule : ISerialized
    {
        public NonNegativeSchedule(XmlNode xmlNode)
        {
            XmlNode initialValueNode = xmlNode.SelectSingleNode("initialValue");
            
            if (initialValueNode != null)
            {
                if (initialValueNode.Attributes["href"] != null || initialValueNode.Attributes["id"] != null) 
                {
                    if (initialValueNode.Attributes["id"] != null) 
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(initialValueNode);
                        IDManager.SetID(initialValueIDRef_, ob);
                    }
                    else if (initialValueNode.Attributes["href"] != null)
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialValue_ = new NonNegativeDecimal(initialValueNode);
                    }
                }
                else
                {
                    initialValue_ = new NonNegativeDecimal(initialValueNode);
                }
            }
            
        
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            
            if (stepNodeList != null)
            {
                this.step_ = new List<NonNegativeStep>();
                foreach (XmlNode item in stepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            stepIDRef_ = item.Attributes["id"].Value;
                            step_.Add(new NonNegativeStep(item));
                            IDManager.SetID(stepIDRef_, step_[step_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            stepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        step_.Add(new NonNegativeStep(item));
                        }
                    }
                    else
                    {
                        step_.Add(new NonNegativeStep(item));
                    }
                }
            }
            
        
        }
        
    
        #region InitialValue_
        private NonNegativeDecimal initialValue_;
        public NonNegativeDecimal InitialValue_
        {
            get
            {
                if (this.initialValue_ != null)
                {
                    return this.initialValue_; 
                }
                else if (this.initialValueIDRef_ != null)
                {
                    initialValue_ = IDManager.getID(initialValueIDRef_) as NonNegativeDecimal;
                    return this.initialValue_; 
                }
                else
                {
                      return this.initialValue_; 
                }
            }
            set
            {
                if (this.initialValue_ != value)
                {
                    this.initialValue_ = value;
                }
            }
        }
        #endregion
        
        public string initialValueIDRef_ { get; set; }
        #region Step_
        private List<NonNegativeStep> step_;
        public List<NonNegativeStep> Step_
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

