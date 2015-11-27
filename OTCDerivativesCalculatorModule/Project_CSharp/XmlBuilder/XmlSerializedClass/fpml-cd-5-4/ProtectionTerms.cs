using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProtectionTerms : ISerialized
    {
        public ProtectionTerms(XmlNode xmlNode)
        {
            XmlNode calculationAmountNode = xmlNode.SelectSingleNode("calculationAmount");
            
            if (calculationAmountNode != null)
            {
                if (calculationAmountNode.Attributes["href"] != null || calculationAmountNode.Attributes["id"] != null) 
                {
                    if (calculationAmountNode.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["id"].Value;
                        Money ob = new Money(calculationAmountNode);
                        IDManager.SetID(calculationAmountIDRef_, ob);
                    }
                    else if (calculationAmountNode.Attributes["href"] != null)
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAmount_ = new Money(calculationAmountNode);
                    }
                }
                else
                {
                    calculationAmount_ = new Money(calculationAmountNode);
                }
            }
            
        
            XmlNode creditEventsNode = xmlNode.SelectSingleNode("creditEvents");
            
            if (creditEventsNode != null)
            {
                if (creditEventsNode.Attributes["href"] != null || creditEventsNode.Attributes["id"] != null) 
                {
                    if (creditEventsNode.Attributes["id"] != null) 
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["id"].Value;
                        CreditEvents ob = new CreditEvents(creditEventsNode);
                        IDManager.SetID(creditEventsIDRef_, ob);
                    }
                    else if (creditEventsNode.Attributes["href"] != null)
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvents_ = new CreditEvents(creditEventsNode);
                    }
                }
                else
                {
                    creditEvents_ = new CreditEvents(creditEventsNode);
                }
            }
            
        
            XmlNode obligationsNode = xmlNode.SelectSingleNode("obligations");
            
            if (obligationsNode != null)
            {
                if (obligationsNode.Attributes["href"] != null || obligationsNode.Attributes["id"] != null) 
                {
                    if (obligationsNode.Attributes["id"] != null) 
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["id"].Value;
                        Obligations ob = new Obligations(obligationsNode);
                        IDManager.SetID(obligationsIDRef_, ob);
                    }
                    else if (obligationsNode.Attributes["href"] != null)
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligations_ = new Obligations(obligationsNode);
                    }
                }
                else
                {
                    obligations_ = new Obligations(obligationsNode);
                }
            }
            
        
            XmlNode floatingAmountEventsNode = xmlNode.SelectSingleNode("floatingAmountEvents");
            
            if (floatingAmountEventsNode != null)
            {
                if (floatingAmountEventsNode.Attributes["href"] != null || floatingAmountEventsNode.Attributes["id"] != null) 
                {
                    if (floatingAmountEventsNode.Attributes["id"] != null) 
                    {
                        floatingAmountEventsIDRef_ = floatingAmountEventsNode.Attributes["id"].Value;
                        FloatingAmountEvents ob = new FloatingAmountEvents(floatingAmountEventsNode);
                        IDManager.SetID(floatingAmountEventsIDRef_, ob);
                    }
                    else if (floatingAmountEventsNode.Attributes["href"] != null)
                    {
                        floatingAmountEventsIDRef_ = floatingAmountEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingAmountEvents_ = new FloatingAmountEvents(floatingAmountEventsNode);
                    }
                }
                else
                {
                    floatingAmountEvents_ = new FloatingAmountEvents(floatingAmountEventsNode);
                }
            }
            
        
        }
        
    
        #region CalculationAmount_
        private Money calculationAmount_;
        public Money CalculationAmount_
        {
            get
            {
                if (this.calculationAmount_ != null)
                {
                    return this.calculationAmount_; 
                }
                else if (this.calculationAmountIDRef_ != null)
                {
                    calculationAmount_ = IDManager.getID(calculationAmountIDRef_) as Money;
                    return this.calculationAmount_; 
                }
                else
                {
                      return this.calculationAmount_; 
                }
            }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAmountIDRef_ { get; set; }
        #region CreditEvents_
        private CreditEvents creditEvents_;
        public CreditEvents CreditEvents_
        {
            get
            {
                if (this.creditEvents_ != null)
                {
                    return this.creditEvents_; 
                }
                else if (this.creditEventsIDRef_ != null)
                {
                    creditEvents_ = IDManager.getID(creditEventsIDRef_) as CreditEvents;
                    return this.creditEvents_; 
                }
                else
                {
                      return this.creditEvents_; 
                }
            }
            set
            {
                if (this.creditEvents_ != value)
                {
                    this.creditEvents_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventsIDRef_ { get; set; }
        #region Obligations_
        private Obligations obligations_;
        public Obligations Obligations_
        {
            get
            {
                if (this.obligations_ != null)
                {
                    return this.obligations_; 
                }
                else if (this.obligationsIDRef_ != null)
                {
                    obligations_ = IDManager.getID(obligationsIDRef_) as Obligations;
                    return this.obligations_; 
                }
                else
                {
                      return this.obligations_; 
                }
            }
            set
            {
                if (this.obligations_ != value)
                {
                    this.obligations_ = value;
                }
            }
        }
        #endregion
        
        public string obligationsIDRef_ { get; set; }
        #region FloatingAmountEvents_
        private FloatingAmountEvents floatingAmountEvents_;
        public FloatingAmountEvents FloatingAmountEvents_
        {
            get
            {
                if (this.floatingAmountEvents_ != null)
                {
                    return this.floatingAmountEvents_; 
                }
                else if (this.floatingAmountEventsIDRef_ != null)
                {
                    floatingAmountEvents_ = IDManager.getID(floatingAmountEventsIDRef_) as FloatingAmountEvents;
                    return this.floatingAmountEvents_; 
                }
                else
                {
                      return this.floatingAmountEvents_; 
                }
            }
            set
            {
                if (this.floatingAmountEvents_ != value)
                {
                    this.floatingAmountEvents_ = value;
                }
            }
        }
        #endregion
        
        public string floatingAmountEventsIDRef_ { get; set; }
        
    
        
    
    }
    
}

