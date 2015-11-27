using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class YieldCurveValuation
    {
        public YieldCurveValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList inputsNodeList = xmlNode.SelectNodes("inputs");
            if (inputsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inputsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inputsIDRef = item.Attributes["id"].Name;
                        QuotedAssetSet ob = QuotedAssetSet();
                        IDManager.SetID(inputsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inputsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inputs = new QuotedAssetSet(item);
                    }
                }
            }
            
        
            XmlNodeList zeroCurveNodeList = xmlNode.SelectNodes("zeroCurve");
            if (zeroCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in zeroCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        zeroCurveIDRef = item.Attributes["id"].Name;
                        ZeroRateCurve ob = ZeroRateCurve();
                        IDManager.SetID(zeroCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        zeroCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        zeroCurve = new ZeroRateCurve(item);
                    }
                }
            }
            
        
            XmlNodeList forwardCurveNodeList = xmlNode.SelectNodes("forwardCurve");
            
            foreach (XmlNode item in forwardCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forwardCurveIDRef = item.Attributes["id"].Name;
                        List<ForwardRateCurve> ob = new List<ForwardRateCurve>();
                        ob.Add(new ForwardRateCurve(item));
                        IDManager.SetID(forwardCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forwardCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    forwardCurve.Add(new ForwardRateCurve(item));
                    }
                }
            }
            
        
            XmlNodeList discountFactorCurveNodeList = xmlNode.SelectNodes("discountFactorCurve");
            if (discountFactorCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountFactorCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountFactorCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(discountFactorCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountFactorCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountFactorCurve = new TermCurve(item);
                    }
                }
            }
            
        
        }
        
    
        #region Inputs
        private QuotedAssetSet inputs;
        public QuotedAssetSet Inputs
        {
            get
            {
                if (this.inputs != null)
                {
                    return this.inputs; 
                }
                else if (this.inputsIDRef != null)
                {
                    inputs = IDManager.getID(inputsIDRef) as QuotedAssetSet;
                    return this.inputs; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inputs != value)
                {
                    this.inputs = value;
                }
            }
        }
        #endregion
        
        public string QuotedAssetSetIDRef { get; set; }
        #region ZeroCurve
        private ZeroRateCurve zeroCurve;
        public ZeroRateCurve ZeroCurve
        {
            get
            {
                if (this.zeroCurve != null)
                {
                    return this.zeroCurve; 
                }
                else if (this.zeroCurveIDRef != null)
                {
                    zeroCurve = IDManager.getID(zeroCurveIDRef) as ZeroRateCurve;
                    return this.zeroCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.zeroCurve != value)
                {
                    this.zeroCurve = value;
                }
            }
        }
        #endregion
        
        public string ZeroRateCurveIDRef { get; set; }
        #region ForwardCurve
        private List<ForwardRateCurve> forwardCurve;
        public List<ForwardRateCurve> ForwardCurve
        {
            get
            {
                if (this.forwardCurve != null)
                {
                    return this.forwardCurve; 
                }
                else if (this.forwardCurveIDRef != null)
                {
                    forwardCurve = IDManager.getID(forwardCurveIDRef) as List<ForwardRateCurve>;
                    return this.forwardCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forwardCurve != value)
                {
                    this.forwardCurve = value;
                }
            }
        }
        #endregion
        
        public string ForwardRateCurveIDRef { get; set; }
        #region DiscountFactorCurve
        private TermCurve discountFactorCurve;
        public TermCurve DiscountFactorCurve
        {
            get
            {
                if (this.discountFactorCurve != null)
                {
                    return this.discountFactorCurve; 
                }
                else if (this.discountFactorCurveIDRef != null)
                {
                    discountFactorCurve = IDManager.getID(discountFactorCurveIDRef) as TermCurve;
                    return this.discountFactorCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountFactorCurve != value)
                {
                    this.discountFactorCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        
    
        
    
    }
    
}

