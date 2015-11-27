using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MasterConfirmation
    {
        public MasterConfirmation(XmlNode xmlNode)
        {
            XmlNodeList masterConfirmationTypeNodeList = xmlNode.SelectNodes("masterConfirmationType");
            if (masterConfirmationTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationTypeIDRef = item.Attributes["id"].Name;
                        MasterConfirmationType ob = MasterConfirmationType();
                        IDManager.SetID(masterConfirmationTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmationType = new MasterConfirmationType(item);
                    }
                }
            }
            
        
            XmlNodeList masterConfirmationDateNodeList = xmlNode.SelectNodes("masterConfirmationDate");
            if (masterConfirmationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(masterConfirmationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList masterConfirmationAnnexDateNodeList = xmlNode.SelectNodes("masterConfirmationAnnexDate");
            if (masterConfirmationAnnexDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationAnnexDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationAnnexDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(masterConfirmationAnnexDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationAnnexDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmationAnnexDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList masterConfirmationAnnexTypeNodeList = xmlNode.SelectNodes("masterConfirmationAnnexType");
            if (masterConfirmationAnnexTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationAnnexTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationAnnexTypeIDRef = item.Attributes["id"].Name;
                        MasterConfirmationAnnexType ob = MasterConfirmationAnnexType();
                        IDManager.SetID(masterConfirmationAnnexTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationAnnexTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmationAnnexType = new MasterConfirmationAnnexType(item);
                    }
                }
            }
            
        
        }
        
    
        #region MasterConfirmationType
        private MasterConfirmationType masterConfirmationType;
        public MasterConfirmationType MasterConfirmationType
        {
            get
            {
                if (this.masterConfirmationType != null)
                {
                    return this.masterConfirmationType; 
                }
                else if (this.masterConfirmationTypeIDRef != null)
                {
                    masterConfirmationType = IDManager.getID(masterConfirmationTypeIDRef) as MasterConfirmationType;
                    return this.masterConfirmationType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmationType != value)
                {
                    this.masterConfirmationType = value;
                }
            }
        }
        #endregion
        
        public string MasterConfirmationTypeIDRef { get; set; }
        #region MasterConfirmationDate
        private XsdTypeDate masterConfirmationDate;
        public XsdTypeDate MasterConfirmationDate
        {
            get
            {
                if (this.masterConfirmationDate != null)
                {
                    return this.masterConfirmationDate; 
                }
                else if (this.masterConfirmationDateIDRef != null)
                {
                    masterConfirmationDate = IDManager.getID(masterConfirmationDateIDRef) as XsdTypeDate;
                    return this.masterConfirmationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmationDate != value)
                {
                    this.masterConfirmationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region MasterConfirmationAnnexDate
        private XsdTypeDate masterConfirmationAnnexDate;
        public XsdTypeDate MasterConfirmationAnnexDate
        {
            get
            {
                if (this.masterConfirmationAnnexDate != null)
                {
                    return this.masterConfirmationAnnexDate; 
                }
                else if (this.masterConfirmationAnnexDateIDRef != null)
                {
                    masterConfirmationAnnexDate = IDManager.getID(masterConfirmationAnnexDateIDRef) as XsdTypeDate;
                    return this.masterConfirmationAnnexDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmationAnnexDate != value)
                {
                    this.masterConfirmationAnnexDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region MasterConfirmationAnnexType
        private MasterConfirmationAnnexType masterConfirmationAnnexType;
        public MasterConfirmationAnnexType MasterConfirmationAnnexType
        {
            get
            {
                if (this.masterConfirmationAnnexType != null)
                {
                    return this.masterConfirmationAnnexType; 
                }
                else if (this.masterConfirmationAnnexTypeIDRef != null)
                {
                    masterConfirmationAnnexType = IDManager.getID(masterConfirmationAnnexTypeIDRef) as MasterConfirmationAnnexType;
                    return this.masterConfirmationAnnexType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmationAnnexType != value)
                {
                    this.masterConfirmationAnnexType = value;
                }
            }
        }
        #endregion
        
        public string MasterConfirmationAnnexTypeIDRef { get; set; }
        
    
        
    
    }
    
}

