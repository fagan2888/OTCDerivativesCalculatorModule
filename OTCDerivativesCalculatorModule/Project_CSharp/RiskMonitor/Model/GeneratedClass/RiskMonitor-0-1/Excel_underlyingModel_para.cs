using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingModel_para : ISerialized
    {
        public Excel_underlyingModel_para() { }
        public Excel_underlyingModel_para(XmlNode xmlNode)
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
            
        
            XmlNode excel_geometricBMNode = xmlNode.SelectSingleNode("excel_geometricBM");
            
            if (excel_geometricBMNode != null)
            {
                if (excel_geometricBMNode.Attributes["href"] != null || excel_geometricBMNode.Attributes["id"] != null) 
                {
                    if (excel_geometricBMNode.Attributes["id"] != null) 
                    {
                        excel_geometricBMIDRef_ = excel_geometricBMNode.Attributes["id"].Value;
                        Excel_geometricBM ob = new Excel_geometricBM(excel_geometricBMNode);
                        IDManager.SetID(excel_geometricBMIDRef_, ob);
                    }
                    else if (excel_geometricBMNode.Attributes["href"] != null)
                    {
                        excel_geometricBMIDRef_ = excel_geometricBMNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_geometricBM_ = new Excel_geometricBM(excel_geometricBMNode);
                    }
                }
                else
                {
                    excel_geometricBM_ = new Excel_geometricBM(excel_geometricBMNode);
                }
            }
            
        
            XmlNode excel_hullWhiteOneFactorNode = xmlNode.SelectSingleNode("excel_hullWhiteOneFactor");
            
            if (excel_hullWhiteOneFactorNode != null)
            {
                if (excel_hullWhiteOneFactorNode.Attributes["href"] != null || excel_hullWhiteOneFactorNode.Attributes["id"] != null) 
                {
                    if (excel_hullWhiteOneFactorNode.Attributes["id"] != null) 
                    {
                        excel_hullWhiteOneFactorIDRef_ = excel_hullWhiteOneFactorNode.Attributes["id"].Value;
                        Excel_hullWhiteOneFactor ob = new Excel_hullWhiteOneFactor(excel_hullWhiteOneFactorNode);
                        IDManager.SetID(excel_hullWhiteOneFactorIDRef_, ob);
                    }
                    else if (excel_hullWhiteOneFactorNode.Attributes["href"] != null)
                    {
                        excel_hullWhiteOneFactorIDRef_ = excel_hullWhiteOneFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hullWhiteOneFactor_ = new Excel_hullWhiteOneFactor(excel_hullWhiteOneFactorNode);
                    }
                }
                else
                {
                    excel_hullWhiteOneFactor_ = new Excel_hullWhiteOneFactor(excel_hullWhiteOneFactorNode);
                }
            }
            
        
            XmlNode excel_forwardModelNode = xmlNode.SelectSingleNode("excel_forwardModel");
            
            if (excel_forwardModelNode != null)
            {
                if (excel_forwardModelNode.Attributes["href"] != null || excel_forwardModelNode.Attributes["id"] != null) 
                {
                    if (excel_forwardModelNode.Attributes["id"] != null) 
                    {
                        excel_forwardModelIDRef_ = excel_forwardModelNode.Attributes["id"].Value;
                        Excel_forwardModel ob = new Excel_forwardModel(excel_forwardModelNode);
                        IDManager.SetID(excel_forwardModelIDRef_, ob);
                    }
                    else if (excel_forwardModelNode.Attributes["href"] != null)
                    {
                        excel_forwardModelIDRef_ = excel_forwardModelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_forwardModel_ = new Excel_forwardModel(excel_forwardModelNode);
                    }
                }
                else
                {
                    excel_forwardModel_ = new Excel_forwardModel(excel_forwardModelNode);
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
        #region Excel_geometricBM_
        private Excel_geometricBM excel_geometricBM_;
        public Excel_geometricBM Excel_geometricBM_
        {
            get
            {
                if (this.excel_geometricBM_ != null)
                {
                    return this.excel_geometricBM_; 
                }
                else if (this.excel_geometricBMIDRef_ != null)
                {
                    excel_geometricBM_ = IDManager.getID(excel_geometricBMIDRef_) as Excel_geometricBM;
                    return this.excel_geometricBM_; 
                }
                else
                {
                    throw new Exception( "excel_geometricBM_Node no exist!");
                }
            }
            set
            {
                if (this.excel_geometricBM_ != value)
                {
                    this.excel_geometricBM_ = value;
                }
            }
        }
        #endregion
        
        public string excel_geometricBMIDRef_ { get; set; }
        #region Excel_hullWhiteOneFactor_
        private Excel_hullWhiteOneFactor excel_hullWhiteOneFactor_;
        public Excel_hullWhiteOneFactor Excel_hullWhiteOneFactor_
        {
            get
            {
                if (this.excel_hullWhiteOneFactor_ != null)
                {
                    return this.excel_hullWhiteOneFactor_; 
                }
                else if (this.excel_hullWhiteOneFactorIDRef_ != null)
                {
                    excel_hullWhiteOneFactor_ = IDManager.getID(excel_hullWhiteOneFactorIDRef_) as Excel_hullWhiteOneFactor;
                    return this.excel_hullWhiteOneFactor_; 
                }
                else
                {
                    throw new Exception( "excel_hullWhiteOneFactor_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hullWhiteOneFactor_ != value)
                {
                    this.excel_hullWhiteOneFactor_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hullWhiteOneFactorIDRef_ { get; set; }
        #region Excel_forwardModel_
        private Excel_forwardModel excel_forwardModel_;
        public Excel_forwardModel Excel_forwardModel_
        {
            get
            {
                if (this.excel_forwardModel_ != null)
                {
                    return this.excel_forwardModel_; 
                }
                else if (this.excel_forwardModelIDRef_ != null)
                {
                    excel_forwardModel_ = IDManager.getID(excel_forwardModelIDRef_) as Excel_forwardModel;
                    return this.excel_forwardModel_; 
                }
                else
                {
                    throw new Exception( "excel_forwardModel_Node no exist!");
                }
            }
            set
            {
                if (this.excel_forwardModel_ != value)
                {
                    this.excel_forwardModel_ = value;
                }
            }
        }
        #endregion
        
        public string excel_forwardModelIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

