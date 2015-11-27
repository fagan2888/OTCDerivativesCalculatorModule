using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_greekUnderlying : ISerialized
    {
        public Excel_greekUnderlying() { }
        public Excel_greekUnderlying(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode underlyingNameNode = xmlNode.SelectSingleNode("underlyingName");
            
            if (underlyingNameNode != null)
            {
                if (underlyingNameNode.Attributes["href"] != null || underlyingNameNode.Attributes["id"] != null) 
                {
                    if (underlyingNameNode.Attributes["id"] != null) 
                    {
                        underlyingNameIDRef_ = underlyingNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underlyingNameNode);
                        IDManager.SetID(underlyingNameIDRef_, ob);
                    }
                    else if (underlyingNameNode.Attributes["href"] != null)
                    {
                        underlyingNameIDRef_ = underlyingNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingName_ = new XsdTypeToken(underlyingNameNode);
                    }
                }
                else
                {
                    underlyingName_ = new XsdTypeToken(underlyingNameNode);
                }
            }
            
        
            XmlNode underlyingValueNode = xmlNode.SelectSingleNode("underlyingValue");
            
            if (underlyingValueNode != null)
            {
                if (underlyingValueNode.Attributes["href"] != null || underlyingValueNode.Attributes["id"] != null) 
                {
                    if (underlyingValueNode.Attributes["id"] != null) 
                    {
                        underlyingValueIDRef_ = underlyingValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underlyingValueNode);
                        IDManager.SetID(underlyingValueIDRef_, ob);
                    }
                    else if (underlyingValueNode.Attributes["href"] != null)
                    {
                        underlyingValueIDRef_ = underlyingValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingValue_ = new XsdTypeToken(underlyingValueNode);
                    }
                }
                else
                {
                    underlyingValue_ = new XsdTypeToken(underlyingValueNode);
                }
            }
            
        
            XmlNode basePriceNode = xmlNode.SelectSingleNode("basePrice");
            
            if (basePriceNode != null)
            {
                if (basePriceNode.Attributes["href"] != null || basePriceNode.Attributes["id"] != null) 
                {
                    if (basePriceNode.Attributes["id"] != null) 
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(basePriceNode);
                        IDManager.SetID(basePriceIDRef_, ob);
                    }
                    else if (basePriceNode.Attributes["href"] != null)
                    {
                        basePriceIDRef_ = basePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basePrice_ = new XsdTypeToken(basePriceNode);
                    }
                }
                else
                {
                    basePrice_ = new XsdTypeToken(basePriceNode);
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
                        XsdTypeToken ob = new XsdTypeToken(volatilityNode);
                        IDManager.SetID(volatilityIDRef_, ob);
                    }
                    else if (volatilityNode.Attributes["href"] != null)
                    {
                        volatilityIDRef_ = volatilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatility_ = new XsdTypeToken(volatilityNode);
                    }
                }
                else
                {
                    volatility_ = new XsdTypeToken(volatilityNode);
                }
            }
            
        
            XmlNode pertubation_hNode = xmlNode.SelectSingleNode("pertubation_h");
            
            if (pertubation_hNode != null)
            {
                if (pertubation_hNode.Attributes["href"] != null || pertubation_hNode.Attributes["id"] != null) 
                {
                    if (pertubation_hNode.Attributes["id"] != null) 
                    {
                        pertubation_hIDRef_ = pertubation_hNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(pertubation_hNode);
                        IDManager.SetID(pertubation_hIDRef_, ob);
                    }
                    else if (pertubation_hNode.Attributes["href"] != null)
                    {
                        pertubation_hIDRef_ = pertubation_hNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pertubation_h_ = new XsdTypeToken(pertubation_hNode);
                    }
                }
                else
                {
                    pertubation_h_ = new XsdTypeToken(pertubation_hNode);
                }
            }
            
        
            XmlNode deltaNode = xmlNode.SelectSingleNode("delta");
            
            if (deltaNode != null)
            {
                if (deltaNode.Attributes["href"] != null || deltaNode.Attributes["id"] != null) 
                {
                    if (deltaNode.Attributes["id"] != null) 
                    {
                        deltaIDRef_ = deltaNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(deltaNode);
                        IDManager.SetID(deltaIDRef_, ob);
                    }
                    else if (deltaNode.Attributes["href"] != null)
                    {
                        deltaIDRef_ = deltaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        delta_ = new XsdTypeToken(deltaNode);
                    }
                }
                else
                {
                    delta_ = new XsdTypeToken(deltaNode);
                }
            }
            
        
            XmlNode gammaNode = xmlNode.SelectSingleNode("gamma");
            
            if (gammaNode != null)
            {
                if (gammaNode.Attributes["href"] != null || gammaNode.Attributes["id"] != null) 
                {
                    if (gammaNode.Attributes["id"] != null) 
                    {
                        gammaIDRef_ = gammaNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(gammaNode);
                        IDManager.SetID(gammaIDRef_, ob);
                    }
                    else if (gammaNode.Attributes["href"] != null)
                    {
                        gammaIDRef_ = gammaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gamma_ = new XsdTypeToken(gammaNode);
                    }
                }
                else
                {
                    gamma_ = new XsdTypeToken(gammaNode);
                }
            }
            
        
            XmlNode vegaNode = xmlNode.SelectSingleNode("vega");
            
            if (vegaNode != null)
            {
                if (vegaNode.Attributes["href"] != null || vegaNode.Attributes["id"] != null) 
                {
                    if (vegaNode.Attributes["id"] != null) 
                    {
                        vegaIDRef_ = vegaNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(vegaNode);
                        IDManager.SetID(vegaIDRef_, ob);
                    }
                    else if (vegaNode.Attributes["href"] != null)
                    {
                        vegaIDRef_ = vegaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vega_ = new XsdTypeToken(vegaNode);
                    }
                }
                else
                {
                    vega_ = new XsdTypeToken(vegaNode);
                }
            }
            
        
        }
        
    
        #region UnderlyingName_
        private XsdTypeToken underlyingName_;
        public XsdTypeToken UnderlyingName_
        {
            get
            {
                if (this.underlyingName_ != null)
                {
                    return this.underlyingName_; 
                }
                else if (this.underlyingNameIDRef_ != null)
                {
                    underlyingName_ = IDManager.getID(underlyingNameIDRef_) as XsdTypeToken;
                    return this.underlyingName_; 
                }
                else
                {
                    throw new Exception( "underlyingName_Node no exist!");
                }
            }
            set
            {
                if (this.underlyingName_ != value)
                {
                    this.underlyingName_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingNameIDRef_ { get; set; }
        #region UnderlyingValue_
        private XsdTypeToken underlyingValue_;
        public XsdTypeToken UnderlyingValue_
        {
            get
            {
                if (this.underlyingValue_ != null)
                {
                    return this.underlyingValue_; 
                }
                else if (this.underlyingValueIDRef_ != null)
                {
                    underlyingValue_ = IDManager.getID(underlyingValueIDRef_) as XsdTypeToken;
                    return this.underlyingValue_; 
                }
                else
                {
                    throw new Exception( "underlyingValue_Node no exist!");
                }
            }
            set
            {
                if (this.underlyingValue_ != value)
                {
                    this.underlyingValue_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingValueIDRef_ { get; set; }
        #region BasePrice_
        private XsdTypeToken basePrice_;
        public XsdTypeToken BasePrice_
        {
            get
            {
                if (this.basePrice_ != null)
                {
                    return this.basePrice_; 
                }
                else if (this.basePriceIDRef_ != null)
                {
                    basePrice_ = IDManager.getID(basePriceIDRef_) as XsdTypeToken;
                    return this.basePrice_; 
                }
                else
                {
                    throw new Exception( "basePrice_Node no exist!");
                }
            }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                }
            }
        }
        #endregion
        
        public string basePriceIDRef_ { get; set; }
        #region Volatility_
        private XsdTypeToken volatility_;
        public XsdTypeToken Volatility_
        {
            get
            {
                if (this.volatility_ != null)
                {
                    return this.volatility_; 
                }
                else if (this.volatilityIDRef_ != null)
                {
                    volatility_ = IDManager.getID(volatilityIDRef_) as XsdTypeToken;
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
        #region Pertubation_h_
        private XsdTypeToken pertubation_h_;
        public XsdTypeToken Pertubation_h_
        {
            get
            {
                if (this.pertubation_h_ != null)
                {
                    return this.pertubation_h_; 
                }
                else if (this.pertubation_hIDRef_ != null)
                {
                    pertubation_h_ = IDManager.getID(pertubation_hIDRef_) as XsdTypeToken;
                    return this.pertubation_h_; 
                }
                else
                {
                    throw new Exception( "pertubation_h_Node no exist!");
                }
            }
            set
            {
                if (this.pertubation_h_ != value)
                {
                    this.pertubation_h_ = value;
                }
            }
        }
        #endregion
        
        public string pertubation_hIDRef_ { get; set; }
        #region Delta_
        private XsdTypeToken delta_;
        public XsdTypeToken Delta_
        {
            get
            {
                if (this.delta_ != null)
                {
                    return this.delta_; 
                }
                else if (this.deltaIDRef_ != null)
                {
                    delta_ = IDManager.getID(deltaIDRef_) as XsdTypeToken;
                    return this.delta_; 
                }
                else
                {
                    throw new Exception( "delta_Node no exist!");
                }
            }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                }
            }
        }
        #endregion
        
        public string deltaIDRef_ { get; set; }
        #region Gamma_
        private XsdTypeToken gamma_;
        public XsdTypeToken Gamma_
        {
            get
            {
                if (this.gamma_ != null)
                {
                    return this.gamma_; 
                }
                else if (this.gammaIDRef_ != null)
                {
                    gamma_ = IDManager.getID(gammaIDRef_) as XsdTypeToken;
                    return this.gamma_; 
                }
                else
                {
                    throw new Exception( "gamma_Node no exist!");
                }
            }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                }
            }
        }
        #endregion
        
        public string gammaIDRef_ { get; set; }
        #region Vega_
        private XsdTypeToken vega_;
        public XsdTypeToken Vega_
        {
            get
            {
                if (this.vega_ != null)
                {
                    return this.vega_; 
                }
                else if (this.vegaIDRef_ != null)
                {
                    vega_ = IDManager.getID(vegaIDRef_) as XsdTypeToken;
                    return this.vega_; 
                }
                else
                {
                    throw new Exception( "vega_Node no exist!");
                }
            }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                }
            }
        }
        #endregion
        
        public string vegaIDRef_ { get; set; }
        
    
        
    
    }
    
}

