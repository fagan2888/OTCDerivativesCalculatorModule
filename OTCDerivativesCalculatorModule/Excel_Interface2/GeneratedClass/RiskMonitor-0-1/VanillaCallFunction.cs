using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaCallFunction : ISerialized
    {
        public VanillaCallFunction() { }
        public VanillaCallFunction(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode partiRateNode = xmlNode.SelectSingleNode("partiRate");
            
            if (partiRateNode != null)
            {
                if (partiRateNode.Attributes["href"] != null || partiRateNode.Attributes["id"] != null) 
                {
                    if (partiRateNode.Attributes["id"] != null) 
                    {
                        partiRateIDRef_ = partiRateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(partiRateNode);
                        IDManager.SetID(partiRateIDRef_, ob);
                    }
                    else if (partiRateNode.Attributes["href"] != null)
                    {
                        partiRateIDRef_ = partiRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partiRate_ = new XsdTypeDouble(partiRateNode);
                    }
                }
                else
                {
                    partiRate_ = new XsdTypeDouble(partiRateNode);
                }
            }
            
        
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new XsdTypeDouble(strikeNode);
                    }
                }
                else
                {
                    strike_ = new XsdTypeDouble(strikeNode);
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
            
        
        }
        
    
        #region PartiRate_
        private XsdTypeDouble partiRate_;
        public XsdTypeDouble PartiRate_
        {
            get
            {
                if (this.partiRate_ != null)
                {
                    return this.partiRate_; 
                }
                else if (this.partiRateIDRef_ != null)
                {
                    partiRate_ = IDManager.getID(partiRateIDRef_) as XsdTypeDouble;
                    return this.partiRate_; 
                }
                else
                {
                    throw new Exception( "partiRate_Node no exist!");
                }
            }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                }
            }
        }
        #endregion
        
        public string partiRateIDRef_ { get; set; }
        #region Strike_
        private XsdTypeDouble strike_;
        public XsdTypeDouble Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as XsdTypeDouble;
                    return this.strike_; 
                }
                else
                {
                    throw new Exception( "strike_Node no exist!");
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

