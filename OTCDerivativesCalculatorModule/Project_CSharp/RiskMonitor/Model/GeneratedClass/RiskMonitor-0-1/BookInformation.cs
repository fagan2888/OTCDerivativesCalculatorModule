using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BookInformation : ISerialized
    {
        public BookInformation() { }
        public BookInformation(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNode pathInfoNode = xmlNode.SelectSingleNode("pathInfo");
            
            if (pathInfoNode != null)
            {
                if (pathInfoNode.Attributes["href"] != null || pathInfoNode.Attributes["id"] != null) 
                {
                    if (pathInfoNode.Attributes["id"] != null) 
                    {
                        pathInfoIDRef_ = pathInfoNode.Attributes["id"].Value;
                        PathInfo ob = new PathInfo(pathInfoNode);
                        IDManager.SetID(pathInfoIDRef_, ob);
                    }
                    else if (pathInfoNode.Attributes["href"] != null)
                    {
                        pathInfoIDRef_ = pathInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pathInfo_ = new PathInfo(pathInfoNode);
                    }
                }
                else
                {
                    pathInfo_ = new PathInfo(pathInfoNode);
                }
            }
            
        
            XmlNode instrumentListNode = xmlNode.SelectSingleNode("instrumentList");
            
            if (instrumentListNode != null)
            {
                if (instrumentListNode.Attributes["href"] != null || instrumentListNode.Attributes["id"] != null) 
                {
                    if (instrumentListNode.Attributes["id"] != null) 
                    {
                        instrumentListIDRef_ = instrumentListNode.Attributes["id"].Value;
                        InstrumentList ob = new InstrumentList(instrumentListNode);
                        IDManager.SetID(instrumentListIDRef_, ob);
                    }
                    else if (instrumentListNode.Attributes["href"] != null)
                    {
                        instrumentListIDRef_ = instrumentListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrumentList_ = new InstrumentList(instrumentListNode);
                    }
                }
                else
                {
                    instrumentList_ = new InstrumentList(instrumentListNode);
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
                    throw new Exception( "name_Node no exist!");
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
        #region PathInfo_
        private PathInfo pathInfo_;
        public PathInfo PathInfo_
        {
            get
            {
                if (this.pathInfo_ != null)
                {
                    return this.pathInfo_; 
                }
                else if (this.pathInfoIDRef_ != null)
                {
                    pathInfo_ = IDManager.getID(pathInfoIDRef_) as PathInfo;
                    return this.pathInfo_; 
                }
                else
                {
                    throw new Exception( "pathInfo_Node no exist!");
                }
            }
            set
            {
                if (this.pathInfo_ != value)
                {
                    this.pathInfo_ = value;
                }
            }
        }
        #endregion
        
        public string pathInfoIDRef_ { get; set; }
        #region InstrumentList_
        private InstrumentList instrumentList_;
        public InstrumentList InstrumentList_
        {
            get
            {
                if (this.instrumentList_ != null)
                {
                    return this.instrumentList_; 
                }
                else if (this.instrumentListIDRef_ != null)
                {
                    instrumentList_ = IDManager.getID(instrumentListIDRef_) as InstrumentList;
                    return this.instrumentList_; 
                }
                else
                {
                    throw new Exception( "instrumentList_Node no exist!");
                }
            }
            set
            {
                if (this.instrumentList_ != value)
                {
                    this.instrumentList_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentListIDRef_ { get; set; }
        
    
        
    
    }
    
}

