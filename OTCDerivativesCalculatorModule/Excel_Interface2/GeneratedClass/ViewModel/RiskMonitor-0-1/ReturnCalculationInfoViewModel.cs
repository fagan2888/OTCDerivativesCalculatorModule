using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReturnCalculationInfoViewModel : IXmlData
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
        
        public ReturnCalculationInfoViewModel() { }
        
        #region ReturnCalculationViewModel_
        private ObservableCollection<ReturnCalculationViewModel> returnCalculationViewModel_;
        public ObservableCollection<ReturnCalculationViewModel> ReturnCalculationViewModel_
        {
            get { return this.returnCalculationViewModel_; }
            set
            {
                if (this.returnCalculationViewModel_ != value)
                {
                    this.returnCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region OperatorNDViewModel_
        private OperatorNDViewModel operatorNDViewModel_;
        public OperatorNDViewModel OperatorNDViewModel_
        {
            get { return this.operatorNDViewModel_; }
            set
            {
                if (this.operatorNDViewModel_ != value)
                {
                    this.operatorNDViewModel_ = value;
                    this.NotifyPropertyChanged("OperatorNDViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "returnCalculationInfo");
                xmlWriter.WriteStartElement("returnCalculationInfo");
                    foreach (var item in returnCalculationViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    operatorNDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ReturnCalculationInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculationInfo serial_ReturnCalculationInfo = serial_Class as FpmlSerializedCSharp.ReturnCalculationInfo;
        
            List<FpmlSerializedCSharp.ReturnCalculation> serial_returnCalculation = serial_ReturnCalculationInfo.ReturnCalculation_;
            this.returnCalculationViewModel_ = new ObservableCollection<ReturnCalculationViewModel>();
            foreach (var item in serial_returnCalculation)
            {
                string type = item.Excel_type_.ValueStr;
                ReturnCalculationViewModel viewModel = ReturnCalculationViewModel.CreateReturnCalculation(type);
                viewModel.setFromSerial(item);
                this.returnCalculationViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.OperatorND serial_operatorND = serial_ReturnCalculationInfo.OperatorND_;
            string operatorNDtype = serial_operatorND.Excel_type_.ValueStr;
            this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(operatorNDtype);
            this.operatorNDViewModel_.setFromSerial(serial_operatorND);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

