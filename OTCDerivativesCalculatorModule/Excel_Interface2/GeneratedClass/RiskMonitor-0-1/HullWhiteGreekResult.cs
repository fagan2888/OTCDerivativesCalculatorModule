using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class HullWhiteGreekResult : ISerialized
    {
        public HullWhiteGreekResult() { }
        public HullWhiteGreekResult(XmlNode xmlNode)
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
            
        
            XmlNode deltaNode = xmlNode.SelectSingleNode("delta");
            
            if (deltaNode != null)
            {
                if (deltaNode.Attributes["href"] != null || deltaNode.Attributes["id"] != null) 
                {
                    if (deltaNode.Attributes["id"] != null) 
                    {
                        deltaIDRef_ = deltaNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(deltaNode);
                        IDManager.SetID(deltaIDRef_, ob);
                    }
                    else if (deltaNode.Attributes["href"] != null)
                    {
                        deltaIDRef_ = deltaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        delta_ = new XsdTypeDouble(deltaNode);
                    }
                }
                else
                {
                    delta_ = new XsdTypeDouble(deltaNode);
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
        #region Delta_
        private XsdTypeDouble delta_;
        public XsdTypeDouble Delta_
        {
            get
            {
                if (this.delta_ != null)
                {
                    return this.delta_; 
                }
                else if (this.deltaIDRef_ != null)
                {
                    delta_ = IDManager.getID(deltaIDRef_) as XsdTypeDouble;
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

