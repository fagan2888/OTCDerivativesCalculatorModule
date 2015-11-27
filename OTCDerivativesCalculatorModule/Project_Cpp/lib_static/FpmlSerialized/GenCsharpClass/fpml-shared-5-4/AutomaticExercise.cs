using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AutomaticExercise
    {
        public AutomaticExercise(XmlNode xmlNode)
        {
            XmlNodeList thresholdRateNodeList = xmlNode.SelectNodes("thresholdRate");
            if (thresholdRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in thresholdRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        thresholdRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(thresholdRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        thresholdRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        thresholdRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region ThresholdRate
        private XsdTypeDecimal thresholdRate;
        public XsdTypeDecimal ThresholdRate
        {
            get
            {
                if (this.thresholdRate != null)
                {
                    return this.thresholdRate; 
                }
                else if (this.thresholdRateIDRef != null)
                {
                    thresholdRate = IDManager.getID(thresholdRateIDRef) as XsdTypeDecimal;
                    return this.thresholdRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.thresholdRate != value)
                {
                    this.thresholdRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

