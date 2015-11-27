using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EarlyTerminationProvision : ISerialized
    {
        public EarlyTerminationProvision(XmlNode xmlNode)
        {
            XmlNode mandatoryEarlyTerminationNode = xmlNode.SelectSingleNode("mandatoryEarlyTermination");
            
            if (mandatoryEarlyTerminationNode != null)
            {
                if (mandatoryEarlyTerminationNode.Attributes["href"] != null || mandatoryEarlyTerminationNode.Attributes["id"] != null) 
                {
                    if (mandatoryEarlyTerminationNode.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationIDRef_ = mandatoryEarlyTerminationNode.Attributes["id"].Value;
                        MandatoryEarlyTermination ob = new MandatoryEarlyTermination(mandatoryEarlyTerminationNode);
                        IDManager.SetID(mandatoryEarlyTerminationIDRef_, ob);
                    }
                    else if (mandatoryEarlyTerminationNode.Attributes["href"] != null)
                    {
                        mandatoryEarlyTerminationIDRef_ = mandatoryEarlyTerminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mandatoryEarlyTermination_ = new MandatoryEarlyTermination(mandatoryEarlyTerminationNode);
                    }
                }
                else
                {
                    mandatoryEarlyTermination_ = new MandatoryEarlyTermination(mandatoryEarlyTerminationNode);
                }
            }
            
        
            XmlNode mandatoryEarlyTerminationDateTenorNode = xmlNode.SelectSingleNode("mandatoryEarlyTerminationDateTenor");
            
            if (mandatoryEarlyTerminationDateTenorNode != null)
            {
                if (mandatoryEarlyTerminationDateTenorNode.Attributes["href"] != null || mandatoryEarlyTerminationDateTenorNode.Attributes["id"] != null) 
                {
                    if (mandatoryEarlyTerminationDateTenorNode.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationDateTenorIDRef_ = mandatoryEarlyTerminationDateTenorNode.Attributes["id"].Value;
                        Period ob = new Period(mandatoryEarlyTerminationDateTenorNode);
                        IDManager.SetID(mandatoryEarlyTerminationDateTenorIDRef_, ob);
                    }
                    else if (mandatoryEarlyTerminationDateTenorNode.Attributes["href"] != null)
                    {
                        mandatoryEarlyTerminationDateTenorIDRef_ = mandatoryEarlyTerminationDateTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mandatoryEarlyTerminationDateTenor_ = new Period(mandatoryEarlyTerminationDateTenorNode);
                    }
                }
                else
                {
                    mandatoryEarlyTerminationDateTenor_ = new Period(mandatoryEarlyTerminationDateTenorNode);
                }
            }
            
        
            XmlNode optionalEarlyTerminationNode = xmlNode.SelectSingleNode("optionalEarlyTermination");
            
            if (optionalEarlyTerminationNode != null)
            {
                if (optionalEarlyTerminationNode.Attributes["href"] != null || optionalEarlyTerminationNode.Attributes["id"] != null) 
                {
                    if (optionalEarlyTerminationNode.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode.Attributes["id"].Value;
                        OptionalEarlyTermination ob = new OptionalEarlyTermination(optionalEarlyTerminationNode);
                        IDManager.SetID(optionalEarlyTerminationIDRef_, ob);
                    }
                    else if (optionalEarlyTerminationNode.Attributes["href"] != null)
                    {
                        optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionalEarlyTermination_ = new OptionalEarlyTermination(optionalEarlyTerminationNode);
                    }
                }
                else
                {
                    optionalEarlyTermination_ = new OptionalEarlyTermination(optionalEarlyTerminationNode);
                }
            }
            
        
            XmlNode optionalEarlyTerminationParametersNode = xmlNode.SelectSingleNode("optionalEarlyTerminationParameters");
            
            if (optionalEarlyTerminationParametersNode != null)
            {
                if (optionalEarlyTerminationParametersNode.Attributes["href"] != null || optionalEarlyTerminationParametersNode.Attributes["id"] != null) 
                {
                    if (optionalEarlyTerminationParametersNode.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationParametersIDRef_ = optionalEarlyTerminationParametersNode.Attributes["id"].Value;
                        ExercisePeriod ob = new ExercisePeriod(optionalEarlyTerminationParametersNode);
                        IDManager.SetID(optionalEarlyTerminationParametersIDRef_, ob);
                    }
                    else if (optionalEarlyTerminationParametersNode.Attributes["href"] != null)
                    {
                        optionalEarlyTerminationParametersIDRef_ = optionalEarlyTerminationParametersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionalEarlyTerminationParameters_ = new ExercisePeriod(optionalEarlyTerminationParametersNode);
                    }
                }
                else
                {
                    optionalEarlyTerminationParameters_ = new ExercisePeriod(optionalEarlyTerminationParametersNode);
                }
            }
            
        
        }
        
    
        #region MandatoryEarlyTermination_
        private MandatoryEarlyTermination mandatoryEarlyTermination_;
        public MandatoryEarlyTermination MandatoryEarlyTermination_
        {
            get
            {
                if (this.mandatoryEarlyTermination_ != null)
                {
                    return this.mandatoryEarlyTermination_; 
                }
                else if (this.mandatoryEarlyTerminationIDRef_ != null)
                {
                    mandatoryEarlyTermination_ = IDManager.getID(mandatoryEarlyTerminationIDRef_) as MandatoryEarlyTermination;
                    return this.mandatoryEarlyTermination_; 
                }
                else
                {
                      return this.mandatoryEarlyTermination_; 
                }
            }
            set
            {
                if (this.mandatoryEarlyTermination_ != value)
                {
                    this.mandatoryEarlyTermination_ = value;
                }
            }
        }
        #endregion
        
        public string mandatoryEarlyTerminationIDRef_ { get; set; }
        #region MandatoryEarlyTerminationDateTenor_
        private Period mandatoryEarlyTerminationDateTenor_;
        public Period MandatoryEarlyTerminationDateTenor_
        {
            get
            {
                if (this.mandatoryEarlyTerminationDateTenor_ != null)
                {
                    return this.mandatoryEarlyTerminationDateTenor_; 
                }
                else if (this.mandatoryEarlyTerminationDateTenorIDRef_ != null)
                {
                    mandatoryEarlyTerminationDateTenor_ = IDManager.getID(mandatoryEarlyTerminationDateTenorIDRef_) as Period;
                    return this.mandatoryEarlyTerminationDateTenor_; 
                }
                else
                {
                      return this.mandatoryEarlyTerminationDateTenor_; 
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationDateTenor_ != value)
                {
                    this.mandatoryEarlyTerminationDateTenor_ = value;
                }
            }
        }
        #endregion
        
        public string mandatoryEarlyTerminationDateTenorIDRef_ { get; set; }
        #region OptionalEarlyTermination_
        private OptionalEarlyTermination optionalEarlyTermination_;
        public OptionalEarlyTermination OptionalEarlyTermination_
        {
            get
            {
                if (this.optionalEarlyTermination_ != null)
                {
                    return this.optionalEarlyTermination_; 
                }
                else if (this.optionalEarlyTerminationIDRef_ != null)
                {
                    optionalEarlyTermination_ = IDManager.getID(optionalEarlyTerminationIDRef_) as OptionalEarlyTermination;
                    return this.optionalEarlyTermination_; 
                }
                else
                {
                      return this.optionalEarlyTermination_; 
                }
            }
            set
            {
                if (this.optionalEarlyTermination_ != value)
                {
                    this.optionalEarlyTermination_ = value;
                }
            }
        }
        #endregion
        
        public string optionalEarlyTerminationIDRef_ { get; set; }
        #region OptionalEarlyTerminationParameters_
        private ExercisePeriod optionalEarlyTerminationParameters_;
        public ExercisePeriod OptionalEarlyTerminationParameters_
        {
            get
            {
                if (this.optionalEarlyTerminationParameters_ != null)
                {
                    return this.optionalEarlyTerminationParameters_; 
                }
                else if (this.optionalEarlyTerminationParametersIDRef_ != null)
                {
                    optionalEarlyTerminationParameters_ = IDManager.getID(optionalEarlyTerminationParametersIDRef_) as ExercisePeriod;
                    return this.optionalEarlyTerminationParameters_; 
                }
                else
                {
                      return this.optionalEarlyTerminationParameters_; 
                }
            }
            set
            {
                if (this.optionalEarlyTerminationParameters_ != value)
                {
                    this.optionalEarlyTerminationParameters_ = value;
                }
            }
        }
        #endregion
        
        public string optionalEarlyTerminationParametersIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

