using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Lag : ISerialized
    {
        public Lag(XmlNode xmlNode)
        {
            XmlNode lagDurationNode = xmlNode.SelectSingleNode("lagDuration");
            
            if (lagDurationNode != null)
            {
                if (lagDurationNode.Attributes["href"] != null || lagDurationNode.Attributes["id"] != null) 
                {
                    if (lagDurationNode.Attributes["id"] != null) 
                    {
                        lagDurationIDRef_ = lagDurationNode.Attributes["id"].Value;
                        Period ob = new Period(lagDurationNode);
                        IDManager.SetID(lagDurationIDRef_, ob);
                    }
                    else if (lagDurationNode.Attributes["href"] != null)
                    {
                        lagDurationIDRef_ = lagDurationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lagDuration_ = new Period(lagDurationNode);
                    }
                }
                else
                {
                    lagDuration_ = new Period(lagDurationNode);
                }
            }
            
        
            XmlNode firstObservationDateOffsetNode = xmlNode.SelectSingleNode("firstObservationDateOffset");
            
            if (firstObservationDateOffsetNode != null)
            {
                if (firstObservationDateOffsetNode.Attributes["href"] != null || firstObservationDateOffsetNode.Attributes["id"] != null) 
                {
                    if (firstObservationDateOffsetNode.Attributes["id"] != null) 
                    {
                        firstObservationDateOffsetIDRef_ = firstObservationDateOffsetNode.Attributes["id"].Value;
                        Period ob = new Period(firstObservationDateOffsetNode);
                        IDManager.SetID(firstObservationDateOffsetIDRef_, ob);
                    }
                    else if (firstObservationDateOffsetNode.Attributes["href"] != null)
                    {
                        firstObservationDateOffsetIDRef_ = firstObservationDateOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstObservationDateOffset_ = new Period(firstObservationDateOffsetNode);
                    }
                }
                else
                {
                    firstObservationDateOffset_ = new Period(firstObservationDateOffsetNode);
                }
            }
            
        
        }
        
    
        #region LagDuration_
        private Period lagDuration_;
        public Period LagDuration_
        {
            get
            {
                if (this.lagDuration_ != null)
                {
                    return this.lagDuration_; 
                }
                else if (this.lagDurationIDRef_ != null)
                {
                    lagDuration_ = IDManager.getID(lagDurationIDRef_) as Period;
                    return this.lagDuration_; 
                }
                else
                {
                      return this.lagDuration_; 
                }
            }
            set
            {
                if (this.lagDuration_ != value)
                {
                    this.lagDuration_ = value;
                }
            }
        }
        #endregion
        
        public string lagDurationIDRef_ { get; set; }
        #region FirstObservationDateOffset_
        private Period firstObservationDateOffset_;
        public Period FirstObservationDateOffset_
        {
            get
            {
                if (this.firstObservationDateOffset_ != null)
                {
                    return this.firstObservationDateOffset_; 
                }
                else if (this.firstObservationDateOffsetIDRef_ != null)
                {
                    firstObservationDateOffset_ = IDManager.getID(firstObservationDateOffsetIDRef_) as Period;
                    return this.firstObservationDateOffset_; 
                }
                else
                {
                      return this.firstObservationDateOffset_; 
                }
            }
            set
            {
                if (this.firstObservationDateOffset_ != value)
                {
                    this.firstObservationDateOffset_ = value;
                }
            }
        }
        #endregion
        
        public string firstObservationDateOffsetIDRef_ { get; set; }
        
    
        
    
    }
    
}

