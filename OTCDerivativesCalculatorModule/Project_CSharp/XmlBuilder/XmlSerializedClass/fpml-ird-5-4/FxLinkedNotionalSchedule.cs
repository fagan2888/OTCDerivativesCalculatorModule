using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxLinkedNotionalSchedule : ISerialized
    {
        public FxLinkedNotionalSchedule(XmlNode xmlNode)
        {
            XmlNode constantNotionalScheduleReferenceNode = xmlNode.SelectSingleNode("constantNotionalScheduleReference");
            
            if (constantNotionalScheduleReferenceNode != null)
            {
                if (constantNotionalScheduleReferenceNode.Attributes["href"] != null || constantNotionalScheduleReferenceNode.Attributes["id"] != null) 
                {
                    if (constantNotionalScheduleReferenceNode.Attributes["id"] != null) 
                    {
                        constantNotionalScheduleReferenceIDRef_ = constantNotionalScheduleReferenceNode.Attributes["id"].Value;
                        NotionalReference ob = new NotionalReference(constantNotionalScheduleReferenceNode);
                        IDManager.SetID(constantNotionalScheduleReferenceIDRef_, ob);
                    }
                    else if (constantNotionalScheduleReferenceNode.Attributes["href"] != null)
                    {
                        constantNotionalScheduleReferenceIDRef_ = constantNotionalScheduleReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constantNotionalScheduleReference_ = new NotionalReference(constantNotionalScheduleReferenceNode);
                    }
                }
                else
                {
                    constantNotionalScheduleReference_ = new NotionalReference(constantNotionalScheduleReferenceNode);
                }
            }
            
        
            XmlNode initialValueNode = xmlNode.SelectSingleNode("initialValue");
            
            if (initialValueNode != null)
            {
                if (initialValueNode.Attributes["href"] != null || initialValueNode.Attributes["id"] != null) 
                {
                    if (initialValueNode.Attributes["id"] != null) 
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialValueNode);
                        IDManager.SetID(initialValueIDRef_, ob);
                    }
                    else if (initialValueNode.Attributes["href"] != null)
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialValue_ = new XsdTypeDecimal(initialValueNode);
                    }
                }
                else
                {
                    initialValue_ = new XsdTypeDecimal(initialValueNode);
                }
            }
            
        
            XmlNode varyingNotionalCurrencyNode = xmlNode.SelectSingleNode("varyingNotionalCurrency");
            
            if (varyingNotionalCurrencyNode != null)
            {
                if (varyingNotionalCurrencyNode.Attributes["href"] != null || varyingNotionalCurrencyNode.Attributes["id"] != null) 
                {
                    if (varyingNotionalCurrencyNode.Attributes["id"] != null) 
                    {
                        varyingNotionalCurrencyIDRef_ = varyingNotionalCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(varyingNotionalCurrencyNode);
                        IDManager.SetID(varyingNotionalCurrencyIDRef_, ob);
                    }
                    else if (varyingNotionalCurrencyNode.Attributes["href"] != null)
                    {
                        varyingNotionalCurrencyIDRef_ = varyingNotionalCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varyingNotionalCurrency_ = new Currency(varyingNotionalCurrencyNode);
                    }
                }
                else
                {
                    varyingNotionalCurrency_ = new Currency(varyingNotionalCurrencyNode);
                }
            }
            
        
            XmlNode varyingNotionalFixingDatesNode = xmlNode.SelectSingleNode("varyingNotionalFixingDates");
            
            if (varyingNotionalFixingDatesNode != null)
            {
                if (varyingNotionalFixingDatesNode.Attributes["href"] != null || varyingNotionalFixingDatesNode.Attributes["id"] != null) 
                {
                    if (varyingNotionalFixingDatesNode.Attributes["id"] != null) 
                    {
                        varyingNotionalFixingDatesIDRef_ = varyingNotionalFixingDatesNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(varyingNotionalFixingDatesNode);
                        IDManager.SetID(varyingNotionalFixingDatesIDRef_, ob);
                    }
                    else if (varyingNotionalFixingDatesNode.Attributes["href"] != null)
                    {
                        varyingNotionalFixingDatesIDRef_ = varyingNotionalFixingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varyingNotionalFixingDates_ = new RelativeDateOffset(varyingNotionalFixingDatesNode);
                    }
                }
                else
                {
                    varyingNotionalFixingDates_ = new RelativeDateOffset(varyingNotionalFixingDatesNode);
                }
            }
            
        
            XmlNode fxSpotRateSourceNode = xmlNode.SelectSingleNode("fxSpotRateSource");
            
            if (fxSpotRateSourceNode != null)
            {
                if (fxSpotRateSourceNode.Attributes["href"] != null || fxSpotRateSourceNode.Attributes["id"] != null) 
                {
                    if (fxSpotRateSourceNode.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["id"].Value;
                        FxSpotRateSource ob = new FxSpotRateSource(fxSpotRateSourceNode);
                        IDManager.SetID(fxSpotRateSourceIDRef_, ob);
                    }
                    else if (fxSpotRateSourceNode.Attributes["href"] != null)
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
                    }
                }
                else
                {
                    fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
                }
            }
            
        
            XmlNode varyingNotionalInterimExchangePaymentDatesNode = xmlNode.SelectSingleNode("varyingNotionalInterimExchangePaymentDates");
            
            if (varyingNotionalInterimExchangePaymentDatesNode != null)
            {
                if (varyingNotionalInterimExchangePaymentDatesNode.Attributes["href"] != null || varyingNotionalInterimExchangePaymentDatesNode.Attributes["id"] != null) 
                {
                    if (varyingNotionalInterimExchangePaymentDatesNode.Attributes["id"] != null) 
                    {
                        varyingNotionalInterimExchangePaymentDatesIDRef_ = varyingNotionalInterimExchangePaymentDatesNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode);
                        IDManager.SetID(varyingNotionalInterimExchangePaymentDatesIDRef_, ob);
                    }
                    else if (varyingNotionalInterimExchangePaymentDatesNode.Attributes["href"] != null)
                    {
                        varyingNotionalInterimExchangePaymentDatesIDRef_ = varyingNotionalInterimExchangePaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varyingNotionalInterimExchangePaymentDates_ = new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode);
                    }
                }
                else
                {
                    varyingNotionalInterimExchangePaymentDates_ = new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode);
                }
            }
            
        
        }
        
    
        #region ConstantNotionalScheduleReference_
        private NotionalReference constantNotionalScheduleReference_;
        public NotionalReference ConstantNotionalScheduleReference_
        {
            get
            {
                if (this.constantNotionalScheduleReference_ != null)
                {
                    return this.constantNotionalScheduleReference_; 
                }
                else if (this.constantNotionalScheduleReferenceIDRef_ != null)
                {
                    constantNotionalScheduleReference_ = IDManager.getID(constantNotionalScheduleReferenceIDRef_) as NotionalReference;
                    return this.constantNotionalScheduleReference_; 
                }
                else
                {
                      return this.constantNotionalScheduleReference_; 
                }
            }
            set
            {
                if (this.constantNotionalScheduleReference_ != value)
                {
                    this.constantNotionalScheduleReference_ = value;
                }
            }
        }
        #endregion
        
        public string constantNotionalScheduleReferenceIDRef_ { get; set; }
        #region InitialValue_
        private XsdTypeDecimal initialValue_;
        public XsdTypeDecimal InitialValue_
        {
            get
            {
                if (this.initialValue_ != null)
                {
                    return this.initialValue_; 
                }
                else if (this.initialValueIDRef_ != null)
                {
                    initialValue_ = IDManager.getID(initialValueIDRef_) as XsdTypeDecimal;
                    return this.initialValue_; 
                }
                else
                {
                      return this.initialValue_; 
                }
            }
            set
            {
                if (this.initialValue_ != value)
                {
                    this.initialValue_ = value;
                }
            }
        }
        #endregion
        
        public string initialValueIDRef_ { get; set; }
        #region VaryingNotionalCurrency_
        private Currency varyingNotionalCurrency_;
        public Currency VaryingNotionalCurrency_
        {
            get
            {
                if (this.varyingNotionalCurrency_ != null)
                {
                    return this.varyingNotionalCurrency_; 
                }
                else if (this.varyingNotionalCurrencyIDRef_ != null)
                {
                    varyingNotionalCurrency_ = IDManager.getID(varyingNotionalCurrencyIDRef_) as Currency;
                    return this.varyingNotionalCurrency_; 
                }
                else
                {
                      return this.varyingNotionalCurrency_; 
                }
            }
            set
            {
                if (this.varyingNotionalCurrency_ != value)
                {
                    this.varyingNotionalCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string varyingNotionalCurrencyIDRef_ { get; set; }
        #region VaryingNotionalFixingDates_
        private RelativeDateOffset varyingNotionalFixingDates_;
        public RelativeDateOffset VaryingNotionalFixingDates_
        {
            get
            {
                if (this.varyingNotionalFixingDates_ != null)
                {
                    return this.varyingNotionalFixingDates_; 
                }
                else if (this.varyingNotionalFixingDatesIDRef_ != null)
                {
                    varyingNotionalFixingDates_ = IDManager.getID(varyingNotionalFixingDatesIDRef_) as RelativeDateOffset;
                    return this.varyingNotionalFixingDates_; 
                }
                else
                {
                      return this.varyingNotionalFixingDates_; 
                }
            }
            set
            {
                if (this.varyingNotionalFixingDates_ != value)
                {
                    this.varyingNotionalFixingDates_ = value;
                }
            }
        }
        #endregion
        
        public string varyingNotionalFixingDatesIDRef_ { get; set; }
        #region FxSpotRateSource_
        private FxSpotRateSource fxSpotRateSource_;
        public FxSpotRateSource FxSpotRateSource_
        {
            get
            {
                if (this.fxSpotRateSource_ != null)
                {
                    return this.fxSpotRateSource_; 
                }
                else if (this.fxSpotRateSourceIDRef_ != null)
                {
                    fxSpotRateSource_ = IDManager.getID(fxSpotRateSourceIDRef_) as FxSpotRateSource;
                    return this.fxSpotRateSource_; 
                }
                else
                {
                      return this.fxSpotRateSource_; 
                }
            }
            set
            {
                if (this.fxSpotRateSource_ != value)
                {
                    this.fxSpotRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string fxSpotRateSourceIDRef_ { get; set; }
        #region VaryingNotionalInterimExchangePaymentDates_
        private RelativeDateOffset varyingNotionalInterimExchangePaymentDates_;
        public RelativeDateOffset VaryingNotionalInterimExchangePaymentDates_
        {
            get
            {
                if (this.varyingNotionalInterimExchangePaymentDates_ != null)
                {
                    return this.varyingNotionalInterimExchangePaymentDates_; 
                }
                else if (this.varyingNotionalInterimExchangePaymentDatesIDRef_ != null)
                {
                    varyingNotionalInterimExchangePaymentDates_ = IDManager.getID(varyingNotionalInterimExchangePaymentDatesIDRef_) as RelativeDateOffset;
                    return this.varyingNotionalInterimExchangePaymentDates_; 
                }
                else
                {
                      return this.varyingNotionalInterimExchangePaymentDates_; 
                }
            }
            set
            {
                if (this.varyingNotionalInterimExchangePaymentDates_ != value)
                {
                    this.varyingNotionalInterimExchangePaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string varyingNotionalInterimExchangePaymentDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

