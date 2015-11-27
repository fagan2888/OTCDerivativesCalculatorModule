using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_issueInfo : ISerialized
    {
        public Excel_issueInfo() { }
        public Excel_issueInfo(XmlNode xmlNode)
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
            
        
            XmlNode excel_noteInfoNode = xmlNode.SelectSingleNode("excel_noteInfo");
            
            if (excel_noteInfoNode != null)
            {
                if (excel_noteInfoNode.Attributes["href"] != null || excel_noteInfoNode.Attributes["id"] != null) 
                {
                    if (excel_noteInfoNode.Attributes["id"] != null) 
                    {
                        excel_noteInfoIDRef_ = excel_noteInfoNode.Attributes["id"].Value;
                        Excel_noteInfo ob = new Excel_noteInfo(excel_noteInfoNode);
                        IDManager.SetID(excel_noteInfoIDRef_, ob);
                    }
                    else if (excel_noteInfoNode.Attributes["href"] != null)
                    {
                        excel_noteInfoIDRef_ = excel_noteInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_noteInfo_ = new Excel_noteInfo(excel_noteInfoNode);
                    }
                }
                else
                {
                    excel_noteInfo_ = new Excel_noteInfo(excel_noteInfoNode);
                }
            }
            
        
            XmlNode excel_swapInfoNode = xmlNode.SelectSingleNode("excel_swapInfo");
            
            if (excel_swapInfoNode != null)
            {
                if (excel_swapInfoNode.Attributes["href"] != null || excel_swapInfoNode.Attributes["id"] != null) 
                {
                    if (excel_swapInfoNode.Attributes["id"] != null) 
                    {
                        excel_swapInfoIDRef_ = excel_swapInfoNode.Attributes["id"].Value;
                        Excel_swapInfo ob = new Excel_swapInfo(excel_swapInfoNode);
                        IDManager.SetID(excel_swapInfoIDRef_, ob);
                    }
                    else if (excel_swapInfoNode.Attributes["href"] != null)
                    {
                        excel_swapInfoIDRef_ = excel_swapInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_swapInfo_ = new Excel_swapInfo(excel_swapInfoNode);
                    }
                }
                else
                {
                    excel_swapInfo_ = new Excel_swapInfo(excel_swapInfoNode);
                }
            }
            
        
            XmlNode excel_swapLegInfoNode = xmlNode.SelectSingleNode("excel_swapLegInfo");
            
            if (excel_swapLegInfoNode != null)
            {
                if (excel_swapLegInfoNode.Attributes["href"] != null || excel_swapLegInfoNode.Attributes["id"] != null) 
                {
                    if (excel_swapLegInfoNode.Attributes["id"] != null) 
                    {
                        excel_swapLegInfoIDRef_ = excel_swapLegInfoNode.Attributes["id"].Value;
                        Excel_swapLegInfo ob = new Excel_swapLegInfo(excel_swapLegInfoNode);
                        IDManager.SetID(excel_swapLegInfoIDRef_, ob);
                    }
                    else if (excel_swapLegInfoNode.Attributes["href"] != null)
                    {
                        excel_swapLegInfoIDRef_ = excel_swapLegInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_swapLegInfo_ = new Excel_swapLegInfo(excel_swapLegInfoNode);
                    }
                }
                else
                {
                    excel_swapLegInfo_ = new Excel_swapLegInfo(excel_swapLegInfoNode);
                }
            }
            
        
            XmlNode excel_emptyInfoNode = xmlNode.SelectSingleNode("excel_emptyInfo");
            
            if (excel_emptyInfoNode != null)
            {
                if (excel_emptyInfoNode.Attributes["href"] != null || excel_emptyInfoNode.Attributes["id"] != null) 
                {
                    if (excel_emptyInfoNode.Attributes["id"] != null) 
                    {
                        excel_emptyInfoIDRef_ = excel_emptyInfoNode.Attributes["id"].Value;
                        Excel_emptyInfo ob = new Excel_emptyInfo(excel_emptyInfoNode);
                        IDManager.SetID(excel_emptyInfoIDRef_, ob);
                    }
                    else if (excel_emptyInfoNode.Attributes["href"] != null)
                    {
                        excel_emptyInfoIDRef_ = excel_emptyInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_emptyInfo_ = new Excel_emptyInfo(excel_emptyInfoNode);
                    }
                }
                else
                {
                    excel_emptyInfo_ = new Excel_emptyInfo(excel_emptyInfoNode);
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
        #region Excel_noteInfo_
        private Excel_noteInfo excel_noteInfo_;
        public Excel_noteInfo Excel_noteInfo_
        {
            get
            {
                if (this.excel_noteInfo_ != null)
                {
                    return this.excel_noteInfo_; 
                }
                else if (this.excel_noteInfoIDRef_ != null)
                {
                    excel_noteInfo_ = IDManager.getID(excel_noteInfoIDRef_) as Excel_noteInfo;
                    return this.excel_noteInfo_; 
                }
                else
                {
                    throw new Exception( "excel_noteInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_noteInfo_ != value)
                {
                    this.excel_noteInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_noteInfoIDRef_ { get; set; }
        #region Excel_swapInfo_
        private Excel_swapInfo excel_swapInfo_;
        public Excel_swapInfo Excel_swapInfo_
        {
            get
            {
                if (this.excel_swapInfo_ != null)
                {
                    return this.excel_swapInfo_; 
                }
                else if (this.excel_swapInfoIDRef_ != null)
                {
                    excel_swapInfo_ = IDManager.getID(excel_swapInfoIDRef_) as Excel_swapInfo;
                    return this.excel_swapInfo_; 
                }
                else
                {
                    throw new Exception( "excel_swapInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapInfo_ != value)
                {
                    this.excel_swapInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapInfoIDRef_ { get; set; }
        #region Excel_swapLegInfo_
        private Excel_swapLegInfo excel_swapLegInfo_;
        public Excel_swapLegInfo Excel_swapLegInfo_
        {
            get
            {
                if (this.excel_swapLegInfo_ != null)
                {
                    return this.excel_swapLegInfo_; 
                }
                else if (this.excel_swapLegInfoIDRef_ != null)
                {
                    excel_swapLegInfo_ = IDManager.getID(excel_swapLegInfoIDRef_) as Excel_swapLegInfo;
                    return this.excel_swapLegInfo_; 
                }
                else
                {
                    throw new Exception( "excel_swapLegInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapLegInfo_ != value)
                {
                    this.excel_swapLegInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapLegInfoIDRef_ { get; set; }
        #region Excel_emptyInfo_
        private Excel_emptyInfo excel_emptyInfo_;
        public Excel_emptyInfo Excel_emptyInfo_
        {
            get
            {
                if (this.excel_emptyInfo_ != null)
                {
                    return this.excel_emptyInfo_; 
                }
                else if (this.excel_emptyInfoIDRef_ != null)
                {
                    excel_emptyInfo_ = IDManager.getID(excel_emptyInfoIDRef_) as Excel_emptyInfo;
                    return this.excel_emptyInfo_; 
                }
                else
                {
                    throw new Exception( "excel_emptyInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_emptyInfo_ != value)
                {
                    this.excel_emptyInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_emptyInfoIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

