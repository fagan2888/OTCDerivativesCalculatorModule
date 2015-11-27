using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxLinkedNotionalSchedule
    {
        public FxLinkedNotionalSchedule(XmlNode xmlNode)
        {
            XmlNodeList constantNotionalScheduleReferenceNodeList = xmlNode.SelectNodes("constantNotionalScheduleReference");
            if (constantNotionalScheduleReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constantNotionalScheduleReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constantNotionalScheduleReferenceIDRef = item.Attributes["id"].Name;
                        NotionalReference ob = NotionalReference();
                        IDManager.SetID(constantNotionalScheduleReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constantNotionalScheduleReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constantNotionalScheduleReference = new NotionalReference(item);
                    }
                }
            }
            
        
            XmlNodeList initialValueNodeList = xmlNode.SelectNodes("initialValue");
            if (initialValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList varyingNotionalCurrencyNodeList = xmlNode.SelectNodes("varyingNotionalCurrency");
            if (varyingNotionalCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varyingNotionalCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varyingNotionalCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(varyingNotionalCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varyingNotionalCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varyingNotionalCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList varyingNotionalFixingDatesNodeList = xmlNode.SelectNodes("varyingNotionalFixingDates");
            if (varyingNotionalFixingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varyingNotionalFixingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varyingNotionalFixingDatesIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(varyingNotionalFixingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varyingNotionalFixingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varyingNotionalFixingDates = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList fxSpotRateSourceNodeList = xmlNode.SelectNodes("fxSpotRateSource");
            if (fxSpotRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxSpotRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef = item.Attributes["id"].Name;
                        FxSpotRateSource ob = FxSpotRateSource();
                        IDManager.SetID(fxSpotRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxSpotRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxSpotRateSource = new FxSpotRateSource(item);
                    }
                }
            }
            
        
            XmlNodeList varyingNotionalInterimExchangePaymentDatesNodeList = xmlNode.SelectNodes("varyingNotionalInterimExchangePaymentDates");
            if (varyingNotionalInterimExchangePaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varyingNotionalInterimExchangePaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varyingNotionalInterimExchangePaymentDatesIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(varyingNotionalInterimExchangePaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varyingNotionalInterimExchangePaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varyingNotionalInterimExchangePaymentDates = new RelativeDateOffset(item);
                    }
                }
            }
            
        
        }
        
    
        #region ConstantNotionalScheduleReference
        private NotionalReference constantNotionalScheduleReference;
        public NotionalReference ConstantNotionalScheduleReference
        {
            get
            {
                if (this.constantNotionalScheduleReference != null)
                {
                    return this.constantNotionalScheduleReference; 
                }
                else if (this.constantNotionalScheduleReferenceIDRef != null)
                {
                    constantNotionalScheduleReference = IDManager.getID(constantNotionalScheduleReferenceIDRef) as NotionalReference;
                    return this.constantNotionalScheduleReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constantNotionalScheduleReference != value)
                {
                    this.constantNotionalScheduleReference = value;
                }
            }
        }
        #endregion
        
        public string NotionalReferenceIDRef { get; set; }
        #region InitialValue
        private XsdTypeDecimal initialValue;
        public XsdTypeDecimal InitialValue
        {
            get
            {
                if (this.initialValue != null)
                {
                    return this.initialValue; 
                }
                else if (this.initialValueIDRef != null)
                {
                    initialValue = IDManager.getID(initialValueIDRef) as XsdTypeDecimal;
                    return this.initialValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialValue != value)
                {
                    this.initialValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region VaryingNotionalCurrency
        private Currency varyingNotionalCurrency;
        public Currency VaryingNotionalCurrency
        {
            get
            {
                if (this.varyingNotionalCurrency != null)
                {
                    return this.varyingNotionalCurrency; 
                }
                else if (this.varyingNotionalCurrencyIDRef != null)
                {
                    varyingNotionalCurrency = IDManager.getID(varyingNotionalCurrencyIDRef) as Currency;
                    return this.varyingNotionalCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varyingNotionalCurrency != value)
                {
                    this.varyingNotionalCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region VaryingNotionalFixingDates
        private RelativeDateOffset varyingNotionalFixingDates;
        public RelativeDateOffset VaryingNotionalFixingDates
        {
            get
            {
                if (this.varyingNotionalFixingDates != null)
                {
                    return this.varyingNotionalFixingDates; 
                }
                else if (this.varyingNotionalFixingDatesIDRef != null)
                {
                    varyingNotionalFixingDates = IDManager.getID(varyingNotionalFixingDatesIDRef) as RelativeDateOffset;
                    return this.varyingNotionalFixingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varyingNotionalFixingDates != value)
                {
                    this.varyingNotionalFixingDates = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region FxSpotRateSource
        private FxSpotRateSource fxSpotRateSource;
        public FxSpotRateSource FxSpotRateSource
        {
            get
            {
                if (this.fxSpotRateSource != null)
                {
                    return this.fxSpotRateSource; 
                }
                else if (this.fxSpotRateSourceIDRef != null)
                {
                    fxSpotRateSource = IDManager.getID(fxSpotRateSourceIDRef) as FxSpotRateSource;
                    return this.fxSpotRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxSpotRateSource != value)
                {
                    this.fxSpotRateSource = value;
                }
            }
        }
        #endregion
        
        public string FxSpotRateSourceIDRef { get; set; }
        #region VaryingNotionalInterimExchangePaymentDates
        private RelativeDateOffset varyingNotionalInterimExchangePaymentDates;
        public RelativeDateOffset VaryingNotionalInterimExchangePaymentDates
        {
            get
            {
                if (this.varyingNotionalInterimExchangePaymentDates != null)
                {
                    return this.varyingNotionalInterimExchangePaymentDates; 
                }
                else if (this.varyingNotionalInterimExchangePaymentDatesIDRef != null)
                {
                    varyingNotionalInterimExchangePaymentDates = IDManager.getID(varyingNotionalInterimExchangePaymentDatesIDRef) as RelativeDateOffset;
                    return this.varyingNotionalInterimExchangePaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varyingNotionalInterimExchangePaymentDates != value)
                {
                    this.varyingNotionalInterimExchangePaymentDates = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        
    
        
    
    }
    
}

