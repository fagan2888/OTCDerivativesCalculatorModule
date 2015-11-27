using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PositiveSchedule : ISerialized
    {
        public PositiveSchedule(XmlNode xmlNode)
        {
            XmlNode initialValueNode = xmlNode.SelectSingleNode("initialValue");
            
            if (initialValueNode != null)
            {
                if (initialValueNode.Attributes["href"] != null || initialValueNode.Attributes["id"] != null) 
                {
                    if (initialValueNode.Attributes["id"] != null) 
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(initialValueNode);
                        IDManager.SetID(initialValueIDRef_, ob);
                    }
                    else if (initialValueNode.Attributes["href"] != null)
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialValue_ = new PositiveDecimal(initialValueNode);
                    }
                }
                else
                {
                    initialValue_ = new PositiveDecimal(initialValueNode);
                }
            }
            
        
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            
            if (stepNodeList != null)
            {
                this.step_ = new List<PositiveStep>();
                foreach (XmlNode item in stepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            stepIDRef_ = item.Attributes["id"].Value;
                            step_.Add(new PositiveStep(item));
                            IDManager.SetID(stepIDRef_, step_[step_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            stepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        step_.Add(new PositiveStep(item));
                        }
                    }
                    else
                    {
                        step_.Add(new PositiveStep(item));
                    }
                }
            }
            
        
        }
        
    
        #region InitialValue_
        private PositiveDecimal initialValue_;
        public PositiveDecimal InitialValue_
        {
            get
            {
                if (this.initialValue_ != null)
                {
                    return this.initialValue_; 
                }
                else if (this.initialValueIDRef_ != null)
                {
                    initialValue_ = IDManager.getID(initialValueIDRef_) as PositiveDecimal;
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
        private List<PositiveStep> step_;
        public List<PositiveStep> Step_
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

