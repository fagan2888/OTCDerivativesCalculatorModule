using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodAmount
    {
        public CalculationPeriodAmount(XmlNode xmlNode)
        {
            XmlNodeList calculationNodeList = xmlNode.SelectNodes("calculation");
            if (calculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationIDRef = item.Attributes["id"].Name;
                        Calculation ob = Calculation();
                        IDManager.SetID(calculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculation = new Calculation(item);
                    }
                }
            }
            
        
            XmlNodeList knownAmountScheduleNodeList = xmlNode.SelectNodes("knownAmountSchedule");
            if (knownAmountScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in knownAmountScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        knownAmountScheduleIDRef = item.Attributes["id"].Name;
                        AmountSchedule ob = AmountSchedule();
                        IDManager.SetID(knownAmountScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        knownAmountScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        knownAmountSchedule = new AmountSchedule(item);
                    }
                }
            }
            
        
        }
        
    
        #region Calculation
        private Calculation calculation;
        public Calculation Calculation
        {
            get
            {
                if (this.calculation != null)
                {
                    return this.calculation; 
                }
                else if (this.calculationIDRef != null)
                {
                    calculation = IDManager.getID(calculationIDRef) as Calculation;
                    return this.calculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculation != value)
                {
                    this.calculation = value;
                }
            }
        }
        #endregion
        
        public string CalculationIDRef { get; set; }
        #region KnownAmountSchedule
        private AmountSchedule knownAmountSchedule;
        public AmountSchedule KnownAmountSchedule
        {
            get
            {
                if (this.knownAmountSchedule != null)
                {
                    return this.knownAmountSchedule; 
                }
                else if (this.knownAmountScheduleIDRef != null)
                {
                    knownAmountSchedule = IDManager.getID(knownAmountScheduleIDRef) as AmountSchedule;
                    return this.knownAmountSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.knownAmountSchedule != value)
                {
                    this.knownAmountSchedule = value;
                }
            }
        }
        #endregion
        
        public string AmountScheduleIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

