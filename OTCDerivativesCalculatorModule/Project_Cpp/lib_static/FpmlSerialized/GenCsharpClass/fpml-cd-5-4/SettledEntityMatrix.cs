using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettledEntityMatrix
    {
        public SettledEntityMatrix(XmlNode xmlNode)
        {
            XmlNodeList matrixSourceNodeList = xmlNode.SelectNodes("matrixSource");
            if (matrixSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in matrixSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        matrixSourceIDRef = item.Attributes["id"].Name;
                        MatrixSource ob = MatrixSource();
                        IDManager.SetID(matrixSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        matrixSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        matrixSource = new MatrixSource(item);
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
        
    
        #region MatrixSource
        private MatrixSource matrixSource;
        public MatrixSource MatrixSource
        {
            get
            {
                if (this.matrixSource != null)
                {
                    return this.matrixSource; 
                }
                else if (this.matrixSourceIDRef != null)
                {
                    matrixSource = IDManager.getID(matrixSourceIDRef) as MatrixSource;
                    return this.matrixSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.matrixSource != value)
                {
                    this.matrixSource = value;
                }
            }
        }
        #endregion
        
        public string MatrixSourceIDRef { get; set; }
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

