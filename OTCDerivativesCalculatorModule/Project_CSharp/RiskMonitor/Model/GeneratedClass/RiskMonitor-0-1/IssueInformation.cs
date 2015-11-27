using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IssueInformation : ISerialized
    {
        public IssueInformation() { }
        public IssueInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode swapInfoNode = xmlNode.SelectSingleNode("swapInfo");
            
            if (swapInfoNode != null)
            {
                if (swapInfoNode.Attributes["href"] != null || swapInfoNode.Attributes["id"] != null) 
                {
                    if (swapInfoNode.Attributes["id"] != null) 
                    {
                        swapInfoIDRef_ = swapInfoNode.Attributes["id"].Value;
                        SwapInfo ob = new SwapInfo(swapInfoNode);
                        IDManager.SetID(swapInfoIDRef_, ob);
                    }
                    else if (swapInfoNode.Attributes["href"] != null)
                    {
                        swapInfoIDRef_ = swapInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapInfo_ = new SwapInfo(swapInfoNode);
                    }
                }
                else
                {
                    swapInfo_ = new SwapInfo(swapInfoNode);
                }
            }
            
        
            XmlNode noteInfoNode = xmlNode.SelectSingleNode("noteInfo");
            
            if (noteInfoNode != null)
            {
                if (noteInfoNode.Attributes["href"] != null || noteInfoNode.Attributes["id"] != null) 
                {
                    if (noteInfoNode.Attributes["id"] != null) 
                    {
                        noteInfoIDRef_ = noteInfoNode.Attributes["id"].Value;
                        NoteInfo ob = new NoteInfo(noteInfoNode);
                        IDManager.SetID(noteInfoIDRef_, ob);
                    }
                    else if (noteInfoNode.Attributes["href"] != null)
                    {
                        noteInfoIDRef_ = noteInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        noteInfo_ = new NoteInfo(noteInfoNode);
                    }
                }
                else
                {
                    noteInfo_ = new NoteInfo(noteInfoNode);
                }
            }
            
        
            XmlNode optionInfoNode = xmlNode.SelectSingleNode("optionInfo");
            
            if (optionInfoNode != null)
            {
                if (optionInfoNode.Attributes["href"] != null || optionInfoNode.Attributes["id"] != null) 
                {
                    if (optionInfoNode.Attributes["id"] != null) 
                    {
                        optionInfoIDRef_ = optionInfoNode.Attributes["id"].Value;
                        OptionInfo ob = new OptionInfo(optionInfoNode);
                        IDManager.SetID(optionInfoIDRef_, ob);
                    }
                    else if (optionInfoNode.Attributes["href"] != null)
                    {
                        optionInfoIDRef_ = optionInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionInfo_ = new OptionInfo(optionInfoNode);
                    }
                }
                else
                {
                    optionInfo_ = new OptionInfo(optionInfoNode);
                }
            }
            
        
            XmlNode securitiesInfoNode = xmlNode.SelectSingleNode("securitiesInfo");
            
            if (securitiesInfoNode != null)
            {
                if (securitiesInfoNode.Attributes["href"] != null || securitiesInfoNode.Attributes["id"] != null) 
                {
                    if (securitiesInfoNode.Attributes["id"] != null) 
                    {
                        securitiesInfoIDRef_ = securitiesInfoNode.Attributes["id"].Value;
                        SecuritiesInfo ob = new SecuritiesInfo(securitiesInfoNode);
                        IDManager.SetID(securitiesInfoIDRef_, ob);
                    }
                    else if (securitiesInfoNode.Attributes["href"] != null)
                    {
                        securitiesInfoIDRef_ = securitiesInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        securitiesInfo_ = new SecuritiesInfo(securitiesInfoNode);
                    }
                }
                else
                {
                    securitiesInfo_ = new SecuritiesInfo(securitiesInfoNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region SwapInfo_
        private SwapInfo swapInfo_;
        public SwapInfo SwapInfo_
        {
            get
            {
                if (this.swapInfo_ != null)
                {
                    return this.swapInfo_; 
                }
                else if (this.swapInfoIDRef_ != null)
                {
                    swapInfo_ = IDManager.getID(swapInfoIDRef_) as SwapInfo;
                    return this.swapInfo_; 
                }
                else
                {
                    throw new Exception( "swapInfo_Node no exist!");
                }
            }
            set
            {
                if (this.swapInfo_ != value)
                {
                    this.swapInfo_ = value;
                }
            }
        }
        #endregion
        
        public string swapInfoIDRef_ { get; set; }
        #region NoteInfo_
        private NoteInfo noteInfo_;
        public NoteInfo NoteInfo_
        {
            get
            {
                if (this.noteInfo_ != null)
                {
                    return this.noteInfo_; 
                }
                else if (this.noteInfoIDRef_ != null)
                {
                    noteInfo_ = IDManager.getID(noteInfoIDRef_) as NoteInfo;
                    return this.noteInfo_; 
                }
                else
                {
                    throw new Exception( "noteInfo_Node no exist!");
                }
            }
            set
            {
                if (this.noteInfo_ != value)
                {
                    this.noteInfo_ = value;
                }
            }
        }
        #endregion
        
        public string noteInfoIDRef_ { get; set; }
        #region OptionInfo_
        private OptionInfo optionInfo_;
        public OptionInfo OptionInfo_
        {
            get
            {
                if (this.optionInfo_ != null)
                {
                    return this.optionInfo_; 
                }
                else if (this.optionInfoIDRef_ != null)
                {
                    optionInfo_ = IDManager.getID(optionInfoIDRef_) as OptionInfo;
                    return this.optionInfo_; 
                }
                else
                {
                    throw new Exception( "optionInfo_Node no exist!");
                }
            }
            set
            {
                if (this.optionInfo_ != value)
                {
                    this.optionInfo_ = value;
                }
            }
        }
        #endregion
        
        public string optionInfoIDRef_ { get; set; }
        #region SecuritiesInfo_
        private SecuritiesInfo securitiesInfo_;
        public SecuritiesInfo SecuritiesInfo_
        {
            get
            {
                if (this.securitiesInfo_ != null)
                {
                    return this.securitiesInfo_; 
                }
                else if (this.securitiesInfoIDRef_ != null)
                {
                    securitiesInfo_ = IDManager.getID(securitiesInfoIDRef_) as SecuritiesInfo;
                    return this.securitiesInfo_; 
                }
                else
                {
                    throw new Exception( "securitiesInfo_Node no exist!");
                }
            }
            set
            {
                if (this.securitiesInfo_ != value)
                {
                    this.securitiesInfo_ = value;
                }
            }
        }
        #endregion
        
        public string securitiesInfoIDRef_ { get; set; }
        public string choiceStr_issueType;
        
    
        
    
    }
    
}

