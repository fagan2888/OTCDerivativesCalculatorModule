using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GbmGreekInfoResultViewModel : UnderylingResultViewModel
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
            xmlWriter.WriteStartElement("underylingResult");
                xmlWriter.WriteElementString("type" , "gbmGreekInfoResult");
                xmlWriter.WriteStartElement("gbmGreekInfoResult");
                    foreach (var item in gbmGreekResultViewModel_)
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
            Control v = new GbmGreekInfoResultView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderylingResult serial_UnderylingResult = serial_Class as FpmlSerializedCSharp.UnderylingResult;
            FpmlSerializedCSharp.GbmGreekInfoResult serial_GbmGreekInfoResult = serial_UnderylingResult.GbmGreekInfoResult_;
        
            List<FpmlSerializedCSharp.GbmGreekResult> serial_gbmGreekResult = serial_GbmGreekInfoResult.GbmGreekResult_;
            this.gbmGreekResultViewModel_ = new ObservableCollection<GbmGreekResultViewModel>();
            foreach (var item in serial_gbmGreekResult)
            {
                string type = item.Excel_type_.ValueStr;
                GbmGreekResultViewModel viewModel = GbmGreekResultViewModel.CreateGbmGreekResult(type);
                viewModel.setFromSerial(item);
                this.gbmGreekResultViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

