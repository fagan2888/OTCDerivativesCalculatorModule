using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingRateDefinition
    {
        public FloatingRateDefinition(XmlNode xmlNode)
        {
            XmlNodeList calculatedRateNodeList = xmlNode.SelectNodes("calculatedRate");
            if (calculatedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculatedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculatedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(calculatedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculatedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculatedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList rateObservationNodeList = xmlNode.SelectNodes("rateObservation");
            
            foreach (XmlNode item in rateObservationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateObservationIDRef = item.Attributes["id"].Name;
                        List<RateObservation> ob = new List<RateObservation>();
                        ob.Add(new RateObservation(item));
                        IDManager.SetID(rateObservationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateObservationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    rateObservation.Add(new RateObservation(item));
                    }
                }
            }
            
        
            XmlNodeList floatingRateMultiplierNodeList = xmlNode.SelectNodes("floatingRateMultiplier");
            if (floatingRateMultiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateMultiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateMultiplierIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(floatingRateMultiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateMultiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateMultiplier = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList spreadNodeList = xmlNode.SelectNodes("spread");
            if (spreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spread = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList capRateNodeList = xmlNode.SelectNodes("capRate");
            
            foreach (XmlNode item in capRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        capRateIDRef = item.Attributes["id"].Name;
                        List<Strike> ob = new List<Strike>();
                        ob.Add(new Strike(item));
                        IDManager.SetID(capRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        capRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    capRate.Add(new Strike(item));
                    }
                }
            }
            
        
            XmlNodeList floorRateNodeList = xmlNode.SelectNodes("floorRate");
            
            foreach (XmlNode item in floorRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floorRateIDRef = item.Attributes["id"].Name;
                        List<Strike> ob = new List<Strike>();
                        ob.Add(new Strike(item));
                        IDManager.SetID(floorRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floorRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    floorRate.Add(new Strike(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculatedRate
        private XsdTypeDecimal calculatedRate;
        public XsdTypeDecimal CalculatedRate
        {
            get
            {
                if (this.calculatedRate != null)
                {
                    return this.calculatedRate; 
                }
                else if (this.calculatedRateIDRef != null)
                {
                    calculatedRate = IDManager.getID(calculatedRateIDRef) as XsdTypeDecimal;
                    return this.calculatedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculatedRate != value)
                {
                    this.calculatedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RateObservation
        private List<RateObservation> rateObservation;
        public List<RateObservation> RateObservation
        {
            get
            {
                if (this.rateObservation != null)
                {
                    return this.rateObservation; 
                }
                else if (this.rateObservationIDRef != null)
                {
                    rateObservation = IDManager.getID(rateObservationIDRef) as List<RateObservation>;
                    return this.rateObservation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateObservation != value)
                {
                    this.rateObservation = value;
                }
            }
        }
        #endregion
        
        public string RateObservationIDRef { get; set; }
        #region FloatingRateMultiplier
        private XsdTypeDecimal floatingRateMultiplier;
        public XsdTypeDecimal FloatingRateMultiplier
        {
            get
            {
                if (this.floatingRateMultiplier != null)
                {
                    return this.floatingRateMultiplier; 
                }
                else if (this.floatingRateMultiplierIDRef != null)
                {
                    floatingRateMultiplier = IDManager.getID(floatingRateMultiplierIDRef) as XsdTypeDecimal;
                    return this.floatingRateMultiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateMultiplier != value)
                {
                    this.floatingRateMultiplier = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Spread
        private XsdTypeDecimal spread;
        public XsdTypeDecimal Spread
        {
            get
            {
                if (this.spread != null)
                {
                    return this.spread; 
                }
                else if (this.spreadIDRef != null)
                {
                    spread = IDManager.getID(spreadIDRef) as XsdTypeDecimal;
                    return this.spread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spread != value)
                {
                    this.spread = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region CapRate
        private List<Strike> capRate;
        public List<Strike> CapRate
        {
            get
            {
                if (this.capRate != null)
                {
                    return this.capRate; 
                }
                else if (this.capRateIDRef != null)
                {
                    capRate = IDManager.getID(capRateIDRef) as List<Strike>;
                    return this.capRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.capRate != value)
                {
                    this.capRate = value;
                }
            }
        }
        #endregion
        
        public string StrikeIDRef { get; set; }
        #region FloorRate
        private List<Strike> floorRate;
        public List<Strike> FloorRate
        {
            get
            {
                if (this.floorRate != null)
                {
                    return this.floorRate; 
                }
                else if (this.floorRateIDRef != null)
                {
                    floorRate = IDManager.getID(floorRateIDRef) as List<Strike>;
                    return this.floorRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floorRate != value)
                {
                    this.floorRate = value;
                }
            }
        }
        #endregion
        
        public string StrikeIDRef { get; set; }
        
    
        
    
    }
    
}

