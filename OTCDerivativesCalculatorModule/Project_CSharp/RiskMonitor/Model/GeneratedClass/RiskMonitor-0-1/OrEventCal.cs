using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OrEventCal : ISerialized
    {
        public OrEventCal() { }
        public OrEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventCalculationListNode = xmlNode.SelectSingleNode("eventCalculationList");
            
            if (eventCalculationListNode != null)
            {
                if (eventCalculationListNode.Attributes["href"] != null || eventCalculationListNode.Attributes["id"] != null) 
                {
                    if (eventCalculationListNode.Attributes["id"] != null) 
                    {
                        eventCalculationListIDRef_ = eventCalculationListNode.Attributes["id"].Value;
                        EventCalculationList ob = new EventCalculationList(eventCalculationListNode);
                        IDManager.SetID(eventCalculationListIDRef_, ob);
                    }
                    else if (eventCalculationListNode.Attributes["href"] != null)
                    {
                        eventCalculationListIDRef_ = eventCalculationListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventCalculationList_ = new EventCalculationList(eventCalculationListNode);
                    }
                }
                else
                {
                    eventCalculationList_ = new EventCalculationList(eventCalculationListNode);
                }
            }
            
        
            XmlNode complementNode = xmlNode.SelectSingleNode("complement");
            
            if (complementNode != null)
            {
                if (complementNode.Attributes["href"] != null || complementNode.Attributes["id"] != null) 
                {
                    if (complementNode.Attributes["id"] != null) 
                    {
                        complementIDRef_ = complementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(complementNode);
                        IDManager.SetID(complementIDRef_, ob);
                    }
                    else if (complementNode.Attributes["href"] != null)
                    {
                        complementIDRef_ = complementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        complement_ = new XsdTypeBoolean(complementNode);
                    }
                }
                else
                {
                    complement_ = new XsdTypeBoolean(complementNode);
                }
            }
            
        
        }
        
    
        #region EventCalculationList_
        private EventCalculationList eventCalculationList_;
        public EventCalculationList EventCalculationList_
        {
            get
            {
                if (this.eventCalculationList_ != null)
                {
                    return this.eventCalculationList_; 
                }
                else if (this.eventCalculationListIDRef_ != null)
                {
                    eventCalculationList_ = IDManager.getID(eventCalculationListIDRef_) as EventCalculationList;
                    return this.eventCalculationList_; 
                }
                else
                {
                    throw new Exception( "eventCalculationList_Node no exist!");
                }
            }
            set
            {
                if (this.eventCalculationList_ != value)
                {
                    this.eventCalculationList_ = value;
                }
            }
        }
        #endregion
        
        public string eventCalculationListIDRef_ { get; set; }
        #region Complement_
        private XsdTypeBoolean complement_;
        public XsdTypeBoolean Complement_
        {
            get
            {
                if (this.complement_ != null)
                {
                    return this.complement_; 
                }
                else if (this.complementIDRef_ != null)
                {
                    complement_ = IDManager.getID(complementIDRef_) as XsdTypeBoolean;
                    return this.complement_; 
                }
                else
                {
                    throw new Exception( "complement_Node no exist!");
                }
            }
            set
            {
                if (this.complement_ != value)
                {
                    this.complement_ = value;
                }
            }
        }
        #endregion
        
        public string complementIDRef_ { get; set; }
        
    
        
    
    }
    
}

