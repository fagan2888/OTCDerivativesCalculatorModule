using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustableOrRelativeDates
    {
        public AdjustableOrRelativeDates(XmlNode xmlNode)
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
            
        
            XmlNodeList relativeDatesNodeList = xmlNode.SelectNodes("relativeDates");
            if (relativeDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDatesIDRef = item.Attributes["id"].Name;
                        RelativeDates ob = RelativeDates();
                        IDManager.SetID(relativeDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDates = new RelativeDates(item);
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
        #region RelativeDates
        private RelativeDates relativeDates;
        public RelativeDates RelativeDates
        {
            get
            {
                if (this.relativeDates != null)
                {
                    return this.relativeDates; 
                }
                else if (this.relativeDatesIDRef != null)
                {
                    relativeDates = IDManager.getID(relativeDatesIDRef) as RelativeDates;
                    return this.relativeDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDates != value)
                {
                    this.relativeDates = value;
                }
            }
        }
        #endregion
        
        public string RelativeDatesIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

