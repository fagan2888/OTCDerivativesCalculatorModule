using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GenericAgreement : ISerialized
    {
        public GenericAgreement(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        AgreementType ob = new AgreementType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new AgreementType(typeNode);
                    }
                }
                else
                {
                    type_ = new AgreementType(typeNode);
                }
            }
            
        
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        AgreementVersion ob = new AgreementVersion(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new AgreementVersion(versionNode);
                    }
                }
                else
                {
                    version_ = new AgreementVersion(versionNode);
                }
            }
            
        
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeDate(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeDate(dateNode);
                }
            }
            
        
            XmlNodeList amendmentDateNodeList = xmlNode.SelectNodes("amendmentDate");
            
            if (amendmentDateNodeList != null)
            {
                this.amendmentDate_ = new List<XsdTypeDate>();
                foreach (XmlNode item in amendmentDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            amendmentDateIDRef_ = item.Attributes["id"].Value;
                            amendmentDate_.Add(new XsdTypeDate(item));
                            IDManager.SetID(amendmentDateIDRef_, amendmentDate_[amendmentDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            amendmentDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        amendmentDate_.Add(new XsdTypeDate(item));
                        }
                    }
                    else
                    {
                        amendmentDate_.Add(new XsdTypeDate(item));
                    }
                }
            }
            
        
            XmlNode governingLawNode = xmlNode.SelectSingleNode("governingLaw");
            
            if (governingLawNode != null)
            {
                if (governingLawNode.Attributes["href"] != null || governingLawNode.Attributes["id"] != null) 
                {
                    if (governingLawNode.Attributes["id"] != null) 
                    {
                        governingLawIDRef_ = governingLawNode.Attributes["id"].Value;
                        GoverningLaw ob = new GoverningLaw(governingLawNode);
                        IDManager.SetID(governingLawIDRef_, ob);
                    }
                    else if (governingLawNode.Attributes["href"] != null)
                    {
                        governingLawIDRef_ = governingLawNode.Attributes["href"].Value;
                    }
                    else
                    {
                        governingLaw_ = new GoverningLaw(governingLawNode);
                    }
                }
                else
                {
                    governingLaw_ = new GoverningLaw(governingLawNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private AgreementType type_;
        public AgreementType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as AgreementType;
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
        #region Version_
        private AgreementVersion version_;
        public AgreementVersion Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as AgreementVersion;
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
        #region Date_
        private XsdTypeDate date_;
        public XsdTypeDate Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeDate;
                    return this.date_; 
                }
                else
                {
                      return this.date_; 
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
        #region AmendmentDate_
        private List<XsdTypeDate> amendmentDate_;
        public List<XsdTypeDate> AmendmentDate_
        {
            get
            {
                if (this.amendmentDate_ != null)
                {
                    return this.amendmentDate_; 
                }
                else if (this.amendmentDateIDRef_ != null)
                {
                    return this.amendmentDate_; 
                }
                else
                {
                      return this.amendmentDate_; 
                }
            }
            set
            {
                if (this.amendmentDate_ != value)
                {
                    this.amendmentDate_ = value;
                }
            }
        }
        #endregion
        
        public string amendmentDateIDRef_ { get; set; }
        #region GoverningLaw_
        private GoverningLaw governingLaw_;
        public GoverningLaw GoverningLaw_
        {
            get
            {
                if (this.governingLaw_ != null)
                {
                    return this.governingLaw_; 
                }
                else if (this.governingLawIDRef_ != null)
                {
                    governingLaw_ = IDManager.getID(governingLawIDRef_) as GoverningLaw;
                    return this.governingLaw_; 
                }
                else
                {
                      return this.governingLaw_; 
                }
            }
            set
            {
                if (this.governingLaw_ != value)
                {
                    this.governingLaw_ = value;
                }
            }
        }
        #endregion
        
        public string governingLawIDRef_ { get; set; }
        
    
        
    
    }
    
}

