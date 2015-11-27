using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstPositionInfo : ISerialized
    {
        public InstPositionInfo() { }
        public InstPositionInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode instNameNode = xmlNode.SelectSingleNode("instName");
            
            if (instNameNode != null)
            {
                if (instNameNode.Attributes["href"] != null || instNameNode.Attributes["id"] != null) 
                {
                    if (instNameNode.Attributes["id"] != null) 
                    {
                        instNameIDRef_ = instNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(instNameNode);
                        IDManager.SetID(instNameIDRef_, ob);
                    }
                    else if (instNameNode.Attributes["href"] != null)
                    {
                        instNameIDRef_ = instNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instName_ = new XsdTypeToken(instNameNode);
                    }
                }
                else
                {
                    instName_ = new XsdTypeToken(instNameNode);
                }
            }
            
        
            XmlNode instCodeNode = xmlNode.SelectSingleNode("instCode");
            
            if (instCodeNode != null)
            {
                if (instCodeNode.Attributes["href"] != null || instCodeNode.Attributes["id"] != null) 
                {
                    if (instCodeNode.Attributes["id"] != null) 
                    {
                        instCodeIDRef_ = instCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(instCodeNode);
                        IDManager.SetID(instCodeIDRef_, ob);
                    }
                    else if (instCodeNode.Attributes["href"] != null)
                    {
                        instCodeIDRef_ = instCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instCode_ = new XsdTypeToken(instCodeNode);
                    }
                }
                else
                {
                    instCode_ = new XsdTypeToken(instCodeNode);
                }
            }
            
        
            XmlNode instTypeNode = xmlNode.SelectSingleNode("instType");
            
            if (instTypeNode != null)
            {
                if (instTypeNode.Attributes["href"] != null || instTypeNode.Attributes["id"] != null) 
                {
                    if (instTypeNode.Attributes["id"] != null) 
                    {
                        instTypeIDRef_ = instTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(instTypeNode);
                        IDManager.SetID(instTypeIDRef_, ob);
                    }
                    else if (instTypeNode.Attributes["href"] != null)
                    {
                        instTypeIDRef_ = instTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instType_ = new XsdTypeToken(instTypeNode);
                    }
                }
                else
                {
                    instType_ = new XsdTypeToken(instTypeNode);
                }
            }
            
        
            XmlNode bookedDateNode = xmlNode.SelectSingleNode("bookedDate");
            
            if (bookedDateNode != null)
            {
                if (bookedDateNode.Attributes["href"] != null || bookedDateNode.Attributes["id"] != null) 
                {
                    if (bookedDateNode.Attributes["id"] != null) 
                    {
                        bookedDateIDRef_ = bookedDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(bookedDateNode);
                        IDManager.SetID(bookedDateIDRef_, ob);
                    }
                    else if (bookedDateNode.Attributes["href"] != null)
                    {
                        bookedDateIDRef_ = bookedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bookedDate_ = new XsdTypeToken(bookedDateNode);
                    }
                }
                else
                {
                    bookedDate_ = new XsdTypeToken(bookedDateNode);
                }
            }
            
        
            XmlNode unBookedDateNode = xmlNode.SelectSingleNode("unBookedDate");
            
            if (unBookedDateNode != null)
            {
                if (unBookedDateNode.Attributes["href"] != null || unBookedDateNode.Attributes["id"] != null) 
                {
                    if (unBookedDateNode.Attributes["id"] != null) 
                    {
                        unBookedDateIDRef_ = unBookedDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(unBookedDateNode);
                        IDManager.SetID(unBookedDateIDRef_, ob);
                    }
                    else if (unBookedDateNode.Attributes["href"] != null)
                    {
                        unBookedDateIDRef_ = unBookedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unBookedDate_ = new XsdTypeToken(unBookedDateNode);
                    }
                }
                else
                {
                    unBookedDate_ = new XsdTypeToken(unBookedDateNode);
                }
            }
            
        
            XmlNode maturityDateNode = xmlNode.SelectSingleNode("maturityDate");
            
            if (maturityDateNode != null)
            {
                if (maturityDateNode.Attributes["href"] != null || maturityDateNode.Attributes["id"] != null) 
                {
                    if (maturityDateNode.Attributes["id"] != null) 
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new XsdTypeToken(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new XsdTypeToken(maturityDateNode);
                }
            }
            
        
            XmlNode fileNameNode = xmlNode.SelectSingleNode("fileName");
            
            if (fileNameNode != null)
            {
                if (fileNameNode.Attributes["href"] != null || fileNameNode.Attributes["id"] != null) 
                {
                    if (fileNameNode.Attributes["id"] != null) 
                    {
                        fileNameIDRef_ = fileNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fileNameNode);
                        IDManager.SetID(fileNameIDRef_, ob);
                    }
                    else if (fileNameNode.Attributes["href"] != null)
                    {
                        fileNameIDRef_ = fileNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fileName_ = new XsdTypeToken(fileNameNode);
                    }
                }
                else
                {
                    fileName_ = new XsdTypeToken(fileNameNode);
                }
            }
            
        
            XmlNode positionNameNode = xmlNode.SelectSingleNode("positionName");
            
            if (positionNameNode != null)
            {
                if (positionNameNode.Attributes["href"] != null || positionNameNode.Attributes["id"] != null) 
                {
                    if (positionNameNode.Attributes["id"] != null) 
                    {
                        positionNameIDRef_ = positionNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(positionNameNode);
                        IDManager.SetID(positionNameIDRef_, ob);
                    }
                    else if (positionNameNode.Attributes["href"] != null)
                    {
                        positionNameIDRef_ = positionNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        positionName_ = new XsdTypeToken(positionNameNode);
                    }
                }
                else
                {
                    positionName_ = new XsdTypeToken(positionNameNode);
                }
            }
            
        
            XmlNode counterPartyNode = xmlNode.SelectSingleNode("counterParty");
            
            if (counterPartyNode != null)
            {
                if (counterPartyNode.Attributes["href"] != null || counterPartyNode.Attributes["id"] != null) 
                {
                    if (counterPartyNode.Attributes["id"] != null) 
                    {
                        counterPartyIDRef_ = counterPartyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(counterPartyNode);
                        IDManager.SetID(counterPartyIDRef_, ob);
                    }
                    else if (counterPartyNode.Attributes["href"] != null)
                    {
                        counterPartyIDRef_ = counterPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        counterParty_ = new XsdTypeToken(counterPartyNode);
                    }
                }
                else
                {
                    counterParty_ = new XsdTypeToken(counterPartyNode);
                }
            }
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeToken(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeToken(notionalNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeToken(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeToken(currencyNode);
                }
            }
            
        
            XmlNode fundCodeNode = xmlNode.SelectSingleNode("fundCode");
            
            if (fundCodeNode != null)
            {
                if (fundCodeNode.Attributes["href"] != null || fundCodeNode.Attributes["id"] != null) 
                {
                    if (fundCodeNode.Attributes["id"] != null) 
                    {
                        fundCodeIDRef_ = fundCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fundCodeNode);
                        IDManager.SetID(fundCodeIDRef_, ob);
                    }
                    else if (fundCodeNode.Attributes["href"] != null)
                    {
                        fundCodeIDRef_ = fundCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fundCode_ = new XsdTypeToken(fundCodeNode);
                    }
                }
                else
                {
                    fundCode_ = new XsdTypeToken(fundCodeNode);
                }
            }
            
        
            XmlNode fundNameNode = xmlNode.SelectSingleNode("fundName");
            
            if (fundNameNode != null)
            {
                if (fundNameNode.Attributes["href"] != null || fundNameNode.Attributes["id"] != null) 
                {
                    if (fundNameNode.Attributes["id"] != null) 
                    {
                        fundNameIDRef_ = fundNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fundNameNode);
                        IDManager.SetID(fundNameIDRef_, ob);
                    }
                    else if (fundNameNode.Attributes["href"] != null)
                    {
                        fundNameIDRef_ = fundNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fundName_ = new XsdTypeToken(fundNameNode);
                    }
                }
                else
                {
                    fundName_ = new XsdTypeToken(fundNameNode);
                }
            }
            
        
        }
        
    
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region InstName_
        private XsdTypeToken instName_;
        public XsdTypeToken InstName_
        {
            get
            {
                if (this.instName_ != null)
                {
                    return this.instName_; 
                }
                else if (this.instNameIDRef_ != null)
                {
                    instName_ = IDManager.getID(instNameIDRef_) as XsdTypeToken;
                    return this.instName_; 
                }
                else
                {
                    throw new Exception( "instName_Node no exist!");
                }
            }
            set
            {
                if (this.instName_ != value)
                {
                    this.instName_ = value;
                }
            }
        }
        #endregion
        
        public string instNameIDRef_ { get; set; }
        #region InstCode_
        private XsdTypeToken instCode_;
        public XsdTypeToken InstCode_
        {
            get
            {
                if (this.instCode_ != null)
                {
                    return this.instCode_; 
                }
                else if (this.instCodeIDRef_ != null)
                {
                    instCode_ = IDManager.getID(instCodeIDRef_) as XsdTypeToken;
                    return this.instCode_; 
                }
                else
                {
                    throw new Exception( "instCode_Node no exist!");
                }
            }
            set
            {
                if (this.instCode_ != value)
                {
                    this.instCode_ = value;
                }
            }
        }
        #endregion
        
        public string instCodeIDRef_ { get; set; }
        #region InstType_
        private XsdTypeToken instType_;
        public XsdTypeToken InstType_
        {
            get
            {
                if (this.instType_ != null)
                {
                    return this.instType_; 
                }
                else if (this.instTypeIDRef_ != null)
                {
                    instType_ = IDManager.getID(instTypeIDRef_) as XsdTypeToken;
                    return this.instType_; 
                }
                else
                {
                    throw new Exception( "instType_Node no exist!");
                }
            }
            set
            {
                if (this.instType_ != value)
                {
                    this.instType_ = value;
                }
            }
        }
        #endregion
        
        public string instTypeIDRef_ { get; set; }
        #region BookedDate_
        private XsdTypeToken bookedDate_;
        public XsdTypeToken BookedDate_
        {
            get
            {
                if (this.bookedDate_ != null)
                {
                    return this.bookedDate_; 
                }
                else if (this.bookedDateIDRef_ != null)
                {
                    bookedDate_ = IDManager.getID(bookedDateIDRef_) as XsdTypeToken;
                    return this.bookedDate_; 
                }
                else
                {
                    throw new Exception( "bookedDate_Node no exist!");
                }
            }
            set
            {
                if (this.bookedDate_ != value)
                {
                    this.bookedDate_ = value;
                }
            }
        }
        #endregion
        
        public string bookedDateIDRef_ { get; set; }
        #region UnBookedDate_
        private XsdTypeToken unBookedDate_;
        public XsdTypeToken UnBookedDate_
        {
            get
            {
                if (this.unBookedDate_ != null)
                {
                    return this.unBookedDate_; 
                }
                else if (this.unBookedDateIDRef_ != null)
                {
                    unBookedDate_ = IDManager.getID(unBookedDateIDRef_) as XsdTypeToken;
                    return this.unBookedDate_; 
                }
                else
                {
                    throw new Exception( "unBookedDate_Node no exist!");
                }
            }
            set
            {
                if (this.unBookedDate_ != value)
                {
                    this.unBookedDate_ = value;
                }
            }
        }
        #endregion
        
        public string unBookedDateIDRef_ { get; set; }
        #region MaturityDate_
        private XsdTypeToken maturityDate_;
        public XsdTypeToken MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as XsdTypeToken;
                    return this.maturityDate_; 
                }
                else
                {
                    throw new Exception( "maturityDate_Node no exist!");
                }
            }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                }
            }
        }
        #endregion
        
        public string maturityDateIDRef_ { get; set; }
        #region FileName_
        private XsdTypeToken fileName_;
        public XsdTypeToken FileName_
        {
            get
            {
                if (this.fileName_ != null)
                {
                    return this.fileName_; 
                }
                else if (this.fileNameIDRef_ != null)
                {
                    fileName_ = IDManager.getID(fileNameIDRef_) as XsdTypeToken;
                    return this.fileName_; 
                }
                else
                {
                    throw new Exception( "fileName_Node no exist!");
                }
            }
            set
            {
                if (this.fileName_ != value)
                {
                    this.fileName_ = value;
                }
            }
        }
        #endregion
        
        public string fileNameIDRef_ { get; set; }
        #region PositionName_
        private XsdTypeToken positionName_;
        public XsdTypeToken PositionName_
        {
            get
            {
                if (this.positionName_ != null)
                {
                    return this.positionName_; 
                }
                else if (this.positionNameIDRef_ != null)
                {
                    positionName_ = IDManager.getID(positionNameIDRef_) as XsdTypeToken;
                    return this.positionName_; 
                }
                else
                {
                    throw new Exception( "positionName_Node no exist!");
                }
            }
            set
            {
                if (this.positionName_ != value)
                {
                    this.positionName_ = value;
                }
            }
        }
        #endregion
        
        public string positionNameIDRef_ { get; set; }
        #region CounterParty_
        private XsdTypeToken counterParty_;
        public XsdTypeToken CounterParty_
        {
            get
            {
                if (this.counterParty_ != null)
                {
                    return this.counterParty_; 
                }
                else if (this.counterPartyIDRef_ != null)
                {
                    counterParty_ = IDManager.getID(counterPartyIDRef_) as XsdTypeToken;
                    return this.counterParty_; 
                }
                else
                {
                    throw new Exception( "counterParty_Node no exist!");
                }
            }
            set
            {
                if (this.counterParty_ != value)
                {
                    this.counterParty_ = value;
                }
            }
        }
        #endregion
        
        public string counterPartyIDRef_ { get; set; }
        #region Notional_
        private XsdTypeToken notional_;
        public XsdTypeToken Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeToken;
                    return this.notional_; 
                }
                else
                {
                    throw new Exception( "notional_Node no exist!");
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region Currency_
        private XsdTypeToken currency_;
        public XsdTypeToken Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeToken;
                    return this.currency_; 
                }
                else
                {
                    throw new Exception( "currency_Node no exist!");
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region FundCode_
        private XsdTypeToken fundCode_;
        public XsdTypeToken FundCode_
        {
            get
            {
                if (this.fundCode_ != null)
                {
                    return this.fundCode_; 
                }
                else if (this.fundCodeIDRef_ != null)
                {
                    fundCode_ = IDManager.getID(fundCodeIDRef_) as XsdTypeToken;
                    return this.fundCode_; 
                }
                else
                {
                    throw new Exception( "fundCode_Node no exist!");
                }
            }
            set
            {
                if (this.fundCode_ != value)
                {
                    this.fundCode_ = value;
                }
            }
        }
        #endregion
        
        public string fundCodeIDRef_ { get; set; }
        #region FundName_
        private XsdTypeToken fundName_;
        public XsdTypeToken FundName_
        {
            get
            {
                if (this.fundName_ != null)
                {
                    return this.fundName_; 
                }
                else if (this.fundNameIDRef_ != null)
                {
                    fundName_ = IDManager.getID(fundNameIDRef_) as XsdTypeToken;
                    return this.fundName_; 
                }
                else
                {
                    throw new Exception( "fundName_Node no exist!");
                }
            }
            set
            {
                if (this.fundName_ != value)
                {
                    this.fundName_ = value;
                }
            }
        }
        #endregion
        
        public string fundNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

