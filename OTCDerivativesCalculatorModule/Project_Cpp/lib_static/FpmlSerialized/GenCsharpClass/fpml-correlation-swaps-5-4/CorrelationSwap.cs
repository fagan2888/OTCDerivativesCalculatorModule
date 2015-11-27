using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CorrelationSwap
    {
        public CorrelationSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList correlationLegNodeList = xmlNode.SelectNodes("correlationLeg");
            if (correlationLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationLegIDRef = item.Attributes["id"].Name;
                        CorrelationLeg ob = CorrelationLeg();
                        IDManager.SetID(correlationLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlationLeg = new CorrelationLeg(item);
                    }
                }
            }
            
        
        }
        
    
        #region CorrelationLeg
        private CorrelationLeg correlationLeg;
        public CorrelationLeg CorrelationLeg
        {
            get
            {
                if (this.correlationLeg != null)
                {
                    return this.correlationLeg; 
                }
                else if (this.correlationLegIDRef != null)
                {
                    correlationLeg = IDManager.getID(correlationLegIDRef) as CorrelationLeg;
                    return this.correlationLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlationLeg != value)
                {
                    this.correlationLeg = value;
                }
            }
        }
        #endregion
        
        public string CorrelationLegIDRef { get; set; }
        
    
        
    
    }
    
}

