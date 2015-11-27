using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    public class StandardInstBaseViewModel : InstrumentBaseViewModel
    {

        #region InstrumentViewModel_
        private InstrumentViewModel instrumentViewModel_;
        public InstrumentViewModel InstrumentViewModel_
        {
            get { return this.instrumentViewModel_; }
            set
            {
                if (this.instrumentViewModel_ != value)
                {
                    this.instrumentViewModel_ = value;
                    this.NotifyPropertyChanged("InstrumentViewModel_");
                }
            }
        }
        #endregion

        #region PricingParameterViewModel_
        private PricingParameterViewModel pricingParameterViewModel_;
        public PricingParameterViewModel PricingParameterViewModel_
        {
            get { return this.pricingParameterViewModel_; }
            set
            {
                if (this.pricingParameterViewModel_ != value)
                {
                    this.pricingParameterViewModel_ = value;
                    this.NotifyPropertyChanged("PricingParameterViewModel_");
                }
            }
        }
        #endregion

        #region PricingResultViewModel_
        private PricingResultViewModel PricingResultViewModel;
        public PricingResultViewModel PricingResultViewModel_
        {
            get { return this.PricingResultViewModel; }
            set
            {
                if (this.PricingResultViewModel != value)
                {
                    this.PricingResultViewModel = value;
                    this.NotifyPropertyChanged("PricingResultViewModel_");
                }
            }
        }
        #endregion

        public StandardInstBaseViewModel(InstUriInfo instUri) 
            : base(instUri)
        {
            this.view_ = new StandardInstBaseView();
            //this.view_.DataContext = this;
        }

        protected override string calculateImpl()
        {
            //this.InstrumentViewModel_.calculate();

            string result = StepDownCppDLL.calculationLibCall(
                                            this.InstXml_.InnerXml,
                                            this.ParaResultXml_.InnerXml);

            this.ParaResultXml_.LoadXml(result);

            XmlNode paraNode = ParaResultXml_.SelectSingleNode("parameter");
            XmlNode resultNode = ParaResultXml_.SelectSingleNode("result");

            PricingParameterViewModel_.setFromXml(paraNode);
            PricingResultViewModel_.setFromXml(resultNode);

            return result;
        }

        protected override void buildInstrumentXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("instrument");

            this.instPositionInfoViewModel_.buildXml(xmlWriter);
            InstrumentViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();
        }

        protected override void buildParaResultXml(XmlWriter xmlWriter)
        {
            PricingParameterViewModel_.buildXml(xmlWriter);
            PricingResultViewModel_.buildXml(xmlWriter);
        }

        protected override void buildParaXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("pricing");
                xmlWriter.WriteElementString("evaluationTime",this.ReferenceDate_.ToString("yyyy-MM-dd"));
                xmlWriter.WriteElementString("itemCode", this.itemCode_);
                xmlWriter.WriteElementString("itemType", this.ItemType_);

                xmlWriter.WriteStartElement("pricingParameter");

                PricingParameterViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        protected override void loadInstrumentFromXml(XmlNode node)
        {
            //event를 받아서 할거라 constructor 로 올림
            this.view_.DataContext = this;

            //string 
            FpmlSerializedCSharp.Root serial_root = new FpmlSerializedCSharp.Root(node);
            FpmlSerializedCSharp.InstrumentInfo serial_instInfo = serial_root.Instrument_.InstrumentInfo_;
            //FpmlSerializedCSharp.InstPositionInfo serial_instPositionInfo = serial_root.Instrument_.InstPositionInfo_;

            InstrumentViewModel vm1 = InstrumentViewModel.CreateInstVM(serial_instInfo);
            vm1.setFromSerial(serial_instInfo);

            //InstPositionInfoViewModel vm2 = new InstPositionInfoViewModel();
            //vm2.setFromSerial(serial_instPositionInfo);

            this.InstrumentViewModel_ = vm1;
            //this.InstPositionInfoViewModel_ = vm2;

            //InstrumentViewModel_.setFromXml(node);
        }

        protected override void loadParaResultFromXml(XmlNode node)
        {
            FpmlSerializedCSharp.ParaRoot serial_paraRoot = new FpmlSerializedCSharp.ParaRoot(node);
            FpmlSerializedCSharp.Pricing serial_pricing = serial_paraRoot.Pricing_;

            FpmlSerializedCSharp.Excel_parameter serial_pricingPara = serial_pricing.Excel_parameter_;
            //FpmlSerializedCSharp.PricingResult serial_pricingResult = serial_pricing.;

            PricingParameterViewModel vm1 = PricingParameterViewModel.CreatePricingParameter(serial_pricingPara);
            vm1.setFromSerial(serial_pricingPara);
            this.PricingParameterViewModel_ = vm1;

            //PricingResultViewModel vm2 = PricingResultViewModel.CreatePricingResult(serial_pricingResult);
            //vm2.setFromSerial(serial_pricingResult);
            //this.PricingResultViewModel_ = vm2;

            //this.view_ = new StandardInstBaseView();
        }

        public override void loadSampleParaResult()
        {
            string paraTypeStr = "standard_para";
            this.pricingParameterViewModel_ = PricingParameterViewModel.CreatePricingParameter(paraTypeStr);

            this.pricingParameterViewModel_.initializeParameter(this.instrumentViewModel_);

        }



    }
}
