using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExerciseNotice
    {
        public ExerciseNotice(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseNoticePartyReferenceNodeList = xmlNode.SelectNodes("exerciseNoticePartyReference");
            if (exerciseNoticePartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseNoticePartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseNoticePartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(exerciseNoticePartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseNoticePartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseNoticePartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            if (businessCenterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCenterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCenterIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(businessCenterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCenterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenter = new BusinessCenter(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ExerciseNoticePartyReference
        private PartyReference exerciseNoticePartyReference;
        public PartyReference ExerciseNoticePartyReference
        {
            get
            {
                if (this.exerciseNoticePartyReference != null)
                {
                    return this.exerciseNoticePartyReference; 
                }
                else if (this.exerciseNoticePartyReferenceIDRef != null)
                {
                    exerciseNoticePartyReference = IDManager.getID(exerciseNoticePartyReferenceIDRef) as PartyReference;
                    return this.exerciseNoticePartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseNoticePartyReference != value)
                {
                    this.exerciseNoticePartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BusinessCenter
        private BusinessCenter businessCenter;
        public BusinessCenter BusinessCenter
        {
            get
            {
                if (this.businessCenter != null)
                {
                    return this.businessCenter; 
                }
                else if (this.businessCenterIDRef != null)
                {
                    businessCenter = IDManager.getID(businessCenterIDRef) as BusinessCenter;
                    return this.businessCenter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenter != value)
                {
                    this.businessCenter = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        
    
        
    
    }
    
}

