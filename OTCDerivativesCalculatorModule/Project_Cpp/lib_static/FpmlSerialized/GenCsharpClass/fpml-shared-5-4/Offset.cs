using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Offset
    {
        public Offset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dayTypeNodeList = xmlNode.SelectNodes("dayType");
            if (dayTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayTypeIDRef = item.Attributes["id"].Name;
                        DayTypeEnum ob = DayTypeEnum();
                        IDManager.SetID(dayTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayType = new DayTypeEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region DayType
        private DayTypeEnum dayType;
        public DayTypeEnum DayType
        {
            get
            {
                if (this.dayType != null)
                {
                    return this.dayType; 
                }
                else if (this.dayTypeIDRef != null)
                {
                    dayType = IDManager.getID(dayTypeIDRef) as DayTypeEnum;
                    return this.dayType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayType != value)
                {
                    this.dayType = value;
                }
            }
        }
        #endregion
        
        public string DayTypeEnumIDRef { get; set; }
        
    
        
    
    }
    
}

