using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.RedemInfo;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown
{
    public class ELSRedemInfoViewModel : IXmlBuild
    {
        public ELSRedemInfoViewModel() 
        {
            
        }

        private void buildFromSerialClass()
        {

        }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }


        #region No_
        private int no_;
        public int No_
        {
            get { return this.no_; }
            set
            {
                if (this.no_ != value)
                {
                    this.no_ = value;
                    this.NotifyPropertyChanged("No_");
                }
            }
        }
        #endregion

        #region Date_
        private DateTime date_;
        public DateTime Date_
        {
            get { return this.date_; }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                    this.NotifyPropertyChanged("Date_");
                }
            }
        }
        #endregion

        #region CheckType_
        private string checkType_;
        public string CheckType_
        {
            get { return this.checkType_; }
            set
            {
                if (this.checkType_ != value)
                {
                    this.checkType_ = value;
                    this.NotifyPropertyChanged("CheckType_");
                }
            }
        }
        #endregion

        #region PayoffValue_
        private string payoffValue_;
        public string PayoffValue_
        {
            get { return this.payoffValue_; }
            set
            {
                if (this.payoffValue_ != value)
                {
                    this.payoffValue_ = value;
                    this.NotifyPropertyChanged("PayoffValue_");
                }
            }
        }
        #endregion

        #region AutoCallable_
        private bool autoCallable_;
        public bool AutoCallable_
        {
            get { return this.autoCallable_; }
            set
            {
                if (this.autoCallable_ != value)
                {
                    this.autoCallable_ = value;
                    this.NotifyPropertyChanged("AutoCallable_");
                }
            }
        }
        #endregion

        #region Expired_
        private bool expired_;
        public bool Expired_
        {
            get { return this.expired_; }
            set
            {
                if (this.expired_ != value)
                {
                    this.expired_ = value;
                    this.NotifyPropertyChanged("Expired_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        #region RedemEditVM_
        private RedemEditViewModel redemEditVM_;
        public RedemEditViewModel RedemEditVM_
        {
            get { return this.redemEditVM_; }
            set
            {
                if (this.redemEditVM_ != value)
                {
                    this.redemEditVM_ = value;
                    this.NotifyPropertyChanged("RedemEditVM_");
                }
            }
        }
        #endregion


        // ---------------------- Event ---------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



    }
}
