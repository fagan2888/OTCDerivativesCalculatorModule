using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PostCalculation : ISerialized
    {
        public PostCalculation() { }
        public PostCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode operator1DListNode = xmlNode.SelectSingleNode("operator1DList");
            
            if (operator1DListNode != null)
            {
                if (operator1DListNode.Attributes["href"] != null || operator1DListNode.Attributes["id"] != null) 
                {
                    if (operator1DListNode.Attributes["id"] != null) 
                    {
                        operator1DListIDRef_ = operator1DListNode.Attributes["id"].Value;
                        Operator1DList ob = new Operator1DList(operator1DListNode);
                        IDManager.SetID(operator1DListIDRef_, ob);
                    }
                    else if (operator1DListNode.Attributes["href"] != null)
                    {
                        operator1DListIDRef_ = operator1DListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        operator1DList_ = new Operator1DList(operator1DListNode);
                    }
                }
                else
                {
                    operator1DList_ = new Operator1DList(operator1DListNode);
                }
            }
            
        
            XmlNode conditionOperatorNode = xmlNode.SelectSingleNode("conditionOperator");
            
            if (conditionOperatorNode != null)
            {
                if (conditionOperatorNode.Attributes["href"] != null || conditionOperatorNode.Attributes["id"] != null) 
                {
                    if (conditionOperatorNode.Attributes["id"] != null) 
                    {
                        conditionOperatorIDRef_ = conditionOperatorNode.Attributes["id"].Value;
                        ConditionOperator ob = new ConditionOperator(conditionOperatorNode);
                        IDManager.SetID(conditionOperatorIDRef_, ob);
                    }
                    else if (conditionOperatorNode.Attributes["href"] != null)
                    {
                        conditionOperatorIDRef_ = conditionOperatorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conditionOperator_ = new ConditionOperator(conditionOperatorNode);
                    }
                }
                else
                {
                    conditionOperator_ = new ConditionOperator(conditionOperatorNode);
                }
            }
            
        
        }
        
    
        #region Operator1DList_
        private Operator1DList operator1DList_;
        public Operator1DList Operator1DList_
        {
            get
            {
                if (this.operator1DList_ != null)
                {
                    return this.operator1DList_; 
                }
                else if (this.operator1DListIDRef_ != null)
                {
                    operator1DList_ = IDManager.getID(operator1DListIDRef_) as Operator1DList;
                    return this.operator1DList_; 
                }
                else
                {
                    throw new Exception( "operator1DList_Node no exist!");
                }
            }
            set
            {
                if (this.operator1DList_ != value)
                {
                    this.operator1DList_ = value;
                }
            }
        }
        #endregion
        
        public string operator1DListIDRef_ { get; set; }
        #region ConditionOperator_
        private ConditionOperator conditionOperator_;
        public ConditionOperator ConditionOperator_
        {
            get
            {
                if (this.conditionOperator_ != null)
                {
                    return this.conditionOperator_; 
                }
                else if (this.conditionOperatorIDRef_ != null)
                {
                    conditionOperator_ = IDManager.getID(conditionOperatorIDRef_) as ConditionOperator;
                    return this.conditionOperator_; 
                }
                else
                {
                    throw new Exception( "conditionOperator_Node no exist!");
                }
            }
            set
            {
                if (this.conditionOperator_ != value)
                {
                    this.conditionOperator_ = value;
                }
            }
        }
        #endregion
        
        public string conditionOperatorIDRef_ { get; set; }
        
    
        
    
    }
    
}

