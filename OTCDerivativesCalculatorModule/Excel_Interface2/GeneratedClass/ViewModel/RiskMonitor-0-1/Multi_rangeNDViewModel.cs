using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Multi_rangeNDViewModel : IXmlData
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
        
        public Multi_rangeNDViewModel() { }
        
        #region Joint_type_
        private string joint_type_;
        public string Joint_type_
        {
            get { return this.joint_type_; }
            set
            {
                if (this.joint_type_ != value)
                {
                    this.joint_type_ = value;
                    this.NotifyPropertyChanged("Joint_type_");
                }
            }
        }
        #endregion
        
        #region Range1DViewModel_
        private ObservableCollection<Range1DViewModel> range1DViewModel_;
        public ObservableCollection<Range1DViewModel> Range1DViewModel_
        {
            get { return this.range1DViewModel_; }
            set
            {
                if (this.range1DViewModel_ != value)
                {
                    this.range1DViewModel_ = value;
                    this.NotifyPropertyChanged("Range1DViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingCalcIDViewModel_
        private ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDViewModel_;
        public ObservableCollection<Excel_underlyingCalcIDViewModel> Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "multi_rangeND");
                xmlWriter.WriteStartElement("multi_rangeND");
                    xmlWriter.WriteElementString("joint_type" , this.joint_type_);
                    
                    foreach (var item in range1DViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    foreach (var item in excel_underlyingCalcIDViewModel_)
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
            Control v = new Multi_rangeNDView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Multi_rangeND serial_Multi_rangeND = serial_Class as FpmlSerializedCSharp.Multi_rangeND;
        
            this.joint_type_ = serial_Multi_rangeND.Joint_type_.ValueStr;
            
            List<FpmlSerializedCSharp.Range1D> serial_range1D = serial_Multi_rangeND.Range1D_;
            this.range1DViewModel_ = new ObservableCollection<Range1DViewModel>();
            foreach (var item in serial_range1D)
            {
                string type = item.Excel_type_.ValueStr;
                Range1DViewModel viewModel = Range1DViewModel.CreateRange1D(type);
                viewModel.setFromSerial(item);
                this.range1DViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Multi_rangeND.Excel_underlyingCalcID_;
            this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();
            foreach (var item in serial_excel_underlyingCalcID)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingCalcIDViewModel viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingCalcIDViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

