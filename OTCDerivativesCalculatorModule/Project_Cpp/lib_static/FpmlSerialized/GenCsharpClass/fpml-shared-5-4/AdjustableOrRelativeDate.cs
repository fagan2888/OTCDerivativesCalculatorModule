using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableOrRelativeDate
    {
        public AdjustableOrRelativeDate(XmlNode xmlNode)
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

