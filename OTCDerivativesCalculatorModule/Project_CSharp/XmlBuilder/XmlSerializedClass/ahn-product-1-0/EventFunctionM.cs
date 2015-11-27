using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventFunctionM : ISerialized
    {
        public EventFunctionM(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode indexSymbolNode = xmlNode.SelectSingleNode("indexSymbol");
            
            if (indexSymbolNode != null)
            {
                if (indexSymbolNode.Attributes["href"] != null || indexSymbolNode.Attributes["id"] != null) 
                {
                    if (indexSymbolNode.Attributes["id"] != null) 
                    {
                        indexSymbolIDRef_ = indexSymbolNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(indexSymbolNode);
                        IDManager.SetID(indexSymbolIDRef_, ob);
                    }
                    else if (indexSymbolNode.Attributes["href"] != null)
                    {
                        indexSymbolIDRef_ = indexSymbolNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexSymbol_ = new XsdTypeToken(indexSymbolNode);
                    }
                }
                else
                {
                    indexSymbol_ = new XsdTypeToken(indexSymbolNode);
                }
            }
            
        
            XmlNode upEventCheckNode = xmlNode.SelectSingleNode("upEventCheck");
            
            if (upEventCheckNode != null)
            {
                if (upEventCheckNode.Attributes["href"] != null || upEventCheckNode.Attributes["id"] != null) 
                {
                    if (upEventCheckNode.Attributes["id"] != null) 
                    {
                        upEventCheckIDRef_ = upEventCheckNode.Attributes["id"].Value;
                        UpEventCheck ob = new UpEventCheck(upEventCheckNode);
                        IDManager.SetID(upEventCheckIDRef_, ob);
                    }
                    else if (upEventCheckNode.Attributes["href"] != null)
                    {
                        upEventCheckIDRef_ = upEventCheckNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upEventCheck_ = new UpEventCheck(upEventCheckNode);
                    }
                }
                else
                {
                    upEventCheck_ = new UpEventCheck(upEventCheckNode);
                }
            }
            
        
            XmlNode downEventCheckNode = xmlNode.SelectSingleNode("downEventCheck");
            
            if (downEventCheckNode != null)
            {
                if (downEventCheckNode.Attributes["href"] != null || downEventCheckNode.Attributes["id"] != null) 
                {
                    if (downEventCheckNode.Attributes["id"] != null) 
                    {
                        downEventCheckIDRef_ = downEventCheckNode.Attributes["id"].Value;
                        DownEventCheck ob = new DownEventCheck(downEventCheckNode);
                        IDManager.SetID(downEventCheckIDRef_, ob);
                    }
                    else if (downEventCheckNode.Attributes["href"] != null)
                    {
                        downEventCheckIDRef_ = downEventCheckNode.Attributes["href"].Value;
                    }
                    else
                    {
                        downEventCheck_ = new DownEventCheck(downEventCheckNode);
                    }
                }
                else
                {
                    downEventCheck_ = new DownEventCheck(downEventCheckNode);
                }
            }
            
        
            XmlNode updownEventCheckNode = xmlNode.SelectSingleNode("updownEventCheck");
            
            if (updownEventCheckNode != null)
            {
                if (updownEventCheckNode.Attributes["href"] != null || updownEventCheckNode.Attributes["id"] != null) 
                {
                    if (updownEventCheckNode.Attributes["id"] != null) 
                    {
                        updownEventCheckIDRef_ = updownEventCheckNode.Attributes["id"].Value;
                        UpDownEventCheck ob = new UpDownEventCheck(updownEventCheckNode);
                        IDManager.SetID(updownEventCheckIDRef_, ob);
                    }
                    else if (updownEventCheckNode.Attributes["href"] != null)
                    {
                        updownEventCheckIDRef_ = updownEventCheckNode.Attributes["href"].Value;
                    }
                    else
                    {
                        updownEventCheck_ = new UpDownEventCheck(updownEventCheckNode);
                    }
                }
                else
                {
                    updownEventCheck_ = new UpDownEventCheck(updownEventCheckNode);
                }
            }
            
        
            XmlNode rangeEventCheckNode = xmlNode.SelectSingleNode("rangeEventCheck");
            
            if (rangeEventCheckNode != null)
            {
                if (rangeEventCheckNode.Attributes["href"] != null || rangeEventCheckNode.Attributes["id"] != null) 
                {
                    if (rangeEventCheckNode.Attributes["id"] != null) 
                    {
                        rangeEventCheckIDRef_ = rangeEventCheckNode.Attributes["id"].Value;
                        RangeEventCheck ob = new RangeEventCheck(rangeEventCheckNode);
                        IDManager.SetID(rangeEventCheckIDRef_, ob);
                    }
                    else if (rangeEventCheckNode.Attributes["href"] != null)
                    {
                        rangeEventCheckIDRef_ = rangeEventCheckNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rangeEventCheck_ = new RangeEventCheck(rangeEventCheckNode);
                    }
                }
                else
                {
                    rangeEventCheck_ = new RangeEventCheck(rangeEventCheckNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region IndexSymbol_
        private XsdTypeToken indexSymbol_;
        public XsdTypeToken IndexSymbol_
        {
            get
            {
                if (this.indexSymbol_ != null)
                {
                    return this.indexSymbol_; 
                }
                else if (this.indexSymbolIDRef_ != null)
                {
                    indexSymbol_ = IDManager.getID(indexSymbolIDRef_) as XsdTypeToken;
                    return this.indexSymbol_; 
                }
                else
                {
                      return this.indexSymbol_; 
                }
            }
            set
            {
                if (this.indexSymbol_ != value)
                {
                    this.indexSymbol_ = value;
                }
            }
        }
        #endregion
        
        public string indexSymbolIDRef_ { get; set; }
        #region UpEventCheck_
        private UpEventCheck upEventCheck_;
        public UpEventCheck UpEventCheck_
        {
            get
            {
                if (this.upEventCheck_ != null)
                {
                    return this.upEventCheck_; 
                }
                else if (this.upEventCheckIDRef_ != null)
                {
                    upEventCheck_ = IDManager.getID(upEventCheckIDRef_) as UpEventCheck;
                    return this.upEventCheck_; 
                }
                else
                {
                      return this.upEventCheck_; 
                }
            }
            set
            {
                if (this.upEventCheck_ != value)
                {
                    this.upEventCheck_ = value;
                }
            }
        }
        #endregion
        
        public string upEventCheckIDRef_ { get; set; }
        #region DownEventCheck_
        private DownEventCheck downEventCheck_;
        public DownEventCheck DownEventCheck_
        {
            get
            {
                if (this.downEventCheck_ != null)
                {
                    return this.downEventCheck_; 
                }
                else if (this.downEventCheckIDRef_ != null)
                {
                    downEventCheck_ = IDManager.getID(downEventCheckIDRef_) as DownEventCheck;
                    return this.downEventCheck_; 
                }
                else
                {
                      return this.downEventCheck_; 
                }
            }
            set
            {
                if (this.downEventCheck_ != value)
                {
                    this.downEventCheck_ = value;
                }
            }
        }
        #endregion
        
        public string downEventCheckIDRef_ { get; set; }
        #region UpdownEventCheck_
        private UpDownEventCheck updownEventCheck_;
        public UpDownEventCheck UpdownEventCheck_
        {
            get
            {
                if (this.updownEventCheck_ != null)
                {
                    return this.updownEventCheck_; 
                }
                else if (this.updownEventCheckIDRef_ != null)
                {
                    updownEventCheck_ = IDManager.getID(updownEventCheckIDRef_) as UpDownEventCheck;
                    return this.updownEventCheck_; 
                }
                else
                {
                      return this.updownEventCheck_; 
                }
            }
            set
            {
                if (this.updownEventCheck_ != value)
                {
                    this.updownEventCheck_ = value;
                }
            }
        }
        #endregion
        
        public string updownEventCheckIDRef_ { get; set; }
        #region RangeEventCheck_
        private RangeEventCheck rangeEventCheck_;
        public RangeEventCheck RangeEventCheck_
        {
            get
            {
                if (this.rangeEventCheck_ != null)
                {
                    return this.rangeEventCheck_; 
                }
                else if (this.rangeEventCheckIDRef_ != null)
                {
                    rangeEventCheck_ = IDManager.getID(rangeEventCheckIDRef_) as RangeEventCheck;
                    return this.rangeEventCheck_; 
                }
                else
                {
                      return this.rangeEventCheck_; 
                }
            }
            set
            {
                if (this.rangeEventCheck_ != value)
                {
                    this.rangeEventCheck_ = value;
                }
            }
        }
        #endregion
        
        public string rangeEventCheckIDRef_ { get; set; }
        public string choiceStr_efType;
        
    
        
    
    }
    
}

