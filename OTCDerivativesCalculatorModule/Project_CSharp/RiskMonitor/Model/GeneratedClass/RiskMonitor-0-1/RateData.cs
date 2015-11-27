using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RateData : ISerialized
    {
        public RateData() { }
        public RateData(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode periodMultiplierNode = xmlNode.SelectSingleNode("periodMultiplier");
            
            if (periodMultiplierNode != null)
            {
                if (periodMultiplierNode.Attributes["href"] != null || periodMultiplierNode.Attributes["id"] != null) 
                {
                    if (periodMultiplierNode.Attributes["id"] != null) 
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(periodMultiplierNode);
                        IDManager.SetID(periodMultiplierIDRef_, ob);
                    }
                    else if (periodMultiplierNode.Attributes["href"] != null)
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodMultiplier_ = new XsdTypeInteger(periodMultiplierNode);
                    }
                }
                else
                {
                    periodMultiplier_ = new XsdTypeInteger(periodMultiplierNode);
                }
            }
            
        
            XmlNode periodNode = xmlNode.SelectSingleNode("period");
            
            if (periodNode != null)
            {
                if (periodNode.Attributes["href"] != null || periodNode.Attributes["id"] != null) 
                {
                    if (periodNode.Attributes["id"] != null) 
                    {
                        periodIDRef_ = periodNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(periodNode);
                        IDManager.SetID(periodIDRef_, ob);
                    }
                    else if (periodNode.Attributes["href"] != null)
                    {
                        periodIDRef_ = periodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        period_ = new XsdTypeToken(periodNode);
                    }
                }
                else
                {
                    period_ = new XsdTypeToken(periodNode);
                }
            }
            
        
            XmlNode dataNode = xmlNode.SelectSingleNode("data");
            
            if (dataNode != null)
            {
                if (dataNode.Attributes["href"] != null || dataNode.Attributes["id"] != null) 
                {
                    if (dataNode.Attributes["id"] != null) 
                    {
                        dataIDRef_ = dataNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(dataNode);
                        IDManager.SetID(dataIDRef_, ob);
                    }
                    else if (dataNode.Attributes["href"] != null)
                    {
                        dataIDRef_ = dataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        data_ = new XsdTypeDouble(dataNode);
                    }
                }
                else
                {
                    data_ = new XsdTypeDouble(dataNode);
                }
            }
            
        
        }
        
    
        #region PeriodMultiplier_
        private XsdTypeInteger periodMultiplier_;
        public XsdTypeInteger PeriodMultiplier_
        {
            get
            {
                if (this.periodMultiplier_ != null)
                {
                    return this.periodMultiplier_; 
                }
                else if (this.periodMultiplierIDRef_ != null)
                {
                    periodMultiplier_ = IDManager.getID(periodMultiplierIDRef_) as XsdTypeInteger;
                    return this.periodMultiplier_; 
                }
                else
                {
                    throw new Exception( "periodMultiplier_Node no exist!");
                }
            }
            set
            {
                if (this.periodMultiplier_ != value)
                {
                    this.periodMultiplier_ = value;
                }
            }
        }
        #endregion
        
        public string periodMultiplierIDRef_ { get; set; }
        #region Period_
        private XsdTypeToken period_;
        public XsdTypeToken Period_
        {
            get
            {
                if (this.period_ != null)
                {
                    return this.period_; 
                }
                else if (this.periodIDRef_ != null)
                {
                    period_ = IDManager.getID(periodIDRef_) as XsdTypeToken;
                    return this.period_; 
                }
                else
                {
                    throw new Exception( "period_Node no exist!");
                }
            }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                }
            }
        }
        #endregion
        
        public string periodIDRef_ { get; set; }
        #region Data_
        private XsdTypeDouble data_;
        public XsdTypeDouble Data_
        {
            get
            {
                if (this.data_ != null)
                {
                    return this.data_; 
                }
                else if (this.dataIDRef_ != null)
                {
                    data_ = IDManager.getID(dataIDRef_) as XsdTypeDouble;
                    return this.data_; 
                }
                else
                {
                    throw new Exception( "data_Node no exist!");
                }
            }
            set
            {
                if (this.data_ != value)
                {
                    this.data_ = value;
                }
            }
        }
        #endregion
        
        public string dataIDRef_ { get; set; }
        
    
        
    
    }
    
}

