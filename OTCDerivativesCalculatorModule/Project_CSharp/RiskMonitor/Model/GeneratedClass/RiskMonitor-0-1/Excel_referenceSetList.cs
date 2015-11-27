using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceSetList : ISerialized
    {
        public Excel_referenceSetList() { }
        public Excel_referenceSetList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_referenceSetNodeList = xmlNode.SelectNodes("excel_referenceSet");
            
            if (excel_referenceSetNodeList != null)
            {
                this.excel_referenceSet_ = new List<Excel_referenceSet>();
                foreach (XmlNode item in excel_referenceSetNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_referenceSetIDRef_ = item.Attributes["id"].Value;
                            excel_referenceSet_.Add(new Excel_referenceSet(item));
                            IDManager.SetID(excel_referenceSetIDRef_, excel_referenceSet_[excel_referenceSet_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_referenceSetIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_referenceSet_.Add(new Excel_referenceSet(item));
                        }
                    }
                    else
                    {
                        excel_referenceSet_.Add(new Excel_referenceSet(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_referenceSet_
        private List<Excel_referenceSet> excel_referenceSet_;
        public List<Excel_referenceSet> Excel_referenceSet_
        {
            get
            {
                if (this.excel_referenceSet_ != null)
                {
                    return this.excel_referenceSet_; 
                }
                else if (this.excel_referenceSetIDRef_ != null)
                {
                    return this.excel_referenceSet_; 
                }
                else
                {
                    throw new Exception( "excel_referenceSet_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceSet_ != value)
                {
                    this.excel_referenceSet_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceSetIDRef_ { get; set; }
        
    
        
    
    }
    
}

