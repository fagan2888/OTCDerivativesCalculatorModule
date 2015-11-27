using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_greekResultViewModel : IXmlData
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
        
        public Excel_greekResultViewModel() 
        {
            this.excel_greekUnderlyingViewModel_ = new ObservableCollection<Excel_greekUnderlyingViewModel>();
        }
        
        #region Excel_greekUnderlyingViewModel_
        private ObservableCollection<Excel_greekUnderlyingViewModel> excel_greekUnderlyingViewModel_;
        public ObservableCollection<Excel_greekUnderlyingViewModel> Excel_greekUnderlyingViewModel_
        {
            get { return this.excel_greekUnderlyingViewModel_; }
            set
            {
                if (this.excel_greekUnderlyingViewModel_ != value)
                {
                    this.excel_greekUnderlyingViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_greekUnderlyingViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            //xmlWriter.WriteElementString("excel_type" , "excel_greekResult");
            xmlWriter.WriteStartElement("excel_greekResult");
                foreach (var item in excel_greekUnderlyingViewModel_)
                {
                    item.buildXml(xmlWriter);
                }
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_greekResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_greekResult serial_Excel_greekResult = serial_Class as FpmlSerializedCSharp.Excel_greekResult;
        
            List<FpmlSerializedCSharp.Excel_greekUnderlying> serial_excel_greekUnderlying = serial_Excel_greekResult.Excel_greekUnderlying_;
            this.excel_greekUnderlyingViewModel_ = new ObservableCollection<Excel_greekUnderlyingViewModel>();
            foreach (var item in serial_excel_greekUnderlying)
            {
                Excel_greekUnderlyingViewModel viewModel = new Excel_greekUnderlyingViewModel();
                viewModel.setFromSerial(item);
                this.excel_greekUnderlyingViewModel_.Add(viewModel);
            }
            
        }


    
            
            
        
    
        
    
    }
    
}

