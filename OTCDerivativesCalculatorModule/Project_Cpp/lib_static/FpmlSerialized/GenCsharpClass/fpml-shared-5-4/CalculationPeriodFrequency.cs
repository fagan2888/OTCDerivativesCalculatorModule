using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodFrequency
    {
        public CalculationPeriodFrequency(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList rollConventionNodeList = xmlNode.SelectNodes("rollConvention");
            if (rollConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rollConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rollConventionIDRef = item.Attributes["id"].Name;
                        RollConventionEnum ob = RollConventionEnum();
                        IDManager.SetID(rollConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rollConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rollConvention = new RollConventionEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region RollConvention
        private RollConventionEnum rollConvention;
        public RollConventionEnum RollConvention
        {
            get
            {
                if (this.rollConvention != null)
                {
                    return this.rollConvention; 
                }
                else if (this.rollConventionIDRef != null)
                {
                    rollConvention = IDManager.getID(rollConventionIDRef) as RollConventionEnum;
                    return this.rollConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rollConvention != value)
                {
                    this.rollConvention = value;
                }
            }
        }
        #endregion
        
        public string RollConventionEnumIDRef { get; set; }
        
    
        
    
    }
    
}

