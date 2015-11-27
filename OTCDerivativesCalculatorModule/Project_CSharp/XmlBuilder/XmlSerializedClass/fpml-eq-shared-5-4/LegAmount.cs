using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LegAmount : ISerialized
    {
        public LegAmount(XmlNode xmlNode)
        {
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        IdentifiedCurrency ob = new IdentifiedCurrency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new IdentifiedCurrency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new IdentifiedCurrency(currencyNode);
                }
            }
            
        
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode currencyReferenceNode = xmlNode.SelectSingleNode("currencyReference");
            
            if (currencyReferenceNode != null)
            {
                if (currencyReferenceNode.Attributes["href"] != null || currencyReferenceNode.Attributes["id"] != null) 
                {
                    if (currencyReferenceNode.Attributes["id"] != null) 
                    {
                        currencyReferenceIDRef_ = currencyReferenceNode.Attributes["id"].Value;
                        IdentifiedCurrencyReference ob = new IdentifiedCurrencyReference(currencyReferenceNode);
                        IDManager.SetID(currencyReferenceIDRef_, ob);
                    }
                    else if (currencyReferenceNode.Attributes["href"] != null)
                    {
                        currencyReferenceIDRef_ = currencyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currencyReference_ = new IdentifiedCurrencyReference(currencyReferenceNode);
                    }
                }
                else
                {
                    currencyReference_ = new IdentifiedCurrencyReference(currencyReferenceNode);
                }
            }
            
        
            XmlNode referenceAmountNode = xmlNode.SelectSingleNode("referenceAmount");
            
            if (referenceAmountNode != null)
            {
                if (referenceAmountNode.Attributes["href"] != null || referenceAmountNode.Attributes["id"] != null) 
                {
                    if (referenceAmountNode.Attributes["id"] != null) 
                    {
                        referenceAmountIDRef_ = referenceAmountNode.Attributes["id"].Value;
                        ReferenceAmount ob = new ReferenceAmount(referenceAmountNode);
                        IDManager.SetID(referenceAmountIDRef_, ob);
                    }
                    else if (referenceAmountNode.Attributes["href"] != null)
                    {
                        referenceAmountIDRef_ = referenceAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceAmount_ = new ReferenceAmount(referenceAmountNode);
                    }
                }
                else
                {
                    referenceAmount_ = new ReferenceAmount(referenceAmountNode);
                }
            }
            
        
            XmlNode formulaNode = xmlNode.SelectSingleNode("formula");
            
            if (formulaNode != null)
            {
                if (formulaNode.Attributes["href"] != null || formulaNode.Attributes["id"] != null) 
                {
                    if (formulaNode.Attributes["id"] != null) 
                    {
                        formulaIDRef_ = formulaNode.Attributes["id"].Value;
                        Formula ob = new Formula(formulaNode);
                        IDManager.SetID(formulaIDRef_, ob);
                    }
                    else if (formulaNode.Attributes["href"] != null)
                    {
                        formulaIDRef_ = formulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formula_ = new Formula(formulaNode);
                    }
                }
                else
                {
                    formula_ = new Formula(formulaNode);
                }
            }
            
        
            XmlNode encodedDescriptionNode = xmlNode.SelectSingleNode("encodedDescription");
            
            if (encodedDescriptionNode != null)
            {
                if (encodedDescriptionNode.Attributes["href"] != null || encodedDescriptionNode.Attributes["id"] != null) 
                {
                    if (encodedDescriptionNode.Attributes["id"] != null) 
                    {
                        encodedDescriptionIDRef_ = encodedDescriptionNode.Attributes["id"].Value;
                        XsdTypeBase64Binary ob = new XsdTypeBase64Binary(encodedDescriptionNode);
                        IDManager.SetID(encodedDescriptionIDRef_, ob);
                    }
                    else if (encodedDescriptionNode.Attributes["href"] != null)
                    {
                        encodedDescriptionIDRef_ = encodedDescriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        encodedDescription_ = new XsdTypeBase64Binary(encodedDescriptionNode);
                    }
                }
                else
                {
                    encodedDescription_ = new XsdTypeBase64Binary(encodedDescriptionNode);
                }
            }
            
        
            XmlNode calculationDatesNode = xmlNode.SelectSingleNode("calculationDates");
            
            if (calculationDatesNode != null)
            {
                if (calculationDatesNode.Attributes["href"] != null || calculationDatesNode.Attributes["id"] != null) 
                {
                    if (calculationDatesNode.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates ob = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                        IDManager.SetID(calculationDatesIDRef_, ob);
                    }
                    else if (calculationDatesNode.Attributes["href"] != null)
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDates_ = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                    }
                }
                else
                {
                    calculationDates_ = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                }
            }
            
        
        }
        
    
        #region Currency_
        private IdentifiedCurrency currency_;
        public IdentifiedCurrency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as IdentifiedCurrency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region CurrencyReference_
        private IdentifiedCurrencyReference currencyReference_;
        public IdentifiedCurrencyReference CurrencyReference_
        {
            get
            {
                if (this.currencyReference_ != null)
                {
                    return this.currencyReference_; 
                }
                else if (this.currencyReferenceIDRef_ != null)
                {
                    currencyReference_ = IDManager.getID(currencyReferenceIDRef_) as IdentifiedCurrencyReference;
                    return this.currencyReference_; 
                }
                else
                {
                      return this.currencyReference_; 
                }
            }
            set
            {
                if (this.currencyReference_ != value)
                {
                    this.currencyReference_ = value;
                }
            }
        }
        #endregion
        
        public string currencyReferenceIDRef_ { get; set; }
        #region ReferenceAmount_
        private ReferenceAmount referenceAmount_;
        public ReferenceAmount ReferenceAmount_
        {
            get
            {
                if (this.referenceAmount_ != null)
                {
                    return this.referenceAmount_; 
                }
                else if (this.referenceAmountIDRef_ != null)
                {
                    referenceAmount_ = IDManager.getID(referenceAmountIDRef_) as ReferenceAmount;
                    return this.referenceAmount_; 
                }
                else
                {
                      return this.referenceAmount_; 
                }
            }
            set
            {
                if (this.referenceAmount_ != value)
                {
                    this.referenceAmount_ = value;
                }
            }
        }
        #endregion
        
        public string referenceAmountIDRef_ { get; set; }
        #region Formula_
        private Formula formula_;
        public Formula Formula_
        {
            get
            {
                if (this.formula_ != null)
                {
                    return this.formula_; 
                }
                else if (this.formulaIDRef_ != null)
                {
                    formula_ = IDManager.getID(formulaIDRef_) as Formula;
                    return this.formula_; 
                }
                else
                {
                      return this.formula_; 
                }
            }
            set
            {
                if (this.formula_ != value)
                {
                    this.formula_ = value;
                }
            }
        }
        #endregion
        
        public string formulaIDRef_ { get; set; }
        #region EncodedDescription_
        private XsdTypeBase64Binary encodedDescription_;
        public XsdTypeBase64Binary EncodedDescription_
        {
            get
            {
                if (this.encodedDescription_ != null)
                {
                    return this.encodedDescription_; 
                }
                else if (this.encodedDescriptionIDRef_ != null)
                {
                    encodedDescription_ = IDManager.getID(encodedDescriptionIDRef_) as XsdTypeBase64Binary;
                    return this.encodedDescription_; 
                }
                else
                {
                      return this.encodedDescription_; 
                }
            }
            set
            {
                if (this.encodedDescription_ != value)
                {
                    this.encodedDescription_ = value;
                }
            }
        }
        #endregion
        
        public string encodedDescriptionIDRef_ { get; set; }
        #region CalculationDates_
        private AdjustableRelativeOrPeriodicDates calculationDates_;
        public AdjustableRelativeOrPeriodicDates CalculationDates_
        {
            get
            {
                if (this.calculationDates_ != null)
                {
                    return this.calculationDates_; 
                }
                else if (this.calculationDatesIDRef_ != null)
                {
                    calculationDates_ = IDManager.getID(calculationDatesIDRef_) as AdjustableRelativeOrPeriodicDates;
                    return this.calculationDates_; 
                }
                else
                {
                      return this.calculationDates_; 
                }
            }
            set
            {
                if (this.calculationDates_ != value)
                {
                    this.calculationDates_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

