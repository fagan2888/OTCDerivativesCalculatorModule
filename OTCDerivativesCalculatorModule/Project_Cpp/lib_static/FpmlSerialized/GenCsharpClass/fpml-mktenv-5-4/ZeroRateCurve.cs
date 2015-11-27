using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ZeroRateCurve
    {
        public ZeroRateCurve(XmlNode xmlNode)
        {
            XmlNodeList compoundingFrequencyNodeList = xmlNode.SelectNodes("compoundingFrequency");
            if (compoundingFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingFrequencyIDRef = item.Attributes["id"].Name;
                        CompoundingFrequency ob = CompoundingFrequency();
                        IDManager.SetID(compoundingFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingFrequency = new CompoundingFrequency(item);
                    }
                }
            }
            
        
            XmlNodeList rateCurveNodeList = xmlNode.SelectNodes("rateCurve");
            if (rateCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(rateCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateCurve = new TermCurve(item);
                    }
                }
            }
            
        
        }
        
    
        #region CompoundingFrequency
        private CompoundingFrequency compoundingFrequency;
        public CompoundingFrequency CompoundingFrequency
        {
            get
            {
                if (this.compoundingFrequency != null)
                {
                    return this.compoundingFrequency; 
                }
                else if (this.compoundingFrequencyIDRef != null)
                {
                    compoundingFrequency = IDManager.getID(compoundingFrequencyIDRef) as CompoundingFrequency;
                    return this.compoundingFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingFrequency != value)
                {
                    this.compoundingFrequency = value;
                }
            }
        }
        #endregion
        
        public string CompoundingFrequencyIDRef { get; set; }
        #region RateCurve
        private TermCurve rateCurve;
        public TermCurve RateCurve
        {
            get
            {
                if (this.rateCurve != null)
                {
                    return this.rateCurve; 
                }
                else if (this.rateCurveIDRef != null)
                {
                    rateCurve = IDManager.getID(rateCurveIDRef) as TermCurve;
                    return this.rateCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateCurve != value)
                {
                    this.rateCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        
    
        
    
    }
    
}

