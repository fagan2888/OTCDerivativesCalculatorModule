using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PhysicalSettlementPeriod
    {
        public PhysicalSettlementPeriod(XmlNode xmlNode)
        {
            XmlNodeList businessDaysNotSpecifiedNodeList = xmlNode.SelectNodes("businessDaysNotSpecified");
            if (businessDaysNotSpecifiedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDaysNotSpecifiedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDaysNotSpecifiedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(businessDaysNotSpecifiedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDaysNotSpecifiedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDaysNotSpecified = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList businessDaysNodeList = xmlNode.SelectNodes("businessDays");
            if (businessDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDaysIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(businessDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDays = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList maximumBusinessDaysNodeList = xmlNode.SelectNodes("maximumBusinessDays");
            if (maximumBusinessDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumBusinessDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumBusinessDaysIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(maximumBusinessDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumBusinessDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumBusinessDays = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDaysNotSpecified
        private XsdTypeBoolean businessDaysNotSpecified;
        public XsdTypeBoolean BusinessDaysNotSpecified
        {
            get
            {
                if (this.businessDaysNotSpecified != null)
                {
                    return this.businessDaysNotSpecified; 
                }
                else if (this.businessDaysNotSpecifiedIDRef != null)
                {
                    businessDaysNotSpecified = IDManager.getID(businessDaysNotSpecifiedIDRef) as XsdTypeBoolean;
                    return this.businessDaysNotSpecified; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDaysNotSpecified != value)
                {
                    this.businessDaysNotSpecified = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region BusinessDays
        private XsdTypeNonNegativeInteger businessDays;
        public XsdTypeNonNegativeInteger BusinessDays
        {
            get
            {
                if (this.businessDays != null)
                {
                    return this.businessDays; 
                }
                else if (this.businessDaysIDRef != null)
                {
                    businessDays = IDManager.getID(businessDaysIDRef) as XsdTypeNonNegativeInteger;
                    return this.businessDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDays != value)
                {
                    this.businessDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region MaximumBusinessDays
        private XsdTypeNonNegativeInteger maximumBusinessDays;
        public XsdTypeNonNegativeInteger MaximumBusinessDays
        {
            get
            {
                if (this.maximumBusinessDays != null)
                {
                    return this.maximumBusinessDays; 
                }
                else if (this.maximumBusinessDaysIDRef != null)
                {
                    maximumBusinessDays = IDManager.getID(maximumBusinessDaysIDRef) as XsdTypeNonNegativeInteger;
                    return this.maximumBusinessDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumBusinessDays != value)
                {
                    this.maximumBusinessDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

