using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BarrierDateInfo : ISerialized
    {
        public BarrierDateInfo() { }
        public BarrierDateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dateInformationNode = xmlNode.SelectSingleNode("dateInformation");
            
            if (dateInformationNode != null)
            {
                if (dateInformationNode.Attributes["href"] != null || dateInformationNode.Attributes["id"] != null) 
                {
                    if (dateInformationNode.Attributes["id"] != null) 
                    {
                        dateInformationIDRef_ = dateInformationNode.Attributes["id"].Value;
                        DateInformation ob = new DateInformation(dateInformationNode);
                        IDManager.SetID(dateInformationIDRef_, ob);
                    }
                    else if (dateInformationNode.Attributes["href"] != null)
                    {
                        dateInformationIDRef_ = dateInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateInformation_ = new DateInformation(dateInformationNode);
                    }
                }
                else
                {
                    dateInformation_ = new DateInformation(dateInformationNode);
                }
            }
            
        
        }
        
    
        #region DateInformation_
        private DateInformation dateInformation_;
        public DateInformation DateInformation_
        {
            get
            {
                if (this.dateInformation_ != null)
                {
                    return this.dateInformation_; 
                }
                else if (this.dateInformationIDRef_ != null)
                {
                    dateInformation_ = IDManager.getID(dateInformationIDRef_) as DateInformation;
                    return this.dateInformation_; 
                }
                else
                {
                    throw new Exception( "dateInformation_Node no exist!");
                }
            }
            set
            {
                if (this.dateInformation_ != value)
                {
                    this.dateInformation_ = value;
                }
            }
        }
        #endregion
        
        public string dateInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}

