using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BaseInformation : ISerialized
    {
        public BaseInformation(XmlNode xmlNode)
        {
            XmlNode baseIndexesNode = xmlNode.SelectSingleNode("baseIndexes");
            
            if (baseIndexesNode != null)
            {
                if (baseIndexesNode.Attributes["href"] != null || baseIndexesNode.Attributes["id"] != null) 
                {
                    if (baseIndexesNode.Attributes["id"] != null) 
                    {
                        baseIndexesIDRef_ = baseIndexesNode.Attributes["id"].Value;
                        BaseIndexes ob = new BaseIndexes(baseIndexesNode);
                        IDManager.SetID(baseIndexesIDRef_, ob);
                    }
                    else if (baseIndexesNode.Attributes["href"] != null)
                    {
                        baseIndexesIDRef_ = baseIndexesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseIndexes_ = new BaseIndexes(baseIndexesNode);
                    }
                }
                else
                {
                    baseIndexes_ = new BaseIndexes(baseIndexesNode);
                }
            }
            
        
            XmlNode initialFixedValueNode = xmlNode.SelectSingleNode("initialFixedValue");
            
            if (initialFixedValueNode != null)
            {
                if (initialFixedValueNode.Attributes["href"] != null || initialFixedValueNode.Attributes["id"] != null) 
                {
                    if (initialFixedValueNode.Attributes["id"] != null) 
                    {
                        initialFixedValueIDRef_ = initialFixedValueNode.Attributes["id"].Value;
                        InitialFixedValue ob = new InitialFixedValue(initialFixedValueNode);
                        IDManager.SetID(initialFixedValueIDRef_, ob);
                    }
                    else if (initialFixedValueNode.Attributes["href"] != null)
                    {
                        initialFixedValueIDRef_ = initialFixedValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialFixedValue_ = new InitialFixedValue(initialFixedValueNode);
                    }
                }
                else
                {
                    initialFixedValue_ = new InitialFixedValue(initialFixedValueNode);
                }
            }
            
        
            XmlNode conventionSetNode = xmlNode.SelectSingleNode("conventionSet");
            
            if (conventionSetNode != null)
            {
                if (conventionSetNode.Attributes["href"] != null || conventionSetNode.Attributes["id"] != null) 
                {
                    if (conventionSetNode.Attributes["id"] != null) 
                    {
                        conventionSetIDRef_ = conventionSetNode.Attributes["id"].Value;
                        ConventionSet ob = new ConventionSet(conventionSetNode);
                        IDManager.SetID(conventionSetIDRef_, ob);
                    }
                    else if (conventionSetNode.Attributes["href"] != null)
                    {
                        conventionSetIDRef_ = conventionSetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conventionSet_ = new ConventionSet(conventionSetNode);
                    }
                }
                else
                {
                    conventionSet_ = new ConventionSet(conventionSetNode);
                }
            }
            
        
        }
        
    
        #region BaseIndexes_
        private BaseIndexes baseIndexes_;
        public BaseIndexes BaseIndexes_
        {
            get
            {
                if (this.baseIndexes_ != null)
                {
                    return this.baseIndexes_; 
                }
                else if (this.baseIndexesIDRef_ != null)
                {
                    baseIndexes_ = IDManager.getID(baseIndexesIDRef_) as BaseIndexes;
                    return this.baseIndexes_; 
                }
                else
                {
                      return this.baseIndexes_; 
                }
            }
            set
            {
                if (this.baseIndexes_ != value)
                {
                    this.baseIndexes_ = value;
                }
            }
        }
        #endregion
        
        public string baseIndexesIDRef_ { get; set; }
        #region InitialFixedValue_
        private InitialFixedValue initialFixedValue_;
        public InitialFixedValue InitialFixedValue_
        {
            get
            {
                if (this.initialFixedValue_ != null)
                {
                    return this.initialFixedValue_; 
                }
                else if (this.initialFixedValueIDRef_ != null)
                {
                    initialFixedValue_ = IDManager.getID(initialFixedValueIDRef_) as InitialFixedValue;
                    return this.initialFixedValue_; 
                }
                else
                {
                      return this.initialFixedValue_; 
                }
            }
            set
            {
                if (this.initialFixedValue_ != value)
                {
                    this.initialFixedValue_ = value;
                }
            }
        }
        #endregion
        
        public string initialFixedValueIDRef_ { get; set; }
        #region ConventionSet_
        private ConventionSet conventionSet_;
        public ConventionSet ConventionSet_
        {
            get
            {
                if (this.conventionSet_ != null)
                {
                    return this.conventionSet_; 
                }
                else if (this.conventionSetIDRef_ != null)
                {
                    conventionSet_ = IDManager.getID(conventionSetIDRef_) as ConventionSet;
                    return this.conventionSet_; 
                }
                else
                {
                      return this.conventionSet_; 
                }
            }
            set
            {
                if (this.conventionSet_ != value)
                {
                    this.conventionSet_ = value;
                }
            }
        }
        #endregion
        
        public string conventionSetIDRef_ { get; set; }
        
    
        
    
    }
    
}

