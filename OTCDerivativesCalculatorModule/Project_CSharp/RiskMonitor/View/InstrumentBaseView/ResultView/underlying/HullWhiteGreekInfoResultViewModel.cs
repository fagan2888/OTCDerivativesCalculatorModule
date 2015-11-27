using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class HullWhiteGreekInfoResultViewModel : UnderylingResultViewModel
    {
    
        public HullWhiteGreekInfoResultViewModel() { }
    
        #region HullWhiteGreekResultViewModel_
        private ObservableCollection<HullWhiteGreekResultViewModel> hullWhiteGreekResultViewModel_;
        public ObservableCollection<HullWhiteGreekResultViewModel> HullWhiteGreekResultViewModel_
        {
            get { return this.hullWhiteGreekResultViewModel_; }
            set
            {
                if (this.hullWhiteGreekResultViewModel_ != value)
                {
                    this.hullWhiteGreekResultViewModel_ = value;
                    this.NotifyPropertyChanged("HullWhiteGreekResultViewModel_");
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
            FpmlSerializedCSharp.HullWhiteGreekInfoResult serial_HullWhiteGreekInfoResult = serial_UnderylingResult.HullWhiteGreekInfoResult_;
        
            List<FpmlSerializedCSharp.HullWhiteGreekResult> serial_hullWhiteGreekResult = serial_HullWhiteGreekInfoResult.HullWhiteGreekResult_;
            this.hullWhiteGreekResultViewModel_ = new ObservableCollection<HullWhiteGreekResultViewModel>();
            foreach (var item in serial_hullWhiteGreekResult)
            {
                HullWhiteGreekResultViewModel viewModel = new HullWhiteGreekResultViewModel();
                viewModel.setFromSerial(item);
                this.hullWhiteGreekResultViewModel_.Add(viewModel);
            }
            
            this.view_ = new HullWhiteGreekInfoResultView();
            this.view_.DataContext = this;
        }
        
    }
    
}

