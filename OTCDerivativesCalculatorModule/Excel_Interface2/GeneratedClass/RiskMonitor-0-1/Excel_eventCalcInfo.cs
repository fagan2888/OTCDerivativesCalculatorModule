using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_eventCalcInfo : ISerialized
    {
        public Excel_eventCalcInfo() { }
        public Excel_eventCalcInfo(XmlNode xmlNode)
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
            
        
            XmlNode excel_singleRangeEventCalNode = xmlNode.SelectSingleNode("excel_singleRangeEventCal");
            
            if (excel_singleRangeEventCalNode != null)
            {
                if (excel_singleRangeEventCalNode.Attributes["href"] != null || excel_singleRangeEventCalNode.Attributes["id"] != null) 
                {
                    if (excel_singleRangeEventCalNode.Attributes["id"] != null) 
                    {
                        excel_singleRangeEventCalIDRef_ = excel_singleRangeEventCalNode.Attributes["id"].Value;
                        Excel_singleRangeEventCal ob = new Excel_singleRangeEventCal(excel_singleRangeEventCalNode);
                        IDManager.SetID(excel_singleRangeEventCalIDRef_, ob);
                    }
                    else if (excel_singleRangeEventCalNode.Attributes["href"] != null)
                    {
                        excel_singleRangeEventCalIDRef_ = excel_singleRangeEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_singleRangeEventCal_ = new Excel_singleRangeEventCal(excel_singleRangeEventCalNode);
                    }
                }
                else
                {
                    excel_singleRangeEventCal_ = new Excel_singleRangeEventCal(excel_singleRangeEventCalNode);
                }
            }
            
        
            XmlNode excel_dualRangeEventCalNode = xmlNode.SelectSingleNode("excel_dualRangeEventCal");
            
            if (excel_dualRangeEventCalNode != null)
            {
                if (excel_dualRangeEventCalNode.Attributes["href"] != null || excel_dualRangeEventCalNode.Attributes["id"] != null) 
                {
                    if (excel_dualRangeEventCalNode.Attributes["id"] != null) 
                    {
                        excel_dualRangeEventCalIDRef_ = excel_dualRangeEventCalNode.Attributes["id"].Value;
                        Excel_dualRangeEventCal ob = new Excel_dualRangeEventCal(excel_dualRangeEventCalNode);
                        IDManager.SetID(excel_dualRangeEventCalIDRef_, ob);
                    }
                    else if (excel_dualRangeEventCalNode.Attributes["href"] != null)
                    {
                        excel_dualRangeEventCalIDRef_ = excel_dualRangeEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_dualRangeEventCal_ = new Excel_dualRangeEventCal(excel_dualRangeEventCalNode);
                    }
                }
                else
                {
                    excel_dualRangeEventCal_ = new Excel_dualRangeEventCal(excel_dualRangeEventCalNode);
                }
            }
            
        
            XmlNode excel_singleBarrierEventCalNode = xmlNode.SelectSingleNode("excel_singleBarrierEventCal");
            
            if (excel_singleBarrierEventCalNode != null)
            {
                if (excel_singleBarrierEventCalNode.Attributes["href"] != null || excel_singleBarrierEventCalNode.Attributes["id"] != null) 
                {
                    if (excel_singleBarrierEventCalNode.Attributes["id"] != null) 
                    {
                        excel_singleBarrierEventCalIDRef_ = excel_singleBarrierEventCalNode.Attributes["id"].Value;
                        Excel_singleBarrierEventCal ob = new Excel_singleBarrierEventCal(excel_singleBarrierEventCalNode);
                        IDManager.SetID(excel_singleBarrierEventCalIDRef_, ob);
                    }
                    else if (excel_singleBarrierEventCalNode.Attributes["href"] != null)
                    {
                        excel_singleBarrierEventCalIDRef_ = excel_singleBarrierEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_singleBarrierEventCal_ = new Excel_singleBarrierEventCal(excel_singleBarrierEventCalNode);
                    }
                }
                else
                {
                    excel_singleBarrierEventCal_ = new Excel_singleBarrierEventCal(excel_singleBarrierEventCalNode);
                }
            }
            
        
            XmlNode excel_dualBarrierEventCalNode = xmlNode.SelectSingleNode("excel_dualBarrierEventCal");
            
            if (excel_dualBarrierEventCalNode != null)
            {
                if (excel_dualBarrierEventCalNode.Attributes["href"] != null || excel_dualBarrierEventCalNode.Attributes["id"] != null) 
                {
                    if (excel_dualBarrierEventCalNode.Attributes["id"] != null) 
                    {
                        excel_dualBarrierEventCalIDRef_ = excel_dualBarrierEventCalNode.Attributes["id"].Value;
                        Excel_dualBarrierEventCal ob = new Excel_dualBarrierEventCal(excel_dualBarrierEventCalNode);
                        IDManager.SetID(excel_dualBarrierEventCalIDRef_, ob);
                    }
                    else if (excel_dualBarrierEventCalNode.Attributes["href"] != null)
                    {
                        excel_dualBarrierEventCalIDRef_ = excel_dualBarrierEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_dualBarrierEventCal_ = new Excel_dualBarrierEventCal(excel_dualBarrierEventCalNode);
                    }
                }
                else
                {
                    excel_dualBarrierEventCal_ = new Excel_dualBarrierEventCal(excel_dualBarrierEventCalNode);
                }
            }
            
        
            XmlNode excel_identityEventCalNode = xmlNode.SelectSingleNode("excel_identityEventCal");
            
            if (excel_identityEventCalNode != null)
            {
                if (excel_identityEventCalNode.Attributes["href"] != null || excel_identityEventCalNode.Attributes["id"] != null) 
                {
                    if (excel_identityEventCalNode.Attributes["id"] != null) 
                    {
                        excel_identityEventCalIDRef_ = excel_identityEventCalNode.Attributes["id"].Value;
                        Excel_identityEventCal ob = new Excel_identityEventCal(excel_identityEventCalNode);
                        IDManager.SetID(excel_identityEventCalIDRef_, ob);
                    }
                    else if (excel_identityEventCalNode.Attributes["href"] != null)
                    {
                        excel_identityEventCalIDRef_ = excel_identityEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_identityEventCal_ = new Excel_identityEventCal(excel_identityEventCalNode);
                    }
                }
                else
                {
                    excel_identityEventCal_ = new Excel_identityEventCal(excel_identityEventCalNode);
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
        #region Excel_singleRangeEventCal_
        private Excel_singleRangeEventCal excel_singleRangeEventCal_;
        public Excel_singleRangeEventCal Excel_singleRangeEventCal_
        {
            get
            {
                if (this.excel_singleRangeEventCal_ != null)
                {
                    return this.excel_singleRangeEventCal_; 
                }
                else if (this.excel_singleRangeEventCalIDRef_ != null)
                {
                    excel_singleRangeEventCal_ = IDManager.getID(excel_singleRangeEventCalIDRef_) as Excel_singleRangeEventCal;
                    return this.excel_singleRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "excel_singleRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_singleRangeEventCal_ != value)
                {
                    this.excel_singleRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_singleRangeEventCalIDRef_ { get; set; }
        #region Excel_dualRangeEventCal_
        private Excel_dualRangeEventCal excel_dualRangeEventCal_;
        public Excel_dualRangeEventCal Excel_dualRangeEventCal_
        {
            get
            {
                if (this.excel_dualRangeEventCal_ != null)
                {
                    return this.excel_dualRangeEventCal_; 
                }
                else if (this.excel_dualRangeEventCalIDRef_ != null)
                {
                    excel_dualRangeEventCal_ = IDManager.getID(excel_dualRangeEventCalIDRef_) as Excel_dualRangeEventCal;
                    return this.excel_dualRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "excel_dualRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_dualRangeEventCal_ != value)
                {
                    this.excel_dualRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_dualRangeEventCalIDRef_ { get; set; }
        #region Excel_singleBarrierEventCal_
        private Excel_singleBarrierEventCal excel_singleBarrierEventCal_;
        public Excel_singleBarrierEventCal Excel_singleBarrierEventCal_
        {
            get
            {
                if (this.excel_singleBarrierEventCal_ != null)
                {
                    return this.excel_singleBarrierEventCal_; 
                }
                else if (this.excel_singleBarrierEventCalIDRef_ != null)
                {
                    excel_singleBarrierEventCal_ = IDManager.getID(excel_singleBarrierEventCalIDRef_) as Excel_singleBarrierEventCal;
                    return this.excel_singleBarrierEventCal_; 
                }
                else
                {
                    throw new Exception( "excel_singleBarrierEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_singleBarrierEventCal_ != value)
                {
                    this.excel_singleBarrierEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_singleBarrierEventCalIDRef_ { get; set; }
        #region Excel_dualBarrierEventCal_
        private Excel_dualBarrierEventCal excel_dualBarrierEventCal_;
        public Excel_dualBarrierEventCal Excel_dualBarrierEventCal_
        {
            get
            {
                if (this.excel_dualBarrierEventCal_ != null)
                {
                    return this.excel_dualBarrierEventCal_; 
                }
                else if (this.excel_dualBarrierEventCalIDRef_ != null)
                {
                    excel_dualBarrierEventCal_ = IDManager.getID(excel_dualBarrierEventCalIDRef_) as Excel_dualBarrierEventCal;
                    return this.excel_dualBarrierEventCal_; 
                }
                else
                {
                    throw new Exception( "excel_dualBarrierEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_dualBarrierEventCal_ != value)
                {
                    this.excel_dualBarrierEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_dualBarrierEventCalIDRef_ { get; set; }
        #region Excel_identityEventCal_
        private Excel_identityEventCal excel_identityEventCal_;
        public Excel_identityEventCal Excel_identityEventCal_
        {
            get
            {
                if (this.excel_identityEventCal_ != null)
                {
                    return this.excel_identityEventCal_; 
                }
                else if (this.excel_identityEventCalIDRef_ != null)
                {
                    excel_identityEventCal_ = IDManager.getID(excel_identityEventCalIDRef_) as Excel_identityEventCal;
                    return this.excel_identityEventCal_; 
                }
                else
                {
                    throw new Exception( "excel_identityEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.excel_identityEventCal_ != value)
                {
                    this.excel_identityEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string excel_identityEventCalIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

