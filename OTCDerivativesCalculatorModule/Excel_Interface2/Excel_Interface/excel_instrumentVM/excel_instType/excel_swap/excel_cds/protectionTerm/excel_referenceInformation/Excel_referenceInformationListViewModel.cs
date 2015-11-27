using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_referenceInformationListViewModel : IXmlData
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
        
        public Excel_referenceInformationListViewModel() 
        {
            this.excel_referenceInformationViewModel_ = new ObservableCollection<Excel_referenceInformationViewModel>();
        }
        
        #region Excel_referenceInformationViewModel_
        private ObservableCollection<Excel_referenceInformationViewModel> excel_referenceInformationViewModel_;
        public ObservableCollection<Excel_referenceInformationViewModel> Excel_referenceInformationViewModel_
        {
            get { return this.excel_referenceInformationViewModel_; }
            set
            {
                if (this.excel_referenceInformationViewModel_ != value)
                {
                    this.excel_referenceInformationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceInformationViewModel_");
                }
            }
        }
        #endregion

        public void addReferenceInfoVM(Excel_referenceInformationViewModel e_rivm)
        {
            excel_referenceInformationViewModel_.Add(e_rivm);
            this.NotifyPropertyChanged("Excel_referenceInformationViewModel_");
        }

        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_referenceInformationList");

            foreach (var item in excel_referenceInformationViewModel_)
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
            Control v = new Excel_referenceInformationListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceInformationList serial_Excel_referenceInformationList = serial_Class as FpmlSerializedCSharp.Excel_referenceInformationList;
        
            List<FpmlSerializedCSharp.Excel_referenceInformation> serial_excel_referenceInformation = serial_Excel_referenceInformationList.Excel_referenceInformation_;
            this.excel_referenceInformationViewModel_ = new ObservableCollection<Excel_referenceInformationViewModel>();
            foreach (var item in serial_excel_referenceInformation)
            {
                //string type = item.Excel_type_.ValueStr;
                Excel_referenceInformationViewModel viewModel = new Excel_referenceInformationViewModel();
                viewModel.setFromSerial(item);
                this.excel_referenceInformationViewModel_.Add(viewModel);
            }
            
        }


    }
    
}

