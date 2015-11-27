using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CompoundingRate
    {
        public CompoundingRate(XmlNode xmlNode)
        {
            XmlNodeList interestLegRateNodeList = xmlNode.SelectNodes("interestLegRate");
            if (interestLegRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestLegRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestLegRateIDRef = item.Attributes["id"].Name;
                        FloatingRateCalculationReference ob = FloatingRateCalculationReference();
                        IDManager.SetID(interestLegRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestLegRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestLegRate = new FloatingRateCalculationReference(item);
                    }
                }
            }
            
        
            XmlNodeList specificRateNodeList = xmlNode.SelectNodes("specificRate");
            if (specificRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specificRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specificRateIDRef = item.Attributes["id"].Name;
                        InterestAccrualsMethod ob = InterestAccrualsMethod();
                        IDManager.SetID(specificRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specificRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specificRate = new InterestAccrualsMethod(item);
                    }
                }
            }
            
        
        }
        
    
        #region InterestLegRate
        private FloatingRateCalculationReference interestLegRate;
        public FloatingRateCalculationReference InterestLegRate
        {
            get
            {
                if (this.interestLegRate != null)
                {
                    return this.interestLegRate; 
                }
                else if (this.interestLegRateIDRef != null)
                {
                    interestLegRate = IDManager.getID(interestLegRateIDRef) as FloatingRateCalculationReference;
                    return this.interestLegRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestLegRate != value)
                {
                    this.interestLegRate = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateCalculationReferenceIDRef { get; set; }
        #region SpecificRate
        private InterestAccrualsMethod specificRate;
        public InterestAccrualsMethod SpecificRate
        {
            get
            {
                if (this.specificRate != null)
                {
                    return this.specificRate; 
                }
                else if (this.specificRateIDRef != null)
                {
                    specificRate = IDManager.getID(specificRateIDRef) as InterestAccrualsMethod;
                    return this.specificRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specificRate != value)
                {
                    this.specificRate = value;
                }
            }
        }
        #endregion
        
        public string InterestAccrualsMethodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

