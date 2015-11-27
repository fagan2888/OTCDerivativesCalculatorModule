using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RefVariable_referenceValue : ISerialized
    {
        public RefVariable_referenceValue() { }
        public RefVariable_referenceValue(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode variableInfoNode = xmlNode.SelectSingleNode("variableInfo");
            
            if (variableInfoNode != null)
            {
                if (variableInfoNode.Attributes["href"] != null || variableInfoNode.Attributes["id"] != null) 
                {
                    if (variableInfoNode.Attributes["id"] != null) 
                    {
                        variableInfoIDRef_ = variableInfoNode.Attributes["id"].Value;
                        VariableInfo ob = new VariableInfo(variableInfoNode);
                        IDManager.SetID(variableInfoIDRef_, ob);
                    }
                    else if (variableInfoNode.Attributes["href"] != null)
                    {
                        variableInfoIDRef_ = variableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        variableInfo_ = new VariableInfo(variableInfoNode);
                    }
                }
                else
                {
                    variableInfo_ = new VariableInfo(variableInfoNode);
                }
            }
            
        
        }
        
    
        #region VariableInfo_
        private VariableInfo variableInfo_;
        public VariableInfo VariableInfo_
        {
            get
            {
                if (this.variableInfo_ != null)
                {
                    return this.variableInfo_; 
                }
                else if (this.variableInfoIDRef_ != null)
                {
                    variableInfo_ = IDManager.getID(variableInfoIDRef_) as VariableInfo;
                    return this.variableInfo_; 
                }
                else
                {
                    throw new Exception( "variableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.variableInfo_ != value)
                {
                    this.variableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string variableInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

