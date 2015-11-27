using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CompositeSumOptionPayoff : ISerialized
    {
        public CompositeSumOptionPayoff() { }
        public CompositeSumOptionPayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixingDateInfoNode = xmlNode.SelectSingleNode("fixingDateInfo");
            
            if (fixingDateInfoNode != null)
            {
                if (fixingDateInfoNode.Attributes["href"] != null || fixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (fixingDateInfoNode.Attributes["id"] != null) 
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["id"].Value;
                        FixingDateInfo ob = new FixingDateInfo(fixingDateInfoNode);
                        IDManager.SetID(fixingDateInfoIDRef_, ob);
                    }
                    else if (fixingDateInfoNode.Attributes["href"] != null)
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
                    }
                }
                else
                {
                    fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
                }
            }
            
        
            XmlNode payoffDateInfoNode = xmlNode.SelectSingleNode("payoffDateInfo");
            
            if (payoffDateInfoNode != null)
            {
                if (payoffDateInfoNode.Attributes["href"] != null || payoffDateInfoNode.Attributes["id"] != null) 
                {
                    if (payoffDateInfoNode.Attributes["id"] != null) 
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["id"].Value;
                        PayoffDateInfo ob = new PayoffDateInfo(payoffDateInfoNode);
                        IDManager.SetID(payoffDateInfoIDRef_, ob);
                    }
                    else if (payoffDateInfoNode.Attributes["href"] != null)
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                    }
                }
                else
                {
                    payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
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
            
        
            XmlNodeList standardOptionNodeList = xmlNode.SelectNodes("standardOption");
            
            if (standardOptionNodeList != null)
            {
                this.standardOption_ = new List<StandardOption>();
                foreach (XmlNode item in standardOptionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            standardOptionIDRef_ = item.Attributes["id"].Value;
                            standardOption_.Add(new StandardOption(item));
                            IDManager.SetID(standardOptionIDRef_, standardOption_[standardOption_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            standardOptionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        standardOption_.Add(new StandardOption(item));
                        }
                    }
                    else
                    {
                        standardOption_.Add(new StandardOption(item));
                    }
                }
            }
            
        
        }
        
    
        #region FixingDateInfo_
        private FixingDateInfo fixingDateInfo_;
        public FixingDateInfo FixingDateInfo_
        {
            get
            {
                if (this.fixingDateInfo_ != null)
                {
                    return this.fixingDateInfo_; 
                }
                else if (this.fixingDateInfoIDRef_ != null)
                {
                    fixingDateInfo_ = IDManager.getID(fixingDateInfoIDRef_) as FixingDateInfo;
                    return this.fixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "fixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.fixingDateInfo_ != value)
                {
                    this.fixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateInfoIDRef_ { get; set; }
        #region PayoffDateInfo_
        private PayoffDateInfo payoffDateInfo_;
        public PayoffDateInfo PayoffDateInfo_
        {
            get
            {
                if (this.payoffDateInfo_ != null)
                {
                    return this.payoffDateInfo_; 
                }
                else if (this.payoffDateInfoIDRef_ != null)
                {
                    payoffDateInfo_ = IDManager.getID(payoffDateInfoIDRef_) as PayoffDateInfo;
                    return this.payoffDateInfo_; 
                }
                else
                {
                    throw new Exception( "payoffDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDateInfo_ != value)
                {
                    this.payoffDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateInfoIDRef_ { get; set; }
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
        #region StandardOption_
        private List<StandardOption> standardOption_;
        public List<StandardOption> StandardOption_
        {
            get
            {
                if (this.standardOption_ != null)
                {
                    return this.standardOption_; 
                }
                else if (this.standardOptionIDRef_ != null)
                {
                    return this.standardOption_; 
                }
                else
                {
                    throw new Exception( "standardOption_Node no exist!");
                }
            }
            set
            {
                if (this.standardOption_ != value)
                {
                    this.standardOption_ = value;
                }
            }
        }
        #endregion
        
        public string standardOptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

