using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapNotional
    {
        public ReturnSwapNotional(XmlNode xmlNode)
        {
            XmlNodeList relativeNotionalAmountNodeList = xmlNode.SelectNodes("relativeNotionalAmount");
            if (relativeNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeNotionalAmountIDRef = item.Attributes["id"].Name;
                        ReturnSwapNotionalAmountReference ob = ReturnSwapNotionalAmountReference();
                        IDManager.SetID(relativeNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeNotionalAmount = new ReturnSwapNotionalAmountReference(item);
                    }
                }
            }
            
        
            XmlNodeList relativeDeterminationMethodNodeList = xmlNode.SelectNodes("relativeDeterminationMethod");
            if (relativeDeterminationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDeterminationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDeterminationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethodReference ob = DeterminationMethodReference();
                        IDManager.SetID(relativeDeterminationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDeterminationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDeterminationMethod = new DeterminationMethodReference(item);
                    }
                }
            }
            
        
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        NotionalAmount ob = NotionalAmount();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new NotionalAmount(item);
                    }
                }
            }
            
        
        }
        
    
        #region RelativeNotionalAmount
        private ReturnSwapNotionalAmountReference relativeNotionalAmount;
        public ReturnSwapNotionalAmountReference RelativeNotionalAmount
        {
            get
            {
                if (this.relativeNotionalAmount != null)
                {
                    return this.relativeNotionalAmount; 
                }
                else if (this.relativeNotionalAmountIDRef != null)
                {
                    relativeNotionalAmount = IDManager.getID(relativeNotionalAmountIDRef) as ReturnSwapNotionalAmountReference;
                    return this.relativeNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeNotionalAmount != value)
                {
                    this.relativeNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapNotionalAmountReferenceIDRef { get; set; }
        #region RelativeDeterminationMethod
        private DeterminationMethodReference relativeDeterminationMethod;
        public DeterminationMethodReference RelativeDeterminationMethod
        {
            get
            {
                if (this.relativeDeterminationMethod != null)
                {
                    return this.relativeDeterminationMethod; 
                }
                else if (this.relativeDeterminationMethodIDRef != null)
                {
                    relativeDeterminationMethod = IDManager.getID(relativeDeterminationMethodIDRef) as DeterminationMethodReference;
                    return this.relativeDeterminationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDeterminationMethod != value)
                {
                    this.relativeDeterminationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodReferenceIDRef { get; set; }
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region NotionalAmount
        private NotionalAmount notionalAmount;
        public NotionalAmount NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as NotionalAmount;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NotionalAmountIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

