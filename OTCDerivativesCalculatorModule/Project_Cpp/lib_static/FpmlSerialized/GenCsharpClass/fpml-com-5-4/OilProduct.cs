using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OilProduct
    {
        public OilProduct(XmlNode xmlNode)
        {
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        OilProductType ob = OilProductType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new OilProductType(item);
                    }
                }
            }
            
        
            XmlNodeList gradeNodeList = xmlNode.SelectNodes("grade");
            if (gradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in gradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gradeIDRef = item.Attributes["id"].Name;
                        CommodityProductGrade ob = CommodityProductGrade();
                        IDManager.SetID(gradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        grade = new CommodityProductGrade(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private OilProductType type;
        public OilProductType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as OilProductType;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string OilProductTypeIDRef { get; set; }
        #region Grade
        private CommodityProductGrade grade;
        public CommodityProductGrade Grade
        {
            get
            {
                if (this.grade != null)
                {
                    return this.grade; 
                }
                else if (this.gradeIDRef != null)
                {
                    grade = IDManager.getID(gradeIDRef) as CommodityProductGrade;
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
        
        public string CommodityProductGradeIDRef { get; set; }
        
    
        
    
    }
    
}

