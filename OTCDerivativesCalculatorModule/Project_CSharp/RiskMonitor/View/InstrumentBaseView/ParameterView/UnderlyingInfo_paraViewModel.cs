using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class UnderlyingInfo_paraViewModel : IXmlData
    {
        #region View_
        private Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

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

        public UnderlyingInfo_paraViewModel() 
        {
            this.underlying_paraViewModel_ = new ObservableCollection<Underlying_paraViewModel>();
        }

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

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("underlyingInfo_para");

            foreach (var item in underlying_paraViewModel_)
            {
                item.buildXml(xmlWriter);
            }

            this.correlationInfo_paraViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderlyingInfo_para serial_UnderlyingInfo_para = serial_Class as FpmlSerializedCSharp.UnderlyingInfo_para;
        
            List<FpmlSerializedCSharp.Underlying_para> serial_underlying_para = serial_UnderlyingInfo_para.Underlying_para_;
            this.underlying_paraViewModel_ = new ObservableCollection<Underlying_paraViewModel>();
            foreach (var item in serial_underlying_para)
            {
                string type = item.Type_.ValueStr;
                Underlying_paraViewModel viewModel = Underlying_paraViewModel.CreateUnderlying_para(type);
                viewModel.setFromSerial(item);
                this.underlying_paraViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.CorrelationInfo_para serial_correlationInfo_para = serial_UnderlyingInfo_para.CorrelationInfo_para_;
            this.correlationInfo_paraViewModel_ = new CorrelationInfo_paraViewModel();
            this.correlationInfo_paraViewModel_.setFromSerial(serial_correlationInfo_para);
            
           //this.view_ = new UnderlyingInfo_paraView();
            this.view_.DataContext = this;
        }

        //preSetting을 위함
        //setting 나중에 고려
        public void initializeParameter(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.UnderlyingInformation xml_underInfo = serial_Class as FpmlSerializedCSharp.UnderlyingInformation;

            //FpmlSerializedCSharp.IndexUnderInfo xml_indexUnderInfo = xml_underInfo.IndexUnderInfo_;
            //List<FpmlSerializedCSharp.Index> indexList =  xml_indexUnderInfo.Index_;

            //foreach (var item in indexList)
            //{
            //    Underlying_paraViewModel vm = Underlying_paraViewModel.CreateUnderlying_para("");
                
            //}

            //this.correlationInfo_paraViewModel_ = new CorrelationInfo_paraViewModel();
            //this.correlationInfo_paraViewModel_.initializeParameter(serial_Class);

            //xml_underInfo.
        }

        public void initializeParameter(IndexUnderInfoViewModel indexUnderInfoVM)
        {
            foreach (var item in indexUnderInfoVM.IndexUnderList_)
            {
                string typeStr = item.Type_;
                Underlying_paraViewModel vm = Underlying_paraViewModel.CreateUnderlying_para("geometricBM");
                vm.KrCode_ = item.KRCode_;
                vm.UnderName_ = item.Name_;

            }

            this.correlationInfo_paraViewModel_ = new CorrelationInfo_paraViewModel();
            this.correlationInfo_paraViewModel_.initializeParameter(indexUnderInfoVM);
        }
    }
    
}

