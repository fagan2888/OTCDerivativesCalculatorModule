using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StepDownKI_paraSetting : ISerialized
    {
        public StepDownKI_paraSetting() { }
        public StepDownKI_paraSetting(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode geometricBM_paraSettingNode = xmlNode.SelectSingleNode("geometricBM_paraSetting");
            
            if (geometricBM_paraSettingNode != null)
            {
                if (geometricBM_paraSettingNode.Attributes["href"] != null || geometricBM_paraSettingNode.Attributes["id"] != null) 
                {
                    if (geometricBM_paraSettingNode.Attributes["id"] != null) 
                    {
                        geometricBM_paraSettingIDRef_ = geometricBM_paraSettingNode.Attributes["id"].Value;
                        GeometricBM_paraSetting ob = new GeometricBM_paraSetting(geometricBM_paraSettingNode);
                        IDManager.SetID(geometricBM_paraSettingIDRef_, ob);
                    }
                    else if (geometricBM_paraSettingNode.Attributes["href"] != null)
                    {
                        geometricBM_paraSettingIDRef_ = geometricBM_paraSettingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        geometricBM_paraSetting_ = new GeometricBM_paraSetting(geometricBM_paraSettingNode);
                    }
                }
                else
                {
                    geometricBM_paraSetting_ = new GeometricBM_paraSetting(geometricBM_paraSettingNode);
                }
            }
            
        
            XmlNode hullWhite_paraSettingNode = xmlNode.SelectSingleNode("hullWhite_paraSetting");
            
            if (hullWhite_paraSettingNode != null)
            {
                if (hullWhite_paraSettingNode.Attributes["href"] != null || hullWhite_paraSettingNode.Attributes["id"] != null) 
                {
                    if (hullWhite_paraSettingNode.Attributes["id"] != null) 
                    {
                        hullWhite_paraSettingIDRef_ = hullWhite_paraSettingNode.Attributes["id"].Value;
                        HullWhite_paraSetting ob = new HullWhite_paraSetting(hullWhite_paraSettingNode);
                        IDManager.SetID(hullWhite_paraSettingIDRef_, ob);
                    }
                    else if (hullWhite_paraSettingNode.Attributes["href"] != null)
                    {
                        hullWhite_paraSettingIDRef_ = hullWhite_paraSettingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hullWhite_paraSetting_ = new HullWhite_paraSetting(hullWhite_paraSettingNode);
                    }
                }
                else
                {
                    hullWhite_paraSetting_ = new HullWhite_paraSetting(hullWhite_paraSettingNode);
                }
            }
            
        
            XmlNode discountCurve_paraSettingNode = xmlNode.SelectSingleNode("discountCurve_paraSetting");
            
            if (discountCurve_paraSettingNode != null)
            {
                if (discountCurve_paraSettingNode.Attributes["href"] != null || discountCurve_paraSettingNode.Attributes["id"] != null) 
                {
                    if (discountCurve_paraSettingNode.Attributes["id"] != null) 
                    {
                        discountCurve_paraSettingIDRef_ = discountCurve_paraSettingNode.Attributes["id"].Value;
                        DiscountCurve_paraSetting ob = new DiscountCurve_paraSetting(discountCurve_paraSettingNode);
                        IDManager.SetID(discountCurve_paraSettingIDRef_, ob);
                    }
                    else if (discountCurve_paraSettingNode.Attributes["href"] != null)
                    {
                        discountCurve_paraSettingIDRef_ = discountCurve_paraSettingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountCurve_paraSetting_ = new DiscountCurve_paraSetting(discountCurve_paraSettingNode);
                    }
                }
                else
                {
                    discountCurve_paraSetting_ = new DiscountCurve_paraSetting(discountCurve_paraSettingNode);
                }
            }
            
        
        }
        
    
        #region GeometricBM_paraSetting_
        private GeometricBM_paraSetting geometricBM_paraSetting_;
        public GeometricBM_paraSetting GeometricBM_paraSetting_
        {
            get
            {
                if (this.geometricBM_paraSetting_ != null)
                {
                    return this.geometricBM_paraSetting_; 
                }
                else if (this.geometricBM_paraSettingIDRef_ != null)
                {
                    geometricBM_paraSetting_ = IDManager.getID(geometricBM_paraSettingIDRef_) as GeometricBM_paraSetting;
                    return this.geometricBM_paraSetting_; 
                }
                else
                {
                    throw new Exception( "geometricBM_paraSetting_Node no exist!");
                }
            }
            set
            {
                if (this.geometricBM_paraSetting_ != value)
                {
                    this.geometricBM_paraSetting_ = value;
                }
            }
        }
        #endregion
        
        public string geometricBM_paraSettingIDRef_ { get; set; }
        #region HullWhite_paraSetting_
        private HullWhite_paraSetting hullWhite_paraSetting_;
        public HullWhite_paraSetting HullWhite_paraSetting_
        {
            get
            {
                if (this.hullWhite_paraSetting_ != null)
                {
                    return this.hullWhite_paraSetting_; 
                }
                else if (this.hullWhite_paraSettingIDRef_ != null)
                {
                    hullWhite_paraSetting_ = IDManager.getID(hullWhite_paraSettingIDRef_) as HullWhite_paraSetting;
                    return this.hullWhite_paraSetting_; 
                }
                else
                {
                    throw new Exception( "hullWhite_paraSetting_Node no exist!");
                }
            }
            set
            {
                if (this.hullWhite_paraSetting_ != value)
                {
                    this.hullWhite_paraSetting_ = value;
                }
            }
        }
        #endregion
        
        public string hullWhite_paraSettingIDRef_ { get; set; }
        #region DiscountCurve_paraSetting_
        private DiscountCurve_paraSetting discountCurve_paraSetting_;
        public DiscountCurve_paraSetting DiscountCurve_paraSetting_
        {
            get
            {
                if (this.discountCurve_paraSetting_ != null)
                {
                    return this.discountCurve_paraSetting_; 
                }
                else if (this.discountCurve_paraSettingIDRef_ != null)
                {
                    discountCurve_paraSetting_ = IDManager.getID(discountCurve_paraSettingIDRef_) as DiscountCurve_paraSetting;
                    return this.discountCurve_paraSetting_; 
                }
                else
                {
                    throw new Exception( "discountCurve_paraSetting_Node no exist!");
                }
            }
            set
            {
                if (this.discountCurve_paraSetting_ != value)
                {
                    this.discountCurve_paraSetting_ = value;
                }
            }
        }
        #endregion
        
        public string discountCurve_paraSettingIDRef_ { get; set; }
        
    
        
    
    }
    
}

