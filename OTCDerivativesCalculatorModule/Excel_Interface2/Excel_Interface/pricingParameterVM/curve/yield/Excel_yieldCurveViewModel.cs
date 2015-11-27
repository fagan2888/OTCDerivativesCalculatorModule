using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_yieldCurveViewModel : IXmlData , INotifyPropertyChanged
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
        
        public Excel_yieldCurveViewModel()
        {
            this.excel_interpolationViewModel_ = new Excel_interpolationViewModel();

            this.excel_rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();
        }

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region Code_
        private string code_;
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
        
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
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
        
        #region Excel_interpolationViewModel_
        private Excel_interpolationViewModel excel_interpolationViewModel_;
        public Excel_interpolationViewModel Excel_interpolationViewModel_
        {
            get { return this.excel_interpolationViewModel_; }
            set
            {
                if (this.excel_interpolationViewModel_ != value)
                {
                    this.excel_interpolationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interpolationViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_rateDataViewModel_
        private ObservableCollection<Excel_rateDataViewModel> excel_rateDataViewModel_;
        public ObservableCollection<Excel_rateDataViewModel> Excel_rateDataViewModel_
        {
            get { return this.excel_rateDataViewModel_; }
            set
            {
                if (this.excel_rateDataViewModel_ != value)
                {
                    this.excel_rateDataViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_rateDataViewModel_");
                }
            }
        }
        #endregion
        
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_yieldCurve");
                xmlWriter.WriteElementString("currency" , this.currency_);
                    
                xmlWriter.WriteElementString("code" , this.code_);
                    
                xmlWriter.WriteElementString("name" , this.name_);
                    
                xmlWriter.WriteElementString("description" , this.description_);
                    
                excel_interpolationViewModel_.buildXml(xmlWriter);

                foreach (var item in excel_rateDataViewModel_)
                {
                    item.buildXml(xmlWriter);
                }
                    
            xmlWriter.WriteEndElement();
        }

        public void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("yieldTermstructure");

            xmlWriter.WriteElementString("curveCode", this.code_);
            xmlWriter.WriteElementString("curveType", "ZEROYIELD");
            xmlWriter.WriteElementString("interpolation", this.excel_interpolationViewModel_.Interpolation_);
            xmlWriter.WriteElementString("daycounter", this.excel_interpolationViewModel_.Daycounter_);
            xmlWriter.WriteElementString("calendar", this.excel_interpolationViewModel_.Calendar_);
            xmlWriter.WriteElementString("businessDayConvention", this.excel_interpolationViewModel_.BusinessDayConvention_);

            foreach (var item in excel_rateDataViewModel_)
            {
                item.buildPricingXml(xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_yieldCurve serial_Excel_yieldCurve = serial_Class as FpmlSerializedCSharp.Excel_yieldCurve;

            this.currency_ = serial_Excel_yieldCurve.Currency_.ValueStr;

            this.code_ = serial_Excel_yieldCurve.Code_.ValueStr;

            this.name_ = serial_Excel_yieldCurve.Name_.ValueStr;

            this.description_ = serial_Excel_yieldCurve.Description_.ValueStr;

            FpmlSerializedCSharp.Excel_interpolation serial_excel_interpolation = serial_Excel_yieldCurve.Excel_interpolation_;
            this.excel_interpolationViewModel_ = new Excel_interpolationViewModel();
            this.excel_interpolationViewModel_.setFromSerial(serial_excel_interpolation);

            List<FpmlSerializedCSharp.Excel_rateData> serial_excel_rateData = serial_Excel_yieldCurve.Excel_rateData_;
            this.excel_rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();
            foreach (var item in serial_excel_rateData)
            {
                Excel_rateDataViewModel viewModel = new Excel_rateDataViewModel();
                viewModel.setFromSerial(item);
                this.excel_rateDataViewModel_.Add(viewModel);
            }
            
        }

        public void loadCurve()
        {
            this.excel_rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();

            CurveManager cm = new CurveManager();

            // 데이터를 로드함
            // cm.load(this.code_,this.referenceDate_);

            //for (int i = 0; i < cm.Tenor_.Count ; i++)
            for (int i = 0; i < 15 ; i++)
			{
                Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                e_rdvm.RateType_ = "Spot";
                //e_rdvm.Tenor_ = cm.Tenor_[i];
                e_rdvm.Tenor_ = i.ToString() + "M";
                //e_rdvm.Value_ = cm.Data_[i];
                e_rdvm.Value_ = (i * 0.01).ToString();

                this.excel_rateDataViewModel_.Add(e_rdvm);
            }

        }

        // TODO : Linear 말고 딴거는 또 구현해야함.
        public QLNet.YieldTermStructure yieldCurve()
        {
            List<QLNet.Date> dates = new List<QLNet.Date>();
            List<double> yields = new List<double>();

            foreach (var item in this.excel_rateDataViewModel_)
            {
                string tenor = item.Tenor_;

                int len = tenor.Length;

                string periodMultiplier = tenor.Substring(0, len - 1);
                string period = tenor.Substring(len - 1, 1);

                if (period == "D")
                {
                    int addDays = Convert.ToInt32(periodMultiplier);
                    dates.Add(ProgramVariable.ReferenceDate_.AddDays(addDays));
                }
                else if (period == "M")
                {
                    int addMonths = Convert.ToInt32(periodMultiplier);
                    dates.Add(ProgramVariable.ReferenceDate_.AddMonths(addMonths));
                }
                else
                {
                    throw new Exception("unknown type tenor : " + tenor);
                }

                yields.Add(Convert.ToDouble(item.Value_));

            }

            QLNet.DayCounter dc = new QLNet.Actual365Fixed();

            QLNet.InterpolatedZeroCurve<QLNet.Linear> curve = new QLNet.InterpolatedZeroCurve<QLNet.Linear>(
                dates, yields, dc, new QLNet.Linear());

            return curve;
        }

        public void loadMarketData(DateTime referenceDate)
        {
            this.excel_rateDataViewModel_.Clear();

            Excel_rateDataViewModel e_rdvm1 = new Excel_rateDataViewModel();

            e_rdvm1.Value_ = "0.02";

            this.excel_rateDataViewModel_.Add(e_rdvm1);

            Excel_rateDataViewModel e_rdvm2 = new Excel_rateDataViewModel();

            e_rdvm2.Value_ = "0.03";

            this.excel_rateDataViewModel_.Add(e_rdvm2);
        }

        public string curveInfo()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Interpolation : " + this.excel_interpolationViewModel_.Interpolation_);

            foreach (var item in this.excel_rateDataViewModel_)
            {
                sb.AppendLine(item.Tenor_ + " , " + item.Value_);
            }

            return sb.ToString();
        }

        public bool hasTenor(string tenor)
        {

            foreach (var item in this.excel_rateDataViewModel_)
	        {
                if (item.Tenor_ == tenor)
                {
                    return true;
                }
        	}

            return false;
        }

        public void loadCurve(string constRate)
        {
            this.excel_rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();

            CurveManager cm = new CurveManager();

            // 데이터를 로드함
            // cm.load(this.code_,this.referenceDate_);

            //for (int i = 0; i < cm.Tenor_.Count ; i++)
            List<string> tenorList = new List<string>()
            {
                "1D",
                "3M",
                "6M",
                "9M",
                "12M",
                "18M",
                "24M",
                "30M",
                "36M",
                "48M",
                "60M",
                "84M",
                "120M",
                "180M",
                "240M",
                "360M"
            };

            for (int i = 0; i < tenorList.Count ; i++)
            {
                Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                e_rdvm.RateType_ = "Spot";
                //e_rdvm.Tenor_ = cm.Tenor_[i];
                e_rdvm.Tenor_ = tenorList[i];
                //e_rdvm.Value_ = cm.Data_[i];
                e_rdvm.Value_ = constRate;

                this.excel_rateDataViewModel_.Add(e_rdvm);
            }
        }
    }
    
}

