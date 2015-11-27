using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffDateInfo : ISerialized
    {
        public PayoffDateInfo() { }
        public PayoffDateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixingDateInfoNode = xmlNode.SelectSingleNode("fixingDateInfo");
            
            if (fixingDateInfoNode != null)
            {
                if (fixingDateInfoNode.Attributes["href"] != null || fixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (fixingDateInfoNode.Attributes["id"] != null) 
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["id"].Value;
                        FixingDateInfo ob = new FixingDateInfo(fixingDateInfoNode);
                        IDManager.SetID(fixingDateInfoIDRef_, ob);
                    }
                    else if (fixingDateInfoNode.Attributes["href"] != null)
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
                    }
                }
                else
                {
                    fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
                }
            }
            
        
        }
        
    
        #region FixingDateInfo_
        private FixingDateInfo fixingDateInfo_;
        public FixingDateInfo FixingDateInfo_
        {
            get
            {
                if (this.fixingDateInfo_ != null)
                {
                    return this.fixingDateInfo_; 
                }
                else if (this.fixingDateInfoIDRef_ != null)
                {
                    fixingDateInfo_ = IDManager.getID(fixingDateInfoIDRef_) as FixingDateInfo;
                    return this.fixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "fixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.fixingDateInfo_ != value)
                {
                    this.fixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

