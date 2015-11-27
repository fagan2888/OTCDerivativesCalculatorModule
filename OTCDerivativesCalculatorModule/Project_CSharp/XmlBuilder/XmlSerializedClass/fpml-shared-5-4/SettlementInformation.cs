using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementInformation : ISerialized
    {
        public SettlementInformation(XmlNode xmlNode)
        {
            XmlNode standardSettlementStyleNode = xmlNode.SelectSingleNode("standardSettlementStyle");
            
            if (standardSettlementStyleNode != null)
            {
                if (standardSettlementStyleNode.Attributes["href"] != null || standardSettlementStyleNode.Attributes["id"] != null) 
                {
                    if (standardSettlementStyleNode.Attributes["id"] != null) 
                    {
                        standardSettlementStyleIDRef_ = standardSettlementStyleNode.Attributes["id"].Value;
                        StandardSettlementStyleEnum ob = new StandardSettlementStyleEnum(standardSettlementStyleNode);
                        IDManager.SetID(standardSettlementStyleIDRef_, ob);
                    }
                    else if (standardSettlementStyleNode.Attributes["href"] != null)
                    {
                        standardSettlementStyleIDRef_ = standardSettlementStyleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardSettlementStyle_ = new StandardSettlementStyleEnum(standardSettlementStyleNode);
                    }
                }
                else
                {
                    standardSettlementStyle_ = new StandardSettlementStyleEnum(standardSettlementStyleNode);
                }
            }
            
        
            XmlNode settlementInstructionNode = xmlNode.SelectSingleNode("settlementInstruction");
            
            if (settlementInstructionNode != null)
            {
                if (settlementInstructionNode.Attributes["href"] != null || settlementInstructionNode.Attributes["id"] != null) 
                {
                    if (settlementInstructionNode.Attributes["id"] != null) 
                    {
                        settlementInstructionIDRef_ = settlementInstructionNode.Attributes["id"].Value;
                        SettlementInstruction ob = new SettlementInstruction(settlementInstructionNode);
                        IDManager.SetID(settlementInstructionIDRef_, ob);
                    }
                    else if (settlementInstructionNode.Attributes["href"] != null)
                    {
                        settlementInstructionIDRef_ = settlementInstructionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementInstruction_ = new SettlementInstruction(settlementInstructionNode);
                    }
                }
                else
                {
                    settlementInstruction_ = new SettlementInstruction(settlementInstructionNode);
                }
            }
            
        
        }
        
    
        #region StandardSettlementStyle_
        private StandardSettlementStyleEnum standardSettlementStyle_;
        public StandardSettlementStyleEnum StandardSettlementStyle_
        {
            get
            {
                if (this.standardSettlementStyle_ != null)
                {
                    return this.standardSettlementStyle_; 
                }
                else if (this.standardSettlementStyleIDRef_ != null)
                {
                    standardSettlementStyle_ = IDManager.getID(standardSettlementStyleIDRef_) as StandardSettlementStyleEnum;
                    return this.standardSettlementStyle_; 
                }
                else
                {
                      return this.standardSettlementStyle_; 
                }
            }
            set
            {
                if (this.standardSettlementStyle_ != value)
                {
                    this.standardSettlementStyle_ = value;
                }
            }
        }
        #endregion
        
        public string standardSettlementStyleIDRef_ { get; set; }
        #region SettlementInstruction_
        private SettlementInstruction settlementInstruction_;
        public SettlementInstruction SettlementInstruction_
        {
            get
            {
                if (this.settlementInstruction_ != null)
                {
                    return this.settlementInstruction_; 
                }
                else if (this.settlementInstructionIDRef_ != null)
                {
                    settlementInstruction_ = IDManager.getID(settlementInstructionIDRef_) as SettlementInstruction;
                    return this.settlementInstruction_; 
                }
                else
                {
                      return this.settlementInstruction_; 
                }
            }
            set
            {
                if (this.settlementInstruction_ != value)
                {
                    this.settlementInstruction_ = value;
                }
            }
        }
        #endregion
        
        public string settlementInstructionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

