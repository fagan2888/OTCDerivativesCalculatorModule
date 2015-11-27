using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ResetFrequency
    {
        public ResetFrequency(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList weeklyRollConventionNodeList = xmlNode.SelectNodes("weeklyRollConvention");
            if (weeklyRollConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weeklyRollConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weeklyRollConventionIDRef = item.Attributes["id"].Name;
                        WeeklyRollConventionEnum ob = WeeklyRollConventionEnum();
                        IDManager.SetID(weeklyRollConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weeklyRollConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weeklyRollConvention = new WeeklyRollConventionEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region WeeklyRollConvention
        private WeeklyRollConventionEnum weeklyRollConvention;
        public WeeklyRollConventionEnum WeeklyRollConvention
        {
            get
            {
                if (this.weeklyRollConvention != null)
                {
                    return this.weeklyRollConvention; 
                }
                else if (this.weeklyRollConventionIDRef != null)
                {
                    weeklyRollConvention = IDManager.getID(weeklyRollConventionIDRef) as WeeklyRollConventionEnum;
                    return this.weeklyRollConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weeklyRollConvention != value)
                {
                    this.weeklyRollConvention = value;
                }
            }
        }
        #endregion
        
        public string WeeklyRollConventionEnumIDRef { get; set; }
        
    
        
    
    }
    
}

