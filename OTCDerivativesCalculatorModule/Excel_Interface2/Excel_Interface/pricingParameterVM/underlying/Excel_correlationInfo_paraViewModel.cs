using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_correlationInfo_paraViewModel : IXmlData
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
        
        public Excel_correlationInfo_paraViewModel() 
        {
            this.excel_correlation_paraViewModel_ = new ObservableCollection<Excel_correlation_paraViewModel>();
            this.underlyingList_ = new ObservableCollection<string>();
        }
        
        #region Dimension_
        private int dimension_;
        public int Dimension_
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
        
        #region Excel_correlation_paraViewModel_
        private ObservableCollection<Excel_correlation_paraViewModel> excel_correlation_paraViewModel_;
        public ObservableCollection<Excel_correlation_paraViewModel> Excel_correlation_paraViewModel_
        {
            get { return this.excel_correlation_paraViewModel_; }
            set
            {
                if (this.excel_correlation_paraViewModel_ != value)
                {
                    this.excel_correlation_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_correlation_paraViewModel_");
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

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_correlationInfo_para");
                xmlWriter.WriteElementString("dimension" , this.dimension_.ToString());

                foreach (var item in this.excel_correlation_paraViewModel_)
                {
                    item.buildXml(xmlWriter);    
                }
                    
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public Control view()
        {
            Control v = new Excel_correlationInfo_paraView();

            v.DataContext = this;
            
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_correlationInfo_para serial_Excel_correlationInfo_para = serial_Class as FpmlSerializedCSharp.Excel_correlationInfo_para;
        
            this.dimension_ = serial_Excel_correlationInfo_para.Dimension_.IntValue();
            
            List<FpmlSerializedCSharp.Excel_correlation_para> serial_excel_correlation_para = serial_Excel_correlationInfo_para.Excel_correlation_para_;
            this.excel_correlation_paraViewModel_ = new ObservableCollection<Excel_correlation_paraViewModel>();
            foreach (var item in serial_excel_correlation_para)
            {
                //string type = item.Excel_type_.ValueStr;
                Excel_correlation_paraViewModel viewModel = new Excel_correlation_paraViewModel();
                viewModel.setFromSerial(item);
                this.excel_correlation_paraViewModel_.Add(viewModel);
            }
            
        }

        //public void initializeParameter(IndexUnderInfoViewModel indexUnderInfoVM)
        //{
        //    int count = indexUnderInfoVM.IndexUnderList_.Count;

        //    this.correlation_paraViewModel_ = new ObservableCollection<Correlation_paraViewModel>();

        //    // comination 계산

        //    //for (int i = 0; i < length; i++)
        //    //{

        //    //}

        //    if (count == 2)
        //    {
        //        Correlation_paraViewModel corrVM = new Correlation_paraViewModel();
        //        corrVM.First_ = indexUnderInfoVM.IndexUnderList_[0].Name_;
        //        corrVM.Second_ = indexUnderInfoVM.IndexUnderList_[1].Name_;

        //        this.correlation_paraViewModel_.Add(corrVM);
        //    }

        //}

        //public void addUnderlying(string under)
        //{
        //    int preUnderNum = this.underlyingList_.Count;

        //    this.underlyingList_.Add(under);


        //    Correlation_paraViewModel diagCorrVM = new Correlation_paraViewModel();

        //    diagCorrVM.First_ = under;
        //    diagCorrVM.Second_ = under;
        //    diagCorrVM.Value_ = "1.0";

        //    this.correlation_paraViewModel_.Add(diagCorrVM);

        //    for (int i = 0; i < preUnderNum; i++)
        //    {
        //        Correlation corr = new Correlation();


        //        // 새롭게 추가된 underlying을 넣음
        //        corr.first_ = under;

        //        // 기존꺼를 넣음
        //        corr.second_ = this.underlyingList_[i];

        //        // value는 default 0 이 드감.

        //        corr.value_ = "0.0";

        //        this.correlationDataList_.Add(corr);

        //        Correlation_paraViewModel corrVM_1 = new Correlation_paraViewModel();

        //        corrVM_1.First_ = under;
        //        corrVM_1.Second_ = this.underlyingList_[i];
        //        corrVM_1.Value_ = "0.0";

        //        this.correlation_paraViewModel_.Add(corrVM_1);

        //        Correlation_paraViewModel corrVM_2 = new Correlation_paraViewModel();

        //        corrVM_2.First_ = this.underlyingList_[i];
        //        corrVM_2.Second_ = under;
        //        corrVM_2.Value_ = "0.0";

        //        this.correlation_paraViewModel_.Add(corrVM_2);

        //    }

        //    this.dimension_ = (preUnderNum + 1).ToString();

        //    //this.correlationDataList_

        //    //this.NotifyPropertyChanged("AddUnderlying");


        //}

        public void removeUnderlying(string under)
        {

            //foreach (var item in this.correlation_paraViewModel_)
            //{
            //    if (item.First_ == under)
            //    {
            //        this.correlation_paraViewModel_.Remove(item);
            //    }
            //}

            //foreach (var item in this.correlation_paraViewModel_)
            //{
            //    if (item.Second_ == under)
            //    {
            //        this.correlation_paraViewModel_.Remove(item);
            //    }
            //}

            //this.underlyingList_.Add(under);
            //this.NotifyPropertyChanged("removeUnderlying");
        }

        public void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.excel_correlation_paraViewModel_
                = paraSettingManager.UnderlyingParaSetting_.CorrelationParaSetting_.corrInfo(
                paraSettingManager.Excel_InstrumentViewModel_.Excel_interfaceViewModel_.getExcel_underlyingCalcInfoViewModel());

            this.dimension_ = paraSettingManager.Excel_InstrumentViewModel_.Excel_interfaceViewModel_.getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_.Count;
        }

        public void loadMarketData(DateTime referenceDate)
        {
            throw new NotImplementedException();
        }

        public void addUnderlying(string under)
        {
            throw new NotImplementedException();
        }

        public void addDiagonal(Excel_underlyingInfo_paraViewModel e_ui_pvm)
        {

            string under = e_ui_pvm.KrCode_;

            this.underlyingList_.Add(under);

            this.dimension_ += 1;

            Excel_correlation_paraViewModel diagCorrVM = new Excel_correlation_paraViewModel();

            diagCorrVM.First_ = under;
            diagCorrVM.Second_ = under;
            diagCorrVM.Value_ = "1.0";

            this.excel_correlation_paraViewModel_.Add(diagCorrVM);
            
        }

        public void addDiagonal(string underCode)
        {
            string under = underCode;

            this.underlyingList_.Add(under);

            this.dimension_ += 1;

            Excel_correlation_paraViewModel diagCorrVM = new Excel_correlation_paraViewModel();

            diagCorrVM.First_ = under;
            diagCorrVM.Second_ = under;
            diagCorrVM.Value_ = "1.0";

            this.excel_correlation_paraViewModel_.Add(diagCorrVM);

        }

        public void setCorrelation(Excel_correlation_paraViewModel e_corrVM)
        {
            foreach (var item in this.excel_correlation_paraViewModel_)
            {
                if (e_corrVM.First_ == item.First_ && e_corrVM.Second_ == item.Second_)
                {
                    item.First_ = e_corrVM.First_;
                    item.Second_ = e_corrVM.Second_;
                    item.Value_ = e_corrVM.Value_;

                    return;
                }
            }

            // 없을 경우
            this.excel_correlation_paraViewModel_.Add(e_corrVM);

        }

        public void setCorrelation(string first,string second, double value)
        {
            foreach (var item in this.excel_correlation_paraViewModel_)
            {
                if (first == item.First_ && second == item.Second_)
                {
                    item.First_ = first;
                    item.Second_ = second;
                    item.Value_ = value.ToString();

                    return;
                }
            }

            // 없을 경우

            Excel_correlation_paraViewModel e_cpvm = new Excel_correlation_paraViewModel();

            e_cpvm.First_ = first;
            e_cpvm.Second_ = second;
            e_cpvm.Value_ = value.ToString();

            this.excel_correlation_paraViewModel_.Add(e_cpvm);
        }

        //public void updateDimensionAndDiagonal()
        //{
        //    List<string> underList = new List<string>();

        //    foreach (var item in excel_correlation_paraViewModel_)
        //    {
        //        if (underList.IndexOf(item.First_) == -1)
        //        { 
                    
        //        }

        //        if (underList.IndexOf(item.Second_) == -1)
        //        {

        //        }


        //    }
        //}
    }
    
}

