using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;


namespace XmlBuilder.Views.InstrumentViews.ELSStepDown
{
    public class ELSKICheckInfoViewModel
    {
        public ELSKICheckInfoViewModel()
        { 
        }

        public UserControl kiTypeCtrl()
        {
            if (this.type_ == "NormalKI")
            {
                return new UserControl();
            }
            else
            {
                return new UserControl();
            }
        }

        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region PayoffFormula_
        private string payoffFormula_;
        public string PayoffFormula_
        {
            get { return this.payoffFormula_; }
            set
            {
                if (this.payoffFormula_ != value)
                {
                    this.payoffFormula_ = value;
                    this.NotifyPropertyChanged("PayoffFormula_");
                }
            }
        }
        #endregion

        #region KICheckCalculationVM_
        private IXmlBuild kiCheckCalculationVM_;
        public IXmlBuild KICheckCalculationVM_
        {
            get { return this.kiCheckCalculationVM_; }
            set
            {
                if (this.kiCheckCalculationVM_ != value)
                {
                    this.kiCheckCalculationVM_ = value;
                    this.NotifyPropertyChanged("KICheckCalculationVM_");
                }
            }
        }
        #endregion

        #region PayoffCalculationVM_
        private IXmlBuild payoffCalculationVM_;
        public IXmlBuild PayoffCalculationVM_
        {
            get { return this.payoffCalculationVM_; }
            set
            {
                if (this.payoffCalculationVM_ != value)
                {
                    this.payoffCalculationVM_ = value;
                    this.NotifyPropertyChanged("PayoffCalculationVM_");
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
