using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Index : ExchangeTradedCalculatedPrice
    {
        public Index(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode futureIdNode = xmlNode.SelectSingleNode("futureId");
            
            if (futureIdNode != null)
            {
                if (futureIdNode.Attributes["href"] != null || futureIdNode.Attributes["id"] != null) 
                {
                    if (futureIdNode.Attributes["id"] != null) 
                    {
                        futureIdIDRef_ = futureIdNode.Attributes["id"].Value;
                        FutureId ob = new FutureId(futureIdNode);
                        IDManager.SetID(futureIdIDRef_, ob);
                    }
                    else if (futureIdNode.Attributes["href"] != null)
                    {
                        futureIdIDRef_ = futureIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        futureId_ = new FutureId(futureIdNode);
                    }
                }
                else
                {
                    futureId_ = new FutureId(futureIdNode);
                }
            }
            
        
        }
        
    
        #region FutureId_
        private FutureId futureId_;
        public FutureId FutureId_
        {
            get
            {
                if (this.futureId_ != null)
                {
                    return this.futureId_; 
                }
                else if (this.futureIdIDRef_ != null)
                {
                    futureId_ = IDManager.getID(futureIdIDRef_) as FutureId;
                    return this.futureId_; 
                }
                else
                {
                      return this.futureId_; 
                }
            }
            set
            {
                if (this.futureId_ != value)
                {
                    this.futureId_ = value;
                }
            }
        }
        #endregion
        
        public string futureIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

