using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingCouponSchedule : ISerialized
    {
        public Excel_vanillaFloatingCouponSchedule() { }
        public Excel_vanillaFloatingCouponSchedule(XmlNode xmlNode)
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
            
        
            XmlNode gearingNode = xmlNode.SelectSingleNode("gearing");
            
            if (gearingNode != null)
            {
                if (gearingNode.Attributes["href"] != null || gearingNode.Attributes["id"] != null) 
                {
                    if (gearingNode.Attributes["id"] != null) 
                    {
                        gearingIDRef_ = gearingNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeToken(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeToken(gearingNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeToken(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeToken(spreadNode);
                }
            }
            
        
            XmlNode outGearingNode = xmlNode.SelectSingleNode("outGearing");
            
            if (outGearingNode != null)
            {
                if (outGearingNode.Attributes["href"] != null || outGearingNode.Attributes["id"] != null) 
                {
                    if (outGearingNode.Attributes["id"] != null) 
                    {
                        outGearingIDRef_ = outGearingNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(outGearingNode);
                        IDManager.SetID(outGearingIDRef_, ob);
                    }
                    else if (outGearingNode.Attributes["href"] != null)
                    {
                        outGearingIDRef_ = outGearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outGearing_ = new XsdTypeToken(outGearingNode);
                    }
                }
                else
                {
                    outGearing_ = new XsdTypeToken(outGearingNode);
                }
            }
            
        
            XmlNode outSpreadNode = xmlNode.SelectSingleNode("outSpread");
            
            if (outSpreadNode != null)
            {
                if (outSpreadNode.Attributes["href"] != null || outSpreadNode.Attributes["id"] != null) 
                {
                    if (outSpreadNode.Attributes["id"] != null) 
                    {
                        outSpreadIDRef_ = outSpreadNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(outSpreadNode);
                        IDManager.SetID(outSpreadIDRef_, ob);
                    }
                    else if (outSpreadNode.Attributes["href"] != null)
                    {
                        outSpreadIDRef_ = outSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outSpread_ = new XsdTypeToken(outSpreadNode);
                    }
                }
                else
                {
                    outSpread_ = new XsdTypeToken(outSpreadNode);
                }
            }
            
        
            XmlNode capNode = xmlNode.SelectSingleNode("cap");
            
            if (capNode != null)
            {
                if (capNode.Attributes["href"] != null || capNode.Attributes["id"] != null) 
                {
                    if (capNode.Attributes["id"] != null) 
                    {
                        capIDRef_ = capNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(capNode);
                        IDManager.SetID(capIDRef_, ob);
                    }
                    else if (capNode.Attributes["href"] != null)
                    {
                        capIDRef_ = capNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cap_ = new XsdTypeToken(capNode);
                    }
                }
                else
                {
                    cap_ = new XsdTypeToken(capNode);
                }
            }
            
        
            XmlNode floorNode = xmlNode.SelectSingleNode("floor");
            
            if (floorNode != null)
            {
                if (floorNode.Attributes["href"] != null || floorNode.Attributes["id"] != null) 
                {
                    if (floorNode.Attributes["id"] != null) 
                    {
                        floorIDRef_ = floorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(floorNode);
                        IDManager.SetID(floorIDRef_, ob);
                    }
                    else if (floorNode.Attributes["href"] != null)
                    {
                        floorIDRef_ = floorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floor_ = new XsdTypeToken(floorNode);
                    }
                }
                else
                {
                    floor_ = new XsdTypeToken(floorNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcIDNode = xmlNode.SelectSingleNode("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNode != null)
            {
                if (excel_underlyingCalcIDNode.Attributes["href"] != null || excel_underlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["id"].Value;
                        Excel_underlyingCalcID ob = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                        IDManager.SetID(excel_underlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_underlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
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
        #region Gearing_
        private XsdTypeToken gearing_;
        public XsdTypeToken Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeToken;
                    return this.gearing_; 
                }
                else
                {
                    throw new Exception( "gearing_Node no exist!");
                }
            }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                }
            }
        }
        #endregion
        
        public string gearingIDRef_ { get; set; }
        #region Spread_
        private XsdTypeToken spread_;
        public XsdTypeToken Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeToken;
                    return this.spread_; 
                }
                else
                {
                    throw new Exception( "spread_Node no exist!");
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region OutGearing_
        private XsdTypeToken outGearing_;
        public XsdTypeToken OutGearing_
        {
            get
            {
                if (this.outGearing_ != null)
                {
                    return this.outGearing_; 
                }
                else if (this.outGearingIDRef_ != null)
                {
                    outGearing_ = IDManager.getID(outGearingIDRef_) as XsdTypeToken;
                    return this.outGearing_; 
                }
                else
                {
                    throw new Exception( "outGearing_Node no exist!");
                }
            }
            set
            {
                if (this.outGearing_ != value)
                {
                    this.outGearing_ = value;
                }
            }
        }
        #endregion
        
        public string outGearingIDRef_ { get; set; }
        #region OutSpread_
        private XsdTypeToken outSpread_;
        public XsdTypeToken OutSpread_
        {
            get
            {
                if (this.outSpread_ != null)
                {
                    return this.outSpread_; 
                }
                else if (this.outSpreadIDRef_ != null)
                {
                    outSpread_ = IDManager.getID(outSpreadIDRef_) as XsdTypeToken;
                    return this.outSpread_; 
                }
                else
                {
                    throw new Exception( "outSpread_Node no exist!");
                }
            }
            set
            {
                if (this.outSpread_ != value)
                {
                    this.outSpread_ = value;
                }
            }
        }
        #endregion
        
        public string outSpreadIDRef_ { get; set; }
        #region Cap_
        private XsdTypeToken cap_;
        public XsdTypeToken Cap_
        {
            get
            {
                if (this.cap_ != null)
                {
                    return this.cap_; 
                }
                else if (this.capIDRef_ != null)
                {
                    cap_ = IDManager.getID(capIDRef_) as XsdTypeToken;
                    return this.cap_; 
                }
                else
                {
                    throw new Exception( "cap_Node no exist!");
                }
            }
            set
            {
                if (this.cap_ != value)
                {
                    this.cap_ = value;
                }
            }
        }
        #endregion
        
        public string capIDRef_ { get; set; }
        #region Floor_
        private XsdTypeToken floor_;
        public XsdTypeToken Floor_
        {
            get
            {
                if (this.floor_ != null)
                {
                    return this.floor_; 
                }
                else if (this.floorIDRef_ != null)
                {
                    floor_ = IDManager.getID(floorIDRef_) as XsdTypeToken;
                    return this.floor_; 
                }
                else
                {
                    throw new Exception( "floor_Node no exist!");
                }
            }
            set
            {
                if (this.floor_ != value)
                {
                    this.floor_ = value;
                }
            }
        }
        #endregion
        
        public string floorIDRef_ { get; set; }
        #region Excel_underlyingCalcID_
        private Excel_underlyingCalcID excel_underlyingCalcID_;
        public Excel_underlyingCalcID Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
                    excel_underlyingCalcID_ = IDManager.getID(excel_underlyingCalcIDIDRef_) as Excel_underlyingCalcID;
                    return this.excel_underlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcID_ != value)
                {
                    this.excel_underlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcIDIDRef_ { get; set; }
        
    
        
    
    }
    
}

