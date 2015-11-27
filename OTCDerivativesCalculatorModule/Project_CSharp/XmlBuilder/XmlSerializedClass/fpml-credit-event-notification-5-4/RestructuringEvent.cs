using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RestructuringEvent : CreditEvent
    {
        public RestructuringEvent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode partialExerciseAmountNode = xmlNode.SelectSingleNode("partialExerciseAmount");
            
            if (partialExerciseAmountNode != null)
            {
                if (partialExerciseAmountNode.Attributes["href"] != null || partialExerciseAmountNode.Attributes["id"] != null) 
                {
                    if (partialExerciseAmountNode.Attributes["id"] != null) 
                    {
                        partialExerciseAmountIDRef_ = partialExerciseAmountNode.Attributes["id"].Value;
                        Money ob = new Money(partialExerciseAmountNode);
                        IDManager.SetID(partialExerciseAmountIDRef_, ob);
                    }
                    else if (partialExerciseAmountNode.Attributes["href"] != null)
                    {
                        partialExerciseAmountIDRef_ = partialExerciseAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partialExerciseAmount_ = new Money(partialExerciseAmountNode);
                    }
                }
                else
                {
                    partialExerciseAmount_ = new Money(partialExerciseAmountNode);
                }
            }
            
        
        }
        
    
        #region PartialExerciseAmount_
        private Money partialExerciseAmount_;
        public Money PartialExerciseAmount_
        {
            get
            {
                if (this.partialExerciseAmount_ != null)
                {
                    return this.partialExerciseAmount_; 
                }
                else if (this.partialExerciseAmountIDRef_ != null)
                {
                    partialExerciseAmount_ = IDManager.getID(partialExerciseAmountIDRef_) as Money;
                    return this.partialExerciseAmount_; 
                }
                else
                {
                      return this.partialExerciseAmount_; 
                }
            }
            set
            {
                if (this.partialExerciseAmount_ != value)
                {
                    this.partialExerciseAmount_ = value;
                }
            }
        }
        #endregion
        
        public string partialExerciseAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

