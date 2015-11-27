using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class GbmGreekInfoResultViewModel : UnderylingResultViewModel
    {
    
        public GbmGreekInfoResultViewModel() { }
    
        #region GbmGreekResultViewModel_
        private ObservableCollection<GbmGreekResultViewModel> gbmGreekResultViewModel_;
        public ObservableCollection<GbmGreekResultViewModel> GbmGreekResultViewModel_
        {
            get { return this.gbmGreekResultViewModel_; }
            set
            {
                if (this.gbmGreekResultViewModel_ != value)
                {
                    this.gbmGreekResultViewModel_ = value;
                    this.NotifyPropertyChanged("GbmGreekResultViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderylingResult serial_UnderylingResult = serial_Class as FpmlSerializedCSharp.UnderylingResult;
            FpmlSerializedCSharp.GbmGreekInfoResult serial_GbmGreekInfoResult = serial_UnderylingResult.GbmGreekInfoResult_;
        
            List<FpmlSerializedCSharp.GbmGreekResult> serial_gbmGreekResult = serial_GbmGreekInfoResult.GbmGreekResult_;
            this.gbmGreekResultViewModel_ = new ObservableCollection<GbmGreekResultViewModel>();
            foreach (var item in serial_gbmGreekResult)
            {
                GbmGreekResultViewModel viewModel = new GbmGreekResultViewModel();
                viewModel.setFromSerial(item);
                this.gbmGreekResultViewModel_.Add(viewModel);
            }
            
            this.view_ = new GbmGreekInfoResultView();
            this.view_.DataContext = this;
        }
            
    }
    
}

