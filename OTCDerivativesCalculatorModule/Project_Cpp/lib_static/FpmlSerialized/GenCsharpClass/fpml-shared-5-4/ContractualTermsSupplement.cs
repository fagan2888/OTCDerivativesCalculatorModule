using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ContractualTermsSupplement
    {
        public ContractualTermsSupplement(XmlNode xmlNode)
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
                        ContractualSupplement ob = ContractualSupplement();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new ContractualSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList publicationDateNodeList = xmlNode.SelectNodes("publicationDate");
            if (publicationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publicationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publicationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(publicationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publicationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publicationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private ContractualSupplement type;
        public ContractualSupplement Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as ContractualSupplement;
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
        
        public string ContractualSupplementIDRef { get; set; }
        #region PublicationDate
        private XsdTypeDate publicationDate;
        public XsdTypeDate PublicationDate
        {
            get
            {
                if (this.publicationDate != null)
                {
                    return this.publicationDate; 
                }
                else if (this.publicationDateIDRef != null)
                {
                    publicationDate = IDManager.getID(publicationDateIDRef) as XsdTypeDate;
                    return this.publicationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publicationDate != value)
                {
                    this.publicationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

