using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Step
    {
        public Step(XmlNode xmlNode)
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
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(stepValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region StepValue
        private XsdTypeDecimal stepValue;
        public XsdTypeDecimal StepValue
        {
            get
            {
                if (this.stepValue != null)
                {
                    return this.stepValue; 
                }
                else if (this.stepValueIDRef != null)
                {
                    stepValue = IDManager.getID(stepValueIDRef) as XsdTypeDecimal;
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
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

