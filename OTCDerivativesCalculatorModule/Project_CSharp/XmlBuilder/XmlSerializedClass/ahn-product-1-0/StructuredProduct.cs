using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StructuredProduct : ISerialized
    {
        public StructuredProduct(XmlNode xmlNode)
        {
            XmlNode issueInformationNode = xmlNode.SelectSingleNode("issueInformation");
            
            if (issueInformationNode != null)
            {
                if (issueInformationNode.Attributes["href"] != null || issueInformationNode.Attributes["id"] != null) 
                {
                    if (issueInformationNode.Attributes["id"] != null) 
                    {
                        issueInformationIDRef_ = issueInformationNode.Attributes["id"].Value;
                        IssueInformation ob = new IssueInformation(issueInformationNode);
                        IDManager.SetID(issueInformationIDRef_, ob);
                    }
                    else if (issueInformationNode.Attributes["href"] != null)
                    {
                        issueInformationIDRef_ = issueInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issueInformation_ = new IssueInformation(issueInformationNode);
                    }
                }
                else
                {
                    issueInformation_ = new IssueInformation(issueInformationNode);
                }
            }
            
        
            XmlNode structuredProductPayoffNode = xmlNode.SelectSingleNode("structuredProductPayoff");
            
            if (structuredProductPayoffNode != null)
            {
                if (structuredProductPayoffNode.Attributes["href"] != null || structuredProductPayoffNode.Attributes["id"] != null) 
                {
                    if (structuredProductPayoffNode.Attributes["id"] != null) 
                    {
                        structuredProductPayoffIDRef_ = structuredProductPayoffNode.Attributes["id"].Value;
                        StructuredProductPayoff ob = new StructuredProductPayoff(structuredProductPayoffNode);
                        IDManager.SetID(structuredProductPayoffIDRef_, ob);
                    }
                    else if (structuredProductPayoffNode.Attributes["href"] != null)
                    {
                        structuredProductPayoffIDRef_ = structuredProductPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        structuredProductPayoff_ = new StructuredProductPayoff(structuredProductPayoffNode);
                    }
                }
                else
                {
                    structuredProductPayoff_ = new StructuredProductPayoff(structuredProductPayoffNode);
                }
            }
            
        
        }
        
    
        #region IssueInformation_
        private IssueInformation issueInformation_;
        public IssueInformation IssueInformation_
        {
            get
            {
                if (this.issueInformation_ != null)
                {
                    return this.issueInformation_; 
                }
                else if (this.issueInformationIDRef_ != null)
                {
                    issueInformation_ = IDManager.getID(issueInformationIDRef_) as IssueInformation;
                    return this.issueInformation_; 
                }
                else
                {
                      return this.issueInformation_; 
                }
            }
            set
            {
                if (this.issueInformation_ != value)
                {
                    this.issueInformation_ = value;
                }
            }
        }
        #endregion
        
        public string issueInformationIDRef_ { get; set; }
        #region StructuredProductPayoff_
        private StructuredProductPayoff structuredProductPayoff_;
        public StructuredProductPayoff StructuredProductPayoff_
        {
            get
            {
                if (this.structuredProductPayoff_ != null)
                {
                    return this.structuredProductPayoff_; 
                }
                else if (this.structuredProductPayoffIDRef_ != null)
                {
                    structuredProductPayoff_ = IDManager.getID(structuredProductPayoffIDRef_) as StructuredProductPayoff;
                    return this.structuredProductPayoff_; 
                }
                else
                {
                      return this.structuredProductPayoff_; 
                }
            }
            set
            {
                if (this.structuredProductPayoff_ != value)
                {
                    this.structuredProductPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string structuredProductPayoffIDRef_ { get; set; }
        
    
        
    
    }
    
}

