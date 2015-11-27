using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CancellationEvent
    {
        public CancellationEvent(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

