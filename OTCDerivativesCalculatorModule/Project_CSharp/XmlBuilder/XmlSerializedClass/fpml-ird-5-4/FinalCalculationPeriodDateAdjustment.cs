using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FinalCalculationPeriodDateAdjustment : ISerialized
    {
        public FinalCalculationPeriodDateAdjustment(XmlNode xmlNode)
        {
            XmlNode relevantUnderlyingDateReferenceNode = xmlNode.SelectSingleNode("relevantUnderlyingDateReference");
            
            if (relevantUnderlyingDateReferenceNode != null)
            {
                if (relevantUnderlyingDateReferenceNode.Attributes["href"] != null || relevantUnderlyingDateReferenceNode.Attributes["id"] != null) 
                {
                    if (relevantUnderlyingDateReferenceNode.Attributes["id"] != null) 
                    {
                        relevantUnderlyingDateReferenceIDRef_ = relevantUnderlyingDateReferenceNode.Attributes["id"].Value;
                        RelevantUnderlyingDateReference ob = new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode);
                        IDManager.SetID(relevantUnderlyingDateReferenceIDRef_, ob);
                    }
                    else if (relevantUnderlyingDateReferenceNode.Attributes["href"] != null)
                    {
                        relevantUnderlyingDateReferenceIDRef_ = relevantUnderlyingDateReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relevantUnderlyingDateReference_ = new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode);
                    }
                }
                else
                {
                    relevantUnderlyingDateReference_ = new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode);
                }
            }
            
        
            XmlNode swapStreamReferenceNode = xmlNode.SelectSingleNode("swapStreamReference");
            
            if (swapStreamReferenceNode != null)
            {
                if (swapStreamReferenceNode.Attributes["href"] != null || swapStreamReferenceNode.Attributes["id"] != null) 
                {
                    if (swapStreamReferenceNode.Attributes["id"] != null) 
                    {
                        swapStreamReferenceIDRef_ = swapStreamReferenceNode.Attributes["id"].Value;
                        InterestRateStreamReference ob = new InterestRateStreamReference(swapStreamReferenceNode);
                        IDManager.SetID(swapStreamReferenceIDRef_, ob);
                    }
                    else if (swapStreamReferenceNode.Attributes["href"] != null)
                    {
                        swapStreamReferenceIDRef_ = swapStreamReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapStreamReference_ = new InterestRateStreamReference(swapStreamReferenceNode);
                    }
                }
                else
                {
                    swapStreamReference_ = new InterestRateStreamReference(swapStreamReferenceNode);
                }
            }
            
        
            XmlNode businessDayConventionNode = xmlNode.SelectSingleNode("businessDayConvention");
            
            if (businessDayConventionNode != null)
            {
                if (businessDayConventionNode.Attributes["href"] != null || businessDayConventionNode.Attributes["id"] != null) 
                {
                    if (businessDayConventionNode.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["id"].Value;
                        BusinessDayConventionEnum ob = new BusinessDayConventionEnum(businessDayConventionNode);
                        IDManager.SetID(businessDayConventionIDRef_, ob);
                    }
                    else if (businessDayConventionNode.Attributes["href"] != null)
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                    }
                }
                else
                {
                    businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                }
            }
            
        
        }
        
    
        #region RelevantUnderlyingDateReference_
        private RelevantUnderlyingDateReference relevantUnderlyingDateReference_;
        public RelevantUnderlyingDateReference RelevantUnderlyingDateReference_
        {
            get
            {
                if (this.relevantUnderlyingDateReference_ != null)
                {
                    return this.relevantUnderlyingDateReference_; 
                }
                else if (this.relevantUnderlyingDateReferenceIDRef_ != null)
                {
                    relevantUnderlyingDateReference_ = IDManager.getID(relevantUnderlyingDateReferenceIDRef_) as RelevantUnderlyingDateReference;
                    return this.relevantUnderlyingDateReference_; 
                }
                else
                {
                      return this.relevantUnderlyingDateReference_; 
                }
            }
            set
            {
                if (this.relevantUnderlyingDateReference_ != value)
                {
                    this.relevantUnderlyingDateReference_ = value;
                }
            }
        }
        #endregion
        
        public string relevantUnderlyingDateReferenceIDRef_ { get; set; }
        #region SwapStreamReference_
        private InterestRateStreamReference swapStreamReference_;
        public InterestRateStreamReference SwapStreamReference_
        {
            get
            {
                if (this.swapStreamReference_ != null)
                {
                    return this.swapStreamReference_; 
                }
                else if (this.swapStreamReferenceIDRef_ != null)
                {
                    swapStreamReference_ = IDManager.getID(swapStreamReferenceIDRef_) as InterestRateStreamReference;
                    return this.swapStreamReference_; 
                }
                else
                {
                      return this.swapStreamReference_; 
                }
            }
            set
            {
                if (this.swapStreamReference_ != value)
                {
                    this.swapStreamReference_ = value;
                }
            }
        }
        #endregion
        
        public string swapStreamReferenceIDRef_ { get; set; }
        #region BusinessDayConvention_
        private BusinessDayConventionEnum businessDayConvention_;
        public BusinessDayConventionEnum BusinessDayConvention_
        {
            get
            {
                if (this.businessDayConvention_ != null)
                {
                    return this.businessDayConvention_; 
                }
                else if (this.businessDayConventionIDRef_ != null)
                {
                    businessDayConvention_ = IDManager.getID(businessDayConventionIDRef_) as BusinessDayConventionEnum;
                    return this.businessDayConvention_; 
                }
                else
                {
                      return this.businessDayConvention_; 
                }
            }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayConventionIDRef_ { get; set; }
        
    
        
    
    }
    
}

