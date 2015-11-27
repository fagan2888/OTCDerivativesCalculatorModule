using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StubCalculationPeriodAmount
    {
        public StubCalculationPeriodAmount(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            if (calculationPeriodDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodDatesReference ob = CalculationPeriodDatesReference();
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDatesReference = new CalculationPeriodDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList initialStubNodeList = xmlNode.SelectNodes("initialStub");
            if (initialStubNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialStubNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialStubIDRef = item.Attributes["id"].Name;
                        StubValue ob = StubValue();
                        IDManager.SetID(initialStubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialStubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialStub = new StubValue(item);
                    }
                }
            }
            
        
            XmlNodeList finalStubNodeList = xmlNode.SelectNodes("finalStub");
            if (finalStubNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in finalStubNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        finalStubIDRef = item.Attributes["id"].Name;
                        StubValue ob = StubValue();
                        IDManager.SetID(finalStubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finalStubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finalStub = new StubValue(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference
        private CalculationPeriodDatesReference calculationPeriodDatesReference;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference
        {
            get
            {
                if (this.calculationPeriodDatesReference != null)
                {
                    return this.calculationPeriodDatesReference; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef != null)
                {
                    calculationPeriodDatesReference = IDManager.getID(calculationPeriodDatesReferenceIDRef) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference != value)
                {
                    this.calculationPeriodDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodDatesReferenceIDRef { get; set; }
        #region InitialStub
        private StubValue initialStub;
        public StubValue InitialStub
        {
            get
            {
                if (this.initialStub != null)
                {
                    return this.initialStub; 
                }
                else if (this.initialStubIDRef != null)
                {
                    initialStub = IDManager.getID(initialStubIDRef) as StubValue;
                    return this.initialStub; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialStub != value)
                {
                    this.initialStub = value;
                }
            }
        }
        #endregion
        
        public string StubValueIDRef { get; set; }
        #region FinalStub
        private StubValue finalStub;
        public StubValue FinalStub
        {
            get
            {
                if (this.finalStub != null)
                {
                    return this.finalStub; 
                }
                else if (this.finalStubIDRef != null)
                {
                    finalStub = IDManager.getID(finalStubIDRef) as StubValue;
                    return this.finalStub; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.finalStub != value)
                {
                    this.finalStub = value;
                }
            }
        }
        #endregion
        
        public string StubValueIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

