using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingRate : Rate
    {
        public FloatingRate(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode floatingRateIndexNode = xmlNode.SelectSingleNode("floatingRateIndex");
            
            if (floatingRateIndexNode != null)
            {
                if (floatingRateIndexNode.Attributes["href"] != null || floatingRateIndexNode.Attributes["id"] != null) 
                {
                    if (floatingRateIndexNode.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["id"].Value;
                        FloatingRateIndex ob = new FloatingRateIndex(floatingRateIndexNode);
                        IDManager.SetID(floatingRateIndexIDRef_, ob);
                    }
                    else if (floatingRateIndexNode.Attributes["href"] != null)
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                    }
                }
                else
                {
                    floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                }
            }
            
        
            XmlNode indexTenorNode = xmlNode.SelectSingleNode("indexTenor");
            
            if (indexTenorNode != null)
            {
                if (indexTenorNode.Attributes["href"] != null || indexTenorNode.Attributes["id"] != null) 
                {
                    if (indexTenorNode.Attributes["id"] != null) 
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["id"].Value;
                        Period ob = new Period(indexTenorNode);
                        IDManager.SetID(indexTenorIDRef_, ob);
                    }
                    else if (indexTenorNode.Attributes["href"] != null)
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexTenor_ = new Period(indexTenorNode);
                    }
                }
                else
                {
                    indexTenor_ = new Period(indexTenorNode);
                }
            }
            
        
            XmlNode floatingRateMultiplierScheduleNode = xmlNode.SelectSingleNode("floatingRateMultiplierSchedule");
            
            if (floatingRateMultiplierScheduleNode != null)
            {
                if (floatingRateMultiplierScheduleNode.Attributes["href"] != null || floatingRateMultiplierScheduleNode.Attributes["id"] != null) 
                {
                    if (floatingRateMultiplierScheduleNode.Attributes["id"] != null) 
                    {
                        floatingRateMultiplierScheduleIDRef_ = floatingRateMultiplierScheduleNode.Attributes["id"].Value;
                        Schedule ob = new Schedule(floatingRateMultiplierScheduleNode);
                        IDManager.SetID(floatingRateMultiplierScheduleIDRef_, ob);
                    }
                    else if (floatingRateMultiplierScheduleNode.Attributes["href"] != null)
                    {
                        floatingRateMultiplierScheduleIDRef_ = floatingRateMultiplierScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateMultiplierSchedule_ = new Schedule(floatingRateMultiplierScheduleNode);
                    }
                }
                else
                {
                    floatingRateMultiplierSchedule_ = new Schedule(floatingRateMultiplierScheduleNode);
                }
            }
            
        
            XmlNodeList spreadScheduleNodeList = xmlNode.SelectNodes("spreadSchedule");
            
            if (spreadScheduleNodeList != null)
            {
                this.spreadSchedule_ = new List<SpreadSchedule>();
                foreach (XmlNode item in spreadScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            spreadScheduleIDRef_ = item.Attributes["id"].Value;
                            spreadSchedule_.Add(new SpreadSchedule(item));
                            IDManager.SetID(spreadScheduleIDRef_, spreadSchedule_[spreadSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            spreadScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        spreadSchedule_.Add(new SpreadSchedule(item));
                        }
                    }
                    else
                    {
                        spreadSchedule_.Add(new SpreadSchedule(item));
                    }
                }
            }
            
        
            XmlNode rateTreatmentNode = xmlNode.SelectSingleNode("rateTreatment");
            
            if (rateTreatmentNode != null)
            {
                if (rateTreatmentNode.Attributes["href"] != null || rateTreatmentNode.Attributes["id"] != null) 
                {
                    if (rateTreatmentNode.Attributes["id"] != null) 
                    {
                        rateTreatmentIDRef_ = rateTreatmentNode.Attributes["id"].Value;
                        RateTreatmentEnum ob = new RateTreatmentEnum(rateTreatmentNode);
                        IDManager.SetID(rateTreatmentIDRef_, ob);
                    }
                    else if (rateTreatmentNode.Attributes["href"] != null)
                    {
                        rateTreatmentIDRef_ = rateTreatmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateTreatment_ = new RateTreatmentEnum(rateTreatmentNode);
                    }
                }
                else
                {
                    rateTreatment_ = new RateTreatmentEnum(rateTreatmentNode);
                }
            }
            
        
            XmlNodeList capRateScheduleNodeList = xmlNode.SelectNodes("capRateSchedule");
            
            if (capRateScheduleNodeList != null)
            {
                this.capRateSchedule_ = new List<StrikeSchedule>();
                foreach (XmlNode item in capRateScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            capRateScheduleIDRef_ = item.Attributes["id"].Value;
                            capRateSchedule_.Add(new StrikeSchedule(item));
                            IDManager.SetID(capRateScheduleIDRef_, capRateSchedule_[capRateSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            capRateScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        capRateSchedule_.Add(new StrikeSchedule(item));
                        }
                    }
                    else
                    {
                        capRateSchedule_.Add(new StrikeSchedule(item));
                    }
                }
            }
            
        
            XmlNodeList floorRateScheduleNodeList = xmlNode.SelectNodes("floorRateSchedule");
            
            if (floorRateScheduleNodeList != null)
            {
                this.floorRateSchedule_ = new List<StrikeSchedule>();
                foreach (XmlNode item in floorRateScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            floorRateScheduleIDRef_ = item.Attributes["id"].Value;
                            floorRateSchedule_.Add(new StrikeSchedule(item));
                            IDManager.SetID(floorRateScheduleIDRef_, floorRateSchedule_[floorRateSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            floorRateScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        floorRateSchedule_.Add(new StrikeSchedule(item));
                        }
                    }
                    else
                    {
                        floorRateSchedule_.Add(new StrikeSchedule(item));
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRateIndex_
        private FloatingRateIndex floatingRateIndex_;
        public FloatingRateIndex FloatingRateIndex_
        {
            get
            {
                if (this.floatingRateIndex_ != null)
                {
                    return this.floatingRateIndex_; 
                }
                else if (this.floatingRateIndexIDRef_ != null)
                {
                    floatingRateIndex_ = IDManager.getID(floatingRateIndexIDRef_) as FloatingRateIndex;
                    return this.floatingRateIndex_; 
                }
                else
                {
                      return this.floatingRateIndex_; 
                }
            }
            set
            {
                if (this.floatingRateIndex_ != value)
                {
                    this.floatingRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIndexIDRef_ { get; set; }
        #region IndexTenor_
        private Period indexTenor_;
        public Period IndexTenor_
        {
            get
            {
                if (this.indexTenor_ != null)
                {
                    return this.indexTenor_; 
                }
                else if (this.indexTenorIDRef_ != null)
                {
                    indexTenor_ = IDManager.getID(indexTenorIDRef_) as Period;
                    return this.indexTenor_; 
                }
                else
                {
                      return this.indexTenor_; 
                }
            }
            set
            {
                if (this.indexTenor_ != value)
                {
                    this.indexTenor_ = value;
                }
            }
        }
        #endregion
        
        public string indexTenorIDRef_ { get; set; }
        #region FloatingRateMultiplierSchedule_
        private Schedule floatingRateMultiplierSchedule_;
        public Schedule FloatingRateMultiplierSchedule_
        {
            get
            {
                if (this.floatingRateMultiplierSchedule_ != null)
                {
                    return this.floatingRateMultiplierSchedule_; 
                }
                else if (this.floatingRateMultiplierScheduleIDRef_ != null)
                {
                    floatingRateMultiplierSchedule_ = IDManager.getID(floatingRateMultiplierScheduleIDRef_) as Schedule;
                    return this.floatingRateMultiplierSchedule_; 
                }
                else
                {
                      return this.floatingRateMultiplierSchedule_; 
                }
            }
            set
            {
                if (this.floatingRateMultiplierSchedule_ != value)
                {
                    this.floatingRateMultiplierSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateMultiplierScheduleIDRef_ { get; set; }
        #region SpreadSchedule_
        private List<SpreadSchedule> spreadSchedule_;
        public List<SpreadSchedule> SpreadSchedule_
        {
            get
            {
                if (this.spreadSchedule_ != null)
                {
                    return this.spreadSchedule_; 
                }
                else if (this.spreadScheduleIDRef_ != null)
                {
                    return this.spreadSchedule_; 
                }
                else
                {
                      return this.spreadSchedule_; 
                }
            }
            set
            {
                if (this.spreadSchedule_ != value)
                {
                    this.spreadSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string spreadScheduleIDRef_ { get; set; }
        #region RateTreatment_
        private RateTreatmentEnum rateTreatment_;
        public RateTreatmentEnum RateTreatment_
        {
            get
            {
                if (this.rateTreatment_ != null)
                {
                    return this.rateTreatment_; 
                }
                else if (this.rateTreatmentIDRef_ != null)
                {
                    rateTreatment_ = IDManager.getID(rateTreatmentIDRef_) as RateTreatmentEnum;
                    return this.rateTreatment_; 
                }
                else
                {
                      return this.rateTreatment_; 
                }
            }
            set
            {
                if (this.rateTreatment_ != value)
                {
                    this.rateTreatment_ = value;
                }
            }
        }
        #endregion
        
        public string rateTreatmentIDRef_ { get; set; }
        #region CapRateSchedule_
        private List<StrikeSchedule> capRateSchedule_;
        public List<StrikeSchedule> CapRateSchedule_
        {
            get
            {
                if (this.capRateSchedule_ != null)
                {
                    return this.capRateSchedule_; 
                }
                else if (this.capRateScheduleIDRef_ != null)
                {
                    return this.capRateSchedule_; 
                }
                else
                {
                      return this.capRateSchedule_; 
                }
            }
            set
            {
                if (this.capRateSchedule_ != value)
                {
                    this.capRateSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string capRateScheduleIDRef_ { get; set; }
        #region FloorRateSchedule_
        private List<StrikeSchedule> floorRateSchedule_;
        public List<StrikeSchedule> FloorRateSchedule_
        {
            get
            {
                if (this.floorRateSchedule_ != null)
                {
                    return this.floorRateSchedule_; 
                }
                else if (this.floorRateScheduleIDRef_ != null)
                {
                    return this.floorRateSchedule_; 
                }
                else
                {
                      return this.floorRateSchedule_; 
                }
            }
            set
            {
                if (this.floorRateSchedule_ != value)
                {
                    this.floorRateSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string floorRateScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}

