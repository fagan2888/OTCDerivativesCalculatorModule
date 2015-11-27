using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeometricBM : ISerialized
    {
        public GeometricBM() { }
        public GeometricBM(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode currentValueNode = xmlNode.SelectSingleNode("currentValue");
            
            if (currentValueNode != null)
            {
                if (currentValueNode.Attributes["href"] != null || currentValueNode.Attributes["id"] != null) 
                {
                    if (currentValueNode.Attributes["id"] != null) 
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(currentValueNode);
                        IDManager.SetID(currentValueIDRef_, ob);
                    }
                    else if (currentValueNode.Attributes["href"] != null)
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentValue_ = new XsdTypeDouble(currentValueNode);
                    }
                }
                else
                {
                    currentValue_ = new XsdTypeDouble(currentValueNode);
                }
            }
            
        
            XmlNode driftNode = xmlNode.SelectSingleNode("drift");
            
            if (driftNode != null)
            {
                if (driftNode.Attributes["href"] != null || driftNode.Attributes["id"] != null) 
                {
                    if (driftNode.Attributes["id"] != null) 
                    {
                        driftIDRef_ = driftNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(driftNode);
                        IDManager.SetID(driftIDRef_, ob);
                    }
                    else if (driftNode.Attributes["href"] != null)
                    {
                        driftIDRef_ = driftNode.Attributes["href"].Value;
                    }
                    else
                    {
                        drift_ = new XsdTypeDouble(driftNode);
                    }
                }
                else
                {
                    drift_ = new XsdTypeDouble(driftNode);
                }
            }
            
        
            XmlNode dividendNode = xmlNode.SelectSingleNode("dividend");
            
            if (dividendNode != null)
            {
                if (dividendNode.Attributes["href"] != null || dividendNode.Attributes["id"] != null) 
                {
                    if (dividendNode.Attributes["id"] != null) 
                    {
                        dividendIDRef_ = dividendNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(dividendNode);
                        IDManager.SetID(dividendIDRef_, ob);
                    }
                    else if (dividendNode.Attributes["href"] != null)
                    {
                        dividendIDRef_ = dividendNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividend_ = new XsdTypeDouble(dividendNode);
                    }
                }
                else
                {
                    dividend_ = new XsdTypeDouble(dividendNode);
                }
            }
            
        
            XmlNode volatilityNode = xmlNode.SelectSingleNode("volatility");
            
            if (volatilityNode != null)
            {
                if (volatilityNode.Attributes["href"] != null || volatilityNode.Attributes["id"] != null) 
                {
                    if (volatilityNode.Attributes["id"] != null) 
                    {
                        volatilityIDRef_ = volatilityNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(volatilityNode);
                        IDManager.SetID(volatilityIDRef_, ob);
                    }
                    else if (volatilityNode.Attributes["href"] != null)
                    {
                        volatilityIDRef_ = volatilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatility_ = new XsdTypeDouble(volatilityNode);
                    }
                }
                else
                {
                    volatility_ = new XsdTypeDouble(volatilityNode);
                }
            }
            
        
        }
        
    
        #region CurrentValue_
        private XsdTypeDouble currentValue_;
        public XsdTypeDouble CurrentValue_
        {
            get
            {
                if (this.currentValue_ != null)
                {
                    return this.currentValue_; 
                }
                else if (this.currentValueIDRef_ != null)
                {
                    currentValue_ = IDManager.getID(currentValueIDRef_) as XsdTypeDouble;
                    return this.currentValue_; 
                }
                else
                {
                    throw new Exception( "currentValue_Node no exist!");
                }
            }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                }
            }
        }
        #endregion
        
        public string currentValueIDRef_ { get; set; }
        #region Drift_
        private XsdTypeDouble drift_;
        public XsdTypeDouble Drift_
        {
            get
            {
                if (this.drift_ != null)
                {
                    return this.drift_; 
                }
                else if (this.driftIDRef_ != null)
                {
                    drift_ = IDManager.getID(driftIDRef_) as XsdTypeDouble;
                    return this.drift_; 
                }
                else
                {
                    throw new Exception( "drift_Node no exist!");
                }
            }
            set
            {
                if (this.drift_ != value)
                {
                    this.drift_ = value;
                }
            }
        }
        #endregion
        
        public string driftIDRef_ { get; set; }
        #region Dividend_
        private XsdTypeDouble dividend_;
        public XsdTypeDouble Dividend_
        {
            get
            {
                if (this.dividend_ != null)
                {
                    return this.dividend_; 
                }
                else if (this.dividendIDRef_ != null)
                {
                    dividend_ = IDManager.getID(dividendIDRef_) as XsdTypeDouble;
                    return this.dividend_; 
                }
                else
                {
                    throw new Exception( "dividend_Node no exist!");
                }
            }
            set
            {
                if (this.dividend_ != value)
                {
                    this.dividend_ = value;
                }
            }
        }
        #endregion
        
        public string dividendIDRef_ { get; set; }
        #region Volatility_
        private XsdTypeDouble volatility_;
        public XsdTypeDouble Volatility_
        {
            get
            {
                if (this.volatility_ != null)
                {
                    return this.volatility_; 
                }
                else if (this.volatilityIDRef_ != null)
                {
                    volatility_ = IDManager.getID(volatilityIDRef_) as XsdTypeDouble;
                    return this.volatility_; 
                }
                else
                {
                    throw new Exception( "volatility_Node no exist!");
                }
            }
            set
            {
                if (this.volatility_ != value)
                {
                    this.volatility_ = value;
                }
            }
        }
        #endregion
        
        public string volatilityIDRef_ { get; set; }
        
    
        
    
    }
    
}

