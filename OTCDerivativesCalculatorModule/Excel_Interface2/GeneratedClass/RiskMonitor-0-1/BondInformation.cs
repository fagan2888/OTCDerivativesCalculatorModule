using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BondInformation : ISerialized
    {
        public BondInformation() { }
        public BondInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode irFrequencyNode = xmlNode.SelectSingleNode("irFrequency");
            
            if (irFrequencyNode != null)
            {
                if (irFrequencyNode.Attributes["href"] != null || irFrequencyNode.Attributes["id"] != null) 
                {
                    if (irFrequencyNode.Attributes["id"] != null) 
                    {
                        irFrequencyIDRef_ = irFrequencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(irFrequencyNode);
                        IDManager.SetID(irFrequencyIDRef_, ob);
                    }
                    else if (irFrequencyNode.Attributes["href"] != null)
                    {
                        irFrequencyIDRef_ = irFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        irFrequency_ = new XsdTypeToken(irFrequencyNode);
                    }
                }
                else
                {
                    irFrequency_ = new XsdTypeToken(irFrequencyNode);
                }
            }
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeToken(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeToken(notionalNode);
                }
            }
            
        
            XmlNode issueDateNode = xmlNode.SelectSingleNode("issueDate");
            
            if (issueDateNode != null)
            {
                if (issueDateNode.Attributes["href"] != null || issueDateNode.Attributes["id"] != null) 
                {
                    if (issueDateNode.Attributes["id"] != null) 
                    {
                        issueDateIDRef_ = issueDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(issueDateNode);
                        IDManager.SetID(issueDateIDRef_, ob);
                    }
                    else if (issueDateNode.Attributes["href"] != null)
                    {
                        issueDateIDRef_ = issueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issueDate_ = new XsdTypeToken(issueDateNode);
                    }
                }
                else
                {
                    issueDate_ = new XsdTypeToken(issueDateNode);
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
            
        
            XmlNode dayCounterNode = xmlNode.SelectSingleNode("dayCounter");
            
            if (dayCounterNode != null)
            {
                if (dayCounterNode.Attributes["href"] != null || dayCounterNode.Attributes["id"] != null) 
                {
                    if (dayCounterNode.Attributes["id"] != null) 
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayCounterNode);
                        IDManager.SetID(dayCounterIDRef_, ob);
                    }
                    else if (dayCounterNode.Attributes["href"] != null)
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCounter_ = new XsdTypeToken(dayCounterNode);
                    }
                }
                else
                {
                    dayCounter_ = new XsdTypeToken(dayCounterNode);
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
            
        
        }
        
    
        #region IrFrequency_
        private XsdTypeToken irFrequency_;
        public XsdTypeToken IrFrequency_
        {
            get
            {
                if (this.irFrequency_ != null)
                {
                    return this.irFrequency_; 
                }
                else if (this.irFrequencyIDRef_ != null)
                {
                    irFrequency_ = IDManager.getID(irFrequencyIDRef_) as XsdTypeToken;
                    return this.irFrequency_; 
                }
                else
                {
                    throw new Exception( "irFrequency_Node no exist!");
                }
            }
            set
            {
                if (this.irFrequency_ != value)
                {
                    this.irFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string irFrequencyIDRef_ { get; set; }
        #region Notional_
        private XsdTypeToken notional_;
        public XsdTypeToken Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeToken;
                    return this.notional_; 
                }
                else
                {
                    throw new Exception( "notional_Node no exist!");
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region IssueDate_
        private XsdTypeToken issueDate_;
        public XsdTypeToken IssueDate_
        {
            get
            {
                if (this.issueDate_ != null)
                {
                    return this.issueDate_; 
                }
                else if (this.issueDateIDRef_ != null)
                {
                    issueDate_ = IDManager.getID(issueDateIDRef_) as XsdTypeToken;
                    return this.issueDate_; 
                }
                else
                {
                    throw new Exception( "issueDate_Node no exist!");
                }
            }
            set
            {
                if (this.issueDate_ != value)
                {
                    this.issueDate_ = value;
                }
            }
        }
        #endregion
        
        public string issueDateIDRef_ { get; set; }
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
        #region DayCounter_
        private XsdTypeToken dayCounter_;
        public XsdTypeToken DayCounter_
        {
            get
            {
                if (this.dayCounter_ != null)
                {
                    return this.dayCounter_; 
                }
                else if (this.dayCounterIDRef_ != null)
                {
                    dayCounter_ = IDManager.getID(dayCounterIDRef_) as XsdTypeToken;
                    return this.dayCounter_; 
                }
                else
                {
                    throw new Exception( "dayCounter_Node no exist!");
                }
            }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                }
            }
        }
        #endregion
        
        public string dayCounterIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

