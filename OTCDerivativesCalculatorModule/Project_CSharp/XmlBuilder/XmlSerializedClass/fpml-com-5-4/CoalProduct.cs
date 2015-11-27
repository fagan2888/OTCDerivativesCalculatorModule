using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalProduct : ISerialized
    {
        public CoalProduct(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        CoalProductType ob = new CoalProductType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new CoalProductType(typeNode);
                    }
                }
                else
                {
                    type_ = new CoalProductType(typeNode);
                }
            }
            
        
            XmlNode coalProductSpecificationsNode = xmlNode.SelectSingleNode("coalProductSpecifications");
            
            if (coalProductSpecificationsNode != null)
            {
                if (coalProductSpecificationsNode.Attributes["href"] != null || coalProductSpecificationsNode.Attributes["id"] != null) 
                {
                    if (coalProductSpecificationsNode.Attributes["id"] != null) 
                    {
                        coalProductSpecificationsIDRef_ = coalProductSpecificationsNode.Attributes["id"].Value;
                        CoalProductSpecifications ob = new CoalProductSpecifications(coalProductSpecificationsNode);
                        IDManager.SetID(coalProductSpecificationsIDRef_, ob);
                    }
                    else if (coalProductSpecificationsNode.Attributes["href"] != null)
                    {
                        coalProductSpecificationsIDRef_ = coalProductSpecificationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coalProductSpecifications_ = new CoalProductSpecifications(coalProductSpecificationsNode);
                    }
                }
                else
                {
                    coalProductSpecifications_ = new CoalProductSpecifications(coalProductSpecificationsNode);
                }
            }
            
        
            XmlNodeList sourceNodeList = xmlNode.SelectNodes("source");
            
            if (sourceNodeList != null)
            {
                this.source_ = new List<CoalProductSource>();
                foreach (XmlNode item in sourceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            sourceIDRef_ = item.Attributes["id"].Value;
                            source_.Add(new CoalProductSource(item));
                            IDManager.SetID(sourceIDRef_, source_[source_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            sourceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        source_.Add(new CoalProductSource(item));
                        }
                    }
                    else
                    {
                        source_.Add(new CoalProductSource(item));
                    }
                }
            }
            
        
            XmlNode sCoTASpecificationsNode = xmlNode.SelectSingleNode("sCoTASpecifications");
            
            if (sCoTASpecificationsNode != null)
            {
                if (sCoTASpecificationsNode.Attributes["href"] != null || sCoTASpecificationsNode.Attributes["id"] != null) 
                {
                    if (sCoTASpecificationsNode.Attributes["id"] != null) 
                    {
                        sCoTASpecificationsIDRef_ = sCoTASpecificationsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(sCoTASpecificationsNode);
                        IDManager.SetID(sCoTASpecificationsIDRef_, ob);
                    }
                    else if (sCoTASpecificationsNode.Attributes["href"] != null)
                    {
                        sCoTASpecificationsIDRef_ = sCoTASpecificationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sCoTASpecifications_ = new XsdTypeBoolean(sCoTASpecificationsNode);
                    }
                }
                else
                {
                    sCoTASpecifications_ = new XsdTypeBoolean(sCoTASpecificationsNode);
                }
            }
            
        
            XmlNode btuQualityAdjustmentNode = xmlNode.SelectSingleNode("btuQualityAdjustment");
            
            if (btuQualityAdjustmentNode != null)
            {
                if (btuQualityAdjustmentNode.Attributes["href"] != null || btuQualityAdjustmentNode.Attributes["id"] != null) 
                {
                    if (btuQualityAdjustmentNode.Attributes["id"] != null) 
                    {
                        btuQualityAdjustmentIDRef_ = btuQualityAdjustmentNode.Attributes["id"].Value;
                        CoalQualityAdjustments ob = new CoalQualityAdjustments(btuQualityAdjustmentNode);
                        IDManager.SetID(btuQualityAdjustmentIDRef_, ob);
                    }
                    else if (btuQualityAdjustmentNode.Attributes["href"] != null)
                    {
                        btuQualityAdjustmentIDRef_ = btuQualityAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        btuQualityAdjustment_ = new CoalQualityAdjustments(btuQualityAdjustmentNode);
                    }
                }
                else
                {
                    btuQualityAdjustment_ = new CoalQualityAdjustments(btuQualityAdjustmentNode);
                }
            }
            
        
            XmlNode so2QualityAdjustmentNode = xmlNode.SelectSingleNode("so2QualityAdjustment");
            
            if (so2QualityAdjustmentNode != null)
            {
                if (so2QualityAdjustmentNode.Attributes["href"] != null || so2QualityAdjustmentNode.Attributes["id"] != null) 
                {
                    if (so2QualityAdjustmentNode.Attributes["id"] != null) 
                    {
                        so2QualityAdjustmentIDRef_ = so2QualityAdjustmentNode.Attributes["id"].Value;
                        CoalQualityAdjustments ob = new CoalQualityAdjustments(so2QualityAdjustmentNode);
                        IDManager.SetID(so2QualityAdjustmentIDRef_, ob);
                    }
                    else if (so2QualityAdjustmentNode.Attributes["href"] != null)
                    {
                        so2QualityAdjustmentIDRef_ = so2QualityAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        so2QualityAdjustment_ = new CoalQualityAdjustments(so2QualityAdjustmentNode);
                    }
                }
                else
                {
                    so2QualityAdjustment_ = new CoalQualityAdjustments(so2QualityAdjustmentNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private CoalProductType type_;
        public CoalProductType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as CoalProductType;
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
        #region CoalProductSpecifications_
        private CoalProductSpecifications coalProductSpecifications_;
        public CoalProductSpecifications CoalProductSpecifications_
        {
            get
            {
                if (this.coalProductSpecifications_ != null)
                {
                    return this.coalProductSpecifications_; 
                }
                else if (this.coalProductSpecificationsIDRef_ != null)
                {
                    coalProductSpecifications_ = IDManager.getID(coalProductSpecificationsIDRef_) as CoalProductSpecifications;
                    return this.coalProductSpecifications_; 
                }
                else
                {
                      return this.coalProductSpecifications_; 
                }
            }
            set
            {
                if (this.coalProductSpecifications_ != value)
                {
                    this.coalProductSpecifications_ = value;
                }
            }
        }
        #endregion
        
        public string coalProductSpecificationsIDRef_ { get; set; }
        #region Source_
        private List<CoalProductSource> source_;
        public List<CoalProductSource> Source_
        {
            get
            {
                if (this.source_ != null)
                {
                    return this.source_; 
                }
                else if (this.sourceIDRef_ != null)
                {
                    return this.source_; 
                }
                else
                {
                      return this.source_; 
                }
            }
            set
            {
                if (this.source_ != value)
                {
                    this.source_ = value;
                }
            }
        }
        #endregion
        
        public string sourceIDRef_ { get; set; }
        #region SCoTASpecifications_
        private XsdTypeBoolean sCoTASpecifications_;
        public XsdTypeBoolean SCoTASpecifications_
        {
            get
            {
                if (this.sCoTASpecifications_ != null)
                {
                    return this.sCoTASpecifications_; 
                }
                else if (this.sCoTASpecificationsIDRef_ != null)
                {
                    sCoTASpecifications_ = IDManager.getID(sCoTASpecificationsIDRef_) as XsdTypeBoolean;
                    return this.sCoTASpecifications_; 
                }
                else
                {
                      return this.sCoTASpecifications_; 
                }
            }
            set
            {
                if (this.sCoTASpecifications_ != value)
                {
                    this.sCoTASpecifications_ = value;
                }
            }
        }
        #endregion
        
        public string sCoTASpecificationsIDRef_ { get; set; }
        #region BtuQualityAdjustment_
        private CoalQualityAdjustments btuQualityAdjustment_;
        public CoalQualityAdjustments BtuQualityAdjustment_
        {
            get
            {
                if (this.btuQualityAdjustment_ != null)
                {
                    return this.btuQualityAdjustment_; 
                }
                else if (this.btuQualityAdjustmentIDRef_ != null)
                {
                    btuQualityAdjustment_ = IDManager.getID(btuQualityAdjustmentIDRef_) as CoalQualityAdjustments;
                    return this.btuQualityAdjustment_; 
                }
                else
                {
                      return this.btuQualityAdjustment_; 
                }
            }
            set
            {
                if (this.btuQualityAdjustment_ != value)
                {
                    this.btuQualityAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string btuQualityAdjustmentIDRef_ { get; set; }
        #region So2QualityAdjustment_
        private CoalQualityAdjustments so2QualityAdjustment_;
        public CoalQualityAdjustments So2QualityAdjustment_
        {
            get
            {
                if (this.so2QualityAdjustment_ != null)
                {
                    return this.so2QualityAdjustment_; 
                }
                else if (this.so2QualityAdjustmentIDRef_ != null)
                {
                    so2QualityAdjustment_ = IDManager.getID(so2QualityAdjustmentIDRef_) as CoalQualityAdjustments;
                    return this.so2QualityAdjustment_; 
                }
                else
                {
                      return this.so2QualityAdjustment_; 
                }
            }
            set
            {
                if (this.so2QualityAdjustment_ != value)
                {
                    this.so2QualityAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string so2QualityAdjustmentIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

