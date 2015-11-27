using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditCurveValuation
    {
        public CreditCurveValuation(XmlNode xmlNode)
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
            
        
            XmlNodeList defaultProbabilityCurveNodeList = xmlNode.SelectNodes("defaultProbabilityCurve");
            if (defaultProbabilityCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in defaultProbabilityCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        defaultProbabilityCurveIDRef = item.Attributes["id"].Name;
                        DefaultProbabilityCurve ob = DefaultProbabilityCurve();
                        IDManager.SetID(defaultProbabilityCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        defaultProbabilityCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        defaultProbabilityCurve = new DefaultProbabilityCurve(item);
                    }
                }
            }
            
        
            XmlNodeList recoveryRateNodeList = xmlNode.SelectNodes("recoveryRate");
            if (recoveryRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in recoveryRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        recoveryRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(recoveryRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        recoveryRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        recoveryRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList recoveryRateCurveNodeList = xmlNode.SelectNodes("recoveryRateCurve");
            if (recoveryRateCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in recoveryRateCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        recoveryRateCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(recoveryRateCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        recoveryRateCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        recoveryRateCurve = new TermCurve(item);
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
        #region DefaultProbabilityCurve
        private DefaultProbabilityCurve defaultProbabilityCurve;
        public DefaultProbabilityCurve DefaultProbabilityCurve
        {
            get
            {
                if (this.defaultProbabilityCurve != null)
                {
                    return this.defaultProbabilityCurve; 
                }
                else if (this.defaultProbabilityCurveIDRef != null)
                {
                    defaultProbabilityCurve = IDManager.getID(defaultProbabilityCurveIDRef) as DefaultProbabilityCurve;
                    return this.defaultProbabilityCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.defaultProbabilityCurve != value)
                {
                    this.defaultProbabilityCurve = value;
                }
            }
        }
        #endregion
        
        public string DefaultProbabilityCurveIDRef { get; set; }
        #region RecoveryRate
        private XsdTypeDecimal recoveryRate;
        public XsdTypeDecimal RecoveryRate
        {
            get
            {
                if (this.recoveryRate != null)
                {
                    return this.recoveryRate; 
                }
                else if (this.recoveryRateIDRef != null)
                {
                    recoveryRate = IDManager.getID(recoveryRateIDRef) as XsdTypeDecimal;
                    return this.recoveryRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.recoveryRate != value)
                {
                    this.recoveryRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RecoveryRateCurve
        private TermCurve recoveryRateCurve;
        public TermCurve RecoveryRateCurve
        {
            get
            {
                if (this.recoveryRateCurve != null)
                {
                    return this.recoveryRateCurve; 
                }
                else if (this.recoveryRateCurveIDRef != null)
                {
                    recoveryRateCurve = IDManager.getID(recoveryRateCurveIDRef) as TermCurve;
                    return this.recoveryRateCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.recoveryRateCurve != value)
                {
                    this.recoveryRateCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

