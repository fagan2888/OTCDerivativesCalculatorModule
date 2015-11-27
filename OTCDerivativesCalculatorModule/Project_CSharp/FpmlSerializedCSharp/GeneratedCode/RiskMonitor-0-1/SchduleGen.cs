using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class SchduleGen : ISerialized
    {
        public SchduleGen() { }
        public SchduleGen(XmlNode xmlNode)
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
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new XsdTypeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new XsdTypeDate(terminationDateNode);
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
            
        
            XmlNode calculationPeriodFrequencyNode = xmlNode.SelectSingleNode("calculationPeriodFrequency");
            
            if (calculationPeriodFrequencyNode != null)
            {
                if (calculationPeriodFrequencyNode.Attributes["href"] != null || calculationPeriodFrequencyNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodFrequencyNode.Attributes["id"] != null) 
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["id"].Value;
                        CalculationPeriodFrequency ob = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                        IDManager.SetID(calculationPeriodFrequencyIDRef_, ob);
                    }
                    else if (calculationPeriodFrequencyNode.Attributes["href"] != null)
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                    }
                }
                else
                {
                    calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
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
        #region TerminationDate_
        private XsdTypeDate terminationDate_;
        public XsdTypeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as XsdTypeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
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
                      return this.calendar_; 
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
        #region CalculationPeriodFrequency_
        private CalculationPeriodFrequency calculationPeriodFrequency_;
        public CalculationPeriodFrequency CalculationPeriodFrequency_
        {
            get
            {
                if (this.calculationPeriodFrequency_ != null)
                {
                    return this.calculationPeriodFrequency_; 
                }
                else if (this.calculationPeriodFrequencyIDRef_ != null)
                {
                    calculationPeriodFrequency_ = IDManager.getID(calculationPeriodFrequencyIDRef_) as CalculationPeriodFrequency;
                    return this.calculationPeriodFrequency_; 
                }
                else
                {
                      return this.calculationPeriodFrequency_; 
                }
            }
            set
            {
                if (this.calculationPeriodFrequency_ != value)
                {
                    this.calculationPeriodFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodFrequencyIDRef_ { get; set; }
        
    
        
    
    }
    
}

