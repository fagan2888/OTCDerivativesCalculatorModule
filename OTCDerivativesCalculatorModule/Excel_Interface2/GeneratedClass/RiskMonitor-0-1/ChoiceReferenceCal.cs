using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ChoiceReferenceCal : ISerialized
    {
        public ChoiceReferenceCal() { }
        public ChoiceReferenceCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode selectedUnderNameNode = xmlNode.SelectSingleNode("selectedUnderName");
            
            if (selectedUnderNameNode != null)
            {
                if (selectedUnderNameNode.Attributes["href"] != null || selectedUnderNameNode.Attributes["id"] != null) 
                {
                    if (selectedUnderNameNode.Attributes["id"] != null) 
                    {
                        selectedUnderNameIDRef_ = selectedUnderNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(selectedUnderNameNode);
                        IDManager.SetID(selectedUnderNameIDRef_, ob);
                    }
                    else if (selectedUnderNameNode.Attributes["href"] != null)
                    {
                        selectedUnderNameIDRef_ = selectedUnderNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        selectedUnderName_ = new XsdTypeToken(selectedUnderNameNode);
                    }
                }
                else
                {
                    selectedUnderName_ = new XsdTypeToken(selectedUnderNameNode);
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
        
    
        #region SelectedUnderName_
        private XsdTypeToken selectedUnderName_;
        public XsdTypeToken SelectedUnderName_
        {
            get
            {
                if (this.selectedUnderName_ != null)
                {
                    return this.selectedUnderName_; 
                }
                else if (this.selectedUnderNameIDRef_ != null)
                {
                    selectedUnderName_ = IDManager.getID(selectedUnderNameIDRef_) as XsdTypeToken;
                    return this.selectedUnderName_; 
                }
                else
                {
                    throw new Exception( "selectedUnderName_Node no exist!");
                }
            }
            set
            {
                if (this.selectedUnderName_ != value)
                {
                    this.selectedUnderName_ = value;
                }
            }
        }
        #endregion
        
        public string selectedUnderNameIDRef_ { get; set; }
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

