using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaFloatingRatePayoff_A : ISerialized
    {
        public VanillaFloatingRatePayoff_A() { }
        public VanillaFloatingRatePayoff_A(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode calculationStartDateNode = xmlNode.SelectSingleNode("calculationStartDate");
            
            if (calculationStartDateNode != null)
            {
                if (calculationStartDateNode.Attributes["href"] != null || calculationStartDateNode.Attributes["id"] != null) 
                {
                    if (calculationStartDateNode.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
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
                        XsdTypeDate ob = new XsdTypeDate(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
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
                        XsdTypeDouble ob = new XsdTypeDouble(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeDouble(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeDouble(gearingNode);
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
                        XsdTypeDouble ob = new XsdTypeDouble(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDouble(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDouble(spreadNode);
                }
            }
            
        
            XmlNode referenceStrNode = xmlNode.SelectSingleNode("referenceStr");
            
            if (referenceStrNode != null)
            {
                if (referenceStrNode.Attributes["href"] != null || referenceStrNode.Attributes["id"] != null) 
                {
                    if (referenceStrNode.Attributes["id"] != null) 
                    {
                        referenceStrIDRef_ = referenceStrNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceStrNode);
                        IDManager.SetID(referenceStrIDRef_, ob);
                    }
                    else if (referenceStrNode.Attributes["href"] != null)
                    {
                        referenceStrIDRef_ = referenceStrNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceStr_ = new XsdTypeToken(referenceStrNode);
                    }
                }
                else
                {
                    referenceStr_ = new XsdTypeToken(referenceStrNode);
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
            
        
            XmlNode capFloorOptionNode = xmlNode.SelectSingleNode("capFloorOption");
            
            if (capFloorOptionNode != null)
            {
                if (capFloorOptionNode.Attributes["href"] != null || capFloorOptionNode.Attributes["id"] != null) 
                {
                    if (capFloorOptionNode.Attributes["id"] != null) 
                    {
                        capFloorOptionIDRef_ = capFloorOptionNode.Attributes["id"].Value;
                        CapFloorOption ob = new CapFloorOption(capFloorOptionNode);
                        IDManager.SetID(capFloorOptionIDRef_, ob);
                    }
                    else if (capFloorOptionNode.Attributes["href"] != null)
                    {
                        capFloorOptionIDRef_ = capFloorOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        capFloorOption_ = new CapFloorOption(capFloorOptionNode);
                    }
                }
                else
                {
                    capFloorOption_ = new CapFloorOption(capFloorOptionNode);
                }
            }
            
        
        }
        
    
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
        #region CalculationStartDate_
        private XsdTypeDate calculationStartDate_;
        public XsdTypeDate CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as XsdTypeDate;
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
        private XsdTypeDate calculationEndDate_;
        public XsdTypeDate CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as XsdTypeDate;
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
        #region Gearing_
        private XsdTypeDouble gearing_;
        public XsdTypeDouble Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeDouble;
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
        private XsdTypeDouble spread_;
        public XsdTypeDouble Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDouble;
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
        #region ReferenceStr_
        private XsdTypeToken referenceStr_;
        public XsdTypeToken ReferenceStr_
        {
            get
            {
                if (this.referenceStr_ != null)
                {
                    return this.referenceStr_; 
                }
                else if (this.referenceStrIDRef_ != null)
                {
                    referenceStr_ = IDManager.getID(referenceStrIDRef_) as XsdTypeToken;
                    return this.referenceStr_; 
                }
                else
                {
                    throw new Exception( "referenceStr_Node no exist!");
                }
            }
            set
            {
                if (this.referenceStr_ != value)
                {
                    this.referenceStr_ = value;
                }
            }
        }
        #endregion
        
        public string referenceStrIDRef_ { get; set; }
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
        #region CapFloorOption_
        private CapFloorOption capFloorOption_;
        public CapFloorOption CapFloorOption_
        {
            get
            {
                if (this.capFloorOption_ != null)
                {
                    return this.capFloorOption_; 
                }
                else if (this.capFloorOptionIDRef_ != null)
                {
                    capFloorOption_ = IDManager.getID(capFloorOptionIDRef_) as CapFloorOption;
                    return this.capFloorOption_; 
                }
                else
                {
                    throw new Exception( "capFloorOption_Node no exist!");
                }
            }
            set
            {
                if (this.capFloorOption_ != value)
                {
                    this.capFloorOption_ = value;
                }
            }
        }
        #endregion
        
        public string capFloorOptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

