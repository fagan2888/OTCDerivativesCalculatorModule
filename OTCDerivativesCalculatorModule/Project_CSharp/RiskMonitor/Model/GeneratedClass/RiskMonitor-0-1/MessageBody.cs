using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MessageBody : ISerialized
    {
        public MessageBody() { }
        public MessageBody(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode msg_typeNode = xmlNode.SelectSingleNode("msg_type");
            
            if (msg_typeNode != null)
            {
                if (msg_typeNode.Attributes["href"] != null || msg_typeNode.Attributes["id"] != null) 
                {
                    if (msg_typeNode.Attributes["id"] != null) 
                    {
                        msg_typeIDRef_ = msg_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(msg_typeNode);
                        IDManager.SetID(msg_typeIDRef_, ob);
                    }
                    else if (msg_typeNode.Attributes["href"] != null)
                    {
                        msg_typeIDRef_ = msg_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        msg_type_ = new XsdTypeToken(msg_typeNode);
                    }
                }
                else
                {
                    msg_type_ = new XsdTypeToken(msg_typeNode);
                }
            }
            
        
            XmlNode maturityNotificationNode = xmlNode.SelectSingleNode("maturityNotification");
            
            if (maturityNotificationNode != null)
            {
                if (maturityNotificationNode.Attributes["href"] != null || maturityNotificationNode.Attributes["id"] != null) 
                {
                    if (maturityNotificationNode.Attributes["id"] != null) 
                    {
                        maturityNotificationIDRef_ = maturityNotificationNode.Attributes["id"].Value;
                        MaturityNotification ob = new MaturityNotification(maturityNotificationNode);
                        IDManager.SetID(maturityNotificationIDRef_, ob);
                    }
                    else if (maturityNotificationNode.Attributes["href"] != null)
                    {
                        maturityNotificationIDRef_ = maturityNotificationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityNotification_ = new MaturityNotification(maturityNotificationNode);
                    }
                }
                else
                {
                    maturityNotification_ = new MaturityNotification(maturityNotificationNode);
                }
            }
            
        
            XmlNode gridCalculationNode = xmlNode.SelectSingleNode("gridCalculation");
            
            if (gridCalculationNode != null)
            {
                if (gridCalculationNode.Attributes["href"] != null || gridCalculationNode.Attributes["id"] != null) 
                {
                    if (gridCalculationNode.Attributes["id"] != null) 
                    {
                        gridCalculationIDRef_ = gridCalculationNode.Attributes["id"].Value;
                        GridCalculation ob = new GridCalculation(gridCalculationNode);
                        IDManager.SetID(gridCalculationIDRef_, ob);
                    }
                    else if (gridCalculationNode.Attributes["href"] != null)
                    {
                        gridCalculationIDRef_ = gridCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gridCalculation_ = new GridCalculation(gridCalculationNode);
                    }
                }
                else
                {
                    gridCalculation_ = new GridCalculation(gridCalculationNode);
                }
            }
            
        
            XmlNode clearQueueNode = xmlNode.SelectSingleNode("clearQueue");
            
            if (clearQueueNode != null)
            {
                if (clearQueueNode.Attributes["href"] != null || clearQueueNode.Attributes["id"] != null) 
                {
                    if (clearQueueNode.Attributes["id"] != null) 
                    {
                        clearQueueIDRef_ = clearQueueNode.Attributes["id"].Value;
                        ClearQueue ob = new ClearQueue(clearQueueNode);
                        IDManager.SetID(clearQueueIDRef_, ob);
                    }
                    else if (clearQueueNode.Attributes["href"] != null)
                    {
                        clearQueueIDRef_ = clearQueueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearQueue_ = new ClearQueue(clearQueueNode);
                    }
                }
                else
                {
                    clearQueue_ = new ClearQueue(clearQueueNode);
                }
            }
            
        
            XmlNode gridCalculationStartNode = xmlNode.SelectSingleNode("gridCalculationStart");
            
            if (gridCalculationStartNode != null)
            {
                if (gridCalculationStartNode.Attributes["href"] != null || gridCalculationStartNode.Attributes["id"] != null) 
                {
                    if (gridCalculationStartNode.Attributes["id"] != null) 
                    {
                        gridCalculationStartIDRef_ = gridCalculationStartNode.Attributes["id"].Value;
                        GridCalculationStart ob = new GridCalculationStart(gridCalculationStartNode);
                        IDManager.SetID(gridCalculationStartIDRef_, ob);
                    }
                    else if (gridCalculationStartNode.Attributes["href"] != null)
                    {
                        gridCalculationStartIDRef_ = gridCalculationStartNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gridCalculationStart_ = new GridCalculationStart(gridCalculationStartNode);
                    }
                }
                else
                {
                    gridCalculationStart_ = new GridCalculationStart(gridCalculationStartNode);
                }
            }
            
        
            XmlNode calculationServerInfoNode = xmlNode.SelectSingleNode("calculationServerInfo");
            
            if (calculationServerInfoNode != null)
            {
                if (calculationServerInfoNode.Attributes["href"] != null || calculationServerInfoNode.Attributes["id"] != null) 
                {
                    if (calculationServerInfoNode.Attributes["id"] != null) 
                    {
                        calculationServerInfoIDRef_ = calculationServerInfoNode.Attributes["id"].Value;
                        CalculationServerInfo ob = new CalculationServerInfo(calculationServerInfoNode);
                        IDManager.SetID(calculationServerInfoIDRef_, ob);
                    }
                    else if (calculationServerInfoNode.Attributes["href"] != null)
                    {
                        calculationServerInfoIDRef_ = calculationServerInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationServerInfo_ = new CalculationServerInfo(calculationServerInfoNode);
                    }
                }
                else
                {
                    calculationServerInfo_ = new CalculationServerInfo(calculationServerInfoNode);
                }
            }
            
        
        }
        
    
        #region Msg_type_
        private XsdTypeToken msg_type_;
        public XsdTypeToken Msg_type_
        {
            get
            {
                if (this.msg_type_ != null)
                {
                    return this.msg_type_; 
                }
                else if (this.msg_typeIDRef_ != null)
                {
                    msg_type_ = IDManager.getID(msg_typeIDRef_) as XsdTypeToken;
                    return this.msg_type_; 
                }
                else
                {
                    throw new Exception( "msg_type_Node no exist!");
                }
            }
            set
            {
                if (this.msg_type_ != value)
                {
                    this.msg_type_ = value;
                }
            }
        }
        #endregion
        
        public string msg_typeIDRef_ { get; set; }
        #region MaturityNotification_
        private MaturityNotification maturityNotification_;
        public MaturityNotification MaturityNotification_
        {
            get
            {
                if (this.maturityNotification_ != null)
                {
                    return this.maturityNotification_; 
                }
                else if (this.maturityNotificationIDRef_ != null)
                {
                    maturityNotification_ = IDManager.getID(maturityNotificationIDRef_) as MaturityNotification;
                    return this.maturityNotification_; 
                }
                else
                {
                    throw new Exception( "maturityNotification_Node no exist!");
                }
            }
            set
            {
                if (this.maturityNotification_ != value)
                {
                    this.maturityNotification_ = value;
                }
            }
        }
        #endregion
        
        public string maturityNotificationIDRef_ { get; set; }
        #region GridCalculation_
        private GridCalculation gridCalculation_;
        public GridCalculation GridCalculation_
        {
            get
            {
                if (this.gridCalculation_ != null)
                {
                    return this.gridCalculation_; 
                }
                else if (this.gridCalculationIDRef_ != null)
                {
                    gridCalculation_ = IDManager.getID(gridCalculationIDRef_) as GridCalculation;
                    return this.gridCalculation_; 
                }
                else
                {
                    throw new Exception( "gridCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.gridCalculation_ != value)
                {
                    this.gridCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string gridCalculationIDRef_ { get; set; }
        #region ClearQueue_
        private ClearQueue clearQueue_;
        public ClearQueue ClearQueue_
        {
            get
            {
                if (this.clearQueue_ != null)
                {
                    return this.clearQueue_; 
                }
                else if (this.clearQueueIDRef_ != null)
                {
                    clearQueue_ = IDManager.getID(clearQueueIDRef_) as ClearQueue;
                    return this.clearQueue_; 
                }
                else
                {
                    throw new Exception( "clearQueue_Node no exist!");
                }
            }
            set
            {
                if (this.clearQueue_ != value)
                {
                    this.clearQueue_ = value;
                }
            }
        }
        #endregion
        
        public string clearQueueIDRef_ { get; set; }
        #region GridCalculationStart_
        private GridCalculationStart gridCalculationStart_;
        public GridCalculationStart GridCalculationStart_
        {
            get
            {
                if (this.gridCalculationStart_ != null)
                {
                    return this.gridCalculationStart_; 
                }
                else if (this.gridCalculationStartIDRef_ != null)
                {
                    gridCalculationStart_ = IDManager.getID(gridCalculationStartIDRef_) as GridCalculationStart;
                    return this.gridCalculationStart_; 
                }
                else
                {
                    throw new Exception( "gridCalculationStart_Node no exist!");
                }
            }
            set
            {
                if (this.gridCalculationStart_ != value)
                {
                    this.gridCalculationStart_ = value;
                }
            }
        }
        #endregion
        
        public string gridCalculationStartIDRef_ { get; set; }
        #region CalculationServerInfo_
        private CalculationServerInfo calculationServerInfo_;
        public CalculationServerInfo CalculationServerInfo_
        {
            get
            {
                if (this.calculationServerInfo_ != null)
                {
                    return this.calculationServerInfo_; 
                }
                else if (this.calculationServerInfoIDRef_ != null)
                {
                    calculationServerInfo_ = IDManager.getID(calculationServerInfoIDRef_) as CalculationServerInfo;
                    return this.calculationServerInfo_; 
                }
                else
                {
                    throw new Exception( "calculationServerInfo_Node no exist!");
                }
            }
            set
            {
                if (this.calculationServerInfo_ != value)
                {
                    this.calculationServerInfo_ = value;
                }
            }
        }
        #endregion
        
        public string calculationServerInfoIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

