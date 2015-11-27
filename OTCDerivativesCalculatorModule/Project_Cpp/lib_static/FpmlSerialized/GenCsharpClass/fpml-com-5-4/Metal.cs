using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Metal
    {
        public Metal(XmlNode xmlNode)
        {
            XmlNodeList materialNodeList = xmlNode.SelectNodes("material");
            if (materialNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in materialNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        materialIDRef = item.Attributes["id"].Name;
                        Material ob = Material();
                        IDManager.SetID(materialIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        materialIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        material = new Material(item);
                    }
                }
            }
            
        
            XmlNodeList shapeNodeList = xmlNode.SelectNodes("shape");
            
            foreach (XmlNode item in shapeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shapeIDRef = item.Attributes["id"].Name;
                        List<CommodityMetalShape> ob = new List<CommodityMetalShape>();
                        ob.Add(new CommodityMetalShape(item));
                        IDManager.SetID(shapeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shapeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    shape.Add(new CommodityMetalShape(item));
                    }
                }
            }
            
        
            XmlNodeList brandNodeList = xmlNode.SelectNodes("brand");
            
            foreach (XmlNode item in brandNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brandIDRef = item.Attributes["id"].Name;
                        List<CommodityMetalBrand> ob = new List<CommodityMetalBrand>();
                        ob.Add(new CommodityMetalBrand(item));
                        IDManager.SetID(brandIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brandIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    brand.Add(new CommodityMetalBrand(item));
                    }
                }
            }
            
        
            XmlNodeList gradeNodeList = xmlNode.SelectNodes("grade");
            
            foreach (XmlNode item in gradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gradeIDRef = item.Attributes["id"].Name;
                        List<CommodityMetalGrade> ob = new List<CommodityMetalGrade>();
                        ob.Add(new CommodityMetalGrade(item));
                        IDManager.SetID(gradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    grade.Add(new CommodityMetalGrade(item));
                    }
                }
            }
            
        
        }
        
    
        #region Material
        private Material material;
        public Material Material
        {
            get
            {
                if (this.material != null)
                {
                    return this.material; 
                }
                else if (this.materialIDRef != null)
                {
                    material = IDManager.getID(materialIDRef) as Material;
                    return this.material; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.material != value)
                {
                    this.material = value;
                }
            }
        }
        #endregion
        
        public string MaterialIDRef { get; set; }
        #region Shape
        private List<CommodityMetalShape> shape;
        public List<CommodityMetalShape> Shape
        {
            get
            {
                if (this.shape != null)
                {
                    return this.shape; 
                }
                else if (this.shapeIDRef != null)
                {
                    shape = IDManager.getID(shapeIDRef) as List<CommodityMetalShape>;
                    return this.shape; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shape != value)
                {
                    this.shape = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalShapeIDRef { get; set; }
        #region Brand
        private List<CommodityMetalBrand> brand;
        public List<CommodityMetalBrand> Brand
        {
            get
            {
                if (this.brand != null)
                {
                    return this.brand; 
                }
                else if (this.brandIDRef != null)
                {
                    brand = IDManager.getID(brandIDRef) as List<CommodityMetalBrand>;
                    return this.brand; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brand != value)
                {
                    this.brand = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalBrandIDRef { get; set; }
        #region Grade
        private List<CommodityMetalGrade> grade;
        public List<CommodityMetalGrade> Grade
        {
            get
            {
                if (this.grade != null)
                {
                    return this.grade; 
                }
                else if (this.gradeIDRef != null)
                {
                    grade = IDManager.getID(gradeIDRef) as List<CommodityMetalGrade>;
                    return this.grade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.grade != value)
                {
                    this.grade = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalGradeIDRef { get; set; }
        
    
        
    
    }
    
}

