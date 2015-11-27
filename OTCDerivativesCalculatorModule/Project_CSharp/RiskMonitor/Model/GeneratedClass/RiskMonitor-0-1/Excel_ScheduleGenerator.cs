using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_ScheduleGenerator : ISerialized
    {
        public Excel_ScheduleGenerator() { }
        public Excel_ScheduleGenerator(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeToken(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeToken(effectiveDateNode);
                }
            }
            
        
            XmlNode maturityDateNode = xmlNode.SelectSingleNode("maturityDate");
            
            if (maturityDateNode != null)
            {
                if (maturityDateNode.Attributes["href"] != null || maturityDateNode.Attributes["id"] != null) 
                {
                    if (maturityDateNode.Attributes["id"] != null) 
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new XsdTypeToken(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new XsdTypeToken(maturityDateNode);
                }
            }
            
        
            XmlNode tenorNode = xmlNode.SelectSingleNode("tenor");
            
            if (tenorNode != null)
            {
                if (tenorNode.Attributes["href"] != null || tenorNode.Attributes["id"] != null) 
                {
                    if (tenorNode.Attributes["id"] != null) 
                    {
                        tenorIDRef_ = tenorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new XsdTypeToken(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new XsdTypeToken(tenorNode);
                }
            }
            
        
            XmlNode paymentDaysNode = xmlNode.SelectSingleNode("paymentDays");
            
            if (paymentDaysNode != null)
            {
                if (paymentDaysNode.Attributes["href"] != null || paymentDaysNode.Attributes["id"] != null) 
                {
                    if (paymentDaysNode.Attributes["id"] != null) 
                    {
                        paymentDaysIDRef_ = paymentDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(paymentDaysNode);
                        IDManager.SetID(paymentDaysIDRef_, ob);
                    }
                    else if (paymentDaysNode.Attributes["href"] != null)
                    {
                        paymentDaysIDRef_ = paymentDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDays_ = new XsdTypeToken(paymentDaysNode);
                    }
                }
                else
                {
                    paymentDays_ = new XsdTypeToken(paymentDaysNode);
                }
            }
            
        
            XmlNodeList calendarsNodeList = xmlNode.SelectNodes("calendars");
            
            if (calendarsNodeList != null)
            {
                this.calendars_ = new List<XsdTypeToken>();
                foreach (XmlNode item in calendarsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            calendarsIDRef_ = item.Attributes["id"].Value;
                            calendars_.Add(new XsdTypeToken(item));
                            IDManager.SetID(calendarsIDRef_, calendars_[calendars_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            calendarsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        calendars_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        calendars_.Add(new XsdTypeToken(item));
                    }
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
            
        
        }
        
    
        #region EffectiveDate_
        private XsdTypeToken effectiveDate_;
        public XsdTypeToken EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeToken;
                    return this.effectiveDate_; 
                }
                else
                {
                    throw new Exception( "effectiveDate_Node no exist!");
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region MaturityDate_
        private XsdTypeToken maturityDate_;
        public XsdTypeToken MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as XsdTypeToken;
                    return this.maturityDate_; 
                }
                else
                {
                    throw new Exception( "maturityDate_Node no exist!");
                }
            }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                }
            }
        }
        #endregion
        
        public string maturityDateIDRef_ { get; set; }
        #region Tenor_
        private XsdTypeToken tenor_;
        public XsdTypeToken Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as XsdTypeToken;
                    return this.tenor_; 
                }
                else
                {
                    throw new Exception( "tenor_Node no exist!");
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region PaymentDays_
        private XsdTypeToken paymentDays_;
        public XsdTypeToken PaymentDays_
        {
            get
            {
                if (this.paymentDays_ != null)
                {
                    return this.paymentDays_; 
                }
                else if (this.paymentDaysIDRef_ != null)
                {
                    paymentDays_ = IDManager.getID(paymentDaysIDRef_) as XsdTypeToken;
                    return this.paymentDays_; 
                }
                else
                {
                    throw new Exception( "paymentDays_Node no exist!");
                }
            }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDaysIDRef_ { get; set; }
        #region Calendars_
        private List<XsdTypeToken> calendars_;
        public List<XsdTypeToken> Calendars_
        {
            get
            {
                if (this.calendars_ != null)
                {
                    return this.calendars_; 
                }
                else if (this.calendarsIDRef_ != null)
                {
                    return this.calendars_; 
                }
                else
                {
                    throw new Exception( "calendars_Node no exist!");
                }
            }
            set
            {
                if (this.calendars_ != value)
                {
                    this.calendars_ = value;
                }
            }
        }
        #endregion
        
        public string calendarsIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

