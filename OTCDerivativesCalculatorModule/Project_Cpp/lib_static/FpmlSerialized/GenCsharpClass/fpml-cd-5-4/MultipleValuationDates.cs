using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MultipleValuationDates
    {
        public MultipleValuationDates(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList businessDaysThereafterNodeList = xmlNode.SelectNodes("businessDaysThereafter");
            if (businessDaysThereafterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDaysThereafterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDaysThereafterIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(businessDaysThereafterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDaysThereafterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDaysThereafter = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList numberValuationDatesNodeList = xmlNode.SelectNodes("numberValuationDates");
            if (numberValuationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberValuationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberValuationDatesIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(numberValuationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberValuationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberValuationDates = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDaysThereafter
        private XsdTypePositiveInteger businessDaysThereafter;
        public XsdTypePositiveInteger BusinessDaysThereafter
        {
            get
            {
                if (this.businessDaysThereafter != null)
                {
                    return this.businessDaysThereafter; 
                }
                else if (this.businessDaysThereafterIDRef != null)
                {
                    businessDaysThereafter = IDManager.getID(businessDaysThereafterIDRef) as XsdTypePositiveInteger;
                    return this.businessDaysThereafter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDaysThereafter != value)
                {
                    this.businessDaysThereafter = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region NumberValuationDates
        private XsdTypePositiveInteger numberValuationDates;
        public XsdTypePositiveInteger NumberValuationDates
        {
            get
            {
                if (this.numberValuationDates != null)
                {
                    return this.numberValuationDates; 
                }
                else if (this.numberValuationDatesIDRef != null)
                {
                    numberValuationDates = IDManager.getID(numberValuationDatesIDRef) as XsdTypePositiveInteger;
                    return this.numberValuationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberValuationDates != value)
                {
                    this.numberValuationDates = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

