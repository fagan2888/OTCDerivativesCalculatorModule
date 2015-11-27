using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiAsset_upInOutCallViewModel : Excel_multiAsset_compositeOption_subtypeViewModel
    {
        public enum InOutEnum
        {
            In,
            Out
        };

        public Excel_multiAsset_upInOutCallViewModel()
        {
            this.excel_Type_ = "excel_multiAsset_upInOutCall";
            this.inOut_ = InOutEnum.Out;
            this.partiRate_ = "100";
        }

        #region InOut_
        private InOutEnum? inOut_;
        public InOutEnum? InOut_
        {
            get { return this.inOut_; }
            set
            {
                if (this.inOut_ != value)
                {
                    this.inOut_ = value;
                    this.NotifyPropertyChanged("InOut_");
                }
            }
        }
        #endregion
        
        #region BaseCoupon_
        private string baseCoupon_;
        public string BaseCoupon_
        {
            get { return this.baseCoupon_; }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                    this.NotifyPropertyChanged("BaseCoupon_");
                }
            }
        }
        #endregion
        
        #region Strike_
        private string strike_;
        public string Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion
        
        //#region StrikeValue_
        //private string strikeValue_;
        //public string StrikeValue_
        //{
        //    get { return this.strikeValue_; }
        //    set
        //    {
        //        if (this.strikeValue_ != value)
        //        {
        //            this.strikeValue_ = value;
        //            this.NotifyPropertyChanged("StrikeValue_");
        //        }
        //    }
        //}
        //#endregion
        
        #region PartiRate_
        private string partiRate_;
        public string PartiRate_
        {
            get { return this.partiRate_; }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                    this.NotifyPropertyChanged("PartiRate_");
                }
            }
        }
        #endregion
        
        #region Barrier_
        private string barrier_;
        public string Barrier_
        {
            get { return this.barrier_; }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                    this.NotifyPropertyChanged("Barrier_");
                }
            }
        }
        #endregion
        
        //#region BarrierValue_
        //private string barrierValue_;
        //public string BarrierValue_
        //{
        //    get { return this.barrierValue_; }
        //    set
        //    {
        //        if (this.barrierValue_ != value)
        //        {
        //            this.barrierValue_ = value;
        //            this.NotifyPropertyChanged("BarrierValue_");
        //        }
        //    }
        //}
        //#endregion
        
        #region RebateCoupon_
        private string rebateCoupon_;
        public string RebateCoupon_
        {
            get { return this.rebateCoupon_; }
            set
            {
                if (this.rebateCoupon_ != value)
                {
                    this.rebateCoupon_ = value;
                    this.NotifyPropertyChanged("RebateCoupon_");
                }
            }
        }
        #endregion
        
        #region RebateCouponValue_
        private string rebateCouponValue_;
        public string RebateCouponValue_
        {
            get { return this.rebateCouponValue_; }
            set
            {
                if (this.rebateCouponValue_ != value)
                {
                    this.rebateCouponValue_ = value;
                    this.NotifyPropertyChanged("RebateCouponValue_");
                }
            }
        }
        #endregion

        #region BarrierUnderlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel barrierUnderlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel BarrierUnderlyingCalcIDViewModel_
        {
            get { return this.barrierUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.barrierUnderlyingCalcIDViewModel_ != value)
                {
                    this.barrierUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion

        #region ReturnUnderlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel returnUnderlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel ReturnUnderlyingCalcIDViewModel_
        {
            get { return this.returnUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.returnUnderlyingCalcIDViewModel_ != value)
                {
                    this.returnUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion

        #region ObservationStartDate_
        private DateTime observationStartDate_;
        public DateTime ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion

        #region ObservationEndDate_
        private DateTime observationEndDate_;
        public DateTime ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion

        // 여기서 데이터 입출력을 하고 BARRIER 랑 RETURN에서 처리함

        //#region Excel_underlyingCalcIDViewModel_
        //private ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDViewModel_;
        //public ObservableCollection<Excel_underlyingCalcIDViewModel> Excel_underlyingCalcIDViewModel_
        //{
        //    get { return this.excel_underlyingCalcIDViewModel_; }
        //    set
        //    {
        //        if (this.excel_underlyingCalcIDViewModel_ != value)
        //        {
        //            this.excel_underlyingCalcIDViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
        //        }
        //    }
        //}
        //#endregion

        public override void DefaultSetting(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            this.inOut_ = InOutEnum.Out;
            this.baseCoupon_ = "0.0";
            this.strike_ = "100.0";

            this.returnUnderlyingCalcIDViewModel_ = new Excel_minimumUnderlyingCalcIDViewModel();
            //this.returnUnderlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            //this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_ / 100.0;
            this.partiRate_ = "100.0";
            this.barrier_ = "120.0";

            this.barrierUnderlyingCalcIDViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();
            //this.barrierUnderlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            //this.barrierValue_ = Convert.ToDouble(this.barrier_) * this.baseUnderlyingValue_ / 100.0;
            this.rebateCoupon_ = "0.0";
            this.rebateCouponValue_ = "0.0";

            this.observationStartDate_ = e_mcovm.Excel_issueInfoViewModel_.EffectiveDate_;
            this.observationEndDate_ = e_mcovm.Excel_issueInfoViewModel_.MaturityDate_;

        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_multiAsset_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_multiAsset_upInOutCall");
                xmlWriter.WriteStartElement("excel_multiAsset_upInOutCall");

                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("inOut" , this.inOut_.ToString() );
                    xmlWriter.WriteElementString("baseCoupon", (Convert.ToDouble(this.baseCoupon_) / 100.0).ToString() );
                    xmlWriter.WriteElementString("strike" , (Convert.ToDouble(this.strike_)/100.0).ToString() );
                    //xmlWriter.WriteElementString("strikeValue" , this.strikeValue_);
                    xmlWriter.WriteElementString("partiRate" , (Convert.ToDouble(this.partiRate_)/100.0).ToString() );
                    xmlWriter.WriteElementString("barrier" , (Convert.ToDouble(this.barrier_)/100.0).ToString() );
                    //xmlWriter.WriteElementString("barrierValue" , this.barrierValue_);
                    xmlWriter.WriteElementString("rebateCoupon", (Convert.ToDouble(this.rebateCoupon_) / 100.0).ToString());
                    xmlWriter.WriteElementString("rebateCouponValue" , this.rebateCouponValue_);

                    this.barrierUnderlyingCalcIDViewModel_.AttributeValue_ = "barrierCalc";
                    this.barrierUnderlyingCalcIDViewModel_.buildXml(xmlWriter);

                    this.returnUnderlyingCalcIDViewModel_.AttributeValue_ = "returnCalc";
                    this.returnUnderlyingCalcIDViewModel_.buildXml(xmlWriter);

                    xmlWriter.WriteElementString("observationStartDate", this.observationStartDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("observationEndDate", this.observationEndDate_.ToString(StringFormat.XmlDateFormat_));


                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype serial_Excel_multiAsset_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_multiAsset_upInOutCall serial_Excel_multiAsset_upInOutCall = serial_Excel_multiAsset_compositeOption_subtype.Excel_multiAsset_upInOutCall_;
        
            this.inOut_ = Enum.Parse(typeof(InOutEnum), serial_Excel_multiAsset_upInOutCall.InOut_.ValueStr) as InOutEnum?;
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_upInOutCall.ExerciseDate_.ValueStr);
            //this.baseUnderlyingValue_ = serial_Excel_multiAsset_upInOutCall.BaseUnderlyingValue_.DoubleValue();
            this.baseCoupon_ = ( serial_Excel_multiAsset_upInOutCall.BaseCoupon_.DoubleValue() * 100.0).ToString();
            this.strike_ = ( serial_Excel_multiAsset_upInOutCall.Strike_.DoubleValue() * 100.0).ToString();
            //this.strikeValue_ = serial_Excel_multiAsset_upInOutCall.StrikeValue_.ValueStr;
            this.partiRate_ = ( serial_Excel_multiAsset_upInOutCall.PartiRate_.DoubleValue() * 100.0).ToString();
            this.barrier_ = ( serial_Excel_multiAsset_upInOutCall.Barrier_.DoubleValue() * 100.0).ToString();
            //this.barrierValue_ = serial_Excel_multiAsset_upInOutCall.BarrierValue_.ValueStr;
            this.rebateCoupon_ = (serial_Excel_multiAsset_upInOutCall.RebateCoupon_.DoubleValue() * 100.0).ToString();
            this.rebateCouponValue_ = serial_Excel_multiAsset_upInOutCall.RebateCouponValue_.ValueStr;

            List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Excel_multiAsset_upInOutCall.Excel_underlyingCalcID_;
            //this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();

            string barrierType = serial_excel_underlyingCalcID[0].Excel_type_.ValueStr;
            Excel_underlyingCalcIDViewModel barrier_viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(barrierType);
            barrier_viewModel.setFromSerial(serial_excel_underlyingCalcID[0]);
            //this.excel_underlyingCalcIDViewModel_.Add(barrier_viewModel);
            barrierUnderlyingCalcIDViewModel_ = barrier_viewModel;

            //returnCalcID
            string returnType = serial_excel_underlyingCalcID[1].Excel_type_.ValueStr;
            Excel_underlyingCalcIDViewModel return_viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(returnType);
            return_viewModel.setFromSerial(serial_excel_underlyingCalcID[1]);
            //this.excel_underlyingCalcIDViewModel_.Add(return_viewModel);
            returnUnderlyingCalcIDViewModel_ = return_viewModel;

            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_upInOutCall.ObservationStartDate_.ValueStr);
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_upInOutCall.ObservationEndDate_.ValueStr);

            this.descriptionUpdate();
        }

        public override Excel_multiAsset_compositeOption_subtypeViewModel Clone()
        {
            Excel_multiAsset_upInOutCallViewModel clone = new Excel_multiAsset_upInOutCallViewModel();

            clone.Excel_underlyingCalcInfoViewModel_ = this.excel_underlyingCalcInfoViewModel_;

            clone.ExerciseDate_ = this.exerciseDate_;
            clone.PayoffDate_ = this.payoffDate_;
            clone.InOut_ = this.inOut_;
            //clone.BaseUnderlyingValue_ = this.baseUnderlyingValue_;
            clone.partiRate_ = this.partiRate_;
            clone.BaseCoupon_ = this.baseCoupon_;
            clone.Strike_ = this.strike_;
            //clone.StrikeValue_ = this.strikeValue_;
            clone.Barrier_ = this.barrier_;
            //clone.BarrierValue_ = this.BarrierValue_;
            clone.RebateCoupon_ = this.rebateCoupon_;
            clone.RebateCouponValue_ = this.rebateCouponValue_;

            clone.ReturnUnderlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(this.returnUnderlyingCalcIDViewModel_.Excel_type_);
            clone.ReturnUnderlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            clone.BarrierUnderlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(this.barrierUnderlyingCalcIDViewModel_.Excel_type_);
            clone.BarrierUnderlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            clone.ObservationStartDate_ = this.observationStartDate_;
            clone.ObservationEndDate_ = this.observationEndDate_;

            this.descriptionUpdate();

            clone.Description_ = this.description_;

            return clone;
        }

        public override void descriptionUpdate()
        {
            if (this.inOut_ == InOutEnum.Out)
            {
                this.Type_ = "Up Out Call";
            }
            else if (this.inOut_ == InOutEnum.In)
            {
                this.Type_ = "Up In Call";
            }
            else
            {
                this.Type_ = "unknown";
            }

            this.description_ = "Barrier " + this.barrier_ + " Call" + this.strike_ + " " + this.InOut_;
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_multiAsset_upInOutCallView();

            v.DataContext = this;

            return v;

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                          EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_TYPE_ = "multiAssetcompositeOptionSubTypeTest";
            dao.EVENT_NAME_ = "multi_upInOutCall";
        }

        //// 이놈을 쓸건지
        //public void underlyingInfoChangeObserver()
        //{
        //    Excel_underlyingCalcInfoViewModel excel_under = new Excel_underlyingCalcInfoViewModel();

        //    this.barrierUnderlyingCalcIDViewModel_.setUnderlying(excel_under);
        //    this.returnUnderlyingCalcIDViewModel_.setUnderlying(excel_under);
        //}

        // 이놈을 쓸건지 결정해야함
        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.barrierUnderlyingCalcIDViewModel_.setUnderlying(excel_under);
            this.returnUnderlyingCalcIDViewModel_.setUnderlying(excel_under);

        }

        public override Excel_multiAssetCompositeOptionLoaderView loaderView(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            Excel_multiAssetCompositeOptionLoaderView subTypeLoaderView = new Excel_multiAssetCompositeOptionLoaderView();

            subTypeLoaderView.initialize(this);

            subTypeLoaderView.InterfaceViewModel_ = e_mcovm;

            this.excel_underlyingCalcInfoViewModel_ = e_mcovm.Excel_underlyingCalcInfoViewModel_;

            subTypeLoaderView.selectedOptionGrid_.Children.Add(this.view());

            return subTypeLoaderView;
        }


        public override void setInterfaceViewModel(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            this.exerciseDate_ = e_mcovm.Excel_issueInfoViewModel_.MaturityDate_;
            this.payoffDate_ = e_mcovm.PayoffDate_;

            this.observationStartDate_ = e_mcovm.Excel_issueInfoViewModel_.EffectiveDate_;
            this.observationEndDate_ = e_mcovm.Excel_issueInfoViewModel_.MaturityDate_;

            this.returnUnderlyingCalcIDViewModel_.EventDate_ = this.exerciseDate_;
            this.barrierUnderlyingCalcIDViewModel_.EventDate_ = this.exerciseDate_;
            
            //this.DefaultSetting(e_mcovm);
        }
    }
    
}

