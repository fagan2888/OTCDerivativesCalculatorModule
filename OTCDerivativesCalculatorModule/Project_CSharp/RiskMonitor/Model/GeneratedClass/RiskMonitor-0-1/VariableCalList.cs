using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VariableCalList : ISerialized
    {
        public VariableCalList() { }
        public VariableCalList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode variableCalculationNode = xmlNode.SelectSingleNode("variableCalculation");
            
            if (variableCalculationNode != null)
            {
                if (variableCalculationNode.Attributes["href"] != null || variableCalculationNode.Attributes["id"] != null) 
                {
                    if (variableCalculationNode.Attributes["id"] != null) 
                    {
                        variableCalculationIDRef_ = variableCalculationNode.Attributes["id"].Value;
                        VariableCalculation ob = new VariableCalculation(variableCalculationNode);
                        IDManager.SetID(variableCalculationIDRef_, ob);
                    }
                    else if (variableCalculationNode.Attributes["href"] != null)
                    {
                        variableCalculationIDRef_ = variableCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        variableCalculation_ = new VariableCalculation(variableCalculationNode);
                    }
                }
                else
                {
                    variableCalculation_ = new VariableCalculation(variableCalculationNode);
                }
            }
            
        
        }
        
    
        #region VariableCalculation_
        private VariableCalculation variableCalculation_;
        public VariableCalculation VariableCalculation_
        {
            get
            {
                if (this.variableCalculation_ != null)
                {
                    return this.variableCalculation_; 
                }
                else if (this.variableCalculationIDRef_ != null)
                {
                    variableCalculation_ = IDManager.getID(variableCalculationIDRef_) as VariableCalculation;
                    return this.variableCalculation_; 
                }
                else
                {
                    throw new Exception( "variableCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.variableCalculation_ != value)
                {
                    this.variableCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string variableCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

