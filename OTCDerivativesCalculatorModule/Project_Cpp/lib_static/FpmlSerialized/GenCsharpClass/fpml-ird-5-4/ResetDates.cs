using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ResetDates
    {
        public ResetDates(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            if (calculationPeriodDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodDatesReference ob = CalculationPeriodDatesReference();
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDatesReference = new CalculationPeriodDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList resetRelativeToNodeList = xmlNode.SelectNodes("resetRelativeTo");
            if (resetRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetRelativeToIDRef = item.Attributes["id"].Name;
                        ResetRelativeToEnum ob = ResetRelativeToEnum();
                        IDManager.SetID(resetRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetRelativeTo = new ResetRelativeToEnum(item);
                    }
                }
            }
            
        
            XmlNodeList initialFixingDateNodeList = xmlNode.SelectNodes("initialFixingDate");
            if (initialFixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialFixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialFixingDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(initialFixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialFixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialFixingDate = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList fixingDatesNodeList = xmlNode.SelectNodes("fixingDates");
            if (fixingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingDatesIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(fixingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingDates = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList rateCutOffDaysOffsetNodeList = xmlNode.SelectNodes("rateCutOffDaysOffset");
            if (rateCutOffDaysOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateCutOffDaysOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateCutOffDaysOffsetIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(rateCutOffDaysOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateCutOffDaysOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateCutOffDaysOffset = new Offset(item);
                    }
                }
            }
            
        
            XmlNodeList resetFrequencyNodeList = xmlNode.SelectNodes("resetFrequency");
            if (resetFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetFrequencyIDRef = item.Attributes["id"].Name;
                        ResetFrequency ob = ResetFrequency();
                        IDManager.SetID(resetFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetFrequency = new ResetFrequency(item);
                    }
                }
            }
            
        
            XmlNodeList resetDatesAdjustmentsNodeList = xmlNode.SelectNodes("resetDatesAdjustments");
            if (resetDatesAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetDatesAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetDatesAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(resetDatesAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetDatesAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetDatesAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference
        private CalculationPeriodDatesReference calculationPeriodDatesReference;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference
        {
            get
            {
                if (this.calculationPeriodDatesReference != null)
                {
                    return this.calculationPeriodDatesReference; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef != null)
                {
                    calculationPeriodDatesReference = IDManager.getID(calculationPeriodDatesReferenceIDRef) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference != value)
                {
                    this.calculationPeriodDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodDatesReferenceIDRef { get; set; }
        #region ResetRelativeTo
        private ResetRelativeToEnum resetRelativeTo;
        public ResetRelativeToEnum ResetRelativeTo
        {
            get
            {
                if (this.resetRelativeTo != null)
                {
                    return this.resetRelativeTo; 
                }
                else if (this.resetRelativeToIDRef != null)
                {
                    resetRelativeTo = IDManager.getID(resetRelativeToIDRef) as ResetRelativeToEnum;
                    return this.resetRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetRelativeTo != value)
                {
                    this.resetRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string ResetRelativeToEnumIDRef { get; set; }
        #region InitialFixingDate
        private RelativeDateOffset initialFixingDate;
        public RelativeDateOffset InitialFixingDate
        {
            get
            {
                if (this.initialFixingDate != null)
                {
                    return this.initialFixingDate; 
                }
                else if (this.initialFixingDateIDRef != null)
                {
                    initialFixingDate = IDManager.getID(initialFixingDateIDRef) as RelativeDateOffset;
                    return this.initialFixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialFixingDate != value)
                {
                    this.initialFixingDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region FixingDates
        private RelativeDateOffset fixingDates;
        public RelativeDateOffset FixingDates
        {
            get
            {
                if (this.fixingDates != null)
                {
                    return this.fixingDates; 
                }
                else if (this.fixingDatesIDRef != null)
                {
                    fixingDates = IDManager.getID(fixingDatesIDRef) as RelativeDateOffset;
                    return this.fixingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingDates != value)
                {
                    this.fixingDates = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region RateCutOffDaysOffset
        private Offset rateCutOffDaysOffset;
        public Offset RateCutOffDaysOffset
        {
            get
            {
                if (this.rateCutOffDaysOffset != null)
                {
                    return this.rateCutOffDaysOffset; 
                }
                else if (this.rateCutOffDaysOffsetIDRef != null)
                {
                    rateCutOffDaysOffset = IDManager.getID(rateCutOffDaysOffsetIDRef) as Offset;
                    return this.rateCutOffDaysOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateCutOffDaysOffset != value)
                {
                    this.rateCutOffDaysOffset = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        #region ResetFrequency
        private ResetFrequency resetFrequency;
        public ResetFrequency ResetFrequency
        {
            get
            {
                if (this.resetFrequency != null)
                {
                    return this.resetFrequency; 
                }
                else if (this.resetFrequencyIDRef != null)
                {
                    resetFrequency = IDManager.getID(resetFrequencyIDRef) as ResetFrequency;
                    return this.resetFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetFrequency != value)
                {
                    this.resetFrequency = value;
                }
            }
        }
        #endregion
        
        public string ResetFrequencyIDRef { get; set; }
        #region ResetDatesAdjustments
        private BusinessDayAdjustments resetDatesAdjustments;
        public BusinessDayAdjustments ResetDatesAdjustments
        {
            get
            {
                if (this.resetDatesAdjustments != null)
                {
                    return this.resetDatesAdjustments; 
                }
                else if (this.resetDatesAdjustmentsIDRef != null)
                {
                    resetDatesAdjustments = IDManager.getID(resetDatesAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.resetDatesAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetDatesAdjustments != value)
                {
                    this.resetDatesAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        
    
        
    
    }
    
}

