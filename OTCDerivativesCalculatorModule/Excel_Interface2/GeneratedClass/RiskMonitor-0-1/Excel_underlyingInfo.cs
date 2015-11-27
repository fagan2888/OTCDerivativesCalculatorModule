using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingInfo : ISerialized
    {
        public Excel_underlyingInfo() { }
        public Excel_underlyingInfo(XmlNode xmlNode)
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
            
        
            XmlNode excel_stockIndexNode = xmlNode.SelectSingleNode("excel_stockIndex");
            
            if (excel_stockIndexNode != null)
            {
                if (excel_stockIndexNode.Attributes["href"] != null || excel_stockIndexNode.Attributes["id"] != null) 
                {
                    if (excel_stockIndexNode.Attributes["id"] != null) 
                    {
                        excel_stockIndexIDRef_ = excel_stockIndexNode.Attributes["id"].Value;
                        Excel_stockIndex ob = new Excel_stockIndex(excel_stockIndexNode);
                        IDManager.SetID(excel_stockIndexIDRef_, ob);
                    }
                    else if (excel_stockIndexNode.Attributes["href"] != null)
                    {
                        excel_stockIndexIDRef_ = excel_stockIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_stockIndex_ = new Excel_stockIndex(excel_stockIndexNode);
                    }
                }
                else
                {
                    excel_stockIndex_ = new Excel_stockIndex(excel_stockIndexNode);
                }
            }
            
        
            XmlNode excel_interestRateNode = xmlNode.SelectSingleNode("excel_interestRate");
            
            if (excel_interestRateNode != null)
            {
                if (excel_interestRateNode.Attributes["href"] != null || excel_interestRateNode.Attributes["id"] != null) 
                {
                    if (excel_interestRateNode.Attributes["id"] != null) 
                    {
                        excel_interestRateIDRef_ = excel_interestRateNode.Attributes["id"].Value;
                        Excel_interestRate ob = new Excel_interestRate(excel_interestRateNode);
                        IDManager.SetID(excel_interestRateIDRef_, ob);
                    }
                    else if (excel_interestRateNode.Attributes["href"] != null)
                    {
                        excel_interestRateIDRef_ = excel_interestRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_interestRate_ = new Excel_interestRate(excel_interestRateNode);
                    }
                }
                else
                {
                    excel_interestRate_ = new Excel_interestRate(excel_interestRateNode);
                }
            }
            
        
            XmlNode excel_indexTypeNode = xmlNode.SelectSingleNode("excel_indexType");
            
            if (excel_indexTypeNode != null)
            {
                if (excel_indexTypeNode.Attributes["href"] != null || excel_indexTypeNode.Attributes["id"] != null) 
                {
                    if (excel_indexTypeNode.Attributes["id"] != null) 
                    {
                        excel_indexTypeIDRef_ = excel_indexTypeNode.Attributes["id"].Value;
                        Excel_indexType ob = new Excel_indexType(excel_indexTypeNode);
                        IDManager.SetID(excel_indexTypeIDRef_, ob);
                    }
                    else if (excel_indexTypeNode.Attributes["href"] != null)
                    {
                        excel_indexTypeIDRef_ = excel_indexTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_indexType_ = new Excel_indexType(excel_indexTypeNode);
                    }
                }
                else
                {
                    excel_indexType_ = new Excel_indexType(excel_indexTypeNode);
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
        #region Excel_stockIndex_
        private Excel_stockIndex excel_stockIndex_;
        public Excel_stockIndex Excel_stockIndex_
        {
            get
            {
                if (this.excel_stockIndex_ != null)
                {
                    return this.excel_stockIndex_; 
                }
                else if (this.excel_stockIndexIDRef_ != null)
                {
                    excel_stockIndex_ = IDManager.getID(excel_stockIndexIDRef_) as Excel_stockIndex;
                    return this.excel_stockIndex_; 
                }
                else
                {
                    throw new Exception( "excel_stockIndex_Node no exist!");
                }
            }
            set
            {
                if (this.excel_stockIndex_ != value)
                {
                    this.excel_stockIndex_ = value;
                }
            }
        }
        #endregion
        
        public string excel_stockIndexIDRef_ { get; set; }
        #region Excel_interestRate_
        private Excel_interestRate excel_interestRate_;
        public Excel_interestRate Excel_interestRate_
        {
            get
            {
                if (this.excel_interestRate_ != null)
                {
                    return this.excel_interestRate_; 
                }
                else if (this.excel_interestRateIDRef_ != null)
                {
                    excel_interestRate_ = IDManager.getID(excel_interestRateIDRef_) as Excel_interestRate;
                    return this.excel_interestRate_; 
                }
                else
                {
                    throw new Exception( "excel_interestRate_Node no exist!");
                }
            }
            set
            {
                if (this.excel_interestRate_ != value)
                {
                    this.excel_interestRate_ = value;
                }
            }
        }
        #endregion
        
        public string excel_interestRateIDRef_ { get; set; }
        #region Excel_indexType_
        private Excel_indexType excel_indexType_;
        public Excel_indexType Excel_indexType_
        {
            get
            {
                if (this.excel_indexType_ != null)
                {
                    return this.excel_indexType_; 
                }
                else if (this.excel_indexTypeIDRef_ != null)
                {
                    excel_indexType_ = IDManager.getID(excel_indexTypeIDRef_) as Excel_indexType;
                    return this.excel_indexType_; 
                }
                else
                {
                    throw new Exception( "excel_indexType_Node no exist!");
                }
            }
            set
            {
                if (this.excel_indexType_ != value)
                {
                    this.excel_indexType_ = value;
                }
            }
        }
        #endregion
        
        public string excel_indexTypeIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

