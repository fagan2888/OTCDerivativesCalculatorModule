using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Instrument : ISerialized
    {
        public Instrument() { }
        public Instrument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode headerNode = xmlNode.SelectSingleNode("header");
            
            if (headerNode != null)
            {
                if (headerNode.Attributes["href"] != null || headerNode.Attributes["id"] != null) 
                {
                    if (headerNode.Attributes["id"] != null) 
                    {
                        headerIDRef_ = headerNode.Attributes["id"].Value;
                        Header ob = new Header(headerNode);
                        IDManager.SetID(headerIDRef_, ob);
                    }
                    else if (headerNode.Attributes["href"] != null)
                    {
                        headerIDRef_ = headerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        header_ = new Header(headerNode);
                    }
                }
                else
                {
                    header_ = new Header(headerNode);
                }
            }
            
        
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
            
        
            XmlNode calculationAgentNode = xmlNode.SelectSingleNode("calculationAgent");
            
            if (calculationAgentNode != null)
            {
                if (calculationAgentNode.Attributes["href"] != null || calculationAgentNode.Attributes["id"] != null) 
                {
                    if (calculationAgentNode.Attributes["id"] != null) 
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["id"].Value;
                        CalculationAgent ob = new CalculationAgent(calculationAgentNode);
                        IDManager.SetID(calculationAgentIDRef_, ob);
                    }
                    else if (calculationAgentNode.Attributes["href"] != null)
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgent_ = new CalculationAgent(calculationAgentNode);
                    }
                }
                else
                {
                    calculationAgent_ = new CalculationAgent(calculationAgentNode);
                }
            }
            
        
        }
        
    
        #region Header_
        private Header header_;
        public Header Header_
        {
            get
            {
                if (this.header_ != null)
                {
                    return this.header_; 
                }
                else if (this.headerIDRef_ != null)
                {
                    header_ = IDManager.getID(headerIDRef_) as Header;
                    return this.header_; 
                }
                else
                {
                      return this.header_; 
                }
            }
            set
            {
                if (this.header_ != value)
                {
                    this.header_ = value;
                }
            }
        }
        #endregion
        
        public string headerIDRef_ { get; set; }
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
        #region CalculationAgent_
        private CalculationAgent calculationAgent_;
        public CalculationAgent CalculationAgent_
        {
            get
            {
                if (this.calculationAgent_ != null)
                {
                    return this.calculationAgent_; 
                }
                else if (this.calculationAgentIDRef_ != null)
                {
                    calculationAgent_ = IDManager.getID(calculationAgentIDRef_) as CalculationAgent;
                    return this.calculationAgent_; 
                }
                else
                {
                      return this.calculationAgent_; 
                }
            }
            set
            {
                if (this.calculationAgent_ != value)
                {
                    this.calculationAgent_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentIDRef_ { get; set; }
        
    
        
    
    }
    
}

