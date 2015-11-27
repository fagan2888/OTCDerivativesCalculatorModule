using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingRate
    {
        public FloatingRate(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList floatingRateIndexNodeList = xmlNode.SelectNodes("floatingRateIndex");
            if (floatingRateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef = item.Attributes["id"].Name;
                        FloatingRateIndex ob = FloatingRateIndex();
                        IDManager.SetID(floatingRateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateIndex = new FloatingRateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList indexTenorNodeList = xmlNode.SelectNodes("indexTenor");
            if (indexTenorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexTenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTenorIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(indexTenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexTenor = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList floatingRateMultiplierScheduleNodeList = xmlNode.SelectNodes("floatingRateMultiplierSchedule");
            if (floatingRateMultiplierScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateMultiplierScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateMultiplierScheduleIDRef = item.Attributes["id"].Name;
                        Schedule ob = Schedule();
                        IDManager.SetID(floatingRateMultiplierScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateMultiplierScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateMultiplierSchedule = new Schedule(item);
                    }
                }
            }
            
        
            XmlNodeList spreadScheduleNodeList = xmlNode.SelectNodes("spreadSchedule");
            
            foreach (XmlNode item in spreadScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadScheduleIDRef = item.Attributes["id"].Name;
                        List<SpreadSchedule> ob = new List<SpreadSchedule>();
                        ob.Add(new SpreadSchedule(item));
                        IDManager.SetID(spreadScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    spreadSchedule.Add(new SpreadSchedule(item));
                    }
                }
            }
            
        
            XmlNodeList rateTreatmentNodeList = xmlNode.SelectNodes("rateTreatment");
            if (rateTreatmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateTreatmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateTreatmentIDRef = item.Attributes["id"].Name;
                        RateTreatmentEnum ob = RateTreatmentEnum();
                        IDManager.SetID(rateTreatmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateTreatmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateTreatment = new RateTreatmentEnum(item);
                    }
                }
            }
            
        
            XmlNodeList capRateScheduleNodeList = xmlNode.SelectNodes("capRateSchedule");
            
            foreach (XmlNode item in capRateScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        capRateScheduleIDRef = item.Attributes["id"].Name;
                        List<StrikeSchedule> ob = new List<StrikeSchedule>();
                        ob.Add(new StrikeSchedule(item));
                        IDManager.SetID(capRateScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        capRateScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    capRateSchedule.Add(new StrikeSchedule(item));
                    }
                }
            }
            
        
            XmlNodeList floorRateScheduleNodeList = xmlNode.SelectNodes("floorRateSchedule");
            
            foreach (XmlNode item in floorRateScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floorRateScheduleIDRef = item.Attributes["id"].Name;
                        List<StrikeSchedule> ob = new List<StrikeSchedule>();
                        ob.Add(new StrikeSchedule(item));
                        IDManager.SetID(floorRateScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floorRateScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    floorRateSchedule.Add(new StrikeSchedule(item));
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRateIndex
        private FloatingRateIndex floatingRateIndex;
        public FloatingRateIndex FloatingRateIndex
        {
            get
            {
                if (this.floatingRateIndex != null)
                {
                    return this.floatingRateIndex; 
                }
                else if (this.floatingRateIndexIDRef != null)
                {
                    floatingRateIndex = IDManager.getID(floatingRateIndexIDRef) as FloatingRateIndex;
                    return this.floatingRateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateIndex != value)
                {
                    this.floatingRateIndex = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIndexIDRef { get; set; }
        #region IndexTenor
        private Period indexTenor;
        public Period IndexTenor
        {
            get
            {
                if (this.indexTenor != null)
                {
                    return this.indexTenor; 
                }
                else if (this.indexTenorIDRef != null)
                {
                    indexTenor = IDManager.getID(indexTenorIDRef) as Period;
                    return this.indexTenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexTenor != value)
                {
                    this.indexTenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region FloatingRateMultiplierSchedule
        private Schedule floatingRateMultiplierSchedule;
        public Schedule FloatingRateMultiplierSchedule
        {
            get
            {
                if (this.floatingRateMultiplierSchedule != null)
                {
                    return this.floatingRateMultiplierSchedule; 
                }
                else if (this.floatingRateMultiplierScheduleIDRef != null)
                {
                    floatingRateMultiplierSchedule = IDManager.getID(floatingRateMultiplierScheduleIDRef) as Schedule;
                    return this.floatingRateMultiplierSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateMultiplierSchedule != value)
                {
                    this.floatingRateMultiplierSchedule = value;
                }
            }
        }
        #endregion
        
        public string ScheduleIDRef { get; set; }
        #region SpreadSchedule
        private List<SpreadSchedule> spreadSchedule;
        public List<SpreadSchedule> SpreadSchedule
        {
            get
            {
                if (this.spreadSchedule != null)
                {
                    return this.spreadSchedule; 
                }
                else if (this.spreadScheduleIDRef != null)
                {
                    spreadSchedule = IDManager.getID(spreadScheduleIDRef) as List<SpreadSchedule>;
                    return this.spreadSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadSchedule != value)
                {
                    this.spreadSchedule = value;
                }
            }
        }
        #endregion
        
        public string SpreadScheduleIDRef { get; set; }
        #region RateTreatment
        private RateTreatmentEnum rateTreatment;
        public RateTreatmentEnum RateTreatment
        {
            get
            {
                if (this.rateTreatment != null)
                {
                    return this.rateTreatment; 
                }
                else if (this.rateTreatmentIDRef != null)
                {
                    rateTreatment = IDManager.getID(rateTreatmentIDRef) as RateTreatmentEnum;
                    return this.rateTreatment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateTreatment != value)
                {
                    this.rateTreatment = value;
                }
            }
        }
        #endregion
        
        public string RateTreatmentEnumIDRef { get; set; }
        #region CapRateSchedule
        private List<StrikeSchedule> capRateSchedule;
        public List<StrikeSchedule> CapRateSchedule
        {
            get
            {
                if (this.capRateSchedule != null)
                {
                    return this.capRateSchedule; 
                }
                else if (this.capRateScheduleIDRef != null)
                {
                    capRateSchedule = IDManager.getID(capRateScheduleIDRef) as List<StrikeSchedule>;
                    return this.capRateSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.capRateSchedule != value)
                {
                    this.capRateSchedule = value;
                }
            }
        }
        #endregion
        
        public string StrikeScheduleIDRef { get; set; }
        #region FloorRateSchedule
        private List<StrikeSchedule> floorRateSchedule;
        public List<StrikeSchedule> FloorRateSchedule
        {
            get
            {
                if (this.floorRateSchedule != null)
                {
                    return this.floorRateSchedule; 
                }
                else if (this.floorRateScheduleIDRef != null)
                {
                    floorRateSchedule = IDManager.getID(floorRateScheduleIDRef) as List<StrikeSchedule>;
                    return this.floorRateSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floorRateSchedule != value)
                {
                    this.floorRateSchedule = value;
                }
            }
        }
        #endregion
        
        public string StrikeScheduleIDRef { get; set; }
        
    
        
    
    }
    
}

