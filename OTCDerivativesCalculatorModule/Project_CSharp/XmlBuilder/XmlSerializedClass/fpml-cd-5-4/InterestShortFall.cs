using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestShortFall : ISerialized
    {
        public InterestShortFall(XmlNode xmlNode)
        {
            XmlNode interestShortfallCapNode = xmlNode.SelectSingleNode("interestShortfallCap");
            
            if (interestShortfallCapNode != null)
            {
                if (interestShortfallCapNode.Attributes["href"] != null || interestShortfallCapNode.Attributes["id"] != null) 
                {
                    if (interestShortfallCapNode.Attributes["id"] != null) 
                    {
                        interestShortfallCapIDRef_ = interestShortfallCapNode.Attributes["id"].Value;
                        InterestShortfallCapEnum ob = new InterestShortfallCapEnum(interestShortfallCapNode);
                        IDManager.SetID(interestShortfallCapIDRef_, ob);
                    }
                    else if (interestShortfallCapNode.Attributes["href"] != null)
                    {
                        interestShortfallCapIDRef_ = interestShortfallCapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestShortfallCap_ = new InterestShortfallCapEnum(interestShortfallCapNode);
                    }
                }
                else
                {
                    interestShortfallCap_ = new InterestShortfallCapEnum(interestShortfallCapNode);
                }
            }
            
        
            XmlNode compoundingNode = xmlNode.SelectSingleNode("compounding");
            
            if (compoundingNode != null)
            {
                if (compoundingNode.Attributes["href"] != null || compoundingNode.Attributes["id"] != null) 
                {
                    if (compoundingNode.Attributes["id"] != null) 
                    {
                        compoundingIDRef_ = compoundingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(compoundingNode);
                        IDManager.SetID(compoundingIDRef_, ob);
                    }
                    else if (compoundingNode.Attributes["href"] != null)
                    {
                        compoundingIDRef_ = compoundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compounding_ = new XsdTypeBoolean(compoundingNode);
                    }
                }
                else
                {
                    compounding_ = new XsdTypeBoolean(compoundingNode);
                }
            }
            
        
            XmlNode rateSourceNode = xmlNode.SelectSingleNode("rateSource");
            
            if (rateSourceNode != null)
            {
                if (rateSourceNode.Attributes["href"] != null || rateSourceNode.Attributes["id"] != null) 
                {
                    if (rateSourceNode.Attributes["id"] != null) 
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["id"].Value;
                        FloatingRateIndex ob = new FloatingRateIndex(rateSourceNode);
                        IDManager.SetID(rateSourceIDRef_, ob);
                    }
                    else if (rateSourceNode.Attributes["href"] != null)
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateSource_ = new FloatingRateIndex(rateSourceNode);
                    }
                }
                else
                {
                    rateSource_ = new FloatingRateIndex(rateSourceNode);
                }
            }
            
        
        }
        
    
        #region InterestShortfallCap_
        private InterestShortfallCapEnum interestShortfallCap_;
        public InterestShortfallCapEnum InterestShortfallCap_
        {
            get
            {
                if (this.interestShortfallCap_ != null)
                {
                    return this.interestShortfallCap_; 
                }
                else if (this.interestShortfallCapIDRef_ != null)
                {
                    interestShortfallCap_ = IDManager.getID(interestShortfallCapIDRef_) as InterestShortfallCapEnum;
                    return this.interestShortfallCap_; 
                }
                else
                {
                      return this.interestShortfallCap_; 
                }
            }
            set
            {
                if (this.interestShortfallCap_ != value)
                {
                    this.interestShortfallCap_ = value;
                }
            }
        }
        #endregion
        
        public string interestShortfallCapIDRef_ { get; set; }
        #region Compounding_
        private XsdTypeBoolean compounding_;
        public XsdTypeBoolean Compounding_
        {
            get
            {
                if (this.compounding_ != null)
                {
                    return this.compounding_; 
                }
                else if (this.compoundingIDRef_ != null)
                {
                    compounding_ = IDManager.getID(compoundingIDRef_) as XsdTypeBoolean;
                    return this.compounding_; 
                }
                else
                {
                      return this.compounding_; 
                }
            }
            set
            {
                if (this.compounding_ != value)
                {
                    this.compounding_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingIDRef_ { get; set; }
        #region RateSource_
        private FloatingRateIndex rateSource_;
        public FloatingRateIndex RateSource_
        {
            get
            {
                if (this.rateSource_ != null)
                {
                    return this.rateSource_; 
                }
                else if (this.rateSourceIDRef_ != null)
                {
                    rateSource_ = IDManager.getID(rateSourceIDRef_) as FloatingRateIndex;
                    return this.rateSource_; 
                }
                else
                {
                      return this.rateSource_; 
                }
            }
            set
            {
                if (this.rateSource_ != value)
                {
                    this.rateSource_ = value;
                }
            }
        }
        #endregion
        
        public string rateSourceIDRef_ { get; set; }
        
    
        
    
    }
    
}

