using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_forwardModel : ISerialized
    {
        public Excel_forwardModel() { }
        public Excel_forwardModel(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode currentValueNode = xmlNode.SelectSingleNode("currentValue");
            
            if (currentValueNode != null)
            {
                if (currentValueNode.Attributes["href"] != null || currentValueNode.Attributes["id"] != null) 
                {
                    if (currentValueNode.Attributes["id"] != null) 
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currentValueNode);
                        IDManager.SetID(currentValueIDRef_, ob);
                    }
                    else if (currentValueNode.Attributes["href"] != null)
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentValue_ = new XsdTypeToken(currentValueNode);
                    }
                }
                else
                {
                    currentValue_ = new XsdTypeToken(currentValueNode);
                }
            }
            
        
            XmlNode tenorNode = xmlNode.SelectSingleNode("tenor");
            
            if (tenorNode != null)
            {
                if (tenorNode.Attributes["href"] != null || tenorNode.Attributes["id"] != null) 
                {
                    if (tenorNode.Attributes["id"] != null) 
                    {
                        tenorIDRef_ = tenorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new XsdTypeToken(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new XsdTypeToken(tenorNode);
                }
            }
            
        
            XmlNode linkedCurveCodeNode = xmlNode.SelectSingleNode("linkedCurveCode");
            
            if (linkedCurveCodeNode != null)
            {
                if (linkedCurveCodeNode.Attributes["href"] != null || linkedCurveCodeNode.Attributes["id"] != null) 
                {
                    if (linkedCurveCodeNode.Attributes["id"] != null) 
                    {
                        linkedCurveCodeIDRef_ = linkedCurveCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(linkedCurveCodeNode);
                        IDManager.SetID(linkedCurveCodeIDRef_, ob);
                    }
                    else if (linkedCurveCodeNode.Attributes["href"] != null)
                    {
                        linkedCurveCodeIDRef_ = linkedCurveCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        linkedCurveCode_ = new XsdTypeToken(linkedCurveCodeNode);
                    }
                }
                else
                {
                    linkedCurveCode_ = new XsdTypeToken(linkedCurveCodeNode);
                }
            }
            
        
            XmlNode excel_yieldCurveNode = xmlNode.SelectSingleNode("excel_yieldCurve");
            
            if (excel_yieldCurveNode != null)
            {
                if (excel_yieldCurveNode.Attributes["href"] != null || excel_yieldCurveNode.Attributes["id"] != null) 
                {
                    if (excel_yieldCurveNode.Attributes["id"] != null) 
                    {
                        excel_yieldCurveIDRef_ = excel_yieldCurveNode.Attributes["id"].Value;
                        Excel_yieldCurve ob = new Excel_yieldCurve(excel_yieldCurveNode);
                        IDManager.SetID(excel_yieldCurveIDRef_, ob);
                    }
                    else if (excel_yieldCurveNode.Attributes["href"] != null)
                    {
                        excel_yieldCurveIDRef_ = excel_yieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_yieldCurve_ = new Excel_yieldCurve(excel_yieldCurveNode);
                    }
                }
                else
                {
                    excel_yieldCurve_ = new Excel_yieldCurve(excel_yieldCurveNode);
                }
            }
            
        
            XmlNode vba_descriptionNode = xmlNode.SelectSingleNode("vba_description");
            
            if (vba_descriptionNode != null)
            {
                if (vba_descriptionNode.Attributes["href"] != null || vba_descriptionNode.Attributes["id"] != null) 
                {
                    if (vba_descriptionNode.Attributes["id"] != null) 
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(vba_descriptionNode);
                        IDManager.SetID(vba_descriptionIDRef_, ob);
                    }
                    else if (vba_descriptionNode.Attributes["href"] != null)
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vba_description_ = new XsdTypeToken(vba_descriptionNode);
                    }
                }
                else
                {
                    vba_description_ = new XsdTypeToken(vba_descriptionNode);
                }
            }
            
        
        }
        
    
        #region CurrentValue_
        private XsdTypeToken currentValue_;
        public XsdTypeToken CurrentValue_
        {
            get
            {
                if (this.currentValue_ != null)
                {
                    return this.currentValue_; 
                }
                else if (this.currentValueIDRef_ != null)
                {
                    currentValue_ = IDManager.getID(currentValueIDRef_) as XsdTypeToken;
                    return this.currentValue_; 
                }
                else
                {
                    throw new Exception( "currentValue_Node no exist!");
                }
            }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                }
            }
        }
        #endregion
        
        public string currentValueIDRef_ { get; set; }
        #region Tenor_
        private XsdTypeToken tenor_;
        public XsdTypeToken Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as XsdTypeToken;
                    return this.tenor_; 
                }
                else
                {
                    throw new Exception( "tenor_Node no exist!");
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region LinkedCurveCode_
        private XsdTypeToken linkedCurveCode_;
        public XsdTypeToken LinkedCurveCode_
        {
            get
            {
                if (this.linkedCurveCode_ != null)
                {
                    return this.linkedCurveCode_; 
                }
                else if (this.linkedCurveCodeIDRef_ != null)
                {
                    linkedCurveCode_ = IDManager.getID(linkedCurveCodeIDRef_) as XsdTypeToken;
                    return this.linkedCurveCode_; 
                }
                else
                {
                    throw new Exception( "linkedCurveCode_Node no exist!");
                }
            }
            set
            {
                if (this.linkedCurveCode_ != value)
                {
                    this.linkedCurveCode_ = value;
                }
            }
        }
        #endregion
        
        public string linkedCurveCodeIDRef_ { get; set; }
        #region Excel_yieldCurve_
        private Excel_yieldCurve excel_yieldCurve_;
        public Excel_yieldCurve Excel_yieldCurve_
        {
            get
            {
                if (this.excel_yieldCurve_ != null)
                {
                    return this.excel_yieldCurve_; 
                }
                else if (this.excel_yieldCurveIDRef_ != null)
                {
                    excel_yieldCurve_ = IDManager.getID(excel_yieldCurveIDRef_) as Excel_yieldCurve;
                    return this.excel_yieldCurve_; 
                }
                else
                {
                    throw new Exception( "excel_yieldCurve_Node no exist!");
                }
            }
            set
            {
                if (this.excel_yieldCurve_ != value)
                {
                    this.excel_yieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string excel_yieldCurveIDRef_ { get; set; }
        #region Vba_description_
        private XsdTypeToken vba_description_;
        public XsdTypeToken Vba_description_
        {
            get
            {
                if (this.vba_description_ != null)
                {
                    return this.vba_description_; 
                }
                else if (this.vba_descriptionIDRef_ != null)
                {
                    vba_description_ = IDManager.getID(vba_descriptionIDRef_) as XsdTypeToken;
                    return this.vba_description_; 
                }
                else
                {
                    throw new Exception( "vba_description_Node no exist!");
                }
            }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                }
            }
        }
        #endregion
        
        public string vba_descriptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

