using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PreCalculation : ISerialized
    {
        public PreCalculation() { }
        public PreCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode variableCalListNode = xmlNode.SelectSingleNode("variableCalList");
            
            if (variableCalListNode != null)
            {
                if (variableCalListNode.Attributes["href"] != null || variableCalListNode.Attributes["id"] != null) 
                {
                    if (variableCalListNode.Attributes["id"] != null) 
                    {
                        variableCalListIDRef_ = variableCalListNode.Attributes["id"].Value;
                        VariableCalList ob = new VariableCalList(variableCalListNode);
                        IDManager.SetID(variableCalListIDRef_, ob);
                    }
                    else if (variableCalListNode.Attributes["href"] != null)
                    {
                        variableCalListIDRef_ = variableCalListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        variableCalList_ = new VariableCalList(variableCalListNode);
                    }
                }
                else
                {
                    variableCalList_ = new VariableCalList(variableCalListNode);
                }
            }
            
        
        }
        
    
        #region VariableCalList_
        private VariableCalList variableCalList_;
        public VariableCalList VariableCalList_
        {
            get
            {
                if (this.variableCalList_ != null)
                {
                    return this.variableCalList_; 
                }
                else if (this.variableCalListIDRef_ != null)
                {
                    variableCalList_ = IDManager.getID(variableCalListIDRef_) as VariableCalList;
                    return this.variableCalList_; 
                }
                else
                {
                    throw new Exception( "variableCalList_Node no exist!");
                }
            }
            set
            {
                if (this.variableCalList_ != value)
                {
                    this.variableCalList_ = value;
                }
            }
        }
        #endregion
        
        public string variableCalListIDRef_ { get; set; }
        
    
        
    
    }
    
}

