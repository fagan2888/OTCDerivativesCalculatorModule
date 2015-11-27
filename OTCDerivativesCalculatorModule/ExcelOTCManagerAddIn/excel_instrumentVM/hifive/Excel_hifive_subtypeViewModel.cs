using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Excel_hifive_subtypeViewModel : IXmlData
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


        // 대충의 gen 될 스케줄 이걸 사용해서 세부 gen이 될거임
        #region ScheduleInfoVM_
        protected ScheduleInfoViewModel scheduleInfoVM_;
        public ScheduleInfoViewModel ScheduleInfoVM_
        {
            get { return this.scheduleInfoVM_; }
            set
            {
                if (this.scheduleInfoVM_ != value)
                {
                    this.scheduleInfoVM_ = value;
                    this.NotifyPropertyChanged("ScheduleInfoVM_");
                }
            }
        }
        #endregion

        public Excel_hifive_subtypeViewModel() { }
    
        #region Excel_Type_
        private string excel_Type_;
        public string Excel_Type_
        {
            get { return this.excel_Type_; }
            set
            {
                if (this.excel_Type_ != value)
                {
                    this.excel_Type_ = value;
                    this.NotifyPropertyChanged("Excel_Type_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        


    
        public static Excel_hifive_subtypeViewModel CreateExcel_hifive_subtype(string typeStr)
        {
            if ( typeStr == "excel_hifive_stepDown_ki")
            {
                return new Excel_hifive_stepDown_kiViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Excel_hifive_subtypeViewModel CreateExcel_hifive_subtype(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_hifive_subtype serial_Excel_hifive_subtype = serial_Class as FpmlSerializedCSharp.Excel_hifive_subtype;
            string typeStr = serial_Excel_hifive_subtype.Type_.ValueStr;
            return Excel_hifive_subtypeViewModel.CreateExcel_hifive_subtype(typeStr);
        }
        

        //--------------------------------------------------

        public abstract void buildProduct();

        public abstract Excel_scheduleListViewModel excel_scheduleListVM();
        public abstract Excel_kiScheduleListViewModel excel_kiScheduleListVM();

        public abstract ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDVM();

        
    }
    
}

