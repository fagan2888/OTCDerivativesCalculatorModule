using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StandardInstrument : ISerialized
    {
        public StandardInstrument() { }
        public StandardInstrument(XmlNode xmlNode)
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
            
        
            XmlNode payoffInfoNode = xmlNode.SelectSingleNode("payoffInfo");
            
            if (payoffInfoNode != null)
            {
                if (payoffInfoNode.Attributes["href"] != null || payoffInfoNode.Attributes["id"] != null) 
                {
                    if (payoffInfoNode.Attributes["id"] != null) 
                    {
                        payoffInfoIDRef_ = payoffInfoNode.Attributes["id"].Value;
                        PayoffInfo ob = new PayoffInfo(payoffInfoNode);
                        IDManager.SetID(payoffInfoIDRef_, ob);
                    }
                    else if (payoffInfoNode.Attributes["href"] != null)
                    {
                        payoffInfoIDRef_ = payoffInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffInfo_ = new PayoffInfo(payoffInfoNode);
                    }
                }
                else
                {
                    payoffInfo_ = new PayoffInfo(payoffInfoNode);
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
        #region PayoffInfo_
        private PayoffInfo payoffInfo_;
        public PayoffInfo PayoffInfo_
        {
            get
            {
                if (this.payoffInfo_ != null)
                {
                    return this.payoffInfo_; 
                }
                else if (this.payoffInfoIDRef_ != null)
                {
                    payoffInfo_ = IDManager.getID(payoffInfoIDRef_) as PayoffInfo;
                    return this.payoffInfo_; 
                }
                else
                {
                    throw new Exception( "payoffInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffInfo_ != value)
                {
                    this.payoffInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

