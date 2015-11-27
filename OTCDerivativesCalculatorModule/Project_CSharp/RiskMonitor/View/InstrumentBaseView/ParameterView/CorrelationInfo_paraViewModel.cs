using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CorrelationInfo_paraViewModel : IXmlData
    {
        #region View_
        protected Control view_;
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
        
        public CorrelationInfo_paraViewModel() 
        {
            this.correlation_paraViewModel_ = new ObservableCollection<Correlation_paraViewModel>();
            this.underlyingList_ = new ObservableCollection<string>();
            this.correlationDataList_ = new ObservableCollection<Correlation>();
            this.view_ = new CorrelationInfo_paraView();
            this.view_.DataContext = this;

        }
    
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

        #region UnderlyingList_
        private ObservableCollection<string> underlyingList_;
        public ObservableCollection<string> UnderlyingList_
        {
            get { return this.underlyingList_; }
            set
            {
                if (this.underlyingList_ != value)
                {
                    this.underlyingList_ = value;
                    this.NotifyPropertyChanged("UnderlyingList_");
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

        #region CorrelationDataList_
        private ObservableCollection<Correlation> correlationDataList_;
        public ObservableCollection<Correlation> CorrelationDataList_
        {
            get { return this.correlationDataList_; }
            set
            {
                if (this.correlationDataList_ != value)
                {
                    this.correlationDataList_ = value;
                    this.NotifyPropertyChanged("CorrelationDataList_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_correlationInfo_para");
            xmlWriter.WriteElementString("dimension", this.dimension_);

            foreach (var item in correlationDataList_)
            {
                xmlWriter.WriteStartElement("excel_correlation_para");

                    xmlWriter.WriteElementString("first", item.first_);
                    xmlWriter.WriteElementString("second", item.second_);
                    xmlWriter.WriteElementString("value", item.value_);

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();

            //// 이거 otccal때매 만든거임... //2014-05-16
            //this.buildPricingXml(xmlWriter);
        }

        public void buildPricingXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("correlationInfo_para");

                xmlWriter.WriteElementString("dimension", this.dimension_);

                foreach (var item in correlation_paraViewModel_)
                {
                    item.buildXml(xmlWriter);
                }

            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CorrelationInfo_para serial_CorrelationInfo_para = serial_Class as FpmlSerializedCSharp.CorrelationInfo_para;
        
            this.dimension_ = serial_CorrelationInfo_para.Dimension_.ValueStr;
            
            List<FpmlSerializedCSharp.Correlation_para> serial_correlation_para = serial_CorrelationInfo_para.Correlation_para_;
            this.correlation_paraViewModel_ = new ObservableCollection<Correlation_paraViewModel>();
            foreach (var item in serial_correlation_para)
            {
                Correlation_paraViewModel viewModel = new Correlation_paraViewModel();
                viewModel.setFromSerial(item);
                this.correlation_paraViewModel_.Add(viewModel);
            }
            
            this.view_ = new CorrelationInfo_paraView();
            this.view_.DataContext = this;
        }

        public void initializeParameter(IndexUnderInfoViewModel indexUnderInfoVM)
        {
            int count = indexUnderInfoVM.IndexUnderList_.Count;

            this.correlation_paraViewModel_ = new ObservableCollection<Correlation_paraViewModel>();

            // comination 계산

            //for (int i = 0; i < length; i++)
            //{
			 
            //}

            if(count==2)
            {
                Correlation_paraViewModel corrVM = new Correlation_paraViewModel();
                corrVM.First_ = indexUnderInfoVM.IndexUnderList_[0].Name_;
                corrVM.Second_ = indexUnderInfoVM.IndexUnderList_[1].Name_;

                this.correlation_paraViewModel_.Add(corrVM);
            }

        }



        

        public void loadMarketData(DateTime referenceDate)
        {
            this.dimension_ = "2";
        }

        //public void buildParaSetting(ParameterSettingManager paraSettingManager)
        //{
        //    throw new NotImplementedException();
        //}

        public class Correlation
        {
            public Correlation() { }

            public string first_ { get; set; }
            public string second_ { get; set; }
            public string value_ { get; set; }
        }



    }
    
}



