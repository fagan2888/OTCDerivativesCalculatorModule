using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StandardSwapInstrument : ISerialized
    {
        public StandardSwapInstrument() { }
        public StandardSwapInstrument(XmlNode xmlNode)
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
            
        
            XmlNode swapPayoffInfoNode = xmlNode.SelectSingleNode("swapPayoffInfo");
            
            if (swapPayoffInfoNode != null)
            {
                if (swapPayoffInfoNode.Attributes["href"] != null || swapPayoffInfoNode.Attributes["id"] != null) 
                {
                    if (swapPayoffInfoNode.Attributes["id"] != null) 
                    {
                        swapPayoffInfoIDRef_ = swapPayoffInfoNode.Attributes["id"].Value;
                        SwapPayoffInfo ob = new SwapPayoffInfo(swapPayoffInfoNode);
                        IDManager.SetID(swapPayoffInfoIDRef_, ob);
                    }
                    else if (swapPayoffInfoNode.Attributes["href"] != null)
                    {
                        swapPayoffInfoIDRef_ = swapPayoffInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapPayoffInfo_ = new SwapPayoffInfo(swapPayoffInfoNode);
                    }
                }
                else
                {
                    swapPayoffInfo_ = new SwapPayoffInfo(swapPayoffInfoNode);
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
        #region SwapPayoffInfo_
        private SwapPayoffInfo swapPayoffInfo_;
        public SwapPayoffInfo SwapPayoffInfo_
        {
            get
            {
                if (this.swapPayoffInfo_ != null)
                {
                    return this.swapPayoffInfo_; 
                }
                else if (this.swapPayoffInfoIDRef_ != null)
                {
                    swapPayoffInfo_ = IDManager.getID(swapPayoffInfoIDRef_) as SwapPayoffInfo;
                    return this.swapPayoffInfo_; 
                }
                else
                {
                    throw new Exception( "swapPayoffInfo_Node no exist!");
                }
            }
            set
            {
                if (this.swapPayoffInfo_ != value)
                {
                    this.swapPayoffInfo_ = value;
                }
            }
        }
        #endregion
        
        public string swapPayoffInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

