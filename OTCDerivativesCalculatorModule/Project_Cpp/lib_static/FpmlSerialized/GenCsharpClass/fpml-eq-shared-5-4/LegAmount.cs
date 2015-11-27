using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LegAmount
    {
        public LegAmount(XmlNode xmlNode)
        {
            XmlNodeList currencyNodeList = xmlNode.SelectNodes("currency");
            if (currencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrency ob = IdentifiedCurrency();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new IdentifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList currencyReferenceNodeList = xmlNode.SelectNodes("currencyReference");
            if (currencyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyReferenceIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrencyReference ob = IdentifiedCurrencyReference();
                        IDManager.SetID(currencyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currencyReference = new IdentifiedCurrencyReference(item);
                    }
                }
            }
            
        
            XmlNodeList referenceAmountNodeList = xmlNode.SelectNodes("referenceAmount");
            if (referenceAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceAmountIDRef = item.Attributes["id"].Name;
                        ReferenceAmount ob = ReferenceAmount();
                        IDManager.SetID(referenceAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceAmount = new ReferenceAmount(item);
                    }
                }
            }
            
        
            XmlNodeList formulaNodeList = xmlNode.SelectNodes("formula");
            if (formulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaIDRef = item.Attributes["id"].Name;
                        Formula ob = Formula();
                        IDManager.SetID(formulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formula = new Formula(item);
                    }
                }
            }
            
        
            XmlNodeList encodedDescriptionNodeList = xmlNode.SelectNodes("encodedDescription");
            if (encodedDescriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in encodedDescriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        encodedDescriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeBase64Binary ob = XsdTypeBase64Binary();
                        IDManager.SetID(encodedDescriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        encodedDescriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        encodedDescription = new XsdTypeBase64Binary(item);
                    }
                }
            }
            
        
            XmlNodeList calculationDatesNodeList = xmlNode.SelectNodes("calculationDates");
            if (calculationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates ob = AdjustableRelativeOrPeriodicDates();
                        IDManager.SetID(calculationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationDates = new AdjustableRelativeOrPeriodicDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region Currency
        private IdentifiedCurrency currency;
        public IdentifiedCurrency Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as IdentifiedCurrency;
                    return this.currency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyIDRef { get; set; }
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region CurrencyReference
        private IdentifiedCurrencyReference currencyReference;
        public IdentifiedCurrencyReference CurrencyReference
        {
            get
            {
                if (this.currencyReference != null)
                {
                    return this.currencyReference; 
                }
                else if (this.currencyReferenceIDRef != null)
                {
                    currencyReference = IDManager.getID(currencyReferenceIDRef) as IdentifiedCurrencyReference;
                    return this.currencyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currencyReference != value)
                {
                    this.currencyReference = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyReferenceIDRef { get; set; }
        #region ReferenceAmount
        private ReferenceAmount referenceAmount;
        public ReferenceAmount ReferenceAmount
        {
            get
            {
                if (this.referenceAmount != null)
                {
                    return this.referenceAmount; 
                }
                else if (this.referenceAmountIDRef != null)
                {
                    referenceAmount = IDManager.getID(referenceAmountIDRef) as ReferenceAmount;
                    return this.referenceAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceAmount != value)
                {
                    this.referenceAmount = value;
                }
            }
        }
        #endregion
        
        public string ReferenceAmountIDRef { get; set; }
        #region Formula
        private Formula formula;
        public Formula Formula
        {
            get
            {
                if (this.formula != null)
                {
                    return this.formula; 
                }
                else if (this.formulaIDRef != null)
                {
                    formula = IDManager.getID(formulaIDRef) as Formula;
                    return this.formula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                }
            }
        }
        #endregion
        
        public string FormulaIDRef { get; set; }
        #region EncodedDescription
        private XsdTypeBase64Binary encodedDescription;
        public XsdTypeBase64Binary EncodedDescription
        {
            get
            {
                if (this.encodedDescription != null)
                {
                    return this.encodedDescription; 
                }
                else if (this.encodedDescriptionIDRef != null)
                {
                    encodedDescription = IDManager.getID(encodedDescriptionIDRef) as XsdTypeBase64Binary;
                    return this.encodedDescription; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.encodedDescription != value)
                {
                    this.encodedDescription = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBase64BinaryIDRef { get; set; }
        #region CalculationDates
        private AdjustableRelativeOrPeriodicDates calculationDates;
        public AdjustableRelativeOrPeriodicDates CalculationDates
        {
            get
            {
                if (this.calculationDates != null)
                {
                    return this.calculationDates; 
                }
                else if (this.calculationDatesIDRef != null)
                {
                    calculationDates = IDManager.getID(calculationDatesIDRef) as AdjustableRelativeOrPeriodicDates;
                    return this.calculationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationDates != value)
                {
                    this.calculationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDatesIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

