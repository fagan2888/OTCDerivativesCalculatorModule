using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityEuropeanExercise
    {
        public EquityEuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList expirationDateNodeList = xmlNode.SelectNodes("expirationDate");
            if (expirationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(expirationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList equityExpirationTimeTypeNodeList = xmlNode.SelectNodes("equityExpirationTimeType");
            if (equityExpirationTimeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityExpirationTimeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityExpirationTimeTypeIDRef = item.Attributes["id"].Name;
                        TimeTypeEnum ob = TimeTypeEnum();
                        IDManager.SetID(equityExpirationTimeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityExpirationTimeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityExpirationTimeType = new TimeTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList equityExpirationTimeNodeList = xmlNode.SelectNodes("equityExpirationTime");
            if (equityExpirationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityExpirationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityExpirationTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(equityExpirationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityExpirationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityExpirationTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList expirationTimeDeterminationNodeList = xmlNode.SelectNodes("expirationTimeDetermination");
            if (expirationTimeDeterminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationTimeDeterminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationTimeDeterminationIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(expirationTimeDeterminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationTimeDeterminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationTimeDetermination = new DeterminationMethod(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExpirationDate
        private AdjustableOrRelativeDate expirationDate;
        public AdjustableOrRelativeDate ExpirationDate
        {
            get
            {
                if (this.expirationDate != null)
                {
                    return this.expirationDate; 
                }
                else if (this.expirationDateIDRef != null)
                {
                    expirationDate = IDManager.getID(expirationDateIDRef) as AdjustableOrRelativeDate;
                    return this.expirationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDate != value)
                {
                    this.expirationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region EquityExpirationTimeType
        private TimeTypeEnum equityExpirationTimeType;
        public TimeTypeEnum EquityExpirationTimeType
        {
            get
            {
                if (this.equityExpirationTimeType != null)
                {
                    return this.equityExpirationTimeType; 
                }
                else if (this.equityExpirationTimeTypeIDRef != null)
                {
                    equityExpirationTimeType = IDManager.getID(equityExpirationTimeTypeIDRef) as TimeTypeEnum;
                    return this.equityExpirationTimeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityExpirationTimeType != value)
                {
                    this.equityExpirationTimeType = value;
                }
            }
        }
        #endregion
        
        public string TimeTypeEnumIDRef { get; set; }
        #region EquityExpirationTime
        private BusinessCenterTime equityExpirationTime;
        public BusinessCenterTime EquityExpirationTime
        {
            get
            {
                if (this.equityExpirationTime != null)
                {
                    return this.equityExpirationTime; 
                }
                else if (this.equityExpirationTimeIDRef != null)
                {
                    equityExpirationTime = IDManager.getID(equityExpirationTimeIDRef) as BusinessCenterTime;
                    return this.equityExpirationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityExpirationTime != value)
                {
                    this.equityExpirationTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region ExpirationTimeDetermination
        private DeterminationMethod expirationTimeDetermination;
        public DeterminationMethod ExpirationTimeDetermination
        {
            get
            {
                if (this.expirationTimeDetermination != null)
                {
                    return this.expirationTimeDetermination; 
                }
                else if (this.expirationTimeDeterminationIDRef != null)
                {
                    expirationTimeDetermination = IDManager.getID(expirationTimeDeterminationIDRef) as DeterminationMethod;
                    return this.expirationTimeDetermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationTimeDetermination != value)
                {
                    this.expirationTimeDetermination = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

