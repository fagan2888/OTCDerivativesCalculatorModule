using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Metal : ISerialized
    {
        public Metal(XmlNode xmlNode)
        {
            XmlNode materialNode = xmlNode.SelectSingleNode("material");
            
            if (materialNode != null)
            {
                if (materialNode.Attributes["href"] != null || materialNode.Attributes["id"] != null) 
                {
                    if (materialNode.Attributes["id"] != null) 
                    {
                        materialIDRef_ = materialNode.Attributes["id"].Value;
                        Material ob = new Material(materialNode);
                        IDManager.SetID(materialIDRef_, ob);
                    }
                    else if (materialNode.Attributes["href"] != null)
                    {
                        materialIDRef_ = materialNode.Attributes["href"].Value;
                    }
                    else
                    {
                        material_ = new Material(materialNode);
                    }
                }
                else
                {
                    material_ = new Material(materialNode);
                }
            }
            
        
            XmlNodeList shapeNodeList = xmlNode.SelectNodes("shape");
            
            if (shapeNodeList != null)
            {
                this.shape_ = new List<CommodityMetalShape>();
                foreach (XmlNode item in shapeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            shapeIDRef_ = item.Attributes["id"].Value;
                            shape_.Add(new CommodityMetalShape(item));
                            IDManager.SetID(shapeIDRef_, shape_[shape_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            shapeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        shape_.Add(new CommodityMetalShape(item));
                        }
                    }
                    else
                    {
                        shape_.Add(new CommodityMetalShape(item));
                    }
                }
            }
            
        
            XmlNodeList brandNodeList = xmlNode.SelectNodes("brand");
            
            if (brandNodeList != null)
            {
                this.brand_ = new List<CommodityMetalBrand>();
                foreach (XmlNode item in brandNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            brandIDRef_ = item.Attributes["id"].Value;
                            brand_.Add(new CommodityMetalBrand(item));
                            IDManager.SetID(brandIDRef_, brand_[brand_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            brandIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        brand_.Add(new CommodityMetalBrand(item));
                        }
                    }
                    else
                    {
                        brand_.Add(new CommodityMetalBrand(item));
                    }
                }
            }
            
        
            XmlNodeList gradeNodeList = xmlNode.SelectNodes("grade");
            
            if (gradeNodeList != null)
            {
                this.grade_ = new List<CommodityMetalGrade>();
                foreach (XmlNode item in gradeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            gradeIDRef_ = item.Attributes["id"].Value;
                            grade_.Add(new CommodityMetalGrade(item));
                            IDManager.SetID(gradeIDRef_, grade_[grade_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            gradeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        grade_.Add(new CommodityMetalGrade(item));
                        }
                    }
                    else
                    {
                        grade_.Add(new CommodityMetalGrade(item));
                    }
                }
            }
            
        
        }
        
    
        #region Material_
        private Material material_;
        public Material Material_
        {
            get
            {
                if (this.material_ != null)
                {
                    return this.material_; 
                }
                else if (this.materialIDRef_ != null)
                {
                    material_ = IDManager.getID(materialIDRef_) as Material;
                    return this.material_; 
                }
                else
                {
                      return this.material_; 
                }
            }
            set
            {
                if (this.material_ != value)
                {
                    this.material_ = value;
                }
            }
        }
        #endregion
        
        public string materialIDRef_ { get; set; }
        #region Shape_
        private List<CommodityMetalShape> shape_;
        public List<CommodityMetalShape> Shape_
        {
            get
            {
                if (this.shape_ != null)
                {
                    return this.shape_; 
                }
                else if (this.shapeIDRef_ != null)
                {
                    return this.shape_; 
                }
                else
                {
                      return this.shape_; 
                }
            }
            set
            {
                if (this.shape_ != value)
                {
                    this.shape_ = value;
                }
            }
        }
        #endregion
        
        public string shapeIDRef_ { get; set; }
        #region Brand_
        private List<CommodityMetalBrand> brand_;
        public List<CommodityMetalBrand> Brand_
        {
            get
            {
                if (this.brand_ != null)
                {
                    return this.brand_; 
                }
                else if (this.brandIDRef_ != null)
                {
                    return this.brand_; 
                }
                else
                {
                      return this.brand_; 
                }
            }
            set
            {
                if (this.brand_ != value)
                {
                    this.brand_ = value;
                }
            }
        }
        #endregion
        
        public string brandIDRef_ { get; set; }
        #region Grade_
        private List<CommodityMetalGrade> grade_;
        public List<CommodityMetalGrade> Grade_
        {
            get
            {
                if (this.grade_ != null)
                {
                    return this.grade_; 
                }
                else if (this.gradeIDRef_ != null)
                {
                    return this.grade_; 
                }
                else
                {
                      return this.grade_; 
                }
            }
            set
            {
                if (this.grade_ != value)
                {
                    this.grade_ = value;
                }
            }
        }
        #endregion
        
        public string gradeIDRef_ { get; set; }
        
    
        
    
    }
    
}

