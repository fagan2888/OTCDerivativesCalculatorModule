using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CorrelationAmount
    {
        public CorrelationAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList correlationNodeList = xmlNode.SelectNodes("correlation");
            if (correlationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationIDRef = item.Attributes["id"].Name;
                        Correlation ob = Correlation();
                        IDManager.SetID(correlationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlation = new Correlation(item);
                    }
                }
            }
            
        
        }
        
    
        #region Correlation
        private Correlation correlation;
        public Correlation Correlation
        {
            get
            {
                if (this.correlation != null)
                {
                    return this.correlation; 
                }
                else if (this.correlationIDRef != null)
                {
                    correlation = IDManager.getID(correlationIDRef) as Correlation;
                    return this.correlation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlation != value)
                {
                    this.correlation = value;
                }
            }
        }
        #endregion
        
        public string CorrelationIDRef { get; set; }
        
    
        
    
    }
    
}

