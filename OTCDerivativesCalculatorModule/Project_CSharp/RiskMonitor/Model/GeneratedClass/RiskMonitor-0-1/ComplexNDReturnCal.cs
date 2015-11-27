using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ComplexNDReturnCal : ISerialized
    {
        public ComplexNDReturnCal() { }
        public ComplexNDReturnCal(XmlNode xmlNode)
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
            
        
            XmlNode operatorNDNode = xmlNode.SelectSingleNode("operatorND");
            
            if (operatorNDNode != null)
            {
                if (operatorNDNode.Attributes["href"] != null || operatorNDNode.Attributes["id"] != null) 
                {
                    if (operatorNDNode.Attributes["id"] != null) 
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["id"].Value;
                        OperatorND ob = new OperatorND(operatorNDNode);
                        IDManager.SetID(operatorNDIDRef_, ob);
                    }
                    else if (operatorNDNode.Attributes["href"] != null)
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        operatorND_ = new OperatorND(operatorNDNode);
                    }
                }
                else
                {
                    operatorND_ = new OperatorND(operatorNDNode);
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
        #region OperatorND_
        private OperatorND operatorND_;
        public OperatorND OperatorND_
        {
            get
            {
                if (this.operatorND_ != null)
                {
                    return this.operatorND_; 
                }
                else if (this.operatorNDIDRef_ != null)
                {
                    operatorND_ = IDManager.getID(operatorNDIDRef_) as OperatorND;
                    return this.operatorND_; 
                }
                else
                {
                    throw new Exception( "operatorND_Node no exist!");
                }
            }
            set
            {
                if (this.operatorND_ != value)
                {
                    this.operatorND_ = value;
                }
            }
        }
        #endregion
        
        public string operatorNDIDRef_ { get; set; }
        
    
        
    
    }
    
}

