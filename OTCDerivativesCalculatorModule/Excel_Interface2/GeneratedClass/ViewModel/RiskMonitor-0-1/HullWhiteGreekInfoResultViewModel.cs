using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HullWhiteGreekInfoResultViewModel : UnderylingResultViewModel
    {
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
            xmlWriter.WriteStartElement("underylingResult");
                xmlWriter.WriteElementString("excel_type" , "hullWhiteGreekInfoResult");
                xmlWriter.WriteStartElement("hullWhiteGreekInfoResult");
                    foreach (var item in hullWhiteGreekResultViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new HullWhiteGreekInfoResultView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderylingResult serial_UnderylingResult = serial_Class as FpmlSerializedCSharp.UnderylingResult;
            FpmlSerializedCSharp.HullWhiteGreekInfoResult serial_HullWhiteGreekInfoResult = serial_UnderylingResult.HullWhiteGreekInfoResult_;
        
            List<FpmlSerializedCSharp.HullWhiteGreekResult> serial_hullWhiteGreekResult = serial_HullWhiteGreekInfoResult.HullWhiteGreekResult_;
            this.hullWhiteGreekResultViewModel_ = new ObservableCollection<HullWhiteGreekResultViewModel>();
            foreach (var item in serial_hullWhiteGreekResult)
            {
                string type = item.Excel_type_.ValueStr;
                HullWhiteGreekResultViewModel viewModel = HullWhiteGreekResultViewModel.CreateHullWhiteGreekResult(type);
                viewModel.setFromSerial(item);
                this.hullWhiteGreekResultViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

