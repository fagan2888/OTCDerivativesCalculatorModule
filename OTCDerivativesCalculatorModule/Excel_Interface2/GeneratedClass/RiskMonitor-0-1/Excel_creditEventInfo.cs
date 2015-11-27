using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_creditEventInfo : ISerialized
    {
        public Excel_creditEventInfo() { }
        public Excel_creditEventInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_issueInfoNode = xmlNode.SelectSingleNode("excel_issueInfo");
            
            if (excel_issueInfoNode != null)
            {
                if (excel_issueInfoNode.Attributes["href"] != null || excel_issueInfoNode.Attributes["id"] != null) 
                {
                    if (excel_issueInfoNode.Attributes["id"] != null) 
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["id"].Value;
                        Excel_issueInfo ob = new Excel_issueInfo(excel_issueInfoNode);
                        IDManager.SetID(excel_issueInfoIDRef_, ob);
                    }
                    else if (excel_issueInfoNode.Attributes["href"] != null)
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                    }
                }
                else
                {
                    excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                }
            }
            
        
            XmlNode excel_referenceInformationListNode = xmlNode.SelectSingleNode("excel_referenceInformationList");
            
            if (excel_referenceInformationListNode != null)
            {
                if (excel_referenceInformationListNode.Attributes["href"] != null || excel_referenceInformationListNode.Attributes["id"] != null) 
                {
                    if (excel_referenceInformationListNode.Attributes["id"] != null) 
                    {
                        excel_referenceInformationListIDRef_ = excel_referenceInformationListNode.Attributes["id"].Value;
                        Excel_referenceInformationList ob = new Excel_referenceInformationList(excel_referenceInformationListNode);
                        IDManager.SetID(excel_referenceInformationListIDRef_, ob);
                    }
                    else if (excel_referenceInformationListNode.Attributes["href"] != null)
                    {
                        excel_referenceInformationListIDRef_ = excel_referenceInformationListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_referenceInformationList_ = new Excel_referenceInformationList(excel_referenceInformationListNode);
                    }
                }
                else
                {
                    excel_referenceInformationList_ = new Excel_referenceInformationList(excel_referenceInformationListNode);
                }
            }
            
        
            XmlNode excel_jointProbabilityTraitNode = xmlNode.SelectSingleNode("excel_jointProbabilityTrait");
            
            if (excel_jointProbabilityTraitNode != null)
            {
                if (excel_jointProbabilityTraitNode.Attributes["href"] != null || excel_jointProbabilityTraitNode.Attributes["id"] != null) 
                {
                    if (excel_jointProbabilityTraitNode.Attributes["id"] != null) 
                    {
                        excel_jointProbabilityTraitIDRef_ = excel_jointProbabilityTraitNode.Attributes["id"].Value;
                        Excel_jointProbabilityTrait ob = new Excel_jointProbabilityTrait(excel_jointProbabilityTraitNode);
                        IDManager.SetID(excel_jointProbabilityTraitIDRef_, ob);
                    }
                    else if (excel_jointProbabilityTraitNode.Attributes["href"] != null)
                    {
                        excel_jointProbabilityTraitIDRef_ = excel_jointProbabilityTraitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_jointProbabilityTrait_ = new Excel_jointProbabilityTrait(excel_jointProbabilityTraitNode);
                    }
                }
                else
                {
                    excel_jointProbabilityTrait_ = new Excel_jointProbabilityTrait(excel_jointProbabilityTraitNode);
                }
            }
            
        
            XmlNode excel_protectionTermsNode = xmlNode.SelectSingleNode("excel_protectionTerms");
            
            if (excel_protectionTermsNode != null)
            {
                if (excel_protectionTermsNode.Attributes["href"] != null || excel_protectionTermsNode.Attributes["id"] != null) 
                {
                    if (excel_protectionTermsNode.Attributes["id"] != null) 
                    {
                        excel_protectionTermsIDRef_ = excel_protectionTermsNode.Attributes["id"].Value;
                        Excel_protectionTerms ob = new Excel_protectionTerms(excel_protectionTermsNode);
                        IDManager.SetID(excel_protectionTermsIDRef_, ob);
                    }
                    else if (excel_protectionTermsNode.Attributes["href"] != null)
                    {
                        excel_protectionTermsIDRef_ = excel_protectionTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_protectionTerms_ = new Excel_protectionTerms(excel_protectionTermsNode);
                    }
                }
                else
                {
                    excel_protectionTerms_ = new Excel_protectionTerms(excel_protectionTermsNode);
                }
            }
            
        
        }
        
    
        #region Excel_issueInfo_
        private Excel_issueInfo excel_issueInfo_;
        public Excel_issueInfo Excel_issueInfo_
        {
            get
            {
                if (this.excel_issueInfo_ != null)
                {
                    return this.excel_issueInfo_; 
                }
                else if (this.excel_issueInfoIDRef_ != null)
                {
                    excel_issueInfo_ = IDManager.getID(excel_issueInfoIDRef_) as Excel_issueInfo;
                    return this.excel_issueInfo_; 
                }
                else
                {
                    throw new Exception( "excel_issueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_issueInfo_ != value)
                {
                    this.excel_issueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_issueInfoIDRef_ { get; set; }
        #region Excel_referenceInformationList_
        private Excel_referenceInformationList excel_referenceInformationList_;
        public Excel_referenceInformationList Excel_referenceInformationList_
        {
            get
            {
                if (this.excel_referenceInformationList_ != null)
                {
                    return this.excel_referenceInformationList_; 
                }
                else if (this.excel_referenceInformationListIDRef_ != null)
                {
                    excel_referenceInformationList_ = IDManager.getID(excel_referenceInformationListIDRef_) as Excel_referenceInformationList;
                    return this.excel_referenceInformationList_; 
                }
                else
                {
                    throw new Exception( "excel_referenceInformationList_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceInformationList_ != value)
                {
                    this.excel_referenceInformationList_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceInformationListIDRef_ { get; set; }
        #region Excel_jointProbabilityTrait_
        private Excel_jointProbabilityTrait excel_jointProbabilityTrait_;
        public Excel_jointProbabilityTrait Excel_jointProbabilityTrait_
        {
            get
            {
                if (this.excel_jointProbabilityTrait_ != null)
                {
                    return this.excel_jointProbabilityTrait_; 
                }
                else if (this.excel_jointProbabilityTraitIDRef_ != null)
                {
                    excel_jointProbabilityTrait_ = IDManager.getID(excel_jointProbabilityTraitIDRef_) as Excel_jointProbabilityTrait;
                    return this.excel_jointProbabilityTrait_; 
                }
                else
                {
                    throw new Exception( "excel_jointProbabilityTrait_Node no exist!");
                }
            }
            set
            {
                if (this.excel_jointProbabilityTrait_ != value)
                {
                    this.excel_jointProbabilityTrait_ = value;
                }
            }
        }
        #endregion
        
        public string excel_jointProbabilityTraitIDRef_ { get; set; }
        #region Excel_protectionTerms_
        private Excel_protectionTerms excel_protectionTerms_;
        public Excel_protectionTerms Excel_protectionTerms_
        {
            get
            {
                if (this.excel_protectionTerms_ != null)
                {
                    return this.excel_protectionTerms_; 
                }
                else if (this.excel_protectionTermsIDRef_ != null)
                {
                    excel_protectionTerms_ = IDManager.getID(excel_protectionTermsIDRef_) as Excel_protectionTerms;
                    return this.excel_protectionTerms_; 
                }
                else
                {
                    throw new Exception( "excel_protectionTerms_Node no exist!");
                }
            }
            set
            {
                if (this.excel_protectionTerms_ != value)
                {
                    this.excel_protectionTerms_ = value;
                }
            }
        }
        #endregion
        
        public string excel_protectionTermsIDRef_ { get; set; }
        
    
        
    
    }
    
}

