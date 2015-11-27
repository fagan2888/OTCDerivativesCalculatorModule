using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown.Ctrl
{
    public class KIPayoffEditViewModel : IXmlBuild
    {
        public KIPayoffEditViewModel()
        {
        
        }

        private void buildFromSerialClass()
        {

        }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
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
