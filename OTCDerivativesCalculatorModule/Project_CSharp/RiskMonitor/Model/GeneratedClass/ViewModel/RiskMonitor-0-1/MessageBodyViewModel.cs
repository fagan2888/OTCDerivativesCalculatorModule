using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class MessageBodyViewModel : IXmlData
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
        
        public MessageBodyViewModel() { }
        
        #region Msg_type_
        private string msg_type_;
        public string Msg_type_
        {
            get { return this.msg_type_; }
            set
            {
                if (this.msg_type_ != value)
                {
                    this.msg_type_ = value;
                    this.NotifyPropertyChanged("Msg_type_");
                }
            }
        }
        #endregion
        
        #region MaturityNotificationViewModel_
        private MaturityNotificationViewModel maturityNotificationViewModel_;
        public MaturityNotificationViewModel MaturityNotificationViewModel_
        {
            get { return this.maturityNotificationViewModel_; }
            set
            {
                if (this.maturityNotificationViewModel_ != value)
                {
                    this.maturityNotificationViewModel_ = value;
                    this.NotifyPropertyChanged("MaturityNotificationViewModel_");
                }
            }
        }
        #endregion
        
        #region GridCalculationViewModel_
        private GridCalculationViewModel gridCalculationViewModel_;
        public GridCalculationViewModel GridCalculationViewModel_
        {
            get { return this.gridCalculationViewModel_; }
            set
            {
                if (this.gridCalculationViewModel_ != value)
                {
                    this.gridCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("GridCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region ClearQueueViewModel_
        private ClearQueueViewModel clearQueueViewModel_;
        public ClearQueueViewModel ClearQueueViewModel_
        {
            get { return this.clearQueueViewModel_; }
            set
            {
                if (this.clearQueueViewModel_ != value)
                {
                    this.clearQueueViewModel_ = value;
                    this.NotifyPropertyChanged("ClearQueueViewModel_");
                }
            }
        }
        #endregion
        
        #region GridCalculationStartViewModel_
        private GridCalculationStartViewModel gridCalculationStartViewModel_;
        public GridCalculationStartViewModel GridCalculationStartViewModel_
        {
            get { return this.gridCalculationStartViewModel_; }
            set
            {
                if (this.gridCalculationStartViewModel_ != value)
                {
                    this.gridCalculationStartViewModel_ = value;
                    this.NotifyPropertyChanged("GridCalculationStartViewModel_");
                }
            }
        }
        #endregion
        
        #region CalculationServerInfoViewModel_
        private CalculationServerInfoViewModel calculationServerInfoViewModel_;
        public CalculationServerInfoViewModel CalculationServerInfoViewModel_
        {
            get { return this.calculationServerInfoViewModel_; }
            set
            {
                if (this.calculationServerInfoViewModel_ != value)
                {
                    this.calculationServerInfoViewModel_ = value;
                    this.NotifyPropertyChanged("CalculationServerInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static MessageBodyViewModel CreateMessageBody(string typeStr)
        {
            if ( typeStr == "maturityNotification")
            {
                return new MaturityNotificationViewModel();
            }
            else if ( typeStr == "gridCalculation")
            {
                return new GridCalculationViewModel();
            }
            else if ( typeStr == "clearQueue")
            {
                return new ClearQueueViewModel();
            }
            else if ( typeStr == "gridCalculationStart")
            {
                return new GridCalculationStartViewModel();
            }
            else if ( typeStr == "calculationServerInfo")
            {
                return new CalculationServerInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

