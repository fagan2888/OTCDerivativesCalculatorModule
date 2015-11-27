using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MultipleValuationDates : SingleValuationDate
    {
        public MultipleValuationDates(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode businessDaysThereafterNode = xmlNode.SelectSingleNode("businessDaysThereafter");
            
            if (businessDaysThereafterNode != null)
            {
                if (businessDaysThereafterNode.Attributes["href"] != null || businessDaysThereafterNode.Attributes["id"] != null) 
                {
                    if (businessDaysThereafterNode.Attributes["id"] != null) 
                    {
                        businessDaysThereafterIDRef_ = businessDaysThereafterNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(businessDaysThereafterNode);
                        IDManager.SetID(businessDaysThereafterIDRef_, ob);
                    }
                    else if (businessDaysThereafterNode.Attributes["href"] != null)
                    {
                        businessDaysThereafterIDRef_ = businessDaysThereafterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDaysThereafter_ = new XsdTypePositiveInteger(businessDaysThereafterNode);
                    }
                }
                else
                {
                    businessDaysThereafter_ = new XsdTypePositiveInteger(businessDaysThereafterNode);
                }
            }
            
        
            XmlNode numberValuationDatesNode = xmlNode.SelectSingleNode("numberValuationDates");
            
            if (numberValuationDatesNode != null)
            {
                if (numberValuationDatesNode.Attributes["href"] != null || numberValuationDatesNode.Attributes["id"] != null) 
                {
                    if (numberValuationDatesNode.Attributes["id"] != null) 
                    {
                        numberValuationDatesIDRef_ = numberValuationDatesNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(numberValuationDatesNode);
                        IDManager.SetID(numberValuationDatesIDRef_, ob);
                    }
                    else if (numberValuationDatesNode.Attributes["href"] != null)
                    {
                        numberValuationDatesIDRef_ = numberValuationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberValuationDates_ = new XsdTypePositiveInteger(numberValuationDatesNode);
                    }
                }
                else
                {
                    numberValuationDates_ = new XsdTypePositiveInteger(numberValuationDatesNode);
                }
            }
            
        
        }
        
    
        #region BusinessDaysThereafter_
        private XsdTypePositiveInteger businessDaysThereafter_;
        public XsdTypePositiveInteger BusinessDaysThereafter_
        {
            get
            {
                if (this.businessDaysThereafter_ != null)
                {
                    return this.businessDaysThereafter_; 
                }
                else if (this.businessDaysThereafterIDRef_ != null)
                {
                    businessDaysThereafter_ = IDManager.getID(businessDaysThereafterIDRef_) as XsdTypePositiveInteger;
                    return this.businessDaysThereafter_; 
                }
                else
                {
                      return this.businessDaysThereafter_; 
                }
            }
            set
            {
                if (this.businessDaysThereafter_ != value)
                {
                    this.businessDaysThereafter_ = value;
                }
            }
        }
        #endregion
        
        public string businessDaysThereafterIDRef_ { get; set; }
        #region NumberValuationDates_
        private XsdTypePositiveInteger numberValuationDates_;
        public XsdTypePositiveInteger NumberValuationDates_
        {
            get
            {
                if (this.numberValuationDates_ != null)
                {
                    return this.numberValuationDates_; 
                }
                else if (this.numberValuationDatesIDRef_ != null)
                {
                    numberValuationDates_ = IDManager.getID(numberValuationDatesIDRef_) as XsdTypePositiveInteger;
                    return this.numberValuationDates_; 
                }
                else
                {
                      return this.numberValuationDates_; 
                }
            }
            set
            {
                if (this.numberValuationDates_ != value)
                {
                    this.numberValuationDates_ = value;
                }
            }
        }
        #endregion
        
        public string numberValuationDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

