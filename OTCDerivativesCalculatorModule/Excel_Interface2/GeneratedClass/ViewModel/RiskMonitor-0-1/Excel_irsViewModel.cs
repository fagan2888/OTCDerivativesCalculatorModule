using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_irsViewModel : Excel_swapInterfaceViewModel
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
        
        public Excel_irsViewModel() { }
        
        #region Excel_swapLegViewModel_
        private ObservableCollection<Excel_swapLegViewModel> excel_swapLegViewModel_;
        public ObservableCollection<Excel_swapLegViewModel> Excel_swapLegViewModel_
        {
            get { return this.excel_swapLegViewModel_; }
            set
            {
                if (this.excel_swapLegViewModel_ != value)
                {
                    this.excel_swapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapLegViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapInterface");
                xmlWriter.WriteElementString("excel_type" , "excel_irs");
                xmlWriter.WriteStartElement("excel_irs");
                    foreach (var item in excel_swapLegViewModel_)
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
            Control v = new Excel_irsView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_swapInterface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_irs serial_Excel_irs = serial_Excel_swapInterface.Excel_irs_;
        
            List<FpmlSerializedCSharp.Excel_swapLeg> serial_excel_swapLeg = serial_Excel_irs.Excel_swapLeg_;
            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();
            foreach (var item in serial_excel_swapLeg)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_swapLegViewModel viewModel = Excel_swapLegViewModel.CreateExcel_swapLeg(type);
                viewModel.setFromSerial(item);
                this.excel_swapLegViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

