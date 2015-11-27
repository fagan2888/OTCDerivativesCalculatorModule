using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_couponSchedule : ISerialized
    {
        public Excel_couponSchedule() { }
        public Excel_couponSchedule(XmlNode xmlNode)
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
            
        
            XmlNode excel_additionalOptionNode = xmlNode.SelectSingleNode("excel_additionalOption");
            
            if (excel_additionalOptionNode != null)
            {
                if (excel_additionalOptionNode.Attributes["href"] != null || excel_additionalOptionNode.Attributes["id"] != null) 
                {
                    if (excel_additionalOptionNode.Attributes["id"] != null) 
                    {
                        excel_additionalOptionIDRef_ = excel_additionalOptionNode.Attributes["id"].Value;
                        Excel_additionalOption ob = new Excel_additionalOption(excel_additionalOptionNode);
                        IDManager.SetID(excel_additionalOptionIDRef_, ob);
                    }
                    else if (excel_additionalOptionNode.Attributes["href"] != null)
                    {
                        excel_additionalOptionIDRef_ = excel_additionalOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_additionalOption_ = new Excel_additionalOption(excel_additionalOptionNode);
                    }
                }
                else
                {
                    excel_additionalOption_ = new Excel_additionalOption(excel_additionalOptionNode);
                }
            }
            
        
            XmlNode excel_fixedCouponScheduleNode = xmlNode.SelectSingleNode("excel_fixedCouponSchedule");
            
            if (excel_fixedCouponScheduleNode != null)
            {
                if (excel_fixedCouponScheduleNode.Attributes["href"] != null || excel_fixedCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_fixedCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_fixedCouponScheduleIDRef_ = excel_fixedCouponScheduleNode.Attributes["id"].Value;
                        Excel_fixedCouponSchedule ob = new Excel_fixedCouponSchedule(excel_fixedCouponScheduleNode);
                        IDManager.SetID(excel_fixedCouponScheduleIDRef_, ob);
                    }
                    else if (excel_fixedCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_fixedCouponScheduleIDRef_ = excel_fixedCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_fixedCouponSchedule_ = new Excel_fixedCouponSchedule(excel_fixedCouponScheduleNode);
                    }
                }
                else
                {
                    excel_fixedCouponSchedule_ = new Excel_fixedCouponSchedule(excel_fixedCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_vanillaFloatingCouponScheduleNode = xmlNode.SelectSingleNode("excel_vanillaFloatingCouponSchedule");
            
            if (excel_vanillaFloatingCouponScheduleNode != null)
            {
                if (excel_vanillaFloatingCouponScheduleNode.Attributes["href"] != null || excel_vanillaFloatingCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaFloatingCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_vanillaFloatingCouponScheduleIDRef_ = excel_vanillaFloatingCouponScheduleNode.Attributes["id"].Value;
                        Excel_vanillaFloatingCouponSchedule ob = new Excel_vanillaFloatingCouponSchedule(excel_vanillaFloatingCouponScheduleNode);
                        IDManager.SetID(excel_vanillaFloatingCouponScheduleIDRef_, ob);
                    }
                    else if (excel_vanillaFloatingCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_vanillaFloatingCouponScheduleIDRef_ = excel_vanillaFloatingCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaFloatingCouponSchedule_ = new Excel_vanillaFloatingCouponSchedule(excel_vanillaFloatingCouponScheduleNode);
                    }
                }
                else
                {
                    excel_vanillaFloatingCouponSchedule_ = new Excel_vanillaFloatingCouponSchedule(excel_vanillaFloatingCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_floatingCouponScheduleNode = xmlNode.SelectSingleNode("excel_floatingCouponSchedule");
            
            if (excel_floatingCouponScheduleNode != null)
            {
                if (excel_floatingCouponScheduleNode.Attributes["href"] != null || excel_floatingCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_floatingCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_floatingCouponScheduleIDRef_ = excel_floatingCouponScheduleNode.Attributes["id"].Value;
                        Excel_floatingCouponSchedule ob = new Excel_floatingCouponSchedule(excel_floatingCouponScheduleNode);
                        IDManager.SetID(excel_floatingCouponScheduleIDRef_, ob);
                    }
                    else if (excel_floatingCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_floatingCouponScheduleIDRef_ = excel_floatingCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_floatingCouponSchedule_ = new Excel_floatingCouponSchedule(excel_floatingCouponScheduleNode);
                    }
                }
                else
                {
                    excel_floatingCouponSchedule_ = new Excel_floatingCouponSchedule(excel_floatingCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_condi_structuredCouponScheduleNode = xmlNode.SelectSingleNode("excel_condi_structuredCouponSchedule");
            
            if (excel_condi_structuredCouponScheduleNode != null)
            {
                if (excel_condi_structuredCouponScheduleNode.Attributes["href"] != null || excel_condi_structuredCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_condi_structuredCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_condi_structuredCouponScheduleIDRef_ = excel_condi_structuredCouponScheduleNode.Attributes["id"].Value;
                        Excel_condi_structuredCouponSchedule ob = new Excel_condi_structuredCouponSchedule(excel_condi_structuredCouponScheduleNode);
                        IDManager.SetID(excel_condi_structuredCouponScheduleIDRef_, ob);
                    }
                    else if (excel_condi_structuredCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_condi_structuredCouponScheduleIDRef_ = excel_condi_structuredCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_condi_structuredCouponSchedule_ = new Excel_condi_structuredCouponSchedule(excel_condi_structuredCouponScheduleNode);
                    }
                }
                else
                {
                    excel_condi_structuredCouponSchedule_ = new Excel_condi_structuredCouponSchedule(excel_condi_structuredCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_condi_structuredAccrualCouponScheduleNode = xmlNode.SelectSingleNode("excel_condi_structuredAccrualCouponSchedule");
            
            if (excel_condi_structuredAccrualCouponScheduleNode != null)
            {
                if (excel_condi_structuredAccrualCouponScheduleNode.Attributes["href"] != null || excel_condi_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_condi_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_condi_structuredAccrualCouponScheduleIDRef_ = excel_condi_structuredAccrualCouponScheduleNode.Attributes["id"].Value;
                        Excel_condi_structuredAccrualCouponSchedule ob = new Excel_condi_structuredAccrualCouponSchedule(excel_condi_structuredAccrualCouponScheduleNode);
                        IDManager.SetID(excel_condi_structuredAccrualCouponScheduleIDRef_, ob);
                    }
                    else if (excel_condi_structuredAccrualCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_condi_structuredAccrualCouponScheduleIDRef_ = excel_condi_structuredAccrualCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_condi_structuredAccrualCouponSchedule_ = new Excel_condi_structuredAccrualCouponSchedule(excel_condi_structuredAccrualCouponScheduleNode);
                    }
                }
                else
                {
                    excel_condi_structuredAccrualCouponSchedule_ = new Excel_condi_structuredAccrualCouponSchedule(excel_condi_structuredAccrualCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_multiCondi_structuredCouponScheduleNode = xmlNode.SelectSingleNode("excel_multiCondi_structuredCouponSchedule");
            
            if (excel_multiCondi_structuredCouponScheduleNode != null)
            {
                if (excel_multiCondi_structuredCouponScheduleNode.Attributes["href"] != null || excel_multiCondi_structuredCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_multiCondi_structuredCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_multiCondi_structuredCouponScheduleIDRef_ = excel_multiCondi_structuredCouponScheduleNode.Attributes["id"].Value;
                        Excel_multiCondi_structuredCouponSchedule ob = new Excel_multiCondi_structuredCouponSchedule(excel_multiCondi_structuredCouponScheduleNode);
                        IDManager.SetID(excel_multiCondi_structuredCouponScheduleIDRef_, ob);
                    }
                    else if (excel_multiCondi_structuredCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_multiCondi_structuredCouponScheduleIDRef_ = excel_multiCondi_structuredCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiCondi_structuredCouponSchedule_ = new Excel_multiCondi_structuredCouponSchedule(excel_multiCondi_structuredCouponScheduleNode);
                    }
                }
                else
                {
                    excel_multiCondi_structuredCouponSchedule_ = new Excel_multiCondi_structuredCouponSchedule(excel_multiCondi_structuredCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_multiCondi_structuredAccrualCouponScheduleNode = xmlNode.SelectSingleNode("excel_multiCondi_structuredAccrualCouponSchedule");
            
            if (excel_multiCondi_structuredAccrualCouponScheduleNode != null)
            {
                if (excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["href"] != null || excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_multiCondi_structuredAccrualCouponScheduleIDRef_ = excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["id"].Value;
                        Excel_multiCondi_structuredAccrualCouponSchedule ob = new Excel_multiCondi_structuredAccrualCouponSchedule(excel_multiCondi_structuredAccrualCouponScheduleNode);
                        IDManager.SetID(excel_multiCondi_structuredAccrualCouponScheduleIDRef_, ob);
                    }
                    else if (excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_multiCondi_structuredAccrualCouponScheduleIDRef_ = excel_multiCondi_structuredAccrualCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiCondi_structuredAccrualCouponSchedule_ = new Excel_multiCondi_structuredAccrualCouponSchedule(excel_multiCondi_structuredAccrualCouponScheduleNode);
                    }
                }
                else
                {
                    excel_multiCondi_structuredAccrualCouponSchedule_ = new Excel_multiCondi_structuredAccrualCouponSchedule(excel_multiCondi_structuredAccrualCouponScheduleNode);
                }
            }
            
        
            XmlNode excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode = xmlNode.SelectSingleNode("excel_multiCondi_multiRng_structuredAccrualCouponSchedule");
            
            if (excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode != null)
            {
                if (excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["href"] != null || excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                {
                    if (excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["id"] != null) 
                    {
                        excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_ = excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["id"].Value;
                        Excel_multiCondi_multiRng_structuredAccrualCouponSchedule ob = new Excel_multiCondi_multiRng_structuredAccrualCouponSchedule(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode);
                        IDManager.SetID(excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_, ob);
                    }
                    else if (excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["href"] != null)
                    {
                        excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_ = excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ = new Excel_multiCondi_multiRng_structuredAccrualCouponSchedule(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode);
                    }
                }
                else
                {
                    excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ = new Excel_multiCondi_multiRng_structuredAccrualCouponSchedule(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode);
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
        #region Excel_additionalOption_
        private Excel_additionalOption excel_additionalOption_;
        public Excel_additionalOption Excel_additionalOption_
        {
            get
            {
                if (this.excel_additionalOption_ != null)
                {
                    return this.excel_additionalOption_; 
                }
                else if (this.excel_additionalOptionIDRef_ != null)
                {
                    excel_additionalOption_ = IDManager.getID(excel_additionalOptionIDRef_) as Excel_additionalOption;
                    return this.excel_additionalOption_; 
                }
                else
                {
                    throw new Exception( "excel_additionalOption_Node no exist!");
                }
            }
            set
            {
                if (this.excel_additionalOption_ != value)
                {
                    this.excel_additionalOption_ = value;
                }
            }
        }
        #endregion
        
        public string excel_additionalOptionIDRef_ { get; set; }
        #region Excel_fixedCouponSchedule_
        private Excel_fixedCouponSchedule excel_fixedCouponSchedule_;
        public Excel_fixedCouponSchedule Excel_fixedCouponSchedule_
        {
            get
            {
                if (this.excel_fixedCouponSchedule_ != null)
                {
                    return this.excel_fixedCouponSchedule_; 
                }
                else if (this.excel_fixedCouponScheduleIDRef_ != null)
                {
                    excel_fixedCouponSchedule_ = IDManager.getID(excel_fixedCouponScheduleIDRef_) as Excel_fixedCouponSchedule;
                    return this.excel_fixedCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_fixedCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedCouponSchedule_ != value)
                {
                    this.excel_fixedCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedCouponScheduleIDRef_ { get; set; }
        #region Excel_vanillaFloatingCouponSchedule_
        private Excel_vanillaFloatingCouponSchedule excel_vanillaFloatingCouponSchedule_;
        public Excel_vanillaFloatingCouponSchedule Excel_vanillaFloatingCouponSchedule_
        {
            get
            {
                if (this.excel_vanillaFloatingCouponSchedule_ != null)
                {
                    return this.excel_vanillaFloatingCouponSchedule_; 
                }
                else if (this.excel_vanillaFloatingCouponScheduleIDRef_ != null)
                {
                    excel_vanillaFloatingCouponSchedule_ = IDManager.getID(excel_vanillaFloatingCouponScheduleIDRef_) as Excel_vanillaFloatingCouponSchedule;
                    return this.excel_vanillaFloatingCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingCouponSchedule_ != value)
                {
                    this.excel_vanillaFloatingCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingCouponScheduleIDRef_ { get; set; }
        #region Excel_floatingCouponSchedule_
        private Excel_floatingCouponSchedule excel_floatingCouponSchedule_;
        public Excel_floatingCouponSchedule Excel_floatingCouponSchedule_
        {
            get
            {
                if (this.excel_floatingCouponSchedule_ != null)
                {
                    return this.excel_floatingCouponSchedule_; 
                }
                else if (this.excel_floatingCouponScheduleIDRef_ != null)
                {
                    excel_floatingCouponSchedule_ = IDManager.getID(excel_floatingCouponScheduleIDRef_) as Excel_floatingCouponSchedule;
                    return this.excel_floatingCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_floatingCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_floatingCouponSchedule_ != value)
                {
                    this.excel_floatingCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_floatingCouponScheduleIDRef_ { get; set; }
        #region Excel_condi_structuredCouponSchedule_
        private Excel_condi_structuredCouponSchedule excel_condi_structuredCouponSchedule_;
        public Excel_condi_structuredCouponSchedule Excel_condi_structuredCouponSchedule_
        {
            get
            {
                if (this.excel_condi_structuredCouponSchedule_ != null)
                {
                    return this.excel_condi_structuredCouponSchedule_; 
                }
                else if (this.excel_condi_structuredCouponScheduleIDRef_ != null)
                {
                    excel_condi_structuredCouponSchedule_ = IDManager.getID(excel_condi_structuredCouponScheduleIDRef_) as Excel_condi_structuredCouponSchedule;
                    return this.excel_condi_structuredCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_condi_structuredCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_condi_structuredCouponSchedule_ != value)
                {
                    this.excel_condi_structuredCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_condi_structuredCouponScheduleIDRef_ { get; set; }
        #region Excel_condi_structuredAccrualCouponSchedule_
        private Excel_condi_structuredAccrualCouponSchedule excel_condi_structuredAccrualCouponSchedule_;
        public Excel_condi_structuredAccrualCouponSchedule Excel_condi_structuredAccrualCouponSchedule_
        {
            get
            {
                if (this.excel_condi_structuredAccrualCouponSchedule_ != null)
                {
                    return this.excel_condi_structuredAccrualCouponSchedule_; 
                }
                else if (this.excel_condi_structuredAccrualCouponScheduleIDRef_ != null)
                {
                    excel_condi_structuredAccrualCouponSchedule_ = IDManager.getID(excel_condi_structuredAccrualCouponScheduleIDRef_) as Excel_condi_structuredAccrualCouponSchedule;
                    return this.excel_condi_structuredAccrualCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_condi_structuredAccrualCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_condi_structuredAccrualCouponSchedule_ != value)
                {
                    this.excel_condi_structuredAccrualCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_condi_structuredAccrualCouponScheduleIDRef_ { get; set; }
        #region Excel_multiCondi_structuredCouponSchedule_
        private Excel_multiCondi_structuredCouponSchedule excel_multiCondi_structuredCouponSchedule_;
        public Excel_multiCondi_structuredCouponSchedule Excel_multiCondi_structuredCouponSchedule_
        {
            get
            {
                if (this.excel_multiCondi_structuredCouponSchedule_ != null)
                {
                    return this.excel_multiCondi_structuredCouponSchedule_; 
                }
                else if (this.excel_multiCondi_structuredCouponScheduleIDRef_ != null)
                {
                    excel_multiCondi_structuredCouponSchedule_ = IDManager.getID(excel_multiCondi_structuredCouponScheduleIDRef_) as Excel_multiCondi_structuredCouponSchedule;
                    return this.excel_multiCondi_structuredCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_multiCondi_structuredCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiCondi_structuredCouponSchedule_ != value)
                {
                    this.excel_multiCondi_structuredCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiCondi_structuredCouponScheduleIDRef_ { get; set; }
        #region Excel_multiCondi_structuredAccrualCouponSchedule_
        private Excel_multiCondi_structuredAccrualCouponSchedule excel_multiCondi_structuredAccrualCouponSchedule_;
        public Excel_multiCondi_structuredAccrualCouponSchedule Excel_multiCondi_structuredAccrualCouponSchedule_
        {
            get
            {
                if (this.excel_multiCondi_structuredAccrualCouponSchedule_ != null)
                {
                    return this.excel_multiCondi_structuredAccrualCouponSchedule_; 
                }
                else if (this.excel_multiCondi_structuredAccrualCouponScheduleIDRef_ != null)
                {
                    excel_multiCondi_structuredAccrualCouponSchedule_ = IDManager.getID(excel_multiCondi_structuredAccrualCouponScheduleIDRef_) as Excel_multiCondi_structuredAccrualCouponSchedule;
                    return this.excel_multiCondi_structuredAccrualCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_multiCondi_structuredAccrualCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiCondi_structuredAccrualCouponSchedule_ != value)
                {
                    this.excel_multiCondi_structuredAccrualCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiCondi_structuredAccrualCouponScheduleIDRef_ { get; set; }
        #region Excel_multiCondi_multiRng_structuredAccrualCouponSchedule_
        private Excel_multiCondi_multiRng_structuredAccrualCouponSchedule excel_multiCondi_multiRng_structuredAccrualCouponSchedule_;
        public Excel_multiCondi_multiRng_structuredAccrualCouponSchedule Excel_multiCondi_multiRng_structuredAccrualCouponSchedule_
        {
            get
            {
                if (this.excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ != null)
                {
                    return this.excel_multiCondi_multiRng_structuredAccrualCouponSchedule_; 
                }
                else if (this.excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_ != null)
                {
                    excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ = IDManager.getID(excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_) as Excel_multiCondi_multiRng_structuredAccrualCouponSchedule;
                    return this.excel_multiCondi_multiRng_structuredAccrualCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_multiCondi_multiRng_structuredAccrualCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ != value)
                {
                    this.excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiCondi_multiRng_structuredAccrualCouponScheduleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

