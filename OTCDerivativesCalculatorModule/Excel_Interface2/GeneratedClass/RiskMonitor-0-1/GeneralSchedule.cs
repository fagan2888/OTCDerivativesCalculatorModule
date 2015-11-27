using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralSchedule : ISerialized
    {
        public GeneralSchedule() { }
        public GeneralSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode detailScheduleTypeNode = xmlNode.SelectSingleNode("detailScheduleType");
            
            if (detailScheduleTypeNode != null)
            {
                if (detailScheduleTypeNode.Attributes["href"] != null || detailScheduleTypeNode.Attributes["id"] != null) 
                {
                    if (detailScheduleTypeNode.Attributes["id"] != null) 
                    {
                        detailScheduleTypeIDRef_ = detailScheduleTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(detailScheduleTypeNode);
                        IDManager.SetID(detailScheduleTypeIDRef_, ob);
                    }
                    else if (detailScheduleTypeNode.Attributes["href"] != null)
                    {
                        detailScheduleTypeIDRef_ = detailScheduleTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        detailScheduleType_ = new XsdTypeToken(detailScheduleTypeNode);
                    }
                }
                else
                {
                    detailScheduleType_ = new XsdTypeToken(detailScheduleTypeNode);
                }
            }
            
        
            XmlNode generalScheduleDeatilNode = xmlNode.SelectSingleNode("generalScheduleDeatil");
            
            if (generalScheduleDeatilNode != null)
            {
                if (generalScheduleDeatilNode.Attributes["href"] != null || generalScheduleDeatilNode.Attributes["id"] != null) 
                {
                    if (generalScheduleDeatilNode.Attributes["id"] != null) 
                    {
                        generalScheduleDeatilIDRef_ = generalScheduleDeatilNode.Attributes["id"].Value;
                        GeneralScheduleDeatil ob = new GeneralScheduleDeatil(generalScheduleDeatilNode);
                        IDManager.SetID(generalScheduleDeatilIDRef_, ob);
                    }
                    else if (generalScheduleDeatilNode.Attributes["href"] != null)
                    {
                        generalScheduleDeatilIDRef_ = generalScheduleDeatilNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generalScheduleDeatil_ = new GeneralScheduleDeatil(generalScheduleDeatilNode);
                    }
                }
                else
                {
                    generalScheduleDeatil_ = new GeneralScheduleDeatil(generalScheduleDeatilNode);
                }
            }
            
        
        }
        
    
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
        #region DetailScheduleType_
        private XsdTypeToken detailScheduleType_;
        public XsdTypeToken DetailScheduleType_
        {
            get
            {
                if (this.detailScheduleType_ != null)
                {
                    return this.detailScheduleType_; 
                }
                else if (this.detailScheduleTypeIDRef_ != null)
                {
                    detailScheduleType_ = IDManager.getID(detailScheduleTypeIDRef_) as XsdTypeToken;
                    return this.detailScheduleType_; 
                }
                else
                {
                    throw new Exception( "detailScheduleType_Node no exist!");
                }
            }
            set
            {
                if (this.detailScheduleType_ != value)
                {
                    this.detailScheduleType_ = value;
                }
            }
        }
        #endregion
        
        public string detailScheduleTypeIDRef_ { get; set; }
        #region GeneralScheduleDeatil_
        private GeneralScheduleDeatil generalScheduleDeatil_;
        public GeneralScheduleDeatil GeneralScheduleDeatil_
        {
            get
            {
                if (this.generalScheduleDeatil_ != null)
                {
                    return this.generalScheduleDeatil_; 
                }
                else if (this.generalScheduleDeatilIDRef_ != null)
                {
                    generalScheduleDeatil_ = IDManager.getID(generalScheduleDeatilIDRef_) as GeneralScheduleDeatil;
                    return this.generalScheduleDeatil_; 
                }
                else
                {
                    throw new Exception( "generalScheduleDeatil_Node no exist!");
                }
            }
            set
            {
                if (this.generalScheduleDeatil_ != value)
                {
                    this.generalScheduleDeatil_ = value;
                }
            }
        }
        #endregion
        
        public string generalScheduleDeatilIDRef_ { get; set; }
        
    
        
    
    }
    
}

