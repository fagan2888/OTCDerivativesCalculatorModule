using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MultipleExercise : ISerialized
    {
        public MultipleExercise(XmlNode xmlNode)
        {
            XmlNodeList notionalReferenceNodeList = xmlNode.SelectNodes("notionalReference");
            
            if (notionalReferenceNodeList != null)
            {
                this.notionalReference_ = new List<NotionalReference>();
                foreach (XmlNode item in notionalReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            notionalReferenceIDRef_ = item.Attributes["id"].Value;
                            notionalReference_.Add(new NotionalReference(item));
                            IDManager.SetID(notionalReferenceIDRef_, notionalReference_[notionalReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            notionalReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        notionalReference_.Add(new NotionalReference(item));
                        }
                    }
                    else
                    {
                        notionalReference_.Add(new NotionalReference(item));
                    }
                }
            }
            
        
            XmlNode integralMultipleAmountNode = xmlNode.SelectSingleNode("integralMultipleAmount");
            
            if (integralMultipleAmountNode != null)
            {
                if (integralMultipleAmountNode.Attributes["href"] != null || integralMultipleAmountNode.Attributes["id"] != null) 
                {
                    if (integralMultipleAmountNode.Attributes["id"] != null) 
                    {
                        integralMultipleAmountIDRef_ = integralMultipleAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(integralMultipleAmountNode);
                        IDManager.SetID(integralMultipleAmountIDRef_, ob);
                    }
                    else if (integralMultipleAmountNode.Attributes["href"] != null)
                    {
                        integralMultipleAmountIDRef_ = integralMultipleAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        integralMultipleAmount_ = new XsdTypeDecimal(integralMultipleAmountNode);
                    }
                }
                else
                {
                    integralMultipleAmount_ = new XsdTypeDecimal(integralMultipleAmountNode);
                }
            }
            
        
            XmlNode minimumNotionalAmountNode = xmlNode.SelectSingleNode("minimumNotionalAmount");
            
            if (minimumNotionalAmountNode != null)
            {
                if (minimumNotionalAmountNode.Attributes["href"] != null || minimumNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (minimumNotionalAmountNode.Attributes["id"] != null) 
                    {
                        minimumNotionalAmountIDRef_ = minimumNotionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(minimumNotionalAmountNode);
                        IDManager.SetID(minimumNotionalAmountIDRef_, ob);
                    }
                    else if (minimumNotionalAmountNode.Attributes["href"] != null)
                    {
                        minimumNotionalAmountIDRef_ = minimumNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumNotionalAmount_ = new XsdTypeDecimal(minimumNotionalAmountNode);
                    }
                }
                else
                {
                    minimumNotionalAmount_ = new XsdTypeDecimal(minimumNotionalAmountNode);
                }
            }
            
        
            XmlNode minimumNumberOfOptionsNode = xmlNode.SelectSingleNode("minimumNumberOfOptions");
            
            if (minimumNumberOfOptionsNode != null)
            {
                if (minimumNumberOfOptionsNode.Attributes["href"] != null || minimumNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (minimumNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(minimumNumberOfOptionsNode);
                        IDManager.SetID(minimumNumberOfOptionsIDRef_, ob);
                    }
                    else if (minimumNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumNumberOfOptions_ = new XsdTypeNonNegativeInteger(minimumNumberOfOptionsNode);
                    }
                }
                else
                {
                    minimumNumberOfOptions_ = new XsdTypeNonNegativeInteger(minimumNumberOfOptionsNode);
                }
            }
            
        
            XmlNode maximumNotionalAmountNode = xmlNode.SelectSingleNode("maximumNotionalAmount");
            
            if (maximumNotionalAmountNode != null)
            {
                if (maximumNotionalAmountNode.Attributes["href"] != null || maximumNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (maximumNotionalAmountNode.Attributes["id"] != null) 
                    {
                        maximumNotionalAmountIDRef_ = maximumNotionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(maximumNotionalAmountNode);
                        IDManager.SetID(maximumNotionalAmountIDRef_, ob);
                    }
                    else if (maximumNotionalAmountNode.Attributes["href"] != null)
                    {
                        maximumNotionalAmountIDRef_ = maximumNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumNotionalAmount_ = new XsdTypeDecimal(maximumNotionalAmountNode);
                    }
                }
                else
                {
                    maximumNotionalAmount_ = new XsdTypeDecimal(maximumNotionalAmountNode);
                }
            }
            
        
            XmlNode maximumNumberOfOptionsNode = xmlNode.SelectSingleNode("maximumNumberOfOptions");
            
            if (maximumNumberOfOptionsNode != null)
            {
                if (maximumNumberOfOptionsNode.Attributes["href"] != null || maximumNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (maximumNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                        IDManager.SetID(maximumNumberOfOptionsIDRef_, ob);
                    }
                    else if (maximumNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumNumberOfOptions_ = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                    }
                }
                else
                {
                    maximumNumberOfOptions_ = new NonNegativeDecimal(maximumNumberOfOptionsNode);
                }
            }
            
        
        }
        
    
        #region NotionalReference_
        private List<NotionalReference> notionalReference_;
        public List<NotionalReference> NotionalReference_
        {
            get
            {
                if (this.notionalReference_ != null)
                {
                    return this.notionalReference_; 
                }
                else if (this.notionalReferenceIDRef_ != null)
                {
                    return this.notionalReference_; 
                }
                else
                {
                      return this.notionalReference_; 
                }
            }
            set
            {
                if (this.notionalReference_ != value)
                {
                    this.notionalReference_ = value;
                }
            }
        }
        #endregion
        
        public string notionalReferenceIDRef_ { get; set; }
        #region IntegralMultipleAmount_
        private XsdTypeDecimal integralMultipleAmount_;
        public XsdTypeDecimal IntegralMultipleAmount_
        {
            get
            {
                if (this.integralMultipleAmount_ != null)
                {
                    return this.integralMultipleAmount_; 
                }
                else if (this.integralMultipleAmountIDRef_ != null)
                {
                    integralMultipleAmount_ = IDManager.getID(integralMultipleAmountIDRef_) as XsdTypeDecimal;
                    return this.integralMultipleAmount_; 
                }
                else
                {
                      return this.integralMultipleAmount_; 
                }
            }
            set
            {
                if (this.integralMultipleAmount_ != value)
                {
                    this.integralMultipleAmount_ = value;
                }
            }
        }
        #endregion
        
        public string integralMultipleAmountIDRef_ { get; set; }
        #region MinimumNotionalAmount_
        private XsdTypeDecimal minimumNotionalAmount_;
        public XsdTypeDecimal MinimumNotionalAmount_
        {
            get
            {
                if (this.minimumNotionalAmount_ != null)
                {
                    return this.minimumNotionalAmount_; 
                }
                else if (this.minimumNotionalAmountIDRef_ != null)
                {
                    minimumNotionalAmount_ = IDManager.getID(minimumNotionalAmountIDRef_) as XsdTypeDecimal;
                    return this.minimumNotionalAmount_; 
                }
                else
                {
                      return this.minimumNotionalAmount_; 
                }
            }
            set
            {
                if (this.minimumNotionalAmount_ != value)
                {
                    this.minimumNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string minimumNotionalAmountIDRef_ { get; set; }
        #region MinimumNumberOfOptions_
        private XsdTypeNonNegativeInteger minimumNumberOfOptions_;
        public XsdTypeNonNegativeInteger MinimumNumberOfOptions_
        {
            get
            {
                if (this.minimumNumberOfOptions_ != null)
                {
                    return this.minimumNumberOfOptions_; 
                }
                else if (this.minimumNumberOfOptionsIDRef_ != null)
                {
                    minimumNumberOfOptions_ = IDManager.getID(minimumNumberOfOptionsIDRef_) as XsdTypeNonNegativeInteger;
                    return this.minimumNumberOfOptions_; 
                }
                else
                {
                      return this.minimumNumberOfOptions_; 
                }
            }
            set
            {
                if (this.minimumNumberOfOptions_ != value)
                {
                    this.minimumNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string minimumNumberOfOptionsIDRef_ { get; set; }
        #region MaximumNotionalAmount_
        private XsdTypeDecimal maximumNotionalAmount_;
        public XsdTypeDecimal MaximumNotionalAmount_
        {
            get
            {
                if (this.maximumNotionalAmount_ != null)
                {
                    return this.maximumNotionalAmount_; 
                }
                else if (this.maximumNotionalAmountIDRef_ != null)
                {
                    maximumNotionalAmount_ = IDManager.getID(maximumNotionalAmountIDRef_) as XsdTypeDecimal;
                    return this.maximumNotionalAmount_; 
                }
                else
                {
                      return this.maximumNotionalAmount_; 
                }
            }
            set
            {
                if (this.maximumNotionalAmount_ != value)
                {
                    this.maximumNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string maximumNotionalAmountIDRef_ { get; set; }
        #region MaximumNumberOfOptions_
        private NonNegativeDecimal maximumNumberOfOptions_;
        public NonNegativeDecimal MaximumNumberOfOptions_
        {
            get
            {
                if (this.maximumNumberOfOptions_ != null)
                {
                    return this.maximumNumberOfOptions_; 
                }
                else if (this.maximumNumberOfOptionsIDRef_ != null)
                {
                    maximumNumberOfOptions_ = IDManager.getID(maximumNumberOfOptionsIDRef_) as NonNegativeDecimal;
                    return this.maximumNumberOfOptions_; 
                }
                else
                {
                      return this.maximumNumberOfOptions_; 
                }
            }
            set
            {
                if (this.maximumNumberOfOptions_ != value)
                {
                    this.maximumNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string maximumNumberOfOptionsIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

