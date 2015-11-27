using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Xml;
using XmlBuilder.Views.StructuredProduct.View.PayoffCtrl;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class PayoffViewModel : IXmlBuild
    {
        //private FpmlSerializedCSharp.PayoffBase payoffBase;

        public PayoffViewModel(FpmlSerializedCSharp.PayoffCalculation serial_pc)
        {
            // TODO: Complete member initialization
            this.serial_pc_ = serial_pc;
            this.buildFromSerialClass();
        }

        private void setDetailCtrl(string type)
        {
            if (type == "Return")
            {

            }
            else if (type == "Minimum")
            {

            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {

            xmlWriter.WriteStartElement("payoffCalculation");

                this.viewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();

        }

        private void buildFromSerialClass()
        {

            if (serial_pc_ == null)
            {
                this.type_ = "Null";
            }
            else if (serial_pc_.ConstPayoff_ != null || serial_pc_.constPayoffIDRef_ != null)
            {
                this.type_ = "Const";

                ConstPayoffCtrlModel ccm = new ConstPayoffCtrlModel(serial_pc_.ConstPayoff_);
                this.viewModel_ = ccm;
                payoffDetailCtrl_ = new ConstPayoffCtrl(ccm);
            }
             
        }

        public UserControl payoffDetailCtrl_ { get; set; }


        public FpmlSerializedCSharp.PayoffCalculation serial_pc_ { get; set; }

        #region Symbol_
        private string symbol_;
        public string Symbol_
        {
            get { return this.symbol_; }
            set
            {
                if (this.symbol_ != value)
                {
                    this.symbol_ = value;
                    this.NotifyPropertyChanged("Symbol_");
                }
            }
        }
        #endregion

        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.setDetailCtrl(value);
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region RefIndex_
        private string refIndex_;
        public string RefIndex_
        {
            get { return this.refIndex_; }
            set
            {
                if (this.refIndex_ != value)
                {
                    this.refIndex_ = value;
                    this.NotifyPropertyChanged("refIndex_");
                }
            }
        }
        #endregion

        #region ViewModel_
        private IXmlBuild viewModel_;
        public IXmlBuild ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
