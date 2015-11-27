using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SensitivitySet : ISerialized
    {
        public SensitivitySet(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeString(nameNode);
                }
            }
            
        
            XmlNode definitionReferenceNode = xmlNode.SelectSingleNode("definitionReference");
            
            if (definitionReferenceNode != null)
            {
                if (definitionReferenceNode.Attributes["href"] != null || definitionReferenceNode.Attributes["id"] != null) 
                {
                    if (definitionReferenceNode.Attributes["id"] != null) 
                    {
                        definitionReferenceIDRef_ = definitionReferenceNode.Attributes["id"].Value;
                        SensitivitySetDefinitionReference ob = new SensitivitySetDefinitionReference(definitionReferenceNode);
                        IDManager.SetID(definitionReferenceIDRef_, ob);
                    }
                    else if (definitionReferenceNode.Attributes["href"] != null)
                    {
                        definitionReferenceIDRef_ = definitionReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        definitionReference_ = new SensitivitySetDefinitionReference(definitionReferenceNode);
                    }
                }
                else
                {
                    definitionReference_ = new SensitivitySetDefinitionReference(definitionReferenceNode);
                }
            }
            
        
            XmlNodeList sensitivityNodeList = xmlNode.SelectNodes("sensitivity");
            
            if (sensitivityNodeList != null)
            {
                this.sensitivity_ = new List<Sensitivity>();
                foreach (XmlNode item in sensitivityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            sensitivityIDRef_ = item.Attributes["id"].Value;
                            sensitivity_.Add(new Sensitivity(item));
                            IDManager.SetID(sensitivityIDRef_, sensitivity_[sensitivity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            sensitivityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        sensitivity_.Add(new Sensitivity(item));
                        }
                    }
                    else
                    {
                        sensitivity_.Add(new Sensitivity(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeString name_;
        public XsdTypeString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region DefinitionReference_
        private SensitivitySetDefinitionReference definitionReference_;
        public SensitivitySetDefinitionReference DefinitionReference_
        {
            get
            {
                if (this.definitionReference_ != null)
                {
                    return this.definitionReference_; 
                }
                else if (this.definitionReferenceIDRef_ != null)
                {
                    definitionReference_ = IDManager.getID(definitionReferenceIDRef_) as SensitivitySetDefinitionReference;
                    return this.definitionReference_; 
                }
                else
                {
                      return this.definitionReference_; 
                }
            }
            set
            {
                if (this.definitionReference_ != value)
                {
                    this.definitionReference_ = value;
                }
            }
        }
        #endregion
        
        public string definitionReferenceIDRef_ { get; set; }
        #region Sensitivity_
        private List<Sensitivity> sensitivity_;
        public List<Sensitivity> Sensitivity_
        {
            get
            {
                if (this.sensitivity_ != null)
                {
                    return this.sensitivity_; 
                }
                else if (this.sensitivityIDRef_ != null)
                {
                    return this.sensitivity_; 
                }
                else
                {
                      return this.sensitivity_; 
                }
            }
            set
            {
                if (this.sensitivity_ != value)
                {
                    this.sensitivity_ = value;
                }
            }
        }
        #endregion
        
        public string sensitivityIDRef_ { get; set; }
        
    
        
    
    }
    
}

