using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AveragingObservationList
    {
        public AveragingObservationList(XmlNode xmlNode)
        {
            XmlNodeList averagingObservationNodeList = xmlNode.SelectNodes("averagingObservation");
            
            foreach (XmlNode item in averagingObservationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingObservationIDRef = item.Attributes["id"].Name;
                        List<WeightedAveragingObservation> ob = new List<WeightedAveragingObservation>();
                        ob.Add(new WeightedAveragingObservation(item));
                        IDManager.SetID(averagingObservationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingObservationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    averagingObservation.Add(new WeightedAveragingObservation(item));
                    }
                }
            }
            
        
        }
        
    
        #region AveragingObservation
        private List<WeightedAveragingObservation> averagingObservation;
        public List<WeightedAveragingObservation> AveragingObservation
        {
            get
            {
                if (this.averagingObservation != null)
                {
                    return this.averagingObservation; 
                }
                else if (this.averagingObservationIDRef != null)
                {
                    averagingObservation = IDManager.getID(averagingObservationIDRef) as List<WeightedAveragingObservation>;
                    return this.averagingObservation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingObservation != value)
                {
                    this.averagingObservation = value;
                }
            }
        }
        #endregion
        
        public string WeightedAveragingObservationIDRef { get; set; }
        
    
        
    
    }
    
}

