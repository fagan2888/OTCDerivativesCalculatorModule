using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_swapLeg : ISerialized
    {
        public Excel_swapLeg() { }
        public Excel_swapLeg(XmlNode xmlNode)
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
            
        
            XmlNode excel_fixedRateSwapLegNode = xmlNode.SelectSingleNode("excel_fixedRateSwapLeg");
            
            if (excel_fixedRateSwapLegNode != null)
            {
                if (excel_fixedRateSwapLegNode.Attributes["href"] != null || excel_fixedRateSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_fixedRateSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_fixedRateSwapLegIDRef_ = excel_fixedRateSwapLegNode.Attributes["id"].Value;
                        Excel_fixedRateSwapLeg ob = new Excel_fixedRateSwapLeg(excel_fixedRateSwapLegNode);
                        IDManager.SetID(excel_fixedRateSwapLegIDRef_, ob);
                    }
                    else if (excel_fixedRateSwapLegNode.Attributes["href"] != null)
                    {
                        excel_fixedRateSwapLegIDRef_ = excel_fixedRateSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedRateSwapLeg_ = new Excel_fixedRateSwapLeg(excel_fixedRateSwapLegNode);
                    }
                }
                else
                {
                    excel_fixedRateSwapLeg_ = new Excel_fixedRateSwapLeg(excel_fixedRateSwapLegNode);
                }
            }
            
        
            XmlNode excel_vanillaFloatingRateSwapLegNode = xmlNode.SelectSingleNode("excel_vanillaFloatingRateSwapLeg");
            
            if (excel_vanillaFloatingRateSwapLegNode != null)
            {
                if (excel_vanillaFloatingRateSwapLegNode.Attributes["href"] != null || excel_vanillaFloatingRateSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingRateSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingRateSwapLegIDRef_ = excel_vanillaFloatingRateSwapLegNode.Attributes["id"].Value;
                        Excel_vanillaFloatingRateSwapLeg ob = new Excel_vanillaFloatingRateSwapLeg(excel_vanillaFloatingRateSwapLegNode);
                        IDManager.SetID(excel_vanillaFloatingRateSwapLegIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingRateSwapLegNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingRateSwapLegIDRef_ = excel_vanillaFloatingRateSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingRateSwapLeg_ = new Excel_vanillaFloatingRateSwapLeg(excel_vanillaFloatingRateSwapLegNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingRateSwapLeg_ = new Excel_vanillaFloatingRateSwapLeg(excel_vanillaFloatingRateSwapLegNode);
                }
            }
            
        
            XmlNode excel_structuredRateSwapLegNode = xmlNode.SelectSingleNode("excel_structuredRateSwapLeg");
            
            if (excel_structuredRateSwapLegNode != null)
            {
                if (excel_structuredRateSwapLegNode.Attributes["href"] != null || excel_structuredRateSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_structuredRateSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_structuredRateSwapLegIDRef_ = excel_structuredRateSwapLegNode.Attributes["id"].Value;
                        Excel_structuredRateSwapLeg ob = new Excel_structuredRateSwapLeg(excel_structuredRateSwapLegNode);
                        IDManager.SetID(excel_structuredRateSwapLegIDRef_, ob);
                    }
                    else if (excel_structuredRateSwapLegNode.Attributes["href"] != null)
                    {
                        excel_structuredRateSwapLegIDRef_ = excel_structuredRateSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_structuredRateSwapLeg_ = new Excel_structuredRateSwapLeg(excel_structuredRateSwapLegNode);
                    }
                }
                else
                {
                    excel_structuredRateSwapLeg_ = new Excel_structuredRateSwapLeg(excel_structuredRateSwapLegNode);
                }
            }
            
        
            XmlNode excel_creditEventSwapLegNode = xmlNode.SelectSingleNode("excel_creditEventSwapLeg");
            
            if (excel_creditEventSwapLegNode != null)
            {
                if (excel_creditEventSwapLegNode.Attributes["href"] != null || excel_creditEventSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_creditEventSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_creditEventSwapLegIDRef_ = excel_creditEventSwapLegNode.Attributes["id"].Value;
                        Excel_creditEventSwapLeg ob = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                        IDManager.SetID(excel_creditEventSwapLegIDRef_, ob);
                    }
                    else if (excel_creditEventSwapLegNode.Attributes["href"] != null)
                    {
                        excel_creditEventSwapLegIDRef_ = excel_creditEventSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_creditEventSwapLeg_ = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                    }
                }
                else
                {
                    excel_creditEventSwapLeg_ = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                }
            }
            
        
            XmlNode excel_hifiveSwapLegNode = xmlNode.SelectSingleNode("excel_hifiveSwapLeg");
            
            if (excel_hifiveSwapLegNode != null)
            {
                if (excel_hifiveSwapLegNode.Attributes["href"] != null || excel_hifiveSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_hifiveSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_hifiveSwapLegIDRef_ = excel_hifiveSwapLegNode.Attributes["id"].Value;
                        Excel_hifiveSwapLeg ob = new Excel_hifiveSwapLeg(excel_hifiveSwapLegNode);
                        IDManager.SetID(excel_hifiveSwapLegIDRef_, ob);
                    }
                    else if (excel_hifiveSwapLegNode.Attributes["href"] != null)
                    {
                        excel_hifiveSwapLegIDRef_ = excel_hifiveSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hifiveSwapLeg_ = new Excel_hifiveSwapLeg(excel_hifiveSwapLegNode);
                    }
                }
                else
                {
                    excel_hifiveSwapLeg_ = new Excel_hifiveSwapLeg(excel_hifiveSwapLegNode);
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
        #region Excel_fixedRateSwapLeg_
        private Excel_fixedRateSwapLeg excel_fixedRateSwapLeg_;
        public Excel_fixedRateSwapLeg Excel_fixedRateSwapLeg_
        {
            get
            {
                if (this.excel_fixedRateSwapLeg_ != null)
                {
                    return this.excel_fixedRateSwapLeg_; 
                }
                else if (this.excel_fixedRateSwapLegIDRef_ != null)
                {
                    excel_fixedRateSwapLeg_ = IDManager.getID(excel_fixedRateSwapLegIDRef_) as Excel_fixedRateSwapLeg;
                    return this.excel_fixedRateSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_fixedRateSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedRateSwapLeg_ != value)
                {
                    this.excel_fixedRateSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedRateSwapLegIDRef_ { get; set; }
        #region Excel_vanillaFloatingRateSwapLeg_
        private Excel_vanillaFloatingRateSwapLeg excel_vanillaFloatingRateSwapLeg_;
        public Excel_vanillaFloatingRateSwapLeg Excel_vanillaFloatingRateSwapLeg_
        {
            get
            {
                if (this.excel_vanillaFloatingRateSwapLeg_ != null)
                {
                    return this.excel_vanillaFloatingRateSwapLeg_; 
                }
                else if (this.excel_vanillaFloatingRateSwapLegIDRef_ != null)
                {
                    excel_vanillaFloatingRateSwapLeg_ = IDManager.getID(excel_vanillaFloatingRateSwapLegIDRef_) as Excel_vanillaFloatingRateSwapLeg;
                    return this.excel_vanillaFloatingRateSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingRateSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingRateSwapLeg_ != value)
                {
                    this.excel_vanillaFloatingRateSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingRateSwapLegIDRef_ { get; set; }
        #region Excel_structuredRateSwapLeg_
        private Excel_structuredRateSwapLeg excel_structuredRateSwapLeg_;
        public Excel_structuredRateSwapLeg Excel_structuredRateSwapLeg_
        {
            get
            {
                if (this.excel_structuredRateSwapLeg_ != null)
                {
                    return this.excel_structuredRateSwapLeg_; 
                }
                else if (this.excel_structuredRateSwapLegIDRef_ != null)
                {
                    excel_structuredRateSwapLeg_ = IDManager.getID(excel_structuredRateSwapLegIDRef_) as Excel_structuredRateSwapLeg;
                    return this.excel_structuredRateSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_structuredRateSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_structuredRateSwapLeg_ != value)
                {
                    this.excel_structuredRateSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_structuredRateSwapLegIDRef_ { get; set; }
        #region Excel_creditEventSwapLeg_
        private Excel_creditEventSwapLeg excel_creditEventSwapLeg_;
        public Excel_creditEventSwapLeg Excel_creditEventSwapLeg_
        {
            get
            {
                if (this.excel_creditEventSwapLeg_ != null)
                {
                    return this.excel_creditEventSwapLeg_; 
                }
                else if (this.excel_creditEventSwapLegIDRef_ != null)
                {
                    excel_creditEventSwapLeg_ = IDManager.getID(excel_creditEventSwapLegIDRef_) as Excel_creditEventSwapLeg;
                    return this.excel_creditEventSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_creditEventSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_creditEventSwapLeg_ != value)
                {
                    this.excel_creditEventSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_creditEventSwapLegIDRef_ { get; set; }
        #region Excel_hifiveSwapLeg_
        private Excel_hifiveSwapLeg excel_hifiveSwapLeg_;
        public Excel_hifiveSwapLeg Excel_hifiveSwapLeg_
        {
            get
            {
                if (this.excel_hifiveSwapLeg_ != null)
                {
                    return this.excel_hifiveSwapLeg_; 
                }
                else if (this.excel_hifiveSwapLegIDRef_ != null)
                {
                    excel_hifiveSwapLeg_ = IDManager.getID(excel_hifiveSwapLegIDRef_) as Excel_hifiveSwapLeg;
                    return this.excel_hifiveSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_hifiveSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hifiveSwapLeg_ != value)
                {
                    this.excel_hifiveSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hifiveSwapLegIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

