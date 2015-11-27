using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Schedule
    {
        public Schedule(XmlNode xmlNode)
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
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialValue = new XsdTypeDecimal(item);
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
        
    
        #region InitialValue
        private XsdTypeDecimal initialValue;
        public XsdTypeDecimal InitialValue
        {
            get
            {
                if (this.initialValue != null)
                {
                    return this.initialValue; 
                }
                else if (this.initialValueIDRef != null)
                {
                    initialValue = IDManager.getID(initialValueIDRef) as XsdTypeDecimal;
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
        
        public string XsdTypeDecimalIDRef { get; set; }
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

