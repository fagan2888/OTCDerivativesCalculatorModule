using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MasterAgreement
    {
        public MasterAgreement(XmlNode xmlNode)
        {
            XmlNodeList masterAgreementTypeNodeList = xmlNode.SelectNodes("masterAgreementType");
            if (masterAgreementTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementTypeIDRef = item.Attributes["id"].Name;
                        MasterAgreementType ob = MasterAgreementType();
                        IDManager.SetID(masterAgreementTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementType = new MasterAgreementType(item);
                    }
                }
            }
            
        
            XmlNodeList masterAgreementVersionNodeList = xmlNode.SelectNodes("masterAgreementVersion");
            if (masterAgreementVersionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementVersionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementVersionIDRef = item.Attributes["id"].Name;
                        MasterAgreementVersion ob = MasterAgreementVersion();
                        IDManager.SetID(masterAgreementVersionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementVersionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementVersion = new MasterAgreementVersion(item);
                    }
                }
            }
            
        
            XmlNodeList masterAgreementDateNodeList = xmlNode.SelectNodes("masterAgreementDate");
            if (masterAgreementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(masterAgreementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region MasterAgreementType
        private MasterAgreementType masterAgreementType;
        public MasterAgreementType MasterAgreementType
        {
            get
            {
                if (this.masterAgreementType != null)
                {
                    return this.masterAgreementType; 
                }
                else if (this.masterAgreementTypeIDRef != null)
                {
                    masterAgreementType = IDManager.getID(masterAgreementTypeIDRef) as MasterAgreementType;
                    return this.masterAgreementType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementType != value)
                {
                    this.masterAgreementType = value;
                }
            }
        }
        #endregion
        
        public string MasterAgreementTypeIDRef { get; set; }
        #region MasterAgreementVersion
        private MasterAgreementVersion masterAgreementVersion;
        public MasterAgreementVersion MasterAgreementVersion
        {
            get
            {
                if (this.masterAgreementVersion != null)
                {
                    return this.masterAgreementVersion; 
                }
                else if (this.masterAgreementVersionIDRef != null)
                {
                    masterAgreementVersion = IDManager.getID(masterAgreementVersionIDRef) as MasterAgreementVersion;
                    return this.masterAgreementVersion; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementVersion != value)
                {
                    this.masterAgreementVersion = value;
                }
            }
        }
        #endregion
        
        public string MasterAgreementVersionIDRef { get; set; }
        #region MasterAgreementDate
        private XsdTypeDate masterAgreementDate;
        public XsdTypeDate MasterAgreementDate
        {
            get
            {
                if (this.masterAgreementDate != null)
                {
                    return this.masterAgreementDate; 
                }
                else if (this.masterAgreementDateIDRef != null)
                {
                    masterAgreementDate = IDManager.getID(masterAgreementDateIDRef) as XsdTypeDate;
                    return this.masterAgreementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementDate != value)
                {
                    this.masterAgreementDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

