using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class IssueInformation : ISerialized
    {
        public IssueInformation() { }
        public IssueInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
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
                      return this.swapInfo_; 
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
                      return this.noteInfo_; 
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
                      return this.securitiesInfo_; 
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

