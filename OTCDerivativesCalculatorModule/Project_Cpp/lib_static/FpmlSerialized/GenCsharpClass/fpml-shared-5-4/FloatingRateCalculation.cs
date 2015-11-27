using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingRateCalculation
    {
        public FloatingRateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList initialRateNodeList = xmlNode.SelectNodes("initialRate");
            if (initialRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList finalRateRoundingNodeList = xmlNode.SelectNodes("finalRateRounding");
            if (finalRateRoundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in finalRateRoundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        finalRateRoundingIDRef = item.Attributes["id"].Name;
                        Rounding ob = Rounding();
                        IDManager.SetID(finalRateRoundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finalRateRoundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finalRateRounding = new Rounding(item);
                    }
                }
            }
            
        
            XmlNodeList averagingMethodNodeList = xmlNode.SelectNodes("averagingMethod");
            if (averagingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef = item.Attributes["id"].Name;
                        AveragingMethodEnum ob = AveragingMethodEnum();
                        IDManager.SetID(averagingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingMethod = new AveragingMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList negativeInterestRateTreatmentNodeList = xmlNode.SelectNodes("negativeInterestRateTreatment");
            if (negativeInterestRateTreatmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in negativeInterestRateTreatmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        negativeInterestRateTreatmentIDRef = item.Attributes["id"].Name;
                        NegativeInterestRateTreatmentEnum ob = NegativeInterestRateTreatmentEnum();
                        IDManager.SetID(negativeInterestRateTreatmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        negativeInterestRateTreatmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        negativeInterestRateTreatment = new NegativeInterestRateTreatmentEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialRate
        private XsdTypeDecimal initialRate;
        public XsdTypeDecimal InitialRate
        {
            get
            {
                if (this.initialRate != null)
                {
                    return this.initialRate; 
                }
                else if (this.initialRateIDRef != null)
                {
                    initialRate = IDManager.getID(initialRateIDRef) as XsdTypeDecimal;
                    return this.initialRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialRate != value)
                {
                    this.initialRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FinalRateRounding
        private Rounding finalRateRounding;
        public Rounding FinalRateRounding
        {
            get
            {
                if (this.finalRateRounding != null)
                {
                    return this.finalRateRounding; 
                }
                else if (this.finalRateRoundingIDRef != null)
                {
                    finalRateRounding = IDManager.getID(finalRateRoundingIDRef) as Rounding;
                    return this.finalRateRounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.finalRateRounding != value)
                {
                    this.finalRateRounding = value;
                }
            }
        }
        #endregion
        
        public string RoundingIDRef { get; set; }
        #region AveragingMethod
        private AveragingMethodEnum averagingMethod;
        public AveragingMethodEnum AveragingMethod
        {
            get
            {
                if (this.averagingMethod != null)
                {
                    return this.averagingMethod; 
                }
                else if (this.averagingMethodIDRef != null)
                {
                    averagingMethod = IDManager.getID(averagingMethodIDRef) as AveragingMethodEnum;
                    return this.averagingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingMethod != value)
                {
                    this.averagingMethod = value;
                }
            }
        }
        #endregion
        
        public string AveragingMethodEnumIDRef { get; set; }
        #region NegativeInterestRateTreatment
        private NegativeInterestRateTreatmentEnum negativeInterestRateTreatment;
        public NegativeInterestRateTreatmentEnum NegativeInterestRateTreatment
        {
            get
            {
                if (this.negativeInterestRateTreatment != null)
                {
                    return this.negativeInterestRateTreatment; 
                }
                else if (this.negativeInterestRateTreatmentIDRef != null)
                {
                    negativeInterestRateTreatment = IDManager.getID(negativeInterestRateTreatmentIDRef) as NegativeInterestRateTreatmentEnum;
                    return this.negativeInterestRateTreatment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.negativeInterestRateTreatment != value)
                {
                    this.negativeInterestRateTreatment = value;
                }
            }
        }
        #endregion
        
        public string NegativeInterestRateTreatmentEnumIDRef { get; set; }
        
    
        
    
    }
    
}

