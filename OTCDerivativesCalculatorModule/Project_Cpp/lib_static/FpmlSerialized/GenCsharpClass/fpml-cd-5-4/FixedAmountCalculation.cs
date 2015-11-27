using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FixedAmountCalculation
    {
        public FixedAmountCalculation(XmlNode xmlNode)
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
                        CalculationAmount ob = CalculationAmount();
                        IDManager.SetID(calculationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAmount = new CalculationAmount(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        FixedRate ob = FixedRate();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new FixedRate(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            if (dayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(dayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationAmount
        private CalculationAmount calculationAmount;
        public CalculationAmount CalculationAmount
        {
            get
            {
                if (this.calculationAmount != null)
                {
                    return this.calculationAmount; 
                }
                else if (this.calculationAmountIDRef != null)
                {
                    calculationAmount = IDManager.getID(calculationAmountIDRef) as CalculationAmount;
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
        
        public string CalculationAmountIDRef { get; set; }
        #region FixedRate
        private FixedRate fixedRate;
        public FixedRate FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as FixedRate;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string FixedRateIDRef { get; set; }
        #region DayCountFraction
        private DayCountFraction dayCountFraction;
        public DayCountFraction DayCountFraction
        {
            get
            {
                if (this.dayCountFraction != null)
                {
                    return this.dayCountFraction; 
                }
                else if (this.dayCountFractionIDRef != null)
                {
                    dayCountFraction = IDManager.getID(dayCountFractionIDRef) as DayCountFraction;
                    return this.dayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountFraction != value)
                {
                    this.dayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        
    
        
    
    }
    
}

