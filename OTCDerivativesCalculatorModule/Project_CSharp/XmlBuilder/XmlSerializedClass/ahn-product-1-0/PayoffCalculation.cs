using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffCalculation : ISerialized
    {
        public PayoffCalculation(XmlNode xmlNode)
        {
            XmlNode constPayoffNode = xmlNode.SelectSingleNode("constPayoff");
            
            if (constPayoffNode != null)
            {
                if (constPayoffNode.Attributes["href"] != null || constPayoffNode.Attributes["id"] != null) 
                {
                    if (constPayoffNode.Attributes["id"] != null) 
                    {
                        constPayoffIDRef_ = constPayoffNode.Attributes["id"].Value;
                        ConstPayoff ob = new ConstPayoff(constPayoffNode);
                        IDManager.SetID(constPayoffIDRef_, ob);
                    }
                    else if (constPayoffNode.Attributes["href"] != null)
                    {
                        constPayoffIDRef_ = constPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constPayoff_ = new ConstPayoff(constPayoffNode);
                    }
                }
                else
                {
                    constPayoff_ = new ConstPayoff(constPayoffNode);
                }
            }
            
        
            XmlNode nullPayoffNode = xmlNode.SelectSingleNode("nullPayoff");
            
            if (nullPayoffNode != null)
            {
                if (nullPayoffNode.Attributes["href"] != null || nullPayoffNode.Attributes["id"] != null) 
                {
                    if (nullPayoffNode.Attributes["id"] != null) 
                    {
                        nullPayoffIDRef_ = nullPayoffNode.Attributes["id"].Value;
                        NullPayoff ob = new NullPayoff(nullPayoffNode);
                        IDManager.SetID(nullPayoffIDRef_, ob);
                    }
                    else if (nullPayoffNode.Attributes["href"] != null)
                    {
                        nullPayoffIDRef_ = nullPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nullPayoff_ = new NullPayoff(nullPayoffNode);
                    }
                }
                else
                {
                    nullPayoff_ = new NullPayoff(nullPayoffNode);
                }
            }
            
        
            XmlNode averPayoffNode = xmlNode.SelectSingleNode("averPayoff");
            
            if (averPayoffNode != null)
            {
                if (averPayoffNode.Attributes["href"] != null || averPayoffNode.Attributes["id"] != null) 
                {
                    if (averPayoffNode.Attributes["id"] != null) 
                    {
                        averPayoffIDRef_ = averPayoffNode.Attributes["id"].Value;
                        AverPayoff ob = new AverPayoff(averPayoffNode);
                        IDManager.SetID(averPayoffIDRef_, ob);
                    }
                    else if (averPayoffNode.Attributes["href"] != null)
                    {
                        averPayoffIDRef_ = averPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averPayoff_ = new AverPayoff(averPayoffNode);
                    }
                }
                else
                {
                    averPayoff_ = new AverPayoff(averPayoffNode);
                }
            }
            
        
            XmlNode exprPayoffNode = xmlNode.SelectSingleNode("exprPayoff");
            
            if (exprPayoffNode != null)
            {
                if (exprPayoffNode.Attributes["href"] != null || exprPayoffNode.Attributes["id"] != null) 
                {
                    if (exprPayoffNode.Attributes["id"] != null) 
                    {
                        exprPayoffIDRef_ = exprPayoffNode.Attributes["id"].Value;
                        ExprPayoff ob = new ExprPayoff(exprPayoffNode);
                        IDManager.SetID(exprPayoffIDRef_, ob);
                    }
                    else if (exprPayoffNode.Attributes["href"] != null)
                    {
                        exprPayoffIDRef_ = exprPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exprPayoff_ = new ExprPayoff(exprPayoffNode);
                    }
                }
                else
                {
                    exprPayoff_ = new ExprPayoff(exprPayoffNode);
                }
            }
            
        
            XmlNode preFixPayoffNode = xmlNode.SelectSingleNode("preFixPayoff");
            
            if (preFixPayoffNode != null)
            {
                if (preFixPayoffNode.Attributes["href"] != null || preFixPayoffNode.Attributes["id"] != null) 
                {
                    if (preFixPayoffNode.Attributes["id"] != null) 
                    {
                        preFixPayoffIDRef_ = preFixPayoffNode.Attributes["id"].Value;
                        PreFixPayoff ob = new PreFixPayoff(preFixPayoffNode);
                        IDManager.SetID(preFixPayoffIDRef_, ob);
                    }
                    else if (preFixPayoffNode.Attributes["href"] != null)
                    {
                        preFixPayoffIDRef_ = preFixPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preFixPayoff_ = new PreFixPayoff(preFixPayoffNode);
                    }
                }
                else
                {
                    preFixPayoff_ = new PreFixPayoff(preFixPayoffNode);
                }
            }
            
        
        }
        
    
        #region ConstPayoff_
        private ConstPayoff constPayoff_;
        public ConstPayoff ConstPayoff_
        {
            get
            {
                if (this.constPayoff_ != null)
                {
                    return this.constPayoff_; 
                }
                else if (this.constPayoffIDRef_ != null)
                {
                    constPayoff_ = IDManager.getID(constPayoffIDRef_) as ConstPayoff;
                    return this.constPayoff_; 
                }
                else
                {
                      return this.constPayoff_; 
                }
            }
            set
            {
                if (this.constPayoff_ != value)
                {
                    this.constPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string constPayoffIDRef_ { get; set; }
        #region NullPayoff_
        private NullPayoff nullPayoff_;
        public NullPayoff NullPayoff_
        {
            get
            {
                if (this.nullPayoff_ != null)
                {
                    return this.nullPayoff_; 
                }
                else if (this.nullPayoffIDRef_ != null)
                {
                    nullPayoff_ = IDManager.getID(nullPayoffIDRef_) as NullPayoff;
                    return this.nullPayoff_; 
                }
                else
                {
                      return this.nullPayoff_; 
                }
            }
            set
            {
                if (this.nullPayoff_ != value)
                {
                    this.nullPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string nullPayoffIDRef_ { get; set; }
        #region AverPayoff_
        private AverPayoff averPayoff_;
        public AverPayoff AverPayoff_
        {
            get
            {
                if (this.averPayoff_ != null)
                {
                    return this.averPayoff_; 
                }
                else if (this.averPayoffIDRef_ != null)
                {
                    averPayoff_ = IDManager.getID(averPayoffIDRef_) as AverPayoff;
                    return this.averPayoff_; 
                }
                else
                {
                      return this.averPayoff_; 
                }
            }
            set
            {
                if (this.averPayoff_ != value)
                {
                    this.averPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string averPayoffIDRef_ { get; set; }
        #region ExprPayoff_
        private ExprPayoff exprPayoff_;
        public ExprPayoff ExprPayoff_
        {
            get
            {
                if (this.exprPayoff_ != null)
                {
                    return this.exprPayoff_; 
                }
                else if (this.exprPayoffIDRef_ != null)
                {
                    exprPayoff_ = IDManager.getID(exprPayoffIDRef_) as ExprPayoff;
                    return this.exprPayoff_; 
                }
                else
                {
                      return this.exprPayoff_; 
                }
            }
            set
            {
                if (this.exprPayoff_ != value)
                {
                    this.exprPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string exprPayoffIDRef_ { get; set; }
        #region PreFixPayoff_
        private PreFixPayoff preFixPayoff_;
        public PreFixPayoff PreFixPayoff_
        {
            get
            {
                if (this.preFixPayoff_ != null)
                {
                    return this.preFixPayoff_; 
                }
                else if (this.preFixPayoffIDRef_ != null)
                {
                    preFixPayoff_ = IDManager.getID(preFixPayoffIDRef_) as PreFixPayoff;
                    return this.preFixPayoff_; 
                }
                else
                {
                      return this.preFixPayoff_; 
                }
            }
            set
            {
                if (this.preFixPayoff_ != value)
                {
                    this.preFixPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string preFixPayoffIDRef_ { get; set; }
        public string choiceStr_pcType;
        
    
        
    
    }
    
}

