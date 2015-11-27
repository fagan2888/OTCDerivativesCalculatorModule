using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwapCurveValuation : ISerialized
    {
        public SwapCurveValuation(XmlNode xmlNode)
        {
            XmlNode floatingRateIndexNode = xmlNode.SelectSingleNode("floatingRateIndex");
            
            if (floatingRateIndexNode != null)
            {
                if (floatingRateIndexNode.Attributes["href"] != null || floatingRateIndexNode.Attributes["id"] != null) 
                {
                    if (floatingRateIndexNode.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["id"].Value;
                        FloatingRateIndex ob = new FloatingRateIndex(floatingRateIndexNode);
                        IDManager.SetID(floatingRateIndexIDRef_, ob);
                    }
                    else if (floatingRateIndexNode.Attributes["href"] != null)
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                    }
                }
                else
                {
                    floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                }
            }
            
        
            XmlNode indexTenorNode = xmlNode.SelectSingleNode("indexTenor");
            
            if (indexTenorNode != null)
            {
                if (indexTenorNode.Attributes["href"] != null || indexTenorNode.Attributes["id"] != null) 
                {
                    if (indexTenorNode.Attributes["id"] != null) 
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["id"].Value;
                        Period ob = new Period(indexTenorNode);
                        IDManager.SetID(indexTenorIDRef_, ob);
                    }
                    else if (indexTenorNode.Attributes["href"] != null)
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexTenor_ = new Period(indexTenorNode);
                    }
                }
                else
                {
                    indexTenor_ = new Period(indexTenorNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDecimal(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDecimal(spreadNode);
                }
            }
            
        
            XmlNode sideNode = xmlNode.SelectSingleNode("side");
            
            if (sideNode != null)
            {
                if (sideNode.Attributes["href"] != null || sideNode.Attributes["id"] != null) 
                {
                    if (sideNode.Attributes["id"] != null) 
                    {
                        sideIDRef_ = sideNode.Attributes["id"].Value;
                        QuotationSideEnum ob = new QuotationSideEnum(sideNode);
                        IDManager.SetID(sideIDRef_, ob);
                    }
                    else if (sideNode.Attributes["href"] != null)
                    {
                        sideIDRef_ = sideNode.Attributes["href"].Value;
                    }
                    else
                    {
                        side_ = new QuotationSideEnum(sideNode);
                    }
                }
                else
                {
                    side_ = new QuotationSideEnum(sideNode);
                }
            }
            
        
        }
        
    
        #region FloatingRateIndex_
        private FloatingRateIndex floatingRateIndex_;
        public FloatingRateIndex FloatingRateIndex_
        {
            get
            {
                if (this.floatingRateIndex_ != null)
                {
                    return this.floatingRateIndex_; 
                }
                else if (this.floatingRateIndexIDRef_ != null)
                {
                    floatingRateIndex_ = IDManager.getID(floatingRateIndexIDRef_) as FloatingRateIndex;
                    return this.floatingRateIndex_; 
                }
                else
                {
                      return this.floatingRateIndex_; 
                }
            }
            set
            {
                if (this.floatingRateIndex_ != value)
                {
                    this.floatingRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIndexIDRef_ { get; set; }
        #region IndexTenor_
        private Period indexTenor_;
        public Period IndexTenor_
        {
            get
            {
                if (this.indexTenor_ != null)
                {
                    return this.indexTenor_; 
                }
                else if (this.indexTenorIDRef_ != null)
                {
                    indexTenor_ = IDManager.getID(indexTenorIDRef_) as Period;
                    return this.indexTenor_; 
                }
                else
                {
                      return this.indexTenor_; 
                }
            }
            set
            {
                if (this.indexTenor_ != value)
                {
                    this.indexTenor_ = value;
                }
            }
        }
        #endregion
        
        public string indexTenorIDRef_ { get; set; }
        #region Spread_
        private XsdTypeDecimal spread_;
        public XsdTypeDecimal Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDecimal;
                    return this.spread_; 
                }
                else
                {
                      return this.spread_; 
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region Side_
        private QuotationSideEnum side_;
        public QuotationSideEnum Side_
        {
            get
            {
                if (this.side_ != null)
                {
                    return this.side_; 
                }
                else if (this.sideIDRef_ != null)
                {
                    side_ = IDManager.getID(sideIDRef_) as QuotationSideEnum;
                    return this.side_; 
                }
                else
                {
                      return this.side_; 
                }
            }
            set
            {
                if (this.side_ != value)
                {
                    this.side_ = value;
                }
            }
        }
        #endregion
        
        public string sideIDRef_ { get; set; }
        
    
        
    
    }
    
}

