using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StepDownKIPayoff : ISerialized
    {
        public StepDownKIPayoff() { }
        public StepDownKIPayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventTriggerListNode = xmlNode.SelectSingleNode("eventTriggerList");
            
            if (eventTriggerListNode != null)
            {
                if (eventTriggerListNode.Attributes["href"] != null || eventTriggerListNode.Attributes["id"] != null) 
                {
                    if (eventTriggerListNode.Attributes["id"] != null) 
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["id"].Value;
                        EventTriggerList ob = new EventTriggerList(eventTriggerListNode);
                        IDManager.SetID(eventTriggerListIDRef_, ob);
                    }
                    else if (eventTriggerListNode.Attributes["href"] != null)
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                    }
                }
                else
                {
                    eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                }
            }
            
        
            XmlNode kiEventInfoNode = xmlNode.SelectSingleNode("kiEventInfo");
            
            if (kiEventInfoNode != null)
            {
                if (kiEventInfoNode.Attributes["href"] != null || kiEventInfoNode.Attributes["id"] != null) 
                {
                    if (kiEventInfoNode.Attributes["id"] != null) 
                    {
                        kiEventInfoIDRef_ = kiEventInfoNode.Attributes["id"].Value;
                        KiEventInfo ob = new KiEventInfo(kiEventInfoNode);
                        IDManager.SetID(kiEventInfoIDRef_, ob);
                    }
                    else if (kiEventInfoNode.Attributes["href"] != null)
                    {
                        kiEventInfoIDRef_ = kiEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        kiEventInfo_ = new KiEventInfo(kiEventInfoNode);
                    }
                }
                else
                {
                    kiEventInfo_ = new KiEventInfo(kiEventInfoNode);
                }
            }
            
        
            XmlNode nonKiEventInfoNode = xmlNode.SelectSingleNode("nonKiEventInfo");
            
            if (nonKiEventInfoNode != null)
            {
                if (nonKiEventInfoNode.Attributes["href"] != null || nonKiEventInfoNode.Attributes["id"] != null) 
                {
                    if (nonKiEventInfoNode.Attributes["id"] != null) 
                    {
                        nonKiEventInfoIDRef_ = nonKiEventInfoNode.Attributes["id"].Value;
                        NonKiEventInfo ob = new NonKiEventInfo(nonKiEventInfoNode);
                        IDManager.SetID(nonKiEventInfoIDRef_, ob);
                    }
                    else if (nonKiEventInfoNode.Attributes["href"] != null)
                    {
                        nonKiEventInfoIDRef_ = nonKiEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonKiEventInfo_ = new NonKiEventInfo(nonKiEventInfoNode);
                    }
                }
                else
                {
                    nonKiEventInfo_ = new NonKiEventInfo(nonKiEventInfoNode);
                }
            }
            
        
        }
        
    
        #region EventTriggerList_
        private EventTriggerList eventTriggerList_;
        public EventTriggerList EventTriggerList_
        {
            get
            {
                if (this.eventTriggerList_ != null)
                {
                    return this.eventTriggerList_; 
                }
                else if (this.eventTriggerListIDRef_ != null)
                {
                    eventTriggerList_ = IDManager.getID(eventTriggerListIDRef_) as EventTriggerList;
                    return this.eventTriggerList_; 
                }
                else
                {
                    throw new Exception( "eventTriggerList_Node no exist!");
                }
            }
            set
            {
                if (this.eventTriggerList_ != value)
                {
                    this.eventTriggerList_ = value;
                }
            }
        }
        #endregion
        
        public string eventTriggerListIDRef_ { get; set; }
        #region KiEventInfo_
        private KiEventInfo kiEventInfo_;
        public KiEventInfo KiEventInfo_
        {
            get
            {
                if (this.kiEventInfo_ != null)
                {
                    return this.kiEventInfo_; 
                }
                else if (this.kiEventInfoIDRef_ != null)
                {
                    kiEventInfo_ = IDManager.getID(kiEventInfoIDRef_) as KiEventInfo;
                    return this.kiEventInfo_; 
                }
                else
                {
                    throw new Exception( "kiEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.kiEventInfo_ != value)
                {
                    this.kiEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string kiEventInfoIDRef_ { get; set; }
        #region NonKiEventInfo_
        private NonKiEventInfo nonKiEventInfo_;
        public NonKiEventInfo NonKiEventInfo_
        {
            get
            {
                if (this.nonKiEventInfo_ != null)
                {
                    return this.nonKiEventInfo_; 
                }
                else if (this.nonKiEventInfoIDRef_ != null)
                {
                    nonKiEventInfo_ = IDManager.getID(nonKiEventInfoIDRef_) as NonKiEventInfo;
                    return this.nonKiEventInfo_; 
                }
                else
                {
                    throw new Exception( "nonKiEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.nonKiEventInfo_ != value)
                {
                    this.nonKiEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string nonKiEventInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

