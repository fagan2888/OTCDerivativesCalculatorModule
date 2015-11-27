using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedCouponSchedule : ISerialized
    {
        public Excel_fixedCouponSchedule() { }
        public Excel_fixedCouponSchedule(XmlNode xmlNode)
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
            
        
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNode calculationStartDateNode = xmlNode.SelectSingleNode("calculationStartDate");
            
            if (calculationStartDateNode != null)
            {
                if (calculationStartDateNode.Attributes["href"] != null || calculationStartDateNode.Attributes["id"] != null) 
                {
                    if (calculationStartDateNode.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new XsdTypeToken(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new XsdTypeToken(calculationStartDateNode);
                }
            }
            
        
            XmlNode calculationEndDateNode = xmlNode.SelectSingleNode("calculationEndDate");
            
            if (calculationEndDateNode != null)
            {
                if (calculationEndDateNode.Attributes["href"] != null || calculationEndDateNode.Attributes["id"] != null) 
                {
                    if (calculationEndDateNode.Attributes["id"] != null) 
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new XsdTypeToken(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new XsdTypeToken(calculationEndDateNode);
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeToken(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeToken(descriptionNode);
                }
            }
            
        
            XmlNode vba_descriptionNode = xmlNode.SelectSingleNode("vba_description");
            
            if (vba_descriptionNode != null)
            {
                if (vba_descriptionNode.Attributes["href"] != null || vba_descriptionNode.Attributes["id"] != null) 
                {
                    if (vba_descriptionNode.Attributes["id"] != null) 
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(vba_descriptionNode);
                        IDManager.SetID(vba_descriptionIDRef_, ob);
                    }
                    else if (vba_descriptionNode.Attributes["href"] != null)
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vba_description_ = new XsdTypeToken(vba_descriptionNode);
                    }
                }
                else
                {
                    vba_description_ = new XsdTypeToken(vba_descriptionNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeToken(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeToken(fixedRateNode);
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
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                    throw new Exception( "payoffDate_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region CalculationStartDate_
        private XsdTypeToken calculationStartDate_;
        public XsdTypeToken CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as XsdTypeToken;
                    return this.calculationStartDate_; 
                }
                else
                {
                    throw new Exception( "calculationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationStartDateIDRef_ { get; set; }
        #region CalculationEndDate_
        private XsdTypeToken calculationEndDate_;
        public XsdTypeToken CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as XsdTypeToken;
                    return this.calculationEndDate_; 
                }
                else
                {
                    throw new Exception( "calculationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationEndDateIDRef_ { get; set; }
        #region Description_
        private XsdTypeToken description_;
        public XsdTypeToken Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeToken;
                    return this.description_; 
                }
                else
                {
                    throw new Exception( "description_Node no exist!");
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        #region Vba_description_
        private XsdTypeToken vba_description_;
        public XsdTypeToken Vba_description_
        {
            get
            {
                if (this.vba_description_ != null)
                {
                    return this.vba_description_; 
                }
                else if (this.vba_descriptionIDRef_ != null)
                {
                    vba_description_ = IDManager.getID(vba_descriptionIDRef_) as XsdTypeToken;
                    return this.vba_description_; 
                }
                else
                {
                    throw new Exception( "vba_description_Node no exist!");
                }
            }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                }
            }
        }
        #endregion
        
        public string vba_descriptionIDRef_ { get; set; }
        #region FixedRate_
        private XsdTypeToken fixedRate_;
        public XsdTypeToken FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeToken;
                    return this.fixedRate_; 
                }
                else
                {
                    throw new Exception( "fixedRate_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

