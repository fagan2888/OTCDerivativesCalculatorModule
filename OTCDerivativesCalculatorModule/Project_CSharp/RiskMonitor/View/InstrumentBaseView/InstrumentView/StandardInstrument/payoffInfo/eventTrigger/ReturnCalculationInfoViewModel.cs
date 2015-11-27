using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
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
    
        public ReturnCalculationInfoViewModel() 
        {
            this.returnCalculationViewModel_ = new ObservableCollection<ReturnCalculationViewModel>();
        }
    
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
            xmlWriter.WriteStartElement("returnCalculationInfo");

            foreach (var item in returnCalculationViewModel_)
            {
                item.buildXml(xmlWriter);
                    
            }
                
            if (operatorNDViewModel_ != null)
                operatorNDViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculationInfo serial_ReturnCalculationInfo = serial_Class as FpmlSerializedCSharp.ReturnCalculationInfo;
        
            List<FpmlSerializedCSharp.ReturnCalculation> serial_returnCalculation = serial_ReturnCalculationInfo.ReturnCalculation_;
            this.returnCalculationViewModel_ = new ObservableCollection<ReturnCalculationViewModel>();
            foreach (var item in serial_returnCalculation)
            {
                string type = item.Type_.ValueStr;
                ReturnCalculationViewModel viewModel = ReturnCalculationViewModel.CreateReturnCalculation(type);
                viewModel.setFromSerial(item);
                this.returnCalculationViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.OperatorND serial_operatorND = serial_ReturnCalculationInfo.OperatorND_;
            string operatorNDtype = serial_operatorND.Type_.ValueStr;
            this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(operatorNDtype);
            this.operatorNDViewModel_.setFromSerial(serial_operatorND);
            
            ////this.view_ = new ReturnCalculationInfoView();
            //this.view_.DataContext = this;
        }
    
        //#region SelectReturnCalculationInfo_
            //private string selectReturnCalculationInfo_;
            //public string SelectReturnCalculationInfo_
            //{
            //    get { return this.selectReturnCalculationInfo_; }
            //    set
            //    {
            //        if (this.selectReturnCalculationInfo_ != value)
            //        {
            //            this.selectReturnCalculationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReturnCalculationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReturnCalculationInfo(string typeStr)
            //{
            //    this.returnCalculationViewModel_ = ReturnCalculationViewModel.CreateReturnCalculation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectOperatorNDInfo_
            //private string selectOperatorNDInfo_;
            //public string SelectOperatorNDInfo_
            //{
            //    get { return this.selectOperatorNDInfo_; }
            //    set
            //    {
            //        if (this.selectOperatorNDInfo_ != value)
            //        {
            //            this.selectOperatorNDInfo_ = value;
            //            this.NotifyPropertyChanged("SelectOperatorNDInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectOperatorNDInfo(string typeStr)
            //{
            //    this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(typeStr);
            //    this.view_.DataContext = this;
            //}
    
    }
    
}

