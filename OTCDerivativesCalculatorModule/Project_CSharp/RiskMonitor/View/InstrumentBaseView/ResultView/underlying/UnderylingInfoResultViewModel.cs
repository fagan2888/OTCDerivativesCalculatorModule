using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class UnderylingInfoResultViewModel : IXmlData
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
    
        public UnderylingInfoResultViewModel() { }
        
        #region UnderylingResultViewModel_
        private ObservableCollection<UnderylingResultViewModel> underylingResultViewModel_;
        public ObservableCollection<UnderylingResultViewModel> UnderylingResultViewModel_
        {
            get { return this.underylingResultViewModel_; }
            set
            {
                if (this.underylingResultViewModel_ != value)
                {
                    this.underylingResultViewModel_ = value;
                    this.NotifyPropertyChanged("UnderylingResultViewModel_");
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
            FpmlSerializedCSharp.UnderylingInfoResult serial_UnderylingInfoResult = serial_Class as FpmlSerializedCSharp.UnderylingInfoResult;
        
            List<FpmlSerializedCSharp.UnderylingResult> serial_underylingResult = serial_UnderylingInfoResult.UnderylingResult_;
            this.underylingResultViewModel_ = new ObservableCollection<UnderylingResultViewModel>();
            foreach (var item in serial_underylingResult)
            {
                string type = item.Type_.ValueStr;
                UnderylingResultViewModel viewModel = UnderylingResultViewModel.CreateUnderylingResult(type);
                viewModel.setFromSerial(item);
                this.underylingResultViewModel_.Add(viewModel);
            }
            
            this.view_ = new UnderylingInfoResultView();
            this.view_.DataContext = this;
        }
    
    }
    
}

