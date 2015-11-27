using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace RiskMonitor
{

    public abstract class InstrumentViewModel : IXmlData, IUnderlyingInst
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get
            {
                return this.view_;
            }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

        public InstrumentViewModel()
        { 
        
        }

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

        #region ItemCode_
        protected string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region ItemType_
        private string itemType_;
        public string ItemType_
        {
            get { return this.itemType_; }
            set
            {
                if (this.itemType_ != value)
                {
                    this.itemType_ = value;
                    this.NotifyPropertyChanged("ItemType_");
                }
            }
        }
        #endregion

        #region ItemName_
        private string itemName_;
        public string ItemName_
        {
            get { return this.itemName_; }
            set
            {
                if (this.itemName_ != value)
                {
                    this.itemName_ = value;
                    this.NotifyPropertyChanged("ItemName_");
                }
            }
        }
        #endregion

        #region PayoffType_
        private string payoffType_;
        public string PayoffType_
        {
            get { return this.payoffType_; }
            set
            {
                if (this.payoffType_ != value)
                {
                    this.payoffType_ = value;
                    this.NotifyPropertyChanged("PayoffType_");
                }
            }
        }
        #endregion

        public abstract void buildXml(XmlWriter xmlWriter);
        public abstract void setFromXml(XmlNode InstNode);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract UnderlyingViewModel getUnderlying();

        public abstract void calculate();

        public static InstrumentViewModel CreateInstVM(XmlNode node)
        {
            FpmlSerializedCSharp.InstrumentInfo serial_instInfo = new FpmlSerializedCSharp.InstrumentInfo(node);
            return InstrumentViewModel.CreateInstVM(serial_instInfo);
        }

        public static InstrumentViewModel CreateInstVM(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstrumentInfo instrumentInfo = serial_Class as FpmlSerializedCSharp.InstrumentInfo;

            string type = instrumentInfo.Type_.ValueStr;

            if (type == "standardInstrument")
            {
                return new StandardInstViewModel();
            }
            //else if (type == "creditInstrument")
            //{
            //    return new CreditInstrumentViewModel();
            //}
            else
            {
                throw new NotImplementedException();
            }
        }

 
    }
}
