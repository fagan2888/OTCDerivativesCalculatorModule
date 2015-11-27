using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StubCalculationPeriod
    {
        public StubCalculationPeriod(XmlNode xmlNode)
        {
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
                        Stub ob = Stub();
                        IDManager.SetID(initialStubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialStubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialStub = new Stub(item);
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
                        Stub ob = Stub();
                        IDManager.SetID(finalStubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finalStubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finalStub = new Stub(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialStub
        private Stub initialStub;
        public Stub InitialStub
        {
            get
            {
                if (this.initialStub != null)
                {
                    return this.initialStub; 
                }
                else if (this.initialStubIDRef != null)
                {
                    initialStub = IDManager.getID(initialStubIDRef) as Stub;
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
        
        public string StubIDRef { get; set; }
        #region FinalStub
        private Stub finalStub;
        public Stub FinalStub
        {
            get
            {
                if (this.finalStub != null)
                {
                    return this.finalStub; 
                }
                else if (this.finalStubIDRef != null)
                {
                    finalStub = IDManager.getID(finalStubIDRef) as Stub;
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
        
        public string StubIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

