using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestLeg
    {
        public InterestLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList interestLegCalculationPeriodDatesNodeList = xmlNode.SelectNodes("interestLegCalculationPeriodDates");
            if (interestLegCalculationPeriodDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestLegCalculationPeriodDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestLegCalculationPeriodDatesIDRef = item.Attributes["id"].Name;
                        InterestLegCalculationPeriodDates ob = InterestLegCalculationPeriodDates();
                        IDManager.SetID(interestLegCalculationPeriodDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestLegCalculationPeriodDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestLegCalculationPeriodDates = new InterestLegCalculationPeriodDates(item);
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            if (notionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalIDRef = item.Attributes["id"].Name;
                        ReturnSwapNotional ob = ReturnSwapNotional();
                        IDManager.SetID(notionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notional = new ReturnSwapNotional(item);
                    }
                }
            }
            
        
            XmlNodeList interestAmountNodeList = xmlNode.SelectNodes("interestAmount");
            if (interestAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestAmountIDRef = item.Attributes["id"].Name;
                        LegAmount ob = LegAmount();
                        IDManager.SetID(interestAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestAmount = new LegAmount(item);
                    }
                }
            }
            
        
            XmlNodeList interestCalculationNodeList = xmlNode.SelectNodes("interestCalculation");
            if (interestCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestCalculationIDRef = item.Attributes["id"].Name;
                        InterestCalculation ob = InterestCalculation();
                        IDManager.SetID(interestCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestCalculation = new InterestCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList stubCalculationPeriodNodeList = xmlNode.SelectNodes("stubCalculationPeriod");
            if (stubCalculationPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubCalculationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubCalculationPeriodIDRef = item.Attributes["id"].Name;
                        StubCalculationPeriod ob = StubCalculationPeriod();
                        IDManager.SetID(stubCalculationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubCalculationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubCalculationPeriod = new StubCalculationPeriod(item);
                    }
                }
            }
            
        
        }
        
    
        #region InterestLegCalculationPeriodDates
        private InterestLegCalculationPeriodDates interestLegCalculationPeriodDates;
        public InterestLegCalculationPeriodDates InterestLegCalculationPeriodDates
        {
            get
            {
                if (this.interestLegCalculationPeriodDates != null)
                {
                    return this.interestLegCalculationPeriodDates; 
                }
                else if (this.interestLegCalculationPeriodDatesIDRef != null)
                {
                    interestLegCalculationPeriodDates = IDManager.getID(interestLegCalculationPeriodDatesIDRef) as InterestLegCalculationPeriodDates;
                    return this.interestLegCalculationPeriodDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestLegCalculationPeriodDates != value)
                {
                    this.interestLegCalculationPeriodDates = value;
                }
            }
        }
        #endregion
        
        public string InterestLegCalculationPeriodDatesIDRef { get; set; }
        #region Notional
        private ReturnSwapNotional notional;
        public ReturnSwapNotional Notional
        {
            get
            {
                if (this.notional != null)
                {
                    return this.notional; 
                }
                else if (this.notionalIDRef != null)
                {
                    notional = IDManager.getID(notionalIDRef) as ReturnSwapNotional;
                    return this.notional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notional != value)
                {
                    this.notional = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapNotionalIDRef { get; set; }
        #region InterestAmount
        private LegAmount interestAmount;
        public LegAmount InterestAmount
        {
            get
            {
                if (this.interestAmount != null)
                {
                    return this.interestAmount; 
                }
                else if (this.interestAmountIDRef != null)
                {
                    interestAmount = IDManager.getID(interestAmountIDRef) as LegAmount;
                    return this.interestAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestAmount != value)
                {
                    this.interestAmount = value;
                }
            }
        }
        #endregion
        
        public string LegAmountIDRef { get; set; }
        #region InterestCalculation
        private InterestCalculation interestCalculation;
        public InterestCalculation InterestCalculation
        {
            get
            {
                if (this.interestCalculation != null)
                {
                    return this.interestCalculation; 
                }
                else if (this.interestCalculationIDRef != null)
                {
                    interestCalculation = IDManager.getID(interestCalculationIDRef) as InterestCalculation;
                    return this.interestCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestCalculation != value)
                {
                    this.interestCalculation = value;
                }
            }
        }
        #endregion
        
        public string InterestCalculationIDRef { get; set; }
        #region StubCalculationPeriod
        private StubCalculationPeriod stubCalculationPeriod;
        public StubCalculationPeriod StubCalculationPeriod
        {
            get
            {
                if (this.stubCalculationPeriod != null)
                {
                    return this.stubCalculationPeriod; 
                }
                else if (this.stubCalculationPeriodIDRef != null)
                {
                    stubCalculationPeriod = IDManager.getID(stubCalculationPeriodIDRef) as StubCalculationPeriod;
                    return this.stubCalculationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubCalculationPeriod != value)
                {
                    this.stubCalculationPeriod = value;
                }
            }
        }
        #endregion
        
        public string StubCalculationPeriodIDRef { get; set; }
        
    
        
    
    }
    
}

