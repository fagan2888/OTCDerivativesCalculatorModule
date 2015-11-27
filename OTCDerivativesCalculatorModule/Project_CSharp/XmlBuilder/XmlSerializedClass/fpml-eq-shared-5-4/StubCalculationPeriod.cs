using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StubCalculationPeriod : ISerialized
    {
        public StubCalculationPeriod(XmlNode xmlNode)
        {
            XmlNode initialStubNode = xmlNode.SelectSingleNode("initialStub");
            
            if (initialStubNode != null)
            {
                if (initialStubNode.Attributes["href"] != null || initialStubNode.Attributes["id"] != null) 
                {
                    if (initialStubNode.Attributes["id"] != null) 
                    {
                        initialStubIDRef_ = initialStubNode.Attributes["id"].Value;
                        Stub ob = new Stub(initialStubNode);
                        IDManager.SetID(initialStubIDRef_, ob);
                    }
                    else if (initialStubNode.Attributes["href"] != null)
                    {
                        initialStubIDRef_ = initialStubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialStub_ = new Stub(initialStubNode);
                    }
                }
                else
                {
                    initialStub_ = new Stub(initialStubNode);
                }
            }
            
        
            XmlNode finalStubNode = xmlNode.SelectSingleNode("finalStub");
            
            if (finalStubNode != null)
            {
                if (finalStubNode.Attributes["href"] != null || finalStubNode.Attributes["id"] != null) 
                {
                    if (finalStubNode.Attributes["id"] != null) 
                    {
                        finalStubIDRef_ = finalStubNode.Attributes["id"].Value;
                        Stub ob = new Stub(finalStubNode);
                        IDManager.SetID(finalStubIDRef_, ob);
                    }
                    else if (finalStubNode.Attributes["href"] != null)
                    {
                        finalStubIDRef_ = finalStubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finalStub_ = new Stub(finalStubNode);
                    }
                }
                else
                {
                    finalStub_ = new Stub(finalStubNode);
                }
            }
            
        
        }
        
    
        #region InitialStub_
        private Stub initialStub_;
        public Stub InitialStub_
        {
            get
            {
                if (this.initialStub_ != null)
                {
                    return this.initialStub_; 
                }
                else if (this.initialStubIDRef_ != null)
                {
                    initialStub_ = IDManager.getID(initialStubIDRef_) as Stub;
                    return this.initialStub_; 
                }
                else
                {
                      return this.initialStub_; 
                }
            }
            set
            {
                if (this.initialStub_ != value)
                {
                    this.initialStub_ = value;
                }
            }
        }
        #endregion
        
        public string initialStubIDRef_ { get; set; }
        #region FinalStub_
        private Stub finalStub_;
        public Stub FinalStub_
        {
            get
            {
                if (this.finalStub_ != null)
                {
                    return this.finalStub_; 
                }
                else if (this.finalStubIDRef_ != null)
                {
                    finalStub_ = IDManager.getID(finalStubIDRef_) as Stub;
                    return this.finalStub_; 
                }
                else
                {
                      return this.finalStub_; 
                }
            }
            set
            {
                if (this.finalStub_ != value)
                {
                    this.finalStub_ = value;
                }
            }
        }
        #endregion
        
        public string finalStubIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

