using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ContractualMatrix : ISerialized
    {
        public ContractualMatrix(XmlNode xmlNode)
        {
            XmlNode matrixTypeNode = xmlNode.SelectSingleNode("matrixType");
            
            if (matrixTypeNode != null)
            {
                if (matrixTypeNode.Attributes["href"] != null || matrixTypeNode.Attributes["id"] != null) 
                {
                    if (matrixTypeNode.Attributes["id"] != null) 
                    {
                        matrixTypeIDRef_ = matrixTypeNode.Attributes["id"].Value;
                        MatrixType ob = new MatrixType(matrixTypeNode);
                        IDManager.SetID(matrixTypeIDRef_, ob);
                    }
                    else if (matrixTypeNode.Attributes["href"] != null)
                    {
                        matrixTypeIDRef_ = matrixTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        matrixType_ = new MatrixType(matrixTypeNode);
                    }
                }
                else
                {
                    matrixType_ = new MatrixType(matrixTypeNode);
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
            
        
            XmlNode matrixTermNode = xmlNode.SelectSingleNode("matrixTerm");
            
            if (matrixTermNode != null)
            {
                if (matrixTermNode.Attributes["href"] != null || matrixTermNode.Attributes["id"] != null) 
                {
                    if (matrixTermNode.Attributes["id"] != null) 
                    {
                        matrixTermIDRef_ = matrixTermNode.Attributes["id"].Value;
                        MatrixTerm ob = new MatrixTerm(matrixTermNode);
                        IDManager.SetID(matrixTermIDRef_, ob);
                    }
                    else if (matrixTermNode.Attributes["href"] != null)
                    {
                        matrixTermIDRef_ = matrixTermNode.Attributes["href"].Value;
                    }
                    else
                    {
                        matrixTerm_ = new MatrixTerm(matrixTermNode);
                    }
                }
                else
                {
                    matrixTerm_ = new MatrixTerm(matrixTermNode);
                }
            }
            
        
        }
        
    
        #region MatrixType_
        private MatrixType matrixType_;
        public MatrixType MatrixType_
        {
            get
            {
                if (this.matrixType_ != null)
                {
                    return this.matrixType_; 
                }
                else if (this.matrixTypeIDRef_ != null)
                {
                    matrixType_ = IDManager.getID(matrixTypeIDRef_) as MatrixType;
                    return this.matrixType_; 
                }
                else
                {
                      return this.matrixType_; 
                }
            }
            set
            {
                if (this.matrixType_ != value)
                {
                    this.matrixType_ = value;
                }
            }
        }
        #endregion
        
        public string matrixTypeIDRef_ { get; set; }
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
        #region MatrixTerm_
        private MatrixTerm matrixTerm_;
        public MatrixTerm MatrixTerm_
        {
            get
            {
                if (this.matrixTerm_ != null)
                {
                    return this.matrixTerm_; 
                }
                else if (this.matrixTermIDRef_ != null)
                {
                    matrixTerm_ = IDManager.getID(matrixTermIDRef_) as MatrixTerm;
                    return this.matrixTerm_; 
                }
                else
                {
                      return this.matrixTerm_; 
                }
            }
            set
            {
                if (this.matrixTerm_ != value)
                {
                    this.matrixTerm_ = value;
                }
            }
        }
        #endregion
        
        public string matrixTermIDRef_ { get; set; }
        
    
        
    
    }
    
}

