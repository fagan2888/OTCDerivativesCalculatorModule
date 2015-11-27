using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_underlyingModel_paraViewModel : IXmlData , INotifyPropertyChanged
    {
        public enum ModelType
        {
            GBM = 0,
            HullWhite = 1,
            Forward = 2
        };

        public static ObservableCollection<Excel_underlyingModel_paraViewModel> UnderlyingModelComboDisplayStrList_ = new ObservableCollection<Excel_underlyingModel_paraViewModel>();

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
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    
        public Excel_underlyingModel_paraViewModel() { }
    
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

        #region UnderlyingModelComboString_
        protected string underlyingModelComboString_;
        public string UnderlyingModelComboString_
        {
            get { return this.underlyingModelComboString_; }
            set
            {
                if (this.underlyingModelComboString_ != value)
                {
                    this.underlyingModelComboString_ = value;
                    this.NotifyPropertyChanged("UnderlyingModelComboString_");
                }
            }
        }
        #endregion

        #region SelectedIndex_
        protected int selectedIndex_;
        public int SelectedIndex_
        {
            get { return this.selectedIndex_; }
            set
            {
                if (this.selectedIndex_ != value)
                {
                    this.selectedIndex_ = value;
                    this.NotifyPropertyChanged("SelectedIndex_");
                }
            }
        }
        #endregion

        #region Code_
        protected string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion

        #region CurrentValue_
        protected string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
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
                return this.description(); 
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

        //#region Vba_description_
        //protected string vba_description_;
        //public string Vba_description_
        //{
        //    get { return this.vba_description_; }
        //    set
        //    {
        //        if (this.vba_description_ != value)
        //        {
        //            this.vba_description_ = value;
        //            this.NotifyPropertyChanged("Vba_description_");
        //        }
        //    }
        //}
        //#endregion

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract string description();
        public abstract void parameterLoad(ParameterSettingManager parameterSettingManager);

        public static Excel_underlyingModel_paraViewModel CreateExcel_underlyingModel_para(string typeStr)
        {
            if (typeStr.ToUpper() == "EXCEL_GEOMETRICBM" || 
                typeStr.ToUpper() == "GBM")
            {
                return new Excel_geometricBMViewModel() { SelectedIndex_ = 0 };
            }
            else if ( typeStr.ToUpper() == "EXCEL_HULLWHITEONEFACTOR" ||
                      typeStr.ToUpper() == "HULLWHITEONEFACTOR")
            {
                return new Excel_hullWhiteOneFactorViewModel() { SelectedIndex_ = 1 };
            }
            else if ( typeStr.ToUpper() == "EXCEL_FORWARDMODEL" ||
                      typeStr.ToUpper() == "FORWARD")
            {
                return new Excel_forwardModelViewModel() { SelectedIndex_ = 2 };
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static void initialize_UnderlyingModelComboStringList()
        {
            Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_ = new ObservableCollection<Excel_underlyingModel_paraViewModel>();

            Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_.Add(
                Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para("excel_geometricBM"));
            Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_.Add(
                Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para("excel_hullWhiteOneFactor"));
            Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_.Add(
                Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para("excel_forwardModel"));

        }

        public abstract Excel_underlyingModel_paraViewModel Clone();

        public abstract Control view();

        //public abstract void loadMarketData(DateTime referenceDate);

        public abstract string vba_description();
    }
    
}

