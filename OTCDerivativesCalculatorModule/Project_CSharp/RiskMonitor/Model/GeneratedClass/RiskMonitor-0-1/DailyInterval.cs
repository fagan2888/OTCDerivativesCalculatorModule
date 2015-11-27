using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DailyInterval : ISerialized
    {
        public DailyInterval() { }
        public DailyInterval(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode observationStartDateNode = xmlNode.SelectSingleNode("observationStartDate");
            
            if (observationStartDateNode != null)
            {
                if (observationStartDateNode.Attributes["href"] != null || observationStartDateNode.Attributes["id"] != null) 
                {
                    if (observationStartDateNode.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(observationStartDateNode);
                        IDManager.SetID(observationStartDateIDRef_, ob);
                    }
                    else if (observationStartDateNode.Attributes["href"] != null)
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationStartDate_ = new XsdTypeDate(observationStartDateNode);
                    }
                }
                else
                {
                    observationStartDate_ = new XsdTypeDate(observationStartDateNode);
                }
            }
            
        
            XmlNode observationEndDateNode = xmlNode.SelectSingleNode("observationEndDate");
            
            if (observationEndDateNode != null)
            {
                if (observationEndDateNode.Attributes["href"] != null || observationEndDateNode.Attributes["id"] != null) 
                {
                    if (observationEndDateNode.Attributes["id"] != null) 
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(observationEndDateNode);
                        IDManager.SetID(observationEndDateIDRef_, ob);
                    }
                    else if (observationEndDateNode.Attributes["href"] != null)
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationEndDate_ = new XsdTypeDate(observationEndDateNode);
                    }
                }
                else
                {
                    observationEndDate_ = new XsdTypeDate(observationEndDateNode);
                }
            }
            
        
        }
        
    
        #region ObservationStartDate_
        private XsdTypeDate observationStartDate_;
        public XsdTypeDate ObservationStartDate_
        {
            get
            {
                if (this.observationStartDate_ != null)
                {
                    return this.observationStartDate_; 
                }
                else if (this.observationStartDateIDRef_ != null)
                {
                    observationStartDate_ = IDManager.getID(observationStartDateIDRef_) as XsdTypeDate;
                    return this.observationStartDate_; 
                }
                else
                {
                    throw new Exception( "observationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationStartDateIDRef_ { get; set; }
        #region ObservationEndDate_
        private XsdTypeDate observationEndDate_;
        public XsdTypeDate ObservationEndDate_
        {
            get
            {
                if (this.observationEndDate_ != null)
                {
                    return this.observationEndDate_; 
                }
                else if (this.observationEndDateIDRef_ != null)
                {
                    observationEndDate_ = IDManager.getID(observationEndDateIDRef_) as XsdTypeDate;
                    return this.observationEndDate_; 
                }
                else
                {
                    throw new Exception( "observationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationEndDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

