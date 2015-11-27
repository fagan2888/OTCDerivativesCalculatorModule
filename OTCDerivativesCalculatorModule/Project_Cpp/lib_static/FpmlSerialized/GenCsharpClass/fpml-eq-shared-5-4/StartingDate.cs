using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StartingDate
    {
        public StartingDate(XmlNode xmlNode)
        {
            XmlNodeList dateRelativeToNodeList = xmlNode.SelectNodes("dateRelativeTo");
            if (dateRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateRelativeToIDRef = item.Attributes["id"].Name;
                        DateReference ob = DateReference();
                        IDManager.SetID(dateRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateRelativeTo = new DateReference(item);
                    }
                }
            }
            
        
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
            
        
        }
        
    
        #region DateRelativeTo
        private DateReference dateRelativeTo;
        public DateReference DateRelativeTo
        {
            get
            {
                if (this.dateRelativeTo != null)
                {
                    return this.dateRelativeTo; 
                }
                else if (this.dateRelativeToIDRef != null)
                {
                    dateRelativeTo = IDManager.getID(dateRelativeToIDRef) as DateReference;
                    return this.dateRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateRelativeTo != value)
                {
                    this.dateRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string DateReferenceIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

