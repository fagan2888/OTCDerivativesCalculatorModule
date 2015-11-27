using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapNotional : ISerialized
    {
        public ReturnSwapNotional(XmlNode xmlNode)
        {
            XmlNode relativeNotionalAmountNode = xmlNode.SelectSingleNode("relativeNotionalAmount");
            
            if (relativeNotionalAmountNode != null)
            {
                if (relativeNotionalAmountNode.Attributes["href"] != null || relativeNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (relativeNotionalAmountNode.Attributes["id"] != null) 
                    {
                        relativeNotionalAmountIDRef_ = relativeNotionalAmountNode.Attributes["id"].Value;
                        ReturnSwapNotionalAmountReference ob = new ReturnSwapNotionalAmountReference(relativeNotionalAmountNode);
                        IDManager.SetID(relativeNotionalAmountIDRef_, ob);
                    }
                    else if (relativeNotionalAmountNode.Attributes["href"] != null)
                    {
                        relativeNotionalAmountIDRef_ = relativeNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeNotionalAmount_ = new ReturnSwapNotionalAmountReference(relativeNotionalAmountNode);
                    }
                }
                else
                {
                    relativeNotionalAmount_ = new ReturnSwapNotionalAmountReference(relativeNotionalAmountNode);
                }
            }
            
        
            XmlNode relativeDeterminationMethodNode = xmlNode.SelectSingleNode("relativeDeterminationMethod");
            
            if (relativeDeterminationMethodNode != null)
            {
                if (relativeDeterminationMethodNode.Attributes["href"] != null || relativeDeterminationMethodNode.Attributes["id"] != null) 
                {
                    if (relativeDeterminationMethodNode.Attributes["id"] != null) 
                    {
                        relativeDeterminationMethodIDRef_ = relativeDeterminationMethodNode.Attributes["id"].Value;
                        DeterminationMethodReference ob = new DeterminationMethodReference(relativeDeterminationMethodNode);
                        IDManager.SetID(relativeDeterminationMethodIDRef_, ob);
                    }
                    else if (relativeDeterminationMethodNode.Attributes["href"] != null)
                    {
                        relativeDeterminationMethodIDRef_ = relativeDeterminationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDeterminationMethod_ = new DeterminationMethodReference(relativeDeterminationMethodNode);
                    }
                }
                else
                {
                    relativeDeterminationMethod_ = new DeterminationMethodReference(relativeDeterminationMethodNode);
                }
            }
            
        
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        NotionalAmount ob = new NotionalAmount(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new NotionalAmount(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new NotionalAmount(notionalAmountNode);
                }
            }
            
        
        }
        
    
        #region RelativeNotionalAmount_
        private ReturnSwapNotionalAmountReference relativeNotionalAmount_;
        public ReturnSwapNotionalAmountReference RelativeNotionalAmount_
        {
            get
            {
                if (this.relativeNotionalAmount_ != null)
                {
                    return this.relativeNotionalAmount_; 
                }
                else if (this.relativeNotionalAmountIDRef_ != null)
                {
                    relativeNotionalAmount_ = IDManager.getID(relativeNotionalAmountIDRef_) as ReturnSwapNotionalAmountReference;
                    return this.relativeNotionalAmount_; 
                }
                else
                {
                      return this.relativeNotionalAmount_; 
                }
            }
            set
            {
                if (this.relativeNotionalAmount_ != value)
                {
                    this.relativeNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string relativeNotionalAmountIDRef_ { get; set; }
        #region RelativeDeterminationMethod_
        private DeterminationMethodReference relativeDeterminationMethod_;
        public DeterminationMethodReference RelativeDeterminationMethod_
        {
            get
            {
                if (this.relativeDeterminationMethod_ != null)
                {
                    return this.relativeDeterminationMethod_; 
                }
                else if (this.relativeDeterminationMethodIDRef_ != null)
                {
                    relativeDeterminationMethod_ = IDManager.getID(relativeDeterminationMethodIDRef_) as DeterminationMethodReference;
                    return this.relativeDeterminationMethod_; 
                }
                else
                {
                      return this.relativeDeterminationMethod_; 
                }
            }
            set
            {
                if (this.relativeDeterminationMethod_ != value)
                {
                    this.relativeDeterminationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDeterminationMethodIDRef_ { get; set; }
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region NotionalAmount_
        private NotionalAmount notionalAmount_;
        public NotionalAmount NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as NotionalAmount;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

