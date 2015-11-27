using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GeneralScheduleInfoViewModel : IXmlData
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region ScheduleInitialDate_
        private DateTime scheduleInitialDate_;
        public DateTime ScheduleInitialDate_
        {
            get { return this.scheduleInitialDate_; }
            set
            {
                if (this.scheduleInitialDate_ != value)
                {
                    this.scheduleInitialDate_ = value;
                    this.NotifyPropertyChanged("ScheduleInitialDate_");
                }
            }
        }
        #endregion

        #region StepMonth_ 
        private int stepMonth_;
        public int StepMonth_
        {
            get { return this.stepMonth_; }
            set
            {
                if (this.stepMonth_ != value)
                {
                    this.stepMonth_ = value;
                    this.NotifyPropertyChanged("StepMonth_");
                }
            }
        }
        #endregion

        #region GeneralScheduleVMList_
        private ObservableCollection<GeneralScheduleViewModel> generalScheduleVMList_;
        public ObservableCollection<GeneralScheduleViewModel> GeneralScheduleVMList_
        {
            get { return this.generalScheduleVMList_; }
            set
            {
                if (this.generalScheduleVMList_ != value)
                {
                    this.generalScheduleVMList_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleVMList_");
                }
            }
        }
        #endregion

        public GeneralScheduleInfoViewModel()
        {
            this.scheduleInitialDate_ = ProgramVariable.ReferenceDate_;
            this.stepMonth_ = 3;

            this.generalScheduleVMList_ = new ObservableCollection<GeneralScheduleViewModel>();

            //this.view_ = new GeneralScheduleInfoView();
            //this.view_.DataContext = this;
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalScheduleInfo");

            foreach (var item in this.generalScheduleVMList_)
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
            //FpmlSerializedCSharp.GeneralScheduleInfo serial_GeneralScheduleInfo = serial_Class as FpmlSerializedCSharp.GeneralScheduleInfo;

            //List<FpmlSerializedCSharp.GeneralSchedule> serial_generalSchedule = serial_GeneralScheduleInfo.GeneralSchedule_;
            //this.generalScheduleViewModel_ = new ObservableCollection<GeneralScheduleViewModel>();
            //foreach (var item in serial_generalSchedule)
            //{
            //    string type = item.Type_.ValueStr;
            //    GeneralScheduleViewModel viewModel = GeneralScheduleViewModel.CreateGeneralSchedule(type);
            //    viewModel.setFromSerial(item);
            //    this.generalScheduleViewModel_.Add(viewModel);
            //}

            //this.view_ = new GeneralScheduleInfoView();
            //this.view_.DataContext = this;
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.generalScheduleVMList_)
	        {
                item.bookingEvent(masterInformationViewModel);
	        }
        }

        public Control view()
        {
            System.Windows.Controls.Control v = new GeneralScheduleInfoView();

            v.DataContext = this;

            return v;
        }

    }
}
