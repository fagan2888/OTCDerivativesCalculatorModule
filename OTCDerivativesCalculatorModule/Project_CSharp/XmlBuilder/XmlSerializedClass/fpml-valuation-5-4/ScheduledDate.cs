using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ScheduledDate : ISerialized
    {
        public ScheduledDate(XmlNode xmlNode)
        {
            XmlNode unadjustedDateNode = xmlNode.SelectSingleNode("unadjustedDate");
            
            if (unadjustedDateNode != null)
            {
                if (unadjustedDateNode.Attributes["href"] != null || unadjustedDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedDateNode.Attributes["id"] != null) 
                    {
                        unadjustedDateIDRef_ = unadjustedDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedDateNode);
                        IDManager.SetID(unadjustedDateIDRef_, ob);
                    }
                    else if (unadjustedDateNode.Attributes["href"] != null)
                    {
                        unadjustedDateIDRef_ = unadjustedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedDate_ = new XsdTypeDate(unadjustedDateNode);
                    }
                }
                else
                {
                    unadjustedDate_ = new XsdTypeDate(unadjustedDateNode);
                }
            }
            
        
            XmlNode adjustedDateNode = xmlNode.SelectSingleNode("adjustedDate");
            
            if (adjustedDateNode != null)
            {
                if (adjustedDateNode.Attributes["href"] != null || adjustedDateNode.Attributes["id"] != null) 
                {
                    if (adjustedDateNode.Attributes["id"] != null) 
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedDateNode);
                        IDManager.SetID(adjustedDateIDRef_, ob);
                    }
                    else if (adjustedDateNode.Attributes["href"] != null)
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedDate_ = new XsdTypeDate(adjustedDateNode);
                    }
                }
                else
                {
                    adjustedDate_ = new XsdTypeDate(adjustedDateNode);
                }
            }
            
        
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        ScheduledDateType ob = new ScheduledDateType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new ScheduledDateType(typeNode);
                    }
                }
                else
                {
                    type_ = new ScheduledDateType(typeNode);
                }
            }
            
        
            XmlNode assetReferenceNode = xmlNode.SelectSingleNode("assetReference");
            
            if (assetReferenceNode != null)
            {
                if (assetReferenceNode.Attributes["href"] != null || assetReferenceNode.Attributes["id"] != null) 
                {
                    if (assetReferenceNode.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["id"].Value;
                        AnyAssetReference ob = new AnyAssetReference(assetReferenceNode);
                        IDManager.SetID(assetReferenceIDRef_, ob);
                    }
                    else if (assetReferenceNode.Attributes["href"] != null)
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        assetReference_ = new AnyAssetReference(assetReferenceNode);
                    }
                }
                else
                {
                    assetReference_ = new AnyAssetReference(assetReferenceNode);
                }
            }
            
        
            XmlNode associatedValueNode = xmlNode.SelectSingleNode("associatedValue");
            
            if (associatedValueNode != null)
            {
                if (associatedValueNode.Attributes["href"] != null || associatedValueNode.Attributes["id"] != null) 
                {
                    if (associatedValueNode.Attributes["id"] != null) 
                    {
                        associatedValueIDRef_ = associatedValueNode.Attributes["id"].Value;
                        AssetValuation ob = new AssetValuation(associatedValueNode);
                        IDManager.SetID(associatedValueIDRef_, ob);
                    }
                    else if (associatedValueNode.Attributes["href"] != null)
                    {
                        associatedValueIDRef_ = associatedValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        associatedValue_ = new AssetValuation(associatedValueNode);
                    }
                }
                else
                {
                    associatedValue_ = new AssetValuation(associatedValueNode);
                }
            }
            
        
            XmlNode associatedValueReferenceNode = xmlNode.SelectSingleNode("associatedValueReference");
            
            if (associatedValueReferenceNode != null)
            {
                if (associatedValueReferenceNode.Attributes["href"] != null || associatedValueReferenceNode.Attributes["id"] != null) 
                {
                    if (associatedValueReferenceNode.Attributes["id"] != null) 
                    {
                        associatedValueReferenceIDRef_ = associatedValueReferenceNode.Attributes["id"].Value;
                        ValuationReference ob = new ValuationReference(associatedValueReferenceNode);
                        IDManager.SetID(associatedValueReferenceIDRef_, ob);
                    }
                    else if (associatedValueReferenceNode.Attributes["href"] != null)
                    {
                        associatedValueReferenceIDRef_ = associatedValueReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        associatedValueReference_ = new ValuationReference(associatedValueReferenceNode);
                    }
                }
                else
                {
                    associatedValueReference_ = new ValuationReference(associatedValueReferenceNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedDate_
        private XsdTypeDate unadjustedDate_;
        public XsdTypeDate UnadjustedDate_
        {
            get
            {
                if (this.unadjustedDate_ != null)
                {
                    return this.unadjustedDate_; 
                }
                else if (this.unadjustedDateIDRef_ != null)
                {
                    unadjustedDate_ = IDManager.getID(unadjustedDateIDRef_) as XsdTypeDate;
                    return this.unadjustedDate_; 
                }
                else
                {
                      return this.unadjustedDate_; 
                }
            }
            set
            {
                if (this.unadjustedDate_ != value)
                {
                    this.unadjustedDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedDateIDRef_ { get; set; }
        #region AdjustedDate_
        private XsdTypeDate adjustedDate_;
        public XsdTypeDate AdjustedDate_
        {
            get
            {
                if (this.adjustedDate_ != null)
                {
                    return this.adjustedDate_; 
                }
                else if (this.adjustedDateIDRef_ != null)
                {
                    adjustedDate_ = IDManager.getID(adjustedDateIDRef_) as XsdTypeDate;
                    return this.adjustedDate_; 
                }
                else
                {
                      return this.adjustedDate_; 
                }
            }
            set
            {
                if (this.adjustedDate_ != value)
                {
                    this.adjustedDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedDateIDRef_ { get; set; }
        #region Type_
        private ScheduledDateType type_;
        public ScheduledDateType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as ScheduledDateType;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region AssetReference_
        private AnyAssetReference assetReference_;
        public AnyAssetReference AssetReference_
        {
            get
            {
                if (this.assetReference_ != null)
                {
                    return this.assetReference_; 
                }
                else if (this.assetReferenceIDRef_ != null)
                {
                    assetReference_ = IDManager.getID(assetReferenceIDRef_) as AnyAssetReference;
                    return this.assetReference_; 
                }
                else
                {
                      return this.assetReference_; 
                }
            }
            set
            {
                if (this.assetReference_ != value)
                {
                    this.assetReference_ = value;
                }
            }
        }
        #endregion
        
        public string assetReferenceIDRef_ { get; set; }
        #region AssociatedValue_
        private AssetValuation associatedValue_;
        public AssetValuation AssociatedValue_
        {
            get
            {
                if (this.associatedValue_ != null)
                {
                    return this.associatedValue_; 
                }
                else if (this.associatedValueIDRef_ != null)
                {
                    associatedValue_ = IDManager.getID(associatedValueIDRef_) as AssetValuation;
                    return this.associatedValue_; 
                }
                else
                {
                      return this.associatedValue_; 
                }
            }
            set
            {
                if (this.associatedValue_ != value)
                {
                    this.associatedValue_ = value;
                }
            }
        }
        #endregion
        
        public string associatedValueIDRef_ { get; set; }
        #region AssociatedValueReference_
        private ValuationReference associatedValueReference_;
        public ValuationReference AssociatedValueReference_
        {
            get
            {
                if (this.associatedValueReference_ != null)
                {
                    return this.associatedValueReference_; 
                }
                else if (this.associatedValueReferenceIDRef_ != null)
                {
                    associatedValueReference_ = IDManager.getID(associatedValueReferenceIDRef_) as ValuationReference;
                    return this.associatedValueReference_; 
                }
                else
                {
                      return this.associatedValueReference_; 
                }
            }
            set
            {
                if (this.associatedValueReference_ != value)
                {
                    this.associatedValueReference_ = value;
                }
            }
        }
        #endregion
        
        public string associatedValueReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

