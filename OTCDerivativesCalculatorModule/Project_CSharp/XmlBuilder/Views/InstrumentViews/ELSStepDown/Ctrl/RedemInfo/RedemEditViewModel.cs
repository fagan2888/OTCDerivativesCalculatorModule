using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.RedemInfo
{
    public class RedemEditViewModel
    {
        public RedemEditViewModel()
        { 
        
        }

        //public UserControl kiTypeCtrl()
        //{
        //    if (this.type_ == "NormalKI")
        //    {
        //        return new UserControl();
        //    }
        //    else
        //    {
        //        return new UserControl();
        //    }
        //}



        #region UnderlyingCalculationVM_
        private IXmlBuild underlyingCalculationVM_;
        public IXmlBuild UnderlyingCalculationVM_
        {
            get { return this.underlyingCalculationVM_; }
            set
            {
                if (this.underlyingCalculationVM_ != value)
                {
                    this.underlyingCalculationVM_ = value;
                    this.NotifyPropertyChanged("UnderlyingCalculationVM_");
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
