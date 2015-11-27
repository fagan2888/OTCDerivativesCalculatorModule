using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingRateDefinition : ISerialized
    {
        public FloatingRateDefinition(XmlNode xmlNode)
        {
            XmlNode calculatedRateNode = xmlNode.SelectSingleNode("calculatedRate");
            
            if (calculatedRateNode != null)
            {
                if (calculatedRateNode.Attributes["href"] != null || calculatedRateNode.Attributes["id"] != null) 
                {
                    if (calculatedRateNode.Attributes["id"] != null) 
                    {
                        calculatedRateIDRef_ = calculatedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(calculatedRateNode);
                        IDManager.SetID(calculatedRateIDRef_, ob);
                    }
                    else if (calculatedRateNode.Attributes["href"] != null)
                    {
                        calculatedRateIDRef_ = calculatedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculatedRate_ = new XsdTypeDecimal(calculatedRateNode);
                    }
                }
                else
                {
                    calculatedRate_ = new XsdTypeDecimal(calculatedRateNode);
                }
            }
            
        
            XmlNodeList rateObservationNodeList = xmlNode.SelectNodes("rateObservation");
            
            if (rateObservationNodeList != null)
            {
                this.rateObservation_ = new List<RateObservation>();
                foreach (XmlNode item in rateObservationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            rateObservationIDRef_ = item.Attributes["id"].Value;
                            rateObservation_.Add(new RateObservation(item));
                            IDManager.SetID(rateObservationIDRef_, rateObservation_[rateObservation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            rateObservationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        rateObservation_.Add(new RateObservation(item));
                        }
                    }
                    else
                    {
                        rateObservation_.Add(new RateObservation(item));
                    }
                }
            }
            
        
            XmlNode floatingRateMultiplierNode = xmlNode.SelectSingleNode("floatingRateMultiplier");
            
            if (floatingRateMultiplierNode != null)
            {
                if (floatingRateMultiplierNode.Attributes["href"] != null || floatingRateMultiplierNode.Attributes["id"] != null) 
                {
                    if (floatingRateMultiplierNode.Attributes["id"] != null) 
                    {
                        floatingRateMultiplierIDRef_ = floatingRateMultiplierNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(floatingRateMultiplierNode);
                        IDManager.SetID(floatingRateMultiplierIDRef_, ob);
                    }
                    else if (floatingRateMultiplierNode.Attributes["href"] != null)
                    {
                        floatingRateMultiplierIDRef_ = floatingRateMultiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateMultiplier_ = new XsdTypeDecimal(floatingRateMultiplierNode);
                    }
                }
                else
                {
                    floatingRateMultiplier_ = new XsdTypeDecimal(floatingRateMultiplierNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDecimal(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDecimal(spreadNode);
                }
            }
            
        
            XmlNodeList capRateNodeList = xmlNode.SelectNodes("capRate");
            
            if (capRateNodeList != null)
            {
                this.capRate_ = new List<Strike>();
                foreach (XmlNode item in capRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            capRateIDRef_ = item.Attributes["id"].Value;
                            capRate_.Add(new Strike(item));
                            IDManager.SetID(capRateIDRef_, capRate_[capRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            capRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        capRate_.Add(new Strike(item));
                        }
                    }
                    else
                    {
                        capRate_.Add(new Strike(item));
                    }
                }
            }
            
        
            XmlNodeList floorRateNodeList = xmlNode.SelectNodes("floorRate");
            
            if (floorRateNodeList != null)
            {
                this.floorRate_ = new List<Strike>();
                foreach (XmlNode item in floorRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            floorRateIDRef_ = item.Attributes["id"].Value;
                            floorRate_.Add(new Strike(item));
                            IDManager.SetID(floorRateIDRef_, floorRate_[floorRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            floorRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        floorRate_.Add(new Strike(item));
                        }
                    }
                    else
                    {
                        floorRate_.Add(new Strike(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculatedRate_
        private XsdTypeDecimal calculatedRate_;
        public XsdTypeDecimal CalculatedRate_
        {
            get
            {
                if (this.calculatedRate_ != null)
                {
                    return this.calculatedRate_; 
                }
                else if (this.calculatedRateIDRef_ != null)
                {
                    calculatedRate_ = IDManager.getID(calculatedRateIDRef_) as XsdTypeDecimal;
                    return this.calculatedRate_; 
                }
                else
                {
                      return this.calculatedRate_; 
                }
            }
            set
            {
                if (this.calculatedRate_ != value)
                {
                    this.calculatedRate_ = value;
                }
            }
        }
        #endregion
        
        public string calculatedRateIDRef_ { get; set; }
        #region RateObservation_
        private List<RateObservation> rateObservation_;
        public List<RateObservation> RateObservation_
        {
            get
            {
                if (this.rateObservation_ != null)
                {
                    return this.rateObservation_; 
                }
                else if (this.rateObservationIDRef_ != null)
                {
                    return this.rateObservation_; 
                }
                else
                {
                      return this.rateObservation_; 
                }
            }
            set
            {
                if (this.rateObservation_ != value)
                {
                    this.rateObservation_ = value;
                }
            }
        }
        #endregion
        
        public string rateObservationIDRef_ { get; set; }
        #region FloatingRateMultiplier_
        private XsdTypeDecimal floatingRateMultiplier_;
        public XsdTypeDecimal FloatingRateMultiplier_
        {
            get
            {
                if (this.floatingRateMultiplier_ != null)
                {
                    return this.floatingRateMultiplier_; 
                }
                else if (this.floatingRateMultiplierIDRef_ != null)
                {
                    floatingRateMultiplier_ = IDManager.getID(floatingRateMultiplierIDRef_) as XsdTypeDecimal;
                    return this.floatingRateMultiplier_; 
                }
                else
                {
                      return this.floatingRateMultiplier_; 
                }
            }
            set
            {
                if (this.floatingRateMultiplier_ != value)
                {
                    this.floatingRateMultiplier_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateMultiplierIDRef_ { get; set; }
        #region Spread_
        private XsdTypeDecimal spread_;
        public XsdTypeDecimal Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDecimal;
                    return this.spread_; 
                }
                else
                {
                      return this.spread_; 
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region CapRate_
        private List<Strike> capRate_;
        public List<Strike> CapRate_
        {
            get
            {
                if (this.capRate_ != null)
                {
                    return this.capRate_; 
                }
                else if (this.capRateIDRef_ != null)
                {
                    return this.capRate_; 
                }
                else
                {
                      return this.capRate_; 
                }
            }
            set
            {
                if (this.capRate_ != value)
                {
                    this.capRate_ = value;
                }
            }
        }
        #endregion
        
        public string capRateIDRef_ { get; set; }
        #region FloorRate_
        private List<Strike> floorRate_;
        public List<Strike> FloorRate_
        {
            get
            {
                if (this.floorRate_ != null)
                {
                    return this.floorRate_; 
                }
                else if (this.floorRateIDRef_ != null)
                {
                    return this.floorRate_; 
                }
                else
                {
                      return this.floorRate_; 
                }
            }
            set
            {
                if (this.floorRate_ != value)
                {
                    this.floorRate_ = value;
                }
            }
        }
        #endregion
        
        public string floorRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

