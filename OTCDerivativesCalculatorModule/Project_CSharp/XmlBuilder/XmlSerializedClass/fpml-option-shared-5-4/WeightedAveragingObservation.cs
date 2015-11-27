using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeightedAveragingObservation : ISerialized
    {
        public WeightedAveragingObservation(XmlNode xmlNode)
        {
            XmlNode dateTimeNode = xmlNode.SelectSingleNode("dateTime");
            
            if (dateTimeNode != null)
            {
                if (dateTimeNode.Attributes["href"] != null || dateTimeNode.Attributes["id"] != null) 
                {
                    if (dateTimeNode.Attributes["id"] != null) 
                    {
                        dateTimeIDRef_ = dateTimeNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(dateTimeNode);
                        IDManager.SetID(dateTimeIDRef_, ob);
                    }
                    else if (dateTimeNode.Attributes["href"] != null)
                    {
                        dateTimeIDRef_ = dateTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateTime_ = new XsdTypeDateTime(dateTimeNode);
                    }
                }
                else
                {
                    dateTime_ = new XsdTypeDateTime(dateTimeNode);
                }
            }
            
        
            XmlNode observationNumberNode = xmlNode.SelectSingleNode("observationNumber");
            
            if (observationNumberNode != null)
            {
                if (observationNumberNode.Attributes["href"] != null || observationNumberNode.Attributes["id"] != null) 
                {
                    if (observationNumberNode.Attributes["id"] != null) 
                    {
                        observationNumberIDRef_ = observationNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(observationNumberNode);
                        IDManager.SetID(observationNumberIDRef_, ob);
                    }
                    else if (observationNumberNode.Attributes["href"] != null)
                    {
                        observationNumberIDRef_ = observationNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationNumber_ = new XsdTypePositiveInteger(observationNumberNode);
                    }
                }
                else
                {
                    observationNumber_ = new XsdTypePositiveInteger(observationNumberNode);
                }
            }
            
        
            XmlNode weightNode = xmlNode.SelectSingleNode("weight");
            
            if (weightNode != null)
            {
                if (weightNode.Attributes["href"] != null || weightNode.Attributes["id"] != null) 
                {
                    if (weightNode.Attributes["id"] != null) 
                    {
                        weightIDRef_ = weightNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(weightNode);
                        IDManager.SetID(weightIDRef_, ob);
                    }
                    else if (weightNode.Attributes["href"] != null)
                    {
                        weightIDRef_ = weightNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weight_ = new NonNegativeDecimal(weightNode);
                    }
                }
                else
                {
                    weight_ = new NonNegativeDecimal(weightNode);
                }
            }
            
        
        }
        
    
        #region DateTime_
        private XsdTypeDateTime dateTime_;
        public XsdTypeDateTime DateTime_
        {
            get
            {
                if (this.dateTime_ != null)
                {
                    return this.dateTime_; 
                }
                else if (this.dateTimeIDRef_ != null)
                {
                    dateTime_ = IDManager.getID(dateTimeIDRef_) as XsdTypeDateTime;
                    return this.dateTime_; 
                }
                else
                {
                      return this.dateTime_; 
                }
            }
            set
            {
                if (this.dateTime_ != value)
                {
                    this.dateTime_ = value;
                }
            }
        }
        #endregion
        
        public string dateTimeIDRef_ { get; set; }
        #region ObservationNumber_
        private XsdTypePositiveInteger observationNumber_;
        public XsdTypePositiveInteger ObservationNumber_
        {
            get
            {
                if (this.observationNumber_ != null)
                {
                    return this.observationNumber_; 
                }
                else if (this.observationNumberIDRef_ != null)
                {
                    observationNumber_ = IDManager.getID(observationNumberIDRef_) as XsdTypePositiveInteger;
                    return this.observationNumber_; 
                }
                else
                {
                      return this.observationNumber_; 
                }
            }
            set
            {
                if (this.observationNumber_ != value)
                {
                    this.observationNumber_ = value;
                }
            }
        }
        #endregion
        
        public string observationNumberIDRef_ { get; set; }
        #region Weight_
        private NonNegativeDecimal weight_;
        public NonNegativeDecimal Weight_
        {
            get
            {
                if (this.weight_ != null)
                {
                    return this.weight_; 
                }
                else if (this.weightIDRef_ != null)
                {
                    weight_ = IDManager.getID(weightIDRef_) as NonNegativeDecimal;
                    return this.weight_; 
                }
                else
                {
                      return this.weight_; 
                }
            }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                }
            }
        }
        #endregion
        
        public string weightIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

