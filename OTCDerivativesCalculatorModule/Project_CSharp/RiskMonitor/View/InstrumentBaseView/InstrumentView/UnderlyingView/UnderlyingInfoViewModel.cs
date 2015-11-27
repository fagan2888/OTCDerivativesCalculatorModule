using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;

namespace RiskMonitor
{
    public abstract class UnderlyingInfoViewModel : IXmlData
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
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

        public UnderlyingInfoViewModel()
        {

        }

        public void loadData(DateTime referenceDate, ParameterSetting setting)
        {
            //UnderInfo_.loadData(referenceDate, setting);
        }

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode InstNode);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

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

        public static UnderlyingInfoViewModel CreateUnderlyingInfo(string underInfoType)
        {
            if (underInfoType == "indexUnderInfo")
            {
                return new IndexUnderInfoViewModel();
            }
            //else if (underInfoType == "credit")
            //{
            //    return new CreditEventUnderInfoViewModel();
            //}
            else
            {
                throw new NotImplementedException();
            }
        }

        public static UnderlyingInfoViewModel CreateUnderlyingInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderlyingInformation serial_underInfo = serial_Class as FpmlSerializedCSharp.UnderlyingInformation;

            string undertype = serial_underInfo.Type_.ValueStr;

            return UnderlyingInfoViewModel.CreateUnderlyingInfo(undertype);
        }
    }
}
