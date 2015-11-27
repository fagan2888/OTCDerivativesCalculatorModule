using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MinimumReferenceCal : ISerialized
    {
        public MinimumReferenceCal() { }
        public MinimumReferenceCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode nthNode = xmlNode.SelectSingleNode("nth");
            
            if (nthNode != null)
            {
                if (nthNode.Attributes["href"] != null || nthNode.Attributes["id"] != null) 
                {
                    if (nthNode.Attributes["id"] != null) 
                    {
                        nthIDRef_ = nthNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(nthNode);
                        IDManager.SetID(nthIDRef_, ob);
                    }
                    else if (nthNode.Attributes["href"] != null)
                    {
                        nthIDRef_ = nthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nth_ = new XsdTypeDouble(nthNode);
                    }
                }
                else
                {
                    nth_ = new XsdTypeDouble(nthNode);
                }
            }
            
        
            XmlNodeList selectedUnderNameNodeList = xmlNode.SelectNodes("selectedUnderName");
            
            if (selectedUnderNameNodeList != null)
            {
                this.selectedUnderName_ = new List<XsdTypeToken>();
                foreach (XmlNode item in selectedUnderNameNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            selectedUnderNameIDRef_ = item.Attributes["id"].Value;
                            selectedUnderName_.Add(new XsdTypeToken(item));
                            IDManager.SetID(selectedUnderNameIDRef_, selectedUnderName_[selectedUnderName_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            selectedUnderNameIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        selectedUnderName_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        selectedUnderName_.Add(new XsdTypeToken(item));
                    }
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
        
    
        #region Nth_
        private XsdTypeDouble nth_;
        public XsdTypeDouble Nth_
        {
            get
            {
                if (this.nth_ != null)
                {
                    return this.nth_; 
                }
                else if (this.nthIDRef_ != null)
                {
                    nth_ = IDManager.getID(nthIDRef_) as XsdTypeDouble;
                    return this.nth_; 
                }
                else
                {
                    throw new Exception( "nth_Node no exist!");
                }
            }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                }
            }
        }
        #endregion
        
        public string nthIDRef_ { get; set; }
        #region SelectedUnderName_
        private List<XsdTypeToken> selectedUnderName_;
        public List<XsdTypeToken> SelectedUnderName_
        {
            get
            {
                if (this.selectedUnderName_ != null)
                {
                    return this.selectedUnderName_; 
                }
                else if (this.selectedUnderNameIDRef_ != null)
                {
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

