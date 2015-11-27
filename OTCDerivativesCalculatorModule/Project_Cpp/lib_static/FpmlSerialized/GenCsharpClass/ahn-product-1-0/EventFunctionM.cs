using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventFunctionM
    {
        public EventFunctionM(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList indexSymbolNodeList = xmlNode.SelectNodes("indexSymbol");
            if (indexSymbolNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexSymbolNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexSymbolIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(indexSymbolIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexSymbolIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexSymbol = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList upEventCheckNodeList = xmlNode.SelectNodes("upEventCheck");
            if (upEventCheckNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in upEventCheckNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        upEventCheckIDRef = item.Attributes["id"].Name;
                        UpEventCheck ob = UpEventCheck();
                        IDManager.SetID(upEventCheckIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        upEventCheckIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        upEventCheck = new UpEventCheck(item);
                    }
                }
            }
            
        
            XmlNodeList downEventCheckNodeList = xmlNode.SelectNodes("downEventCheck");
            if (downEventCheckNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in downEventCheckNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        downEventCheckIDRef = item.Attributes["id"].Name;
                        DownEventCheck ob = DownEventCheck();
                        IDManager.SetID(downEventCheckIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        downEventCheckIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        downEventCheck = new DownEventCheck(item);
                    }
                }
            }
            
        
            XmlNodeList updownEventCheckNodeList = xmlNode.SelectNodes("updownEventCheck");
            if (updownEventCheckNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in updownEventCheckNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        updownEventCheckIDRef = item.Attributes["id"].Name;
                        UpDownEventCheck ob = UpDownEventCheck();
                        IDManager.SetID(updownEventCheckIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        updownEventCheckIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        updownEventCheck = new UpDownEventCheck(item);
                    }
                }
            }
            
        
            XmlNodeList rangeEventCheckNodeList = xmlNode.SelectNodes("rangeEventCheck");
            if (rangeEventCheckNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rangeEventCheckNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rangeEventCheckIDRef = item.Attributes["id"].Name;
                        RangeEventCheck ob = RangeEventCheck();
                        IDManager.SetID(rangeEventCheckIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rangeEventCheckIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rangeEventCheck = new RangeEventCheck(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeToken name;
        public XsdTypeToken Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeToken;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region IndexSymbol
        private XsdTypeToken indexSymbol;
        public XsdTypeToken IndexSymbol
        {
            get
            {
                if (this.indexSymbol != null)
                {
                    return this.indexSymbol; 
                }
                else if (this.indexSymbolIDRef != null)
                {
                    indexSymbol = IDManager.getID(indexSymbolIDRef) as XsdTypeToken;
                    return this.indexSymbol; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexSymbol != value)
                {
                    this.indexSymbol = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region UpEventCheck
        private UpEventCheck upEventCheck;
        public UpEventCheck UpEventCheck
        {
            get
            {
                if (this.upEventCheck != null)
                {
                    return this.upEventCheck; 
                }
                else if (this.upEventCheckIDRef != null)
                {
                    upEventCheck = IDManager.getID(upEventCheckIDRef) as UpEventCheck;
                    return this.upEventCheck; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.upEventCheck != value)
                {
                    this.upEventCheck = value;
                }
            }
        }
        #endregion
        
        public string UpEventCheckIDRef { get; set; }
        #region DownEventCheck
        private DownEventCheck downEventCheck;
        public DownEventCheck DownEventCheck
        {
            get
            {
                if (this.downEventCheck != null)
                {
                    return this.downEventCheck; 
                }
                else if (this.downEventCheckIDRef != null)
                {
                    downEventCheck = IDManager.getID(downEventCheckIDRef) as DownEventCheck;
                    return this.downEventCheck; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.downEventCheck != value)
                {
                    this.downEventCheck = value;
                }
            }
        }
        #endregion
        
        public string DownEventCheckIDRef { get; set; }
        #region UpdownEventCheck
        private UpDownEventCheck updownEventCheck;
        public UpDownEventCheck UpdownEventCheck
        {
            get
            {
                if (this.updownEventCheck != null)
                {
                    return this.updownEventCheck; 
                }
                else if (this.updownEventCheckIDRef != null)
                {
                    updownEventCheck = IDManager.getID(updownEventCheckIDRef) as UpDownEventCheck;
                    return this.updownEventCheck; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.updownEventCheck != value)
                {
                    this.updownEventCheck = value;
                }
            }
        }
        #endregion
        
        public string UpDownEventCheckIDRef { get; set; }
        #region RangeEventCheck
        private RangeEventCheck rangeEventCheck;
        public RangeEventCheck RangeEventCheck
        {
            get
            {
                if (this.rangeEventCheck != null)
                {
                    return this.rangeEventCheck; 
                }
                else if (this.rangeEventCheckIDRef != null)
                {
                    rangeEventCheck = IDManager.getID(rangeEventCheckIDRef) as RangeEventCheck;
                    return this.rangeEventCheck; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rangeEventCheck != value)
                {
                    this.rangeEventCheck = value;
                }
            }
        }
        #endregion
        
        public string RangeEventCheckIDRef { get; set; }
        public string choiceStr_efType;
        
    
        
    
    }
    
}

