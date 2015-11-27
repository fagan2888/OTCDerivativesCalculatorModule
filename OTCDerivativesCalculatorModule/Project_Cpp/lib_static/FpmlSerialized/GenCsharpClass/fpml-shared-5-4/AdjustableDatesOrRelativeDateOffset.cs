using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableDatesOrRelativeDateOffset
    {
        public AdjustableDatesOrRelativeDateOffset(XmlNode xmlNode)
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
            
        
            XmlNodeList relativeDateNodeList = xmlNode.SelectNodes("relativeDate");
            if (relativeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(relativeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDate = new RelativeDateOffset(item);
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
        #region RelativeDate
        private RelativeDateOffset relativeDate;
        public RelativeDateOffset RelativeDate
        {
            get
            {
                if (this.relativeDate != null)
                {
                    return this.relativeDate; 
                }
                else if (this.relativeDateIDRef != null)
                {
                    relativeDate = IDManager.getID(relativeDateIDRef) as RelativeDateOffset;
                    return this.relativeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDate != value)
                {
                    this.relativeDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

