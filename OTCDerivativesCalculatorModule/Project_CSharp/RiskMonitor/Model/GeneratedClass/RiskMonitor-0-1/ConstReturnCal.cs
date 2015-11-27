using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConstReturnCal : ISerialized
    {
        public ConstReturnCal() { }
        public ConstReturnCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode constReturnNode = xmlNode.SelectSingleNode("constReturn");
            
            if (constReturnNode != null)
            {
                if (constReturnNode.Attributes["href"] != null || constReturnNode.Attributes["id"] != null) 
                {
                    if (constReturnNode.Attributes["id"] != null) 
                    {
                        constReturnIDRef_ = constReturnNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(constReturnNode);
                        IDManager.SetID(constReturnIDRef_, ob);
                    }
                    else if (constReturnNode.Attributes["href"] != null)
                    {
                        constReturnIDRef_ = constReturnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constReturn_ = new XsdTypeDouble(constReturnNode);
                    }
                }
                else
                {
                    constReturn_ = new XsdTypeDouble(constReturnNode);
                }
            }
            
        
        }
        
    
        #region ConstReturn_
        private XsdTypeDouble constReturn_;
        public XsdTypeDouble ConstReturn_
        {
            get
            {
                if (this.constReturn_ != null)
                {
                    return this.constReturn_; 
                }
                else if (this.constReturnIDRef_ != null)
                {
                    constReturn_ = IDManager.getID(constReturnIDRef_) as XsdTypeDouble;
                    return this.constReturn_; 
                }
                else
                {
                    throw new Exception( "constReturn_Node no exist!");
                }
            }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                }
            }
        }
        #endregion
        
        public string constReturnIDRef_ { get; set; }
        
    
        
    
    }
    
}

