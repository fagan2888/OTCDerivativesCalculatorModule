using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ScheduledDate
    {
        public ScheduledDate(XmlNode xmlNode)
        {
            XmlNodeList unadjustedDateNodeList = xmlNode.SelectNodes("unadjustedDate");
            if (unadjustedDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedDateNodeList = xmlNode.SelectNodes("adjustedDate");
            if (adjustedDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        ScheduledDateType ob = ScheduledDateType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new ScheduledDateType(item);
                    }
                }
            }
            
        
            XmlNodeList assetReferenceNodeList = xmlNode.SelectNodes("assetReference");
            if (assetReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assetReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef = item.Attributes["id"].Name;
                        AnyAssetReference ob = AnyAssetReference();
                        IDManager.SetID(assetReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        assetReference = new AnyAssetReference(item);
                    }
                }
            }
            
        
            XmlNodeList associatedValueNodeList = xmlNode.SelectNodes("associatedValue");
            if (associatedValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in associatedValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        associatedValueIDRef = item.Attributes["id"].Name;
                        AssetValuation ob = AssetValuation();
                        IDManager.SetID(associatedValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        associatedValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        associatedValue = new AssetValuation(item);
                    }
                }
            }
            
        
            XmlNodeList associatedValueReferenceNodeList = xmlNode.SelectNodes("associatedValueReference");
            if (associatedValueReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in associatedValueReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        associatedValueReferenceIDRef = item.Attributes["id"].Name;
                        ValuationReference ob = ValuationReference();
                        IDManager.SetID(associatedValueReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        associatedValueReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        associatedValueReference = new ValuationReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedDate
        private XsdTypeDate unadjustedDate;
        public XsdTypeDate UnadjustedDate
        {
            get
            {
                if (this.unadjustedDate != null)
                {
                    return this.unadjustedDate; 
                }
                else if (this.unadjustedDateIDRef != null)
                {
                    unadjustedDate = IDManager.getID(unadjustedDateIDRef) as XsdTypeDate;
                    return this.unadjustedDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedDate != value)
                {
                    this.unadjustedDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedDate
        private XsdTypeDate adjustedDate;
        public XsdTypeDate AdjustedDate
        {
            get
            {
                if (this.adjustedDate != null)
                {
                    return this.adjustedDate; 
                }
                else if (this.adjustedDateIDRef != null)
                {
                    adjustedDate = IDManager.getID(adjustedDateIDRef) as XsdTypeDate;
                    return this.adjustedDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedDate != value)
                {
                    this.adjustedDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Type
        private ScheduledDateType type;
        public ScheduledDateType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as ScheduledDateType;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string ScheduledDateTypeIDRef { get; set; }
        #region AssetReference
        private AnyAssetReference assetReference;
        public AnyAssetReference AssetReference
        {
            get
            {
                if (this.assetReference != null)
                {
                    return this.assetReference; 
                }
                else if (this.assetReferenceIDRef != null)
                {
                    assetReference = IDManager.getID(assetReferenceIDRef) as AnyAssetReference;
                    return this.assetReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assetReference != value)
                {
                    this.assetReference = value;
                }
            }
        }
        #endregion
        
        public string AnyAssetReferenceIDRef { get; set; }
        #region AssociatedValue
        private AssetValuation associatedValue;
        public AssetValuation AssociatedValue
        {
            get
            {
                if (this.associatedValue != null)
                {
                    return this.associatedValue; 
                }
                else if (this.associatedValueIDRef != null)
                {
                    associatedValue = IDManager.getID(associatedValueIDRef) as AssetValuation;
                    return this.associatedValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.associatedValue != value)
                {
                    this.associatedValue = value;
                }
            }
        }
        #endregion
        
        public string AssetValuationIDRef { get; set; }
        #region AssociatedValueReference
        private ValuationReference associatedValueReference;
        public ValuationReference AssociatedValueReference
        {
            get
            {
                if (this.associatedValueReference != null)
                {
                    return this.associatedValueReference; 
                }
                else if (this.associatedValueReferenceIDRef != null)
                {
                    associatedValueReference = IDManager.getID(associatedValueReferenceIDRef) as ValuationReference;
                    return this.associatedValueReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.associatedValueReference != value)
                {
                    this.associatedValueReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationReferenceIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

