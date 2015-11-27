using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AssetPool : ISerialized
    {
        public AssetPool(XmlNode xmlNode)
        {
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new XsdTypeNonNegativeInteger(versionNode);
                    }
                }
                else
                {
                    version_ = new XsdTypeNonNegativeInteger(versionNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                }
            }
            
        
            XmlNode initialFactorNode = xmlNode.SelectSingleNode("initialFactor");
            
            if (initialFactorNode != null)
            {
                if (initialFactorNode.Attributes["href"] != null || initialFactorNode.Attributes["id"] != null) 
                {
                    if (initialFactorNode.Attributes["id"] != null) 
                    {
                        initialFactorIDRef_ = initialFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialFactorNode);
                        IDManager.SetID(initialFactorIDRef_, ob);
                    }
                    else if (initialFactorNode.Attributes["href"] != null)
                    {
                        initialFactorIDRef_ = initialFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialFactor_ = new XsdTypeDecimal(initialFactorNode);
                    }
                }
                else
                {
                    initialFactor_ = new XsdTypeDecimal(initialFactorNode);
                }
            }
            
        
            XmlNode currentFactorNode = xmlNode.SelectSingleNode("currentFactor");
            
            if (currentFactorNode != null)
            {
                if (currentFactorNode.Attributes["href"] != null || currentFactorNode.Attributes["id"] != null) 
                {
                    if (currentFactorNode.Attributes["id"] != null) 
                    {
                        currentFactorIDRef_ = currentFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(currentFactorNode);
                        IDManager.SetID(currentFactorIDRef_, ob);
                    }
                    else if (currentFactorNode.Attributes["href"] != null)
                    {
                        currentFactorIDRef_ = currentFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentFactor_ = new XsdTypeDecimal(currentFactorNode);
                    }
                }
                else
                {
                    currentFactor_ = new XsdTypeDecimal(currentFactorNode);
                }
            }
            
        
        }
        
    
        #region Version_
        private XsdTypeNonNegativeInteger version_;
        public XsdTypeNonNegativeInteger Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.version_; 
                }
                else
                {
                      return this.version_; 
                }
            }
            set
            {
                if (this.version_ != value)
                {
                    this.version_ = value;
                }
            }
        }
        #endregion
        
        public string versionIDRef_ { get; set; }
        #region EffectiveDate_
        private IdentifiedDate effectiveDate_;
        public IdentifiedDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as IdentifiedDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region InitialFactor_
        private XsdTypeDecimal initialFactor_;
        public XsdTypeDecimal InitialFactor_
        {
            get
            {
                if (this.initialFactor_ != null)
                {
                    return this.initialFactor_; 
                }
                else if (this.initialFactorIDRef_ != null)
                {
                    initialFactor_ = IDManager.getID(initialFactorIDRef_) as XsdTypeDecimal;
                    return this.initialFactor_; 
                }
                else
                {
                      return this.initialFactor_; 
                }
            }
            set
            {
                if (this.initialFactor_ != value)
                {
                    this.initialFactor_ = value;
                }
            }
        }
        #endregion
        
        public string initialFactorIDRef_ { get; set; }
        #region CurrentFactor_
        private XsdTypeDecimal currentFactor_;
        public XsdTypeDecimal CurrentFactor_
        {
            get
            {
                if (this.currentFactor_ != null)
                {
                    return this.currentFactor_; 
                }
                else if (this.currentFactorIDRef_ != null)
                {
                    currentFactor_ = IDManager.getID(currentFactorIDRef_) as XsdTypeDecimal;
                    return this.currentFactor_; 
                }
                else
                {
                      return this.currentFactor_; 
                }
            }
            set
            {
                if (this.currentFactor_ != value)
                {
                    this.currentFactor_ = value;
                }
            }
        }
        #endregion
        
        public string currentFactorIDRef_ { get; set; }
        
    
        
    
    }
    
}

