using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_standardCreditPara : ISerialized
    {
        public Excel_standardCreditPara() { }
        public Excel_standardCreditPara(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceDateNode = xmlNode.SelectSingleNode("referenceDate");
            
            if (referenceDateNode != null)
            {
                if (referenceDateNode.Attributes["href"] != null || referenceDateNode.Attributes["id"] != null) 
                {
                    if (referenceDateNode.Attributes["id"] != null) 
                    {
                        referenceDateIDRef_ = referenceDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceDateNode);
                        IDManager.SetID(referenceDateIDRef_, ob);
                    }
                    else if (referenceDateNode.Attributes["href"] != null)
                    {
                        referenceDateIDRef_ = referenceDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceDate_ = new XsdTypeToken(referenceDateNode);
                    }
                }
                else
                {
                    referenceDate_ = new XsdTypeToken(referenceDateNode);
                }
            }
            
        
            XmlNode simulationNumNode = xmlNode.SelectSingleNode("simulationNum");
            
            if (simulationNumNode != null)
            {
                if (simulationNumNode.Attributes["href"] != null || simulationNumNode.Attributes["id"] != null) 
                {
                    if (simulationNumNode.Attributes["id"] != null) 
                    {
                        simulationNumIDRef_ = simulationNumNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(simulationNumNode);
                        IDManager.SetID(simulationNumIDRef_, ob);
                    }
                    else if (simulationNumNode.Attributes["href"] != null)
                    {
                        simulationNumIDRef_ = simulationNumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simulationNum_ = new XsdTypeToken(simulationNumNode);
                    }
                }
                else
                {
                    simulationNum_ = new XsdTypeToken(simulationNumNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcInfo_paraNode = xmlNode.SelectSingleNode("excel_underlyingCalcInfo_para");
            
            if (excel_underlyingCalcInfo_paraNode != null)
            {
                if (excel_underlyingCalcInfo_paraNode.Attributes["href"] != null || excel_underlyingCalcInfo_paraNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcInfo_paraNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcInfo_paraIDRef_ = excel_underlyingCalcInfo_paraNode.Attributes["id"].Value;
                        Excel_underlyingCalcInfo_para ob = new Excel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paraNode);
                        IDManager.SetID(excel_underlyingCalcInfo_paraIDRef_, ob);
                    }
                    else if (excel_underlyingCalcInfo_paraNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcInfo_paraIDRef_ = excel_underlyingCalcInfo_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcInfo_para_ = new Excel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paraNode);
                    }
                }
                else
                {
                    excel_underlyingCalcInfo_para_ = new Excel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paraNode);
                }
            }
            
        
            XmlNode excel_referenceCalcInfo_paraNode = xmlNode.SelectSingleNode("excel_referenceCalcInfo_para");
            
            if (excel_referenceCalcInfo_paraNode != null)
            {
                if (excel_referenceCalcInfo_paraNode.Attributes["href"] != null || excel_referenceCalcInfo_paraNode.Attributes["id"] != null) 
                {
                    if (excel_referenceCalcInfo_paraNode.Attributes["id"] != null) 
                    {
                        excel_referenceCalcInfo_paraIDRef_ = excel_referenceCalcInfo_paraNode.Attributes["id"].Value;
                        Excel_referenceCalcInfo_para ob = new Excel_referenceCalcInfo_para(excel_referenceCalcInfo_paraNode);
                        IDManager.SetID(excel_referenceCalcInfo_paraIDRef_, ob);
                    }
                    else if (excel_referenceCalcInfo_paraNode.Attributes["href"] != null)
                    {
                        excel_referenceCalcInfo_paraIDRef_ = excel_referenceCalcInfo_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_referenceCalcInfo_para_ = new Excel_referenceCalcInfo_para(excel_referenceCalcInfo_paraNode);
                    }
                }
                else
                {
                    excel_referenceCalcInfo_para_ = new Excel_referenceCalcInfo_para(excel_referenceCalcInfo_paraNode);
                }
            }
            
        
            XmlNode excel_discountCurve_paraNode = xmlNode.SelectSingleNode("excel_discountCurve_para");
            
            if (excel_discountCurve_paraNode != null)
            {
                if (excel_discountCurve_paraNode.Attributes["href"] != null || excel_discountCurve_paraNode.Attributes["id"] != null) 
                {
                    if (excel_discountCurve_paraNode.Attributes["id"] != null) 
                    {
                        excel_discountCurve_paraIDRef_ = excel_discountCurve_paraNode.Attributes["id"].Value;
                        Excel_discountCurve_para ob = new Excel_discountCurve_para(excel_discountCurve_paraNode);
                        IDManager.SetID(excel_discountCurve_paraIDRef_, ob);
                    }
                    else if (excel_discountCurve_paraNode.Attributes["href"] != null)
                    {
                        excel_discountCurve_paraIDRef_ = excel_discountCurve_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_discountCurve_para_ = new Excel_discountCurve_para(excel_discountCurve_paraNode);
                    }
                }
                else
                {
                    excel_discountCurve_para_ = new Excel_discountCurve_para(excel_discountCurve_paraNode);
                }
            }
            
        
            XmlNode excel_defaultCurve_paraNode = xmlNode.SelectSingleNode("excel_defaultCurve_para");
            
            if (excel_defaultCurve_paraNode != null)
            {
                if (excel_defaultCurve_paraNode.Attributes["href"] != null || excel_defaultCurve_paraNode.Attributes["id"] != null) 
                {
                    if (excel_defaultCurve_paraNode.Attributes["id"] != null) 
                    {
                        excel_defaultCurve_paraIDRef_ = excel_defaultCurve_paraNode.Attributes["id"].Value;
                        Excel_defaultCurve_para ob = new Excel_defaultCurve_para(excel_defaultCurve_paraNode);
                        IDManager.SetID(excel_defaultCurve_paraIDRef_, ob);
                    }
                    else if (excel_defaultCurve_paraNode.Attributes["href"] != null)
                    {
                        excel_defaultCurve_paraIDRef_ = excel_defaultCurve_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_defaultCurve_para_ = new Excel_defaultCurve_para(excel_defaultCurve_paraNode);
                    }
                }
                else
                {
                    excel_defaultCurve_para_ = new Excel_defaultCurve_para(excel_defaultCurve_paraNode);
                }
            }
            
        
        }
        
    
        #region ReferenceDate_
        private XsdTypeToken referenceDate_;
        public XsdTypeToken ReferenceDate_
        {
            get
            {
                if (this.referenceDate_ != null)
                {
                    return this.referenceDate_; 
                }
                else if (this.referenceDateIDRef_ != null)
                {
                    referenceDate_ = IDManager.getID(referenceDateIDRef_) as XsdTypeToken;
                    return this.referenceDate_; 
                }
                else
                {
                    throw new Exception( "referenceDate_Node no exist!");
                }
            }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                }
            }
        }
        #endregion
        
        public string referenceDateIDRef_ { get; set; }
        #region SimulationNum_
        private XsdTypeToken simulationNum_;
        public XsdTypeToken SimulationNum_
        {
            get
            {
                if (this.simulationNum_ != null)
                {
                    return this.simulationNum_; 
                }
                else if (this.simulationNumIDRef_ != null)
                {
                    simulationNum_ = IDManager.getID(simulationNumIDRef_) as XsdTypeToken;
                    return this.simulationNum_; 
                }
                else
                {
                    throw new Exception( "simulationNum_Node no exist!");
                }
            }
            set
            {
                if (this.simulationNum_ != value)
                {
                    this.simulationNum_ = value;
                }
            }
        }
        #endregion
        
        public string simulationNumIDRef_ { get; set; }
        #region Excel_underlyingCalcInfo_para_
        private Excel_underlyingCalcInfo_para excel_underlyingCalcInfo_para_;
        public Excel_underlyingCalcInfo_para Excel_underlyingCalcInfo_para_
        {
            get
            {
                if (this.excel_underlyingCalcInfo_para_ != null)
                {
                    return this.excel_underlyingCalcInfo_para_; 
                }
                else if (this.excel_underlyingCalcInfo_paraIDRef_ != null)
                {
                    excel_underlyingCalcInfo_para_ = IDManager.getID(excel_underlyingCalcInfo_paraIDRef_) as Excel_underlyingCalcInfo_para;
                    return this.excel_underlyingCalcInfo_para_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcInfo_para_ != value)
                {
                    this.excel_underlyingCalcInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcInfo_paraIDRef_ { get; set; }
        #region Excel_referenceCalcInfo_para_
        private Excel_referenceCalcInfo_para excel_referenceCalcInfo_para_;
        public Excel_referenceCalcInfo_para Excel_referenceCalcInfo_para_
        {
            get
            {
                if (this.excel_referenceCalcInfo_para_ != null)
                {
                    return this.excel_referenceCalcInfo_para_; 
                }
                else if (this.excel_referenceCalcInfo_paraIDRef_ != null)
                {
                    excel_referenceCalcInfo_para_ = IDManager.getID(excel_referenceCalcInfo_paraIDRef_) as Excel_referenceCalcInfo_para;
                    return this.excel_referenceCalcInfo_para_; 
                }
                else
                {
                    throw new Exception( "excel_referenceCalcInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceCalcInfo_para_ != value)
                {
                    this.excel_referenceCalcInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceCalcInfo_paraIDRef_ { get; set; }
        #region Excel_discountCurve_para_
        private Excel_discountCurve_para excel_discountCurve_para_;
        public Excel_discountCurve_para Excel_discountCurve_para_
        {
            get
            {
                if (this.excel_discountCurve_para_ != null)
                {
                    return this.excel_discountCurve_para_; 
                }
                else if (this.excel_discountCurve_paraIDRef_ != null)
                {
                    excel_discountCurve_para_ = IDManager.getID(excel_discountCurve_paraIDRef_) as Excel_discountCurve_para;
                    return this.excel_discountCurve_para_; 
                }
                else
                {
                    throw new Exception( "excel_discountCurve_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_discountCurve_para_ != value)
                {
                    this.excel_discountCurve_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_discountCurve_paraIDRef_ { get; set; }
        #region Excel_defaultCurve_para_
        private Excel_defaultCurve_para excel_defaultCurve_para_;
        public Excel_defaultCurve_para Excel_defaultCurve_para_
        {
            get
            {
                if (this.excel_defaultCurve_para_ != null)
                {
                    return this.excel_defaultCurve_para_; 
                }
                else if (this.excel_defaultCurve_paraIDRef_ != null)
                {
                    excel_defaultCurve_para_ = IDManager.getID(excel_defaultCurve_paraIDRef_) as Excel_defaultCurve_para;
                    return this.excel_defaultCurve_para_; 
                }
                else
                {
                    throw new Exception( "excel_defaultCurve_para_Node no exist!");
                }
            }
            set
            {
                if (this.excel_defaultCurve_para_ != value)
                {
                    this.excel_defaultCurve_para_ = value;
                }
            }
        }
        #endregion
        
        public string excel_defaultCurve_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}

