using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EarlyTerminationEvent
    {
        public EarlyTerminationEvent(XmlNode xmlNode)
        {
            XmlNodeList adjustedExerciseDateNodeList = xmlNode.SelectNodes("adjustedExerciseDate");
            if (adjustedExerciseDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedExerciseDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedExerciseDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedExerciseDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedExerciseDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedExerciseDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedEarlyTerminationDateNodeList = xmlNode.SelectNodes("adjustedEarlyTerminationDate");
            if (adjustedEarlyTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedEarlyTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedEarlyTerminationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedEarlyTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedEarlyTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedEarlyTerminationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedCashSettlementValuationDateNodeList = xmlNode.SelectNodes("adjustedCashSettlementValuationDate");
            if (adjustedCashSettlementValuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedCashSettlementValuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedCashSettlementValuationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedCashSettlementValuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedCashSettlementValuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedCashSettlementValuationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedCashSettlementPaymentDateNodeList = xmlNode.SelectNodes("adjustedCashSettlementPaymentDate");
            if (adjustedCashSettlementPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedCashSettlementPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedCashSettlementPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedCashSettlementPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedCashSettlementPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedCashSettlementPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedExerciseFeePaymentDateNodeList = xmlNode.SelectNodes("adjustedExerciseFeePaymentDate");
            if (adjustedExerciseFeePaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedExerciseFeePaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedExerciseFeePaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedExerciseFeePaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedExerciseFeePaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedExerciseFeePaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region AdjustedExerciseDate
        private XsdTypeDate adjustedExerciseDate;
        public XsdTypeDate AdjustedExerciseDate
        {
            get
            {
                if (this.adjustedExerciseDate != null)
                {
                    return this.adjustedExerciseDate; 
                }
                else if (this.adjustedExerciseDateIDRef != null)
                {
                    adjustedExerciseDate = IDManager.getID(adjustedExerciseDateIDRef) as XsdTypeDate;
                    return this.adjustedExerciseDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedExerciseDate != value)
                {
                    this.adjustedExerciseDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedEarlyTerminationDate
        private XsdTypeDate adjustedEarlyTerminationDate;
        public XsdTypeDate AdjustedEarlyTerminationDate
        {
            get
            {
                if (this.adjustedEarlyTerminationDate != null)
                {
                    return this.adjustedEarlyTerminationDate; 
                }
                else if (this.adjustedEarlyTerminationDateIDRef != null)
                {
                    adjustedEarlyTerminationDate = IDManager.getID(adjustedEarlyTerminationDateIDRef) as XsdTypeDate;
                    return this.adjustedEarlyTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedEarlyTerminationDate != value)
                {
                    this.adjustedEarlyTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedCashSettlementValuationDate
        private XsdTypeDate adjustedCashSettlementValuationDate;
        public XsdTypeDate AdjustedCashSettlementValuationDate
        {
            get
            {
                if (this.adjustedCashSettlementValuationDate != null)
                {
                    return this.adjustedCashSettlementValuationDate; 
                }
                else if (this.adjustedCashSettlementValuationDateIDRef != null)
                {
                    adjustedCashSettlementValuationDate = IDManager.getID(adjustedCashSettlementValuationDateIDRef) as XsdTypeDate;
                    return this.adjustedCashSettlementValuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedCashSettlementValuationDate != value)
                {
                    this.adjustedCashSettlementValuationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedCashSettlementPaymentDate
        private XsdTypeDate adjustedCashSettlementPaymentDate;
        public XsdTypeDate AdjustedCashSettlementPaymentDate
        {
            get
            {
                if (this.adjustedCashSettlementPaymentDate != null)
                {
                    return this.adjustedCashSettlementPaymentDate; 
                }
                else if (this.adjustedCashSettlementPaymentDateIDRef != null)
                {
                    adjustedCashSettlementPaymentDate = IDManager.getID(adjustedCashSettlementPaymentDateIDRef) as XsdTypeDate;
                    return this.adjustedCashSettlementPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedCashSettlementPaymentDate != value)
                {
                    this.adjustedCashSettlementPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedExerciseFeePaymentDate
        private XsdTypeDate adjustedExerciseFeePaymentDate;
        public XsdTypeDate AdjustedExerciseFeePaymentDate
        {
            get
            {
                if (this.adjustedExerciseFeePaymentDate != null)
                {
                    return this.adjustedExerciseFeePaymentDate; 
                }
                else if (this.adjustedExerciseFeePaymentDateIDRef != null)
                {
                    adjustedExerciseFeePaymentDate = IDManager.getID(adjustedExerciseFeePaymentDateIDRef) as XsdTypeDate;
                    return this.adjustedExerciseFeePaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedExerciseFeePaymentDate != value)
                {
                    this.adjustedExerciseFeePaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

