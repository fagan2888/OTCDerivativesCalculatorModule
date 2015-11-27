using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StepBase
    {
        public StepBase(XmlNode xmlNode)
        {
            XmlNodeList stepDateNodeList = xmlNode.SelectNodes("stepDate");
            if (stepDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(stepDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region StepDate
        private XsdTypeDate stepDate;
        public XsdTypeDate StepDate
        {
            get
            {
                if (this.stepDate != null)
                {
                    return this.stepDate; 
                }
                else if (this.stepDateIDRef != null)
                {
                    stepDate = IDManager.getID(stepDateIDRef) as XsdTypeDate;
                    return this.stepDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stepDate != value)
                {
                    this.stepDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

