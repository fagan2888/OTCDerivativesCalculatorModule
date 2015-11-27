using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    // min max 평균 머 그런거를 할라면
    // 그냥 referenceType 이런걸로 받으면 안대고
    // 하위클래스로 확장시켜야함.
    // 나중에 구현 ㄱㄱ
    public abstract class Excel_underlyingCalcIDViewModel : IXmlData , INotifyPropertyChanged
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

        public Excel_underlyingCalcIDViewModel() 
        {
            this.defaultUnderlyingSettingFlag_ = true;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
        }

        #region AttributeValue_
        protected string attributeValue_;
        public string AttributeValue_
        {
            get { return this.attributeValue_; }
            set
            {
                if (this.attributeValue_ != value)
                {
                    this.attributeValue_ = value;
                    this.NotifyPropertyChanged("AttributeValue_");
                }
            }
        }
        #endregion

        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion

        #region CalcID_
        private string calcID_;
        public string CalcID_
        {
            get { return this.calcID_; }
            set
            {
                if (this.calcID_ != value)
                {
                    this.calcID_ = value;
                    this.NotifyPropertyChanged("CalcID_");
                }
            }
        }
        #endregion

        #region Description_
        protected string description_;
        public string Description_
        {
            get 
            {
                this.descriptionUpdate();

                return this.description_; 
            }
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

        #region EventDate_
        protected DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion

        #region DefaultUnderlyingSettingFlag_
        protected bool defaultUnderlyingSettingFlag_;
        public bool DefaultUnderlyingSettingFlag_
        {
            get { return this.defaultUnderlyingSettingFlag_; }
            set
            {
                if (this.defaultUnderlyingSettingFlag_ != value)
                {
                    this.defaultUnderlyingSettingFlag_ = value;
                    this.NotifyPropertyChanged("DefaultUnderlyingSettingFlag_");
                }
            }
        }
        #endregion

        #region Excel_selectedUnderlyingViewModel_
        protected ObservableCollection<Excel_selectedUnderlyingViewModel> excel_selectedUnderlyingViewModel_;
        public ObservableCollection<Excel_selectedUnderlyingViewModel> Excel_selectedUnderlyingViewModel_
        {
            get { return this.excel_selectedUnderlyingViewModel_; }
            set
            {
                if (this.excel_selectedUnderlyingViewModel_ != value)
                {
                    this.excel_selectedUnderlyingViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_selectedUnderlyingViewModel_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcInfoViewModel_
        protected Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public Excel_underlyingCalcIDLoaderView loaderView()
        {
            Excel_underlyingCalcIDLoaderView underCalcLoader = new Excel_underlyingCalcIDLoaderView();

            underCalcLoader.initialize(this);

            underCalcLoader.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            underCalcLoader.selectedUnderCalcIDGrid_.Children.Add(this.view());

            return underCalcLoader;
        }

        public abstract Control view();

        public abstract void descriptionUpdate();
        public abstract Excel_underlyingCalcIDViewModel Clone();

        public static Excel_underlyingCalcIDViewModel CreateExcel_underlyingCalcID(string typeStr)
        {
            if (typeStr == "excel_choiceUnderlyingCalcID" || 
                typeStr.ToUpper() == "CHOICE" )
            {
                return new Excel_choiceUnderlyingCalcIDViewModel();
            }
            else if (typeStr == "excel_maximumUnderlyingCalcID" || 
                     typeStr.ToUpper() == "MAXIMUM" ||
                     typeStr.ToUpper() == "MAX" )
            {
                return new Excel_maximumUnderlyingCalcIDViewModel();
            }
            else if (typeStr == "excel_minimumUnderlyingCalcID" || 
                     typeStr.ToUpper() == "MINIMUM" ||
                     typeStr.ToUpper() == "MIN" )
            {
                return new Excel_minimumUnderlyingCalcIDViewModel();
            }
            else if (typeStr == "excel_averageUnderlyingCalcID" ||
                     typeStr.ToUpper() == "AVERAGE" ||
                     typeStr.ToUpper() == "AVER")
            {
                return new Excel_averageUnderlyingCalcIDViewModel();
            }
            //else if (typeStr == "excel_orderUnderlyingCalcID")
            //{
            //    return new Excel_orderUnderlyingCalcIDViewModel();
            //}
            else
            {
                throw new NotImplementedException();
            }
        }

        //public static Excel_underlyingCalcIDViewModel CreateExcel_underlyingCalcID(string typeStr)
        //{
        //    //    Maximum , 
        //    //    Minimum , 
        //    //    Average

        //    if (typeStr.ToUpper() == "MAXIMUM")
        //    {
        //        return new Excel_maximumUnderlyingCalcIDViewModel();
        //    }
        //    else if (typeStr.ToUpper() == "MINIMUM")
        //    {
        //        return new Excel_minimumUnderlyingCalcIDViewModel();
        //    }
        //    else if (typeStr.ToUpper() == "AVERAGE")
        //    {
        //        return new Excel_averageUnderlyingCalcIDViewModel();
        //    }
        //    else
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


        //이건 calculationEngine에 들어갈 꺼
        //public ReferenceCalculationInfoViewModel referenceCalcInfoVM()
        //{
        //    ReferenceCalculationInfoViewModel rcivm = new ReferenceCalculationInfoViewModel();

        //    if (this.excel_type_.ToUpper() == "MAXIMUM")
        //    {
        //        MaximumReferenceCalViewModel mrcvm = new MaximumReferenceCalViewModel();
        //        //mrcvm.SelectedUnderName_ = this.selectedUnderlyingName_;
        //        //mrcvm.Nth_ = this.nth_;
        //        rcivm.ReferenceCalculationViewModel_.Add(mrcvm);
        //    }
        //    else if (this.excel_type_.ToUpper() == "MINIMUM")
        //    {
        //        MinimumReferenceCalViewModel mrcvm = new MinimumReferenceCalViewModel();
        //        //mrcvm.SelectedUnderName_ = this.selectedUnderlyingName_;
        //        //mrcvm.Nth_ = this.nth_;
        //        rcivm.ReferenceCalculationViewModel_.Add(mrcvm);
        //    }
        //    else 
        //    {
        //        throw new NotImplementedException();
        //    }

        //    //FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();
        //    //ffdivm.Date_ = dateTime.ToString("yyyy-MM-dd");
        //    //mrcvm.FixingDateInfoViewModel_ = ffdivm;

        //    // operatorND set 이런거

        //    return rcivm;
        //}

        //public ReferenceCalculationInfoViewModel referenceCalcInfoVM()
        //{
        //    ReferenceCalculationInfoViewModel rcivm = new ReferenceCalculationInfoViewModel();

        //    ObservableCollection<EventCalculationViewModel> eventCalcViewModelList
        //        = new ObservableCollection<EventCalculationViewModel>();

        //    ecivm.EventCalculationViewModel_ = eventCalcViewModelList;

        //    foreach (var item in excel_eventCalcViewModel_)
        //    {
        //        eventCalcViewModelList.Add(item.eventCalcVM());
        //    }

        //    return ecivm;


        //}

        public virtual void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_selectedUnderlyingViewModel_.Clear();

            this.excel_underlyingCalcInfoViewModel_ = excel_under;
            
            foreach (var item in excel_under.Excel_underlyingInfoViewModel_)
            {
                Excel_selectedUnderlyingViewModel e_suvm = new Excel_selectedUnderlyingViewModel();

                e_suvm.Code_ = item.KrCode_;
                e_suvm.NameTrans_= item.NameTrans_;
                e_suvm.Checked_ = false;

                this.excel_selectedUnderlyingViewModel_.Add(e_suvm);
            }
        }

        public virtual void selectUnderlying(string underCode)
        {
            foreach (var item in this.excel_selectedUnderlyingViewModel_)
            {
                if (item.Code_ == underCode)
                {
                    item.Checked_ = true;
                }
            }
        }

        public virtual void selectUnderlyings(string underCodes)
        {
            string[] underCodeList = underCodes.Split(',', '|');

            foreach (var item in underCodeList)
            {
                foreach (var item2 in this.excel_selectedUnderlyingViewModel_)
                {
                    if (item2.Code_ == item)
                    {
                        item2.Checked_ = true;
                    }
                }    
            }
            
        }

        public abstract void defaultSetting();

    }
    
}

