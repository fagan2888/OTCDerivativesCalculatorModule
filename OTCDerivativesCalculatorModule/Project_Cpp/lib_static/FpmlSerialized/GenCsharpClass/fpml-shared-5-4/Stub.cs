using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Stub
    {
        public Stub(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList stubStartDateNodeList = xmlNode.SelectNodes("stubStartDate");
            if (stubStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubStartDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(stubStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubStartDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList stubEndDateNodeList = xmlNode.SelectNodes("stubEndDate");
            if (stubEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubEndDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(stubEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubEndDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region StubStartDate
        private AdjustableOrRelativeDate stubStartDate;
        public AdjustableOrRelativeDate StubStartDate
        {
            get
            {
                if (this.stubStartDate != null)
                {
                    return this.stubStartDate; 
                }
                else if (this.stubStartDateIDRef != null)
                {
                    stubStartDate = IDManager.getID(stubStartDateIDRef) as AdjustableOrRelativeDate;
                    return this.stubStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubStartDate != value)
                {
                    this.stubStartDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region StubEndDate
        private AdjustableOrRelativeDate stubEndDate;
        public AdjustableOrRelativeDate StubEndDate
        {
            get
            {
                if (this.stubEndDate != null)
                {
                    return this.stubEndDate; 
                }
                else if (this.stubEndDateIDRef != null)
                {
                    stubEndDate = IDManager.getID(stubEndDateIDRef) as AdjustableOrRelativeDate;
                    return this.stubEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubEndDate != value)
                {
                    this.stubEndDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}

