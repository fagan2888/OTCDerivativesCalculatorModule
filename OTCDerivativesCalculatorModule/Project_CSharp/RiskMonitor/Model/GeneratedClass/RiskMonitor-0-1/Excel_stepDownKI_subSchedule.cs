using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_stepDownKI_subSchedule : ISerialized
    {
        public Excel_stepDownKI_subSchedule() { }
        public Excel_stepDownKI_subSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_typeNode = xmlNode.SelectSingleNode("excel_type");
            
            if (excel_typeNode != null)
            {
                if (excel_typeNode.Attributes["href"] != null || excel_typeNode.Attributes["id"] != null) 
                {
                    if (excel_typeNode.Attributes["id"] != null) 
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(excel_typeNode);
                        IDManager.SetID(excel_typeIDRef_, ob);
                    }
                    else if (excel_typeNode.Attributes["href"] != null)
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_type_ = new XsdTypeToken(excel_typeNode);
                    }
                }
                else
                {
                    excel_type_ = new XsdTypeToken(excel_typeNode);
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
            
        
            XmlNode triggerNode = xmlNode.SelectSingleNode("trigger");
            
            if (triggerNode != null)
            {
                if (triggerNode.Attributes["href"] != null || triggerNode.Attributes["id"] != null) 
                {
                    if (triggerNode.Attributes["id"] != null) 
                    {
                        triggerIDRef_ = triggerNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(triggerNode);
                        IDManager.SetID(triggerIDRef_, ob);
                    }
                    else if (triggerNode.Attributes["href"] != null)
                    {
                        triggerIDRef_ = triggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trigger_ = new XsdTypeToken(triggerNode);
                    }
                }
                else
                {
                    trigger_ = new XsdTypeToken(triggerNode);
                }
            }
            
        
            XmlNode couponNode = xmlNode.SelectSingleNode("coupon");
            
            if (couponNode != null)
            {
                if (couponNode.Attributes["href"] != null || couponNode.Attributes["id"] != null) 
                {
                    if (couponNode.Attributes["id"] != null) 
                    {
                        couponIDRef_ = couponNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(couponNode);
                        IDManager.SetID(couponIDRef_, ob);
                    }
                    else if (couponNode.Attributes["href"] != null)
                    {
                        couponIDRef_ = couponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coupon_ = new XsdTypeToken(couponNode);
                    }
                }
                else
                {
                    coupon_ = new XsdTypeToken(couponNode);
                }
            }
            
        
            XmlNode averageDaysNode = xmlNode.SelectSingleNode("averageDays");
            
            if (averageDaysNode != null)
            {
                if (averageDaysNode.Attributes["href"] != null || averageDaysNode.Attributes["id"] != null) 
                {
                    if (averageDaysNode.Attributes["id"] != null) 
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(averageDaysNode);
                        IDManager.SetID(averageDaysIDRef_, ob);
                    }
                    else if (averageDaysNode.Attributes["href"] != null)
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averageDays_ = new XsdTypeToken(averageDaysNode);
                    }
                }
                else
                {
                    averageDays_ = new XsdTypeToken(averageDaysNode);
                }
            }
            
        
            XmlNode underCalcTypeNode = xmlNode.SelectSingleNode("underCalcType");
            
            if (underCalcTypeNode != null)
            {
                if (underCalcTypeNode.Attributes["href"] != null || underCalcTypeNode.Attributes["id"] != null) 
                {
                    if (underCalcTypeNode.Attributes["id"] != null) 
                    {
                        underCalcTypeIDRef_ = underCalcTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underCalcTypeNode);
                        IDManager.SetID(underCalcTypeIDRef_, ob);
                    }
                    else if (underCalcTypeNode.Attributes["href"] != null)
                    {
                        underCalcTypeIDRef_ = underCalcTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underCalcType_ = new XsdTypeToken(underCalcTypeNode);
                    }
                }
                else
                {
                    underCalcType_ = new XsdTypeToken(underCalcTypeNode);
                }
            }
            
        
        }
        
    
        #region Excel_type_
        private XsdTypeToken excel_type_;
        public XsdTypeToken Excel_type_
        {
            get
            {
                if (this.excel_type_ != null)
                {
                    return this.excel_type_; 
                }
                else if (this.excel_typeIDRef_ != null)
                {
                    excel_type_ = IDManager.getID(excel_typeIDRef_) as XsdTypeToken;
                    return this.excel_type_; 
                }
                else
                {
                    throw new Exception( "excel_type_Node no exist!");
                }
            }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                }
            }
        }
        #endregion
        
        public string excel_typeIDRef_ { get; set; }
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
        #region Trigger_
        private XsdTypeToken trigger_;
        public XsdTypeToken Trigger_
        {
            get
            {
                if (this.trigger_ != null)
                {
                    return this.trigger_; 
                }
                else if (this.triggerIDRef_ != null)
                {
                    trigger_ = IDManager.getID(triggerIDRef_) as XsdTypeToken;
                    return this.trigger_; 
                }
                else
                {
                    throw new Exception( "trigger_Node no exist!");
                }
            }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                }
            }
        }
        #endregion
        
        public string triggerIDRef_ { get; set; }
        #region Coupon_
        private XsdTypeToken coupon_;
        public XsdTypeToken Coupon_
        {
            get
            {
                if (this.coupon_ != null)
                {
                    return this.coupon_; 
                }
                else if (this.couponIDRef_ != null)
                {
                    coupon_ = IDManager.getID(couponIDRef_) as XsdTypeToken;
                    return this.coupon_; 
                }
                else
                {
                    throw new Exception( "coupon_Node no exist!");
                }
            }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                }
            }
        }
        #endregion
        
        public string couponIDRef_ { get; set; }
        #region AverageDays_
        private XsdTypeToken averageDays_;
        public XsdTypeToken AverageDays_
        {
            get
            {
                if (this.averageDays_ != null)
                {
                    return this.averageDays_; 
                }
                else if (this.averageDaysIDRef_ != null)
                {
                    averageDays_ = IDManager.getID(averageDaysIDRef_) as XsdTypeToken;
                    return this.averageDays_; 
                }
                else
                {
                    throw new Exception( "averageDays_Node no exist!");
                }
            }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                }
            }
        }
        #endregion
        
        public string averageDaysIDRef_ { get; set; }
        #region UnderCalcType_
        private XsdTypeToken underCalcType_;
        public XsdTypeToken UnderCalcType_
        {
            get
            {
                if (this.underCalcType_ != null)
                {
                    return this.underCalcType_; 
                }
                else if (this.underCalcTypeIDRef_ != null)
                {
                    underCalcType_ = IDManager.getID(underCalcTypeIDRef_) as XsdTypeToken;
                    return this.underCalcType_; 
                }
                else
                {
                    throw new Exception( "underCalcType_Node no exist!");
                }
            }
            set
            {
                if (this.underCalcType_ != value)
                {
                    this.underCalcType_ = value;
                }
            }
        }
        #endregion
        
        public string underCalcTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

