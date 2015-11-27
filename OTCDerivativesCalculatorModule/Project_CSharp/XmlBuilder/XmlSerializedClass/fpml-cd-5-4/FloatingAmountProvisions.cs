using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingAmountProvisions : ISerialized
    {
        public FloatingAmountProvisions(XmlNode xmlNode)
        {
            XmlNode WACCapInterestProvisionNode = xmlNode.SelectSingleNode("WACCapInterestProvision");
            
            if (WACCapInterestProvisionNode != null)
            {
                if (WACCapInterestProvisionNode.Attributes["href"] != null || WACCapInterestProvisionNode.Attributes["id"] != null) 
                {
                    if (WACCapInterestProvisionNode.Attributes["id"] != null) 
                    {
                        WACCapInterestProvisionIDRef_ = WACCapInterestProvisionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(WACCapInterestProvisionNode);
                        IDManager.SetID(WACCapInterestProvisionIDRef_, ob);
                    }
                    else if (WACCapInterestProvisionNode.Attributes["href"] != null)
                    {
                        WACCapInterestProvisionIDRef_ = WACCapInterestProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        WACCapInterestProvision_ = new XsdTypeBoolean(WACCapInterestProvisionNode);
                    }
                }
                else
                {
                    WACCapInterestProvision_ = new XsdTypeBoolean(WACCapInterestProvisionNode);
                }
            }
            
        
            XmlNode stepUpProvisionNode = xmlNode.SelectSingleNode("stepUpProvision");
            
            if (stepUpProvisionNode != null)
            {
                if (stepUpProvisionNode.Attributes["href"] != null || stepUpProvisionNode.Attributes["id"] != null) 
                {
                    if (stepUpProvisionNode.Attributes["id"] != null) 
                    {
                        stepUpProvisionIDRef_ = stepUpProvisionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(stepUpProvisionNode);
                        IDManager.SetID(stepUpProvisionIDRef_, ob);
                    }
                    else if (stepUpProvisionNode.Attributes["href"] != null)
                    {
                        stepUpProvisionIDRef_ = stepUpProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepUpProvision_ = new XsdTypeBoolean(stepUpProvisionNode);
                    }
                }
                else
                {
                    stepUpProvision_ = new XsdTypeBoolean(stepUpProvisionNode);
                }
            }
            
        
        }
        
    
        #region WACCapInterestProvision_
        private XsdTypeBoolean WACCapInterestProvision_;
        public XsdTypeBoolean WACCapInterestProvision_
        {
            get
            {
                if (this.WACCapInterestProvision_ != null)
                {
                    return this.WACCapInterestProvision_; 
                }
                else if (this.WACCapInterestProvisionIDRef_ != null)
                {
                    WACCapInterestProvision_ = IDManager.getID(WACCapInterestProvisionIDRef_) as XsdTypeBoolean;
                    return this.WACCapInterestProvision_; 
                }
                else
                {
                      return this.WACCapInterestProvision_; 
                }
            }
            set
            {
                if (this.WACCapInterestProvision_ != value)
                {
                    this.WACCapInterestProvision_ = value;
                }
            }
        }
        #endregion
        
        public string WACCapInterestProvisionIDRef_ { get; set; }
        #region StepUpProvision_
        private XsdTypeBoolean stepUpProvision_;
        public XsdTypeBoolean StepUpProvision_
        {
            get
            {
                if (this.stepUpProvision_ != null)
                {
                    return this.stepUpProvision_; 
                }
                else if (this.stepUpProvisionIDRef_ != null)
                {
                    stepUpProvision_ = IDManager.getID(stepUpProvisionIDRef_) as XsdTypeBoolean;
                    return this.stepUpProvision_; 
                }
                else
                {
                      return this.stepUpProvision_; 
                }
            }
            set
            {
                if (this.stepUpProvision_ != value)
                {
                    this.stepUpProvision_ = value;
                }
            }
        }
        #endregion
        
        public string stepUpProvisionIDRef_ { get; set; }
        
    
        
    
    }
    
}

