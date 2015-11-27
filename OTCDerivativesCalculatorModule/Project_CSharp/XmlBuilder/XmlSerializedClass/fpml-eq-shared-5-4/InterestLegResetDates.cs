using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestLegResetDates : ISerialized
    {
        public InterestLegResetDates(XmlNode xmlNode)
        {
            XmlNode calculationPeriodDatesReferenceNode = xmlNode.SelectSingleNode("calculationPeriodDatesReference");
            
            if (calculationPeriodDatesReferenceNode != null)
            {
                if (calculationPeriodDatesReferenceNode.Attributes["href"] != null || calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["id"].Value;
                        InterestLegCalculationPeriodDatesReference ob = new InterestLegCalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodDatesReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesReference_ = new InterestLegCalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodDatesReference_ = new InterestLegCalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                }
            }
            
        
            XmlNode resetRelativeToNode = xmlNode.SelectSingleNode("resetRelativeTo");
            
            if (resetRelativeToNode != null)
            {
                if (resetRelativeToNode.Attributes["href"] != null || resetRelativeToNode.Attributes["id"] != null) 
                {
                    if (resetRelativeToNode.Attributes["id"] != null) 
                    {
                        resetRelativeToIDRef_ = resetRelativeToNode.Attributes["id"].Value;
                        ResetRelativeToEnum ob = new ResetRelativeToEnum(resetRelativeToNode);
                        IDManager.SetID(resetRelativeToIDRef_, ob);
                    }
                    else if (resetRelativeToNode.Attributes["href"] != null)
                    {
                        resetRelativeToIDRef_ = resetRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetRelativeTo_ = new ResetRelativeToEnum(resetRelativeToNode);
                    }
                }
                else
                {
                    resetRelativeTo_ = new ResetRelativeToEnum(resetRelativeToNode);
                }
            }
            
        
            XmlNode resetFrequencyNode = xmlNode.SelectSingleNode("resetFrequency");
            
            if (resetFrequencyNode != null)
            {
                if (resetFrequencyNode.Attributes["href"] != null || resetFrequencyNode.Attributes["id"] != null) 
                {
                    if (resetFrequencyNode.Attributes["id"] != null) 
                    {
                        resetFrequencyIDRef_ = resetFrequencyNode.Attributes["id"].Value;
                        ResetFrequency ob = new ResetFrequency(resetFrequencyNode);
                        IDManager.SetID(resetFrequencyIDRef_, ob);
                    }
                    else if (resetFrequencyNode.Attributes["href"] != null)
                    {
                        resetFrequencyIDRef_ = resetFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetFrequency_ = new ResetFrequency(resetFrequencyNode);
                    }
                }
                else
                {
                    resetFrequency_ = new ResetFrequency(resetFrequencyNode);
                }
            }
            
        
            XmlNode initialFixingDateNode = xmlNode.SelectSingleNode("initialFixingDate");
            
            if (initialFixingDateNode != null)
            {
                if (initialFixingDateNode.Attributes["href"] != null || initialFixingDateNode.Attributes["id"] != null) 
                {
                    if (initialFixingDateNode.Attributes["id"] != null) 
                    {
                        initialFixingDateIDRef_ = initialFixingDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(initialFixingDateNode);
                        IDManager.SetID(initialFixingDateIDRef_, ob);
                    }
                    else if (initialFixingDateNode.Attributes["href"] != null)
                    {
                        initialFixingDateIDRef_ = initialFixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialFixingDate_ = new RelativeDateOffset(initialFixingDateNode);
                    }
                }
                else
                {
                    initialFixingDate_ = new RelativeDateOffset(initialFixingDateNode);
                }
            }
            
        
            XmlNode fixingDatesNode = xmlNode.SelectSingleNode("fixingDates");
            
            if (fixingDatesNode != null)
            {
                if (fixingDatesNode.Attributes["href"] != null || fixingDatesNode.Attributes["id"] != null) 
                {
                    if (fixingDatesNode.Attributes["id"] != null) 
                    {
                        fixingDatesIDRef_ = fixingDatesNode.Attributes["id"].Value;
                        AdjustableDatesOrRelativeDateOffset ob = new AdjustableDatesOrRelativeDateOffset(fixingDatesNode);
                        IDManager.SetID(fixingDatesIDRef_, ob);
                    }
                    else if (fixingDatesNode.Attributes["href"] != null)
                    {
                        fixingDatesIDRef_ = fixingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDates_ = new AdjustableDatesOrRelativeDateOffset(fixingDatesNode);
                    }
                }
                else
                {
                    fixingDates_ = new AdjustableDatesOrRelativeDateOffset(fixingDatesNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference_
        private InterestLegCalculationPeriodDatesReference calculationPeriodDatesReference_;
        public InterestLegCalculationPeriodDatesReference CalculationPeriodDatesReference_
        {
            get
            {
                if (this.calculationPeriodDatesReference_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef_ != null)
                {
                    calculationPeriodDatesReference_ = IDManager.getID(calculationPeriodDatesReferenceIDRef_) as InterestLegCalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference_ != value)
                {
                    this.calculationPeriodDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesReferenceIDRef_ { get; set; }
        #region ResetRelativeTo_
        private ResetRelativeToEnum resetRelativeTo_;
        public ResetRelativeToEnum ResetRelativeTo_
        {
            get
            {
                if (this.resetRelativeTo_ != null)
                {
                    return this.resetRelativeTo_; 
                }
                else if (this.resetRelativeToIDRef_ != null)
                {
                    resetRelativeTo_ = IDManager.getID(resetRelativeToIDRef_) as ResetRelativeToEnum;
                    return this.resetRelativeTo_; 
                }
                else
                {
                      return this.resetRelativeTo_; 
                }
            }
            set
            {
                if (this.resetRelativeTo_ != value)
                {
                    this.resetRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string resetRelativeToIDRef_ { get; set; }
        #region ResetFrequency_
        private ResetFrequency resetFrequency_;
        public ResetFrequency ResetFrequency_
        {
            get
            {
                if (this.resetFrequency_ != null)
                {
                    return this.resetFrequency_; 
                }
                else if (this.resetFrequencyIDRef_ != null)
                {
                    resetFrequency_ = IDManager.getID(resetFrequencyIDRef_) as ResetFrequency;
                    return this.resetFrequency_; 
                }
                else
                {
                      return this.resetFrequency_; 
                }
            }
            set
            {
                if (this.resetFrequency_ != value)
                {
                    this.resetFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string resetFrequencyIDRef_ { get; set; }
        #region InitialFixingDate_
        private RelativeDateOffset initialFixingDate_;
        public RelativeDateOffset InitialFixingDate_
        {
            get
            {
                if (this.initialFixingDate_ != null)
                {
                    return this.initialFixingDate_; 
                }
                else if (this.initialFixingDateIDRef_ != null)
                {
                    initialFixingDate_ = IDManager.getID(initialFixingDateIDRef_) as RelativeDateOffset;
                    return this.initialFixingDate_; 
                }
                else
                {
                      return this.initialFixingDate_; 
                }
            }
            set
            {
                if (this.initialFixingDate_ != value)
                {
                    this.initialFixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string initialFixingDateIDRef_ { get; set; }
        #region FixingDates_
        private AdjustableDatesOrRelativeDateOffset fixingDates_;
        public AdjustableDatesOrRelativeDateOffset FixingDates_
        {
            get
            {
                if (this.fixingDates_ != null)
                {
                    return this.fixingDates_; 
                }
                else if (this.fixingDatesIDRef_ != null)
                {
                    fixingDates_ = IDManager.getID(fixingDatesIDRef_) as AdjustableDatesOrRelativeDateOffset;
                    return this.fixingDates_; 
                }
                else
                {
                      return this.fixingDates_; 
                }
            }
            set
            {
                if (this.fixingDates_ != value)
                {
                    this.fixingDates_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDatesIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

