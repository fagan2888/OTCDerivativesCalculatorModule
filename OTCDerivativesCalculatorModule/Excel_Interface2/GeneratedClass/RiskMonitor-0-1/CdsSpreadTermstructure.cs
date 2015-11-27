using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CdsSpreadTermstructure : ISerialized
    {
        public CdsSpreadTermstructure() { }
        public CdsSpreadTermstructure(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode interpolationNode = xmlNode.SelectSingleNode("interpolation");
            
            if (interpolationNode != null)
            {
                if (interpolationNode.Attributes["href"] != null || interpolationNode.Attributes["id"] != null) 
                {
                    if (interpolationNode.Attributes["id"] != null) 
                    {
                        interpolationIDRef_ = interpolationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(interpolationNode);
                        IDManager.SetID(interpolationIDRef_, ob);
                    }
                    else if (interpolationNode.Attributes["href"] != null)
                    {
                        interpolationIDRef_ = interpolationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interpolation_ = new XsdTypeToken(interpolationNode);
                    }
                }
                else
                {
                    interpolation_ = new XsdTypeToken(interpolationNode);
                }
            }
            
        
            XmlNode daycounterNode = xmlNode.SelectSingleNode("daycounter");
            
            if (daycounterNode != null)
            {
                if (daycounterNode.Attributes["href"] != null || daycounterNode.Attributes["id"] != null) 
                {
                    if (daycounterNode.Attributes["id"] != null) 
                    {
                        daycounterIDRef_ = daycounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(daycounterNode);
                        IDManager.SetID(daycounterIDRef_, ob);
                    }
                    else if (daycounterNode.Attributes["href"] != null)
                    {
                        daycounterIDRef_ = daycounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        daycounter_ = new XsdTypeToken(daycounterNode);
                    }
                }
                else
                {
                    daycounter_ = new XsdTypeToken(daycounterNode);
                }
            }
            
        
            XmlNode calendarNode = xmlNode.SelectSingleNode("calendar");
            
            if (calendarNode != null)
            {
                if (calendarNode.Attributes["href"] != null || calendarNode.Attributes["id"] != null) 
                {
                    if (calendarNode.Attributes["id"] != null) 
                    {
                        calendarIDRef_ = calendarNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calendarNode);
                        IDManager.SetID(calendarIDRef_, ob);
                    }
                    else if (calendarNode.Attributes["href"] != null)
                    {
                        calendarIDRef_ = calendarNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calendar_ = new XsdTypeToken(calendarNode);
                    }
                }
                else
                {
                    calendar_ = new XsdTypeToken(calendarNode);
                }
            }
            
        
            XmlNode businessDayConventionNode = xmlNode.SelectSingleNode("businessDayConvention");
            
            if (businessDayConventionNode != null)
            {
                if (businessDayConventionNode.Attributes["href"] != null || businessDayConventionNode.Attributes["id"] != null) 
                {
                    if (businessDayConventionNode.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(businessDayConventionNode);
                        IDManager.SetID(businessDayConventionIDRef_, ob);
                    }
                    else if (businessDayConventionNode.Attributes["href"] != null)
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDayConvention_ = new XsdTypeToken(businessDayConventionNode);
                    }
                }
                else
                {
                    businessDayConvention_ = new XsdTypeToken(businessDayConventionNode);
                }
            }
            
        
            XmlNodeList rateDataNodeList = xmlNode.SelectNodes("rateData");
            
            if (rateDataNodeList != null)
            {
                this.rateData_ = new List<RateData>();
                foreach (XmlNode item in rateDataNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            rateDataIDRef_ = item.Attributes["id"].Value;
                            rateData_.Add(new RateData(item));
                            IDManager.SetID(rateDataIDRef_, rateData_[rateData_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            rateDataIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        rateData_.Add(new RateData(item));
                        }
                    }
                    else
                    {
                        rateData_.Add(new RateData(item));
                    }
                }
            }
            
        
            XmlNode dateGenerationNode = xmlNode.SelectSingleNode("dateGeneration");
            
            if (dateGenerationNode != null)
            {
                if (dateGenerationNode.Attributes["href"] != null || dateGenerationNode.Attributes["id"] != null) 
                {
                    if (dateGenerationNode.Attributes["id"] != null) 
                    {
                        dateGenerationIDRef_ = dateGenerationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dateGenerationNode);
                        IDManager.SetID(dateGenerationIDRef_, ob);
                    }
                    else if (dateGenerationNode.Attributes["href"] != null)
                    {
                        dateGenerationIDRef_ = dateGenerationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateGeneration_ = new XsdTypeToken(dateGenerationNode);
                    }
                }
                else
                {
                    dateGeneration_ = new XsdTypeToken(dateGenerationNode);
                }
            }
            
        
            XmlNode recoveryRateNode = xmlNode.SelectSingleNode("recoveryRate");
            
            if (recoveryRateNode != null)
            {
                if (recoveryRateNode.Attributes["href"] != null || recoveryRateNode.Attributes["id"] != null) 
                {
                    if (recoveryRateNode.Attributes["id"] != null) 
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(recoveryRateNode);
                        IDManager.SetID(recoveryRateIDRef_, ob);
                    }
                    else if (recoveryRateNode.Attributes["href"] != null)
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryRate_ = new XsdTypeToken(recoveryRateNode);
                    }
                }
                else
                {
                    recoveryRate_ = new XsdTypeToken(recoveryRateNode);
                }
            }
            
        
        }
        
    
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
        #region Interpolation_
        private XsdTypeToken interpolation_;
        public XsdTypeToken Interpolation_
        {
            get
            {
                if (this.interpolation_ != null)
                {
                    return this.interpolation_; 
                }
                else if (this.interpolationIDRef_ != null)
                {
                    interpolation_ = IDManager.getID(interpolationIDRef_) as XsdTypeToken;
                    return this.interpolation_; 
                }
                else
                {
                    throw new Exception( "interpolation_Node no exist!");
                }
            }
            set
            {
                if (this.interpolation_ != value)
                {
                    this.interpolation_ = value;
                }
            }
        }
        #endregion
        
        public string interpolationIDRef_ { get; set; }
        #region Daycounter_
        private XsdTypeToken daycounter_;
        public XsdTypeToken Daycounter_
        {
            get
            {
                if (this.daycounter_ != null)
                {
                    return this.daycounter_; 
                }
                else if (this.daycounterIDRef_ != null)
                {
                    daycounter_ = IDManager.getID(daycounterIDRef_) as XsdTypeToken;
                    return this.daycounter_; 
                }
                else
                {
                    throw new Exception( "daycounter_Node no exist!");
                }
            }
            set
            {
                if (this.daycounter_ != value)
                {
                    this.daycounter_ = value;
                }
            }
        }
        #endregion
        
        public string daycounterIDRef_ { get; set; }
        #region Calendar_
        private XsdTypeToken calendar_;
        public XsdTypeToken Calendar_
        {
            get
            {
                if (this.calendar_ != null)
                {
                    return this.calendar_; 
                }
                else if (this.calendarIDRef_ != null)
                {
                    calendar_ = IDManager.getID(calendarIDRef_) as XsdTypeToken;
                    return this.calendar_; 
                }
                else
                {
                    throw new Exception( "calendar_Node no exist!");
                }
            }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                }
            }
        }
        #endregion
        
        public string calendarIDRef_ { get; set; }
        #region BusinessDayConvention_
        private XsdTypeToken businessDayConvention_;
        public XsdTypeToken BusinessDayConvention_
        {
            get
            {
                if (this.businessDayConvention_ != null)
                {
                    return this.businessDayConvention_; 
                }
                else if (this.businessDayConventionIDRef_ != null)
                {
                    businessDayConvention_ = IDManager.getID(businessDayConventionIDRef_) as XsdTypeToken;
                    return this.businessDayConvention_; 
                }
                else
                {
                    throw new Exception( "businessDayConvention_Node no exist!");
                }
            }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayConventionIDRef_ { get; set; }
        #region RateData_
        private List<RateData> rateData_;
        public List<RateData> RateData_
        {
            get
            {
                if (this.rateData_ != null)
                {
                    return this.rateData_; 
                }
                else if (this.rateDataIDRef_ != null)
                {
                    return this.rateData_; 
                }
                else
                {
                    throw new Exception( "rateData_Node no exist!");
                }
            }
            set
            {
                if (this.rateData_ != value)
                {
                    this.rateData_ = value;
                }
            }
        }
        #endregion
        
        public string rateDataIDRef_ { get; set; }
        #region DateGeneration_
        private XsdTypeToken dateGeneration_;
        public XsdTypeToken DateGeneration_
        {
            get
            {
                if (this.dateGeneration_ != null)
                {
                    return this.dateGeneration_; 
                }
                else if (this.dateGenerationIDRef_ != null)
                {
                    dateGeneration_ = IDManager.getID(dateGenerationIDRef_) as XsdTypeToken;
                    return this.dateGeneration_; 
                }
                else
                {
                    throw new Exception( "dateGeneration_Node no exist!");
                }
            }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                }
            }
        }
        #endregion
        
        public string dateGenerationIDRef_ { get; set; }
        #region RecoveryRate_
        private XsdTypeToken recoveryRate_;
        public XsdTypeToken RecoveryRate_
        {
            get
            {
                if (this.recoveryRate_ != null)
                {
                    return this.recoveryRate_; 
                }
                else if (this.recoveryRateIDRef_ != null)
                {
                    recoveryRate_ = IDManager.getID(recoveryRateIDRef_) as XsdTypeToken;
                    return this.recoveryRate_; 
                }
                else
                {
                    throw new Exception( "recoveryRate_Node no exist!");
                }
            }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

