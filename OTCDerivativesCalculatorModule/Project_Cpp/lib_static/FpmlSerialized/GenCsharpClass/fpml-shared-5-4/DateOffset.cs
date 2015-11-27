using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateOffset
    {
        public DateOffset(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

