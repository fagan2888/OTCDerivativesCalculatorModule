using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ContractualTermsSupplement : ISerialized
    {
        public ContractualTermsSupplement(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        ContractualSupplement ob = new ContractualSupplement(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new ContractualSupplement(typeNode);
                    }
                }
                else
                {
                    type_ = new ContractualSupplement(typeNode);
                }
            }
            
        
            XmlNode publicationDateNode = xmlNode.SelectSingleNode("publicationDate");
            
            if (publicationDateNode != null)
            {
                if (publicationDateNode.Attributes["href"] != null || publicationDateNode.Attributes["id"] != null) 
                {
                    if (publicationDateNode.Attributes["id"] != null) 
                    {
                        publicationDateIDRef_ = publicationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(publicationDateNode);
                        IDManager.SetID(publicationDateIDRef_, ob);
                    }
                    else if (publicationDateNode.Attributes["href"] != null)
                    {
                        publicationDateIDRef_ = publicationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publicationDate_ = new XsdTypeDate(publicationDateNode);
                    }
                }
                else
                {
                    publicationDate_ = new XsdTypeDate(publicationDateNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private ContractualSupplement type_;
        public ContractualSupplement Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as ContractualSupplement;
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
        #region PublicationDate_
        private XsdTypeDate publicationDate_;
        public XsdTypeDate PublicationDate_
        {
            get
            {
                if (this.publicationDate_ != null)
                {
                    return this.publicationDate_; 
                }
                else if (this.publicationDateIDRef_ != null)
                {
                    publicationDate_ = IDManager.getID(publicationDateIDRef_) as XsdTypeDate;
                    return this.publicationDate_; 
                }
                else
                {
                      return this.publicationDate_; 
                }
            }
            set
            {
                if (this.publicationDate_ != value)
                {
                    this.publicationDate_ = value;
                }
            }
        }
        #endregion
        
        public string publicationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

