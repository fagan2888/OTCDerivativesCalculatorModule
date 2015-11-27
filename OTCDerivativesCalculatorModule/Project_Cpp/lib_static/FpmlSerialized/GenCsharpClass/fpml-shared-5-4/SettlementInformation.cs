using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementInformation
    {
        public SettlementInformation(XmlNode xmlNode)
        {
            XmlNodeList standardSettlementStyleNodeList = xmlNode.SelectNodes("standardSettlementStyle");
            if (standardSettlementStyleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardSettlementStyleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardSettlementStyleIDRef = item.Attributes["id"].Name;
                        StandardSettlementStyleEnum ob = StandardSettlementStyleEnum();
                        IDManager.SetID(standardSettlementStyleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardSettlementStyleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardSettlementStyle = new StandardSettlementStyleEnum(item);
                    }
                }
            }
            
        
            XmlNodeList settlementInstructionNodeList = xmlNode.SelectNodes("settlementInstruction");
            if (settlementInstructionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementInstructionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementInstructionIDRef = item.Attributes["id"].Name;
                        SettlementInstruction ob = SettlementInstruction();
                        IDManager.SetID(settlementInstructionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementInstructionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementInstruction = new SettlementInstruction(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardSettlementStyle
        private StandardSettlementStyleEnum standardSettlementStyle;
        public StandardSettlementStyleEnum StandardSettlementStyle
        {
            get
            {
                if (this.standardSettlementStyle != null)
                {
                    return this.standardSettlementStyle; 
                }
                else if (this.standardSettlementStyleIDRef != null)
                {
                    standardSettlementStyle = IDManager.getID(standardSettlementStyleIDRef) as StandardSettlementStyleEnum;
                    return this.standardSettlementStyle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardSettlementStyle != value)
                {
                    this.standardSettlementStyle = value;
                }
            }
        }
        #endregion
        
        public string StandardSettlementStyleEnumIDRef { get; set; }
        #region SettlementInstruction
        private SettlementInstruction settlementInstruction;
        public SettlementInstruction SettlementInstruction
        {
            get
            {
                if (this.settlementInstruction != null)
                {
                    return this.settlementInstruction; 
                }
                else if (this.settlementInstructionIDRef != null)
                {
                    settlementInstruction = IDManager.getID(settlementInstructionIDRef) as SettlementInstruction;
                    return this.settlementInstruction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementInstruction != value)
                {
                    this.settlementInstruction = value;
                }
            }
        }
        #endregion
        
        public string SettlementInstructionIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

