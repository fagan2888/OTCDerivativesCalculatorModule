using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettledEntityMatrix : ISerialized
    {
        public SettledEntityMatrix(XmlNode xmlNode)
        {
            XmlNode matrixSourceNode = xmlNode.SelectSingleNode("matrixSource");
            
            if (matrixSourceNode != null)
            {
                if (matrixSourceNode.Attributes["href"] != null || matrixSourceNode.Attributes["id"] != null) 
                {
                    if (matrixSourceNode.Attributes["id"] != null) 
                    {
                        matrixSourceIDRef_ = matrixSourceNode.Attributes["id"].Value;
                        MatrixSource ob = new MatrixSource(matrixSourceNode);
                        IDManager.SetID(matrixSourceIDRef_, ob);
                    }
                    else if (matrixSourceNode.Attributes["href"] != null)
                    {
                        matrixSourceIDRef_ = matrixSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        matrixSource_ = new MatrixSource(matrixSourceNode);
                    }
                }
                else
                {
                    matrixSource_ = new MatrixSource(matrixSourceNode);
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
        
    
        #region MatrixSource_
        private MatrixSource matrixSource_;
        public MatrixSource MatrixSource_
        {
            get
            {
                if (this.matrixSource_ != null)
                {
                    return this.matrixSource_; 
                }
                else if (this.matrixSourceIDRef_ != null)
                {
                    matrixSource_ = IDManager.getID(matrixSourceIDRef_) as MatrixSource;
                    return this.matrixSource_; 
                }
                else
                {
                      return this.matrixSource_; 
                }
            }
            set
            {
                if (this.matrixSource_ != value)
                {
                    this.matrixSource_ = value;
                }
            }
        }
        #endregion
        
        public string matrixSourceIDRef_ { get; set; }
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

