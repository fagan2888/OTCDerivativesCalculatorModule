using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditInstrument : ISerialized
    {
        public CreditInstrument() { }
        public CreditInstrument(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNode underlyingInformationNode = xmlNode.SelectSingleNode("underlyingInformation");
            
            if (underlyingInformationNode != null)
            {
                if (underlyingInformationNode.Attributes["href"] != null || underlyingInformationNode.Attributes["id"] != null) 
                {
                    if (underlyingInformationNode.Attributes["id"] != null) 
                    {
                        underlyingInformationIDRef_ = underlyingInformationNode.Attributes["id"].Value;
                        UnderlyingInformation ob = new UnderlyingInformation(underlyingInformationNode);
                        IDManager.SetID(underlyingInformationIDRef_, ob);
                    }
                    else if (underlyingInformationNode.Attributes["href"] != null)
                    {
                        underlyingInformationIDRef_ = underlyingInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingInformation_ = new UnderlyingInformation(underlyingInformationNode);
                    }
                }
                else
                {
                    underlyingInformation_ = new UnderlyingInformation(underlyingInformationNode);
                }
            }
            
        
            XmlNode creditPayoffInfoNode = xmlNode.SelectSingleNode("creditPayoffInfo");
            
            if (creditPayoffInfoNode != null)
            {
                if (creditPayoffInfoNode.Attributes["href"] != null || creditPayoffInfoNode.Attributes["id"] != null) 
                {
                    if (creditPayoffInfoNode.Attributes["id"] != null) 
                    {
                        creditPayoffInfoIDRef_ = creditPayoffInfoNode.Attributes["id"].Value;
                        CreditPayoffInfo ob = new CreditPayoffInfo(creditPayoffInfoNode);
                        IDManager.SetID(creditPayoffInfoIDRef_, ob);
                    }
                    else if (creditPayoffInfoNode.Attributes["href"] != null)
                    {
                        creditPayoffInfoIDRef_ = creditPayoffInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditPayoffInfo_ = new CreditPayoffInfo(creditPayoffInfoNode);
                    }
                }
                else
                {
                    creditPayoffInfo_ = new CreditPayoffInfo(creditPayoffInfoNode);
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
                    throw new Exception( "issueInformation_Node no exist!");
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
        #region UnderlyingInformation_
        private UnderlyingInformation underlyingInformation_;
        public UnderlyingInformation UnderlyingInformation_
        {
            get
            {
                if (this.underlyingInformation_ != null)
                {
                    return this.underlyingInformation_; 
                }
                else if (this.underlyingInformationIDRef_ != null)
                {
                    underlyingInformation_ = IDManager.getID(underlyingInformationIDRef_) as UnderlyingInformation;
                    return this.underlyingInformation_; 
                }
                else
                {
                    throw new Exception( "underlyingInformation_Node no exist!");
                }
            }
            set
            {
                if (this.underlyingInformation_ != value)
                {
                    this.underlyingInformation_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingInformationIDRef_ { get; set; }
        #region CreditPayoffInfo_
        private CreditPayoffInfo creditPayoffInfo_;
        public CreditPayoffInfo CreditPayoffInfo_
        {
            get
            {
                if (this.creditPayoffInfo_ != null)
                {
                    return this.creditPayoffInfo_; 
                }
                else if (this.creditPayoffInfoIDRef_ != null)
                {
                    creditPayoffInfo_ = IDManager.getID(creditPayoffInfoIDRef_) as CreditPayoffInfo;
                    return this.creditPayoffInfo_; 
                }
                else
                {
                    throw new Exception( "creditPayoffInfo_Node no exist!");
                }
            }
            set
            {
                if (this.creditPayoffInfo_ != value)
                {
                    this.creditPayoffInfo_ = value;
                }
            }
        }
        #endregion
        
        public string creditPayoffInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

