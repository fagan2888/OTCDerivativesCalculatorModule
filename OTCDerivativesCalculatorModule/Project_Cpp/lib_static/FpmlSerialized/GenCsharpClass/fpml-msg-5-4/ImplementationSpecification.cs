using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ImplementationSpecification
    {
        public ImplementationSpecification(XmlNode xmlNode)
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
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList versionNodeList = xmlNode.SelectNodes("version");
            if (versionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in versionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionIDRef = item.Attributes["id"].Name;
                        ImplementationSpecificationVersion ob = ImplementationSpecificationVersion();
                        IDManager.SetID(versionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        version = new ImplementationSpecificationVersion(item);
                    }
                }
            }
            
        
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            if (dateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        date = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeNormalizedString name;
        public XsdTypeNormalizedString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeNormalizedString;
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
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Version
        private ImplementationSpecificationVersion version;
        public ImplementationSpecificationVersion Version
        {
            get
            {
                if (this.version != null)
                {
                    return this.version; 
                }
                else if (this.versionIDRef != null)
                {
                    version = IDManager.getID(versionIDRef) as ImplementationSpecificationVersion;
                    return this.version; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.version != value)
                {
                    this.version = value;
                }
            }
        }
        #endregion
        
        public string ImplementationSpecificationVersionIDRef { get; set; }
        #region Date
        private XsdTypeDate date;
        public XsdTypeDate Date
        {
            get
            {
                if (this.date != null)
                {
                    return this.date; 
                }
                else if (this.dateIDRef != null)
                {
                    date = IDManager.getID(dateIDRef) as XsdTypeDate;
                    return this.date; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.date != value)
                {
                    this.date = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

