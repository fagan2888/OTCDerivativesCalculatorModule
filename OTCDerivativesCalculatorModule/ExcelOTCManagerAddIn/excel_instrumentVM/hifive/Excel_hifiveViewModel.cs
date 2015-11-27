using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_hifiveViewModel : Excel_interfaceViewModel
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
        
    
        public Excel_hifiveViewModel() { }
        
    
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
        
        #region Excel_underlyingCalcInfoViewModel_
        private Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { return this.excel_underlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
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

        
        // sub Type 즐겨찾기용
        #region Excel_hifive_subtypeViewModel_
        private Excel_hifive_subtypeViewModel excel_hifive_subtypeViewModel_;
        public Excel_hifive_subtypeViewModel Excel_hifive_subtypeViewModel_
        {
            get { return this.excel_hifive_subtypeViewModel_; }
            set
            {
                if (this.excel_hifive_subtypeViewModel_ != value)
                {
                    this.excel_hifive_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifive_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_scheduleListViewModel_
        private Excel_scheduleListViewModel excel_scheduleListViewModel_;
        public Excel_scheduleListViewModel Excel_scheduleListViewModel_
        {
            get { return this.excel_scheduleListViewModel_; }
            set
            {
                if (this.excel_scheduleListViewModel_ != value)
                {
                    this.excel_scheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_scheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_kiScheduleListViewModel_
        private Excel_kiScheduleListViewModel excel_kiScheduleListViewModel_;
        public Excel_kiScheduleListViewModel Excel_kiScheduleListViewModel_
        {
            get { return this.excel_kiScheduleListViewModel_; }
            set
            {
                if (this.excel_kiScheduleListViewModel_ != value)
                {
                    this.excel_kiScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_kiScheduleListViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("type" , "excel_hifive");
                xmlWriter.WriteStartElement("excel_hifive");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    foreach (var item in excel_underlyingCalcIDViewModel_)
                    {
                        item.buildXml(xmlWriter);    
                    }
                    
                    excel_hifive_subtypeViewModel_.buildXml(xmlWriter);
                    
                    excel_scheduleListViewModel_.buildXml(xmlWriter);
                    
                    excel_kiScheduleListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        //load part임
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            //FpmlSerializedCSharp.Excel_hifive serial_Excel_hifive = serial_Excel_interface.Excel_hifive_;
        
            //FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_hifive.Excel_issueInfo_;
            //string excel_issueInfotype = serial_excel_issueInfo.Type_.ValueStr;
            //this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            //this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            //FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_hifive.Excel_underlyingCalcInfo_;
            //string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Type_.ValueStr;
            //this.excel_underlyingCalcInfoViewModel_ = Excel_underlyingCalcInfoViewModel.CreateExcel_underlyingCalcInfo(excel_underlyingCalcInfotype);
            //this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            //List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Excel_hifive.Excel_underlyingCalcID_;
            //this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();
            //foreach (var item in serial_excel_underlyingCalcID)
            //{
            //    string type = item.Type_.ValueStr;
            //    Excel_underlyingCalcIDViewModel viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(type);
            //    viewModel.setFromSerial(item);
            //    this.excel_underlyingCalcIDViewModel_.Add(viewModel);
            //}

            //FpmlSerializedCSharp.Excel_hifive_subtype serial_excel_hifive_subtype = serial_Excel_hifive.Excel_hifive_subtype_;
            //string excel_hifive_subtypetype = serial_excel_hifive_subtype.Type_.ValueStr;
            //this.excel_hifive_subtypeViewModel_ = Excel_hifive_subtypeViewModel.CreateExcel_hifive_subtype(excel_hifive_subtypetype);
            //this.excel_hifive_subtypeViewModel_.setFromSerial(serial_excel_hifive_subtype);
            
            //FpmlSerializedCSharp.Excel_scheduleList serial_excel_scheduleList = serial_Excel_hifive.Excel_scheduleList_;
            //string excel_scheduleListtype = serial_excel_scheduleList.Type_.ValueStr;
            //this.excel_scheduleListViewModel_ = Excel_scheduleListViewModel.CreateExcel_scheduleList(excel_scheduleListtype);
            //this.excel_scheduleListViewModel_.setFromSerial(serial_excel_scheduleList);
            
            //FpmlSerializedCSharp.Excel_kiScheduleList serial_excel_kiScheduleList = serial_Excel_hifive.Excel_kiScheduleList_;
            //string excel_kiScheduleListtype = serial_excel_kiScheduleList.Type_.ValueStr;
            //this.excel_kiScheduleListViewModel_ = Excel_kiScheduleListViewModel.CreateExcel_kiScheduleList(excel_kiScheduleListtype);
            //this.excel_kiScheduleListViewModel_.setFromSerial(serial_excel_kiScheduleList);
            
            //this.view_ = new Excel_hifiveView();
            //this.view_.DataContext = this;
        }

        //excel_vm으로 부터 각각의 subType을 만드는 작업
        public void buildHifive()
        {

            // view 데이터를 가져오는 부분 binding대서 자동으로 박힐거임. 여기서는 만들어줌
            {
                // 이게 원래 화면에서 build 대야대는디
                Excel_hifive_stepDown_kiViewModel e_hsvm = new Excel_hifive_stepDown_kiViewModel();

                ScheduleInfoViewModel sivm = new ScheduleInfoViewModel();
                sivm.PeriodFrequency_ = "3M";
                sivm.InitialDate_ = "20160325";
                sivm.EndDate_ = "20160325";

                e_hsvm.ScheduleInfoVM_ = sivm;

                e_hsvm.Ki_ = "";
                e_hsvm.Tenor_ = "3M";

                //기초자산 정보를 전달해줌.
                e_hsvm.Excel_underlyingCalcInfoViewModel_ =
                    this.excel_underlyingCalcInfoViewModel_;

                this.excel_hifive_subtypeViewModel_ = e_hsvm;

            }

            // setting된 정보를 토대로 상품을 만듬
            this.excel_hifive_subtypeViewModel_.buildProduct();

            this.excel_underlyingCalcIDViewModel_ = this.excel_hifive_subtypeViewModel_.excel_underlyingCalcIDVM();

            // 이미 세부 calculation 을 만들 vm은 생성이 되어있음
            this.excel_scheduleListViewModel_ = this.excel_hifive_subtypeViewModel_.excel_scheduleListVM();
            this.excel_kiScheduleListViewModel_ = this.excel_hifive_subtypeViewModel_.excel_kiScheduleListVM();

        }

        
    
    }
    
}

