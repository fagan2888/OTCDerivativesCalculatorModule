using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fxSwapViewModel : Excel_interfaceViewModel
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
        
        public Excel_fxSwapViewModel() { }
        
        #region Excel_issueInfoViewModel_
        private Excel_issueInfoViewModel excel_issueInfoViewModel_;
        public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        {
            get { return this.excel_issueInfoViewModel_; }
            set
            {
                if (this.excel_issueInfoViewModel_ != value)
                {
                    this.excel_issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Fx_exchangeLegViewModel_
        private ObservableCollection<Fx_exchangeLegViewModel> fx_exchangeLegViewModel_;
        public ObservableCollection<Fx_exchangeLegViewModel> Fx_exchangeLegViewModel_
        {
            get { return this.fx_exchangeLegViewModel_; }
            set
            {
                if (this.fx_exchangeLegViewModel_ != value)
                {
                    this.fx_exchangeLegViewModel_ = value;
                    this.NotifyPropertyChanged("Fx_exchangeLegViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_fxSwap");
                xmlWriter.WriteStartElement("excel_fxSwap");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in fx_exchangeLegViewModel_)
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
            Control v = new Excel_fxSwapView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_fxSwap serial_Excel_fxSwap = serial_Excel_interface.Excel_fxSwap_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_fxSwap.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            List<FpmlSerializedCSharp.Fx_exchangeLeg> serial_fx_exchangeLeg = serial_Excel_fxSwap.Fx_exchangeLeg_;
            this.fx_exchangeLegViewModel_ = new ObservableCollection<Fx_exchangeLegViewModel>();
            foreach (var item in serial_fx_exchangeLeg)
            {
                string type = item.Excel_type_.ValueStr;
                Fx_exchangeLegViewModel viewModel = Fx_exchangeLegViewModel.CreateFx_exchangeLeg(type);
                viewModel.setFromSerial(item);
                this.fx_exchangeLegViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

