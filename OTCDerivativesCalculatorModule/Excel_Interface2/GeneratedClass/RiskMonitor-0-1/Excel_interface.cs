using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_interface : ISerialized
    {
        public Excel_interface() { }
        public Excel_interface(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_typeNode = xmlNode.SelectSingleNode("excel_type");
            
            if (excel_typeNode != null)
            {
                if (excel_typeNode.Attributes["href"] != null || excel_typeNode.Attributes["id"] != null) 
                {
                    if (excel_typeNode.Attributes["id"] != null) 
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(excel_typeNode);
                        IDManager.SetID(excel_typeIDRef_, ob);
                    }
                    else if (excel_typeNode.Attributes["href"] != null)
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_type_ = new XsdTypeToken(excel_typeNode);
                    }
                }
                else
                {
                    excel_type_ = new XsdTypeToken(excel_typeNode);
                }
            }
            
        
            XmlNode excel_hifiveNode = xmlNode.SelectSingleNode("excel_hifive");
            
            if (excel_hifiveNode != null)
            {
                if (excel_hifiveNode.Attributes["href"] != null || excel_hifiveNode.Attributes["id"] != null) 
                {
                    if (excel_hifiveNode.Attributes["id"] != null) 
                    {
                        excel_hifiveIDRef_ = excel_hifiveNode.Attributes["id"].Value;
                        Excel_hifive ob = new Excel_hifive(excel_hifiveNode);
                        IDManager.SetID(excel_hifiveIDRef_, ob);
                    }
                    else if (excel_hifiveNode.Attributes["href"] != null)
                    {
                        excel_hifiveIDRef_ = excel_hifiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hifive_ = new Excel_hifive(excel_hifiveNode);
                    }
                }
                else
                {
                    excel_hifive_ = new Excel_hifive(excel_hifiveNode);
                }
            }
            
        
            XmlNode excel_stepDownKICustomNode = xmlNode.SelectSingleNode("excel_stepDownKICustom");
            
            if (excel_stepDownKICustomNode != null)
            {
                if (excel_stepDownKICustomNode.Attributes["href"] != null || excel_stepDownKICustomNode.Attributes["id"] != null) 
                {
                    if (excel_stepDownKICustomNode.Attributes["id"] != null) 
                    {
                        excel_stepDownKICustomIDRef_ = excel_stepDownKICustomNode.Attributes["id"].Value;
                        Excel_stepDownKICustom ob = new Excel_stepDownKICustom(excel_stepDownKICustomNode);
                        IDManager.SetID(excel_stepDownKICustomIDRef_, ob);
                    }
                    else if (excel_stepDownKICustomNode.Attributes["href"] != null)
                    {
                        excel_stepDownKICustomIDRef_ = excel_stepDownKICustomNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_stepDownKICustom_ = new Excel_stepDownKICustom(excel_stepDownKICustomNode);
                    }
                }
                else
                {
                    excel_stepDownKICustom_ = new Excel_stepDownKICustom(excel_stepDownKICustomNode);
                }
            }
            
        
            XmlNode excel_compositeOptionNode = xmlNode.SelectSingleNode("excel_compositeOption");
            
            if (excel_compositeOptionNode != null)
            {
                if (excel_compositeOptionNode.Attributes["href"] != null || excel_compositeOptionNode.Attributes["id"] != null) 
                {
                    if (excel_compositeOptionNode.Attributes["id"] != null) 
                    {
                        excel_compositeOptionIDRef_ = excel_compositeOptionNode.Attributes["id"].Value;
                        Excel_compositeOption ob = new Excel_compositeOption(excel_compositeOptionNode);
                        IDManager.SetID(excel_compositeOptionIDRef_, ob);
                    }
                    else if (excel_compositeOptionNode.Attributes["href"] != null)
                    {
                        excel_compositeOptionIDRef_ = excel_compositeOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_compositeOption_ = new Excel_compositeOption(excel_compositeOptionNode);
                    }
                }
                else
                {
                    excel_compositeOption_ = new Excel_compositeOption(excel_compositeOptionNode);
                }
            }
            
        
            XmlNode excel_generalNode = xmlNode.SelectSingleNode("excel_general");
            
            if (excel_generalNode != null)
            {
                if (excel_generalNode.Attributes["href"] != null || excel_generalNode.Attributes["id"] != null) 
                {
                    if (excel_generalNode.Attributes["id"] != null) 
                    {
                        excel_generalIDRef_ = excel_generalNode.Attributes["id"].Value;
                        Excel_general ob = new Excel_general(excel_generalNode);
                        IDManager.SetID(excel_generalIDRef_, ob);
                    }
                    else if (excel_generalNode.Attributes["href"] != null)
                    {
                        excel_generalIDRef_ = excel_generalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_general_ = new Excel_general(excel_generalNode);
                    }
                }
                else
                {
                    excel_general_ = new Excel_general(excel_generalNode);
                }
            }
            
        
            XmlNode excel_fixedBondNode = xmlNode.SelectSingleNode("excel_fixedBond");
            
            if (excel_fixedBondNode != null)
            {
                if (excel_fixedBondNode.Attributes["href"] != null || excel_fixedBondNode.Attributes["id"] != null) 
                {
                    if (excel_fixedBondNode.Attributes["id"] != null) 
                    {
                        excel_fixedBondIDRef_ = excel_fixedBondNode.Attributes["id"].Value;
                        Excel_fixedBond ob = new Excel_fixedBond(excel_fixedBondNode);
                        IDManager.SetID(excel_fixedBondIDRef_, ob);
                    }
                    else if (excel_fixedBondNode.Attributes["href"] != null)
                    {
                        excel_fixedBondIDRef_ = excel_fixedBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedBond_ = new Excel_fixedBond(excel_fixedBondNode);
                    }
                }
                else
                {
                    excel_fixedBond_ = new Excel_fixedBond(excel_fixedBondNode);
                }
            }
            
        
            XmlNode excel_vanillaFloatingBondNode = xmlNode.SelectSingleNode("excel_vanillaFloatingBond");
            
            if (excel_vanillaFloatingBondNode != null)
            {
                if (excel_vanillaFloatingBondNode.Attributes["href"] != null || excel_vanillaFloatingBondNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingBondNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingBondIDRef_ = excel_vanillaFloatingBondNode.Attributes["id"].Value;
                        Excel_vanillaFloatingBond ob = new Excel_vanillaFloatingBond(excel_vanillaFloatingBondNode);
                        IDManager.SetID(excel_vanillaFloatingBondIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingBondNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingBondIDRef_ = excel_vanillaFloatingBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingBond_ = new Excel_vanillaFloatingBond(excel_vanillaFloatingBondNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingBond_ = new Excel_vanillaFloatingBond(excel_vanillaFloatingBondNode);
                }
            }
            
        
            XmlNode excel_structuredBondNode = xmlNode.SelectSingleNode("excel_structuredBond");
            
            if (excel_structuredBondNode != null)
            {
                if (excel_structuredBondNode.Attributes["href"] != null || excel_structuredBondNode.Attributes["id"] != null) 
                {
                    if (excel_structuredBondNode.Attributes["id"] != null) 
                    {
                        excel_structuredBondIDRef_ = excel_structuredBondNode.Attributes["id"].Value;
                        Excel_structuredBond ob = new Excel_structuredBond(excel_structuredBondNode);
                        IDManager.SetID(excel_structuredBondIDRef_, ob);
                    }
                    else if (excel_structuredBondNode.Attributes["href"] != null)
                    {
                        excel_structuredBondIDRef_ = excel_structuredBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredBond_ = new Excel_structuredBond(excel_structuredBondNode);
                    }
                }
                else
                {
                    excel_structuredBond_ = new Excel_structuredBond(excel_structuredBondNode);
                }
            }
            
        
            XmlNode excel_fxForwardNode = xmlNode.SelectSingleNode("excel_fxForward");
            
            if (excel_fxForwardNode != null)
            {
                if (excel_fxForwardNode.Attributes["href"] != null || excel_fxForwardNode.Attributes["id"] != null) 
                {
                    if (excel_fxForwardNode.Attributes["id"] != null) 
                    {
                        excel_fxForwardIDRef_ = excel_fxForwardNode.Attributes["id"].Value;
                        Excel_fxForward ob = new Excel_fxForward(excel_fxForwardNode);
                        IDManager.SetID(excel_fxForwardIDRef_, ob);
                    }
                    else if (excel_fxForwardNode.Attributes["href"] != null)
                    {
                        excel_fxForwardIDRef_ = excel_fxForwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fxForward_ = new Excel_fxForward(excel_fxForwardNode);
                    }
                }
                else
                {
                    excel_fxForward_ = new Excel_fxForward(excel_fxForwardNode);
                }
            }
            
        
            XmlNode excel_fxSwapNode = xmlNode.SelectSingleNode("excel_fxSwap");
            
            if (excel_fxSwapNode != null)
            {
                if (excel_fxSwapNode.Attributes["href"] != null || excel_fxSwapNode.Attributes["id"] != null) 
                {
                    if (excel_fxSwapNode.Attributes["id"] != null) 
                    {
                        excel_fxSwapIDRef_ = excel_fxSwapNode.Attributes["id"].Value;
                        Excel_fxSwap ob = new Excel_fxSwap(excel_fxSwapNode);
                        IDManager.SetID(excel_fxSwapIDRef_, ob);
                    }
                    else if (excel_fxSwapNode.Attributes["href"] != null)
                    {
                        excel_fxSwapIDRef_ = excel_fxSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fxSwap_ = new Excel_fxSwap(excel_fxSwapNode);
                    }
                }
                else
                {
                    excel_fxSwap_ = new Excel_fxSwap(excel_fxSwapNode);
                }
            }
            
        
            XmlNode excel_multiAssetCompositeOptionNode = xmlNode.SelectSingleNode("excel_multiAssetCompositeOption");
            
            if (excel_multiAssetCompositeOptionNode != null)
            {
                if (excel_multiAssetCompositeOptionNode.Attributes["href"] != null || excel_multiAssetCompositeOptionNode.Attributes["id"] != null) 
                {
                    if (excel_multiAssetCompositeOptionNode.Attributes["id"] != null) 
                    {
                        excel_multiAssetCompositeOptionIDRef_ = excel_multiAssetCompositeOptionNode.Attributes["id"].Value;
                        Excel_multiAssetCompositeOption ob = new Excel_multiAssetCompositeOption(excel_multiAssetCompositeOptionNode);
                        IDManager.SetID(excel_multiAssetCompositeOptionIDRef_, ob);
                    }
                    else if (excel_multiAssetCompositeOptionNode.Attributes["href"] != null)
                    {
                        excel_multiAssetCompositeOptionIDRef_ = excel_multiAssetCompositeOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiAssetCompositeOption_ = new Excel_multiAssetCompositeOption(excel_multiAssetCompositeOptionNode);
                    }
                }
                else
                {
                    excel_multiAssetCompositeOption_ = new Excel_multiAssetCompositeOption(excel_multiAssetCompositeOptionNode);
                }
            }
            
        
        }
        
    
        #region Excel_type_
        private XsdTypeToken excel_type_;
        public XsdTypeToken Excel_type_
        {
            get
            {
                if (this.excel_type_ != null)
                {
                    return this.excel_type_; 
                }
                else if (this.excel_typeIDRef_ != null)
                {
                    excel_type_ = IDManager.getID(excel_typeIDRef_) as XsdTypeToken;
                    return this.excel_type_; 
                }
                else
                {
                    throw new Exception( "excel_type_Node no exist!");
                }
            }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                }
            }
        }
        #endregion
        
        public string excel_typeIDRef_ { get; set; }
        #region Excel_hifive_
        private Excel_hifive excel_hifive_;
        public Excel_hifive Excel_hifive_
        {
            get
            {
                if (this.excel_hifive_ != null)
                {
                    return this.excel_hifive_; 
                }
                else if (this.excel_hifiveIDRef_ != null)
                {
                    excel_hifive_ = IDManager.getID(excel_hifiveIDRef_) as Excel_hifive;
                    return this.excel_hifive_; 
                }
                else
                {
                    throw new Exception( "excel_hifive_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hifive_ != value)
                {
                    this.excel_hifive_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hifiveIDRef_ { get; set; }
        #region Excel_stepDownKICustom_
        private Excel_stepDownKICustom excel_stepDownKICustom_;
        public Excel_stepDownKICustom Excel_stepDownKICustom_
        {
            get
            {
                if (this.excel_stepDownKICustom_ != null)
                {
                    return this.excel_stepDownKICustom_; 
                }
                else if (this.excel_stepDownKICustomIDRef_ != null)
                {
                    excel_stepDownKICustom_ = IDManager.getID(excel_stepDownKICustomIDRef_) as Excel_stepDownKICustom;
                    return this.excel_stepDownKICustom_; 
                }
                else
                {
                    throw new Exception( "excel_stepDownKICustom_Node no exist!");
                }
            }
            set
            {
                if (this.excel_stepDownKICustom_ != value)
                {
                    this.excel_stepDownKICustom_ = value;
                }
            }
        }
        #endregion
        
        public string excel_stepDownKICustomIDRef_ { get; set; }
        #region Excel_compositeOption_
        private Excel_compositeOption excel_compositeOption_;
        public Excel_compositeOption Excel_compositeOption_
        {
            get
            {
                if (this.excel_compositeOption_ != null)
                {
                    return this.excel_compositeOption_; 
                }
                else if (this.excel_compositeOptionIDRef_ != null)
                {
                    excel_compositeOption_ = IDManager.getID(excel_compositeOptionIDRef_) as Excel_compositeOption;
                    return this.excel_compositeOption_; 
                }
                else
                {
                    throw new Exception( "excel_compositeOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_compositeOption_ != value)
                {
                    this.excel_compositeOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_compositeOptionIDRef_ { get; set; }
        #region Excel_general_
        private Excel_general excel_general_;
        public Excel_general Excel_general_
        {
            get
            {
                if (this.excel_general_ != null)
                {
                    return this.excel_general_; 
                }
                else if (this.excel_generalIDRef_ != null)
                {
                    excel_general_ = IDManager.getID(excel_generalIDRef_) as Excel_general;
                    return this.excel_general_; 
                }
                else
                {
                    throw new Exception( "excel_general_Node no exist!");
                }
            }
            set
            {
                if (this.excel_general_ != value)
                {
                    this.excel_general_ = value;
                }
            }
        }
        #endregion
        
        public string excel_generalIDRef_ { get; set; }
        #region Excel_fixedBond_
        private Excel_fixedBond excel_fixedBond_;
        public Excel_fixedBond Excel_fixedBond_
        {
            get
            {
                if (this.excel_fixedBond_ != null)
                {
                    return this.excel_fixedBond_; 
                }
                else if (this.excel_fixedBondIDRef_ != null)
                {
                    excel_fixedBond_ = IDManager.getID(excel_fixedBondIDRef_) as Excel_fixedBond;
                    return this.excel_fixedBond_; 
                }
                else
                {
                    throw new Exception( "excel_fixedBond_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedBond_ != value)
                {
                    this.excel_fixedBond_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedBondIDRef_ { get; set; }
        #region Excel_vanillaFloatingBond_
        private Excel_vanillaFloatingBond excel_vanillaFloatingBond_;
        public Excel_vanillaFloatingBond Excel_vanillaFloatingBond_
        {
            get
            {
                if (this.excel_vanillaFloatingBond_ != null)
                {
                    return this.excel_vanillaFloatingBond_; 
                }
                else if (this.excel_vanillaFloatingBondIDRef_ != null)
                {
                    excel_vanillaFloatingBond_ = IDManager.getID(excel_vanillaFloatingBondIDRef_) as Excel_vanillaFloatingBond;
                    return this.excel_vanillaFloatingBond_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingBond_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingBond_ != value)
                {
                    this.excel_vanillaFloatingBond_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingBondIDRef_ { get; set; }
        #region Excel_structuredBond_
        private Excel_structuredBond excel_structuredBond_;
        public Excel_structuredBond Excel_structuredBond_
        {
            get
            {
                if (this.excel_structuredBond_ != null)
                {
                    return this.excel_structuredBond_; 
                }
                else if (this.excel_structuredBondIDRef_ != null)
                {
                    excel_structuredBond_ = IDManager.getID(excel_structuredBondIDRef_) as Excel_structuredBond;
                    return this.excel_structuredBond_; 
                }
                else
                {
                    throw new Exception( "excel_structuredBond_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredBond_ != value)
                {
                    this.excel_structuredBond_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredBondIDRef_ { get; set; }
        #region Excel_fxForward_
        private Excel_fxForward excel_fxForward_;
        public Excel_fxForward Excel_fxForward_
        {
            get
            {
                if (this.excel_fxForward_ != null)
                {
                    return this.excel_fxForward_; 
                }
                else if (this.excel_fxForwardIDRef_ != null)
                {
                    excel_fxForward_ = IDManager.getID(excel_fxForwardIDRef_) as Excel_fxForward;
                    return this.excel_fxForward_; 
                }
                else
                {
                    throw new Exception( "excel_fxForward_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fxForward_ != value)
                {
                    this.excel_fxForward_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fxForwardIDRef_ { get; set; }
        #region Excel_fxSwap_
        private Excel_fxSwap excel_fxSwap_;
        public Excel_fxSwap Excel_fxSwap_
        {
            get
            {
                if (this.excel_fxSwap_ != null)
                {
                    return this.excel_fxSwap_; 
                }
                else if (this.excel_fxSwapIDRef_ != null)
                {
                    excel_fxSwap_ = IDManager.getID(excel_fxSwapIDRef_) as Excel_fxSwap;
                    return this.excel_fxSwap_; 
                }
                else
                {
                    throw new Exception( "excel_fxSwap_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fxSwap_ != value)
                {
                    this.excel_fxSwap_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fxSwapIDRef_ { get; set; }
        #region Excel_multiAssetCompositeOption_
        private Excel_multiAssetCompositeOption excel_multiAssetCompositeOption_;
        public Excel_multiAssetCompositeOption Excel_multiAssetCompositeOption_
        {
            get
            {
                if (this.excel_multiAssetCompositeOption_ != null)
                {
                    return this.excel_multiAssetCompositeOption_; 
                }
                else if (this.excel_multiAssetCompositeOptionIDRef_ != null)
                {
                    excel_multiAssetCompositeOption_ = IDManager.getID(excel_multiAssetCompositeOptionIDRef_) as Excel_multiAssetCompositeOption;
                    return this.excel_multiAssetCompositeOption_; 
                }
                else
                {
                    throw new Exception( "excel_multiAssetCompositeOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAssetCompositeOption_ != value)
                {
                    this.excel_multiAssetCompositeOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAssetCompositeOptionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

