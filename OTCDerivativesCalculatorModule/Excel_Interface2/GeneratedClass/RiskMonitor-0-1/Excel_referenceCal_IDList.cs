using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceCal_IDList : ISerialized
    {
        public Excel_referenceCal_IDList() { }
        public Excel_referenceCal_IDList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_referenceCal_IDNodeList = xmlNode.SelectNodes("excel_referenceCal_ID");
            
            if (excel_referenceCal_IDNodeList != null)
            {
                this.excel_referenceCal_ID_ = new List<Excel_referenceCal_ID>();
                foreach (XmlNode item in excel_referenceCal_IDNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_referenceCal_IDIDRef_ = item.Attributes["id"].Value;
                            excel_referenceCal_ID_.Add(new Excel_referenceCal_ID(item));
                            IDManager.SetID(excel_referenceCal_IDIDRef_, excel_referenceCal_ID_[excel_referenceCal_ID_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_referenceCal_IDIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_referenceCal_ID_.Add(new Excel_referenceCal_ID(item));
                        }
                    }
                    else
                    {
                        excel_referenceCal_ID_.Add(new Excel_referenceCal_ID(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_referenceCal_ID_
        private List<Excel_referenceCal_ID> excel_referenceCal_ID_;
        public List<Excel_referenceCal_ID> Excel_referenceCal_ID_
        {
            get
            {
                if (this.excel_referenceCal_ID_ != null)
                {
                    return this.excel_referenceCal_ID_; 
                }
                else if (this.excel_referenceCal_IDIDRef_ != null)
                {
                    return this.excel_referenceCal_ID_; 
                }
                else
                {
                    throw new Exception( "excel_referenceCal_ID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceCal_ID_ != value)
                {
                    this.excel_referenceCal_ID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceCal_IDIDRef_ { get; set; }
        
    
        
    
    }
    
}

