using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeightedAveragingObservation
    {
        public WeightedAveragingObservation(XmlNode xmlNode)
        {
            XmlNodeList dateTimeNodeList = xmlNode.SelectNodes("dateTime");
            if (dateTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(dateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateTime = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList observationNumberNodeList = xmlNode.SelectNodes("observationNumber");
            if (observationNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(observationNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList weightNodeList = xmlNode.SelectNodes("weight");
            if (weightNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weightNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weightIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(weightIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weightIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weight = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region DateTime
        private XsdTypeDateTime dateTime;
        public XsdTypeDateTime DateTime
        {
            get
            {
                if (this.dateTime != null)
                {
                    return this.dateTime; 
                }
                else if (this.dateTimeIDRef != null)
                {
                    dateTime = IDManager.getID(dateTimeIDRef) as XsdTypeDateTime;
                    return this.dateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateTime != value)
                {
                    this.dateTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region ObservationNumber
        private XsdTypePositiveInteger observationNumber;
        public XsdTypePositiveInteger ObservationNumber
        {
            get
            {
                if (this.observationNumber != null)
                {
                    return this.observationNumber; 
                }
                else if (this.observationNumberIDRef != null)
                {
                    observationNumber = IDManager.getID(observationNumberIDRef) as XsdTypePositiveInteger;
                    return this.observationNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationNumber != value)
                {
                    this.observationNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region Weight
        private NonNegativeDecimal weight;
        public NonNegativeDecimal Weight
        {
            get
            {
                if (this.weight != null)
                {
                    return this.weight; 
                }
                else if (this.weightIDRef != null)
                {
                    weight = IDManager.getID(weightIDRef) as NonNegativeDecimal;
                    return this.weight; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weight != value)
                {
                    this.weight = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

