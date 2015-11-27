using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Pricing : ISerialized
    {
        public Pricing() { }
        public Pricing(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode evaluationTimeNode = xmlNode.SelectSingleNode("evaluationTime");
            
            if (evaluationTimeNode != null)
            {
                if (evaluationTimeNode.Attributes["href"] != null || evaluationTimeNode.Attributes["id"] != null) 
                {
                    if (evaluationTimeNode.Attributes["id"] != null) 
                    {
                        evaluationTimeIDRef_ = evaluationTimeNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(evaluationTimeNode);
                        IDManager.SetID(evaluationTimeIDRef_, ob);
                    }
                    else if (evaluationTimeNode.Attributes["href"] != null)
                    {
                        evaluationTimeIDRef_ = evaluationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        evaluationTime_ = new XsdTypeDate(evaluationTimeNode);
                    }
                }
                else
                {
                    evaluationTime_ = new XsdTypeDate(evaluationTimeNode);
                }
            }
            
        
            XmlNode excel_parameterNode = xmlNode.SelectSingleNode("excel_parameter");
            
            if (excel_parameterNode != null)
            {
                if (excel_parameterNode.Attributes["href"] != null || excel_parameterNode.Attributes["id"] != null) 
                {
                    if (excel_parameterNode.Attributes["id"] != null) 
                    {
                        excel_parameterIDRef_ = excel_parameterNode.Attributes["id"].Value;
                        Excel_parameter ob = new Excel_parameter(excel_parameterNode);
                        IDManager.SetID(excel_parameterIDRef_, ob);
                    }
                    else if (excel_parameterNode.Attributes["href"] != null)
                    {
                        excel_parameterIDRef_ = excel_parameterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_parameter_ = new Excel_parameter(excel_parameterNode);
                    }
                }
                else
                {
                    excel_parameter_ = new Excel_parameter(excel_parameterNode);
                }
            }
            
        
        }
        
    
        #region EvaluationTime_
        private XsdTypeDate evaluationTime_;
        public XsdTypeDate EvaluationTime_
        {
            get
            {
                if (this.evaluationTime_ != null)
                {
                    return this.evaluationTime_; 
                }
                else if (this.evaluationTimeIDRef_ != null)
                {
                    evaluationTime_ = IDManager.getID(evaluationTimeIDRef_) as XsdTypeDate;
                    return this.evaluationTime_; 
                }
                else
                {
                    throw new Exception( "evaluationTime_Node no exist!");
                }
            }
            set
            {
                if (this.evaluationTime_ != value)
                {
                    this.evaluationTime_ = value;
                }
            }
        }
        #endregion
        
        public string evaluationTimeIDRef_ { get; set; }
        #region Excel_parameter_
        private Excel_parameter excel_parameter_;
        public Excel_parameter Excel_parameter_
        {
            get
            {
                if (this.excel_parameter_ != null)
                {
                    return this.excel_parameter_; 
                }
                else if (this.excel_parameterIDRef_ != null)
                {
                    excel_parameter_ = IDManager.getID(excel_parameterIDRef_) as Excel_parameter;
                    return this.excel_parameter_; 
                }
                else
                {
                    throw new Exception( "excel_parameter_Node no exist!");
                }
            }
            set
            {
                if (this.excel_parameter_ != value)
                {
                    this.excel_parameter_ = value;
                }
            }
        }
        #endregion
        
        public string excel_parameterIDRef_ { get; set; }
        
    
        
    
    }
    
}

