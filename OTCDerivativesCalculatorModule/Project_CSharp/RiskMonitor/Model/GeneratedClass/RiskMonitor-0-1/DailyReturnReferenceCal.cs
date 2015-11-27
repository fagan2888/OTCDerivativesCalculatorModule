using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DailyReturnReferenceCal : ISerialized
    {
        public DailyReturnReferenceCal() { }
        public DailyReturnReferenceCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
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
        
    
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
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

