using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PubliclyAvailableInformation
    {
        public PubliclyAvailableInformation(XmlNode xmlNode)
        {
            XmlNodeList standardPublicSourcesNodeList = xmlNode.SelectNodes("standardPublicSources");
            if (standardPublicSourcesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardPublicSourcesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardPublicSourcesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(standardPublicSourcesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardPublicSourcesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardPublicSources = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList publicSourceNodeList = xmlNode.SelectNodes("publicSource");
            
            foreach (XmlNode item in publicSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publicSourceIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(publicSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publicSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    publicSource.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNodeList specifiedNumberNodeList = xmlNode.SelectNodes("specifiedNumber");
            if (specifiedNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specifiedNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specifiedNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(specifiedNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specifiedNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specifiedNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardPublicSources
        private XsdTypeBoolean standardPublicSources;
        public XsdTypeBoolean StandardPublicSources
        {
            get
            {
                if (this.standardPublicSources != null)
                {
                    return this.standardPublicSources; 
                }
                else if (this.standardPublicSourcesIDRef != null)
                {
                    standardPublicSources = IDManager.getID(standardPublicSourcesIDRef) as XsdTypeBoolean;
                    return this.standardPublicSources; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardPublicSources != value)
                {
                    this.standardPublicSources = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PublicSource
        private XsdTypeString publicSource;
        public XsdTypeString PublicSource
        {
            get
            {
                if (this.publicSource != null)
                {
                    return this.publicSource; 
                }
                else if (this.publicSourceIDRef != null)
                {
                    publicSource = IDManager.getID(publicSourceIDRef) as XsdTypeString;
                    return this.publicSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publicSource != value)
                {
                    this.publicSource = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region SpecifiedNumber
        private XsdTypePositiveInteger specifiedNumber;
        public XsdTypePositiveInteger SpecifiedNumber
        {
            get
            {
                if (this.specifiedNumber != null)
                {
                    return this.specifiedNumber; 
                }
                else if (this.specifiedNumberIDRef != null)
                {
                    specifiedNumber = IDManager.getID(specifiedNumberIDRef) as XsdTypePositiveInteger;
                    return this.specifiedNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specifiedNumber != value)
                {
                    this.specifiedNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

