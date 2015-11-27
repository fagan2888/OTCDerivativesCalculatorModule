using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExerciseNotice : ISerialized
    {
        public ExerciseNotice(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode exerciseNoticePartyReferenceNode = xmlNode.SelectSingleNode("exerciseNoticePartyReference");
            
            if (exerciseNoticePartyReferenceNode != null)
            {
                if (exerciseNoticePartyReferenceNode.Attributes["href"] != null || exerciseNoticePartyReferenceNode.Attributes["id"] != null) 
                {
                    if (exerciseNoticePartyReferenceNode.Attributes["id"] != null) 
                    {
                        exerciseNoticePartyReferenceIDRef_ = exerciseNoticePartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(exerciseNoticePartyReferenceNode);
                        IDManager.SetID(exerciseNoticePartyReferenceIDRef_, ob);
                    }
                    else if (exerciseNoticePartyReferenceNode.Attributes["href"] != null)
                    {
                        exerciseNoticePartyReferenceIDRef_ = exerciseNoticePartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseNoticePartyReference_ = new PartyReference(exerciseNoticePartyReferenceNode);
                    }
                }
                else
                {
                    exerciseNoticePartyReference_ = new PartyReference(exerciseNoticePartyReferenceNode);
                }
            }
            
        
            XmlNode businessCenterNode = xmlNode.SelectSingleNode("businessCenter");
            
            if (businessCenterNode != null)
            {
                if (businessCenterNode.Attributes["href"] != null || businessCenterNode.Attributes["id"] != null) 
                {
                    if (businessCenterNode.Attributes["id"] != null) 
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(businessCenterNode);
                        IDManager.SetID(businessCenterIDRef_, ob);
                    }
                    else if (businessCenterNode.Attributes["href"] != null)
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenter_ = new BusinessCenter(businessCenterNode);
                    }
                }
                else
                {
                    businessCenter_ = new BusinessCenter(businessCenterNode);
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region ExerciseNoticePartyReference_
        private PartyReference exerciseNoticePartyReference_;
        public PartyReference ExerciseNoticePartyReference_
        {
            get
            {
                if (this.exerciseNoticePartyReference_ != null)
                {
                    return this.exerciseNoticePartyReference_; 
                }
                else if (this.exerciseNoticePartyReferenceIDRef_ != null)
                {
                    exerciseNoticePartyReference_ = IDManager.getID(exerciseNoticePartyReferenceIDRef_) as PartyReference;
                    return this.exerciseNoticePartyReference_; 
                }
                else
                {
                      return this.exerciseNoticePartyReference_; 
                }
            }
            set
            {
                if (this.exerciseNoticePartyReference_ != value)
                {
                    this.exerciseNoticePartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseNoticePartyReferenceIDRef_ { get; set; }
        #region BusinessCenter_
        private BusinessCenter businessCenter_;
        public BusinessCenter BusinessCenter_
        {
            get
            {
                if (this.businessCenter_ != null)
                {
                    return this.businessCenter_; 
                }
                else if (this.businessCenterIDRef_ != null)
                {
                    businessCenter_ = IDManager.getID(businessCenterIDRef_) as BusinessCenter;
                    return this.businessCenter_; 
                }
                else
                {
                      return this.businessCenter_; 
                }
            }
            set
            {
                if (this.businessCenter_ != value)
                {
                    this.businessCenter_ = value;
                }
            }
        }
        #endregion
        
        public string businessCenterIDRef_ { get; set; }
        
    
        
    
    }
    
}

