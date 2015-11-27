using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentType : ISerialized
    {
        public InstrumentType(XmlNode xmlNode)
        {
            XmlNode classificationNode = xmlNode.SelectSingleNode("classification");
            
            if (classificationNode != null)
            {
                if (classificationNode.Attributes["href"] != null || classificationNode.Attributes["id"] != null) 
                {
                    if (classificationNode.Attributes["id"] != null) 
                    {
                        classificationIDRef_ = classificationNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(classificationNode);
                        IDManager.SetID(classificationIDRef_, ob);
                    }
                    else if (classificationNode.Attributes["href"] != null)
                    {
                        classificationIDRef_ = classificationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        classification_ = new XsdTypeToken(classificationNode);
                    }
                }
                else
                {
                    classification_ = new XsdTypeToken(classificationNode);
                }
            }
            
        
        }
        
    
        #region Classification_
        private XsdTypeToken classification_;
        public XsdTypeToken Classification_
        {
            get
            {
                if (this.classification_ != null)
                {
                    return this.classification_; 
                }
                else if (this.classificationIDRef_ != null)
                {
                    classification_ = IDManager.getID(classificationIDRef_) as XsdTypeToken;
                    return this.classification_; 
                }
                else
                {
                      return this.classification_; 
                }
            }
            set
            {
                if (this.classification_ != value)
                {
                    this.classification_ = value;
                }
            }
        }
        #endregion
        
        public string classificationIDRef_ { get; set; }
        
    
        
    
    }
    
}

