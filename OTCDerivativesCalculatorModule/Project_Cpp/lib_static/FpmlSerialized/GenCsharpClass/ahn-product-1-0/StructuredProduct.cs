using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StructuredProduct
    {
        public StructuredProduct(XmlNode xmlNode)
        {
            XmlNodeList issueInformationNodeList = xmlNode.SelectNodes("issueInformation");
            if (issueInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in issueInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        issueInformationIDRef = item.Attributes["id"].Name;
                        IssueInformation ob = IssueInformation();
                        IDManager.SetID(issueInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        issueInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        issueInformation = new IssueInformation(item);
                    }
                }
            }
            
        
            XmlNodeList structuredProductPayoffNodeList = xmlNode.SelectNodes("structuredProductPayoff");
            if (structuredProductPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in structuredProductPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        structuredProductPayoffIDRef = item.Attributes["id"].Name;
                        StructuredProductPayoff ob = StructuredProductPayoff();
                        IDManager.SetID(structuredProductPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        structuredProductPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        structuredProductPayoff = new StructuredProductPayoff(item);
                    }
                }
            }
            
        
        }
        
    
        #region IssueInformation
        private IssueInformation issueInformation;
        public IssueInformation IssueInformation
        {
            get
            {
                if (this.issueInformation != null)
                {
                    return this.issueInformation; 
                }
                else if (this.issueInformationIDRef != null)
                {
                    issueInformation = IDManager.getID(issueInformationIDRef) as IssueInformation;
                    return this.issueInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.issueInformation != value)
                {
                    this.issueInformation = value;
                }
            }
        }
        #endregion
        
        public string IssueInformationIDRef { get; set; }
        #region StructuredProductPayoff
        private StructuredProductPayoff structuredProductPayoff;
        public StructuredProductPayoff StructuredProductPayoff
        {
            get
            {
                if (this.structuredProductPayoff != null)
                {
                    return this.structuredProductPayoff; 
                }
                else if (this.structuredProductPayoffIDRef != null)
                {
                    structuredProductPayoff = IDManager.getID(structuredProductPayoffIDRef) as StructuredProductPayoff;
                    return this.structuredProductPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.structuredProductPayoff != value)
                {
                    this.structuredProductPayoff = value;
                }
            }
        }
        #endregion
        
        public string StructuredProductPayoffIDRef { get; set; }
        
    
        
    
    }
    
}

