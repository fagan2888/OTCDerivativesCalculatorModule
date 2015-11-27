using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestShortFall
    {
        public InterestShortFall(XmlNode xmlNode)
        {
            XmlNodeList interestShortfallCapNodeList = xmlNode.SelectNodes("interestShortfallCap");
            if (interestShortfallCapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestShortfallCapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestShortfallCapIDRef = item.Attributes["id"].Name;
                        InterestShortfallCapEnum ob = InterestShortfallCapEnum();
                        IDManager.SetID(interestShortfallCapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestShortfallCapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestShortfallCap = new InterestShortfallCapEnum(item);
                    }
                }
            }
            
        
            XmlNodeList compoundingNodeList = xmlNode.SelectNodes("compounding");
            if (compoundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(compoundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compounding = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList rateSourceNodeList = xmlNode.SelectNodes("rateSource");
            if (rateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateSourceIDRef = item.Attributes["id"].Name;
                        FloatingRateIndex ob = FloatingRateIndex();
                        IDManager.SetID(rateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateSource = new FloatingRateIndex(item);
                    }
                }
            }
            
        
        }
        
    
        #region InterestShortfallCap
        private InterestShortfallCapEnum interestShortfallCap;
        public InterestShortfallCapEnum InterestShortfallCap
        {
            get
            {
                if (this.interestShortfallCap != null)
                {
                    return this.interestShortfallCap; 
                }
                else if (this.interestShortfallCapIDRef != null)
                {
                    interestShortfallCap = IDManager.getID(interestShortfallCapIDRef) as InterestShortfallCapEnum;
                    return this.interestShortfallCap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestShortfallCap != value)
                {
                    this.interestShortfallCap = value;
                }
            }
        }
        #endregion
        
        public string InterestShortfallCapEnumIDRef { get; set; }
        #region Compounding
        private XsdTypeBoolean compounding;
        public XsdTypeBoolean Compounding
        {
            get
            {
                if (this.compounding != null)
                {
                    return this.compounding; 
                }
                else if (this.compoundingIDRef != null)
                {
                    compounding = IDManager.getID(compoundingIDRef) as XsdTypeBoolean;
                    return this.compounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compounding != value)
                {
                    this.compounding = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region RateSource
        private FloatingRateIndex rateSource;
        public FloatingRateIndex RateSource
        {
            get
            {
                if (this.rateSource != null)
                {
                    return this.rateSource; 
                }
                else if (this.rateSourceIDRef != null)
                {
                    rateSource = IDManager.getID(rateSourceIDRef) as FloatingRateIndex;
                    return this.rateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateSource != value)
                {
                    this.rateSource = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIndexIDRef { get; set; }
        
    
        
    
    }
    
}

