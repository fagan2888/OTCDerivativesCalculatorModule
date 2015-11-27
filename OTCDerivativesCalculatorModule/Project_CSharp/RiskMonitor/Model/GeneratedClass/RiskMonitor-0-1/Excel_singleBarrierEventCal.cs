using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_singleBarrierEventCal : ISerialized
    {
        public Excel_singleBarrierEventCal() { }
        public Excel_singleBarrierEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode lowerTriggerNode = xmlNode.SelectSingleNode("lowerTrigger");
            
            if (lowerTriggerNode != null)
            {
                if (lowerTriggerNode.Attributes["href"] != null || lowerTriggerNode.Attributes["id"] != null) 
                {
                    if (lowerTriggerNode.Attributes["id"] != null) 
                    {
                        lowerTriggerIDRef_ = lowerTriggerNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(lowerTriggerNode);
                        IDManager.SetID(lowerTriggerIDRef_, ob);
                    }
                    else if (lowerTriggerNode.Attributes["href"] != null)
                    {
                        lowerTriggerIDRef_ = lowerTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerTrigger_ = new XsdTypeToken(lowerTriggerNode);
                    }
                }
                else
                {
                    lowerTrigger_ = new XsdTypeToken(lowerTriggerNode);
                }
            }
            
        
            XmlNode upperTriggerNode = xmlNode.SelectSingleNode("upperTrigger");
            
            if (upperTriggerNode != null)
            {
                if (upperTriggerNode.Attributes["href"] != null || upperTriggerNode.Attributes["id"] != null) 
                {
                    if (upperTriggerNode.Attributes["id"] != null) 
                    {
                        upperTriggerIDRef_ = upperTriggerNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(upperTriggerNode);
                        IDManager.SetID(upperTriggerIDRef_, ob);
                    }
                    else if (upperTriggerNode.Attributes["href"] != null)
                    {
                        upperTriggerIDRef_ = upperTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperTrigger_ = new XsdTypeToken(upperTriggerNode);
                    }
                }
                else
                {
                    upperTrigger_ = new XsdTypeToken(upperTriggerNode);
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
            
        
            XmlNode observationStartDateNode = xmlNode.SelectSingleNode("observationStartDate");
            
            if (observationStartDateNode != null)
            {
                if (observationStartDateNode.Attributes["href"] != null || observationStartDateNode.Attributes["id"] != null) 
                {
                    if (observationStartDateNode.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(observationStartDateNode);
                        IDManager.SetID(observationStartDateIDRef_, ob);
                    }
                    else if (observationStartDateNode.Attributes["href"] != null)
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationStartDate_ = new XsdTypeToken(observationStartDateNode);
                    }
                }
                else
                {
                    observationStartDate_ = new XsdTypeToken(observationStartDateNode);
                }
            }
            
        
            XmlNode observationEndDateNode = xmlNode.SelectSingleNode("observationEndDate");
            
            if (observationEndDateNode != null)
            {
                if (observationEndDateNode.Attributes["href"] != null || observationEndDateNode.Attributes["id"] != null) 
                {
                    if (observationEndDateNode.Attributes["id"] != null) 
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(observationEndDateNode);
                        IDManager.SetID(observationEndDateIDRef_, ob);
                    }
                    else if (observationEndDateNode.Attributes["href"] != null)
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationEndDate_ = new XsdTypeToken(observationEndDateNode);
                    }
                }
                else
                {
                    observationEndDate_ = new XsdTypeToken(observationEndDateNode);
                }
            }
            
        
        }
        
    
        #region LowerTrigger_
        private XsdTypeToken lowerTrigger_;
        public XsdTypeToken LowerTrigger_
        {
            get
            {
                if (this.lowerTrigger_ != null)
                {
                    return this.lowerTrigger_; 
                }
                else if (this.lowerTriggerIDRef_ != null)
                {
                    lowerTrigger_ = IDManager.getID(lowerTriggerIDRef_) as XsdTypeToken;
                    return this.lowerTrigger_; 
                }
                else
                {
                    throw new Exception( "lowerTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string lowerTriggerIDRef_ { get; set; }
        #region UpperTrigger_
        private XsdTypeToken upperTrigger_;
        public XsdTypeToken UpperTrigger_
        {
            get
            {
                if (this.upperTrigger_ != null)
                {
                    return this.upperTrigger_; 
                }
                else if (this.upperTriggerIDRef_ != null)
                {
                    upperTrigger_ = IDManager.getID(upperTriggerIDRef_) as XsdTypeToken;
                    return this.upperTrigger_; 
                }
                else
                {
                    throw new Exception( "upperTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string upperTriggerIDRef_ { get; set; }
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
        #region ObservationStartDate_
        private XsdTypeToken observationStartDate_;
        public XsdTypeToken ObservationStartDate_
        {
            get
            {
                if (this.observationStartDate_ != null)
                {
                    return this.observationStartDate_; 
                }
                else if (this.observationStartDateIDRef_ != null)
                {
                    observationStartDate_ = IDManager.getID(observationStartDateIDRef_) as XsdTypeToken;
                    return this.observationStartDate_; 
                }
                else
                {
                    throw new Exception( "observationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationStartDateIDRef_ { get; set; }
        #region ObservationEndDate_
        private XsdTypeToken observationEndDate_;
        public XsdTypeToken ObservationEndDate_
        {
            get
            {
                if (this.observationEndDate_ != null)
                {
                    return this.observationEndDate_; 
                }
                else if (this.observationEndDateIDRef_ != null)
                {
                    observationEndDate_ = IDManager.getID(observationEndDateIDRef_) as XsdTypeToken;
                    return this.observationEndDate_; 
                }
                else
                {
                    throw new Exception( "observationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationEndDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

