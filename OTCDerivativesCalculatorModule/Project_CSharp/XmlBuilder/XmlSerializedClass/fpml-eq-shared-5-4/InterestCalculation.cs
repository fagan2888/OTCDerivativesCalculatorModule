using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestCalculation : InterestAccrualsMethod
    {
        public InterestCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode compoundingNode = xmlNode.SelectSingleNode("compounding");
            
            if (compoundingNode != null)
            {
                if (compoundingNode.Attributes["href"] != null || compoundingNode.Attributes["id"] != null) 
                {
                    if (compoundingNode.Attributes["id"] != null) 
                    {
                        compoundingIDRef_ = compoundingNode.Attributes["id"].Value;
                        Compounding ob = new Compounding(compoundingNode);
                        IDManager.SetID(compoundingIDRef_, ob);
                    }
                    else if (compoundingNode.Attributes["href"] != null)
                    {
                        compoundingIDRef_ = compoundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compounding_ = new Compounding(compoundingNode);
                    }
                }
                else
                {
                    compounding_ = new Compounding(compoundingNode);
                }
            }
            
        
            XmlNode interpolationMethodNode = xmlNode.SelectSingleNode("interpolationMethod");
            
            if (interpolationMethodNode != null)
            {
                if (interpolationMethodNode.Attributes["href"] != null || interpolationMethodNode.Attributes["id"] != null) 
                {
                    if (interpolationMethodNode.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["id"].Value;
                        InterpolationMethod ob = new InterpolationMethod(interpolationMethodNode);
                        IDManager.SetID(interpolationMethodIDRef_, ob);
                    }
                    else if (interpolationMethodNode.Attributes["href"] != null)
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                    }
                }
                else
                {
                    interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                }
            }
            
        
            XmlNode interpolationPeriodNode = xmlNode.SelectSingleNode("interpolationPeriod");
            
            if (interpolationPeriodNode != null)
            {
                if (interpolationPeriodNode.Attributes["href"] != null || interpolationPeriodNode.Attributes["id"] != null) 
                {
                    if (interpolationPeriodNode.Attributes["id"] != null) 
                    {
                        interpolationPeriodIDRef_ = interpolationPeriodNode.Attributes["id"].Value;
                        InterpolationPeriodEnum ob = new InterpolationPeriodEnum(interpolationPeriodNode);
                        IDManager.SetID(interpolationPeriodIDRef_, ob);
                    }
                    else if (interpolationPeriodNode.Attributes["href"] != null)
                    {
                        interpolationPeriodIDRef_ = interpolationPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interpolationPeriod_ = new InterpolationPeriodEnum(interpolationPeriodNode);
                    }
                }
                else
                {
                    interpolationPeriod_ = new InterpolationPeriodEnum(interpolationPeriodNode);
                }
            }
            
        
        }
        
    
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
        #region Compounding_
        private Compounding compounding_;
        public Compounding Compounding_
        {
            get
            {
                if (this.compounding_ != null)
                {
                    return this.compounding_; 
                }
                else if (this.compoundingIDRef_ != null)
                {
                    compounding_ = IDManager.getID(compoundingIDRef_) as Compounding;
                    return this.compounding_; 
                }
                else
                {
                      return this.compounding_; 
                }
            }
            set
            {
                if (this.compounding_ != value)
                {
                    this.compounding_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingIDRef_ { get; set; }
        #region InterpolationMethod_
        private InterpolationMethod interpolationMethod_;
        public InterpolationMethod InterpolationMethod_
        {
            get
            {
                if (this.interpolationMethod_ != null)
                {
                    return this.interpolationMethod_; 
                }
                else if (this.interpolationMethodIDRef_ != null)
                {
                    interpolationMethod_ = IDManager.getID(interpolationMethodIDRef_) as InterpolationMethod;
                    return this.interpolationMethod_; 
                }
                else
                {
                      return this.interpolationMethod_; 
                }
            }
            set
            {
                if (this.interpolationMethod_ != value)
                {
                    this.interpolationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string interpolationMethodIDRef_ { get; set; }
        #region InterpolationPeriod_
        private InterpolationPeriodEnum interpolationPeriod_;
        public InterpolationPeriodEnum InterpolationPeriod_
        {
            get
            {
                if (this.interpolationPeriod_ != null)
                {
                    return this.interpolationPeriod_; 
                }
                else if (this.interpolationPeriodIDRef_ != null)
                {
                    interpolationPeriod_ = IDManager.getID(interpolationPeriodIDRef_) as InterpolationPeriodEnum;
                    return this.interpolationPeriod_; 
                }
                else
                {
                      return this.interpolationPeriod_; 
                }
            }
            set
            {
                if (this.interpolationPeriod_ != value)
                {
                    this.interpolationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string interpolationPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

