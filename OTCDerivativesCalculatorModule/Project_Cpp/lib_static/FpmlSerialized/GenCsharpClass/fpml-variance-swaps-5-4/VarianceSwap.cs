using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VarianceSwap
    {
        public VarianceSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceLegNodeList = xmlNode.SelectNodes("varianceLeg");
            
            foreach (XmlNode item in varianceLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceLegIDRef = item.Attributes["id"].Name;
                        List<VarianceLeg> ob = new List<VarianceLeg>();
                        ob.Add(new VarianceLeg(item));
                        IDManager.SetID(varianceLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    varianceLeg.Add(new VarianceLeg(item));
                    }
                }
            }
            
        
        }
        
    
        #region VarianceLeg
        private List<VarianceLeg> varianceLeg;
        public List<VarianceLeg> VarianceLeg
        {
            get
            {
                if (this.varianceLeg != null)
                {
                    return this.varianceLeg; 
                }
                else if (this.varianceLegIDRef != null)
                {
                    varianceLeg = IDManager.getID(varianceLegIDRef) as List<VarianceLeg>;
                    return this.varianceLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceLeg != value)
                {
                    this.varianceLeg = value;
                }
            }
        }
        #endregion
        
        public string VarianceLegIDRef { get; set; }
        
    
        
    
    }
    
}

