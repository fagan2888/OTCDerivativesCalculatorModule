using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationAmount
    {
        public CalculationAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            
            foreach (XmlNode item in stepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepIDRef = item.Attributes["id"].Name;
                        List<Step> ob = new List<Step>();
                        ob.Add(new Step(item));
                        IDManager.SetID(stepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    step.Add(new Step(item));
                    }
                }
            }
            
        
        }
        
    
        #region Step
        private List<Step> step;
        public List<Step> Step
        {
            get
            {
                if (this.step != null)
                {
                    return this.step; 
                }
                else if (this.stepIDRef != null)
                {
                    step = IDManager.getID(stepIDRef) as List<Step>;
                    return this.step; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.step != value)
                {
                    this.step = value;
                }
            }
        }
        #endregion
        
        public string StepIDRef { get; set; }
        
    
        
    
    }
    
}

