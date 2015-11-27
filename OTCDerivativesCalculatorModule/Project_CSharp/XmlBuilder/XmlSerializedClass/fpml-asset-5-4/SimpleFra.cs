using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleFra : UnderlyingAsset
    {
        public SimpleFra(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode startTermNode = xmlNode.SelectSingleNode("startTerm");
            
            if (startTermNode != null)
            {
                if (startTermNode.Attributes["href"] != null || startTermNode.Attributes["id"] != null) 
                {
                    if (startTermNode.Attributes["id"] != null) 
                    {
                        startTermIDRef_ = startTermNode.Attributes["id"].Value;
                        Period ob = new Period(startTermNode);
                        IDManager.SetID(startTermIDRef_, ob);
                    }
                    else if (startTermNode.Attributes["href"] != null)
                    {
                        startTermIDRef_ = startTermNode.Attributes["href"].Value;
                    }
                    else
                    {
                        startTerm_ = new Period(startTermNode);
                    }
                }
                else
                {
                    startTerm_ = new Period(startTermNode);
                }
            }
            
        
            XmlNode endTermNode = xmlNode.SelectSingleNode("endTerm");
            
            if (endTermNode != null)
            {
                if (endTermNode.Attributes["href"] != null || endTermNode.Attributes["id"] != null) 
                {
                    if (endTermNode.Attributes["id"] != null) 
                    {
                        endTermIDRef_ = endTermNode.Attributes["id"].Value;
                        Period ob = new Period(endTermNode);
                        IDManager.SetID(endTermIDRef_, ob);
                    }
                    else if (endTermNode.Attributes["href"] != null)
                    {
                        endTermIDRef_ = endTermNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endTerm_ = new Period(endTermNode);
                    }
                }
                else
                {
                    endTerm_ = new Period(endTermNode);
                }
            }
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                }
            }
            
        
        }
        
    
        #region StartTerm_
        private Period startTerm_;
        public Period StartTerm_
        {
            get
            {
                if (this.startTerm_ != null)
                {
                    return this.startTerm_; 
                }
                else if (this.startTermIDRef_ != null)
                {
                    startTerm_ = IDManager.getID(startTermIDRef_) as Period;
                    return this.startTerm_; 
                }
                else
                {
                      return this.startTerm_; 
                }
            }
            set
            {
                if (this.startTerm_ != value)
                {
                    this.startTerm_ = value;
                }
            }
        }
        #endregion
        
        public string startTermIDRef_ { get; set; }
        #region EndTerm_
        private Period endTerm_;
        public Period EndTerm_
        {
            get
            {
                if (this.endTerm_ != null)
                {
                    return this.endTerm_; 
                }
                else if (this.endTermIDRef_ != null)
                {
                    endTerm_ = IDManager.getID(endTermIDRef_) as Period;
                    return this.endTerm_; 
                }
                else
                {
                      return this.endTerm_; 
                }
            }
            set
            {
                if (this.endTerm_ != value)
                {
                    this.endTerm_ = value;
                }
            }
        }
        #endregion
        
        public string endTermIDRef_ { get; set; }
        #region DayCountFraction_
        private DayCountFraction dayCountFraction_;
        public DayCountFraction DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as DayCountFraction;
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        
    
        
    
    }
    
}

