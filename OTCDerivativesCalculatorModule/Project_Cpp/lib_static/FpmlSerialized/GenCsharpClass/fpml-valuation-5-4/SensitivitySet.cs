using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SensitivitySet
    {
        public SensitivitySet(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList definitionReferenceNodeList = xmlNode.SelectNodes("definitionReference");
            if (definitionReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in definitionReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        definitionReferenceIDRef = item.Attributes["id"].Name;
                        SensitivitySetDefinitionReference ob = SensitivitySetDefinitionReference();
                        IDManager.SetID(definitionReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        definitionReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        definitionReference = new SensitivitySetDefinitionReference(item);
                    }
                }
            }
            
        
            XmlNodeList sensitivityNodeList = xmlNode.SelectNodes("sensitivity");
            
            foreach (XmlNode item in sensitivityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sensitivityIDRef = item.Attributes["id"].Name;
                        List<Sensitivity> ob = new List<Sensitivity>();
                        ob.Add(new Sensitivity(item));
                        IDManager.SetID(sensitivityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sensitivityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    sensitivity.Add(new Sensitivity(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeString name;
        public XsdTypeString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region DefinitionReference
        private SensitivitySetDefinitionReference definitionReference;
        public SensitivitySetDefinitionReference DefinitionReference
        {
            get
            {
                if (this.definitionReference != null)
                {
                    return this.definitionReference; 
                }
                else if (this.definitionReferenceIDRef != null)
                {
                    definitionReference = IDManager.getID(definitionReferenceIDRef) as SensitivitySetDefinitionReference;
                    return this.definitionReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.definitionReference != value)
                {
                    this.definitionReference = value;
                }
            }
        }
        #endregion
        
        public string SensitivitySetDefinitionReferenceIDRef { get; set; }
        #region Sensitivity
        private List<Sensitivity> sensitivity;
        public List<Sensitivity> Sensitivity
        {
            get
            {
                if (this.sensitivity != null)
                {
                    return this.sensitivity; 
                }
                else if (this.sensitivityIDRef != null)
                {
                    sensitivity = IDManager.getID(sensitivityIDRef) as List<Sensitivity>;
                    return this.sensitivity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sensitivity != value)
                {
                    this.sensitivity = value;
                }
            }
        }
        #endregion
        
        public string SensitivityIDRef { get; set; }
        
    
        
    
    }
    
}

