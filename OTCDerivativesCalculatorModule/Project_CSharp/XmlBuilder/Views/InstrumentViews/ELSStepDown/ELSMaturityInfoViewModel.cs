using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace XmlBuilder.Views.InstrumentViews.ELSStepDown
{
    public class ELSMaturityInfoViewModel : IXmlBuild
    {
        public ELSMaturityInfoViewModel()
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
