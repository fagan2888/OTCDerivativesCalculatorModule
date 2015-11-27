using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BondOptionStrike
    {
        public BondOptionStrike(XmlNode xmlNode)
        {
            XmlNodeList referenceSwapCurveNodeList = xmlNode.SelectNodes("referenceSwapCurve");
            if (referenceSwapCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceSwapCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceSwapCurveIDRef = item.Attributes["id"].Name;
                        ReferenceSwapCurve ob = ReferenceSwapCurve();
                        IDManager.SetID(referenceSwapCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceSwapCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceSwapCurve = new ReferenceSwapCurve(item);
                    }
                }
            }
            
        
            XmlNodeList priceNodeList = xmlNode.SelectNodes("price");
            if (priceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceIDRef = item.Attributes["id"].Name;
                        OptionStrike ob = OptionStrike();
                        IDManager.SetID(priceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        price = new OptionStrike(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceSwapCurve
        private ReferenceSwapCurve referenceSwapCurve;
        public ReferenceSwapCurve ReferenceSwapCurve
        {
            get
            {
                if (this.referenceSwapCurve != null)
                {
                    return this.referenceSwapCurve; 
                }
                else if (this.referenceSwapCurveIDRef != null)
                {
                    referenceSwapCurve = IDManager.getID(referenceSwapCurveIDRef) as ReferenceSwapCurve;
                    return this.referenceSwapCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceSwapCurve != value)
                {
                    this.referenceSwapCurve = value;
                }
            }
        }
        #endregion
        
        public string ReferenceSwapCurveIDRef { get; set; }
        #region Price
        private OptionStrike price;
        public OptionStrike Price
        {
            get
            {
                if (this.price != null)
                {
                    return this.price; 
                }
                else if (this.priceIDRef != null)
                {
                    price = IDManager.getID(priceIDRef) as OptionStrike;
                    return this.price; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                }
            }
        }
        #endregion
        
        public string OptionStrikeIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

