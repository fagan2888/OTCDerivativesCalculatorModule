using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxFixingDate : Offset
    {
        public FxFixingDate(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode businessCentersReferenceNode = xmlNode.SelectSingleNode("businessCentersReference");
            
            if (businessCentersReferenceNode != null)
            {
                if (businessCentersReferenceNode.Attributes["href"] != null || businessCentersReferenceNode.Attributes["id"] != null) 
                {
                    if (businessCentersReferenceNode.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["id"].Value;
                        BusinessCentersReference ob = new BusinessCentersReference(businessCentersReferenceNode);
                        IDManager.SetID(businessCentersReferenceIDRef_, ob);
                    }
                    else if (businessCentersReferenceNode.Attributes["href"] != null)
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                    }
                }
                else
                {
                    businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                }
            }
            
        
            XmlNode businessCentersNode = xmlNode.SelectSingleNode("businessCenters");
            
            if (businessCentersNode != null)
            {
                if (businessCentersNode.Attributes["href"] != null || businessCentersNode.Attributes["id"] != null) 
                {
                    if (businessCentersNode.Attributes["id"] != null) 
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["id"].Value;
                        BusinessCenters ob = new BusinessCenters(businessCentersNode);
                        IDManager.SetID(businessCentersIDRef_, ob);
                    }
                    else if (businessCentersNode.Attributes["href"] != null)
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenters_ = new BusinessCenters(businessCentersNode);
                    }
                }
                else
                {
                    businessCenters_ = new BusinessCenters(businessCentersNode);
                }
            }
            
        
            XmlNode dateRelativeToPaymentDatesNode = xmlNode.SelectSingleNode("dateRelativeToPaymentDates");
            
            if (dateRelativeToPaymentDatesNode != null)
            {
                if (dateRelativeToPaymentDatesNode.Attributes["href"] != null || dateRelativeToPaymentDatesNode.Attributes["id"] != null) 
                {
                    if (dateRelativeToPaymentDatesNode.Attributes["id"] != null) 
                    {
                        dateRelativeToPaymentDatesIDRef_ = dateRelativeToPaymentDatesNode.Attributes["id"].Value;
                        DateRelativeToPaymentDates ob = new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode);
                        IDManager.SetID(dateRelativeToPaymentDatesIDRef_, ob);
                    }
                    else if (dateRelativeToPaymentDatesNode.Attributes["href"] != null)
                    {
                        dateRelativeToPaymentDatesIDRef_ = dateRelativeToPaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateRelativeToPaymentDates_ = new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode);
                    }
                }
                else
                {
                    dateRelativeToPaymentDates_ = new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode);
                }
            }
            
        
            XmlNode dateRelativeToCalculationPeriodDatesNode = xmlNode.SelectSingleNode("dateRelativeToCalculationPeriodDates");
            
            if (dateRelativeToCalculationPeriodDatesNode != null)
            {
                if (dateRelativeToCalculationPeriodDatesNode.Attributes["href"] != null || dateRelativeToCalculationPeriodDatesNode.Attributes["id"] != null) 
                {
                    if (dateRelativeToCalculationPeriodDatesNode.Attributes["id"] != null) 
                    {
                        dateRelativeToCalculationPeriodDatesIDRef_ = dateRelativeToCalculationPeriodDatesNode.Attributes["id"].Value;
                        DateRelativeToCalculationPeriodDates ob = new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode);
                        IDManager.SetID(dateRelativeToCalculationPeriodDatesIDRef_, ob);
                    }
                    else if (dateRelativeToCalculationPeriodDatesNode.Attributes["href"] != null)
                    {
                        dateRelativeToCalculationPeriodDatesIDRef_ = dateRelativeToCalculationPeriodDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateRelativeToCalculationPeriodDates_ = new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode);
                    }
                }
                else
                {
                    dateRelativeToCalculationPeriodDates_ = new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode);
                }
            }
            
        
        }
        
    
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
        #region BusinessCentersReference_
        private BusinessCentersReference businessCentersReference_;
        public BusinessCentersReference BusinessCentersReference_
        {
            get
            {
                if (this.businessCentersReference_ != null)
                {
                    return this.businessCentersReference_; 
                }
                else if (this.businessCentersReferenceIDRef_ != null)
                {
                    businessCentersReference_ = IDManager.getID(businessCentersReferenceIDRef_) as BusinessCentersReference;
                    return this.businessCentersReference_; 
                }
                else
                {
                      return this.businessCentersReference_; 
                }
            }
            set
            {
                if (this.businessCentersReference_ != value)
                {
                    this.businessCentersReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersReferenceIDRef_ { get; set; }
        #region BusinessCenters_
        private BusinessCenters businessCenters_;
        public BusinessCenters BusinessCenters_
        {
            get
            {
                if (this.businessCenters_ != null)
                {
                    return this.businessCenters_; 
                }
                else if (this.businessCentersIDRef_ != null)
                {
                    businessCenters_ = IDManager.getID(businessCentersIDRef_) as BusinessCenters;
                    return this.businessCenters_; 
                }
                else
                {
                      return this.businessCenters_; 
                }
            }
            set
            {
                if (this.businessCenters_ != value)
                {
                    this.businessCenters_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersIDRef_ { get; set; }
        #region DateRelativeToPaymentDates_
        private DateRelativeToPaymentDates dateRelativeToPaymentDates_;
        public DateRelativeToPaymentDates DateRelativeToPaymentDates_
        {
            get
            {
                if (this.dateRelativeToPaymentDates_ != null)
                {
                    return this.dateRelativeToPaymentDates_; 
                }
                else if (this.dateRelativeToPaymentDatesIDRef_ != null)
                {
                    dateRelativeToPaymentDates_ = IDManager.getID(dateRelativeToPaymentDatesIDRef_) as DateRelativeToPaymentDates;
                    return this.dateRelativeToPaymentDates_; 
                }
                else
                {
                      return this.dateRelativeToPaymentDates_; 
                }
            }
            set
            {
                if (this.dateRelativeToPaymentDates_ != value)
                {
                    this.dateRelativeToPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string dateRelativeToPaymentDatesIDRef_ { get; set; }
        #region DateRelativeToCalculationPeriodDates_
        private DateRelativeToCalculationPeriodDates dateRelativeToCalculationPeriodDates_;
        public DateRelativeToCalculationPeriodDates DateRelativeToCalculationPeriodDates_
        {
            get
            {
                if (this.dateRelativeToCalculationPeriodDates_ != null)
                {
                    return this.dateRelativeToCalculationPeriodDates_; 
                }
                else if (this.dateRelativeToCalculationPeriodDatesIDRef_ != null)
                {
                    dateRelativeToCalculationPeriodDates_ = IDManager.getID(dateRelativeToCalculationPeriodDatesIDRef_) as DateRelativeToCalculationPeriodDates;
                    return this.dateRelativeToCalculationPeriodDates_; 
                }
                else
                {
                      return this.dateRelativeToCalculationPeriodDates_; 
                }
            }
            set
            {
                if (this.dateRelativeToCalculationPeriodDates_ != value)
                {
                    this.dateRelativeToCalculationPeriodDates_ = value;
                }
            }
        }
        #endregion
        
        public string dateRelativeToCalculationPeriodDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

