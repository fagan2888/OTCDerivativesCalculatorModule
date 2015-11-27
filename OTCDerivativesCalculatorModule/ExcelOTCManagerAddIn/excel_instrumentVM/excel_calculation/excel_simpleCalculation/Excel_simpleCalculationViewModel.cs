using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_simpleCalculationViewModel : Excel_scheduleViewModel
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
    
        public Excel_simpleCalculationViewModel() { }
    
        #region Excel_eventCalcInfoViewModel_
        private Excel_eventCalcInfoViewModel excel_eventCalcInfoViewModel_;
        public Excel_eventCalcInfoViewModel Excel_eventCalcInfoViewModel_
        {
            get { return this.excel_eventCalcInfoViewModel_; }
            set
            {
                if (this.excel_eventCalcInfoViewModel_ != value)
                {
                    this.excel_eventCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfoViewModel_
        private Excel_returnCalcInfoViewModel excel_returnCalcInfoViewModel_;
        public Excel_returnCalcInfoViewModel Excel_returnCalcInfoViewModel_
        {
            get { return this.excel_returnCalcInfoViewModel_; }
            set
            {
                if (this.excel_returnCalcInfoViewModel_ != value)
                {
                    this.excel_returnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfoViewModel_");
                }
            }
        }
        #endregion

        #region Excel_complementReturnCalcViewModel_
        private Excel_complementReturnCalcViewModel excel_complementReturnCalcViewModel_;
        public Excel_complementReturnCalcViewModel Excel_complementReturnCalcViewModel_
        {
            get { return this.excel_complementReturnCalcViewModel_; }
            set
            {
                if (this.excel_complementReturnCalcViewModel_ != value)
                {
                    this.excel_complementReturnCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_complementReturnCalcViewModel_");
                }
            }
        }
        #endregion

        #region Excel_eventCalcInfo_CallViewModel_
        private Excel_eventCalcInfo_CallViewModel excel_eventCalcInfo_CallViewModel_;
        public Excel_eventCalcInfo_CallViewModel Excel_eventCalcInfo_CallViewModel_
        {
            get { return this.excel_eventCalcInfo_CallViewModel_; }
            set
            {
                if (this.excel_eventCalcInfo_CallViewModel_ != value)
                {
                    this.excel_eventCalcInfo_CallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfo_CallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfo_CallViewModel_
        private Excel_returnCalcInfo_CallViewModel excel_returnCalcInfo_CallViewModel_;
        public Excel_returnCalcInfo_CallViewModel Excel_returnCalcInfo_CallViewModel_
        {
            get { return this.excel_returnCalcInfo_CallViewModel_; }
            set
            {
                if (this.excel_returnCalcInfo_CallViewModel_ != value)
                {
                    this.excel_returnCalcInfo_CallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfo_CallViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_schedule");
                xmlWriter.WriteElementString("type" , "excel_simpleCalculation");
                xmlWriter.WriteStartElement("excel_simpleCalculation");
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_returnCalcInfoViewModel_.buildXml(xmlWriter);

                    excel_complementReturnCalcViewModel_.buildXml(xmlWriter);
                    
                    excel_eventCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    
                    excel_returnCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            // 원래 꺼 만드는 코드 부분
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_schedule serial_Excel_schedule = serial_Class as FpmlSerializedCSharp.Excel_schedule;
            FpmlSerializedCSharp.Excel_simpleCalculation serial_Excel_simpleCalculation = serial_Excel_schedule.Excel_simpleCalculation_;
        
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_simpleCalculation.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
            
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_excel_returnCalcInfo = serial_Excel_simpleCalculation.Excel_returnCalcInfo_;
            string excel_returnCalcInfotype = serial_excel_returnCalcInfo.Type_.ValueStr;
            this.excel_returnCalcInfoViewModel_ = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(excel_returnCalcInfotype);
            this.excel_returnCalcInfoViewModel_.setFromSerial(serial_excel_returnCalcInfo);

            FpmlSerializedCSharp.Excel_complementReturnCalc serial_excel_complementReturnCalc = serial_Excel_simpleCalculation.Excel_complementReturnCalc_;
            string excel_complementReturnCalctype = serial_excel_complementReturnCalc.Type_.ValueStr;
            this.excel_complementReturnCalcViewModel_ = Excel_complementReturnCalcViewModel.CreateExcel_complementReturnCalc(excel_complementReturnCalctype);
            this.excel_complementReturnCalcViewModel_.setFromSerial(serial_excel_complementReturnCalc);

            FpmlSerializedCSharp.Excel_eventCalcInfo_Call serial_excel_eventCalcInfo_Call = serial_Excel_simpleCalculation.Excel_eventCalcInfo_Call_;
            string excel_eventCalcInfo_Calltype = serial_excel_eventCalcInfo_Call.Type_.ValueStr;
            this.excel_eventCalcInfo_CallViewModel_ = Excel_eventCalcInfo_CallViewModel.CreateExcel_eventCalcInfo_Call(excel_eventCalcInfo_Calltype);
            this.excel_eventCalcInfo_CallViewModel_.setFromSerial(serial_excel_eventCalcInfo_Call);
            
            FpmlSerializedCSharp.Excel_returnCalcInfo_Call serial_excel_returnCalcInfo_Call = serial_Excel_simpleCalculation.Excel_returnCalcInfo_Call_;
            string excel_returnCalcInfo_Calltype = serial_excel_returnCalcInfo_Call.Type_.ValueStr;
            this.excel_returnCalcInfo_CallViewModel_ = Excel_returnCalcInfo_CallViewModel.CreateExcel_returnCalcInfo_Call(excel_returnCalcInfo_Calltype);
            this.excel_returnCalcInfo_CallViewModel_.setFromSerial(serial_excel_returnCalcInfo_Call);

            this.view_ = new Excel_simpleCalculationView();
            this.view_.DataContext = this;
        }

        public override void vmBuildFromExcel_interface()
        {
            SimpleEventCouponTriggerViewModel sectvm = new SimpleEventCouponTriggerViewModel();

            sectvm.EventCalculationInfoViewModel_ = this.excel_eventCalcInfoViewModel_.eventCalcInfoVM();
            sectvm.ReturnCalculationInfoViewModel_ = this.excel_returnCalcInfoViewModel_.returnCalcInfoVM();
            sectvm.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_
                = this.excel_complementReturnCalcViewModel_.returnCalcInfoVM();

            FixedFixingDateInfoViewModel ffdvm = new FixedFixingDateInfoViewModel();
            
            ffdvm.Date_ = this.EventDate_.ToString("yyyyMMdd");

            sectvm.PayoffDateInfoViewModel_.FixingDateInfoViewModel_ = new FixedFixingDateInfoViewModel();

            // --------------- autoCallTrigger

            sectvm.AutoTerminationTriggerViewModel_.EventCalculationInfoViewModel_
                = this.excel_eventCalcInfo_CallViewModel_.eventCalcInfoVM();

            sectvm.AutoTerminationTriggerViewModel_.ReturnCalculationInfoViewModel_
                = this.excel_returnCalcInfo_CallViewModel_.returnCalcInfoVM();


            FixedFixingDateInfoViewModel ffdvm_call = new FixedFixingDateInfoViewModel();

            ffdvm_call.Date_ = this.EventDate_.ToString("yyyyMMdd");

            sectvm.AutoTerminationTriggerViewModel_.PayoffDateInfoViewModel_.FixingDateInfoViewModel_
                = ffdvm_call;


        }
    
            #region SelectExcel_eventCalcInfoInfo_
            private string selectExcel_eventCalcInfoInfo_;
            public string SelectExcel_eventCalcInfoInfo_
            {
                get { return this.selectExcel_eventCalcInfoInfo_; }
                set
                {
                    if (this.selectExcel_eventCalcInfoInfo_ != value)
                    {
                        this.selectExcel_eventCalcInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_eventCalcInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_eventCalcInfoInfo(string typeStr)
            {
                this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectExcel_returnCalcInfoInfo_
            private string selectExcel_returnCalcInfoInfo_;
            public string SelectExcel_returnCalcInfoInfo_
            {
                get { return this.selectExcel_returnCalcInfoInfo_; }
                set
                {
                    if (this.selectExcel_returnCalcInfoInfo_ != value)
                    {
                        this.selectExcel_returnCalcInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_returnCalcInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_returnCalcInfoInfo(string typeStr)
            {
                this.excel_returnCalcInfoViewModel_ = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectExcel_eventCalcInfo_CallInfo_
            private string selectExcel_eventCalcInfo_CallInfo_;
            public string SelectExcel_eventCalcInfo_CallInfo_
            {
                get { return this.selectExcel_eventCalcInfo_CallInfo_; }
                set
                {
                    if (this.selectExcel_eventCalcInfo_CallInfo_ != value)
                    {
                        this.selectExcel_eventCalcInfo_CallInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_eventCalcInfo_CallInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_eventCalcInfo_CallInfo(string typeStr)
            {
                this.excel_eventCalcInfo_CallViewModel_ = Excel_eventCalcInfo_CallViewModel.CreateExcel_eventCalcInfo_Call(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectExcel_returnCalcInfo_CallInfo_
            private string selectExcel_returnCalcInfo_CallInfo_;
            public string SelectExcel_returnCalcInfo_CallInfo_
            {
                get { return this.selectExcel_returnCalcInfo_CallInfo_; }
                set
                {
                    if (this.selectExcel_returnCalcInfo_CallInfo_ != value)
                    {
                        this.selectExcel_returnCalcInfo_CallInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_returnCalcInfo_CallInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_returnCalcInfo_CallInfo(string typeStr)
            {
                this.excel_returnCalcInfo_CallViewModel_ = Excel_returnCalcInfo_CallViewModel.CreateExcel_returnCalcInfo_Call(typeStr);
                this.view_.DataContext = this;
            }

}
    
}

