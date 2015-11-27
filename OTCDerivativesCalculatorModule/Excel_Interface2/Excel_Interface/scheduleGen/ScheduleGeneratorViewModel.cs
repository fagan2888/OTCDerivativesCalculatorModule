using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

using QLNet;

namespace Excel_Interface
{
    public class ScheduleGeneratorViewModel : IXmlData , INotifyPropertyChanged
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

        #region InitialDate_
        private DateTime initialDate_;
        public DateTime InitialDate_
        {
            get { return this.initialDate_; }
            set
            {
                if (this.initialDate_ != value)
                {
                    this.initialDate_ = value;
                    this.NotifyPropertyChanged("InitialDate_");
                }
            }
        }
        #endregion

        #region EndDate_
        private DateTime endDate_;
        public DateTime EndDate_
        {
            get { return this.endDate_; }
            set
            {
                if (this.endDate_ != value)
                {
                    this.endDate_ = value;
                    this.NotifyPropertyChanged("EndDate_");
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

        #region PaymentDays_
        private string paymentDays_;
        public string PaymentDays_
        {
            get { return this.paymentDays_; }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                    this.NotifyPropertyChanged("PaymentDays_");
                }
            }
        }
        #endregion

        #region Calendar_
        private string calendar_;
        public string Calendar_
        {
            get { return this.calendar_; }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                    this.NotifyPropertyChanged("Calendar_");
                }
            }
        }
        #endregion

        #region Excel_calendarViewModel_
        private Excel_calendarViewModel excel_calendarViewModel;
        public Excel_calendarViewModel Excel_calendarViewModel_
        {
            get { return this.excel_calendarViewModel; }
            set
            {
                if (this.excel_calendarViewModel != value)
                {
                    this.excel_calendarViewModel = value;
                    this.NotifyPropertyChanged("Excel_calendarViewModel_");
                }
            }
        }
        #endregion

        #region BusinessDayConvention_
        private string businessDayConvention_;
        public string BusinessDayConvention_
        {
            get { return this.businessDayConvention_; }
            set
            {
                   
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvention_");
                }
            }
        }
        #endregion

        #region DateGeneration_
        private string dateGeneration_;
        public string DateGeneration_
        {
            get { return this.dateGeneration_; }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                    this.NotifyPropertyChanged("DateGeneration_");
                }
            }
        }
        #endregion

        #region Dates_
        private ObservableCollection<DateTime> dates_;
        public ObservableCollection<DateTime> Dates_
        {
            get { return this.dates_; }
            set
            {
                if (this.dates_ != value)
                {
                    this.dates_ = value;
                    this.NotifyPropertyChanged("Dates_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        #region QNet Enum

        #region FrequencyEnum_
        private QLNet.Frequency frequencyEnum_;
        public QLNet.Frequency FrequencyEnum_
        {
            get { return this.frequencyEnum_; }
            set
            {
                if (this.frequencyEnum_ != value)
                {
                    this.frequencyEnum_ = value;
                    this.NotifyPropertyChanged("FrequencyEnum_");
                }
            }
        }
        #endregion

        #region BusinessDayConvEnum_
        private QLNet.BusinessDayConvention businessDayConvEnum_;
        public QLNet.BusinessDayConvention BusinessDayConvEnum_
        {
            get { return this.businessDayConvEnum_; }
            set
            {
                if (this.businessDayConvEnum_ != value)
                {
                    this.businessDayConvEnum_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvEnum_");
                }
            }
        }
        #endregion

        #region DateGenEnum_
        private QLNet.DateGeneration.Rule dateGenEnum_;
        public QLNet.DateGeneration.Rule DateGenEnum_
        {
            get { return this.dateGenEnum_; }
            set
            {
                if (this.dateGenEnum_ != value)
                {
                    this.dateGenEnum_ = value;
                    this.NotifyPropertyChanged("DateGenEnum_");
                }
            }
        }
        #endregion

        #endregion

        public ScheduleGeneratorViewModel()
        { 
            //ScheduleGeneratorView
            this.dates_ = new ObservableCollection<DateTime>();

            this.FrequencyEnum_ = Frequency.Quarterly;
            this.BusinessDayConvEnum_ = BusinessDayConvention.ModifiedFollowing;
            this.DateGenEnum_ = DateGeneration.Rule.Backward;
        }

        public void defaultLoad()
        {
            this.initialDate_ = DateTime.Now;
            this.endDate_ = DateTime.Now.AddYears(10);
            this.tenor_ = "3M";
            this.paymentDays_ = "1";
            this.calendar_ = "KOR";
            this.businessDayConvention_ = "Following";
            this.dateGeneration_ = "Forward";

        }

        public ScheduleGeneratorViewModel(DateTime initialDate,
                                          DateTime endDate,
                                          string tenor,
                                          string calendar,
                                          string businessDayConv,
                                          string dateGeneration)
        {
            this.dates_ = new ObservableCollection<DateTime>();

            this.initialDate_ = initialDate;
            this.endDate_ = endDate;
            this.tenor_ = tenor;
            this.FrequencyEnum_ = Frequency.Quarterly;

            this.calendar_ = calendar;
            this.businessDayConvention_ = businessDayConv;
            this.dateGeneration_ = dateGeneration;
        }

        //public ObservableCollection<DateTime> dates(int addingDays = 0)
        public void genDates(int addingDays = 0)
        {
            

            this.dates_.Clear();

            //Period tenor = new Period(this.tenor_);
            
            QLNet.Calendar calendar = new SouthKorea();

            Period tenor = new Period(this.frequencyEnum_);
            BusinessDayConvention bdc = this.businessDayConvEnum_;
            DateGeneration.Rule dateGen = this.dateGenEnum_;

            try
            {
                Schedule schedule = new Schedule(new Date(initialDate_),
                                             new Date(endDate_),
                                             tenor,
                                             calendar,
                                             bdc,
                                             bdc,
                                             dateGen,
                                             false);

                List<Date> ql_d = schedule.dates();

                for (int i = 0; i < ql_d.Count; i++)
                {
                    this.dates_.Add(ql_d[i]);
                }
            }
            catch (Exception)
            {

                OutputLogViewModel.addResult("schedule gen error");
            }
            

            //test

            //for (int i = 0; i < 6; i++)
            //{
            //    this.dates_.Add(new DateTime());    
            //}

            //this.dates_ = d;

            //return d;

        }

        //public DateTime nextDate(int addingDays)
        //{
        //    DateTime d = new DateTime();

        //    Calendar cal = new SouthKorea();

        //    return d;
        //}

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            //xmlWriter.WriteStartElement("scheduleGenerator");
            //xmlWriter.WriteElementString("initialDate", this.initialDate_);

            //xmlWriter.WriteElementString("endDate", this.endDate_);

            //xmlWriter.WriteElementString("tenor", this.tenor_);

            //xmlWriter.WriteElementString("paymentDays", this.paymentDays_);

            //xmlWriter.WriteElementString("calendars", this.calendars_);

            //xmlWriter.WriteElementString("businessDayConvention", this.businessDayConvention_);

            //xmlWriter.WriteElementString("dateGeneration", this.dateGeneration_);

            //xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.ScheduleGenerator serial_ScheduleGenerator = serial_Class as FpmlSerializedCSharp.ScheduleGenerator;

            //this.initialDate_ = serial_ScheduleGenerator.InitialDate_.ValueStr;

            //this.endDate_ = serial_ScheduleGenerator.EndDate_.ValueStr;

            //this.tenor_ = serial_ScheduleGenerator.Tenor_.ValueStr;

            //this.paymentDays_ = serial_ScheduleGenerator.PaymentDays_.ValueStr;

            //this.calendarsViewModel_ = new ObservableCollection<CalendarsViewModel>();
            //foreach (var item in serial_ScheduleGenerator.Calendars_)
            //{
            //    this.value_.Add(item.ValueStr);
            //}

            //this.businessDayConvention_ = serial_ScheduleGenerator.BusinessDayConvention_.ValueStr;

            //this.dateGeneration_ = serial_ScheduleGenerator.DateGeneration_.ValueStr;

            //this.view_ = new ScheduleGeneratorView();
            //this.view_.DataContext = this;
        }

        public string description()
        {
            return "test scheduleGen description";
        }

        public Control view()
        {
            Control v = new ScheduleGeneratorView();

            v.DataContext = this;

            return v;
        }

        public DateTime addDays(DateTime dateTime, int addingDays)
        {
            // calendar 우선 디폴트
            QLNet.Calendar calendar = new SouthKorea();

            return calendar.advance(dateTime, addingDays, TimeUnit.Days);
            
            //DateTime addedDateTime = dateTime.AddDays(addingDays);

        }
    }
}
