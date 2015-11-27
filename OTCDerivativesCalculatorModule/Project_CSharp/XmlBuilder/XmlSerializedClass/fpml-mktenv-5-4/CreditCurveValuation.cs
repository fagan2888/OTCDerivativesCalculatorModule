using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditCurveValuation : PricingStructureValuation
    {
        public CreditCurveValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode inputsNode = xmlNode.SelectSingleNode("inputs");
            
            if (inputsNode != null)
            {
                if (inputsNode.Attributes["href"] != null || inputsNode.Attributes["id"] != null) 
                {
                    if (inputsNode.Attributes["id"] != null) 
                    {
                        inputsIDRef_ = inputsNode.Attributes["id"].Value;
                        QuotedAssetSet ob = new QuotedAssetSet(inputsNode);
                        IDManager.SetID(inputsIDRef_, ob);
                    }
                    else if (inputsNode.Attributes["href"] != null)
                    {
                        inputsIDRef_ = inputsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inputs_ = new QuotedAssetSet(inputsNode);
                    }
                }
                else
                {
                    inputs_ = new QuotedAssetSet(inputsNode);
                }
            }
            
        
            XmlNode defaultProbabilityCurveNode = xmlNode.SelectSingleNode("defaultProbabilityCurve");
            
            if (defaultProbabilityCurveNode != null)
            {
                if (defaultProbabilityCurveNode.Attributes["href"] != null || defaultProbabilityCurveNode.Attributes["id"] != null) 
                {
                    if (defaultProbabilityCurveNode.Attributes["id"] != null) 
                    {
                        defaultProbabilityCurveIDRef_ = defaultProbabilityCurveNode.Attributes["id"].Value;
                        DefaultProbabilityCurve ob = new DefaultProbabilityCurve(defaultProbabilityCurveNode);
                        IDManager.SetID(defaultProbabilityCurveIDRef_, ob);
                    }
                    else if (defaultProbabilityCurveNode.Attributes["href"] != null)
                    {
                        defaultProbabilityCurveIDRef_ = defaultProbabilityCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        defaultProbabilityCurve_ = new DefaultProbabilityCurve(defaultProbabilityCurveNode);
                    }
                }
                else
                {
                    defaultProbabilityCurve_ = new DefaultProbabilityCurve(defaultProbabilityCurveNode);
                }
            }
            
        
            XmlNode recoveryRateNode = xmlNode.SelectSingleNode("recoveryRate");
            
            if (recoveryRateNode != null)
            {
                if (recoveryRateNode.Attributes["href"] != null || recoveryRateNode.Attributes["id"] != null) 
                {
                    if (recoveryRateNode.Attributes["id"] != null) 
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(recoveryRateNode);
                        IDManager.SetID(recoveryRateIDRef_, ob);
                    }
                    else if (recoveryRateNode.Attributes["href"] != null)
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryRate_ = new XsdTypeDecimal(recoveryRateNode);
                    }
                }
                else
                {
                    recoveryRate_ = new XsdTypeDecimal(recoveryRateNode);
                }
            }
            
        
            XmlNode recoveryRateCurveNode = xmlNode.SelectSingleNode("recoveryRateCurve");
            
            if (recoveryRateCurveNode != null)
            {
                if (recoveryRateCurveNode.Attributes["href"] != null || recoveryRateCurveNode.Attributes["id"] != null) 
                {
                    if (recoveryRateCurveNode.Attributes["id"] != null) 
                    {
                        recoveryRateCurveIDRef_ = recoveryRateCurveNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(recoveryRateCurveNode);
                        IDManager.SetID(recoveryRateCurveIDRef_, ob);
                    }
                    else if (recoveryRateCurveNode.Attributes["href"] != null)
                    {
                        recoveryRateCurveIDRef_ = recoveryRateCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryRateCurve_ = new TermCurve(recoveryRateCurveNode);
                    }
                }
                else
                {
                    recoveryRateCurve_ = new TermCurve(recoveryRateCurveNode);
                }
            }
            
        
        }
        
    
        #region Inputs_
        private QuotedAssetSet inputs_;
        public QuotedAssetSet Inputs_
        {
            get
            {
                if (this.inputs_ != null)
                {
                    return this.inputs_; 
                }
                else if (this.inputsIDRef_ != null)
                {
                    inputs_ = IDManager.getID(inputsIDRef_) as QuotedAssetSet;
                    return this.inputs_; 
                }
                else
                {
                      return this.inputs_; 
                }
            }
            set
            {
                if (this.inputs_ != value)
                {
                    this.inputs_ = value;
                }
            }
        }
        #endregion
        
        public string inputsIDRef_ { get; set; }
        #region DefaultProbabilityCurve_
        private DefaultProbabilityCurve defaultProbabilityCurve_;
        public DefaultProbabilityCurve DefaultProbabilityCurve_
        {
            get
            {
                if (this.defaultProbabilityCurve_ != null)
                {
                    return this.defaultProbabilityCurve_; 
                }
                else if (this.defaultProbabilityCurveIDRef_ != null)
                {
                    defaultProbabilityCurve_ = IDManager.getID(defaultProbabilityCurveIDRef_) as DefaultProbabilityCurve;
                    return this.defaultProbabilityCurve_; 
                }
                else
                {
                      return this.defaultProbabilityCurve_; 
                }
            }
            set
            {
                if (this.defaultProbabilityCurve_ != value)
                {
                    this.defaultProbabilityCurve_ = value;
                }
            }
        }
        #endregion
        
        public string defaultProbabilityCurveIDRef_ { get; set; }
        #region RecoveryRate_
        private XsdTypeDecimal recoveryRate_;
        public XsdTypeDecimal RecoveryRate_
        {
            get
            {
                if (this.recoveryRate_ != null)
                {
                    return this.recoveryRate_; 
                }
                else if (this.recoveryRateIDRef_ != null)
                {
                    recoveryRate_ = IDManager.getID(recoveryRateIDRef_) as XsdTypeDecimal;
                    return this.recoveryRate_; 
                }
                else
                {
                      return this.recoveryRate_; 
                }
            }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryRateIDRef_ { get; set; }
        #region RecoveryRateCurve_
        private TermCurve recoveryRateCurve_;
        public TermCurve RecoveryRateCurve_
        {
            get
            {
                if (this.recoveryRateCurve_ != null)
                {
                    return this.recoveryRateCurve_; 
                }
                else if (this.recoveryRateCurveIDRef_ != null)
                {
                    recoveryRateCurve_ = IDManager.getID(recoveryRateCurveIDRef_) as TermCurve;
                    return this.recoveryRateCurve_; 
                }
                else
                {
                      return this.recoveryRateCurve_; 
                }
            }
            set
            {
                if (this.recoveryRateCurve_ != value)
                {
                    this.recoveryRateCurve_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryRateCurveIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

