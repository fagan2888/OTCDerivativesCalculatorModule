using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Rounding
    {
        public Rounding(XmlNode xmlNode)
        {
            XmlNodeList roundingDirectionNodeList = xmlNode.SelectNodes("roundingDirection");
            if (roundingDirectionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in roundingDirectionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        roundingDirectionIDRef = item.Attributes["id"].Name;
                        RoundingDirectionEnum ob = RoundingDirectionEnum();
                        IDManager.SetID(roundingDirectionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roundingDirectionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        roundingDirection = new RoundingDirectionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList precisionNodeList = xmlNode.SelectNodes("precision");
            if (precisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in precisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        precisionIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(precisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        precisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        precision = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region RoundingDirection
        private RoundingDirectionEnum roundingDirection;
        public RoundingDirectionEnum RoundingDirection
        {
            get
            {
                if (this.roundingDirection != null)
                {
                    return this.roundingDirection; 
                }
                else if (this.roundingDirectionIDRef != null)
                {
                    roundingDirection = IDManager.getID(roundingDirectionIDRef) as RoundingDirectionEnum;
                    return this.roundingDirection; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.roundingDirection != value)
                {
                    this.roundingDirection = value;
                }
            }
        }
        #endregion
        
        public string RoundingDirectionEnumIDRef { get; set; }
        #region Precision
        private XsdTypeNonNegativeInteger precision;
        public XsdTypeNonNegativeInteger Precision
        {
            get
            {
                if (this.precision != null)
                {
                    return this.precision; 
                }
                else if (this.precisionIDRef != null)
                {
                    precision = IDManager.getID(precisionIDRef) as XsdTypeNonNegativeInteger;
                    return this.precision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.precision != value)
                {
                    this.precision = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

