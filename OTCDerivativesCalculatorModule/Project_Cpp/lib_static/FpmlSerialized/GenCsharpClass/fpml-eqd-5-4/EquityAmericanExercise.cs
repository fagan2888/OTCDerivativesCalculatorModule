using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityAmericanExercise
    {
        public EquityAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList latestExerciseTimeTypeNodeList = xmlNode.SelectNodes("latestExerciseTimeType");
            if (latestExerciseTimeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in latestExerciseTimeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        latestExerciseTimeTypeIDRef = item.Attributes["id"].Name;
                        TimeTypeEnum ob = TimeTypeEnum();
                        IDManager.SetID(latestExerciseTimeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        latestExerciseTimeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        latestExerciseTimeType = new TimeTypeEnum(item);
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
            
        
            XmlNodeList equityMultipleExerciseNodeList = xmlNode.SelectNodes("equityMultipleExercise");
            if (equityMultipleExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityMultipleExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityMultipleExerciseIDRef = item.Attributes["id"].Name;
                        EquityMultipleExercise ob = EquityMultipleExercise();
                        IDManager.SetID(equityMultipleExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityMultipleExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityMultipleExercise = new EquityMultipleExercise(item);
                    }
                }
            }
            
        
        }
        
    
        #region LatestExerciseTimeType
        private TimeTypeEnum latestExerciseTimeType;
        public TimeTypeEnum LatestExerciseTimeType
        {
            get
            {
                if (this.latestExerciseTimeType != null)
                {
                    return this.latestExerciseTimeType; 
                }
                else if (this.latestExerciseTimeTypeIDRef != null)
                {
                    latestExerciseTimeType = IDManager.getID(latestExerciseTimeTypeIDRef) as TimeTypeEnum;
                    return this.latestExerciseTimeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.latestExerciseTimeType != value)
                {
                    this.latestExerciseTimeType = value;
                }
            }
        }
        #endregion
        
        public string TimeTypeEnumIDRef { get; set; }
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
        #region EquityMultipleExercise
        private EquityMultipleExercise equityMultipleExercise;
        public EquityMultipleExercise EquityMultipleExercise
        {
            get
            {
                if (this.equityMultipleExercise != null)
                {
                    return this.equityMultipleExercise; 
                }
                else if (this.equityMultipleExerciseIDRef != null)
                {
                    equityMultipleExercise = IDManager.getID(equityMultipleExerciseIDRef) as EquityMultipleExercise;
                    return this.equityMultipleExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityMultipleExercise != value)
                {
                    this.equityMultipleExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityMultipleExerciseIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

