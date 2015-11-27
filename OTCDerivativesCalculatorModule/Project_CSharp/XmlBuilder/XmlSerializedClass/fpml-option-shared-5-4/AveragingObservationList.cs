using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AveragingObservationList : ISerialized
    {
        public AveragingObservationList(XmlNode xmlNode)
        {
            XmlNodeList averagingObservationNodeList = xmlNode.SelectNodes("averagingObservation");
            
            if (averagingObservationNodeList != null)
            {
                this.averagingObservation_ = new List<WeightedAveragingObservation>();
                foreach (XmlNode item in averagingObservationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            averagingObservationIDRef_ = item.Attributes["id"].Value;
                            averagingObservation_.Add(new WeightedAveragingObservation(item));
                            IDManager.SetID(averagingObservationIDRef_, averagingObservation_[averagingObservation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            averagingObservationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        averagingObservation_.Add(new WeightedAveragingObservation(item));
                        }
                    }
                    else
                    {
                        averagingObservation_.Add(new WeightedAveragingObservation(item));
                    }
                }
            }
            
        
        }
        
    
        #region AveragingObservation_
        private List<WeightedAveragingObservation> averagingObservation_;
        public List<WeightedAveragingObservation> AveragingObservation_
        {
            get
            {
                if (this.averagingObservation_ != null)
                {
                    return this.averagingObservation_; 
                }
                else if (this.averagingObservationIDRef_ != null)
                {
                    return this.averagingObservation_; 
                }
                else
                {
                      return this.averagingObservation_; 
                }
            }
            set
            {
                if (this.averagingObservation_ != value)
                {
                    this.averagingObservation_ = value;
                }
            }
        }
        #endregion
        
        public string averagingObservationIDRef_ { get; set; }
        
    
        
    
    }
    
}

