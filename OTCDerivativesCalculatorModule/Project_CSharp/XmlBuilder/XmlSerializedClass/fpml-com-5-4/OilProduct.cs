using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OilProduct : ISerialized
    {
        public OilProduct(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        OilProductType ob = new OilProductType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new OilProductType(typeNode);
                    }
                }
                else
                {
                    type_ = new OilProductType(typeNode);
                }
            }
            
        
            XmlNode gradeNode = xmlNode.SelectSingleNode("grade");
            
            if (gradeNode != null)
            {
                if (gradeNode.Attributes["href"] != null || gradeNode.Attributes["id"] != null) 
                {
                    if (gradeNode.Attributes["id"] != null) 
                    {
                        gradeIDRef_ = gradeNode.Attributes["id"].Value;
                        CommodityProductGrade ob = new CommodityProductGrade(gradeNode);
                        IDManager.SetID(gradeIDRef_, ob);
                    }
                    else if (gradeNode.Attributes["href"] != null)
                    {
                        gradeIDRef_ = gradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        grade_ = new CommodityProductGrade(gradeNode);
                    }
                }
                else
                {
                    grade_ = new CommodityProductGrade(gradeNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private OilProductType type_;
        public OilProductType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as OilProductType;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region Grade_
        private CommodityProductGrade grade_;
        public CommodityProductGrade Grade_
        {
            get
            {
                if (this.grade_ != null)
                {
                    return this.grade_; 
                }
                else if (this.gradeIDRef_ != null)
                {
                    grade_ = IDManager.getID(gradeIDRef_) as CommodityProductGrade;
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

