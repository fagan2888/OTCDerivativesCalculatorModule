using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityEuropeanExercise
    {
        public CommodityEuropeanExercise(XmlNode xmlNode)
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
            
        
            XmlNodeList exerciseFrequencyNodeList = xmlNode.SelectNodes("exerciseFrequency");
            if (exerciseFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseFrequencyIDRef = item.Attributes["id"].Name;
                        Frequency ob = Frequency();
                        IDManager.SetID(exerciseFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseFrequency = new Frequency(item);
                    }
                }
            }
            
        
            XmlNodeList expirationTimeNodeList = xmlNode.SelectNodes("expirationTime");
            if (expirationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(expirationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationTime = new BusinessCenterTime(item);
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
        #region ExerciseFrequency
        private Frequency exerciseFrequency;
        public Frequency ExerciseFrequency
        {
            get
            {
                if (this.exerciseFrequency != null)
                {
                    return this.exerciseFrequency; 
                }
                else if (this.exerciseFrequencyIDRef != null)
                {
                    exerciseFrequency = IDManager.getID(exerciseFrequencyIDRef) as Frequency;
                    return this.exerciseFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseFrequency != value)
                {
                    this.exerciseFrequency = value;
                }
            }
        }
        #endregion
        
        public string FrequencyIDRef { get; set; }
        #region ExpirationTime
        private BusinessCenterTime expirationTime;
        public BusinessCenterTime ExpirationTime
        {
            get
            {
                if (this.expirationTime != null)
                {
                    return this.expirationTime; 
                }
                else if (this.expirationTimeIDRef != null)
                {
                    expirationTime = IDManager.getID(expirationTimeIDRef) as BusinessCenterTime;
                    return this.expirationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationTime != value)
                {
                    this.expirationTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        
    
        
    
    }
    
}

