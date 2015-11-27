using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendPeriod
    {
        public DividendPeriod(XmlNode xmlNode)
        {
            XmlNodeList unadjustedStartDateNodeList = xmlNode.SelectNodes("unadjustedStartDate");
            if (unadjustedStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedStartDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(unadjustedStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedStartDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList unadjustedEndDateNodeList = xmlNode.SelectNodes("unadjustedEndDate");
            if (unadjustedEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedEndDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(unadjustedEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedEndDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList dateAdjustmentsNodeList = xmlNode.SelectNodes("dateAdjustments");
            if (dateAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(dateAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerReferenceNodeList = xmlNode.SelectNodes("underlyerReference");
            if (underlyerReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerReferenceIDRef = item.Attributes["id"].Name;
                        AssetReference ob = AssetReference();
                        IDManager.SetID(underlyerReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyerReference = new AssetReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedStartDate
        private IdentifiedDate unadjustedStartDate;
        public IdentifiedDate UnadjustedStartDate
        {
            get
            {
                if (this.unadjustedStartDate != null)
                {
                    return this.unadjustedStartDate; 
                }
                else if (this.unadjustedStartDateIDRef != null)
                {
                    unadjustedStartDate = IDManager.getID(unadjustedStartDateIDRef) as IdentifiedDate;
                    return this.unadjustedStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedStartDate != value)
                {
                    this.unadjustedStartDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region UnadjustedEndDate
        private IdentifiedDate unadjustedEndDate;
        public IdentifiedDate UnadjustedEndDate
        {
            get
            {
                if (this.unadjustedEndDate != null)
                {
                    return this.unadjustedEndDate; 
                }
                else if (this.unadjustedEndDateIDRef != null)
                {
                    unadjustedEndDate = IDManager.getID(unadjustedEndDateIDRef) as IdentifiedDate;
                    return this.unadjustedEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedEndDate != value)
                {
                    this.unadjustedEndDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region DateAdjustments
        private BusinessDayAdjustments dateAdjustments;
        public BusinessDayAdjustments DateAdjustments
        {
            get
            {
                if (this.dateAdjustments != null)
                {
                    return this.dateAdjustments; 
                }
                else if (this.dateAdjustmentsIDRef != null)
                {
                    dateAdjustments = IDManager.getID(dateAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.dateAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateAdjustments != value)
                {
                    this.dateAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        #region UnderlyerReference
        private AssetReference underlyerReference;
        public AssetReference UnderlyerReference
        {
            get
            {
                if (this.underlyerReference != null)
                {
                    return this.underlyerReference; 
                }
                else if (this.underlyerReferenceIDRef != null)
                {
                    underlyerReference = IDManager.getID(underlyerReferenceIDRef) as AssetReference;
                    return this.underlyerReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyerReference != value)
                {
                    this.underlyerReference = value;
                }
            }
        }
        #endregion
        
        public string AssetReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

