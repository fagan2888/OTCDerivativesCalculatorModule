using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MandatoryEarlyTermination
    {
        public MandatoryEarlyTermination(XmlNode xmlNode)
        {
            XmlNodeList mandatoryEarlyTerminationDateNodeList = xmlNode.SelectNodes("mandatoryEarlyTerminationDate");
            if (mandatoryEarlyTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mandatoryEarlyTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(mandatoryEarlyTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mandatoryEarlyTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mandatoryEarlyTerminationDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationAgentNodeList = xmlNode.SelectNodes("calculationAgent");
            if (calculationAgentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationAgentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAgentIDRef = item.Attributes["id"].Name;
                        CalculationAgent ob = CalculationAgent();
                        IDManager.SetID(calculationAgentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAgentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAgent = new CalculationAgent(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementNodeList = xmlNode.SelectNodes("cashSettlement");
            if (cashSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef = item.Attributes["id"].Name;
                        CashSettlement ob = CashSettlement();
                        IDManager.SetID(cashSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlement = new CashSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList mandatoryEarlyTerminationAdjustedDatesNodeList = xmlNode.SelectNodes("mandatoryEarlyTerminationAdjustedDates");
            if (mandatoryEarlyTerminationAdjustedDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mandatoryEarlyTerminationAdjustedDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationAdjustedDatesIDRef = item.Attributes["id"].Name;
                        MandatoryEarlyTerminationAdjustedDates ob = MandatoryEarlyTerminationAdjustedDates();
                        IDManager.SetID(mandatoryEarlyTerminationAdjustedDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mandatoryEarlyTerminationAdjustedDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mandatoryEarlyTerminationAdjustedDates = new MandatoryEarlyTerminationAdjustedDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region MandatoryEarlyTerminationDate
        private AdjustableDate mandatoryEarlyTerminationDate;
        public AdjustableDate MandatoryEarlyTerminationDate
        {
            get
            {
                if (this.mandatoryEarlyTerminationDate != null)
                {
                    return this.mandatoryEarlyTerminationDate; 
                }
                else if (this.mandatoryEarlyTerminationDateIDRef != null)
                {
                    mandatoryEarlyTerminationDate = IDManager.getID(mandatoryEarlyTerminationDateIDRef) as AdjustableDate;
                    return this.mandatoryEarlyTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationDate != value)
                {
                    this.mandatoryEarlyTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region CalculationAgent
        private CalculationAgent calculationAgent;
        public CalculationAgent CalculationAgent
        {
            get
            {
                if (this.calculationAgent != null)
                {
                    return this.calculationAgent; 
                }
                else if (this.calculationAgentIDRef != null)
                {
                    calculationAgent = IDManager.getID(calculationAgentIDRef) as CalculationAgent;
                    return this.calculationAgent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAgent != value)
                {
                    this.calculationAgent = value;
                }
            }
        }
        #endregion
        
        public string CalculationAgentIDRef { get; set; }
        #region CashSettlement
        private CashSettlement cashSettlement;
        public CashSettlement CashSettlement
        {
            get
            {
                if (this.cashSettlement != null)
                {
                    return this.cashSettlement; 
                }
                else if (this.cashSettlementIDRef != null)
                {
                    cashSettlement = IDManager.getID(cashSettlementIDRef) as CashSettlement;
                    return this.cashSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlement != value)
                {
                    this.cashSettlement = value;
                }
            }
        }
        #endregion
        
        public string CashSettlementIDRef { get; set; }
        #region MandatoryEarlyTerminationAdjustedDates
        private MandatoryEarlyTerminationAdjustedDates mandatoryEarlyTerminationAdjustedDates;
        public MandatoryEarlyTerminationAdjustedDates MandatoryEarlyTerminationAdjustedDates
        {
            get
            {
                if (this.mandatoryEarlyTerminationAdjustedDates != null)
                {
                    return this.mandatoryEarlyTerminationAdjustedDates; 
                }
                else if (this.mandatoryEarlyTerminationAdjustedDatesIDRef != null)
                {
                    mandatoryEarlyTerminationAdjustedDates = IDManager.getID(mandatoryEarlyTerminationAdjustedDatesIDRef) as MandatoryEarlyTerminationAdjustedDates;
                    return this.mandatoryEarlyTerminationAdjustedDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationAdjustedDates != value)
                {
                    this.mandatoryEarlyTerminationAdjustedDates = value;
                }
            }
        }
        #endregion
        
        public string MandatoryEarlyTerminationAdjustedDatesIDRef { get; set; }
        
    
        
    
    }
    
}

