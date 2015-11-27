using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IndexCalculation
    {
        public IndexCalculation(XmlNode xmlNode)
        {
            XmlNodeList timeTypeNodeList = xmlNode.SelectNodes("timeType");
            if (timeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timeTypeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(timeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        timeType = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList returnNodeList = xmlNode.SelectNodes("return");
            if (returnNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnIDRef = item.Attributes["id"].Name;
                        ReturnTran ob = ReturnTran();
                        IDManager.SetID(returnIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        return = new ReturnTran(item);
                    }
                }
            }
            
        
            XmlNodeList minimumNodeList = xmlNode.SelectNodes("minimum");
            if (minimumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumIDRef = item.Attributes["id"].Name;
                        MinimumTran ob = MinimumTran();
                        IDManager.SetID(minimumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimum = new MinimumTran(item);
                    }
                }
            }
            
        
            XmlNodeList basketAverNodeList = xmlNode.SelectNodes("basketAver");
            if (basketAverNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketAverNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketAverIDRef = item.Attributes["id"].Name;
                        BasketAver ob = BasketAver();
                        IDManager.SetID(basketAverIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketAverIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketAver = new BasketAver(item);
                    }
                }
            }
            
        
        }
        
    
        #region TimeType
        private XsdTypeBoolean timeType;
        public XsdTypeBoolean TimeType
        {
            get
            {
                if (this.timeType != null)
                {
                    return this.timeType; 
                }
                else if (this.timeTypeIDRef != null)
                {
                    timeType = IDManager.getID(timeTypeIDRef) as XsdTypeBoolean;
                    return this.timeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.timeType != value)
                {
                    this.timeType = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Return
        private ReturnTran return;
        public ReturnTran Return
        {
            get
            {
                if (this.return != null)
                {
                    return this.return; 
                }
                else if (this.returnIDRef != null)
                {
                    return = IDManager.getID(returnIDRef) as ReturnTran;
                    return this.return; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.return != value)
                {
                    this.return = value;
                }
            }
        }
        #endregion
        
        public string ReturnTranIDRef { get; set; }
        #region Minimum
        private MinimumTran minimum;
        public MinimumTran Minimum
        {
            get
            {
                if (this.minimum != null)
                {
                    return this.minimum; 
                }
                else if (this.minimumIDRef != null)
                {
                    minimum = IDManager.getID(minimumIDRef) as MinimumTran;
                    return this.minimum; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimum != value)
                {
                    this.minimum = value;
                }
            }
        }
        #endregion
        
        public string MinimumTranIDRef { get; set; }
        #region BasketAver
        private BasketAver basketAver;
        public BasketAver BasketAver
        {
            get
            {
                if (this.basketAver != null)
                {
                    return this.basketAver; 
                }
                else if (this.basketAverIDRef != null)
                {
                    basketAver = IDManager.getID(basketAverIDRef) as BasketAver;
                    return this.basketAver; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketAver != value)
                {
                    this.basketAver = value;
                }
            }
        }
        #endregion
        
        public string BasketAverIDRef { get; set; }
        public string choiceStr_tran;
        
    
        
    
    }
    
}

