using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ContractualMatrix
    {
        public ContractualMatrix(XmlNode xmlNode)
        {
            XmlNodeList matrixTypeNodeList = xmlNode.SelectNodes("matrixType");
            if (matrixTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in matrixTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        matrixTypeIDRef = item.Attributes["id"].Name;
                        MatrixType ob = MatrixType();
                        IDManager.SetID(matrixTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        matrixTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        matrixType = new MatrixType(item);
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
            
        
            XmlNodeList matrixTermNodeList = xmlNode.SelectNodes("matrixTerm");
            if (matrixTermNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in matrixTermNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        matrixTermIDRef = item.Attributes["id"].Name;
                        MatrixTerm ob = MatrixTerm();
                        IDManager.SetID(matrixTermIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        matrixTermIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        matrixTerm = new MatrixTerm(item);
                    }
                }
            }
            
        
        }
        
    
        #region MatrixType
        private MatrixType matrixType;
        public MatrixType MatrixType
        {
            get
            {
                if (this.matrixType != null)
                {
                    return this.matrixType; 
                }
                else if (this.matrixTypeIDRef != null)
                {
                    matrixType = IDManager.getID(matrixTypeIDRef) as MatrixType;
                    return this.matrixType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.matrixType != value)
                {
                    this.matrixType = value;
                }
            }
        }
        #endregion
        
        public string MatrixTypeIDRef { get; set; }
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
        #region MatrixTerm
        private MatrixTerm matrixTerm;
        public MatrixTerm MatrixTerm
        {
            get
            {
                if (this.matrixTerm != null)
                {
                    return this.matrixTerm; 
                }
                else if (this.matrixTermIDRef != null)
                {
                    matrixTerm = IDManager.getID(matrixTermIDRef) as MatrixTerm;
                    return this.matrixTerm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.matrixTerm != value)
                {
                    this.matrixTerm = value;
                }
            }
        }
        #endregion
        
        public string MatrixTermIDRef { get; set; }
        
    
        
    
    }
    
}

