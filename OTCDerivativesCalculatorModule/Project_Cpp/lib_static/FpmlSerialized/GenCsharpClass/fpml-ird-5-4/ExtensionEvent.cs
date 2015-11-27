using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExtensionEvent
    {
        public ExtensionEvent(XmlNode xmlNode)
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
            
        
            XmlNodeList adjustedExtendedTerminationDateNodeList = xmlNode.SelectNodes("adjustedExtendedTerminationDate");
            if (adjustedExtendedTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedExtendedTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedExtendedTerminationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedExtendedTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedExtendedTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedExtendedTerminationDate = new XsdTypeDate(item);
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
        #region AdjustedExtendedTerminationDate
        private XsdTypeDate adjustedExtendedTerminationDate;
        public XsdTypeDate AdjustedExtendedTerminationDate
        {
            get
            {
                if (this.adjustedExtendedTerminationDate != null)
                {
                    return this.adjustedExtendedTerminationDate; 
                }
                else if (this.adjustedExtendedTerminationDateIDRef != null)
                {
                    adjustedExtendedTerminationDate = IDManager.getID(adjustedExtendedTerminationDateIDRef) as XsdTypeDate;
                    return this.adjustedExtendedTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedExtendedTerminationDate != value)
                {
                    this.adjustedExtendedTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

