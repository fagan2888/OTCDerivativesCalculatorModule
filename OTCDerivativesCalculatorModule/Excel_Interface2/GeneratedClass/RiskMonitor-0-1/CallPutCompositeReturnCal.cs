using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CallPutCompositeReturnCal : ISerialized
    {
        public CallPutCompositeReturnCal() { }
        public CallPutCompositeReturnCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList weightNodeList = xmlNode.SelectNodes("weight");
            
            if (weightNodeList != null)
            {
                this.weight_ = new List<XsdTypeDouble>();
                foreach (XmlNode item in weightNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            weightIDRef_ = item.Attributes["id"].Value;
                            weight_.Add(new XsdTypeDouble(item));
                            IDManager.SetID(weightIDRef_, weight_[weight_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            weightIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        weight_.Add(new XsdTypeDouble(item));
                        }
                    }
                    else
                    {
                        weight_.Add(new XsdTypeDouble(item));
                    }
                }
            }
            
        
            XmlNode referenceCalculationInfoNode = xmlNode.SelectSingleNode("referenceCalculationInfo");
            
            if (referenceCalculationInfoNode != null)
            {
                if (referenceCalculationInfoNode.Attributes["href"] != null || referenceCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (referenceCalculationInfoNode.Attributes["id"] != null) 
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["id"].Value;
                        ReferenceCalculationInfo ob = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                        IDManager.SetID(referenceCalculationInfoIDRef_, ob);
                    }
                    else if (referenceCalculationInfoNode.Attributes["href"] != null)
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                    }
                }
                else
                {
                    referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                }
            }
            
        
            XmlNodeList optionPayoffFunctionNodeList = xmlNode.SelectNodes("optionPayoffFunction");
            
            if (optionPayoffFunctionNodeList != null)
            {
                this.optionPayoffFunction_ = new List<OptionPayoffFunction>();
                foreach (XmlNode item in optionPayoffFunctionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            optionPayoffFunctionIDRef_ = item.Attributes["id"].Value;
                            optionPayoffFunction_.Add(new OptionPayoffFunction(item));
                            IDManager.SetID(optionPayoffFunctionIDRef_, optionPayoffFunction_[optionPayoffFunction_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            optionPayoffFunctionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        optionPayoffFunction_.Add(new OptionPayoffFunction(item));
                        }
                    }
                    else
                    {
                        optionPayoffFunction_.Add(new OptionPayoffFunction(item));
                    }
                }
            }
            
        
        }
        
    
        #region Weight_
        private List<XsdTypeDouble> weight_;
        public List<XsdTypeDouble> Weight_
        {
            get
            {
                if (this.weight_ != null)
                {
                    return this.weight_; 
                }
                else if (this.weightIDRef_ != null)
                {
                    return this.weight_; 
                }
                else
                {
                    throw new Exception( "weight_Node no exist!");
                }
            }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                }
            }
        }
        #endregion
        
        public string weightIDRef_ { get; set; }
        #region ReferenceCalculationInfo_
        private ReferenceCalculationInfo referenceCalculationInfo_;
        public ReferenceCalculationInfo ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
                    referenceCalculationInfo_ = IDManager.getID(referenceCalculationInfoIDRef_) as ReferenceCalculationInfo;
                    return this.referenceCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "referenceCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculationInfo_ != value)
                {
                    this.referenceCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationInfoIDRef_ { get; set; }
        #region OptionPayoffFunction_
        private List<OptionPayoffFunction> optionPayoffFunction_;
        public List<OptionPayoffFunction> OptionPayoffFunction_
        {
            get
            {
                if (this.optionPayoffFunction_ != null)
                {
                    return this.optionPayoffFunction_; 
                }
                else if (this.optionPayoffFunctionIDRef_ != null)
                {
                    return this.optionPayoffFunction_; 
                }
                else
                {
                    throw new Exception( "optionPayoffFunction_Node no exist!");
                }
            }
            set
            {
                if (this.optionPayoffFunction_ != value)
                {
                    this.optionPayoffFunction_ = value;
                }
            }
        }
        #endregion
        
        public string optionPayoffFunctionIDRef_ { get; set; }
        
    
        
    
    }
    
}

