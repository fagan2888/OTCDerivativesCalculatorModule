using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CorrelationInfo_paraViewModel : IXmlData
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
        
        public CorrelationInfo_paraViewModel() { }
        
        #region Dimension_
        private string dimension_;
        public string Dimension_
        {
            get { return this.dimension_; }
            set
            {
                if (this.dimension_ != value)
                {
                    this.dimension_ = value;
                    this.NotifyPropertyChanged("Dimension_");
                }
            }
        }
        #endregion
        
        #region Correlation_paraViewModel_
        private ObservableCollection<Correlation_paraViewModel> correlation_paraViewModel_;
        public ObservableCollection<Correlation_paraViewModel> Correlation_paraViewModel_
        {
            get { return this.correlation_paraViewModel_; }
            set
            {
                if (this.correlation_paraViewModel_ != value)
                {
                    this.correlation_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Correlation_paraViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "correlationInfo_para");
                xmlWriter.WriteStartElement("correlationInfo_para");
                    xmlWriter.WriteElementString("dimension" , this.dimension_);
                    
                    foreach (var item in correlation_paraViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CorrelationInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CorrelationInfo_para serial_CorrelationInfo_para = serial_Class as FpmlSerializedCSharp.CorrelationInfo_para;
        
            this.dimension_ = serial_CorrelationInfo_para.Dimension_.ValueStr;
            
            List<FpmlSerializedCSharp.Correlation_para> serial_correlation_para = serial_CorrelationInfo_para.Correlation_para_;
            this.correlation_paraViewModel_ = new ObservableCollection<Correlation_paraViewModel>();
            foreach (var item in serial_correlation_para)
            {
                string type = item.Excel_type_.ValueStr;
                Correlation_paraViewModel viewModel = Correlation_paraViewModel.CreateCorrelation_para(type);
                viewModel.setFromSerial(item);
                this.correlation_paraViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

