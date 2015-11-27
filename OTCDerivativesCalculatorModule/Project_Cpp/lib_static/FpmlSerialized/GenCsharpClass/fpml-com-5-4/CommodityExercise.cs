using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityExercise
    {
        public CommodityExercise(XmlNode xmlNode)
        {
            XmlNodeList americanExerciseNodeList = xmlNode.SelectNodes("americanExercise");
            if (americanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in americanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef = item.Attributes["id"].Name;
                        CommodityAmericanExercise ob = CommodityAmericanExercise();
                        IDManager.SetID(americanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        americanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        americanExercise = new CommodityAmericanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList europeanExerciseNodeList = xmlNode.SelectNodes("europeanExercise");
            if (europeanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in europeanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef = item.Attributes["id"].Name;
                        CommodityEuropeanExercise ob = CommodityEuropeanExercise();
                        IDManager.SetID(europeanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        europeanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        europeanExercise = new CommodityEuropeanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList automaticExerciseNodeList = xmlNode.SelectNodes("automaticExercise");
            if (automaticExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in automaticExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(automaticExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        automaticExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        automaticExercise = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList writtenConfirmationNodeList = xmlNode.SelectNodes("writtenConfirmation");
            if (writtenConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in writtenConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        writtenConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(writtenConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        writtenConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        writtenConfirmation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            if (settlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrency ob = IdentifiedCurrency();
                        IDManager.SetID(settlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrency = new IdentifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList fxNodeList = xmlNode.SelectNodes("fx");
            if (fxNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxIDRef = item.Attributes["id"].Name;
                        CommodityFx ob = CommodityFx();
                        IDManager.SetID(fxIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fx = new CommodityFx(item);
                    }
                }
            }
            
        
            XmlNodeList conversionFactorNodeList = xmlNode.SelectNodes("conversionFactor");
            if (conversionFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in conversionFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(conversionFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        conversionFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        conversionFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList relativePaymentDatesNodeList = xmlNode.SelectNodes("relativePaymentDates");
            if (relativePaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativePaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativePaymentDates ob = CommodityRelativePaymentDates();
                        IDManager.SetID(relativePaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativePaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativePaymentDates = new CommodityRelativePaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        AdjustableDatesOrRelativeDateOffset ob = AdjustableDatesOrRelativeDateOffset();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new AdjustableDatesOrRelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList masterAgreementPaymentDatesNodeList = xmlNode.SelectNodes("masterAgreementPaymentDates");
            if (masterAgreementPaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(masterAgreementPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementPaymentDates = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region AmericanExercise
        private CommodityAmericanExercise americanExercise;
        public CommodityAmericanExercise AmericanExercise
        {
            get
            {
                if (this.americanExercise != null)
                {
                    return this.americanExercise; 
                }
                else if (this.americanExerciseIDRef != null)
                {
                    americanExercise = IDManager.getID(americanExerciseIDRef) as CommodityAmericanExercise;
                    return this.americanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.americanExercise != value)
                {
                    this.americanExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityAmericanExerciseIDRef { get; set; }
        #region EuropeanExercise
        private CommodityEuropeanExercise europeanExercise;
        public CommodityEuropeanExercise EuropeanExercise
        {
            get
            {
                if (this.europeanExercise != null)
                {
                    return this.europeanExercise; 
                }
                else if (this.europeanExerciseIDRef != null)
                {
                    europeanExercise = IDManager.getID(europeanExerciseIDRef) as CommodityEuropeanExercise;
                    return this.europeanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.europeanExercise != value)
                {
                    this.europeanExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityEuropeanExerciseIDRef { get; set; }
        #region AutomaticExercise
        private XsdTypeBoolean automaticExercise;
        public XsdTypeBoolean AutomaticExercise
        {
            get
            {
                if (this.automaticExercise != null)
                {
                    return this.automaticExercise; 
                }
                else if (this.automaticExerciseIDRef != null)
                {
                    automaticExercise = IDManager.getID(automaticExerciseIDRef) as XsdTypeBoolean;
                    return this.automaticExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.automaticExercise != value)
                {
                    this.automaticExercise = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region WrittenConfirmation
        private XsdTypeBoolean writtenConfirmation;
        public XsdTypeBoolean WrittenConfirmation
        {
            get
            {
                if (this.writtenConfirmation != null)
                {
                    return this.writtenConfirmation; 
                }
                else if (this.writtenConfirmationIDRef != null)
                {
                    writtenConfirmation = IDManager.getID(writtenConfirmationIDRef) as XsdTypeBoolean;
                    return this.writtenConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.writtenConfirmation != value)
                {
                    this.writtenConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SettlementCurrency
        private IdentifiedCurrency settlementCurrency;
        public IdentifiedCurrency SettlementCurrency
        {
            get
            {
                if (this.settlementCurrency != null)
                {
                    return this.settlementCurrency; 
                }
                else if (this.settlementCurrencyIDRef != null)
                {
                    settlementCurrency = IDManager.getID(settlementCurrencyIDRef) as IdentifiedCurrency;
                    return this.settlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrency != value)
                {
                    this.settlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyIDRef { get; set; }
        #region Fx
        private CommodityFx fx;
        public CommodityFx Fx
        {
            get
            {
                if (this.fx != null)
                {
                    return this.fx; 
                }
                else if (this.fxIDRef != null)
                {
                    fx = IDManager.getID(fxIDRef) as CommodityFx;
                    return this.fx; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fx != value)
                {
                    this.fx = value;
                }
            }
        }
        #endregion
        
        public string CommodityFxIDRef { get; set; }
        #region ConversionFactor
        private XsdTypeDecimal conversionFactor;
        public XsdTypeDecimal ConversionFactor
        {
            get
            {
                if (this.conversionFactor != null)
                {
                    return this.conversionFactor; 
                }
                else if (this.conversionFactorIDRef != null)
                {
                    conversionFactor = IDManager.getID(conversionFactorIDRef) as XsdTypeDecimal;
                    return this.conversionFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.conversionFactor != value)
                {
                    this.conversionFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RelativePaymentDates
        private CommodityRelativePaymentDates relativePaymentDates;
        public CommodityRelativePaymentDates RelativePaymentDates
        {
            get
            {
                if (this.relativePaymentDates != null)
                {
                    return this.relativePaymentDates; 
                }
                else if (this.relativePaymentDatesIDRef != null)
                {
                    relativePaymentDates = IDManager.getID(relativePaymentDatesIDRef) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativePaymentDates != value)
                {
                    this.relativePaymentDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativePaymentDatesIDRef { get; set; }
        #region PaymentDates
        private AdjustableDatesOrRelativeDateOffset paymentDates;
        public AdjustableDatesOrRelativeDateOffset PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesOrRelativeDateOffsetIDRef { get; set; }
        #region MasterAgreementPaymentDates
        private XsdTypeBoolean masterAgreementPaymentDates;
        public XsdTypeBoolean MasterAgreementPaymentDates
        {
            get
            {
                if (this.masterAgreementPaymentDates != null)
                {
                    return this.masterAgreementPaymentDates; 
                }
                else if (this.masterAgreementPaymentDatesIDRef != null)
                {
                    masterAgreementPaymentDates = IDManager.getID(masterAgreementPaymentDatesIDRef) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates != value)
                {
                    this.masterAgreementPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

