using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EarlyTerminationProvision
    {
        public EarlyTerminationProvision(XmlNode xmlNode)
        {
            XmlNodeList mandatoryEarlyTerminationNodeList = xmlNode.SelectNodes("mandatoryEarlyTermination");
            if (mandatoryEarlyTerminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mandatoryEarlyTerminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationIDRef = item.Attributes["id"].Name;
                        MandatoryEarlyTermination ob = MandatoryEarlyTermination();
                        IDManager.SetID(mandatoryEarlyTerminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mandatoryEarlyTerminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mandatoryEarlyTermination = new MandatoryEarlyTermination(item);
                    }
                }
            }
            
        
            XmlNodeList mandatoryEarlyTerminationDateTenorNodeList = xmlNode.SelectNodes("mandatoryEarlyTerminationDateTenor");
            if (mandatoryEarlyTerminationDateTenorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mandatoryEarlyTerminationDateTenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationDateTenorIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(mandatoryEarlyTerminationDateTenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mandatoryEarlyTerminationDateTenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mandatoryEarlyTerminationDateTenor = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList optionalEarlyTerminationNodeList = xmlNode.SelectNodes("optionalEarlyTermination");
            if (optionalEarlyTerminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionalEarlyTerminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationIDRef = item.Attributes["id"].Name;
                        OptionalEarlyTermination ob = OptionalEarlyTermination();
                        IDManager.SetID(optionalEarlyTerminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionalEarlyTerminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionalEarlyTermination = new OptionalEarlyTermination(item);
                    }
                }
            }
            
        
            XmlNodeList optionalEarlyTerminationParametersNodeList = xmlNode.SelectNodes("optionalEarlyTerminationParameters");
            if (optionalEarlyTerminationParametersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionalEarlyTerminationParametersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationParametersIDRef = item.Attributes["id"].Name;
                        ExercisePeriod ob = ExercisePeriod();
                        IDManager.SetID(optionalEarlyTerminationParametersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionalEarlyTerminationParametersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionalEarlyTerminationParameters = new ExercisePeriod(item);
                    }
                }
            }
            
        
        }
        
    
        #region MandatoryEarlyTermination
        private MandatoryEarlyTermination mandatoryEarlyTermination;
        public MandatoryEarlyTermination MandatoryEarlyTermination
        {
            get
            {
                if (this.mandatoryEarlyTermination != null)
                {
                    return this.mandatoryEarlyTermination; 
                }
                else if (this.mandatoryEarlyTerminationIDRef != null)
                {
                    mandatoryEarlyTermination = IDManager.getID(mandatoryEarlyTerminationIDRef) as MandatoryEarlyTermination;
                    return this.mandatoryEarlyTermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mandatoryEarlyTermination != value)
                {
                    this.mandatoryEarlyTermination = value;
                }
            }
        }
        #endregion
        
        public string MandatoryEarlyTerminationIDRef { get; set; }
        #region MandatoryEarlyTerminationDateTenor
        private Period mandatoryEarlyTerminationDateTenor;
        public Period MandatoryEarlyTerminationDateTenor
        {
            get
            {
                if (this.mandatoryEarlyTerminationDateTenor != null)
                {
                    return this.mandatoryEarlyTerminationDateTenor; 
                }
                else if (this.mandatoryEarlyTerminationDateTenorIDRef != null)
                {
                    mandatoryEarlyTerminationDateTenor = IDManager.getID(mandatoryEarlyTerminationDateTenorIDRef) as Period;
                    return this.mandatoryEarlyTerminationDateTenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationDateTenor != value)
                {
                    this.mandatoryEarlyTerminationDateTenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region OptionalEarlyTermination
        private OptionalEarlyTermination optionalEarlyTermination;
        public OptionalEarlyTermination OptionalEarlyTermination
        {
            get
            {
                if (this.optionalEarlyTermination != null)
                {
                    return this.optionalEarlyTermination; 
                }
                else if (this.optionalEarlyTerminationIDRef != null)
                {
                    optionalEarlyTermination = IDManager.getID(optionalEarlyTerminationIDRef) as OptionalEarlyTermination;
                    return this.optionalEarlyTermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionalEarlyTermination != value)
                {
                    this.optionalEarlyTermination = value;
                }
            }
        }
        #endregion
        
        public string OptionalEarlyTerminationIDRef { get; set; }
        #region OptionalEarlyTerminationParameters
        private ExercisePeriod optionalEarlyTerminationParameters;
        public ExercisePeriod OptionalEarlyTerminationParameters
        {
            get
            {
                if (this.optionalEarlyTerminationParameters != null)
                {
                    return this.optionalEarlyTerminationParameters; 
                }
                else if (this.optionalEarlyTerminationParametersIDRef != null)
                {
                    optionalEarlyTerminationParameters = IDManager.getID(optionalEarlyTerminationParametersIDRef) as ExercisePeriod;
                    return this.optionalEarlyTerminationParameters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionalEarlyTerminationParameters != value)
                {
                    this.optionalEarlyTerminationParameters = value;
                }
            }
        }
        #endregion
        
        public string ExercisePeriodIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

