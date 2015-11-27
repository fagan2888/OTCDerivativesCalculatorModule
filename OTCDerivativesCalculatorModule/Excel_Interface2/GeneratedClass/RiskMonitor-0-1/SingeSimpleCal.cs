using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SingeSimpleCal : ISerialized
    {
        public SingeSimpleCal() { }
        public SingeSimpleCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode pastOccNode = xmlNode.SelectSingleNode("pastOcc");
            
            if (pastOccNode != null)
            {
                if (pastOccNode.Attributes["href"] != null || pastOccNode.Attributes["id"] != null) 
                {
                    if (pastOccNode.Attributes["id"] != null) 
                    {
                        pastOccIDRef_ = pastOccNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(pastOccNode);
                        IDManager.SetID(pastOccIDRef_, ob);
                    }
                    else if (pastOccNode.Attributes["href"] != null)
                    {
                        pastOccIDRef_ = pastOccNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pastOcc_ = new XsdTypeBoolean(pastOccNode);
                    }
                }
                else
                {
                    pastOcc_ = new XsdTypeBoolean(pastOccNode);
                }
            }
            
        
        }
        
    
        #region PastOcc_
        private XsdTypeBoolean pastOcc_;
        public XsdTypeBoolean PastOcc_
        {
            get
            {
                if (this.pastOcc_ != null)
                {
                    return this.pastOcc_; 
                }
                else if (this.pastOccIDRef_ != null)
                {
                    pastOcc_ = IDManager.getID(pastOccIDRef_) as XsdTypeBoolean;
                    return this.pastOcc_; 
                }
                else
                {
                    throw new Exception( "pastOcc_Node no exist!");
                }
            }
            set
            {
                if (this.pastOcc_ != value)
                {
                    this.pastOcc_ = value;
                }
            }
        }
        #endregion
        
        public string pastOccIDRef_ { get; set; }
        
    
        
    
    }
    
}

