using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PositiveSchedule
    {
        public PositiveSchedule(XmlNode xmlNode)
        {
            XmlNodeList initialValueNodeList = xmlNode.SelectNodes("initialValue");
            if (initialValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialValueIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(initialValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialValue = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList stepNodeList = xmlNode.SelectNodes("step");
            
            foreach (XmlNode item in stepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepIDRef = item.Attributes["id"].Name;
                        List<PositiveStep> ob = new List<PositiveStep>();
                        ob.Add(new PositiveStep(item));
                        IDManager.SetID(stepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    step.Add(new PositiveStep(item));
                    }
                }
            }
            
        
        }
        
    
        #region InitialValue
        private PositiveDecimal initialValue;
        public PositiveDecimal InitialValue
        {
            get
            {
                if (this.initialValue != null)
                {
                    return this.initialValue; 
                }
                else if (this.initialValueIDRef != null)
                {
                    initialValue = IDManager.getID(initialValueIDRef) as PositiveDecimal;
                    return this.initialValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialValue != value)
                {
                    this.initialValue = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region Step
        private List<PositiveStep> step;
        public List<PositiveStep> Step
        {
            get
            {
                if (this.step != null)
                {
                    return this.step; 
                }
                else if (this.stepIDRef != null)
                {
                    step = IDManager.getID(stepIDRef) as List<PositiveStep>;
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
        
        public string PositiveStepIDRef { get; set; }
        
    
        
    
    }
    
}

