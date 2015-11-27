using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxFixingDate
    {
        public FxFixingDate(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList businessDayConventionNodeList = xmlNode.SelectNodes("businessDayConvention");
            if (businessDayConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDayConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef = item.Attributes["id"].Name;
                        BusinessDayConventionEnum ob = BusinessDayConventionEnum();
                        IDManager.SetID(businessDayConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDayConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDayConvention = new BusinessDayConventionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersReferenceNodeList = xmlNode.SelectNodes("businessCentersReference");
            if (businessCentersReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef = item.Attributes["id"].Name;
                        BusinessCentersReference ob = BusinessCentersReference();
                        IDManager.SetID(businessCentersReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCentersReference = new BusinessCentersReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersNodeList = xmlNode.SelectNodes("businessCenters");
            if (businessCentersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersIDRef = item.Attributes["id"].Name;
                        BusinessCenters ob = BusinessCenters();
                        IDManager.SetID(businessCentersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenters = new BusinessCenters(item);
                    }
                }
            }
            
        
            XmlNodeList dateRelativeToPaymentDatesNodeList = xmlNode.SelectNodes("dateRelativeToPaymentDates");
            if (dateRelativeToPaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateRelativeToPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateRelativeToPaymentDatesIDRef = item.Attributes["id"].Name;
                        DateRelativeToPaymentDates ob = DateRelativeToPaymentDates();
                        IDManager.SetID(dateRelativeToPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateRelativeToPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateRelativeToPaymentDates = new DateRelativeToPaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList dateRelativeToCalculationPeriodDatesNodeList = xmlNode.SelectNodes("dateRelativeToCalculationPeriodDates");
            if (dateRelativeToCalculationPeriodDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateRelativeToCalculationPeriodDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateRelativeToCalculationPeriodDatesIDRef = item.Attributes["id"].Name;
                        DateRelativeToCalculationPeriodDates ob = DateRelativeToCalculationPeriodDates();
                        IDManager.SetID(dateRelativeToCalculationPeriodDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateRelativeToCalculationPeriodDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateRelativeToCalculationPeriodDates = new DateRelativeToCalculationPeriodDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDayConvention
        private BusinessDayConventionEnum businessDayConvention;
        public BusinessDayConventionEnum BusinessDayConvention
        {
            get
            {
                if (this.businessDayConvention != null)
                {
                    return this.businessDayConvention; 
                }
                else if (this.businessDayConventionIDRef != null)
                {
                    businessDayConvention = IDManager.getID(businessDayConventionIDRef) as BusinessDayConventionEnum;
                    return this.businessDayConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDayConvention != value)
                {
                    this.businessDayConvention = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayConventionEnumIDRef { get; set; }
        #region BusinessCentersReference
        private BusinessCentersReference businessCentersReference;
        public BusinessCentersReference BusinessCentersReference
        {
            get
            {
                if (this.businessCentersReference != null)
                {
                    return this.businessCentersReference; 
                }
                else if (this.businessCentersReferenceIDRef != null)
                {
                    businessCentersReference = IDManager.getID(businessCentersReferenceIDRef) as BusinessCentersReference;
                    return this.businessCentersReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCentersReference != value)
                {
                    this.businessCentersReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersReferenceIDRef { get; set; }
        #region BusinessCenters
        private BusinessCenters businessCenters;
        public BusinessCenters BusinessCenters
        {
            get
            {
                if (this.businessCenters != null)
                {
                    return this.businessCenters; 
                }
                else if (this.businessCentersIDRef != null)
                {
                    businessCenters = IDManager.getID(businessCentersIDRef) as BusinessCenters;
                    return this.businessCenters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenters != value)
                {
                    this.businessCenters = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersIDRef { get; set; }
        #region DateRelativeToPaymentDates
        private DateRelativeToPaymentDates dateRelativeToPaymentDates;
        public DateRelativeToPaymentDates DateRelativeToPaymentDates
        {
            get
            {
                if (this.dateRelativeToPaymentDates != null)
                {
                    return this.dateRelativeToPaymentDates; 
                }
                else if (this.dateRelativeToPaymentDatesIDRef != null)
                {
                    dateRelativeToPaymentDates = IDManager.getID(dateRelativeToPaymentDatesIDRef) as DateRelativeToPaymentDates;
                    return this.dateRelativeToPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateRelativeToPaymentDates != value)
                {
                    this.dateRelativeToPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string DateRelativeToPaymentDatesIDRef { get; set; }
        #region DateRelativeToCalculationPeriodDates
        private DateRelativeToCalculationPeriodDates dateRelativeToCalculationPeriodDates;
        public DateRelativeToCalculationPeriodDates DateRelativeToCalculationPeriodDates
        {
            get
            {
                if (this.dateRelativeToCalculationPeriodDates != null)
                {
                    return this.dateRelativeToCalculationPeriodDates; 
                }
                else if (this.dateRelativeToCalculationPeriodDatesIDRef != null)
                {
                    dateRelativeToCalculationPeriodDates = IDManager.getID(dateRelativeToCalculationPeriodDatesIDRef) as DateRelativeToCalculationPeriodDates;
                    return this.dateRelativeToCalculationPeriodDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateRelativeToCalculationPeriodDates != value)
                {
                    this.dateRelativeToCalculationPeriodDates = value;
                }
            }
        }
        #endregion
        
        public string DateRelativeToCalculationPeriodDatesIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

