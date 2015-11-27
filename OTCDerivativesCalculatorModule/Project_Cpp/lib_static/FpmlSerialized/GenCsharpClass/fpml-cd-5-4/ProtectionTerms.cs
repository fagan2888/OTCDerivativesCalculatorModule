using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ProtectionTerms
    {
        public ProtectionTerms(XmlNode xmlNode)
        {
            XmlNodeList calculationAmountNodeList = xmlNode.SelectNodes("calculationAmount");
            if (calculationAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(calculationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventsNodeList = xmlNode.SelectNodes("creditEvents");
            if (creditEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventsIDRef = item.Attributes["id"].Name;
                        CreditEvents ob = CreditEvents();
                        IDManager.SetID(creditEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEvents = new CreditEvents(item);
                    }
                }
            }
            
        
            XmlNodeList obligationsNodeList = xmlNode.SelectNodes("obligations");
            if (obligationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in obligationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        obligationsIDRef = item.Attributes["id"].Name;
                        Obligations ob = Obligations();
                        IDManager.SetID(obligationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligations = new Obligations(item);
                    }
                }
            }
            
        
            XmlNodeList floatingAmountEventsNodeList = xmlNode.SelectNodes("floatingAmountEvents");
            if (floatingAmountEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingAmountEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingAmountEventsIDRef = item.Attributes["id"].Name;
                        FloatingAmountEvents ob = FloatingAmountEvents();
                        IDManager.SetID(floatingAmountEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingAmountEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingAmountEvents = new FloatingAmountEvents(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationAmount
        private Money calculationAmount;
        public Money CalculationAmount
        {
            get
            {
                if (this.calculationAmount != null)
                {
                    return this.calculationAmount; 
                }
                else if (this.calculationAmountIDRef != null)
                {
                    calculationAmount = IDManager.getID(calculationAmountIDRef) as Money;
                    return this.calculationAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAmount != value)
                {
                    this.calculationAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region CreditEvents
        private CreditEvents creditEvents;
        public CreditEvents CreditEvents
        {
            get
            {
                if (this.creditEvents != null)
                {
                    return this.creditEvents; 
                }
                else if (this.creditEventsIDRef != null)
                {
                    creditEvents = IDManager.getID(creditEventsIDRef) as CreditEvents;
                    return this.creditEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEvents != value)
                {
                    this.creditEvents = value;
                }
            }
        }
        #endregion
        
        public string CreditEventsIDRef { get; set; }
        #region Obligations
        private Obligations obligations;
        public Obligations Obligations
        {
            get
            {
                if (this.obligations != null)
                {
                    return this.obligations; 
                }
                else if (this.obligationsIDRef != null)
                {
                    obligations = IDManager.getID(obligationsIDRef) as Obligations;
                    return this.obligations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.obligations != value)
                {
                    this.obligations = value;
                }
            }
        }
        #endregion
        
        public string ObligationsIDRef { get; set; }
        #region FloatingAmountEvents
        private FloatingAmountEvents floatingAmountEvents;
        public FloatingAmountEvents FloatingAmountEvents
        {
            get
            {
                if (this.floatingAmountEvents != null)
                {
                    return this.floatingAmountEvents; 
                }
                else if (this.floatingAmountEventsIDRef != null)
                {
                    floatingAmountEvents = IDManager.getID(floatingAmountEventsIDRef) as FloatingAmountEvents;
                    return this.floatingAmountEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingAmountEvents != value)
                {
                    this.floatingAmountEvents = value;
                }
            }
        }
        #endregion
        
        public string FloatingAmountEventsIDRef { get; set; }
        
    
        
    
    }
    
}

