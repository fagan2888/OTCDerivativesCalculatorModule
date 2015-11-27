using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FinalCalculationPeriodDateAdjustment
    {
        public FinalCalculationPeriodDateAdjustment(XmlNode xmlNode)
        {
            XmlNodeList relevantUnderlyingDateReferenceNodeList = xmlNode.SelectNodes("relevantUnderlyingDateReference");
            if (relevantUnderlyingDateReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relevantUnderlyingDateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relevantUnderlyingDateReferenceIDRef = item.Attributes["id"].Name;
                        RelevantUnderlyingDateReference ob = RelevantUnderlyingDateReference();
                        IDManager.SetID(relevantUnderlyingDateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relevantUnderlyingDateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relevantUnderlyingDateReference = new RelevantUnderlyingDateReference(item);
                    }
                }
            }
            
        
            XmlNodeList swapStreamReferenceNodeList = xmlNode.SelectNodes("swapStreamReference");
            if (swapStreamReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swapStreamReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapStreamReferenceIDRef = item.Attributes["id"].Name;
                        InterestRateStreamReference ob = InterestRateStreamReference();
                        IDManager.SetID(swapStreamReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapStreamReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swapStreamReference = new InterestRateStreamReference(item);
                    }
                }
            }
            
        
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
            
        
        }
        
    
        #region RelevantUnderlyingDateReference
        private RelevantUnderlyingDateReference relevantUnderlyingDateReference;
        public RelevantUnderlyingDateReference RelevantUnderlyingDateReference
        {
            get
            {
                if (this.relevantUnderlyingDateReference != null)
                {
                    return this.relevantUnderlyingDateReference; 
                }
                else if (this.relevantUnderlyingDateReferenceIDRef != null)
                {
                    relevantUnderlyingDateReference = IDManager.getID(relevantUnderlyingDateReferenceIDRef) as RelevantUnderlyingDateReference;
                    return this.relevantUnderlyingDateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relevantUnderlyingDateReference != value)
                {
                    this.relevantUnderlyingDateReference = value;
                }
            }
        }
        #endregion
        
        public string RelevantUnderlyingDateReferenceIDRef { get; set; }
        #region SwapStreamReference
        private InterestRateStreamReference swapStreamReference;
        public InterestRateStreamReference SwapStreamReference
        {
            get
            {
                if (this.swapStreamReference != null)
                {
                    return this.swapStreamReference; 
                }
                else if (this.swapStreamReferenceIDRef != null)
                {
                    swapStreamReference = IDManager.getID(swapStreamReferenceIDRef) as InterestRateStreamReference;
                    return this.swapStreamReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swapStreamReference != value)
                {
                    this.swapStreamReference = value;
                }
            }
        }
        #endregion
        
        public string InterestRateStreamReferenceIDRef { get; set; }
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
        
    
        
    
    }
    
}

