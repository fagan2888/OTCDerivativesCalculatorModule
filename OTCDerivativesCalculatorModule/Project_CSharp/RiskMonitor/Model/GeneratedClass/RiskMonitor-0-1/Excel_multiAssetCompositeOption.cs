using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_multiAssetCompositeOption : ISerialized
    {
        public Excel_multiAssetCompositeOption() { }
        public Excel_multiAssetCompositeOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_issueInfoNode = xmlNode.SelectSingleNode("excel_issueInfo");
            
            if (excel_issueInfoNode != null)
            {
                if (excel_issueInfoNode.Attributes["href"] != null || excel_issueInfoNode.Attributes["id"] != null) 
                {
                    if (excel_issueInfoNode.Attributes["id"] != null) 
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["id"].Value;
                        Excel_issueInfo ob = new Excel_issueInfo(excel_issueInfoNode);
                        IDManager.SetID(excel_issueInfoIDRef_, ob);
                    }
                    else if (excel_issueInfoNode.Attributes["href"] != null)
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                    }
                }
                else
                {
                    excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcInfoNode = xmlNode.SelectSingleNode("excel_underlyingCalcInfo");
            
            if (excel_underlyingCalcInfoNode != null)
            {
                if (excel_underlyingCalcInfoNode.Attributes["href"] != null || excel_underlyingCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcInfoIDRef_ = excel_underlyingCalcInfoNode.Attributes["id"].Value;
                        Excel_underlyingCalcInfo ob = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                        IDManager.SetID(excel_underlyingCalcInfoIDRef_, ob);
                    }
                    else if (excel_underlyingCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcInfoIDRef_ = excel_underlyingCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcInfo_ = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                    }
                }
                else
                {
                    excel_underlyingCalcInfo_ = new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode);
                }
            }
            
        
            XmlNode exerciseDateNode = xmlNode.SelectSingleNode("exerciseDate");
            
            if (exerciseDateNode != null)
            {
                if (exerciseDateNode.Attributes["href"] != null || exerciseDateNode.Attributes["id"] != null) 
                {
                    if (exerciseDateNode.Attributes["id"] != null) 
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(exerciseDateNode);
                        IDManager.SetID(exerciseDateIDRef_, ob);
                    }
                    else if (exerciseDateNode.Attributes["href"] != null)
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseDate_ = new XsdTypeToken(exerciseDateNode);
                    }
                }
                else
                {
                    exerciseDate_ = new XsdTypeToken(exerciseDateNode);
                }
            }
            
        
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNode notionalMaturityPaymentNode = xmlNode.SelectSingleNode("notionalMaturityPayment");
            
            if (notionalMaturityPaymentNode != null)
            {
                if (notionalMaturityPaymentNode.Attributes["href"] != null || notionalMaturityPaymentNode.Attributes["id"] != null) 
                {
                    if (notionalMaturityPaymentNode.Attributes["id"] != null) 
                    {
                        notionalMaturityPaymentIDRef_ = notionalMaturityPaymentNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notionalMaturityPaymentNode);
                        IDManager.SetID(notionalMaturityPaymentIDRef_, ob);
                    }
                    else if (notionalMaturityPaymentNode.Attributes["href"] != null)
                    {
                        notionalMaturityPaymentIDRef_ = notionalMaturityPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalMaturityPayment_ = new XsdTypeToken(notionalMaturityPaymentNode);
                    }
                }
                else
                {
                    notionalMaturityPayment_ = new XsdTypeToken(notionalMaturityPaymentNode);
                }
            }
            
        
            XmlNodeList excel_multiAsset_compositeOption_subtypeNodeList = xmlNode.SelectNodes("excel_multiAsset_compositeOption_subtype");
            
            if (excel_multiAsset_compositeOption_subtypeNodeList != null)
            {
                this.excel_multiAsset_compositeOption_subtype_ = new List<Excel_multiAsset_compositeOption_subtype>();
                foreach (XmlNode item in excel_multiAsset_compositeOption_subtypeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_multiAsset_compositeOption_subtypeIDRef_ = item.Attributes["id"].Value;
                            excel_multiAsset_compositeOption_subtype_.Add(new Excel_multiAsset_compositeOption_subtype(item));
                            IDManager.SetID(excel_multiAsset_compositeOption_subtypeIDRef_, excel_multiAsset_compositeOption_subtype_[excel_multiAsset_compositeOption_subtype_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_multiAsset_compositeOption_subtypeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_multiAsset_compositeOption_subtype_.Add(new Excel_multiAsset_compositeOption_subtype(item));
                        }
                    }
                    else
                    {
                        excel_multiAsset_compositeOption_subtype_.Add(new Excel_multiAsset_compositeOption_subtype(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_issueInfo_
        private Excel_issueInfo excel_issueInfo_;
        public Excel_issueInfo Excel_issueInfo_
        {
            get
            {
                if (this.excel_issueInfo_ != null)
                {
                    return this.excel_issueInfo_; 
                }
                else if (this.excel_issueInfoIDRef_ != null)
                {
                    excel_issueInfo_ = IDManager.getID(excel_issueInfoIDRef_) as Excel_issueInfo;
                    return this.excel_issueInfo_; 
                }
                else
                {
                    throw new Exception( "excel_issueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_issueInfo_ != value)
                {
                    this.excel_issueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_issueInfoIDRef_ { get; set; }
        #region Excel_underlyingCalcInfo_
        private Excel_underlyingCalcInfo excel_underlyingCalcInfo_;
        public Excel_underlyingCalcInfo Excel_underlyingCalcInfo_
        {
            get
            {
                if (this.excel_underlyingCalcInfo_ != null)
                {
                    return this.excel_underlyingCalcInfo_; 
                }
                else if (this.excel_underlyingCalcInfoIDRef_ != null)
                {
                    excel_underlyingCalcInfo_ = IDManager.getID(excel_underlyingCalcInfoIDRef_) as Excel_underlyingCalcInfo;
                    return this.excel_underlyingCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcInfo_ != value)
                {
                    this.excel_underlyingCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcInfoIDRef_ { get; set; }
        #region ExerciseDate_
        private XsdTypeToken exerciseDate_;
        public XsdTypeToken ExerciseDate_
        {
            get
            {
                if (this.exerciseDate_ != null)
                {
                    return this.exerciseDate_; 
                }
                else if (this.exerciseDateIDRef_ != null)
                {
                    exerciseDate_ = IDManager.getID(exerciseDateIDRef_) as XsdTypeToken;
                    return this.exerciseDate_; 
                }
                else
                {
                    throw new Exception( "exerciseDate_Node no exist!");
                }
            }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseDateIDRef_ { get; set; }
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                    throw new Exception( "payoffDate_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region NotionalMaturityPayment_
        private XsdTypeToken notionalMaturityPayment_;
        public XsdTypeToken NotionalMaturityPayment_
        {
            get
            {
                if (this.notionalMaturityPayment_ != null)
                {
                    return this.notionalMaturityPayment_; 
                }
                else if (this.notionalMaturityPaymentIDRef_ != null)
                {
                    notionalMaturityPayment_ = IDManager.getID(notionalMaturityPaymentIDRef_) as XsdTypeToken;
                    return this.notionalMaturityPayment_; 
                }
                else
                {
                    throw new Exception( "notionalMaturityPayment_Node no exist!");
                }
            }
            set
            {
                if (this.notionalMaturityPayment_ != value)
                {
                    this.notionalMaturityPayment_ = value;
                }
            }
        }
        #endregion
        
        public string notionalMaturityPaymentIDRef_ { get; set; }
        #region Excel_multiAsset_compositeOption_subtype_
        private List<Excel_multiAsset_compositeOption_subtype> excel_multiAsset_compositeOption_subtype_;
        public List<Excel_multiAsset_compositeOption_subtype> Excel_multiAsset_compositeOption_subtype_
        {
            get
            {
                if (this.excel_multiAsset_compositeOption_subtype_ != null)
                {
                    return this.excel_multiAsset_compositeOption_subtype_; 
                }
                else if (this.excel_multiAsset_compositeOption_subtypeIDRef_ != null)
                {
                    return this.excel_multiAsset_compositeOption_subtype_; 
                }
                else
                {
                    throw new Exception( "excel_multiAsset_compositeOption_subtype_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAsset_compositeOption_subtype_ != value)
                {
                    this.excel_multiAsset_compositeOption_subtype_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAsset_compositeOption_subtypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

