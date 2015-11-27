using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_parameter : ISerialized
    {
        public Excel_parameter() { }
        public Excel_parameter(XmlNode xmlNode)
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
            
        
            XmlNode excel_resultNode = xmlNode.SelectSingleNode("excel_result");
            
            if (excel_resultNode != null)
            {
                if (excel_resultNode.Attributes["href"] != null || excel_resultNode.Attributes["id"] != null) 
                {
                    if (excel_resultNode.Attributes["id"] != null) 
                    {
                        excel_resultIDRef_ = excel_resultNode.Attributes["id"].Value;
                        Excel_result ob = new Excel_result(excel_resultNode);
                        IDManager.SetID(excel_resultIDRef_, ob);
                    }
                    else if (excel_resultNode.Attributes["href"] != null)
                    {
                        excel_resultIDRef_ = excel_resultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_result_ = new Excel_result(excel_resultNode);
                    }
                }
                else
                {
                    excel_result_ = new Excel_result(excel_resultNode);
                }
            }
            
        
            XmlNode excel_standardParaNode = xmlNode.SelectSingleNode("excel_standardPara");
            
            if (excel_standardParaNode != null)
            {
                if (excel_standardParaNode.Attributes["href"] != null || excel_standardParaNode.Attributes["id"] != null) 
                {
                    if (excel_standardParaNode.Attributes["id"] != null) 
                    {
                        excel_standardParaIDRef_ = excel_standardParaNode.Attributes["id"].Value;
                        Excel_standardPara ob = new Excel_standardPara(excel_standardParaNode);
                        IDManager.SetID(excel_standardParaIDRef_, ob);
                    }
                    else if (excel_standardParaNode.Attributes["href"] != null)
                    {
                        excel_standardParaIDRef_ = excel_standardParaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_standardPara_ = new Excel_standardPara(excel_standardParaNode);
                    }
                }
                else
                {
                    excel_standardPara_ = new Excel_standardPara(excel_standardParaNode);
                }
            }
            
        
            XmlNode excel_standardSwapParaNode = xmlNode.SelectSingleNode("excel_standardSwapPara");
            
            if (excel_standardSwapParaNode != null)
            {
                if (excel_standardSwapParaNode.Attributes["href"] != null || excel_standardSwapParaNode.Attributes["id"] != null) 
                {
                    if (excel_standardSwapParaNode.Attributes["id"] != null) 
                    {
                        excel_standardSwapParaIDRef_ = excel_standardSwapParaNode.Attributes["id"].Value;
                        Excel_standardSwapPara ob = new Excel_standardSwapPara(excel_standardSwapParaNode);
                        IDManager.SetID(excel_standardSwapParaIDRef_, ob);
                    }
                    else if (excel_standardSwapParaNode.Attributes["href"] != null)
                    {
                        excel_standardSwapParaIDRef_ = excel_standardSwapParaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_standardSwapPara_ = new Excel_standardSwapPara(excel_standardSwapParaNode);
                    }
                }
                else
                {
                    excel_standardSwapPara_ = new Excel_standardSwapPara(excel_standardSwapParaNode);
                }
            }
            
        
            XmlNode excel_standardHifiveParaNode = xmlNode.SelectSingleNode("excel_standardHifivePara");
            
            if (excel_standardHifiveParaNode != null)
            {
                if (excel_standardHifiveParaNode.Attributes["href"] != null || excel_standardHifiveParaNode.Attributes["id"] != null) 
                {
                    if (excel_standardHifiveParaNode.Attributes["id"] != null) 
                    {
                        excel_standardHifiveParaIDRef_ = excel_standardHifiveParaNode.Attributes["id"].Value;
                        Excel_standardHifivePara ob = new Excel_standardHifivePara(excel_standardHifiveParaNode);
                        IDManager.SetID(excel_standardHifiveParaIDRef_, ob);
                    }
                    else if (excel_standardHifiveParaNode.Attributes["href"] != null)
                    {
                        excel_standardHifiveParaIDRef_ = excel_standardHifiveParaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_standardHifivePara_ = new Excel_standardHifivePara(excel_standardHifiveParaNode);
                    }
                }
                else
                {
                    excel_standardHifivePara_ = new Excel_standardHifivePara(excel_standardHifiveParaNode);
                }
            }
            
        
            XmlNode excel_standardCreditParaNode = xmlNode.SelectSingleNode("excel_standardCreditPara");
            
            if (excel_standardCreditParaNode != null)
            {
                if (excel_standardCreditParaNode.Attributes["href"] != null || excel_standardCreditParaNode.Attributes["id"] != null) 
                {
                    if (excel_standardCreditParaNode.Attributes["id"] != null) 
                    {
                        excel_standardCreditParaIDRef_ = excel_standardCreditParaNode.Attributes["id"].Value;
                        Excel_standardCreditPara ob = new Excel_standardCreditPara(excel_standardCreditParaNode);
                        IDManager.SetID(excel_standardCreditParaIDRef_, ob);
                    }
                    else if (excel_standardCreditParaNode.Attributes["href"] != null)
                    {
                        excel_standardCreditParaIDRef_ = excel_standardCreditParaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_standardCreditPara_ = new Excel_standardCreditPara(excel_standardCreditParaNode);
                    }
                }
                else
                {
                    excel_standardCreditPara_ = new Excel_standardCreditPara(excel_standardCreditParaNode);
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
        #region Excel_result_
        private Excel_result excel_result_;
        public Excel_result Excel_result_
        {
            get
            {
                if (this.excel_result_ != null)
                {
                    return this.excel_result_; 
                }
                else if (this.excel_resultIDRef_ != null)
                {
                    excel_result_ = IDManager.getID(excel_resultIDRef_) as Excel_result;
                    return this.excel_result_; 
                }
                else
                {
                    throw new Exception( "excel_result_Node no exist!");
                }
            }
            set
            {
                if (this.excel_result_ != value)
                {
                    this.excel_result_ = value;
                }
            }
        }
        #endregion
        
        public string excel_resultIDRef_ { get; set; }
        #region Excel_standardPara_
        private Excel_standardPara excel_standardPara_;
        public Excel_standardPara Excel_standardPara_
        {
            get
            {
                if (this.excel_standardPara_ != null)
                {
                    return this.excel_standardPara_; 
                }
                else if (this.excel_standardParaIDRef_ != null)
                {
                    excel_standardPara_ = IDManager.getID(excel_standardParaIDRef_) as Excel_standardPara;
                    return this.excel_standardPara_; 
                }
                else
                {
                    throw new Exception( "excel_standardPara_Node no exist!");
                }
            }
            set
            {
                if (this.excel_standardPara_ != value)
                {
                    this.excel_standardPara_ = value;
                }
            }
        }
        #endregion
        
        public string excel_standardParaIDRef_ { get; set; }
        #region Excel_standardSwapPara_
        private Excel_standardSwapPara excel_standardSwapPara_;
        public Excel_standardSwapPara Excel_standardSwapPara_
        {
            get
            {
                if (this.excel_standardSwapPara_ != null)
                {
                    return this.excel_standardSwapPara_; 
                }
                else if (this.excel_standardSwapParaIDRef_ != null)
                {
                    excel_standardSwapPara_ = IDManager.getID(excel_standardSwapParaIDRef_) as Excel_standardSwapPara;
                    return this.excel_standardSwapPara_; 
                }
                else
                {
                    throw new Exception( "excel_standardSwapPara_Node no exist!");
                }
            }
            set
            {
                if (this.excel_standardSwapPara_ != value)
                {
                    this.excel_standardSwapPara_ = value;
                }
            }
        }
        #endregion
        
        public string excel_standardSwapParaIDRef_ { get; set; }
        #region Excel_standardHifivePara_
        private Excel_standardHifivePara excel_standardHifivePara_;
        public Excel_standardHifivePara Excel_standardHifivePara_
        {
            get
            {
                if (this.excel_standardHifivePara_ != null)
                {
                    return this.excel_standardHifivePara_; 
                }
                else if (this.excel_standardHifiveParaIDRef_ != null)
                {
                    excel_standardHifivePara_ = IDManager.getID(excel_standardHifiveParaIDRef_) as Excel_standardHifivePara;
                    return this.excel_standardHifivePara_; 
                }
                else
                {
                    throw new Exception( "excel_standardHifivePara_Node no exist!");
                }
            }
            set
            {
                if (this.excel_standardHifivePara_ != value)
                {
                    this.excel_standardHifivePara_ = value;
                }
            }
        }
        #endregion
        
        public string excel_standardHifiveParaIDRef_ { get; set; }
        #region Excel_standardCreditPara_
        private Excel_standardCreditPara excel_standardCreditPara_;
        public Excel_standardCreditPara Excel_standardCreditPara_
        {
            get
            {
                if (this.excel_standardCreditPara_ != null)
                {
                    return this.excel_standardCreditPara_; 
                }
                else if (this.excel_standardCreditParaIDRef_ != null)
                {
                    excel_standardCreditPara_ = IDManager.getID(excel_standardCreditParaIDRef_) as Excel_standardCreditPara;
                    return this.excel_standardCreditPara_; 
                }
                else
                {
                    throw new Exception( "excel_standardCreditPara_Node no exist!");
                }
            }
            set
            {
                if (this.excel_standardCreditPara_ != value)
                {
                    this.excel_standardCreditPara_ = value;
                }
            }
        }
        #endregion
        
        public string excel_standardCreditParaIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

