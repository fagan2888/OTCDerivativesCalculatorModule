using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PayoffBase
    {
        public PayoffBase(XmlNode xmlNode)
        {
            XmlNodeList payoffDateNodeList = xmlNode.SelectNodes("payoffDate");
            if (payoffDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payoffDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payoffDateIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(payoffDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payoffDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payoffDate = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList constPayoffNodeList = xmlNode.SelectNodes("constPayoff");
            if (constPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constPayoffIDRef = item.Attributes["id"].Name;
                        ConstPayoff ob = ConstPayoff();
                        IDManager.SetID(constPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constPayoff = new ConstPayoff(item);
                    }
                }
            }
            
        
            XmlNodeList nullPayoffNodeList = xmlNode.SelectNodes("nullPayoff");
            if (nullPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nullPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nullPayoffIDRef = item.Attributes["id"].Name;
                        NullPayoff ob = NullPayoff();
                        IDManager.SetID(nullPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nullPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nullPayoff = new NullPayoff(item);
                    }
                }
            }
            
        
            XmlNodeList averPayoffNodeList = xmlNode.SelectNodes("averPayoff");
            if (averPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averPayoffIDRef = item.Attributes["id"].Name;
                        AverPayoff ob = AverPayoff();
                        IDManager.SetID(averPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averPayoff = new AverPayoff(item);
                    }
                }
            }
            
        
            XmlNodeList exprPayoffNodeList = xmlNode.SelectNodes("exprPayoff");
            if (exprPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exprPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exprPayoffIDRef = item.Attributes["id"].Name;
                        ExprPayoff ob = ExprPayoff();
                        IDManager.SetID(exprPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exprPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exprPayoff = new ExprPayoff(item);
                    }
                }
            }
            
        
            XmlNodeList preFixPayoffNodeList = xmlNode.SelectNodes("preFixPayoff");
            if (preFixPayoffNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in preFixPayoffNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        preFixPayoffIDRef = item.Attributes["id"].Name;
                        PreFixPayoff ob = PreFixPayoff();
                        IDManager.SetID(preFixPayoffIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        preFixPayoffIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        preFixPayoff = new PreFixPayoff(item);
                    }
                }
            }
            
        
        }
        
    
        #region PayoffDate
        private XsdTypeToken payoffDate;
        public XsdTypeToken PayoffDate
        {
            get
            {
                if (this.payoffDate != null)
                {
                    return this.payoffDate; 
                }
                else if (this.payoffDateIDRef != null)
                {
                    payoffDate = IDManager.getID(payoffDateIDRef) as XsdTypeToken;
                    return this.payoffDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payoffDate != value)
                {
                    this.payoffDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region ConstPayoff
        private ConstPayoff constPayoff;
        public ConstPayoff ConstPayoff
        {
            get
            {
                if (this.constPayoff != null)
                {
                    return this.constPayoff; 
                }
                else if (this.constPayoffIDRef != null)
                {
                    constPayoff = IDManager.getID(constPayoffIDRef) as ConstPayoff;
                    return this.constPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constPayoff != value)
                {
                    this.constPayoff = value;
                }
            }
        }
        #endregion
        
        public string ConstPayoffIDRef { get; set; }
        #region NullPayoff
        private NullPayoff nullPayoff;
        public NullPayoff NullPayoff
        {
            get
            {
                if (this.nullPayoff != null)
                {
                    return this.nullPayoff; 
                }
                else if (this.nullPayoffIDRef != null)
                {
                    nullPayoff = IDManager.getID(nullPayoffIDRef) as NullPayoff;
                    return this.nullPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nullPayoff != value)
                {
                    this.nullPayoff = value;
                }
            }
        }
        #endregion
        
        public string NullPayoffIDRef { get; set; }
        #region AverPayoff
        private AverPayoff averPayoff;
        public AverPayoff AverPayoff
        {
            get
            {
                if (this.averPayoff != null)
                {
                    return this.averPayoff; 
                }
                else if (this.averPayoffIDRef != null)
                {
                    averPayoff = IDManager.getID(averPayoffIDRef) as AverPayoff;
                    return this.averPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averPayoff != value)
                {
                    this.averPayoff = value;
                }
            }
        }
        #endregion
        
        public string AverPayoffIDRef { get; set; }
        #region ExprPayoff
        private ExprPayoff exprPayoff;
        public ExprPayoff ExprPayoff
        {
            get
            {
                if (this.exprPayoff != null)
                {
                    return this.exprPayoff; 
                }
                else if (this.exprPayoffIDRef != null)
                {
                    exprPayoff = IDManager.getID(exprPayoffIDRef) as ExprPayoff;
                    return this.exprPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exprPayoff != value)
                {
                    this.exprPayoff = value;
                }
            }
        }
        #endregion
        
        public string ExprPayoffIDRef { get; set; }
        #region PreFixPayoff
        private PreFixPayoff preFixPayoff;
        public PreFixPayoff PreFixPayoff
        {
            get
            {
                if (this.preFixPayoff != null)
                {
                    return this.preFixPayoff; 
                }
                else if (this.preFixPayoffIDRef != null)
                {
                    preFixPayoff = IDManager.getID(preFixPayoffIDRef) as PreFixPayoff;
                    return this.preFixPayoff; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.preFixPayoff != value)
                {
                    this.preFixPayoff = value;
                }
            }
        }
        #endregion
        
        public string PreFixPayoffIDRef { get; set; }
        public string choiceStr_pcType;
        
    
        
    
    }
    
}

