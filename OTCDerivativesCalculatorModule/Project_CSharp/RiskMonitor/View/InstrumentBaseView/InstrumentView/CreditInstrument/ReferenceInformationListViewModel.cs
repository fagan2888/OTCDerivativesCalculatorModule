using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceInformationListViewModel : IXmlData
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
    
        public ReferenceInformationListViewModel() { }
    
        #region ReferenceInformationViewModel_
        private ObservableCollection<ReferenceInformationViewModel> referenceInformationViewModel_;
        public ObservableCollection<ReferenceInformationViewModel> ReferenceInformationViewModel_
        {
            get { return this.referenceInformationViewModel_; }
            set
            {
                if (this.referenceInformationViewModel_ != value)
                {
                    this.referenceInformationViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceInformationViewModel_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceInformationList serial_ReferenceInformationList = serial_Class as FpmlSerializedCSharp.ReferenceInformationList;
        
            List<FpmlSerializedCSharp.ReferenceInformation> serial_referenceInformation = serial_ReferenceInformationList.ReferenceInformation_;
            this.referenceInformationViewModel_ = new ObservableCollection<ReferenceInformationViewModel>();
            foreach (var item in serial_referenceInformation)
            {
                ReferenceInformationViewModel viewModel = new ReferenceInformationViewModel();
                viewModel.setFromSerial(item);
                this.referenceInformationViewModel_.Add(viewModel);
            }

            this.view_ = new ReferenceInformationListView();
            this.view_.DataContext = this;
            
        }
    
    }
    
}

