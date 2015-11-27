using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Compounding
    {
        public Compounding(XmlNode xmlNode)
        {
            XmlNodeList compoundingMethodNodeList = xmlNode.SelectNodes("compoundingMethod");
            if (compoundingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef = item.Attributes["id"].Name;
                        CompoundingMethodEnum ob = CompoundingMethodEnum();
                        IDManager.SetID(compoundingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingMethod = new CompoundingMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList compoundingRateNodeList = xmlNode.SelectNodes("compoundingRate");
            if (compoundingRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingRateIDRef = item.Attributes["id"].Name;
                        CompoundingRate ob = CompoundingRate();
                        IDManager.SetID(compoundingRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingRate = new CompoundingRate(item);
                    }
                }
            }
            
        
            XmlNodeList compoundingSpreadNodeList = xmlNode.SelectNodes("compoundingSpread");
            if (compoundingSpreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingSpreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingSpreadIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(compoundingSpreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingSpreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingSpread = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList compoundingDatesNodeList = xmlNode.SelectNodes("compoundingDates");
            if (compoundingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates2 ob = AdjustableRelativeOrPeriodicDates2();
                        IDManager.SetID(compoundingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingDates = new AdjustableRelativeOrPeriodicDates2(item);
                    }
                }
            }
            
        
        }
        
    
        #region CompoundingMethod
        private CompoundingMethodEnum compoundingMethod;
        public CompoundingMethodEnum CompoundingMethod
        {
            get
            {
                if (this.compoundingMethod != null)
                {
                    return this.compoundingMethod; 
                }
                else if (this.compoundingMethodIDRef != null)
                {
                    compoundingMethod = IDManager.getID(compoundingMethodIDRef) as CompoundingMethodEnum;
                    return this.compoundingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingMethod != value)
                {
                    this.compoundingMethod = value;
                }
            }
        }
        #endregion
        
        public string CompoundingMethodEnumIDRef { get; set; }
        #region CompoundingRate
        private CompoundingRate compoundingRate;
        public CompoundingRate CompoundingRate
        {
            get
            {
                if (this.compoundingRate != null)
                {
                    return this.compoundingRate; 
                }
                else if (this.compoundingRateIDRef != null)
                {
                    compoundingRate = IDManager.getID(compoundingRateIDRef) as CompoundingRate;
                    return this.compoundingRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingRate != value)
                {
                    this.compoundingRate = value;
                }
            }
        }
        #endregion
        
        public string CompoundingRateIDRef { get; set; }
        #region CompoundingSpread
        private XsdTypeDecimal compoundingSpread;
        public XsdTypeDecimal CompoundingSpread
        {
            get
            {
                if (this.compoundingSpread != null)
                {
                    return this.compoundingSpread; 
                }
                else if (this.compoundingSpreadIDRef != null)
                {
                    compoundingSpread = IDManager.getID(compoundingSpreadIDRef) as XsdTypeDecimal;
                    return this.compoundingSpread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingSpread != value)
                {
                    this.compoundingSpread = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region CompoundingDates
        private AdjustableRelativeOrPeriodicDates2 compoundingDates;
        public AdjustableRelativeOrPeriodicDates2 CompoundingDates
        {
            get
            {
                if (this.compoundingDates != null)
                {
                    return this.compoundingDates; 
                }
                else if (this.compoundingDatesIDRef != null)
                {
                    compoundingDates = IDManager.getID(compoundingDatesIDRef) as AdjustableRelativeOrPeriodicDates2;
                    return this.compoundingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingDates != value)
                {
                    this.compoundingDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDates2IDRef { get; set; }
        
    
        
    
    }
    
}

