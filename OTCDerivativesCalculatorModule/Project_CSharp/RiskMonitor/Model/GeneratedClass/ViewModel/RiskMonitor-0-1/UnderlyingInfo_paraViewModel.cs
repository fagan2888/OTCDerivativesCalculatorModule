using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class UnderlyingInfo_paraViewModel : IXmlData
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
        
        public UnderlyingInfo_paraViewModel() { }
        
        #region Underlying_paraViewModel_
        private ObservableCollection<Underlying_paraViewModel> underlying_paraViewModel_;
        public ObservableCollection<Underlying_paraViewModel> Underlying_paraViewModel_
        {
            get { return this.underlying_paraViewModel_; }
            set
            {
                if (this.underlying_paraViewModel_ != value)
                {
                    this.underlying_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Underlying_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region CorrelationInfo_paraViewModel_
        private CorrelationInfo_paraViewModel correlationInfo_paraViewModel_;
        public CorrelationInfo_paraViewModel CorrelationInfo_paraViewModel_
        {
            get { return this.correlationInfo_paraViewModel_; }
            set
            {
                if (this.correlationInfo_paraViewModel_ != value)
                {
                    this.correlationInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("CorrelationInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "underlyingInfo_para");
                xmlWriter.WriteStartElement("underlyingInfo_para");
                    foreach (var item in underlying_paraViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    correlationInfo_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new UnderlyingInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderlyingInfo_para serial_UnderlyingInfo_para = serial_Class as FpmlSerializedCSharp.UnderlyingInfo_para;
        
            List<FpmlSerializedCSharp.Underlying_para> serial_underlying_para = serial_UnderlyingInfo_para.Underlying_para_;
            this.underlying_paraViewModel_ = new ObservableCollection<Underlying_paraViewModel>();
            foreach (var item in serial_underlying_para)
            {
                string type = item.Excel_type_.ValueStr;
                Underlying_paraViewModel viewModel = Underlying_paraViewModel.CreateUnderlying_para(type);
                viewModel.setFromSerial(item);
                this.underlying_paraViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.CorrelationInfo_para serial_correlationInfo_para = serial_UnderlyingInfo_para.CorrelationInfo_para_;
            string correlationInfo_paratype = serial_correlationInfo_para.Excel_type_.ValueStr;
            this.correlationInfo_paraViewModel_ = CorrelationInfo_paraViewModel.CreateCorrelationInfo_para(correlationInfo_paratype);
            this.correlationInfo_paraViewModel_.setFromSerial(serial_correlationInfo_para);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

