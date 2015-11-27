using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaSwapPayoff : ISerialized
    {
        public VanillaSwapPayoff() { }
        public VanillaSwapPayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode recieveSwapPartNode = xmlNode.SelectSingleNode("recieveSwapPart");
            
            if (recieveSwapPartNode != null)
            {
                if (recieveSwapPartNode.Attributes["href"] != null || recieveSwapPartNode.Attributes["id"] != null) 
                {
                    if (recieveSwapPartNode.Attributes["id"] != null) 
                    {
                        recieveSwapPartIDRef_ = recieveSwapPartNode.Attributes["id"].Value;
                        RecieveSwapPart ob = new RecieveSwapPart(recieveSwapPartNode);
                        IDManager.SetID(recieveSwapPartIDRef_, ob);
                    }
                    else if (recieveSwapPartNode.Attributes["href"] != null)
                    {
                        recieveSwapPartIDRef_ = recieveSwapPartNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recieveSwapPart_ = new RecieveSwapPart(recieveSwapPartNode);
                    }
                }
                else
                {
                    recieveSwapPart_ = new RecieveSwapPart(recieveSwapPartNode);
                }
            }
            
        
            XmlNode paySwapPartNode = xmlNode.SelectSingleNode("paySwapPart");
            
            if (paySwapPartNode != null)
            {
                if (paySwapPartNode.Attributes["href"] != null || paySwapPartNode.Attributes["id"] != null) 
                {
                    if (paySwapPartNode.Attributes["id"] != null) 
                    {
                        paySwapPartIDRef_ = paySwapPartNode.Attributes["id"].Value;
                        PaySwapPart ob = new PaySwapPart(paySwapPartNode);
                        IDManager.SetID(paySwapPartIDRef_, ob);
                    }
                    else if (paySwapPartNode.Attributes["href"] != null)
                    {
                        paySwapPartIDRef_ = paySwapPartNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paySwapPart_ = new PaySwapPart(paySwapPartNode);
                    }
                }
                else
                {
                    paySwapPart_ = new PaySwapPart(paySwapPartNode);
                }
            }
            
        
        }
        
    
        #region RecieveSwapPart_
        private RecieveSwapPart recieveSwapPart_;
        public RecieveSwapPart RecieveSwapPart_
        {
            get
            {
                if (this.recieveSwapPart_ != null)
                {
                    return this.recieveSwapPart_; 
                }
                else if (this.recieveSwapPartIDRef_ != null)
                {
                    recieveSwapPart_ = IDManager.getID(recieveSwapPartIDRef_) as RecieveSwapPart;
                    return this.recieveSwapPart_; 
                }
                else
                {
                    throw new Exception( "recieveSwapPart_Node no exist!");
                }
            }
            set
            {
                if (this.recieveSwapPart_ != value)
                {
                    this.recieveSwapPart_ = value;
                }
            }
        }
        #endregion
        
        public string recieveSwapPartIDRef_ { get; set; }
        #region PaySwapPart_
        private PaySwapPart paySwapPart_;
        public PaySwapPart PaySwapPart_
        {
            get
            {
                if (this.paySwapPart_ != null)
                {
                    return this.paySwapPart_; 
                }
                else if (this.paySwapPartIDRef_ != null)
                {
                    paySwapPart_ = IDManager.getID(paySwapPartIDRef_) as PaySwapPart;
                    return this.paySwapPart_; 
                }
                else
                {
                    throw new Exception( "paySwapPart_Node no exist!");
                }
            }
            set
            {
                if (this.paySwapPart_ != value)
                {
                    this.paySwapPart_ = value;
                }
            }
        }
        #endregion
        
        public string paySwapPartIDRef_ { get; set; }
        
    
        
    
    }
    
}

