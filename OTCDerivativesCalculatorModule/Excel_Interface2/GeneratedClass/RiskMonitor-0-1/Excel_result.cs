using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_result : ISerialized
    {
        public Excel_result() { }
        public Excel_result(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationDateNode = xmlNode.SelectSingleNode("calculationDate");
            
            if (calculationDateNode != null)
            {
                if (calculationDateNode.Attributes["href"] != null || calculationDateNode.Attributes["id"] != null) 
                {
                    if (calculationDateNode.Attributes["id"] != null) 
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationDateNode);
                        IDManager.SetID(calculationDateIDRef_, ob);
                    }
                    else if (calculationDateNode.Attributes["href"] != null)
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDate_ = new XsdTypeDate(calculationDateNode);
                    }
                }
                else
                {
                    calculationDate_ = new XsdTypeDate(calculationDateNode);
                }
            }
            
        
            XmlNode excel_valueResultNode = xmlNode.SelectSingleNode("excel_valueResult");
            
            if (excel_valueResultNode != null)
            {
                if (excel_valueResultNode.Attributes["href"] != null || excel_valueResultNode.Attributes["id"] != null) 
                {
                    if (excel_valueResultNode.Attributes["id"] != null) 
                    {
                        excel_valueResultIDRef_ = excel_valueResultNode.Attributes["id"].Value;
                        Excel_valueResult ob = new Excel_valueResult(excel_valueResultNode);
                        IDManager.SetID(excel_valueResultIDRef_, ob);
                    }
                    else if (excel_valueResultNode.Attributes["href"] != null)
                    {
                        excel_valueResultIDRef_ = excel_valueResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_valueResult_ = new Excel_valueResult(excel_valueResultNode);
                    }
                }
                else
                {
                    excel_valueResult_ = new Excel_valueResult(excel_valueResultNode);
                }
            }
            
        
            XmlNode excel_greekResultNode = xmlNode.SelectSingleNode("excel_greekResult");
            
            if (excel_greekResultNode != null)
            {
                if (excel_greekResultNode.Attributes["href"] != null || excel_greekResultNode.Attributes["id"] != null) 
                {
                    if (excel_greekResultNode.Attributes["id"] != null) 
                    {
                        excel_greekResultIDRef_ = excel_greekResultNode.Attributes["id"].Value;
                        Excel_greekResult ob = new Excel_greekResult(excel_greekResultNode);
                        IDManager.SetID(excel_greekResultIDRef_, ob);
                    }
                    else if (excel_greekResultNode.Attributes["href"] != null)
                    {
                        excel_greekResultIDRef_ = excel_greekResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_greekResult_ = new Excel_greekResult(excel_greekResultNode);
                    }
                }
                else
                {
                    excel_greekResult_ = new Excel_greekResult(excel_greekResultNode);
                }
            }
            
        
            XmlNode excel_cashFlowsResultNode = xmlNode.SelectSingleNode("excel_cashFlowsResult");
            
            if (excel_cashFlowsResultNode != null)
            {
                if (excel_cashFlowsResultNode.Attributes["href"] != null || excel_cashFlowsResultNode.Attributes["id"] != null) 
                {
                    if (excel_cashFlowsResultNode.Attributes["id"] != null) 
                    {
                        excel_cashFlowsResultIDRef_ = excel_cashFlowsResultNode.Attributes["id"].Value;
                        Excel_cashFlowsResult ob = new Excel_cashFlowsResult(excel_cashFlowsResultNode);
                        IDManager.SetID(excel_cashFlowsResultIDRef_, ob);
                    }
                    else if (excel_cashFlowsResultNode.Attributes["href"] != null)
                    {
                        excel_cashFlowsResultIDRef_ = excel_cashFlowsResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_cashFlowsResult_ = new Excel_cashFlowsResult(excel_cashFlowsResultNode);
                    }
                }
                else
                {
                    excel_cashFlowsResult_ = new Excel_cashFlowsResult(excel_cashFlowsResultNode);
                }
            }
            
        
        }
        
    
        #region CalculationDate_
        private XsdTypeDate calculationDate_;
        public XsdTypeDate CalculationDate_
        {
            get
            {
                if (this.calculationDate_ != null)
                {
                    return this.calculationDate_; 
                }
                else if (this.calculationDateIDRef_ != null)
                {
                    calculationDate_ = IDManager.getID(calculationDateIDRef_) as XsdTypeDate;
                    return this.calculationDate_; 
                }
                else
                {
                    throw new Exception( "calculationDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDateIDRef_ { get; set; }
        #region Excel_valueResult_
        private Excel_valueResult excel_valueResult_;
        public Excel_valueResult Excel_valueResult_
        {
            get
            {
                if (this.excel_valueResult_ != null)
                {
                    return this.excel_valueResult_; 
                }
                else if (this.excel_valueResultIDRef_ != null)
                {
                    excel_valueResult_ = IDManager.getID(excel_valueResultIDRef_) as Excel_valueResult;
                    return this.excel_valueResult_; 
                }
                else
                {
                    throw new Exception( "excel_valueResult_Node no exist!");
                }
            }
            set
            {
                if (this.excel_valueResult_ != value)
                {
                    this.excel_valueResult_ = value;
                }
            }
        }
        #endregion
        
        public string excel_valueResultIDRef_ { get; set; }
        #region Excel_greekResult_
        private Excel_greekResult excel_greekResult_;
        public Excel_greekResult Excel_greekResult_
        {
            get
            {
                if (this.excel_greekResult_ != null)
                {
                    return this.excel_greekResult_; 
                }
                else if (this.excel_greekResultIDRef_ != null)
                {
                    excel_greekResult_ = IDManager.getID(excel_greekResultIDRef_) as Excel_greekResult;
                    return this.excel_greekResult_; 
                }
                else
                {
                    throw new Exception( "excel_greekResult_Node no exist!");
                }
            }
            set
            {
                if (this.excel_greekResult_ != value)
                {
                    this.excel_greekResult_ = value;
                }
            }
        }
        #endregion
        
        public string excel_greekResultIDRef_ { get; set; }
        #region Excel_cashFlowsResult_
        private Excel_cashFlowsResult excel_cashFlowsResult_;
        public Excel_cashFlowsResult Excel_cashFlowsResult_
        {
            get
            {
                if (this.excel_cashFlowsResult_ != null)
                {
                    return this.excel_cashFlowsResult_; 
                }
                else if (this.excel_cashFlowsResultIDRef_ != null)
                {
                    excel_cashFlowsResult_ = IDManager.getID(excel_cashFlowsResultIDRef_) as Excel_cashFlowsResult;
                    return this.excel_cashFlowsResult_; 
                }
                else
                {
                    throw new Exception( "excel_cashFlowsResult_Node no exist!");
                }
            }
            set
            {
                if (this.excel_cashFlowsResult_ != value)
                {
                    this.excel_cashFlowsResult_ = value;
                }
            }
        }
        #endregion
        
        public string excel_cashFlowsResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

