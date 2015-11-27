using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.ViewModel
{
    public class XmlBuilderViewModel : IXmlBuild
    {

        public XmlBuilderViewModel()
        {
            
        }

        private void buildFromSerialClass()
        {
            this.bivm_ = new BaseInformationViewModel(serial_sp_.StructuredProductPayoff_.BaseInformation_);

            ecvmList_ = new ObservableCollection<EventCheckViewModel>();

            foreach (FpmlSerializedCSharp.EventCheck item in serial_sp_.StructuredProductPayoff_.EventSchedule_.EventCheck_)
            {
                ecvmList_.Add(new EventCheckViewModel(item));
            }
        }

        public void setProduct(FpmlSerializedCSharp.StructuredProduct serial_sp)
        {
            this.serial_sp_ = serial_sp;
            this.buildFromSerialClass();
        }

        private FpmlSerializedCSharp.StructuredProduct serial_sp_;

        #region BaseInformationViewModel_
        private BaseInformationViewModel bivm_;
        public BaseInformationViewModel BaseInformationViewModel_
        {
            get { return this.bivm_; }
            set
            {
                if (this.bivm_ != value)
                {
                    this.bivm_ = value;
                    this.NotifyPropertyChanged("BaseInformationViewModel_");
                }
            }
        }
        #endregion

        #region EventCheckViewModel_
        private ObservableCollection<EventCheckViewModel> ecvmList_;
        public ObservableCollection<EventCheckViewModel> EventCheckViewModel_
        {
            get { return this.ecvmList_; }
            set
            {
                if (this.ecvmList_ != value)
                {
                    this.ecvmList_ = value;
                    this.NotifyPropertyChanged("EventCheckViewModel_");
                }
            }
        }
        #endregion


        public void buildXml(XmlWriter xmlWriter)
        {
            
            foreach (EventCheckViewModel item in ecvmList_)
            {
                item.buildXml(xmlWriter);   
            }
            
        }



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
