using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceInformationList : ISerialized
    {
        public Excel_referenceInformationList() { }
        public Excel_referenceInformationList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_referenceInformationNodeList = xmlNode.SelectNodes("excel_referenceInformation");
            
            if (excel_referenceInformationNodeList != null)
            {
                this.excel_referenceInformation_ = new List<Excel_referenceInformation>();
                foreach (XmlNode item in excel_referenceInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_referenceInformationIDRef_ = item.Attributes["id"].Value;
                            excel_referenceInformation_.Add(new Excel_referenceInformation(item));
                            IDManager.SetID(excel_referenceInformationIDRef_, excel_referenceInformation_[excel_referenceInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_referenceInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_referenceInformation_.Add(new Excel_referenceInformation(item));
                        }
                    }
                    else
                    {
                        excel_referenceInformation_.Add(new Excel_referenceInformation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_referenceInformation_
        private List<Excel_referenceInformation> excel_referenceInformation_;
        public List<Excel_referenceInformation> Excel_referenceInformation_
        {
            get
            {
                if (this.excel_referenceInformation_ != null)
                {
                    return this.excel_referenceInformation_; 
                }
                else if (this.excel_referenceInformationIDRef_ != null)
                {
                    return this.excel_referenceInformation_; 
                }
                else
                {
                    throw new Exception( "excel_referenceInformation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceInformation_ != value)
                {
                    this.excel_referenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}

