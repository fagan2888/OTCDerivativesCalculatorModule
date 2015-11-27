using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeReturn : ISerialized
    {
        public SimpleRangeReturn() { }
        public SimpleRangeReturn(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode simpleRangeEventCalNode = xmlNode.SelectSingleNode("simpleRangeEventCal");
            
            if (simpleRangeEventCalNode != null)
            {
                if (simpleRangeEventCalNode.Attributes["href"] != null || simpleRangeEventCalNode.Attributes["id"] != null) 
                {
                    if (simpleRangeEventCalNode.Attributes["id"] != null) 
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["id"].Value;
                        SimpleRangeEventCal ob = new SimpleRangeEventCal(simpleRangeEventCalNode);
                        IDManager.SetID(simpleRangeEventCalIDRef_, ob);
                    }
                    else if (simpleRangeEventCalNode.Attributes["href"] != null)
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                    }
                }
                else
                {
                    simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                }
            }
            
        
            XmlNode returnCalculationNode = xmlNode.SelectSingleNode("returnCalculation");
            
            if (returnCalculationNode != null)
            {
                if (returnCalculationNode.Attributes["href"] != null || returnCalculationNode.Attributes["id"] != null) 
                {
                    if (returnCalculationNode.Attributes["id"] != null) 
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["id"].Value;
                        ReturnCalculation ob = new ReturnCalculation(returnCalculationNode);
                        IDManager.SetID(returnCalculationIDRef_, ob);
                    }
                    else if (returnCalculationNode.Attributes["href"] != null)
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                    }
                }
                else
                {
                    returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                }
            }
            
        
        }
        
    
        #region SimpleRangeEventCal_
        private SimpleRangeEventCal simpleRangeEventCal_;
        public SimpleRangeEventCal SimpleRangeEventCal_
        {
            get
            {
                if (this.simpleRangeEventCal_ != null)
                {
                    return this.simpleRangeEventCal_; 
                }
                else if (this.simpleRangeEventCalIDRef_ != null)
                {
                    simpleRangeEventCal_ = IDManager.getID(simpleRangeEventCalIDRef_) as SimpleRangeEventCal;
                    return this.simpleRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "simpleRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeEventCal_ != value)
                {
                    this.simpleRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeEventCalIDRef_ { get; set; }
        #region ReturnCalculation_
        private ReturnCalculation returnCalculation_;
        public ReturnCalculation ReturnCalculation_
        {
            get
            {
                if (this.returnCalculation_ != null)
                {
                    return this.returnCalculation_; 
                }
                else if (this.returnCalculationIDRef_ != null)
                {
                    returnCalculation_ = IDManager.getID(returnCalculationIDRef_) as ReturnCalculation;
                    return this.returnCalculation_; 
                }
                else
                {
                    throw new Exception( "returnCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.returnCalculation_ != value)
                {
                    this.returnCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string returnCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

