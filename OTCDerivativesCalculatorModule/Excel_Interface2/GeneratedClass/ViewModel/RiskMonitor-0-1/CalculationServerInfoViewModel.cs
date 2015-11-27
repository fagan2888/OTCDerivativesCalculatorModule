using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CalculationServerInfoViewModel : MessageBodyViewModel
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
        public CalculationServerInfoViewModel() { }
        
        #region Server_name_
        private string server_name_;
        public string Server_name_
        {
            get { return this.server_name_; }
            set
            {
                if (this.server_name_ != value)
                {
                    this.server_name_ = value;
                    this.NotifyPropertyChanged("Server_name_");
                }
            }
        }
        #endregion
        
        #region Server_ip_
        private string server_ip_;
        public string Server_ip_
        {
            get { return this.server_ip_; }
            set
            {
                if (this.server_ip_ != value)
                {
                    this.server_ip_ = value;
                    this.NotifyPropertyChanged("Server_ip_");
                }
            }
        }
        #endregion
        
        #region Server_port_
        private string server_port_;
        public string Server_port_
        {
            get { return this.server_port_; }
            set
            {
                if (this.server_port_ != value)
                {
                    this.server_port_ = value;
                    this.NotifyPropertyChanged("Server_port_");
                }
            }
        }
        #endregion
        
        #region Server_status_
        private string server_status_;
        public string Server_status_
        {
            get { return this.server_status_; }
            set
            {
                if (this.server_status_ != value)
                {
                    this.server_status_ = value;
                    this.NotifyPropertyChanged("Server_status_");
                }
            }
        }
        #endregion
        
        #region Server_coreNum_
        private string server_coreNum_;
        public string Server_coreNum_
        {
            get { return this.server_coreNum_; }
            set
            {
                if (this.server_coreNum_ != value)
                {
                    this.server_coreNum_ = value;
                    this.NotifyPropertyChanged("Server_coreNum_");
                }
            }
        }
        #endregion
        
        #region Server_use_
        private string server_use_;
        public string Server_use_
        {
            get { return this.server_use_; }
            set
            {
                if (this.server_use_ != value)
                {
                    this.server_use_ = value;
                    this.NotifyPropertyChanged("Server_use_");
                }
            }
        }
        #endregion
        
        #region Server_aliveTime_
        private string server_aliveTime_;
        public string Server_aliveTime_
        {
            get { return this.server_aliveTime_; }
            set
            {
                if (this.server_aliveTime_ != value)
                {
                    this.server_aliveTime_ = value;
                    this.NotifyPropertyChanged("Server_aliveTime_");
                }
            }
        }
        #endregion
        
        #region Server_description_
        private string server_description_;
        public string Server_description_
        {
            get { return this.server_description_; }
            set
            {
                if (this.server_description_ != value)
                {
                    this.server_description_ = value;
                    this.NotifyPropertyChanged("Server_description_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("excel_type" , "calculationServerInfo");
                xmlWriter.WriteStartElement("calculationServerInfo");
                    xmlWriter.WriteElementString("server_name" , this.server_name_);
                    
                    xmlWriter.WriteElementString("server_ip" , this.server_ip_);
                    
                    xmlWriter.WriteElementString("server_port" , this.server_port_);
                    
                    xmlWriter.WriteElementString("server_status" , this.server_status_);
                    
                    xmlWriter.WriteElementString("server_coreNum" , this.server_coreNum_);
                    
                    xmlWriter.WriteElementString("server_use" , this.server_use_);
                    
                    xmlWriter.WriteElementString("server_aliveTime" , this.server_aliveTime_);
                    
                    xmlWriter.WriteElementString("server_description" , this.server_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new CalculationServerInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.CalculationServerInfo serial_CalculationServerInfo = serial_MessageBody.CalculationServerInfo_;
        
            this.server_name_ = serial_CalculationServerInfo.Server_name_.ValueStr;
            
            this.server_ip_ = serial_CalculationServerInfo.Server_ip_.ValueStr;
            
            this.server_port_ = serial_CalculationServerInfo.Server_port_.ValueStr;
            
            this.server_status_ = serial_CalculationServerInfo.Server_status_.ValueStr;
            
            this.server_coreNum_ = serial_CalculationServerInfo.Server_coreNum_.ValueStr;
            
            this.server_use_ = serial_CalculationServerInfo.Server_use_.ValueStr;
            
            this.server_aliveTime_ = serial_CalculationServerInfo.Server_aliveTime_.ValueStr;
            
            this.server_description_ = serial_CalculationServerInfo.Server_description_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

