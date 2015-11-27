using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StubCalculationPeriodAmount : ISerialized
    {
        public StubCalculationPeriodAmount(XmlNode xmlNode)
        {
            XmlNode calculationPeriodDatesReferenceNode = xmlNode.SelectSingleNode("calculationPeriodDatesReference");
            
            if (calculationPeriodDatesReferenceNode != null)
            {
                if (calculationPeriodDatesReferenceNode.Attributes["href"] != null || calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["id"].Value;
                        CalculationPeriodDatesReference ob = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodDatesReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                }
            }
            
        
            XmlNode initialStubNode = xmlNode.SelectSingleNode("initialStub");
            
            if (initialStubNode != null)
            {
                if (initialStubNode.Attributes["href"] != null || initialStubNode.Attributes["id"] != null) 
                {
                    if (initialStubNode.Attributes["id"] != null) 
                    {
                        initialStubIDRef_ = initialStubNode.Attributes["id"].Value;
                        StubValue ob = new StubValue(initialStubNode);
                        IDManager.SetID(initialStubIDRef_, ob);
                    }
                    else if (initialStubNode.Attributes["href"] != null)
                    {
                        initialStubIDRef_ = initialStubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialStub_ = new StubValue(initialStubNode);
                    }
                }
                else
                {
                    initialStub_ = new StubValue(initialStubNode);
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
                        StubValue ob = new StubValue(finalStubNode);
                        IDManager.SetID(finalStubIDRef_, ob);
                    }
                    else if (finalStubNode.Attributes["href"] != null)
                    {
                        finalStubIDRef_ = finalStubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finalStub_ = new StubValue(finalStubNode);
                    }
                }
                else
                {
                    finalStub_ = new StubValue(finalStubNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference_
        private CalculationPeriodDatesReference calculationPeriodDatesReference_;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference_
        {
            get
            {
                if (this.calculationPeriodDatesReference_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef_ != null)
                {
                    calculationPeriodDatesReference_ = IDManager.getID(calculationPeriodDatesReferenceIDRef_) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference_ != value)
                {
                    this.calculationPeriodDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesReferenceIDRef_ { get; set; }
        #region InitialStub_
        private StubValue initialStub_;
        public StubValue InitialStub_
        {
            get
            {
                if (this.initialStub_ != null)
                {
                    return this.initialStub_; 
                }
                else if (this.initialStubIDRef_ != null)
                {
                    initialStub_ = IDManager.getID(initialStubIDRef_) as StubValue;
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
        private StubValue finalStub_;
        public StubValue FinalStub_
        {
            get
            {
                if (this.finalStub_ != null)
                {
                    return this.finalStub_; 
                }
                else if (this.finalStubIDRef_ != null)
                {
                    finalStub_ = IDManager.getID(finalStubIDRef_) as StubValue;
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

