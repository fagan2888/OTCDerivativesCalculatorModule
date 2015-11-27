using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RelativeDates
    {
        public RelativeDates(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList periodSkipNodeList = xmlNode.SelectNodes("periodSkip");
            if (periodSkipNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodSkipNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodSkipIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(periodSkipIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodSkipIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodSkip = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList scheduleBoundsNodeList = xmlNode.SelectNodes("scheduleBounds");
            if (scheduleBoundsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in scheduleBoundsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scheduleBoundsIDRef = item.Attributes["id"].Name;
                        DateRange ob = DateRange();
                        IDManager.SetID(scheduleBoundsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scheduleBoundsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        scheduleBounds = new DateRange(item);
                    }
                }
            }
            
        
        }
        
    
        #region PeriodSkip
        private XsdTypePositiveInteger periodSkip;
        public XsdTypePositiveInteger PeriodSkip
        {
            get
            {
                if (this.periodSkip != null)
                {
                    return this.periodSkip; 
                }
                else if (this.periodSkipIDRef != null)
                {
                    periodSkip = IDManager.getID(periodSkipIDRef) as XsdTypePositiveInteger;
                    return this.periodSkip; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodSkip != value)
                {
                    this.periodSkip = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region ScheduleBounds
        private DateRange scheduleBounds;
        public DateRange ScheduleBounds
        {
            get
            {
                if (this.scheduleBounds != null)
                {
                    return this.scheduleBounds; 
                }
                else if (this.scheduleBoundsIDRef != null)
                {
                    scheduleBounds = IDManager.getID(scheduleBoundsIDRef) as DateRange;
                    return this.scheduleBounds; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.scheduleBounds != value)
                {
                    this.scheduleBounds = value;
                }
            }
        }
        #endregion
        
        public string DateRangeIDRef { get; set; }
        
    
        
    
    }
    
}

