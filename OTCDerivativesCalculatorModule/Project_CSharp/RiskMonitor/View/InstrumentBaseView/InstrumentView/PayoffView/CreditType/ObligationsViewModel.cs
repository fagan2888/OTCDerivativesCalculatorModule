using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace RiskMonitor
{
    public class ObligationsViewModel : IXmlData
    {
        #region View_
        private Control view_;
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

        #region Category_
        private string category_;
        public string Category_
        {
            get { return this.category_; }
            set
            {
                if (this.category_ != value)
                {
                    this.category_ = value;
                    this.NotifyPropertyChanged("Category_");
                }
            }
        }
        #endregion

        #region NotSubordinated_
        private bool notSubordinated_;
        public bool NotSubordinated_
        {
            get { return this.notSubordinated_; }
            set
            {
                if (this.notSubordinated_ != value)
                {
                    this.notSubordinated_ = value;
                    this.NotifyPropertyChanged("NotSubordinated_");
                }
            }
        }
        #endregion

        #region NotDomesticCurrency_
        private bool notDomesticCurrency_;
        public bool NotDomesticCurrency_
        {
            get { return this.notDomesticCurrency_; }
            set
            {
                if (this.notDomesticCurrency_ != value)
                {
                    this.notDomesticCurrency_ = value;
                    this.NotifyPropertyChanged("NotDomesticCurrency_");
                }
            }
        }
        #endregion

        #region NotDomesticLaw_
        private bool notDomesticLaw_;
        public bool NotDomesticLaw_
        {
            get { return this.notDomesticLaw_; }
            set
            {
                if (this.notDomesticLaw_ != value)
                {
                    this.notDomesticLaw_ = value;
                    this.NotifyPropertyChanged("NotDomesticLaw_");
                }
            }
        }
        #endregion

        #region NotDomesticIssuance_
        private bool notDomesticIssuance_;
        public bool NotDomesticIssuance_
        {
            get { return this.notDomesticIssuance_; }
            set
            {
                if (this.notDomesticIssuance_ != value)
                {
                    this.notDomesticIssuance_ = value;
                    this.NotifyPropertyChanged("NotDomesticIssuance_");
                }
            }
        }
        #endregion

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Obligations serial_obligation = serial_Class as FpmlSerializedCSharp.Obligations;

            this.category_ = serial_obligation.Category_.ValueStr;
            this.notSubordinated_ = serial_obligation.NotSubordinated_.BooleanValue();
            this.notDomesticCurrency_ = serial_obligation.NotDomesticCurrency_.BooleanValue();
            this.notDomesticLaw_ = serial_obligation.NotDomesticIssuance_.BooleanValue();
            this.notDomesticIssuance_ = serial_obligation.NotDomesticIssuance_.BooleanValue();

            this.view_ = new ObligationsView();
            this.view_.DataContext = this;
        }
    }
}
