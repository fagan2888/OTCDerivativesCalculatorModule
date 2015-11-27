using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NonNegativeStep
    {
        public NonNegativeStep(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList stepValueNodeList = xmlNode.SelectNodes("stepValue");
            if (stepValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepValueIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(stepValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepValue = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region StepValue
        private NonNegativeDecimal stepValue;
        public NonNegativeDecimal StepValue
        {
            get
            {
                if (this.stepValue != null)
                {
                    return this.stepValue; 
                }
                else if (this.stepValueIDRef != null)
                {
                    stepValue = IDManager.getID(stepValueIDRef) as NonNegativeDecimal;
                    return this.stepValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stepValue != value)
                {
                    this.stepValue = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

