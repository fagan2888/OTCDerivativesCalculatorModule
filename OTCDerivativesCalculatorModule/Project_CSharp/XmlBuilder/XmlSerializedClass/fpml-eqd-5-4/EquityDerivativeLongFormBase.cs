using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityDerivativeLongFormBase : EquityDerivativeBase
    {
        public EquityDerivativeLongFormBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dividendConditionsNode = xmlNode.SelectSingleNode("dividendConditions");
            
            if (dividendConditionsNode != null)
            {
                if (dividendConditionsNode.Attributes["href"] != null || dividendConditionsNode.Attributes["id"] != null) 
                {
                    if (dividendConditionsNode.Attributes["id"] != null) 
                    {
                        dividendConditionsIDRef_ = dividendConditionsNode.Attributes["id"].Value;
                        DividendConditions ob = new DividendConditions(dividendConditionsNode);
                        IDManager.SetID(dividendConditionsIDRef_, ob);
                    }
                    else if (dividendConditionsNode.Attributes["href"] != null)
                    {
                        dividendConditionsIDRef_ = dividendConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendConditions_ = new DividendConditions(dividendConditionsNode);
                    }
                }
                else
                {
                    dividendConditions_ = new DividendConditions(dividendConditionsNode);
                }
            }
            
        
            XmlNode methodOfAdjustmentNode = xmlNode.SelectSingleNode("methodOfAdjustment");
            
            if (methodOfAdjustmentNode != null)
            {
                if (methodOfAdjustmentNode.Attributes["href"] != null || methodOfAdjustmentNode.Attributes["id"] != null) 
                {
                    if (methodOfAdjustmentNode.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["id"].Value;
                        MethodOfAdjustmentEnum ob = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                        IDManager.SetID(methodOfAdjustmentIDRef_, ob);
                    }
                    else if (methodOfAdjustmentNode.Attributes["href"] != null)
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                    }
                }
                else
                {
                    methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                }
            }
            
        
            XmlNode extraordinaryEventsNode = xmlNode.SelectSingleNode("extraordinaryEvents");
            
            if (extraordinaryEventsNode != null)
            {
                if (extraordinaryEventsNode.Attributes["href"] != null || extraordinaryEventsNode.Attributes["id"] != null) 
                {
                    if (extraordinaryEventsNode.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["id"].Value;
                        ExtraordinaryEvents ob = new ExtraordinaryEvents(extraordinaryEventsNode);
                        IDManager.SetID(extraordinaryEventsIDRef_, ob);
                    }
                    else if (extraordinaryEventsNode.Attributes["href"] != null)
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                    }
                }
                else
                {
                    extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                }
            }
            
        
        }
        
    
        #region DividendConditions_
        private DividendConditions dividendConditions_;
        public DividendConditions DividendConditions_
        {
            get
            {
                if (this.dividendConditions_ != null)
                {
                    return this.dividendConditions_; 
                }
                else if (this.dividendConditionsIDRef_ != null)
                {
                    dividendConditions_ = IDManager.getID(dividendConditionsIDRef_) as DividendConditions;
                    return this.dividendConditions_; 
                }
                else
                {
                      return this.dividendConditions_; 
                }
            }
            set
            {
                if (this.dividendConditions_ != value)
                {
                    this.dividendConditions_ = value;
                }
            }
        }
        #endregion
        
        public string dividendConditionsIDRef_ { get; set; }
        #region MethodOfAdjustment_
        private MethodOfAdjustmentEnum methodOfAdjustment_;
        public MethodOfAdjustmentEnum MethodOfAdjustment_
        {
            get
            {
                if (this.methodOfAdjustment_ != null)
                {
                    return this.methodOfAdjustment_; 
                }
                else if (this.methodOfAdjustmentIDRef_ != null)
                {
                    methodOfAdjustment_ = IDManager.getID(methodOfAdjustmentIDRef_) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment_; 
                }
                else
                {
                      return this.methodOfAdjustment_; 
                }
            }
            set
            {
                if (this.methodOfAdjustment_ != value)
                {
                    this.methodOfAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string methodOfAdjustmentIDRef_ { get; set; }
        #region ExtraordinaryEvents_
        private ExtraordinaryEvents extraordinaryEvents_;
        public ExtraordinaryEvents ExtraordinaryEvents_
        {
            get
            {
                if (this.extraordinaryEvents_ != null)
                {
                    return this.extraordinaryEvents_; 
                }
                else if (this.extraordinaryEventsIDRef_ != null)
                {
                    extraordinaryEvents_ = IDManager.getID(extraordinaryEventsIDRef_) as ExtraordinaryEvents;
                    return this.extraordinaryEvents_; 
                }
                else
                {
                      return this.extraordinaryEvents_; 
                }
            }
            set
            {
                if (this.extraordinaryEvents_ != value)
                {
                    this.extraordinaryEvents_ = value;
                }
            }
        }
        #endregion
        
        public string extraordinaryEventsIDRef_ { get; set; }
        
    
        
    
    }
    
}

