using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InitialFixedValue : ISerialized
    {
        public InitialFixedValue(XmlNode xmlNode)
        {
            XmlNodeList variableNodeList = xmlNode.SelectNodes("variable");
            
            if (variableNodeList != null)
            {
                this.variable_ = new List<VariableValue>();
                foreach (XmlNode item in variableNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            variableIDRef_ = item.Attributes["id"].Value;
                            variable_.Add(new VariableValue(item));
                            IDManager.SetID(variableIDRef_, variable_[variable_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            variableIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        variable_.Add(new VariableValue(item));
                        }
                    }
                    else
                    {
                        variable_.Add(new VariableValue(item));
                    }
                }
            }
            
        
        }
        
    
        #region Variable_
        private List<VariableValue> variable_;
        public List<VariableValue> Variable_
        {
            get
            {
                if (this.variable_ != null)
                {
                    return this.variable_; 
                }
                else if (this.variableIDRef_ != null)
                {
                    return this.variable_; 
                }
                else
                {
                      return this.variable_; 
                }
            }
            set
            {
                if (this.variable_ != value)
                {
                    this.variable_ = value;
                }
            }
        }
        #endregion
        
        public string variableIDRef_ { get; set; }
        
    
        
    
    }
    
}

