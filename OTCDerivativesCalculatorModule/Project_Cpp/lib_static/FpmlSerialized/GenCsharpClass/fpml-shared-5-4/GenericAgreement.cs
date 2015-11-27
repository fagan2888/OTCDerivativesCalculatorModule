using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GenericAgreement
    {
        public GenericAgreement(XmlNode xmlNode)
        {
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
                        AgreementType ob = AgreementType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new AgreementType(item);
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
                        AgreementVersion ob = AgreementVersion();
                        IDManager.SetID(versionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        version = new AgreementVersion(item);
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
            
        
            XmlNodeList amendmentDateNodeList = xmlNode.SelectNodes("amendmentDate");
            
            foreach (XmlNode item in amendmentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amendmentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = new XsdTypeDate();
                        ob.Add(new XsdTypeDate(item));
                        IDManager.SetID(amendmentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amendmentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    amendmentDate.Add(new XsdTypeDate(item));
                    }
                }
            }
            
        
            XmlNodeList governingLawNodeList = xmlNode.SelectNodes("governingLaw");
            if (governingLawNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in governingLawNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        governingLawIDRef = item.Attributes["id"].Name;
                        GoverningLaw ob = GoverningLaw();
                        IDManager.SetID(governingLawIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        governingLawIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        governingLaw = new GoverningLaw(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private AgreementType type;
        public AgreementType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as AgreementType;
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
        
        public string AgreementTypeIDRef { get; set; }
        #region Version
        private AgreementVersion version;
        public AgreementVersion Version
        {
            get
            {
                if (this.version != null)
                {
                    return this.version; 
                }
                else if (this.versionIDRef != null)
                {
                    version = IDManager.getID(versionIDRef) as AgreementVersion;
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
        
        public string AgreementVersionIDRef { get; set; }
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
        #region AmendmentDate
        private XsdTypeDate amendmentDate;
        public XsdTypeDate AmendmentDate
        {
            get
            {
                if (this.amendmentDate != null)
                {
                    return this.amendmentDate; 
                }
                else if (this.amendmentDateIDRef != null)
                {
                    amendmentDate = IDManager.getID(amendmentDateIDRef) as XsdTypeDate;
                    return this.amendmentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amendmentDate != value)
                {
                    this.amendmentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region GoverningLaw
        private GoverningLaw governingLaw;
        public GoverningLaw GoverningLaw
        {
            get
            {
                if (this.governingLaw != null)
                {
                    return this.governingLaw; 
                }
                else if (this.governingLawIDRef != null)
                {
                    governingLaw = IDManager.getID(governingLawIDRef) as GoverningLaw;
                    return this.governingLaw; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.governingLaw != value)
                {
                    this.governingLaw = value;
                }
            }
        }
        #endregion
        
        public string GoverningLawIDRef { get; set; }
        
    
        
    
    }
    
}

