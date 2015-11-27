using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralTerminationEvent : ISerialized
    {
        public GeneralTerminationEvent() { }
        public GeneralTerminationEvent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode detailTerminationTypeNode = xmlNode.SelectSingleNode("detailTerminationType");
            
            if (detailTerminationTypeNode != null)
            {
                if (detailTerminationTypeNode.Attributes["href"] != null || detailTerminationTypeNode.Attributes["id"] != null) 
                {
                    if (detailTerminationTypeNode.Attributes["id"] != null) 
                    {
                        detailTerminationTypeIDRef_ = detailTerminationTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(detailTerminationTypeNode);
                        IDManager.SetID(detailTerminationTypeIDRef_, ob);
                    }
                    else if (detailTerminationTypeNode.Attributes["href"] != null)
                    {
                        detailTerminationTypeIDRef_ = detailTerminationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        detailTerminationType_ = new XsdTypeToken(detailTerminationTypeNode);
                    }
                }
                else
                {
                    detailTerminationType_ = new XsdTypeToken(detailTerminationTypeNode);
                }
            }
            
        
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeToken(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeToken(eventDateNode);
                }
            }
            
        
            XmlNode generalTerminationEventDetailNode = xmlNode.SelectSingleNode("generalTerminationEventDetail");
            
            if (generalTerminationEventDetailNode != null)
            {
                if (generalTerminationEventDetailNode.Attributes["href"] != null || generalTerminationEventDetailNode.Attributes["id"] != null) 
                {
                    if (generalTerminationEventDetailNode.Attributes["id"] != null) 
                    {
                        generalTerminationEventDetailIDRef_ = generalTerminationEventDetailNode.Attributes["id"].Value;
                        GeneralTerminationEventDetail ob = new GeneralTerminationEventDetail(generalTerminationEventDetailNode);
                        IDManager.SetID(generalTerminationEventDetailIDRef_, ob);
                    }
                    else if (generalTerminationEventDetailNode.Attributes["href"] != null)
                    {
                        generalTerminationEventDetailIDRef_ = generalTerminationEventDetailNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generalTerminationEventDetail_ = new GeneralTerminationEventDetail(generalTerminationEventDetailNode);
                    }
                }
                else
                {
                    generalTerminationEventDetail_ = new GeneralTerminationEventDetail(generalTerminationEventDetailNode);
                }
            }
            
        
        }
        
    
        #region DetailTerminationType_
        private XsdTypeToken detailTerminationType_;
        public XsdTypeToken DetailTerminationType_
        {
            get
            {
                if (this.detailTerminationType_ != null)
                {
                    return this.detailTerminationType_; 
                }
                else if (this.detailTerminationTypeIDRef_ != null)
                {
                    detailTerminationType_ = IDManager.getID(detailTerminationTypeIDRef_) as XsdTypeToken;
                    return this.detailTerminationType_; 
                }
                else
                {
                    throw new Exception( "detailTerminationType_Node no exist!");
                }
            }
            set
            {
                if (this.detailTerminationType_ != value)
                {
                    this.detailTerminationType_ = value;
                }
            }
        }
        #endregion
        
        public string detailTerminationTypeIDRef_ { get; set; }
        #region EventDate_
        private XsdTypeToken eventDate_;
        public XsdTypeToken EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeToken;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region GeneralTerminationEventDetail_
        private GeneralTerminationEventDetail generalTerminationEventDetail_;
        public GeneralTerminationEventDetail GeneralTerminationEventDetail_
        {
            get
            {
                if (this.generalTerminationEventDetail_ != null)
                {
                    return this.generalTerminationEventDetail_; 
                }
                else if (this.generalTerminationEventDetailIDRef_ != null)
                {
                    generalTerminationEventDetail_ = IDManager.getID(generalTerminationEventDetailIDRef_) as GeneralTerminationEventDetail;
                    return this.generalTerminationEventDetail_; 
                }
                else
                {
                    throw new Exception( "generalTerminationEventDetail_Node no exist!");
                }
            }
            set
            {
                if (this.generalTerminationEventDetail_ != value)
                {
                    this.generalTerminationEventDetail_ = value;
                }
            }
        }
        #endregion
        
        public string generalTerminationEventDetailIDRef_ { get; set; }
        
    
        
    
    }
    
}

