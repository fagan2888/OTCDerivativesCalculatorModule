using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace RiskMonitor
{
    public class Excel_hifive_stepDown_kiViewModel : Excel_hifive_subtypeViewModel
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

        public Excel_hifive_stepDown_kiViewModel() { }

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

        #region UnderlyingType_
        private string underlyingType_;
        public string UnderlyingType_
        {
            get { return this.underlyingType_; }
            set
            {
                if (this.underlyingType_ != value)
                {
                    this.underlyingType_ = value;
                    this.NotifyPropertyChanged("UnderlyingType_");
                }
            }
        }
        #endregion

        #region MaturityYear_
        private string maturityYear_;
        public string MaturityYear_
        {
            get { return this.maturityYear_; }
            set
            {
                if (this.maturityYear_ != value)
                {
                    this.maturityYear_ = value;
                    this.NotifyPropertyChanged("MaturityYear_");
                }
            }
        }
        #endregion
        
        #region AutoCallTrigger_
        private ObservableCollection<string> autoCallTrigger_;
        public ObservableCollection<string> AutoCallTrigger_
        {
            get { return this.autoCallTrigger_; }
            set
            {
                if (this.autoCallTrigger_ != value)
                {
                    this.autoCallTrigger_ = value;
                    this.NotifyPropertyChanged("AutoCallTrigger_");
                }
            }
        }
        #endregion
        
        #region Tenor_
        private string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion
        
        #region Ki_
        private string ki_;
        public string Ki_
        {
            get { return this.ki_; }
            set
            {
                if (this.ki_ != value)
                {
                    this.ki_ = value;
                    this.NotifyPropertyChanged("Ki_");
                }
            }
        }
        #endregion

        #region ScheduleDataList_
        private ObservableCollection<ScheduleData> scheduleDataList_;
        public ObservableCollection<ScheduleData> ScheduleDataList_
        {
            get { return this.scheduleDataList_; }
            set
            {
                if (this.scheduleDataList_ != value)
                {
                    this.scheduleDataList_ = value;
                    this.NotifyPropertyChanged("ScheduleDataList_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcInfoVM_
        private Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoVM_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoVM_
        {
            get { return this.excel_underlyingCalcInfoVM_; }
            set
            {
                if (this.excel_underlyingCalcInfoVM_ != value)
                {
                    this.excel_underlyingCalcInfoVM_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoVM_");
                }
            }
        }
        #endregion

        class ScheduleData 
        {
            public string Type_ { get; set; }
            public string EventDate_ { get; set; }
            public string Trigger_ { get; set; }
            public string Coupon_ { get; set; }
            
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_hifive_subtype");
                xmlWriter.WriteElementString("type" , "excel_hifive_stepDown_ki");
                xmlWriter.WriteStartElement("excel_hifive_stepDown_ki");
                    xmlWriter.WriteElementString("maturityYear" , this.maturityYear_);
                    

                    xmlWriter.WriteElementString("autoCallTrigger" , this.autoCallTrigger_);

                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("ki" , this.ki_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_hifive_subtype serial_Excel_hifive_subtype = serial_Class as FpmlSerializedCSharp.Excel_hifive_subtype;
            FpmlSerializedCSharp.Excel_hifive_stepDown_ki serial_Excel_hifive_stepDown_ki = serial_Excel_hifive_subtype.Excel_hifive_stepDown_ki_;
        
            this.maturityYear_ = serial_Excel_hifive_stepDown_ki.MaturityYear_.ValueStr;
            
            this.autoCallTriggerViewModel_ = new ObservableCollection<AutoCallTriggerViewModel>();
            foreach (var item in serial_Excel_hifive_stepDown_ki.AutoCallTrigger_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.tenor_ = serial_Excel_hifive_stepDown_ki.Tenor_.ValueStr;
            
            this.ki_ = serial_Excel_hifive_stepDown_ki.Ki_.ValueStr;
            
            //this.view_ = new Excel_hifive_stepDown_kiView();
            //this.view_.DataContext = this;
        }

        private void scheduleBuild()
        {
            this.scheduleDataList_ = new ObservableCollection<ScheduleData>();

            List<DateTime> eventDates = this.scheduleInfoVM_.dates();

            int scheduleLength = eventDates.Count;

            for (int i = 0; i < scheduleLength ; i++)
			{
			    ScheduleData data = new ScheduleData();

                data.Type_ = ("autocall").ToUpper();
                data.EventDate_ = eventDates[0].ToString("yyyyMMdd");
                data.Trigger_ = autoCallTrigger_[i];
                data.Coupon_ = "0.06";

                this.scheduleDataList_.Add(data);
			}
        }

        private Excel_simpleCalculationViewModel excel_simpleCalculationVMBuild(ScheduleData scheduleData)
        {
            Excel_simpleCalculationViewModel e_cvm = new Excel_simpleCalculationViewModel();

            e_cvm.EventDate_ = scheduleData.EventDate_;

            #region EventCal
            //---------------------------------------------------------------
            {
                Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                e_srecvm.LowerRng_ = scheduleData.Trigger_;

                //처음꺼만 사용함
                e_srecvm.Excel_underlyingCalcID_ = this.excel_underlyingCalcInfoVM_.Excel_underlyingCalcIDViewModel_[0];

                e_cvm.Excel_eventCalcInfoViewModel_.Excel_eventCalcViewModel_.Add(e_srecvm);

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }

            #endregion

            #region ReturnCal
            //---------------------------------------------------------------
            {
                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.ConstReturn_ = scheduleData.Coupon_;

                e_cvm.Excel_returnCalcInfoViewModel_.Excel_returnCalcViewModel_.Add(e_crcvm);

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }
            #endregion

            #region AutoCall_Event

            //---------------------------------------------------------------
            {
                Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                e_srecvm.LowerRng_ = scheduleData.Trigger_;

                //처음꺼만 사용함
                e_srecvm.Excel_underlyingCalcID_ = this.excel_underlyingCalcInfoVM_.Excel_underlyingCalcIDViewModel_[0];

                e_cvm.Excel_eventCalcInfo_CallViewModel_.Excel_eventCalcViewModel_.Add(e_srecvm);

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }

            #endregion

            #region AutoCall_ReturnCal

            //---------------------------------------------------------------
            {
                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.ConstReturn_ = "1.0"; // 원금

                e_cvm.Excel_returnCalcInfo_CallViewModel_.Excel_returnCalcViewModel_.Add(e_crcvm);

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }
            
            #endregion

            return e_cvm;
        }

        public override Excel_scheduleListViewModel excel_scheduleListVM()
        {
            int scheduleNum = this.scheduleDataList_.Count; ;

            Excel_scheduleListViewModel e_slvm = new Excel_scheduleListViewModel();

            for (int i = 0; i < scheduleNum; i++)
            {
                e_slvm.Excel_scheduleViewModel_.Add(
                    this.excel_simpleCalculationVMBuild(this.scheduleDataList_[i]));
            }

            return e_slvm;
        }

        public override Excel_kiScheduleListViewModel excel_kiScheduleListVM()
        {
            Excel_kiScheduleListViewModel e_kslvm = new Excel_kiScheduleListViewModel();

            Excel_singleBarrierEventCalViewModel e_sbecvm = new Excel_singleBarrierEventCalViewModel();
            
            e_sbecvm.LowerBarrier_ = this.ki_;

            e_kslvm.Excel_scheduleViewModel_.Add(

            return e_kslvm;
        }

        public override ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDVM()
        {
            ObservableCollection<Excel_underlyingCalcIDViewModel> e_ucIDvmList = new ObservableCollection<Excel_underlyingCalcIDViewModel>();

            Excel_underlyingCalcIDViewModel e_ucIDvm = new Excel_underlyingCalcIDViewModel();

            if (this.underlyingType_ == "")
            {
                e_ucIDvm.CalcID_ = "";
                e_ucIDvm.ReferenceType_ = "";
                e_ucIDvm.SelectedUnderlyingName_ = new ObservableCollection<string>();
                e_ucIDvm.Nth_ = "";
            }
            else 
            {
                e_ucIDvm.CalcID_ = "";
                e_ucIDvm.ReferenceType_ = "";
                e_ucIDvm.SelectedUnderlyingName_ = new ObservableCollection<string>();
                e_ucIDvm.Nth_ = "";
            }

            e_ucIDvmList.Add(e_ucIDvm);

            return e_ucIDvmList;
        }

        public override void buildProduct()
        {
            this.scheduleBuild();

        }
    }
    
}

