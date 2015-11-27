using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableRelativeOrPeriodicDates
    {
        public AdjustableRelativeOrPeriodicDates(XmlNode xmlNode)
        {
            XmlNodeList adjustableDatesNodeList = xmlNode.SelectNodes("adjustableDates");
            if (adjustableDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustableDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustableDatesIDRef = item.Attributes["id"].Name;
                        AdjustableDates ob = AdjustableDates();
                        IDManager.SetID(adjustableDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustableDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustableDates = new AdjustableDates(item);
                    }
                }
            }
            
        
            XmlNodeList relativeDateSequenceNodeList = xmlNode.SelectNodes("relativeDateSequence");
            if (relativeDateSequenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDateSequenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDateSequenceIDRef = item.Attributes["id"].Name;
                        RelativeDateSequence ob = RelativeDateSequence();
                        IDManager.SetID(relativeDateSequenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDateSequenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDateSequence = new RelativeDateSequence(item);
                    }
                }
            }
            
        
            XmlNodeList periodicDatesNodeList = xmlNode.SelectNodes("periodicDates");
            if (periodicDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodicDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodicDatesIDRef = item.Attributes["id"].Name;
                        PeriodicDates ob = PeriodicDates();
                        IDManager.SetID(periodicDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodicDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodicDates = new PeriodicDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region AdjustableDates
        private AdjustableDates adjustableDates;
        public AdjustableDates AdjustableDates
        {
            get
            {
                if (this.adjustableDates != null)
                {
                    return this.adjustableDates; 
                }
                else if (this.adjustableDatesIDRef != null)
                {
                    adjustableDates = IDManager.getID(adjustableDatesIDRef) as AdjustableDates;
                    return this.adjustableDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustableDates != value)
                {
                    this.adjustableDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
        #region RelativeDateSequence
        private RelativeDateSequence relativeDateSequence;
        public RelativeDateSequence RelativeDateSequence
        {
            get
            {
                if (this.relativeDateSequence != null)
                {
                    return this.relativeDateSequence; 
                }
                else if (this.relativeDateSequenceIDRef != null)
                {
                    relativeDateSequence = IDManager.getID(relativeDateSequenceIDRef) as RelativeDateSequence;
                    return this.relativeDateSequence; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDateSequence != value)
                {
                    this.relativeDateSequence = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateSequenceIDRef { get; set; }
        #region PeriodicDates
        private PeriodicDates periodicDates;
        public PeriodicDates PeriodicDates
        {
            get
            {
                if (this.periodicDates != null)
                {
                    return this.periodicDates; 
                }
                else if (this.periodicDatesIDRef != null)
                {
                    periodicDates = IDManager.getID(periodicDatesIDRef) as PeriodicDates;
                    return this.periodicDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodicDates != value)
                {
                    this.periodicDates = value;
                }
            }
        }
        #endregion
        
        public string PeriodicDatesIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

