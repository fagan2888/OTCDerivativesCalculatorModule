using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ParametricAdjustment : ISerialized
    {
        public ParametricAdjustment(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeNormalizedString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeNormalizedString(nameNode);
                }
            }
            
        
            XmlNode inputUnitsNode = xmlNode.SelectSingleNode("inputUnits");
            
            if (inputUnitsNode != null)
            {
                if (inputUnitsNode.Attributes["href"] != null || inputUnitsNode.Attributes["id"] != null) 
                {
                    if (inputUnitsNode.Attributes["id"] != null) 
                    {
                        inputUnitsIDRef_ = inputUnitsNode.Attributes["id"].Value;
                        PriceQuoteUnits ob = new PriceQuoteUnits(inputUnitsNode);
                        IDManager.SetID(inputUnitsIDRef_, ob);
                    }
                    else if (inputUnitsNode.Attributes["href"] != null)
                    {
                        inputUnitsIDRef_ = inputUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inputUnits_ = new PriceQuoteUnits(inputUnitsNode);
                    }
                }
                else
                {
                    inputUnits_ = new PriceQuoteUnits(inputUnitsNode);
                }
            }
            
        
            XmlNodeList datapointNodeList = xmlNode.SelectNodes("datapoint");
            
            if (datapointNodeList != null)
            {
                this.datapoint_ = new List<ParametricAdjustmentPoint>();
                foreach (XmlNode item in datapointNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            datapointIDRef_ = item.Attributes["id"].Value;
                            datapoint_.Add(new ParametricAdjustmentPoint(item));
                            IDManager.SetID(datapointIDRef_, datapoint_[datapoint_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            datapointIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        datapoint_.Add(new ParametricAdjustmentPoint(item));
                        }
                    }
                    else
                    {
                        datapoint_.Add(new ParametricAdjustmentPoint(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeNormalizedString name_;
        public XsdTypeNormalizedString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeNormalizedString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region InputUnits_
        private PriceQuoteUnits inputUnits_;
        public PriceQuoteUnits InputUnits_
        {
            get
            {
                if (this.inputUnits_ != null)
                {
                    return this.inputUnits_; 
                }
                else if (this.inputUnitsIDRef_ != null)
                {
                    inputUnits_ = IDManager.getID(inputUnitsIDRef_) as PriceQuoteUnits;
                    return this.inputUnits_; 
                }
                else
                {
                      return this.inputUnits_; 
                }
            }
            set
            {
                if (this.inputUnits_ != value)
                {
                    this.inputUnits_ = value;
                }
            }
        }
        #endregion
        
        public string inputUnitsIDRef_ { get; set; }
        #region Datapoint_
        private List<ParametricAdjustmentPoint> datapoint_;
        public List<ParametricAdjustmentPoint> Datapoint_
        {
            get
            {
                if (this.datapoint_ != null)
                {
                    return this.datapoint_; 
                }
                else if (this.datapointIDRef_ != null)
                {
                    return this.datapoint_; 
                }
                else
                {
                      return this.datapoint_; 
                }
            }
            set
            {
                if (this.datapoint_ != value)
                {
                    this.datapoint_ = value;
                }
            }
        }
        #endregion
        
        public string datapointIDRef_ { get; set; }
        
    
        
    
    }
    
}

