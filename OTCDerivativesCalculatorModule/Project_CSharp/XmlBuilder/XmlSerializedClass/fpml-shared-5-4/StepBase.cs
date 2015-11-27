using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StepBase : ISerialized
    {
        public StepBase(XmlNode xmlNode)
        {
            XmlNode stepDateNode = xmlNode.SelectSingleNode("stepDate");
            
            if (stepDateNode != null)
            {
                if (stepDateNode.Attributes["href"] != null || stepDateNode.Attributes["id"] != null) 
                {
                    if (stepDateNode.Attributes["id"] != null) 
                    {
                        stepDateIDRef_ = stepDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(stepDateNode);
                        IDManager.SetID(stepDateIDRef_, ob);
                    }
                    else if (stepDateNode.Attributes["href"] != null)
                    {
                        stepDateIDRef_ = stepDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepDate_ = new XsdTypeDate(stepDateNode);
                    }
                }
                else
                {
                    stepDate_ = new XsdTypeDate(stepDateNode);
                }
            }
            
        
        }
        
    
        #region StepDate_
        private XsdTypeDate stepDate_;
        public XsdTypeDate StepDate_
        {
            get
            {
                if (this.stepDate_ != null)
                {
                    return this.stepDate_; 
                }
                else if (this.stepDateIDRef_ != null)
                {
                    stepDate_ = IDManager.getID(stepDateIDRef_) as XsdTypeDate;
                    return this.stepDate_; 
                }
                else
                {
                      return this.stepDate_; 
                }
            }
            set
            {
                if (this.stepDate_ != value)
                {
                    this.stepDate_ = value;
                }
            }
        }
        #endregion
        
        public string stepDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

