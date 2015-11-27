using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexCalculation : ISerialized
    {
        public IndexCalculation(XmlNode xmlNode)
        {
            XmlNode timeTypeNode = xmlNode.SelectSingleNode("timeType");
            
            if (timeTypeNode != null)
            {
                if (timeTypeNode.Attributes["href"] != null || timeTypeNode.Attributes["id"] != null) 
                {
                    if (timeTypeNode.Attributes["id"] != null) 
                    {
                        timeTypeIDRef_ = timeTypeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(timeTypeNode);
                        IDManager.SetID(timeTypeIDRef_, ob);
                    }
                    else if (timeTypeNode.Attributes["href"] != null)
                    {
                        timeTypeIDRef_ = timeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        timeType_ = new XsdTypeBoolean(timeTypeNode);
                    }
                }
                else
                {
                    timeType_ = new XsdTypeBoolean(timeTypeNode);
                }
            }
            
        
            XmlNode returnNode = xmlNode.SelectSingleNode("return");
            
            if (returnNode != null)
            {
                if (returnNode.Attributes["href"] != null || returnNode.Attributes["id"] != null) 
                {
                    if (returnNode.Attributes["id"] != null) 
                    {
                        returnIDRef_ = returnNode.Attributes["id"].Value;
                        ReturnTran ob = new ReturnTran(returnNode);
                        IDManager.SetID(returnIDRef_, ob);
                    }
                    else if (returnNode.Attributes["href"] != null)
                    {
                        returnIDRef_ = returnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        return_ = new ReturnTran(returnNode);
                    }
                }
                else
                {
                    return_ = new ReturnTran(returnNode);
                }
            }
            
        
            XmlNode minimumNode = xmlNode.SelectSingleNode("minimum");
            
            if (minimumNode != null)
            {
                if (minimumNode.Attributes["href"] != null || minimumNode.Attributes["id"] != null) 
                {
                    if (minimumNode.Attributes["id"] != null) 
                    {
                        minimumIDRef_ = minimumNode.Attributes["id"].Value;
                        MinimumTran ob = new MinimumTran(minimumNode);
                        IDManager.SetID(minimumIDRef_, ob);
                    }
                    else if (minimumNode.Attributes["href"] != null)
                    {
                        minimumIDRef_ = minimumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimum_ = new MinimumTran(minimumNode);
                    }
                }
                else
                {
                    minimum_ = new MinimumTran(minimumNode);
                }
            }
            
        
            XmlNode basketAverNode = xmlNode.SelectSingleNode("basketAver");
            
            if (basketAverNode != null)
            {
                if (basketAverNode.Attributes["href"] != null || basketAverNode.Attributes["id"] != null) 
                {
                    if (basketAverNode.Attributes["id"] != null) 
                    {
                        basketAverIDRef_ = basketAverNode.Attributes["id"].Value;
                        BasketAver ob = new BasketAver(basketAverNode);
                        IDManager.SetID(basketAverIDRef_, ob);
                    }
                    else if (basketAverNode.Attributes["href"] != null)
                    {
                        basketAverIDRef_ = basketAverNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketAver_ = new BasketAver(basketAverNode);
                    }
                }
                else
                {
                    basketAver_ = new BasketAver(basketAverNode);
                }
            }
            
        
        }
        
    
        #region TimeType_
        private XsdTypeBoolean timeType_;
        public XsdTypeBoolean TimeType_
        {
            get
            {
                if (this.timeType_ != null)
                {
                    return this.timeType_; 
                }
                else if (this.timeTypeIDRef_ != null)
                {
                    timeType_ = IDManager.getID(timeTypeIDRef_) as XsdTypeBoolean;
                    return this.timeType_; 
                }
                else
                {
                      return this.timeType_; 
                }
            }
            set
            {
                if (this.timeType_ != value)
                {
                    this.timeType_ = value;
                }
            }
        }
        #endregion
        
        public string timeTypeIDRef_ { get; set; }
        #region Return_
        private ReturnTran return_;
        public ReturnTran Return_
        {
            get
            {
                if (this.return_ != null)
                {
                    return this.return_; 
                }
                else if (this.returnIDRef_ != null)
                {
                    return_ = IDManager.getID(returnIDRef_) as ReturnTran;
                    return this.return_; 
                }
                else
                {
                      return this.return_; 
                }
            }
            set
            {
                if (this.return_ != value)
                {
                    this.return_ = value;
                }
            }
        }
        #endregion
        
        public string returnIDRef_ { get; set; }
        #region Minimum_
        private MinimumTran minimum_;
        public MinimumTran Minimum_
        {
            get
            {
                if (this.minimum_ != null)
                {
                    return this.minimum_; 
                }
                else if (this.minimumIDRef_ != null)
                {
                    minimum_ = IDManager.getID(minimumIDRef_) as MinimumTran;
                    return this.minimum_; 
                }
                else
                {
                      return this.minimum_; 
                }
            }
            set
            {
                if (this.minimum_ != value)
                {
                    this.minimum_ = value;
                }
            }
        }
        #endregion
        
        public string minimumIDRef_ { get; set; }
        #region BasketAver_
        private BasketAver basketAver_;
        public BasketAver BasketAver_
        {
            get
            {
                if (this.basketAver_ != null)
                {
                    return this.basketAver_; 
                }
                else if (this.basketAverIDRef_ != null)
                {
                    basketAver_ = IDManager.getID(basketAverIDRef_) as BasketAver;
                    return this.basketAver_; 
                }
                else
                {
                      return this.basketAver_; 
                }
            }
            set
            {
                if (this.basketAver_ != value)
                {
                    this.basketAver_ = value;
                }
            }
        }
        #endregion
        
        public string basketAverIDRef_ { get; set; }
        public string choiceStr_tran;
        
    
        
    
    }
    
}

