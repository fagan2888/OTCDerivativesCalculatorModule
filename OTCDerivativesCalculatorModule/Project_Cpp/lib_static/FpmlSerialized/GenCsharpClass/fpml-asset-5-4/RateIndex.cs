using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RateIndex
    {
        public RateIndex(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList floatingRateIndexNodeList = xmlNode.SelectNodes("floatingRateIndex");
            if (floatingRateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef = item.Attributes["id"].Name;
                        FloatingRateIndex ob = FloatingRateIndex();
                        IDManager.SetID(floatingRateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateIndex = new FloatingRateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList paymentFrequencyNodeList = xmlNode.SelectNodes("paymentFrequency");
            if (paymentFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(paymentFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentFrequency = new Period(item);
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
        
    
        #region FloatingRateIndex
        private FloatingRateIndex floatingRateIndex;
        public FloatingRateIndex FloatingRateIndex
        {
            get
            {
                if (this.floatingRateIndex != null)
                {
                    return this.floatingRateIndex; 
                }
                else if (this.floatingRateIndexIDRef != null)
                {
                    floatingRateIndex = IDManager.getID(floatingRateIndexIDRef) as FloatingRateIndex;
                    return this.floatingRateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateIndex != value)
                {
                    this.floatingRateIndex = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIndexIDRef { get; set; }
        #region Term
        private Period term;
        public Period Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as Period;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region PaymentFrequency
        private Period paymentFrequency;
        public Period PaymentFrequency
        {
            get
            {
                if (this.paymentFrequency != null)
                {
                    return this.paymentFrequency; 
                }
                else if (this.paymentFrequencyIDRef != null)
                {
                    paymentFrequency = IDManager.getID(paymentFrequencyIDRef) as Period;
                    return this.paymentFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentFrequency != value)
                {
                    this.paymentFrequency = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
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

