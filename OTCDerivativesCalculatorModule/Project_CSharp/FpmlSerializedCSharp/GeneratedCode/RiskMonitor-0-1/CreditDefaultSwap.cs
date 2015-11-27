using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CreditDefaultSwap : ISerialized
    {
        public CreditDefaultSwap() { }
        public CreditDefaultSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceInformationListNode = xmlNode.SelectSingleNode("referenceInformationList");
            
            if (referenceInformationListNode != null)
            {
                if (referenceInformationListNode.Attributes["href"] != null || referenceInformationListNode.Attributes["id"] != null) 
                {
                    if (referenceInformationListNode.Attributes["id"] != null) 
                    {
                        referenceInformationListIDRef_ = referenceInformationListNode.Attributes["id"].Value;
                        ReferenceInformationList ob = new ReferenceInformationList(referenceInformationListNode);
                        IDManager.SetID(referenceInformationListIDRef_, ob);
                    }
                    else if (referenceInformationListNode.Attributes["href"] != null)
                    {
                        referenceInformationListIDRef_ = referenceInformationListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceInformationList_ = new ReferenceInformationList(referenceInformationListNode);
                    }
                }
                else
                {
                    referenceInformationList_ = new ReferenceInformationList(referenceInformationListNode);
                }
            }
            
        
            XmlNode protectionTermsNode = xmlNode.SelectSingleNode("protectionTerms");
            
            if (protectionTermsNode != null)
            {
                if (protectionTermsNode.Attributes["href"] != null || protectionTermsNode.Attributes["id"] != null) 
                {
                    if (protectionTermsNode.Attributes["id"] != null) 
                    {
                        protectionTermsIDRef_ = protectionTermsNode.Attributes["id"].Value;
                        ProtectionTerms ob = new ProtectionTerms(protectionTermsNode);
                        IDManager.SetID(protectionTermsIDRef_, ob);
                    }
                    else if (protectionTermsNode.Attributes["href"] != null)
                    {
                        protectionTermsIDRef_ = protectionTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        protectionTerms_ = new ProtectionTerms(protectionTermsNode);
                    }
                }
                else
                {
                    protectionTerms_ = new ProtectionTerms(protectionTermsNode);
                }
            }
            
        
            XmlNode swapStreamNode = xmlNode.SelectSingleNode("swapStream");
            
            if (swapStreamNode != null)
            {
                if (swapStreamNode.Attributes["href"] != null || swapStreamNode.Attributes["id"] != null) 
                {
                    if (swapStreamNode.Attributes["id"] != null) 
                    {
                        swapStreamIDRef_ = swapStreamNode.Attributes["id"].Value;
                        SwapStream ob = new SwapStream(swapStreamNode);
                        IDManager.SetID(swapStreamIDRef_, ob);
                    }
                    else if (swapStreamNode.Attributes["href"] != null)
                    {
                        swapStreamIDRef_ = swapStreamNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapStream_ = new SwapStream(swapStreamNode);
                    }
                }
                else
                {
                    swapStream_ = new SwapStream(swapStreamNode);
                }
            }
            
        
        }
        
    
        #region ReferenceInformationList_
        private ReferenceInformationList referenceInformationList_;
        public ReferenceInformationList ReferenceInformationList_
        {
            get
            {
                if (this.referenceInformationList_ != null)
                {
                    return this.referenceInformationList_; 
                }
                else if (this.referenceInformationListIDRef_ != null)
                {
                    referenceInformationList_ = IDManager.getID(referenceInformationListIDRef_) as ReferenceInformationList;
                    return this.referenceInformationList_; 
                }
                else
                {
                      return this.referenceInformationList_; 
                }
            }
            set
            {
                if (this.referenceInformationList_ != value)
                {
                    this.referenceInformationList_ = value;
                }
            }
        }
        #endregion
        
        public string referenceInformationListIDRef_ { get; set; }
        #region ProtectionTerms_
        private ProtectionTerms protectionTerms_;
        public ProtectionTerms ProtectionTerms_
        {
            get
            {
                if (this.protectionTerms_ != null)
                {
                    return this.protectionTerms_; 
                }
                else if (this.protectionTermsIDRef_ != null)
                {
                    protectionTerms_ = IDManager.getID(protectionTermsIDRef_) as ProtectionTerms;
                    return this.protectionTerms_; 
                }
                else
                {
                      return this.protectionTerms_; 
                }
            }
            set
            {
                if (this.protectionTerms_ != value)
                {
                    this.protectionTerms_ = value;
                }
            }
        }
        #endregion
        
        public string protectionTermsIDRef_ { get; set; }
        #region SwapStream_
        private SwapStream swapStream_;
        public SwapStream SwapStream_
        {
            get
            {
                if (this.swapStream_ != null)
                {
                    return this.swapStream_; 
                }
                else if (this.swapStreamIDRef_ != null)
                {
                    swapStream_ = IDManager.getID(swapStreamIDRef_) as SwapStream;
                    return this.swapStream_; 
                }
                else
                {
                      return this.swapStream_; 
                }
            }
            set
            {
                if (this.swapStream_ != value)
                {
                    this.swapStream_ = value;
                }
            }
        }
        #endregion
        
        public string swapStreamIDRef_ { get; set; }
        
    
        
    
    }
    
}

