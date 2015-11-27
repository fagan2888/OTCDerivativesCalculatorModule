using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableDateOrRelativeDateSequence
    {
        public AdjustableDateOrRelativeDateSequence(XmlNode xmlNode)
        {
            XmlNodeList adjustableDateNodeList = xmlNode.SelectNodes("adjustableDate");
            if (adjustableDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustableDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustableDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(adjustableDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustableDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustableDate = new AdjustableDate(item);
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
            
        
        }
        
    
        #region AdjustableDate
        private AdjustableDate adjustableDate;
        public AdjustableDate AdjustableDate
        {
            get
            {
                if (this.adjustableDate != null)
                {
                    return this.adjustableDate; 
                }
                else if (this.adjustableDateIDRef != null)
                {
                    adjustableDate = IDManager.getID(adjustableDateIDRef) as AdjustableDate;
                    return this.adjustableDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustableDate != value)
                {
                    this.adjustableDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

