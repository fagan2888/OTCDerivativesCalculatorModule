using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityMultipleExercise
    {
        public EquityMultipleExercise(XmlNode xmlNode)
        {
            XmlNodeList integralMultipleExerciseNodeList = xmlNode.SelectNodes("integralMultipleExercise");
            if (integralMultipleExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in integralMultipleExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        integralMultipleExerciseIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(integralMultipleExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        integralMultipleExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        integralMultipleExercise = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList minimumNumberOfOptionsNodeList = xmlNode.SelectNodes("minimumNumberOfOptions");
            if (minimumNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(minimumNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumNumberOfOptions = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList maximumNumberOfOptionsNodeList = xmlNode.SelectNodes("maximumNumberOfOptions");
            if (maximumNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(maximumNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumNumberOfOptions = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region IntegralMultipleExercise
        private PositiveDecimal integralMultipleExercise;
        public PositiveDecimal IntegralMultipleExercise
        {
            get
            {
                if (this.integralMultipleExercise != null)
                {
                    return this.integralMultipleExercise; 
                }
                else if (this.integralMultipleExerciseIDRef != null)
                {
                    integralMultipleExercise = IDManager.getID(integralMultipleExerciseIDRef) as PositiveDecimal;
                    return this.integralMultipleExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.integralMultipleExercise != value)
                {
                    this.integralMultipleExercise = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region MinimumNumberOfOptions
        private NonNegativeDecimal minimumNumberOfOptions;
        public NonNegativeDecimal MinimumNumberOfOptions
        {
            get
            {
                if (this.minimumNumberOfOptions != null)
                {
                    return this.minimumNumberOfOptions; 
                }
                else if (this.minimumNumberOfOptionsIDRef != null)
                {
                    minimumNumberOfOptions = IDManager.getID(minimumNumberOfOptionsIDRef) as NonNegativeDecimal;
                    return this.minimumNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumNumberOfOptions != value)
                {
                    this.minimumNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region MaximumNumberOfOptions
        private NonNegativeDecimal maximumNumberOfOptions;
        public NonNegativeDecimal MaximumNumberOfOptions
        {
            get
            {
                if (this.maximumNumberOfOptions != null)
                {
                    return this.maximumNumberOfOptions; 
                }
                else if (this.maximumNumberOfOptionsIDRef != null)
                {
                    maximumNumberOfOptions = IDManager.getID(maximumNumberOfOptionsIDRef) as NonNegativeDecimal;
                    return this.maximumNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumNumberOfOptions != value)
                {
                    this.maximumNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

