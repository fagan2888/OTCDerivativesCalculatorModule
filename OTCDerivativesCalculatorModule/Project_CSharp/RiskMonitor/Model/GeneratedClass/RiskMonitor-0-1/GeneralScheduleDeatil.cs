using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralScheduleDeatil : ISerialized
    {
        public GeneralScheduleDeatil() { }
        public GeneralScheduleDeatil(XmlNode xmlNode)
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
            
        
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode general_scheduleDetail_fixedCouponNode = xmlNode.SelectSingleNode("general_scheduleDetail_fixedCoupon");
            
            if (general_scheduleDetail_fixedCouponNode != null)
            {
                if (general_scheduleDetail_fixedCouponNode.Attributes["href"] != null || general_scheduleDetail_fixedCouponNode.Attributes["id"] != null) 
                {
                    if (general_scheduleDetail_fixedCouponNode.Attributes["id"] != null) 
                    {
                        general_scheduleDetail_fixedCouponIDRef_ = general_scheduleDetail_fixedCouponNode.Attributes["id"].Value;
                        General_scheduleDetail_fixedCoupon ob = new General_scheduleDetail_fixedCoupon(general_scheduleDetail_fixedCouponNode);
                        IDManager.SetID(general_scheduleDetail_fixedCouponIDRef_, ob);
                    }
                    else if (general_scheduleDetail_fixedCouponNode.Attributes["href"] != null)
                    {
                        general_scheduleDetail_fixedCouponIDRef_ = general_scheduleDetail_fixedCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        general_scheduleDetail_fixedCoupon_ = new General_scheduleDetail_fixedCoupon(general_scheduleDetail_fixedCouponNode);
                    }
                }
                else
                {
                    general_scheduleDetail_fixedCoupon_ = new General_scheduleDetail_fixedCoupon(general_scheduleDetail_fixedCouponNode);
                }
            }
            
        
            XmlNode general_scheduleDetail_fixedAmountNode = xmlNode.SelectSingleNode("general_scheduleDetail_fixedAmount");
            
            if (general_scheduleDetail_fixedAmountNode != null)
            {
                if (general_scheduleDetail_fixedAmountNode.Attributes["href"] != null || general_scheduleDetail_fixedAmountNode.Attributes["id"] != null) 
                {
                    if (general_scheduleDetail_fixedAmountNode.Attributes["id"] != null) 
                    {
                        general_scheduleDetail_fixedAmountIDRef_ = general_scheduleDetail_fixedAmountNode.Attributes["id"].Value;
                        General_scheduleDetail_fixedAmount ob = new General_scheduleDetail_fixedAmount(general_scheduleDetail_fixedAmountNode);
                        IDManager.SetID(general_scheduleDetail_fixedAmountIDRef_, ob);
                    }
                    else if (general_scheduleDetail_fixedAmountNode.Attributes["href"] != null)
                    {
                        general_scheduleDetail_fixedAmountIDRef_ = general_scheduleDetail_fixedAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        general_scheduleDetail_fixedAmount_ = new General_scheduleDetail_fixedAmount(general_scheduleDetail_fixedAmountNode);
                    }
                }
                else
                {
                    general_scheduleDetail_fixedAmount_ = new General_scheduleDetail_fixedAmount(general_scheduleDetail_fixedAmountNode);
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
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region General_scheduleDetail_fixedCoupon_
        private General_scheduleDetail_fixedCoupon general_scheduleDetail_fixedCoupon_;
        public General_scheduleDetail_fixedCoupon General_scheduleDetail_fixedCoupon_
        {
            get
            {
                if (this.general_scheduleDetail_fixedCoupon_ != null)
                {
                    return this.general_scheduleDetail_fixedCoupon_; 
                }
                else if (this.general_scheduleDetail_fixedCouponIDRef_ != null)
                {
                    general_scheduleDetail_fixedCoupon_ = IDManager.getID(general_scheduleDetail_fixedCouponIDRef_) as General_scheduleDetail_fixedCoupon;
                    return this.general_scheduleDetail_fixedCoupon_; 
                }
                else
                {
                    throw new Exception( "general_scheduleDetail_fixedCoupon_Node no exist!");
                }
            }
            set
            {
                if (this.general_scheduleDetail_fixedCoupon_ != value)
                {
                    this.general_scheduleDetail_fixedCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string general_scheduleDetail_fixedCouponIDRef_ { get; set; }
        #region General_scheduleDetail_fixedAmount_
        private General_scheduleDetail_fixedAmount general_scheduleDetail_fixedAmount_;
        public General_scheduleDetail_fixedAmount General_scheduleDetail_fixedAmount_
        {
            get
            {
                if (this.general_scheduleDetail_fixedAmount_ != null)
                {
                    return this.general_scheduleDetail_fixedAmount_; 
                }
                else if (this.general_scheduleDetail_fixedAmountIDRef_ != null)
                {
                    general_scheduleDetail_fixedAmount_ = IDManager.getID(general_scheduleDetail_fixedAmountIDRef_) as General_scheduleDetail_fixedAmount;
                    return this.general_scheduleDetail_fixedAmount_; 
                }
                else
                {
                    throw new Exception( "general_scheduleDetail_fixedAmount_Node no exist!");
                }
            }
            set
            {
                if (this.general_scheduleDetail_fixedAmount_ != value)
                {
                    this.general_scheduleDetail_fixedAmount_ = value;
                }
            }
        }
        #endregion
        
        public string general_scheduleDetail_fixedAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

