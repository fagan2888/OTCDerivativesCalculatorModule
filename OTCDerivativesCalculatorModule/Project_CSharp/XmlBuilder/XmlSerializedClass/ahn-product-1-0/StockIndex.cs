using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StockIndex : ISerialized
    {
        public StockIndex(XmlNode xmlNode)
        {
            XmlNode codeNode = xmlNode.SelectSingleNode("code");
            
            if (codeNode != null)
            {
                if (codeNode.Attributes["href"] != null || codeNode.Attributes["id"] != null) 
                {
                    if (codeNode.Attributes["id"] != null) 
                    {
                        codeIDRef_ = codeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(codeNode);
                        IDManager.SetID(codeIDRef_, ob);
                    }
                    else if (codeNode.Attributes["href"] != null)
                    {
                        codeIDRef_ = codeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        code_ = new XsdTypeToken(codeNode);
                    }
                }
                else
                {
                    code_ = new XsdTypeToken(codeNode);
                }
            }
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode indexTypeNode = xmlNode.SelectSingleNode("indexType");
            
            if (indexTypeNode != null)
            {
                if (indexTypeNode.Attributes["href"] != null || indexTypeNode.Attributes["id"] != null) 
                {
                    if (indexTypeNode.Attributes["id"] != null) 
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(indexTypeNode);
                        IDManager.SetID(indexTypeIDRef_, ob);
                    }
                    else if (indexTypeNode.Attributes["href"] != null)
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexType_ = new XsdTypeToken(indexTypeNode);
                    }
                }
                else
                {
                    indexType_ = new XsdTypeToken(indexTypeNode);
                }
            }
            
        
            XmlNode businessDayConventionNode = xmlNode.SelectSingleNode("businessDayConvention");
            
            if (businessDayConventionNode != null)
            {
                if (businessDayConventionNode.Attributes["href"] != null || businessDayConventionNode.Attributes["id"] != null) 
                {
                    if (businessDayConventionNode.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["id"].Value;
                        BusinessDayConventionEnum ob = new BusinessDayConventionEnum(businessDayConventionNode);
                        IDManager.SetID(businessDayConventionIDRef_, ob);
                    }
                    else if (businessDayConventionNode.Attributes["href"] != null)
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                    }
                }
                else
                {
                    businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                }
            }
            
        
            XmlNode endOfMonthNode = xmlNode.SelectSingleNode("endOfMonth");
            
            if (endOfMonthNode != null)
            {
                if (endOfMonthNode.Attributes["href"] != null || endOfMonthNode.Attributes["id"] != null) 
                {
                    if (endOfMonthNode.Attributes["id"] != null) 
                    {
                        endOfMonthIDRef_ = endOfMonthNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(endOfMonthNode);
                        IDManager.SetID(endOfMonthIDRef_, ob);
                    }
                    else if (endOfMonthNode.Attributes["href"] != null)
                    {
                        endOfMonthIDRef_ = endOfMonthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endOfMonth_ = new XsdTypeBoolean(endOfMonthNode);
                    }
                }
                else
                {
                    endOfMonth_ = new XsdTypeBoolean(endOfMonthNode);
                }
            }
            
        
            XmlNode dayCounterNode = xmlNode.SelectSingleNode("dayCounter");
            
            if (dayCounterNode != null)
            {
                if (dayCounterNode.Attributes["href"] != null || dayCounterNode.Attributes["id"] != null) 
                {
                    if (dayCounterNode.Attributes["id"] != null) 
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayCounterNode);
                        IDManager.SetID(dayCounterIDRef_, ob);
                    }
                    else if (dayCounterNode.Attributes["href"] != null)
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCounter_ = new XsdTypeToken(dayCounterNode);
                    }
                }
                else
                {
                    dayCounter_ = new XsdTypeToken(dayCounterNode);
                }
            }
            
        
        }
        
    
        #region Code_
        private XsdTypeToken code_;
        public XsdTypeToken Code_
        {
            get
            {
                if (this.code_ != null)
                {
                    return this.code_; 
                }
                else if (this.codeIDRef_ != null)
                {
                    code_ = IDManager.getID(codeIDRef_) as XsdTypeToken;
                    return this.code_; 
                }
                else
                {
                      return this.code_; 
                }
            }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                }
            }
        }
        #endregion
        
        public string codeIDRef_ { get; set; }
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region IndexType_
        private XsdTypeToken indexType_;
        public XsdTypeToken IndexType_
        {
            get
            {
                if (this.indexType_ != null)
                {
                    return this.indexType_; 
                }
                else if (this.indexTypeIDRef_ != null)
                {
                    indexType_ = IDManager.getID(indexTypeIDRef_) as XsdTypeToken;
                    return this.indexType_; 
                }
                else
                {
                      return this.indexType_; 
                }
            }
            set
            {
                if (this.indexType_ != value)
                {
                    this.indexType_ = value;
                }
            }
        }
        #endregion
        
        public string indexTypeIDRef_ { get; set; }
        #region BusinessDayConvention_
        private BusinessDayConventionEnum businessDayConvention_;
        public BusinessDayConventionEnum BusinessDayConvention_
        {
            get
            {
                if (this.businessDayConvention_ != null)
                {
                    return this.businessDayConvention_; 
                }
                else if (this.businessDayConventionIDRef_ != null)
                {
                    businessDayConvention_ = IDManager.getID(businessDayConventionIDRef_) as BusinessDayConventionEnum;
                    return this.businessDayConvention_; 
                }
                else
                {
                      return this.businessDayConvention_; 
                }
            }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayConventionIDRef_ { get; set; }
        #region EndOfMonth_
        private XsdTypeBoolean endOfMonth_;
        public XsdTypeBoolean EndOfMonth_
        {
            get
            {
                if (this.endOfMonth_ != null)
                {
                    return this.endOfMonth_; 
                }
                else if (this.endOfMonthIDRef_ != null)
                {
                    endOfMonth_ = IDManager.getID(endOfMonthIDRef_) as XsdTypeBoolean;
                    return this.endOfMonth_; 
                }
                else
                {
                      return this.endOfMonth_; 
                }
            }
            set
            {
                if (this.endOfMonth_ != value)
                {
                    this.endOfMonth_ = value;
                }
            }
        }
        #endregion
        
        public string endOfMonthIDRef_ { get; set; }
        #region DayCounter_
        private XsdTypeToken dayCounter_;
        public XsdTypeToken DayCounter_
        {
            get
            {
                if (this.dayCounter_ != null)
                {
                    return this.dayCounter_; 
                }
                else if (this.dayCounterIDRef_ != null)
                {
                    dayCounter_ = IDManager.getID(dayCounterIDRef_) as XsdTypeToken;
                    return this.dayCounter_; 
                }
                else
                {
                      return this.dayCounter_; 
                }
            }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                }
            }
        }
        #endregion
        
        public string dayCounterIDRef_ { get; set; }
        
    
        
    
    }
    
}

