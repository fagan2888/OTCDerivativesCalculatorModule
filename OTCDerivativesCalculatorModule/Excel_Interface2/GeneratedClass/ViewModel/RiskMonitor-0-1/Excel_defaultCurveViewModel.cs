using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_defaultCurveViewModel : IXmlData
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
        
        public Excel_defaultCurveViewModel() { }
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion
        
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion
        
        #region Recovery_
        private string recovery_;
        public string Recovery_
        {
            get { return this.recovery_; }
            set
            {
                if (this.recovery_ != value)
                {
                    this.recovery_ = value;
                    this.NotifyPropertyChanged("Recovery_");
                }
            }
        }
        #endregion
        
        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion
        
        #region Excel_interpolationViewModel_
        private Excel_interpolationViewModel excel_interpolationViewModel_;
        public Excel_interpolationViewModel Excel_interpolationViewModel_
        {
            get { return this.excel_interpolationViewModel_; }
            set
            {
                if (this.excel_interpolationViewModel_ != value)
                {
                    this.excel_interpolationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interpolationViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_rateDataViewModel_
        private ObservableCollection<Excel_rateDataViewModel> excel_rateDataViewModel_;
        public ObservableCollection<Excel_rateDataViewModel> Excel_rateDataViewModel_
        {
            get { return this.excel_rateDataViewModel_; }
            set
            {
                if (this.excel_rateDataViewModel_ != value)
                {
                    this.excel_rateDataViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_rateDataViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_defaultCurve");
                xmlWriter.WriteStartElement("excel_defaultCurve");
                    xmlWriter.WriteElementString("code" , this.code_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    xmlWriter.WriteElementString("recovery" , this.recovery_);
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                    excel_interpolationViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in excel_rateDataViewModel_)
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
            Control v = new Excel_defaultCurveView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_defaultCurve serial_Excel_defaultCurve = serial_Class as FpmlSerializedCSharp.Excel_defaultCurve;
        
            this.code_ = serial_Excel_defaultCurve.Code_.ValueStr;
            
            this.name_ = serial_Excel_defaultCurve.Name_.ValueStr;
            
            this.recovery_ = serial_Excel_defaultCurve.Recovery_.ValueStr;
            
            this.description_ = serial_Excel_defaultCurve.Description_.ValueStr;
            
            FpmlSerializedCSharp.Excel_interpolation serial_excel_interpolation = serial_Excel_defaultCurve.Excel_interpolation_;
            string excel_interpolationtype = serial_excel_interpolation.Excel_type_.ValueStr;
            this.excel_interpolationViewModel_ = Excel_interpolationViewModel.CreateExcel_interpolation(excel_interpolationtype);
            this.excel_interpolationViewModel_.setFromSerial(serial_excel_interpolation);
            
            List<FpmlSerializedCSharp.Excel_rateData> serial_excel_rateData = serial_Excel_defaultCurve.Excel_rateData_;
            this.excel_rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();
            foreach (var item in serial_excel_rateData)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_rateDataViewModel viewModel = Excel_rateDataViewModel.CreateExcel_rateData(type);
                viewModel.setFromSerial(item);
                this.excel_rateDataViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

