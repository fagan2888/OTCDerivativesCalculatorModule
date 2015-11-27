using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl.PayoffCalculation
{
    public class ConstantPayoffCtrlViewModel : IXmlBuild
    {
        public ConstantPayoffCtrlViewModel()
        { 
        }

        #region Value_
        private double value_;
        public double Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
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


        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
